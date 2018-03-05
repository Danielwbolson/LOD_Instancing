using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;


namespace MinVR {

public class VRNetClient {
	
	// unique identifiers for different network messages
	static readonly byte[] INPUT_EVENTS_MSG = new byte[] {1};
	static readonly byte[] SWAP_BUFFERS_REQUEST_MSG = new byte[] {2};
	static readonly byte[] SWAP_BUFFERS_NOW_MSG = new byte[] {3};
	
	TcpClient client;
	NetworkStream stream;

	public VRNetClient(string serverIP, int serverPort) {
		try {
			// currently only supports IPv4!!!
			client = new TcpClient(AddressFamily.InterNetwork);
			client.Connect(IPAddress.Parse(serverIP), serverPort);
			stream = client.GetStream();
		} 
		catch (ArgumentNullException e) {
			Debug.Log(String.Format("ArgumentNullException: {0}", e));
			Console.WriteLine("ArgumentNullException: {0}", e);
		} 
		catch (SocketException e) {
			Debug.Log(String.Format("SocketException: {0}", e));
			Console.WriteLine("SocketException: {0}", e);
		}
	}
	
	~VRNetClient() {
		try {
			// Close everything.
			stream.Close();         
			client.Close();         
		} 
		catch (ArgumentNullException e) {
			Console.WriteLine("ArgumentNullException: {0}", e);
		} 
		catch (SocketException e) {
			Console.WriteLine("SocketException: {0}", e);
		}
	}

	public void SynchronizeInputEventsAcrossAllNodes(ref List<VREvent> inputEvents) {
		// 1. send inputEvents to server
		SendInputEvents(ref inputEvents);
		
		// 2. receive and parse serverInputEvents
		List<VREvent> serverInputEvents = new List<VREvent>();
		WaitForAndReceiveInputEvents(ref serverInputEvents);
		
		// 3. inputEvents = serverInputEvents
		inputEvents = serverInputEvents;
	}
	
	public void SynchronizeSwapBuffersAcrossAllNodes() {
		// 1. send a swap_buffers_request message to the server
		SendSwapBuffersRequest();
		
		// 2. wait for and receive a swap_buffers_now message from the server
		WaitForAndReceiveSwapBuffersNow();
	}
	
	void SendSwapBuffersRequest() {
		// this message consists only of a 1-byte header
		stream.Write(SWAP_BUFFERS_REQUEST_MSG, 0, 1);
	}

	void SendInputEvents(ref List<VREvent> inputEvents) {   
		// 1. send 1-byte message header
		stream.Write(INPUT_EVENTS_MSG, 0, 1);

		// 2. create an XML-formatted string to hold all the inputEvents
		string xmlEvents = "<VREventList num=\"" + inputEvents.Count + "\">";
		foreach (VREvent inputEvent in inputEvents) {
			xmlEvents += inputEvent.ToXML();
		}
		xmlEvents += "</VREventList>";

		// 3. send the size of the message data so receive will know how many bytes to expect
		WriteInt32(xmlEvents.Length);

		// 4. send the chars that make up xmlEvents string
		byte[] bytes = Encoding.ASCII.GetBytes(xmlEvents);
		stream.Write(bytes, 0, bytes.Length);
	}


	
	void WaitForAndReceiveMessageHeader(byte [] messageID) {
		byte[] receivedID = new byte[1];
		while (receivedID[0] != messageID[0]) {
			int status = stream.Read(receivedID, 0, 1);
			if (status == -1) {
				Console.WriteLine("WaitForAndReceiveMessageHeader failed");
			}
			else if ((status == 1) && (receivedID[0] != messageID[0])) {
				Console.WriteLine("WaitForAndReceiveMessageHeader error: expected {0} got {1}", messageID[0], receivedID[0]);
			}
		}
	}
	
	void WaitForAndReceiveSwapBuffersRequest() {
		// this message consists only of a 1-byte header
		WaitForAndReceiveMessageHeader(SWAP_BUFFERS_REQUEST_MSG);
	}
	
	void WaitForAndReceiveSwapBuffersNow() {
		// this message consists only of a 1-byte header
		WaitForAndReceiveMessageHeader(SWAP_BUFFERS_NOW_MSG);
	}
		
	void WaitForAndReceiveInputEvents(ref List<VREvent> inputEvents) {
		// 1. receive 1-byte message header
		WaitForAndReceiveMessageHeader(INPUT_EVENTS_MSG);
		
		// 2. receive int that tells us the size of the data portion of the message in bytes
		Int32 dataSize = ReadInt32();
				
		// 3. receive dataSize bytes, then decode these as InputEvents
		byte[] buf2 = new byte[dataSize+1];
		int status = ReceiveAll(ref buf2, dataSize);
		if (status == -1) {
			Console.WriteLine("WaitForAndReceiveInputEvents error reading data");
			return;
		}
		buf2[dataSize] = 0;

		// buf2 is the XML string that contains all the events.
		string xmlEventList = System.Text.Encoding.UTF8.GetString(buf2);
		//Debug.Log(xmlEventList);

		Dictionary<string, string> props = new Dictionary<string, string>();
		string xmlEvents = string.Empty;
		string leftover = string.Empty;
		bool success = XMLUtils.GetXMLField(xmlEventList, "VREventList", ref props, ref xmlEvents, ref leftover);
		if (!success) {
			Debug.Log("Error decoding VREventList");
			return;
		} 
		int nEvents = Convert.ToInt32(props["num"]);
		for (int i=0; i<nEvents; i++) {
			// Create the next VREvent from the XML description
			VREvent e = new VREvent(ref xmlEvents);
			inputEvents.Add(e);
		}
	}

	int ReceiveAll(ref byte[] buf, int len) {
		int total = 0;        // how many bytes we've received
		int bytesleft = len; // how many we have left to receive
		int n;    
		while (total < len) {
			n = stream.Read(buf, total, bytesleft);
			// TODO: Catch exceptions
			total += n;
			bytesleft -= n;
		}
		return total; // return -1 on failure, total on success
	}

	
	void WriteInt32(Int32 i) {
		if (!BitConverter.IsLittleEndian) {
			i = SwapEndianness(i);
		}
		byte[] buf = BitConverter.GetBytes(i);
		stream.Write(buf, 0, 4);
	}

	Int32 ReadInt32() {
		byte[] buf = new byte[4];
		int status = ReceiveAll(ref buf, 4);
		if (status == -1) {
			Console.WriteLine("ReadInt32() error reading data");
			return 0;
		}
		Int32 i = BitConverter.ToInt32(buf, 0);
		if (!BitConverter.IsLittleEndian) {
			i = SwapEndianness(i);
		}
		return i;
	}

	static Int32 SwapEndianness(Int32 value) {
		var b1 = (value >> 0) & 0xff;
		var b2 = (value >> 8) & 0xff;
		var b3 = (value >> 16) & 0xff;
		var b4 = (value >> 24) & 0xff;		
		return b1 << 24 | b2 << 16 | b3 << 8 | b4 << 0;
	}	
}

} // namespace MinVR
