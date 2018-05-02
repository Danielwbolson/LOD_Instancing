
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkXMLDataReader {

// virtual vtkIdType GetNumberOfPoints()
// virtual vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataReader_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataReader*)*/ callingObject);

// virtual vtkIdType GetNumberOfCells()
// virtual vtkIdType GetNumberOfCells()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataReader_GetNumberOfCells_0")] public static extern 
bool GetNumberOfCells_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataReader*)*/ callingObject);

}
};
