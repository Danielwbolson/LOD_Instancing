
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkCollection {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCollection_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCollection_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCollection*)*/ callingObject, string /*(char*)*/ type);

// static vtkCollection* SafeDownCast(vtkObjectBase * o)
// static vtkCollection* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkCollection_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkCollection* NewInstance()
// vtkCollection *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkCollection_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCollection*)*/ callingObject);

// static vtkCollection* New()
// static vtkCollection *New()
[DllImport("vtkplugin", EntryPoint="vtkCollection_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void AddItem(vtkObject * ARG_0)
// void AddItem(vtkObject *)
[DllImport("vtkplugin", EntryPoint="vtkCollection_AddItem_0")] public static extern 
bool AddItem_0(IntPtr /*(vtkCollection*)*/ callingObject, IntPtr /*(vtkObject*)*/ ARG_0);

// void InsertItem(int i, vtkObject * ARG_0)
// void InsertItem(int i, vtkObject *)
[DllImport("vtkplugin", EntryPoint="vtkCollection_InsertItem_0")] public static extern 
bool InsertItem_0(IntPtr /*(vtkCollection*)*/ callingObject, int /*(int)*/ i, IntPtr /*(vtkObject*)*/ ARG_0);

// void ReplaceItem(int i, vtkObject * ARG_0)
// void ReplaceItem(int i, vtkObject *)
[DllImport("vtkplugin", EntryPoint="vtkCollection_ReplaceItem_0")] public static extern 
bool ReplaceItem_0(IntPtr /*(vtkCollection*)*/ callingObject, int /*(int)*/ i, IntPtr /*(vtkObject*)*/ ARG_0);

// void RemoveItem(int i)
// void RemoveItem(int i)
[DllImport("vtkplugin", EntryPoint="vtkCollection_RemoveItem_0")] public static extern 
bool RemoveItem_0(IntPtr /*(vtkCollection*)*/ callingObject, int /*(int)*/ i);

// void RemoveItem(vtkObject * ARG_0)
// void RemoveItem(vtkObject *)
[DllImport("vtkplugin", EntryPoint="vtkCollection_RemoveItem_1")] public static extern 
bool RemoveItem_1(IntPtr /*(vtkCollection*)*/ callingObject, IntPtr /*(vtkObject*)*/ ARG_0);

// void RemoveAllItems()
// void RemoveAllItems()
[DllImport("vtkplugin", EntryPoint="vtkCollection_RemoveAllItems_0")] public static extern 
bool RemoveAllItems_0(IntPtr /*(vtkCollection*)*/ callingObject);

// int IsItemPresent(vtkObject * a)
// int IsItemPresent(vtkObject *a)
[DllImport("vtkplugin", EntryPoint="vtkCollection_IsItemPresent_0")] public static extern 
bool IsItemPresent_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCollection*)*/ callingObject, IntPtr /*(vtkObject*)*/ a);

// int GetNumberOfItems()
// int GetNumberOfItems()
[DllImport("vtkplugin", EntryPoint="vtkCollection_GetNumberOfItems_0")] public static extern 
bool GetNumberOfItems_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCollection*)*/ callingObject);

// void InitTraversal()
// void InitTraversal()
[DllImport("vtkplugin", EntryPoint="vtkCollection_InitTraversal_0")] public static extern 
bool InitTraversal_0(IntPtr /*(vtkCollection*)*/ callingObject);

// vtkObject* GetNextItemAsObject()
// vtkObject *GetNextItemAsObject()
[DllImport("vtkplugin", EntryPoint="vtkCollection_GetNextItemAsObject_0")] public static extern 
bool GetNextItemAsObject_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCollection*)*/ callingObject);

// vtkObject* GetItemAsObject(int i)
// vtkObject *GetItemAsObject(int i)
[DllImport("vtkplugin", EntryPoint="vtkCollection_GetItemAsObject_0")] public static extern 
bool GetItemAsObject_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCollection*)*/ callingObject, int /*(int)*/ i);

// vtkCollectionIterator* NewIterator()
// vtkCollectionIterator* NewIterator()
[DllImport("vtkplugin", EntryPoint="vtkCollection_NewIterator_0")] public static extern 
bool NewIterator_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCollection*)*/ callingObject);

// void Register(vtkObjectBase * o)
// void Register(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkCollection_Register_0")] public static extern 
bool Register_0(IntPtr /*(vtkCollection*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkCollection_UnRegister_0")] public static extern 
bool UnRegister_0(IntPtr /*(vtkCollection*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

}
};
