
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLUnstructuredDataReader {

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_GetNumberOfPoints_0")] public static extern 
bool vtkXMLUnstructuredDataReader_GetNumberOfPoints_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject);

// vtkIdType GetNumberOfCells()
// vtkIdType GetNumberOfCells()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_GetNumberOfCells_0")] public static extern 
bool vtkXMLUnstructuredDataReader_GetNumberOfCells_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject);

// virtual vtkIdType GetNumberOfPieces()
// virtual vtkIdType GetNumberOfPieces()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_GetNumberOfPieces_0")] public static extern 
bool vtkXMLUnstructuredDataReader_GetNumberOfPieces_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject);

// void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
// void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_SetupUpdateExtent_0")] public static extern 
bool vtkXMLUnstructuredDataReader_SetupUpdateExtent_0(IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject, int /*(int)*/ piece, int /*(int)*/ numberOfPieces, int /*(int)*/ ghostLevel);

// void CopyOutputInformation(vtkInformation * outInfo, int port)
// void CopyOutputInformation(vtkInformation *outInfo, int port)
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_CopyOutputInformation_0")] public static extern 
bool vtkXMLUnstructuredDataReader_CopyOutputInformation_0(IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject, IntPtr /*(vtkInformation*)*/ outInfo, int /*(int)*/ port);

}
};
