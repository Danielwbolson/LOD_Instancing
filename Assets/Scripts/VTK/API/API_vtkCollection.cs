
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkCollection {

// static vtkCollection* New()
// static vtkCollection *New()
[DllImport("vtkplugin", EntryPoint="vtkCollection_New_0")] public static extern 
bool vtkCollection_New_0(IntPtr /*(vtkCollection**)*/ return_value);

// void AddItem(vtkObject * ARG_0)
// void AddItem(vtkObject *)
[DllImport("vtkplugin", EntryPoint="vtkCollection_AddItem_0")] public static extern 
bool vtkCollection_AddItem_0(IntPtr /*(vtkCollection*)*/ callingObject, IntPtr /*(vtkObject*)*/ ARG_0);

// void InsertItem(int i, vtkObject * ARG_0)
// void InsertItem(int i, vtkObject *)
[DllImport("vtkplugin", EntryPoint="vtkCollection_InsertItem_0")] public static extern 
bool vtkCollection_InsertItem_0(IntPtr /*(vtkCollection*)*/ callingObject, int /*(int)*/ i, IntPtr /*(vtkObject*)*/ ARG_0);

// void ReplaceItem(int i, vtkObject * ARG_0)
// void ReplaceItem(int i, vtkObject *)
[DllImport("vtkplugin", EntryPoint="vtkCollection_ReplaceItem_0")] public static extern 
bool vtkCollection_ReplaceItem_0(IntPtr /*(vtkCollection*)*/ callingObject, int /*(int)*/ i, IntPtr /*(vtkObject*)*/ ARG_0);

// void RemoveItem(int i)
// void RemoveItem(int i)
[DllImport("vtkplugin", EntryPoint="vtkCollection_RemoveItem_0")] public static extern 
bool vtkCollection_RemoveItem_0(IntPtr /*(vtkCollection*)*/ callingObject, int /*(int)*/ i);

// void RemoveItem(vtkObject * ARG_0)
// void RemoveItem(vtkObject *)
[DllImport("vtkplugin", EntryPoint="vtkCollection_RemoveItem_1")] public static extern 
bool vtkCollection_RemoveItem_1(IntPtr /*(vtkCollection*)*/ callingObject, IntPtr /*(vtkObject*)*/ ARG_0);

// void RemoveAllItems()
// void RemoveAllItems()
[DllImport("vtkplugin", EntryPoint="vtkCollection_RemoveAllItems_0")] public static extern 
bool vtkCollection_RemoveAllItems_0(IntPtr /*(vtkCollection*)*/ callingObject);

// int IsItemPresent(vtkObject * a)
// int IsItemPresent(vtkObject *a)
[DllImport("vtkplugin", EntryPoint="vtkCollection_IsItemPresent_0")] public static extern 
bool vtkCollection_IsItemPresent_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCollection*)*/ callingObject, IntPtr /*(vtkObject*)*/ a);

// int GetNumberOfItems()
// int GetNumberOfItems()
[DllImport("vtkplugin", EntryPoint="vtkCollection_GetNumberOfItems_0")] public static extern 
bool vtkCollection_GetNumberOfItems_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCollection*)*/ callingObject);

// void InitTraversal()
// void InitTraversal()
[DllImport("vtkplugin", EntryPoint="vtkCollection_InitTraversal_0")] public static extern 
bool vtkCollection_InitTraversal_0(IntPtr /*(vtkCollection*)*/ callingObject);

// void InitTraversal(vtkCollectionSimpleIterator & cookie)
// void InitTraversal(vtkCollectionSimpleIterator &cookie)
[DllImport("vtkplugin", EntryPoint="vtkCollection_InitTraversal_1")] public static extern 
bool vtkCollection_InitTraversal_1(IntPtr /*(vtkCollection*)*/ callingObject, IntPtr /*(vtkCollectionSimpleIterator&)*/ cookie);

// vtkObject* GetNextItemAsObject()
// vtkObject *GetNextItemAsObject()
[DllImport("vtkplugin", EntryPoint="vtkCollection_GetNextItemAsObject_0")] public static extern 
bool vtkCollection_GetNextItemAsObject_0(IntPtr /*(vtkObject**)*/ return_value, IntPtr /*(vtkCollection*)*/ callingObject);

// vtkObject* GetItemAsObject(int i)
// vtkObject *GetItemAsObject(int i)
[DllImport("vtkplugin", EntryPoint="vtkCollection_GetItemAsObject_0")] public static extern 
bool vtkCollection_GetItemAsObject_0(IntPtr /*(vtkObject**)*/ return_value, IntPtr /*(vtkCollection*)*/ callingObject, int /*(int)*/ i);

// vtkObject* GetNextItemAsObject(vtkCollectionSimpleIterator & cookie)
// vtkObject *GetNextItemAsObject(vtkCollectionSimpleIterator &cookie)
[DllImport("vtkplugin", EntryPoint="vtkCollection_GetNextItemAsObject_1")] public static extern 
bool vtkCollection_GetNextItemAsObject_1(IntPtr /*(vtkObject**)*/ return_value, IntPtr /*(vtkCollection*)*/ callingObject, IntPtr /*(vtkCollectionSimpleIterator&)*/ cookie);

// void Register(vtkObjectBase * o)
// void Register(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkCollection_Register_0")] public static extern 
bool vtkCollection_Register_0(IntPtr /*(vtkCollection*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkCollection_UnRegister_0")] public static extern 
bool vtkCollection_UnRegister_0(IntPtr /*(vtkCollection*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

}
};
