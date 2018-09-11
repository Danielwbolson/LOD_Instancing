
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAbstractCellLinks {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractCellLinks_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractCellLinks_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractCellLinks*)*/ callingObject, string /*(char*)*/ type);

// static vtkAbstractCellLinks* SafeDownCast(vtkObjectBase * o)
// static vtkAbstractCellLinks* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAbstractCellLinks_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAbstractCellLinks* NewInstance()
// vtkAbstractCellLinks *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAbstractCellLinks_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractCellLinks*)*/ callingObject);

// virtual void BuildLinks(vtkDataSet * data)
// virtual void BuildLinks(vtkDataSet *data)
[DllImport("vtkplugin", EntryPoint="vtkAbstractCellLinks_BuildLinks_0")] public static extern 
bool BuildLinks_0(IntPtr /*(vtkAbstractCellLinks*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ data);

// static int GetIdType(vtkIdType maxPtId, vtkIdType maxCellId, vtkCellArray * ca)
// static int GetIdType(vtkIdType maxPtId, vtkIdType maxCellId, vtkCellArray *ca)
[DllImport("vtkplugin", EntryPoint="vtkAbstractCellLinks_GetIdType_0")] public static extern 
bool GetIdType_0(IntPtr /*(IntPtr*)*/ return_value, long /*(vtkIdType)*/ maxPtId, long /*(vtkIdType)*/ maxCellId, IntPtr /*(vtkCellArray*)*/ ca);

}
};
