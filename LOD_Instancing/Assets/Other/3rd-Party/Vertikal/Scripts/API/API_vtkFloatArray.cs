
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkFloatArray {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkFloatArray_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkFloatArray_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFloatArray*)*/ callingObject, string /*(char*)*/ type);

// static vtkFloatArray* SafeDownCast(vtkObjectBase * o)
// static vtkFloatArray* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkFloatArray_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkFloatArray* NewInstance()
// vtkFloatArray *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkFloatArray_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkFloatArray*)*/ callingObject);

// static vtkFloatArray* New()
// static vtkFloatArray* New()
[DllImport("vtkplugin", EntryPoint="vtkFloatArray_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkFloatArray* FastDownCast(vtkAbstractArray * source)
// static vtkFloatArray* FastDownCast(vtkAbstractArray *source)
[DllImport("vtkplugin", EntryPoint="vtkFloatArray_FastDownCast_0")] public static extern 
bool FastDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ source);

// static float GetDataTypeValueMin()
// static float GetDataTypeValueMin()
[DllImport("vtkplugin", EntryPoint="vtkFloatArray_GetDataTypeValueMin_0")] public static extern 
bool GetDataTypeValueMin_0(IntPtr /*(IntPtr*)*/ return_value);

// static float GetDataTypeValueMax()
// static float GetDataTypeValueMax()
[DllImport("vtkplugin", EntryPoint="vtkFloatArray_GetDataTypeValueMax_0")] public static extern 
bool GetDataTypeValueMax_0(IntPtr /*(IntPtr*)*/ return_value);

}
};
