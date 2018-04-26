
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkUnsignedCharArray {

//       Method: virtual const char * vtkUnsignedCharArray::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnsignedCharArray_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkUnsignedCharArray* */ obj);

//       Method: static vtkUnsignedCharArray * vtkUnsignedCharArray::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkUnsignedCharArray_New_0")] public static extern 
bool New(IntPtr /*vtkUnsignedCharArray** */ ret);

//       Method: static vtkUnsignedCharArray * vtkUnsignedCharArray::FastDownCast(vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkUnsignedCharArray_FastDownCast_0")] public static extern 
bool FastDownCast(IntPtr /*vtkUnsignedCharArray** */ ret, IntPtr/*vtkAbstractArray* */ source);

}
};
