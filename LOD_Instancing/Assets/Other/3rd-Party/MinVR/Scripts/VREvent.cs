using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace MinVR {

/** VREvents have a Name and a DataIndex.  For exmample, an event named "Head_Move" might have
 * a DataIndex that includes a Transformation matrix to store the current head "Postion" and
 * "Orientation".
 */
public class VREvent {

	private string _name;
	private VRDataIndex _dataIndex;

	// Declare a Name property of type string
	public string Name {
		get {
			return _name; 
		}
		set {
			_name = value;
		}
	}

	// Declare a DataIndex property of type VRDataIndex
	public VRDataIndex DataIndex {
		get {
			return _dataIndex;
		}
		set {
			_dataIndex = value;
		}
	}

	// Typical constructor
	public VREvent(string name, VRDataIndex dataIndex) {
		_name = name;
		_dataIndex = dataIndex;
	}

	// Creates an event from an XML-formatted description.  xmlDescription is modified as part of the constructor.  The
	// first VREvent described <VREvent>...</VREvent> is popped off the string and xmlDescription is set to whatever
	// remains in the string.
	public VREvent(ref string xmlDescription) {
		Dictionary<string, string> props = new Dictionary<string, string>();
		string xmlDataIndex = string.Empty;
		string xmlRemaining = string.Empty;
		bool success = XMLUtils.GetXMLField(xmlDescription, "VREvent", ref props, ref xmlDataIndex, ref xmlRemaining);
		if (!success) {
			Debug.Log("Error decoding VREvent");
			return;
		} 
		_name = props["name"];
		_dataIndex = new VRDataIndex(ref xmlDataIndex);
		xmlDescription = xmlRemaining;
	}

	// Generic constructor, creates an empty event
	public VREvent() {
		_name = string.Empty;
		_dataIndex = new VRDataIndex();
	}

	// Get this VREvent in a XML form
	public string ToXML() {
		Dictionary<string, string> props = new Dictionary<string, string>();
		props.Add("name", this._name);
		return XMLUtils.WriteXMLField("VREvent", props, this._dataIndex.ToXML());
	}
}

} // namespace MinVR
