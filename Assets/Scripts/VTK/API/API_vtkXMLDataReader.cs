
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLDataReader {

// virtual vtkIdType GetNumberOfPoints()
// virtual vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataReader_GetNumberOfPoints_0")] public static extern 
bool vtkXMLDataReader_GetNumberOfPoints_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkXMLDataReader*)*/ callingObject);

// virtual vtkIdType GetNumberOfCells()
// virtual vtkIdType GetNumberOfCells()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataReader_GetNumberOfCells_0")] public static extern 
bool vtkXMLDataReader_GetNumberOfCells_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkXMLDataReader*)*/ callingObject);

// void CopyOutputInformation(vtkInformation * outInfo, int port)
// void CopyOutputInformation(vtkInformation *outInfo, int port)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataReader_CopyOutputInformation_0")] public static extern 
bool vtkXMLDataReader_CopyOutputInformation_0(IntPtr /*(vtkXMLDataReader*)*/ callingObject, IntPtr /*(vtkInformation*)*/ outInfo, int /*(int)*/ port);

}
};
