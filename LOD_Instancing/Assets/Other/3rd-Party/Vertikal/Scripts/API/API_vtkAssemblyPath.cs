
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAssemblyPath {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPath_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPath_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssemblyPath*)*/ callingObject, string /*(char*)*/ type);

// static vtkAssemblyPath* SafeDownCast(vtkObjectBase * o)
// static vtkAssemblyPath* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPath_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAssemblyPath* NewInstance()
// vtkAssemblyPath *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPath_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAssemblyPath*)*/ callingObject);

// static vtkAssemblyPath* New()
// static vtkAssemblyPath *New()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPath_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void AddNode(vtkProp * p, vtkMatrix4x4 * m)
// void AddNode(vtkProp *p, vtkMatrix4x4 *m)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPath_AddNode_0")] public static extern 
bool AddNode_0(IntPtr /*(vtkAssemblyPath*)*/ callingObject, IntPtr /*(vtkProp*)*/ p, IntPtr /*(vtkMatrix4x4*)*/ m);

// vtkAssemblyNode* GetNextNode()
// vtkAssemblyNode *GetNextNode()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPath_GetNextNode_0")] public static extern 
bool GetNextNode_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAssemblyPath*)*/ callingObject);

// vtkAssemblyNode* GetFirstNode()
// vtkAssemblyNode *GetFirstNode()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPath_GetFirstNode_0")] public static extern 
bool GetFirstNode_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAssemblyPath*)*/ callingObject);

// vtkAssemblyNode* GetLastNode()
// vtkAssemblyNode *GetLastNode()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPath_GetLastNode_0")] public static extern 
bool GetLastNode_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAssemblyPath*)*/ callingObject);

// void DeleteLastNode()
// void DeleteLastNode()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPath_DeleteLastNode_0")] public static extern 
bool DeleteLastNode_0(IntPtr /*(vtkAssemblyPath*)*/ callingObject);

// void ShallowCopy(vtkAssemblyPath * path)
// void ShallowCopy(vtkAssemblyPath *path)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPath_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkAssemblyPath*)*/ callingObject, IntPtr /*(vtkAssemblyPath*)*/ path);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPath_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssemblyPath*)*/ callingObject);

}
};
