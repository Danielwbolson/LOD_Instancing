

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLParser : vtkObject {
		public vtkXMLParser(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLParser(IntPtr p) {return new vtkXMLParser(p);}
		public static implicit operator  IntPtr(vtkXMLParser o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkXMLParser.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkXMLParser.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkXMLParser* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLParser* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLParser SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkXMLParser.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkXMLParser)(IntPtr)returnPointer;
}


// vtkXMLParser* NewInstance()
// "vtkXMLParser *NewInstance()"
public vtkXMLParser NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkXMLParser.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkXMLParser)(IntPtr)returnPointer;
}


// static vtkXMLParser* New()
// "static vtkXMLParser* New()"
public static vtkXMLParser New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkXMLParser.New_0(returnPointer.GetPtr());
	return (vtkXMLParser)(IntPtr)returnPointer;
}


// virtual void SetStream(istream * _arg)
// "virtual void SetStream (istream* _arg)"
public void SetStream(IntPtr /*(istream*)*/ _arg) {
	VTK_API.API_vtkXMLParser.SetStream_0(this, _arg);
}


// virtual istream* GetStream()
// "virtual istream* GetStream ()"
public IntPtr GetStream() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkXMLParser.GetStream_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// vtkTypeInt64 TellG()
// "vtkTypeInt64 TellG()"
public long TellG() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkXMLParser.TellG_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void SeekG(vtkTypeInt64 position)
// "void SeekG(vtkTypeInt64 position)"
public void SeekG(long /*(vtkTypeInt64)*/ position) {
	VTK_API.API_vtkXMLParser.SeekG_0(this, position);
}


// virtual int Parse()
// "virtual int Parse()"
public int Parse() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkXMLParser.Parse_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int Parse(const char * inputString)
// "virtual int Parse(const char* inputString)"
public int Parse(string /*(char*)*/ inputString) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkXMLParser.Parse_1(returnPointer.GetPtr(), this, inputString);
	return (int)returnPointer;
}


// virtual int Parse(const char * inputString, unsigned int length)
// "virtual int Parse(const char* inputString, unsigned int length)"
public int Parse(string /*(char*)*/ inputString, uint /*(unsigned int)*/ length) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkXMLParser.Parse_2(returnPointer.GetPtr(), this, inputString, length);
	return (int)returnPointer;
}


// virtual int InitializeParser()
// "virtual int InitializeParser()"
public int InitializeParser() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkXMLParser.InitializeParser_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int ParseChunk(const char * inputString, unsigned int length)
// "virtual int ParseChunk(const char* inputString, unsigned int length)"
public int ParseChunk(string /*(char*)*/ inputString, uint /*(unsigned int)*/ length) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkXMLParser.ParseChunk_0(returnPointer.GetPtr(), this, inputString, length);
	return (int)returnPointer;
}


// virtual int CleanupParser()
// "virtual int CleanupParser()"
public int CleanupParser() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkXMLParser.CleanupParser_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetFileName(const char * _arg)
// "virtual void SetFileName (const char* _arg)"
public void SetFileName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkXMLParser.SetFileName_0(this, _arg);
}


// virtual char* GetFileName()
// "virtual char* GetFileName ()"
public string GetFileName() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkXMLParser.GetFileName_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual void SetIgnoreCharacterData(int _arg)
// "virtual void SetIgnoreCharacterData (int _arg)"
public void SetIgnoreCharacterData(int /*(int)*/ _arg) {
	VTK_API.API_vtkXMLParser.SetIgnoreCharacterData_0(this, _arg);
}


// virtual int GetIgnoreCharacterData()
// "virtual int GetIgnoreCharacterData ()"
public int GetIgnoreCharacterData() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkXMLParser.GetIgnoreCharacterData_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetEncoding(const char * _arg)
// "virtual void SetEncoding (const char* _arg)"
public void SetEncoding(string /*(char*)*/ _arg) {
	VTK_API.API_vtkXMLParser.SetEncoding_0(this, _arg);
}


// virtual char* GetEncoding()
// "virtual char* GetEncoding ()"
public string GetEncoding() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkXMLParser.GetEncoding_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


}
};
