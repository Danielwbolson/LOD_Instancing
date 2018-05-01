
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLPolyDataReader {

// static vtkXMLPolyDataReader* New()
// static vtkXMLPolyDataReader *New()
[DllImport("vtkplugin", EntryPoint="vtkXMLPolyDataReader_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// vtkPolyData* GetOutput()
// vtkPolyData *GetOutput()
[DllImport("vtkplugin", EntryPoint="vtkXMLPolyDataReader_GetOutput_0")] public static extern 
bool GetOutput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLPolyDataReader*)*/ callingObject);

// vtkPolyData* GetOutput(int idx)
// vtkPolyData *GetOutput(int idx)
[DllImport("vtkplugin", EntryPoint="vtkXMLPolyDataReader_GetOutput_1")] public static extern 
bool GetOutput_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLPolyDataReader*)*/ callingObject, int /*(int)*/ idx);

// virtual vtkIdType GetNumberOfVerts()
// virtual vtkIdType GetNumberOfVerts()
[DllImport("vtkplugin", EntryPoint="vtkXMLPolyDataReader_GetNumberOfVerts_0")] public static extern 
bool GetNumberOfVerts_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLPolyDataReader*)*/ callingObject);

// virtual vtkIdType GetNumberOfLines()
// virtual vtkIdType GetNumberOfLines()
[DllImport("vtkplugin", EntryPoint="vtkXMLPolyDataReader_GetNumberOfLines_0")] public static extern 
bool GetNumberOfLines_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLPolyDataReader*)*/ callingObject);

// virtual vtkIdType GetNumberOfStrips()
// virtual vtkIdType GetNumberOfStrips()
[DllImport("vtkplugin", EntryPoint="vtkXMLPolyDataReader_GetNumberOfStrips_0")] public static extern 
bool GetNumberOfStrips_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLPolyDataReader*)*/ callingObject);

// virtual vtkIdType GetNumberOfPolys()
// virtual vtkIdType GetNumberOfPolys()
[DllImport("vtkplugin", EntryPoint="vtkXMLPolyDataReader_GetNumberOfPolys_0")] public static extern 
bool GetNumberOfPolys_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLPolyDataReader*)*/ callingObject);

}
};
