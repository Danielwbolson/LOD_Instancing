
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkArrayIterator {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkArrayIterator_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkArrayIterator_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkArrayIterator*)*/ callingObject, string /*(char*)*/ type);

// static vtkArrayIterator* SafeDownCast(vtkObjectBase * o)
// static vtkArrayIterator* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkArrayIterator_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkArrayIterator* NewInstance()
// vtkArrayIterator *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkArrayIterator_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkArrayIterator*)*/ callingObject);

// virtual void Initialize(vtkAbstractArray * array)
// virtual void Initialize(vtkAbstractArray* array)
[DllImport("vtkplugin", EntryPoint="vtkArrayIterator_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkArrayIterator*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ array);

// virtual int GetDataType()
// virtual int GetDataType()
[DllImport("vtkplugin", EntryPoint="vtkArrayIterator_GetDataType_0")] public static extern 
bool GetDataType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkArrayIterator*)*/ callingObject);

}
};
