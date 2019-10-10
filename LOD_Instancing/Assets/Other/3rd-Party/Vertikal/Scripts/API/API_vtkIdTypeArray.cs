
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkIdTypeArray {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkIdTypeArray*)*/ callingObject, string /*(char*)*/ type);

// static vtkIdTypeArray* SafeDownCast(vtkObjectBase * o)
// static vtkIdTypeArray* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkIdTypeArray* NewInstance()
// vtkIdTypeArray *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkIdTypeArray*)*/ callingObject);

// static vtkIdTypeArray* New()
// static vtkIdTypeArray* New()
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// int GetDataType()
// int GetDataType()
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_GetDataType_0")] public static extern 
bool GetDataType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkIdTypeArray*)*/ callingObject);

// static vtkIdTypeArray* FastDownCast(vtkAbstractArray * source)
// static vtkIdTypeArray* FastDownCast(vtkAbstractArray *source)
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_FastDownCast_0")] public static extern 
bool FastDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ source);

// static vtkIdType GetDataTypeValueMin()
// static vtkIdType GetDataTypeValueMin()
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_GetDataTypeValueMin_0")] public static extern 
bool GetDataTypeValueMin_0(IntPtr /*(IntPtr*)*/ return_value);

// static vtkIdType GetDataTypeValueMax()
// static vtkIdType GetDataTypeValueMax()
[DllImport("vtkplugin", EntryPoint="vtkIdTypeArray_GetDataTypeValueMax_0")] public static extern 
bool GetDataTypeValueMax_0(IntPtr /*(IntPtr*)*/ return_value);

}
};
