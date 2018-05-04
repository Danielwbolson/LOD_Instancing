
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkIntArray {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkIntArray_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkIntArray_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkIntArray*)*/ callingObject, string /*(char*)*/ type);

// static vtkIntArray* SafeDownCast(vtkObjectBase * o)
// static vtkIntArray* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkIntArray_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkIntArray* NewInstance()
// vtkIntArray *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkIntArray_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkIntArray*)*/ callingObject);

// static vtkIntArray* New()
// static vtkIntArray* New()
[DllImport("vtkplugin", EntryPoint="vtkIntArray_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkIntArray* FastDownCast(vtkAbstractArray * source)
// static vtkIntArray* FastDownCast(vtkAbstractArray *source)
[DllImport("vtkplugin", EntryPoint="vtkIntArray_FastDownCast_0")] public static extern 
bool FastDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ source);

// static int GetDataTypeValueMin()
// static int GetDataTypeValueMin()
[DllImport("vtkplugin", EntryPoint="vtkIntArray_GetDataTypeValueMin_0")] public static extern 
bool GetDataTypeValueMin_0(IntPtr /*(IntPtr*)*/ return_value);

// static int GetDataTypeValueMax()
// static int GetDataTypeValueMax()
[DllImport("vtkplugin", EntryPoint="vtkIntArray_GetDataTypeValueMax_0")] public static extern 
bool GetDataTypeValueMax_0(IntPtr /*(IntPtr*)*/ return_value);

}
};
