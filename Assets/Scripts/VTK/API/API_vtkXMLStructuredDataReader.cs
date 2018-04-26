
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLStructuredDataReader {

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredDataReader_GetNumberOfPoints_0")] public static extern 
bool vtkXMLStructuredDataReader_GetNumberOfPoints_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkXMLStructuredDataReader*)*/ callingObject);

// vtkIdType GetNumberOfCells()
// vtkIdType GetNumberOfCells()
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredDataReader_GetNumberOfCells_0")] public static extern 
bool vtkXMLStructuredDataReader_GetNumberOfCells_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkXMLStructuredDataReader*)*/ callingObject);

// void CopyOutputInformation(vtkInformation * outInfo, int port)
// void CopyOutputInformation(vtkInformation *outInfo, int port)
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredDataReader_CopyOutputInformation_0")] public static extern 
bool vtkXMLStructuredDataReader_CopyOutputInformation_0(IntPtr /*(vtkXMLStructuredDataReader*)*/ callingObject, IntPtr /*(vtkInformation*)*/ outInfo, int /*(int)*/ port);

}
};
