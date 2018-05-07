
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkSelection {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkSelection_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkSelection_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkSelection*)*/ callingObject, string /*(char*)*/ type);

// static vtkSelection* SafeDownCast(vtkObjectBase * o)
// static vtkSelection* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkSelection_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkSelection* NewInstance()
// vtkSelection *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkSelection_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkSelection*)*/ callingObject);

// static vtkSelection* New()
// static vtkSelection* New()
[DllImport("vtkplugin", EntryPoint="vtkSelection_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkSelection_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkSelection*)*/ callingObject);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkSelection_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkSelection*)*/ callingObject);

// int GetNumberOfNodes()
// unsigned int GetNumberOfNodes()
[DllImport("vtkplugin", EntryPoint="vtkSelection_GetNumberOfNodes_0")] public static extern 
bool GetNumberOfNodes_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkSelection*)*/ callingObject);

// virtual vtkSelectionNode* GetNode(unsigned int idx)
// virtual vtkSelectionNode* GetNode(unsigned int idx)
[DllImport("vtkplugin", EntryPoint="vtkSelection_GetNode_0")] public static extern 
bool GetNode_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkSelection*)*/ callingObject, uint /*(unsigned int)*/ idx);

// virtual void AddNode(vtkSelectionNode * ARG_0)
// virtual void AddNode(vtkSelectionNode*)
[DllImport("vtkplugin", EntryPoint="vtkSelection_AddNode_0")] public static extern 
bool AddNode_0(IntPtr /*(vtkSelection*)*/ callingObject, IntPtr /*(vtkSelectionNode*)*/ ARG_0);

// virtual void RemoveNode(unsigned int idx)
// virtual void RemoveNode(unsigned int idx)
[DllImport("vtkplugin", EntryPoint="vtkSelection_RemoveNode_0")] public static extern 
bool RemoveNode_0(IntPtr /*(vtkSelection*)*/ callingObject, uint /*(unsigned int)*/ idx);

// virtual void RemoveNode(vtkSelectionNode * ARG_0)
// virtual void RemoveNode(vtkSelectionNode*)
[DllImport("vtkplugin", EntryPoint="vtkSelection_RemoveNode_1")] public static extern 
bool RemoveNode_1(IntPtr /*(vtkSelection*)*/ callingObject, IntPtr /*(vtkSelectionNode*)*/ ARG_0);

// virtual void RemoveAllNodes()
// virtual void RemoveAllNodes()
[DllImport("vtkplugin", EntryPoint="vtkSelection_RemoveAllNodes_0")] public static extern 
bool RemoveAllNodes_0(IntPtr /*(vtkSelection*)*/ callingObject);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject* src)
[DllImport("vtkplugin", EntryPoint="vtkSelection_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkSelection*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void ShallowCopy(vtkDataObject * src)
// void ShallowCopy(vtkDataObject* src)
[DllImport("vtkplugin", EntryPoint="vtkSelection_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkSelection*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// virtual void Union(vtkSelection * selection)
// virtual void Union(vtkSelection* selection)
[DllImport("vtkplugin", EntryPoint="vtkSelection_Union_0")] public static extern 
bool Union_0(IntPtr /*(vtkSelection*)*/ callingObject, IntPtr /*(vtkSelection*)*/ selection);

// virtual void Union(vtkSelectionNode * node)
// virtual void Union(vtkSelectionNode* node)
[DllImport("vtkplugin", EntryPoint="vtkSelection_Union_1")] public static extern 
bool Union_1(IntPtr /*(vtkSelection*)*/ callingObject, IntPtr /*(vtkSelectionNode*)*/ node);

// virtual void Subtract(vtkSelection * selection)
// virtual void Subtract(vtkSelection* selection)
[DllImport("vtkplugin", EntryPoint="vtkSelection_Subtract_0")] public static extern 
bool Subtract_0(IntPtr /*(vtkSelection*)*/ callingObject, IntPtr /*(vtkSelection*)*/ selection);

// virtual void Subtract(vtkSelectionNode * node)
// virtual void Subtract(vtkSelectionNode* node)
[DllImport("vtkplugin", EntryPoint="vtkSelection_Subtract_1")] public static extern 
bool Subtract_1(IntPtr /*(vtkSelection*)*/ callingObject, IntPtr /*(vtkSelectionNode*)*/ node);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkSelection_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkSelection*)*/ callingObject);

// virtual void Dump()
// virtual void Dump()
[DllImport("vtkplugin", EntryPoint="vtkSelection_Dump_0")] public static extern 
bool Dump_0(IntPtr /*(vtkSelection*)*/ callingObject);

}
};
