
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkXMLReader {

// virtual int CanReadFile(const char * name)
// virtual int CanReadFile(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_CanReadFile_0")] public static extern 
bool CanReadFile_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name);

// vtkDataSet* GetOutputAsDataSet()
// vtkDataSet* GetOutputAsDataSet()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetOutputAsDataSet_0")] public static extern 
bool GetOutputAsDataSet_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// vtkDataSet* GetOutputAsDataSet(int index)
// vtkDataSet* GetOutputAsDataSet(int index)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetOutputAsDataSet_1")] public static extern 
bool GetOutputAsDataSet_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ index);

// int GetNumberOfPointArrays()
// int GetNumberOfPointArrays()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetNumberOfPointArrays_0")] public static extern 
bool GetNumberOfPointArrays_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// int GetNumberOfCellArrays()
// int GetNumberOfCellArrays()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetNumberOfCellArrays_0")] public static extern 
bool GetNumberOfCellArrays_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// int GetNumberOfColumnArrays()
// int GetNumberOfColumnArrays()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetNumberOfColumnArrays_0")] public static extern 
bool GetNumberOfColumnArrays_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// char* GetPointArrayName(int index)
// const char* GetPointArrayName(int index)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetPointArrayName_0")] public static extern 
bool GetPointArrayName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ index);

// char* GetCellArrayName(int index)
// const char* GetCellArrayName(int index)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetCellArrayName_0")] public static extern 
bool GetCellArrayName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ index);

// char* GetColumnArrayName(int index)
// const char* GetColumnArrayName(int index)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetColumnArrayName_0")] public static extern 
bool GetColumnArrayName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ index);

// int GetPointArrayStatus(const char * name)
// int GetPointArrayStatus(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetPointArrayStatus_0")] public static extern 
bool GetPointArrayStatus_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name);

// int GetCellArrayStatus(const char * name)
// int GetCellArrayStatus(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetCellArrayStatus_0")] public static extern 
bool GetCellArrayStatus_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name);

// void SetPointArrayStatus(const char * name, int status)
// void SetPointArrayStatus(const char* name, int status)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetPointArrayStatus_0")] public static extern 
bool SetPointArrayStatus_0(IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ status);

// void SetCellArrayStatus(const char * name, int status)
// void SetCellArrayStatus(const char* name, int status)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetCellArrayStatus_0")] public static extern 
bool SetCellArrayStatus_0(IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ status);

// int GetColumnArrayStatus(const char * name)
// int GetColumnArrayStatus(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetColumnArrayStatus_0")] public static extern 
bool GetColumnArrayStatus_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name);

// void SetColumnArrayStatus(const char * name, int status)
// void SetColumnArrayStatus(const char* name, int status)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetColumnArrayStatus_0")] public static extern 
bool SetColumnArrayStatus_0(IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ status);

// vtkXMLDataParser* GetXMLParser()
// vtkXMLDataParser* GetXMLParser()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetXMLParser_0")] public static extern 
bool GetXMLParser_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// void SetReaderErrorObserver(vtkCommand * ARG_0)
// void SetReaderErrorObserver(vtkCommand *)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetReaderErrorObserver_0")] public static extern 
bool SetReaderErrorObserver_0(IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(vtkCommand*)*/ ARG_0);

// void SetParserErrorObserver(vtkCommand * ARG_0)
// void SetParserErrorObserver(vtkCommand *)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetParserErrorObserver_0")] public static extern 
bool SetParserErrorObserver_0(IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(vtkCommand*)*/ ARG_0);

}
};
