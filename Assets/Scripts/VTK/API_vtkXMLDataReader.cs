
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLDataReader {

//       Method: virtual const char * vtkXMLDataReader::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLDataReader_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkXMLDataReader* */ obj);

//       Method: virtual vtkIdType vtkXMLDataReader::GetNumberOfPoints()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLDataReader_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkXMLDataReader* */ obj);

//       Method: virtual vtkIdType vtkXMLDataReader::GetNumberOfCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLDataReader_GetNumberOfCells_0")] public static extern 
bool GetNumberOfCells(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkXMLDataReader* */ obj);

//       Method: void vtkXMLDataReader::CopyOutputInformation(vtkInformation* outInfo, int port)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLDataReader_CopyOutputInformation_0")] public static extern 
bool CopyOutputInformation(IntPtr /*vtkXMLDataReader* */ obj, IntPtr/*vtkInformation* */ outInfo, int port);

}
};
