
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLUnstructuredGridReader {

// static vtkXMLUnstructuredGridReader* New()
// static vtkXMLUnstructuredGridReader *New()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredGridReader_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// vtkUnstructuredGrid* GetOutput()
// vtkUnstructuredGrid *GetOutput()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredGridReader_GetOutput_0")] public static extern 
bool GetOutput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLUnstructuredGridReader*)*/ callingObject);

// vtkUnstructuredGrid* GetOutput(int idx)
// vtkUnstructuredGrid *GetOutput(int idx)
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredGridReader_GetOutput_1")] public static extern 
bool GetOutput_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLUnstructuredGridReader*)*/ callingObject, int /*(int)*/ idx);

}
};
