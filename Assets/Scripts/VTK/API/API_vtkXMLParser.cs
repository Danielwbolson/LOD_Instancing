
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLParser {

// static vtkXMLParser* New()
// static vtkXMLParser* New()
[DllImport("vtkplugin", EntryPoint="vtkXMLParser_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

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

}
};
