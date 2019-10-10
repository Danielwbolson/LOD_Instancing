
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkCollectionIterator {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCollectionIterator_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCollectionIterator_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCollectionIterator*)*/ callingObject, string /*(char*)*/ type);

// static vtkCollectionIterator* SafeDownCast(vtkObjectBase * o)
// static vtkCollectionIterator* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkCollectionIterator_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkCollectionIterator* NewInstance()
// vtkCollectionIterator *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkCollectionIterator_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCollectionIterator*)*/ callingObject);

// static vtkCollectionIterator* New()
// static vtkCollectionIterator* New()
[DllImport("vtkplugin", EntryPoint="vtkCollectionIterator_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual void SetCollection(vtkCollection * ARG_0)
// virtual void SetCollection(vtkCollection*)
[DllImport("vtkplugin", EntryPoint="vtkCollectionIterator_SetCollection_0")] public static extern 
bool SetCollection_0(IntPtr /*(vtkCollectionIterator*)*/ callingObject, IntPtr /*(vtkCollection*)*/ ARG_0);

// virtual vtkCollection* GetCollection()
// virtual vtkCollection *GetCollection ()
[DllImport("vtkplugin", EntryPoint="vtkCollectionIterator_GetCollection_0")] public static extern 
bool GetCollection_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCollectionIterator*)*/ callingObject);

// void InitTraversal()
// void InitTraversal()
[DllImport("vtkplugin", EntryPoint="vtkCollectionIterator_InitTraversal_0")] public static extern 
bool InitTraversal_0(IntPtr /*(vtkCollectionIterator*)*/ callingObject);

// void GoToFirstItem()
// void GoToFirstItem()
[DllImport("vtkplugin", EntryPoint="vtkCollectionIterator_GoToFirstItem_0")] public static extern 
bool GoToFirstItem_0(IntPtr /*(vtkCollectionIterator*)*/ callingObject);

// void GoToNextItem()
// void GoToNextItem()
[DllImport("vtkplugin", EntryPoint="vtkCollectionIterator_GoToNextItem_0")] public static extern 
bool GoToNextItem_0(IntPtr /*(vtkCollectionIterator*)*/ callingObject);

// int IsDoneWithTraversal()
// int IsDoneWithTraversal()
[DllImport("vtkplugin", EntryPoint="vtkCollectionIterator_IsDoneWithTraversal_0")] public static extern 
bool IsDoneWithTraversal_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCollectionIterator*)*/ callingObject);

// vtkObject* GetCurrentObject()
// vtkObject* GetCurrentObject()
[DllImport("vtkplugin", EntryPoint="vtkCollectionIterator_GetCurrentObject_0")] public static extern 
bool GetCurrentObject_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCollectionIterator*)*/ callingObject);

}
};
