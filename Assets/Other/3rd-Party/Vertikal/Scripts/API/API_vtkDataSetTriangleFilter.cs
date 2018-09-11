
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkDataSetTriangleFilter {

// static vtkDataSetTriangleFilter* New()
// static vtkDataSetTriangleFilter *New()
[DllImport("vtkplugin", EntryPoint="vtkDataSetTriangleFilter_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataSetTriangleFilter_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataSetTriangleFilter_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSetTriangleFilter*)*/ callingObject, string /*(char*)*/ type);

// static vtkDataSetTriangleFilter* SafeDownCast(vtkObjectBase * o)
// static vtkDataSetTriangleFilter* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkDataSetTriangleFilter_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkDataSetTriangleFilter* NewInstance()
// vtkDataSetTriangleFilter *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkDataSetTriangleFilter_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSetTriangleFilter*)*/ callingObject);

// virtual void SetTetrahedraOnly(int _arg)
// virtual void SetTetrahedraOnly (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataSetTriangleFilter_SetTetrahedraOnly_0")] public static extern 
bool SetTetrahedraOnly_0(IntPtr /*(vtkDataSetTriangleFilter*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetTetrahedraOnly()
// virtual int GetTetrahedraOnly ()
[DllImport("vtkplugin", EntryPoint="vtkDataSetTriangleFilter_GetTetrahedraOnly_0")] public static extern 
bool GetTetrahedraOnly_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSetTriangleFilter*)*/ callingObject);

// virtual void TetrahedraOnlyOn()
// virtual void TetrahedraOnlyOn ()
[DllImport("vtkplugin", EntryPoint="vtkDataSetTriangleFilter_TetrahedraOnlyOn_0")] public static extern 
bool TetrahedraOnlyOn_0(IntPtr /*(vtkDataSetTriangleFilter*)*/ callingObject);

// virtual void TetrahedraOnlyOff()
// virtual void TetrahedraOnlyOff ()
[DllImport("vtkplugin", EntryPoint="vtkDataSetTriangleFilter_TetrahedraOnlyOff_0")] public static extern 
bool TetrahedraOnlyOff_0(IntPtr /*(vtkDataSetTriangleFilter*)*/ callingObject);

}
};
