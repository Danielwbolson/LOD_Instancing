
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLStructuredGridReader {

// static vtkXMLStructuredGridReader* New()
// static vtkXMLStructuredGridReader *New()
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredGridReader_New_0")] public static extern 
bool vtkXMLStructuredGridReader_New_0(IntPtr /*(vtkXMLStructuredGridReader**)*/ return_value);

// vtkStructuredGrid* GetOutput()
// vtkStructuredGrid *GetOutput()
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredGridReader_GetOutput_0")] public static extern 
bool vtkXMLStructuredGridReader_GetOutput_0(IntPtr /*(vtkStructuredGrid**)*/ return_value, IntPtr /*(vtkXMLStructuredGridReader*)*/ callingObject);

// vtkStructuredGrid* GetOutput(int idx)
// vtkStructuredGrid *GetOutput(int idx)
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredGridReader_GetOutput_1")] public static extern 
bool vtkXMLStructuredGridReader_GetOutput_1(IntPtr /*(vtkStructuredGrid**)*/ return_value, IntPtr /*(vtkXMLStructuredGridReader*)*/ callingObject, int /*(int)*/ idx);

}
};
