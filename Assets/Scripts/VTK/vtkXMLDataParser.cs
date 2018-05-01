

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLDataParser : vtkXMLParser {

// static vtkXMLDataParser* New()
// "static vtkXMLDataParser* New()"
public new static vtkXMLDataParser New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLDataParser.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkXMLDataElement* GetRootElement()
// "vtkXMLDataElement* GetRootElement()"
public new vtkXMLDataElement GetRootElement() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLDataParser.GetRootElement_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// size_t ReadInlineData(vtkXMLDataElement * element, int isAscii, void * buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
// "size_t ReadInlineData(vtkXMLDataElement* element, int isAscii, void* buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)"
public new ulong ReadInlineData(vtkXMLDataElement /*(vtkXMLDataElement*)*/ element, int /*(int)*/ isAscii, IntPtr /*(void*)*/ []buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords, int /*(int)*/ wordType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkXMLDataParser.ReadInlineData_0(this, returnPointer, element, isAscii, buffer, startWord, numWords, wordType);
	return Ptr.deref(returnPointer);
}


// size_t ReadInlineData(vtkXMLDataElement * element, int isAscii, char * buffer, vtkTypeUInt64 startWord, size_t numWords)
// "size_t ReadInlineData(vtkXMLDataElement* element, int isAscii, char* buffer, vtkTypeUInt64 startWord, size_t numWords)"
public new ulong ReadInlineData(vtkXMLDataElement /*(vtkXMLDataElement*)*/ element, int /*(int)*/ isAscii, char /*(char*)*/ []buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkXMLDataParser.ReadInlineData_1(this, returnPointer, element, isAscii, buffer, startWord, numWords);
	return Ptr.deref(returnPointer);
}


// size_t ReadAppendedData(vtkTypeInt64 offset, void * buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
// "size_t ReadAppendedData(vtkTypeInt64 offset, void* buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)"
public new ulong ReadAppendedData(long /*(vtkTypeInt64)*/ offset, IntPtr /*(void*)*/ []buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords, int /*(int)*/ wordType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkXMLDataParser.ReadAppendedData_0(this, returnPointer, offset, buffer, startWord, numWords, wordType);
	return Ptr.deref(returnPointer);
}


// size_t ReadAppendedData(vtkTypeInt64 offset, char * buffer, vtkTypeUInt64 startWord, size_t numWords)
// "size_t ReadAppendedData(vtkTypeInt64 offset, char* buffer, vtkTypeUInt64 startWord, size_t numWords)"
public new ulong ReadAppendedData(long /*(vtkTypeInt64)*/ offset, char /*(char*)*/ []buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkXMLDataParser.ReadAppendedData_1(this, returnPointer, offset, buffer, startWord, numWords);
	return Ptr.deref(returnPointer);
}


// size_t ReadAsciiData(void * buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
// "size_t ReadAsciiData(void* buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)"
public new ulong ReadAsciiData(IntPtr /*(void*)*/ []buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords, int /*(int)*/ wordType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkXMLDataParser.ReadAsciiData_0(this, returnPointer, buffer, startWord, numWords, wordType);
	return Ptr.deref(returnPointer);
}


// size_t ReadBinaryData(void * buffer, vtkTypeUInt64 startWord, size_t maxWords, int wordType)
// "size_t ReadBinaryData(void* buffer, vtkTypeUInt64 startWord, size_t maxWords, int wordType)"
public new ulong ReadBinaryData(IntPtr /*(void*)*/ []buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ maxWords, int /*(int)*/ wordType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkXMLDataParser.ReadBinaryData_0(this, returnPointer, buffer, startWord, maxWords, wordType);
	return Ptr.deref(returnPointer);
}


// virtual void SetCompressor(vtkDataCompressor * ARG_0)
// "virtual void SetCompressor(vtkDataCompressor*)"
public new void SetCompressor(vtkDataCompressor /*(vtkDataCompressor*)*/ ARG_0) {
	API_vtkXMLDataParser.SetCompressor_0(this, ARG_0);
}


// size_t GetWordTypeSize(int wordType)
// "size_t GetWordTypeSize(int wordType)"
public new ulong GetWordTypeSize(int /*(int)*/ wordType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkXMLDataParser.GetWordTypeSize_0(this, returnPointer, wordType);
	return Ptr.deref(returnPointer);
}


// int Parse()
// "int Parse()"
public new int Parse() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataParser.Parse_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void CharacterDataHandler(const char * data, int length)
// "void CharacterDataHandler(const char* data, int length)"
public new void CharacterDataHandler(char /*(char*)*/ []data, int /*(int)*/ length) {
	API_vtkXMLDataParser.CharacterDataHandler_0(this, data, length);
}


// vtkTypeInt64 GetAppendedDataPosition()
// "vtkTypeInt64 GetAppendedDataPosition()"
public new long GetAppendedDataPosition() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkXMLDataParser.GetAppendedDataPosition_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
