
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAssemblyNode {

// static vtkAssemblyNode* New()
// static vtkAssemblyNode *New()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyNode_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyNode_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyNode_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssemblyNode*)*/ callingObject, string /*(char*)*/ type);

// static vtkAssemblyNode* SafeDownCast(vtkObjectBase * o)
// static vtkAssemblyNode* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyNode_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAssemblyNode* NewInstance()
// vtkAssemblyNode *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyNode_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAssemblyNode*)*/ callingObject);

// virtual void SetViewProp(vtkProp * prop)
// virtual void SetViewProp(vtkProp* prop)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyNode_SetViewProp_0")] public static extern 
bool SetViewProp_0(IntPtr /*(vtkAssemblyNode*)*/ callingObject, IntPtr /*(vtkProp*)*/ prop);

// virtual vtkProp* GetViewProp()
// virtual vtkProp *GetViewProp ()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyNode_GetViewProp_0")] public static extern 
bool GetViewProp_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAssemblyNode*)*/ callingObject);

// void SetMatrix(vtkMatrix4x4 * matrix)
// void SetMatrix(vtkMatrix4x4 *matrix)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyNode_SetMatrix_0")] public static extern 
bool SetMatrix_0(IntPtr /*(vtkAssemblyNode*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ matrix);

// virtual vtkMatrix4x4* GetMatrix()
// virtual vtkMatrix4x4 *GetMatrix ()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyNode_GetMatrix_0")] public static extern 
bool GetMatrix_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAssemblyNode*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyNode_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssemblyNode*)*/ callingObject);

}
};
