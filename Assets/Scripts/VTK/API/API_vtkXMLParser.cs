
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkXMLParser {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLParser*)*/ callingObject, string /*(char*)*/ type);

// static vtkXMLParser* SafeDownCast(vtkObjectBase * o)
// static vtkXMLParser* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkXMLParser* NewInstance()
// vtkXMLParser *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLParser*)*/ callingObject);

// static vtkXMLParser* New()
// static vtkXMLParser* New()
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual void SetStream(istream * _arg)
// virtual void SetStream (istream* _arg)
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_SetStream_0")] public static extern 
bool SetStream_0(IntPtr /*(vtkXMLParser*)*/ callingObject, IntPtr /*(istream*)*/ _arg);

// virtual istream* GetStream()
// virtual istream* GetStream ()
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_GetStream_0")] public static extern 
bool GetStream_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLParser*)*/ callingObject);

// vtkTypeInt64 TellG()
// vtkTypeInt64 TellG()
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_TellG_0")] public static extern 
bool TellG_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLParser*)*/ callingObject);

// void SeekG(vtkTypeInt64 position)
// void SeekG(vtkTypeInt64 position)
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_SeekG_0")] public static extern 
bool SeekG_0(IntPtr /*(vtkXMLParser*)*/ callingObject, long /*(vtkTypeInt64)*/ position);

// virtual int Parse()
// virtual int Parse()
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_Parse_0")] public static extern 
bool Parse_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLParser*)*/ callingObject);

// virtual int Parse(const char * inputString)
// virtual int Parse(const char* inputString)
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_Parse_1")] public static extern 
bool Parse_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLParser*)*/ callingObject, string /*(char*)*/ inputString);

// virtual int Parse(const char * inputString, unsigned int length)
// virtual int Parse(const char* inputString, unsigned int length)
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_Parse_2")] public static extern 
bool Parse_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLParser*)*/ callingObject, string /*(char*)*/ inputString, uint /*(unsigned int)*/ length);

// virtual int InitializeParser()
// virtual int InitializeParser()
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_InitializeParser_0")] public static extern 
bool InitializeParser_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLParser*)*/ callingObject);

// virtual int ParseChunk(const char * inputString, unsigned int length)
// virtual int ParseChunk(const char* inputString, unsigned int length)
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_ParseChunk_0")] public static extern 
bool ParseChunk_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLParser*)*/ callingObject, string /*(char*)*/ inputString, uint /*(unsigned int)*/ length);

// virtual int CleanupParser()
// virtual int CleanupParser()
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_CleanupParser_0")] public static extern 
bool CleanupParser_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLParser*)*/ callingObject);

// virtual void SetFileName(const char * _arg)
// virtual void SetFileName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_SetFileName_0")] public static extern 
bool SetFileName_0(IntPtr /*(vtkXMLParser*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetFileName()
// virtual char* GetFileName ()
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_GetFileName_0")] public static extern 
bool GetFileName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLParser*)*/ callingObject);

// virtual void SetIgnoreCharacterData(int _arg)
// virtual void SetIgnoreCharacterData (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_SetIgnoreCharacterData_0")] public static extern 
bool SetIgnoreCharacterData_0(IntPtr /*(vtkXMLParser*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetIgnoreCharacterData()
// virtual int GetIgnoreCharacterData ()
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_GetIgnoreCharacterData_0")] public static extern 
bool GetIgnoreCharacterData_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLParser*)*/ callingObject);

// virtual void SetEncoding(const char * _arg)
// virtual void SetEncoding (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_SetEncoding_0")] public static extern 
bool SetEncoding_0(IntPtr /*(vtkXMLParser*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetEncoding()
// virtual char* GetEncoding ()
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_GetEncoding_0")] public static extern 
bool GetEncoding_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLParser*)*/ callingObject);

}
};
