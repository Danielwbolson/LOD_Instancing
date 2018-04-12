
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLStructuredGridReader {

//       Method: static vtkXMLStructuredGridReader * vtkXMLStructuredGridReader::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkXMLStructuredGridReader_New_0")] public static extern 
bool New(IntPtr /*vtkXMLStructuredGridReader** */ ret);

//       Method: vtkStructuredGrid * vtkXMLStructuredGridReader::GetOutput()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLStructuredGridReader_GetOutput_0")] public static extern 
bool GetOutput(IntPtr /*vtkStructuredGrid** */ ret, IntPtr /*vtkXMLStructuredGridReader* */ obj);

//       Method: vtkStructuredGrid * vtkXMLStructuredGridReader::GetOutput(int idx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkXMLStructuredGridReader_GetOutput_1")] public static extern 
bool GetOutput(IntPtr /*vtkStructuredGrid** */ ret, IntPtr /*vtkXMLStructuredGridReader* */ obj, int idx);

}
};
