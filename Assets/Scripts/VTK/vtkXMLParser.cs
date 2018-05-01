

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLParser : vtkObject {
		public vtkXMLParser(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLParser(IntPtr p) {return new vtkXMLParser(p);}
		public static implicit operator  IntPtr(vtkXMLParser o) {return o.GetPtr();}

// static vtkXMLParser* New()
// "static vtkXMLParser* New()"
public static vtkXMLParser New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkXMLParser.New_0(returnPointer.GetPtr());
	return (vtkXMLParser)(IntPtr)returnPointer;
}


// vtkTypeInt64 TellG()
// "vtkTypeInt64 TellG()"
public long TellG() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkXMLParser.TellG_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void SeekG(vtkTypeInt64 position)
// "void SeekG(vtkTypeInt64 position)"
public void SeekG(long /*(vtkTypeInt64)*/ position) {
	API_vtkXMLParser.SeekG_0(this, position);
}


// virtual int Parse()
// "virtual int Parse()"
public int Parse() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkXMLParser.Parse_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int Parse(const char * inputString)
// "virtual int Parse(const char* inputString)"
public int Parse(string /*(char*)*/ inputString) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkXMLParser.Parse_1(returnPointer.GetPtr(), this, inputString);
	return (int)returnPointer;
}


// virtual int Parse(const char * inputString, unsigned int length)
// "virtual int Parse(const char* inputString, unsigned int length)"
public int Parse(string /*(char*)*/ inputString, uint /*(unsigned int)*/ length) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkXMLParser.Parse_2(returnPointer.GetPtr(), this, inputString, length);
	return (int)returnPointer;
}


// virtual int InitializeParser()
// "virtual int InitializeParser()"
public int InitializeParser() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkXMLParser.InitializeParser_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int ParseChunk(const char * inputString, unsigned int length)
// "virtual int ParseChunk(const char* inputString, unsigned int length)"
public int ParseChunk(string /*(char*)*/ inputString, uint /*(unsigned int)*/ length) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkXMLParser.ParseChunk_0(returnPointer.GetPtr(), this, inputString, length);
	return (int)returnPointer;
}


// virtual int CleanupParser()
// "virtual int CleanupParser()"
public int CleanupParser() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkXMLParser.CleanupParser_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


}
};
