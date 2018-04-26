
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkIdTypeArray {

// static vtkIdTypeArray* New()
// static vtkIdTypeArray* New()
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_New_0")] public static extern 
bool vtkIdTypeArray_New_0(IntPtr /*(vtkIdTypeArray**)*/ return_value);

// int GetDataType()
// int GetDataType()
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_GetDataType_0")] public static extern 
bool vtkIdTypeArray_GetDataType_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkIdTypeArray*)*/ callingObject);

// static vtkIdTypeArray* FastDownCast(vtkAbstractArray * source)
// static vtkIdTypeArray* FastDownCast(vtkAbstractArray *source)
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_FastDownCast_0")] public static extern 
bool vtkIdTypeArray_FastDownCast_0(IntPtr /*(vtkIdTypeArray**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ source);

// static vtkIdType GetDataTypeValueMin()
// static vtkIdType GetDataTypeValueMin()
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_GetDataTypeValueMin_0")] public static extern 
bool vtkIdTypeArray_GetDataTypeValueMin_0(IntPtr /*(vtkIdType*)*/ return_value);

// static vtkIdType GetDataTypeValueMax()
// static vtkIdType GetDataTypeValueMax()
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_GetDataTypeValueMax_0")] public static extern 
bool vtkIdTypeArray_GetDataTypeValueMax_0(IntPtr /*(vtkIdType*)*/ return_value);

}
};
