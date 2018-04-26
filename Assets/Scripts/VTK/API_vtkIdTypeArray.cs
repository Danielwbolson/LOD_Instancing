
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkIdTypeArray {

//       Method: virtual const char * vtkIdTypeArray::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdTypeArray_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkIdTypeArray* */ obj);

//       Method: static vtkIdTypeArray * vtkIdTypeArray::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkIdTypeArray_New_0")] public static extern 
bool New(IntPtr /*vtkIdTypeArray** */ ret);

//       Method: int vtkIdTypeArray::GetDataType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdTypeArray_GetDataType_0")] public static extern 
bool GetDataType(IntPtr /*int* */ ret, IntPtr /*vtkIdTypeArray* */ obj);

//       Method: static vtkIdTypeArray * vtkIdTypeArray::FastDownCast(vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkIdTypeArray_FastDownCast_0")] public static extern 
bool FastDownCast(IntPtr /*vtkIdTypeArray** */ ret, IntPtr/*vtkAbstractArray* */ source);

//       Method: static vtkIdType vtkIdTypeArray::GetDataTypeValueMin()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkIdTypeArray_GetDataTypeValueMin_0")] public static extern 
bool GetDataTypeValueMin(IntPtr /*vtkIdType* */ ret);

//       Method: static vtkIdType vtkIdTypeArray::GetDataTypeValueMax()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkIdTypeArray_GetDataTypeValueMax_0")] public static extern 
bool GetDataTypeValueMax(IntPtr /*vtkIdType* */ ret);

}
};
