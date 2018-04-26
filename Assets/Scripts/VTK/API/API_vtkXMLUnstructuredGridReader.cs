
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLUnstructuredGridReader {

// static vtkXMLUnstructuredGridReader* New()
// static vtkXMLUnstructuredGridReader *New()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredGridReader_New_0")] public static extern 
bool vtkXMLUnstructuredGridReader_New_0(IntPtr /*(vtkXMLUnstructuredGridReader**)*/ return_value);

// vtkUnstructuredGrid* GetOutput()
// vtkUnstructuredGrid *GetOutput()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredGridReader_GetOutput_0")] public static extern 
bool vtkXMLUnstructuredGridReader_GetOutput_0(IntPtr /*(vtkUnstructuredGrid**)*/ return_value, IntPtr /*(vtkXMLUnstructuredGridReader*)*/ callingObject);

// vtkUnstructuredGrid* GetOutput(int idx)
// vtkUnstructuredGrid *GetOutput(int idx)
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredGridReader_GetOutput_1")] public static extern 
bool vtkXMLUnstructuredGridReader_GetOutput_1(IntPtr /*(vtkUnstructuredGrid**)*/ return_value, IntPtr /*(vtkXMLUnstructuredGridReader*)*/ callingObject, int /*(int)*/ idx);

}
};
