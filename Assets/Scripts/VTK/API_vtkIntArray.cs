
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkIntArray {

//       Method: virtual const char * vtkIntArray::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIntArray_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkIntArray* */ obj);

//       Method: static vtkIntArray * vtkIntArray::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkIntArray_New_0")] public static extern 
bool New(IntPtr /*vtkIntArray** */ ret);

//       Method: static vtkIntArray * vtkIntArray::FastDownCast(vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkIntArray_FastDownCast_0")] public static extern 
bool FastDownCast(IntPtr /*vtkIntArray** */ ret, IntPtr/*vtkAbstractArray* */ source);

//       Method: static int vtkIntArray::GetDataTypeValueMin()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkIntArray_GetDataTypeValueMin_0")] public static extern 
bool GetDataTypeValueMin(IntPtr /*int* */ ret);

//       Method: static int vtkIntArray::GetDataTypeValueMax()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkIntArray_GetDataTypeValueMax_0")] public static extern 
bool GetDataTypeValueMax(IntPtr /*int* */ ret);

}
};
