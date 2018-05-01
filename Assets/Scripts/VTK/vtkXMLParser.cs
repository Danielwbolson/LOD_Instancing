

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLParser : vtkObject {

// static vtkXMLParser* New()
// "static vtkXMLParser* New()"
public new static vtkXMLParser New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLParser.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkTypeInt64 TellG()
// "vtkTypeInt64 TellG()"
public new long TellG() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkXMLParser.TellG_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SeekG(vtkTypeInt64 position)
// "void SeekG(vtkTypeInt64 position)"
public new void SeekG(long /*(vtkTypeInt64)*/ position) {
	API_vtkXMLParser.SeekG_0(this, position);
}


// virtual int Parse()
// "virtual int Parse()"
public new int Parse() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLParser.Parse_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int Parse(const char * inputString)
// "virtual int Parse(const char* inputString)"
public new int Parse(char /*(char*)*/ []inputString) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLParser.Parse_1(this, returnPointer, inputString);
	return Ptr.deref(returnPointer);
}


// virtual int Parse(const char * inputString, unsigned int length)
// "virtual int Parse(const char* inputString, unsigned int length)"
public new int Parse(char /*(char*)*/ []inputString, uint /*(int)*/ length) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLParser.Parse_2(this, returnPointer, inputString, length);
	return Ptr.deref(returnPointer);
}


// virtual int InitializeParser()
// "virtual int InitializeParser()"
public new int InitializeParser() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLParser.InitializeParser_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int ParseChunk(const char * inputString, unsigned int length)
// "virtual int ParseChunk(const char* inputString, unsigned int length)"
public new int ParseChunk(char /*(char*)*/ []inputString, uint /*(int)*/ length) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLParser.ParseChunk_0(this, returnPointer, inputString, length);
	return Ptr.deref(returnPointer);
}


// virtual int CleanupParser()
// "virtual int CleanupParser()"
public new int CleanupParser() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLParser.CleanupParser_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
