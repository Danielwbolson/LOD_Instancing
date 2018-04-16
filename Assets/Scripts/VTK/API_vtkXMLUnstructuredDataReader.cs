
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLUnstructuredDataReader {

//       Method: virtual const char * vtkXMLUnstructuredDataReader::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLUnstructuredDataReader_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkXMLUnstructuredDataReader* */ obj);

//       Method: vtkIdType vtkXMLUnstructuredDataReader::GetNumberOfPoints()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLUnstructuredDataReader_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkXMLUnstructuredDataReader* */ obj);

//       Method: vtkIdType vtkXMLUnstructuredDataReader::GetNumberOfCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLUnstructuredDataReader_GetNumberOfCells_0")] public static extern 
bool GetNumberOfCells(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkXMLUnstructuredDataReader* */ obj);

//       Method: virtual vtkIdType vtkXMLUnstructuredDataReader::GetNumberOfPieces()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLUnstructuredDataReader_GetNumberOfPieces_0")] public static extern 
bool GetNumberOfPieces(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkXMLUnstructuredDataReader* */ obj);

//       Method: void vtkXMLUnstructuredDataReader::SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLUnstructuredDataReader_SetupUpdateExtent_0")] public static extern 
bool SetupUpdateExtent(IntPtr /*vtkXMLUnstructuredDataReader* */ obj, int piece, int numberOfPieces, int ghostLevel);

//       Method: void vtkXMLUnstructuredDataReader::CopyOutputInformation(vtkInformation* outInfo, int port)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLUnstructuredDataReader_CopyOutputInformation_0")] public static extern 
bool CopyOutputInformation(IntPtr /*vtkXMLUnstructuredDataReader* */ obj, IntPtr/*vtkInformation* */ outInfo, int port);

}
};
