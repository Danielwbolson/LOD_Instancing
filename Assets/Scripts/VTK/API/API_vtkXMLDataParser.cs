
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLDataParser {

// static vtkXMLDataParser* New()
// static vtkXMLDataParser* New()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataParser_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// vtkXMLDataElement* GetRootElement()
// vtkXMLDataElement* GetRootElement()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataParser_GetRootElement_0")] public static extern 
bool GetRootElement_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataParser*)*/ callingObject);

// size_t ReadInlineData(vtkXMLDataElement * element, int isAscii, void * buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
// size_t ReadInlineData(vtkXMLDataElement* element, int isAscii, void* buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataParser_ReadInlineData_0")] public static extern 
bool ReadInlineData_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataParser*)*/ callingObject, IntPtr /*(vtkXMLDataElement*)*/ element, int /*(int)*/ isAscii, IntPtr /*(void*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords, int /*(int)*/ wordType);

// size_t ReadInlineData(vtkXMLDataElement * element, int isAscii, char * buffer, vtkTypeUInt64 startWord, size_t numWords)
// size_t ReadInlineData(vtkXMLDataElement* element, int isAscii, char* buffer, vtkTypeUInt64 startWord, size_t numWords)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataParser_ReadInlineData_1")] public static extern 
bool ReadInlineData_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataParser*)*/ callingObject, IntPtr /*(vtkXMLDataElement*)*/ element, int /*(int)*/ isAscii, string /*(char*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords);

// size_t ReadAppendedData(vtkTypeInt64 offset, void * buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
// size_t ReadAppendedData(vtkTypeInt64 offset, void* buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataParser_ReadAppendedData_0")] public static extern 
bool ReadAppendedData_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataParser*)*/ callingObject, long /*(vtkTypeInt64)*/ offset, IntPtr /*(void*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords, int /*(int)*/ wordType);

// size_t ReadAppendedData(vtkTypeInt64 offset, char * buffer, vtkTypeUInt64 startWord, size_t numWords)
// size_t ReadAppendedData(vtkTypeInt64 offset, char* buffer, vtkTypeUInt64 startWord, size_t numWords)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataParser_ReadAppendedData_1")] public static extern 
bool ReadAppendedData_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataParser*)*/ callingObject, long /*(vtkTypeInt64)*/ offset, string /*(char*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords);

// size_t ReadAsciiData(void * buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
// size_t ReadAsciiData(void* buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataParser_ReadAsciiData_0")] public static extern 
bool ReadAsciiData_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataParser*)*/ callingObject, IntPtr /*(void*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords, int /*(int)*/ wordType);

// size_t ReadBinaryData(void * buffer, vtkTypeUInt64 startWord, size_t maxWords, int wordType)
// size_t ReadBinaryData(void* buffer, vtkTypeUInt64 startWord, size_t maxWords, int wordType)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataParser_ReadBinaryData_0")] public static extern 
bool ReadBinaryData_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataParser*)*/ callingObject, IntPtr /*(void*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ maxWords, int /*(int)*/ wordType);

// virtual void SetCompressor(vtkDataCompressor * ARG_0)
// virtual void SetCompressor(vtkDataCompressor*)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataParser_SetCompressor_0")] public static extern 
bool SetCompressor_0(IntPtr /*(vtkXMLDataParser*)*/ callingObject, IntPtr /*(vtkDataCompressor*)*/ ARG_0);

// size_t GetWordTypeSize(int wordType)
// size_t GetWordTypeSize(int wordType)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataParser_GetWordTypeSize_0")] public static extern 
bool GetWordTypeSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataParser*)*/ callingObject, int /*(int)*/ wordType);

// int Parse()
// int Parse()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataParser_Parse_0")] public static extern 
bool Parse_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataParser*)*/ callingObject);

// void CharacterDataHandler(const char * data, int length)
// void CharacterDataHandler(const char* data, int length)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataParser_CharacterDataHandler_0")] public static extern 
bool CharacterDataHandler_0(IntPtr /*(vtkXMLDataParser*)*/ callingObject, string /*(char*)*/ data, int /*(int)*/ length);

// vtkTypeInt64 GetAppendedDataPosition()
// vtkTypeInt64 GetAppendedDataPosition()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataParser_GetAppendedDataPosition_0")] public static extern 
bool GetAppendedDataPosition_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataParser*)*/ callingObject);

}
};
