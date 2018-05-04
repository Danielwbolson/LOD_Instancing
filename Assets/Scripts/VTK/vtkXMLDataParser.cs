

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLDataParser : vtkXMLParser {
		public vtkXMLDataParser(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLDataParser(IntPtr p) {return new vtkXMLDataParser(p);}
		public static implicit operator  IntPtr(vtkXMLDataParser o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLDataParser.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLDataParser.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkXMLDataParser* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLDataParser* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLDataParser SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLDataParser.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkXMLDataParser)(IntPtr)returnPointer;
}


// vtkXMLDataParser* NewInstance()
// "vtkXMLDataParser *NewInstance()"
public vtkXMLDataParser NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLDataParser.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkXMLDataParser)(IntPtr)returnPointer;
}


// static vtkXMLDataParser* New()
// "static vtkXMLDataParser* New()"
public static vtkXMLDataParser New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLDataParser.New_0(returnPointer.GetPtr());
	return (vtkXMLDataParser)(IntPtr)returnPointer;
}


// vtkXMLDataElement* GetRootElement()
// "vtkXMLDataElement* GetRootElement()"
public vtkXMLDataElement GetRootElement() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLDataParser.GetRootElement_0(returnPointer.GetPtr(), this);
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// size_t ReadInlineData(vtkXMLDataElement * element, int isAscii, void * buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
// "size_t ReadInlineData(vtkXMLDataElement* element, int isAscii, void* buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)"
public ulong ReadInlineData(vtkXMLDataElement /*(vtkXMLDataElement*)*/ element, int /*(int)*/ isAscii, IntPtr /*(void*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords, int /*(int)*/ wordType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	VTK_API.API_vtkXMLDataParser.ReadInlineData_0(returnPointer.GetPtr(), this, element, isAscii, buffer, startWord, numWords, wordType);
	return (ulong)returnPointer;
}


// size_t ReadInlineData(vtkXMLDataElement * element, int isAscii, char * buffer, vtkTypeUInt64 startWord, size_t numWords)
// "size_t ReadInlineData(vtkXMLDataElement* element, int isAscii, char* buffer, vtkTypeUInt64 startWord, size_t numWords)"
public ulong ReadInlineData(vtkXMLDataElement /*(vtkXMLDataElement*)*/ element, int /*(int)*/ isAscii, string /*(char*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	VTK_API.API_vtkXMLDataParser.ReadInlineData_1(returnPointer.GetPtr(), this, element, isAscii, buffer, startWord, numWords);
	return (ulong)returnPointer;
}


// size_t ReadAppendedData(vtkTypeInt64 offset, void * buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
// "size_t ReadAppendedData(vtkTypeInt64 offset, void* buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)"
public ulong ReadAppendedData(long /*(vtkTypeInt64)*/ offset, IntPtr /*(void*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords, int /*(int)*/ wordType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	VTK_API.API_vtkXMLDataParser.ReadAppendedData_0(returnPointer.GetPtr(), this, offset, buffer, startWord, numWords, wordType);
	return (ulong)returnPointer;
}


// size_t ReadAppendedData(vtkTypeInt64 offset, char * buffer, vtkTypeUInt64 startWord, size_t numWords)
// "size_t ReadAppendedData(vtkTypeInt64 offset, char* buffer, vtkTypeUInt64 startWord, size_t numWords)"
public ulong ReadAppendedData(long /*(vtkTypeInt64)*/ offset, string /*(char*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	VTK_API.API_vtkXMLDataParser.ReadAppendedData_1(returnPointer.GetPtr(), this, offset, buffer, startWord, numWords);
	return (ulong)returnPointer;
}


// size_t ReadAsciiData(void * buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
// "size_t ReadAsciiData(void* buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)"
public ulong ReadAsciiData(IntPtr /*(void*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords, int /*(int)*/ wordType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	VTK_API.API_vtkXMLDataParser.ReadAsciiData_0(returnPointer.GetPtr(), this, buffer, startWord, numWords, wordType);
	return (ulong)returnPointer;
}


