
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformation {

//       Method: virtual const char * vtkInformation::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformation_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkInformation* */ obj);

}
};
