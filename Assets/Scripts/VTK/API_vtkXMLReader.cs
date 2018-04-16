
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLReader {

//       Method: virtual const char * vtkXMLReader::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkXMLReader* */ obj);

//       Method: virtual int vtkXMLReader::CanReadFile(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_CanReadFile_0")] public static extern 
bool CanReadFile(IntPtr /*int* */ ret, IntPtr /*vtkXMLReader* */ obj, string/*const char* */ name);

//       Method: vtkDataSet * vtkXMLReader::GetOutputAsDataSet()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_GetOutputAsDataSet_0")] public static extern 
bool GetOutputAsDataSet(IntPtr /*vtkDataSet** */ ret, IntPtr /*vtkXMLReader* */ obj);

//       Method: vtkDataSet * vtkXMLReader::GetOutputAsDataSet(int index)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_GetOutputAsDataSet_1")] public static extern 
bool GetOutputAsDataSet(IntPtr /*vtkDataSet** */ ret, IntPtr /*vtkXMLReader* */ obj, int index);

//       Method: int vtkXMLReader::GetNumberOfPointArrays()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_GetNumberOfPointArrays_0")] public static extern 
bool GetNumberOfPointArrays(IntPtr /*int* */ ret, IntPtr /*vtkXMLReader* */ obj);

//       Method: int vtkXMLReader::GetNumberOfCellArrays()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_GetNumberOfCellArrays_0")] public static extern 
bool GetNumberOfCellArrays(IntPtr /*int* */ ret, IntPtr /*vtkXMLReader* */ obj);

//       Method: int vtkXMLReader::GetNumberOfColumnArrays()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_GetNumberOfColumnArrays_0")] public static extern 
bool GetNumberOfColumnArrays(IntPtr /*int* */ ret, IntPtr /*vtkXMLReader* */ obj);

//       Method: int vtkXMLReader::GetPointArrayStatus(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_GetPointArrayStatus_0")] public static extern 
bool GetPointArrayStatus(IntPtr /*int* */ ret, IntPtr /*vtkXMLReader* */ obj, string/*const char* */ name);

//       Method: int vtkXMLReader::GetCellArrayStatus(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_GetCellArrayStatus_0")] public static extern 
bool GetCellArrayStatus(IntPtr /*int* */ ret, IntPtr /*vtkXMLReader* */ obj, string/*const char* */ name);

//       Method: void vtkXMLReader::SetPointArrayStatus(const char* name, int status)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_SetPointArrayStatus_0")] public static extern 
bool SetPointArrayStatus(IntPtr /*vtkXMLReader* */ obj, string/*const char* */ name, int status);

//       Method: void vtkXMLReader::SetCellArrayStatus(const char* name, int status)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_SetCellArrayStatus_0")] public static extern 
bool SetCellArrayStatus(IntPtr /*vtkXMLReader* */ obj, string/*const char* */ name, int status);

//       Method: int vtkXMLReader::GetColumnArrayStatus(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_GetColumnArrayStatus_0")] public static extern 
bool GetColumnArrayStatus(IntPtr /*int* */ ret, IntPtr /*vtkXMLReader* */ obj, string/*const char* */ name);

//       Method: void vtkXMLReader::SetColumnArrayStatus(const char* name, int status)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_SetColumnArrayStatus_0")] public static extern 
bool SetColumnArrayStatus(IntPtr /*vtkXMLReader* */ obj, string/*const char* */ name, int status);

////       Method: int vtkXMLReader::vtkNotUsed(port ))
//// 
//[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_vtkNotUsed_0")] public static extern 
//bool vtkNotUsed(IntPtr /*int* */ ret, IntPtr /*vtkXMLReader* */ obj, port ));

//       Method: vtkXMLDataParser * vtkXMLReader::GetXMLParser()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_GetXMLParser_0")] public static extern 
bool GetXMLParser(IntPtr /*vtkXMLDataParser** */ ret, IntPtr /*vtkXMLReader* */ obj);

//       Method: int vtkXMLReader::ProcessRequest(vtkInformation* request, vtkInformationVector** inputVector, vtkInformationVector* outputVector)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_ProcessRequest_0")] public static extern 
bool ProcessRequest(IntPtr /*int* */ ret, IntPtr /*vtkXMLReader* */ obj, IntPtr/*vtkInformation* */ request, IntPtr/*vtkInformationVector** */ inputVector, IntPtr/*vtkInformationVector* */ outputVector);

//       Method: void vtkXMLReader::SetReaderErrorObserver(vtkCommand* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_SetReaderErrorObserver_0")] public static extern 
bool SetReaderErrorObserver(IntPtr /*vtkXMLReader* */ obj, IntPtr/*vtkCommand* */ ARG_0);

//       Method: void vtkXMLReader::SetParserErrorObserver(vtkCommand* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLReader_SetParserErrorObserver_0")] public static extern 
bool SetParserErrorObserver(IntPtr /*vtkXMLReader* */ obj, IntPtr/*vtkCommand* */ ARG_0);

}
};
