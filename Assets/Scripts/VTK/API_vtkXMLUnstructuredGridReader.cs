
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLUnstructuredGridReader {

//       Method: virtual const char * vtkXMLUnstructuredGridReader::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLUnstructuredGridReader_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkXMLUnstructuredGridReader* */ obj);

//       Method: static vtkXMLUnstructuredGridReader * vtkXMLUnstructuredGridReader::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkXMLUnstructuredGridReader_New_0")] public static extern 
bool New(IntPtr /*vtkXMLUnstructuredGridReader** */ ret);

//       Method: vtkUnstructuredGrid * vtkXMLUnstructuredGridReader::GetOutput()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLUnstructuredGridReader_GetOutput_0")] public static extern 
bool GetOutput(IntPtr /*vtkUnstructuredGrid** */ ret, IntPtr /*vtkXMLUnstructuredGridReader* */ obj);

//       Method: vtkUnstructuredGrid * vtkXMLUnstructuredGridReader::GetOutput(int idx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLUnstructuredGridReader_GetOutput_1")] public static extern 
bool GetOutput(IntPtr /*vtkUnstructuredGrid** */ ret, IntPtr /*vtkXMLUnstructuredGridReader* */ obj, int idx);

}
};
