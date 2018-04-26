
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkDoubleArray {

//       Method: virtual const char * vtkDoubleArray::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDoubleArray_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkDoubleArray* */ obj);

//       Method: static vtkDoubleArray * vtkDoubleArray::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDoubleArray_New_0")] public static extern 
bool New(IntPtr /*vtkDoubleArray** */ ret);

//       Method: static vtkDoubleArray * vtkDoubleArray::FastDownCast(vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDoubleArray_FastDownCast_0")] public static extern 
bool FastDownCast(IntPtr /*vtkDoubleArray** */ ret, IntPtr/*vtkAbstractArray* */ source);

//       Method: static double vtkDoubleArray::GetDataTypeValueMin()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDoubleArray_GetDataTypeValueMin_0")] public static extern 
bool GetDataTypeValueMin(IntPtr /*double* */ ret);

//       Method: static double vtkDoubleArray::GetDataTypeValueMax()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDoubleArray_GetDataTypeValueMax_0")] public static extern 
bool GetDataTypeValueMax(IntPtr /*double* */ ret);

}
};