// size_t ReadBinaryData(void * buffer, vtkTypeUInt64 startWord, size_t maxWords, int wordType)
// "size_t ReadBinaryData(void* buffer, vtkTypeUInt64 startWord, size_t maxWords, int wordType)"
public ulong ReadBinaryData(IntPtr /*(void*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ maxWords, int /*(int)*/ wordType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	VTK_API.API_vtkXMLDataParser.ReadBinaryData_0(returnPointer.GetPtr(), this, buffer, startWord, maxWords, wordType);
	return (ulong)returnPointer;
}


// virtual void SetCompressor(vtkDataCompressor * ARG_0)
// "virtual void SetCompressor(vtkDataCompressor*)"
public void SetCompressor(vtkDataCompressor /*(vtkDataCompressor*)*/ ARG_0) {
	VTK_API.API_vtkXMLDataParser.SetCompressor_0(this, ARG_0);
}


// virtual vtkDataCompressor* GetCompressor()
// "virtual vtkDataCompressor *GetCompressor ()"
public vtkDataCompressor GetCompressor() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLDataParser.GetCompressor_0(returnPointer.GetPtr(), this);
	return (vtkDataCompressor)(IntPtr)returnPointer;
}


// size_t GetWordTypeSize(int wordType)
// "size_t GetWordTypeSize(int wordType)"
public ulong GetWordTypeSize(int /*(int)*/ wordType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	VTK_API.API_vtkXMLDataParser.GetWordTypeSize_0(returnPointer.GetPtr(), this, wordType);
	return (ulong)returnPointer;
}


// int Parse()
// "int Parse()"
public int Parse() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLDataParser.Parse_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetAbort()
// "virtual int GetAbort ()"
public int GetAbort() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLDataParser.GetAbort_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetAbort(int _arg)
// "virtual void SetAbort (int _arg)"
public void SetAbort(int /*(int)*/ _arg) {
	VTK_API.API_vtkXMLDataParser.SetAbort_0(this, _arg);
}


// virtual float GetProgress()
// "virtual float GetProgress ()"
public float GetProgress() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new float(), return_elements);
	VTK_API.API_vtkXMLDataParser.GetProgress_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual void SetProgress(float _arg)
// "virtual void SetProgress (float _arg)"
public void SetProgress(float /*(float)*/ _arg) {
	VTK_API.API_vtkXMLDataParser.SetProgress_0(this, _arg);
}


// virtual void SetAttributesEncoding(int _arg)
// "virtual void SetAttributesEncoding (int _arg)"
public void SetAttributesEncoding(int /*(int)*/ _arg) {
	VTK_API.API_vtkXMLDataParser.SetAttributesEncoding_0(this, _arg);
}


// virtual int GetAttributesEncodingMinValue()
// "virtual int GetAttributesEncodingMinValue ()"
public int GetAttributesEncodingMinValue() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLDataParser.GetAttributesEncodingMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetAttributesEncodingMaxValue()
// "virtual int GetAttributesEncodingMaxValue ()"
public int GetAttributesEncodingMaxValue() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLDataParser.GetAttributesEncodingMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetAttributesEncoding()
// "virtual int GetAttributesEncoding ()"
public int GetAttributesEncoding() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLDataParser.GetAttributesEncoding_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void CharacterDataHandler(const char * data, int length)
// "void CharacterDataHandler(const char* data, int length)"
public void CharacterDataHandler(string /*(char*)*/ data, int /*(int)*/ length) {
	VTK_API.API_vtkXMLDataParser.CharacterDataHandler_0(this, data, length);
}


// vtkTypeInt64 GetAppendedDataPosition()
// "vtkTypeInt64 GetAppendedDataPosition()"
public long GetAppendedDataPosition() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkXMLDataParser.GetAppendedDataPosition_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


}
};
