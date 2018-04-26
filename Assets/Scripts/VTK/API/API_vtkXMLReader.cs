
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLReader {

// virtual int CanReadFile(const char * name)
// virtual int CanReadFile(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_CanReadFile_0")] public static extern 
bool vtkXMLReader_CanReadFile_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkDataSet* GetOutputAsDataSet()
// vtkDataSet* GetOutputAsDataSet()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetOutputAsDataSet_0")] public static extern 
bool vtkXMLReader_GetOutputAsDataSet_0(IntPtr /*(vtkDataSet**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// vtkDataSet* GetOutputAsDataSet(int index)
// vtkDataSet* GetOutputAsDataSet(int index)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetOutputAsDataSet_1")] public static extern 
bool vtkXMLReader_GetOutputAsDataSet_1(IntPtr /*(vtkDataSet**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ index);

// int GetNumberOfPointArrays()
// int GetNumberOfPointArrays()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetNumberOfPointArrays_0")] public static extern 
bool vtkXMLReader_GetNumberOfPointArrays_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// int GetNumberOfCellArrays()
// int GetNumberOfCellArrays()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetNumberOfCellArrays_0")] public static extern 
bool vtkXMLReader_GetNumberOfCellArrays_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// int GetNumberOfColumnArrays()
// int GetNumberOfColumnArrays()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetNumberOfColumnArrays_0")] public static extern 
bool vtkXMLReader_GetNumberOfColumnArrays_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// char* GetPointArrayName(int index)
// const char* GetPointArrayName(int index)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetPointArrayName_0")] public static extern 
bool vtkXMLReader_GetPointArrayName_0(IntPtr /*(char**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ index);

// char* GetCellArrayName(int index)
// const char* GetCellArrayName(int index)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetCellArrayName_0")] public static extern 
bool vtkXMLReader_GetCellArrayName_0(IntPtr /*(char**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ index);

// char* GetColumnArrayName(int index)
// const char* GetColumnArrayName(int index)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetColumnArrayName_0")] public static extern 
bool vtkXMLReader_GetColumnArrayName_0(IntPtr /*(char**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ index);

// int GetPointArrayStatus(const char * name)
// int GetPointArrayStatus(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetPointArrayStatus_0")] public static extern 
bool vtkXMLReader_GetPointArrayStatus_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(char*)*/ name);

// int GetCellArrayStatus(const char * name)
// int GetCellArrayStatus(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetCellArrayStatus_0")] public static extern 
bool vtkXMLReader_GetCellArrayStatus_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(char*)*/ name);

// void SetPointArrayStatus(const char * name, int status)
// void SetPointArrayStatus(const char* name, int status)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetPointArrayStatus_0")] public static extern 
bool vtkXMLReader_SetPointArrayStatus_0(IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(char*)*/ name, int /*(int)*/ status);

// void SetCellArrayStatus(const char * name, int status)
// void SetCellArrayStatus(const char* name, int status)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetCellArrayStatus_0")] public static extern 
bool vtkXMLReader_SetCellArrayStatus_0(IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(char*)*/ name, int /*(int)*/ status);

// int GetColumnArrayStatus(const char * name)
// int GetColumnArrayStatus(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetColumnArrayStatus_0")] public static extern 
bool vtkXMLReader_GetColumnArrayStatus_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(char*)*/ name);

// void SetColumnArrayStatus(const char * name, int status)
// void SetColumnArrayStatus(const char* name, int status)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetColumnArrayStatus_0")] public static extern 
bool vtkXMLReader_SetColumnArrayStatus_0(IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(char*)*/ name, int /*(int)*/ status);

// vtkXMLDataParser* GetXMLParser()
// vtkXMLDataParser* GetXMLParser()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetXMLParser_0")] public static extern 
bool vtkXMLReader_GetXMLParser_0(IntPtr /*(vtkXMLDataParser**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// int ProcessRequest(vtkInformation * request, vtkInformationVector ** inputVector, vtkInformationVector * outputVector)
// int ProcessRequest(vtkInformation *request, vtkInformationVector **inputVector, vtkInformationVector *outputVector)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_ProcessRequest_0")] public static extern 
bool vtkXMLReader_ProcessRequest_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(vtkInformation*)*/ request, IntPtr /*(vtkInformationVector**)*/ inputVector, IntPtr /*(vtkInformationVector*)*/ outputVector);

// void SetReaderErrorObserver(vtkCommand * ARG_0)
// void SetReaderErrorObserver(vtkCommand *)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetReaderErrorObserver_0")] public static extern 
bool vtkXMLReader_SetReaderErrorObserver_0(IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(vtkCommand*)*/ ARG_0);

// void SetParserErrorObserver(vtkCommand * ARG_0)
// void SetParserErrorObserver(vtkCommand *)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetParserErrorObserver_0")] public static extern 
bool vtkXMLReader_SetParserErrorObserver_0(IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(vtkCommand*)*/ ARG_0);

}
};
