
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPointData {

// static vtkPointData* New()
// static vtkPointData *New()
[DllImport("vtkplugin", EntryPoint="vtkPointData_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPointData_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPointData_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointData*)*/ callingObject, string /*(char*)*/ type);

// static vtkPointData* SafeDownCast(vtkObjectBase * o)
// static vtkPointData* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPointData_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPointData* NewInstance()
// vtkPointData *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPointData_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPointData*)*/ callingObject);

// void NullPoint(vtkIdType ptId)
// void NullPoint(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkPointData_NullPoint_0")] public static extern 
bool NullPoint_0(IntPtr /*(vtkPointData*)*/ callingObject, long /*(vtkIdType)*/ ptId);

}
};
