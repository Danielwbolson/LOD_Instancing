
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkUnsignedCharArray {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkUnsignedCharArray_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkUnsignedCharArray_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnsignedCharArray*)*/ callingObject, string /*(char*)*/ type);

// static vtkUnsignedCharArray* SafeDownCast(vtkObjectBase * o)
// static vtkUnsignedCharArray* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkUnsignedCharArray_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkUnsignedCharArray* NewInstance()
// vtkUnsignedCharArray *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkUnsignedCharArray_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkUnsignedCharArray*)*/ callingObject);

// static vtkUnsignedCharArray* New()
// static vtkUnsignedCharArray* New()
[DllImport("vtkplugin", EntryPoint="vtkUnsignedCharArray_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkUnsignedCharArray* FastDownCast(vtkAbstractArray * source)
// static vtkUnsignedCharArray* FastDownCast(vtkAbstractArray *source)
[DllImport("vtkplugin", EntryPoint="vtkUnsignedCharArray_FastDownCast_0")] public static extern 
bool FastDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ source);

// static char GetDataTypeValueMin()
// static unsigned char GetDataTypeValueMin()
[DllImport("vtkplugin", EntryPoint="vtkUnsignedCharArray_GetDataTypeValueMin_0")] public static extern 
bool GetDataTypeValueMin_0(IntPtr /*(unsigned IntPtr*)*/ return_value);

// static char GetDataTypeValueMax()
// static unsigned char GetDataTypeValueMax()
[DllImport("vtkplugin", EntryPoint="vtkUnsignedCharArray_GetDataTypeValueMax_0")] public static extern 
bool GetDataTypeValueMax_0(IntPtr /*(unsigned IntPtr*)*/ return_value);

}
};
