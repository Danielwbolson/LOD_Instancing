
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkIdList {

// static vtkIdList* New()
// static vtkIdList *New()
[DllImport("vtkplugin", EntryPoint="vtkIdList_New_0")] public static extern 
bool vtkIdList_New_0(IntPtr /*(vtkIdList**)*/ return_value);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkIdList_Initialize_0")] public static extern 
bool vtkIdList_Initialize_0(IntPtr /*(vtkIdList*)*/ callingObject);

// int Allocate(const vtkIdType sz, const int strategy = 0)
// int Allocate(const vtkIdType sz, const int strategy=0)
[DllImport("vtkplugin", EntryPoint="vtkIdList_Allocate_0")] public static extern 
bool vtkIdList_Allocate_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkIdList*)*/ callingObject, long /*(vtkIdType)*/ sz, int /*(int)*/ strategy);

// vtkIdType GetNumberOfIds()
// vtkIdType GetNumberOfIds()
[DllImport("vtkplugin", EntryPoint="vtkIdList_GetNumberOfIds_0")] public static extern 
bool vtkIdList_GetNumberOfIds_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkIdList*)*/ callingObject);

// vtkIdType GetId(const vtkIdType i)
// vtkIdType GetId(const vtkIdType i)
[DllImport("vtkplugin", EntryPoint="vtkIdList_GetId_0")] public static extern 
bool vtkIdList_GetId_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkIdList*)*/ callingObject, long /*(vtkIdType)*/ i);

// void SetNumberOfIds(const vtkIdType number)
// void SetNumberOfIds(const vtkIdType number)
[DllImport("vtkplugin", EntryPoint="vtkIdList_SetNumberOfIds_0")] public static extern 
bool vtkIdList_SetNumberOfIds_0(IntPtr /*(vtkIdList*)*/ callingObject, long /*(vtkIdType)*/ number);

// void SetId(const vtkIdType i, const vtkIdType vtkid)
// void SetId(const vtkIdType i, const vtkIdType vtkid)
[DllImport("vtkplugin", EntryPoint="vtkIdList_SetId_0")] public static extern 
bool vtkIdList_SetId_0(IntPtr /*(vtkIdList*)*/ callingObject, long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ vtkid);

// void InsertId(const vtkIdType i, const vtkIdType vtkid)
// void InsertId(const vtkIdType i, const vtkIdType vtkid)
[DllImport("vtkplugin", EntryPoint="vtkIdList_InsertId_0")] public static extern 
bool vtkIdList_InsertId_0(IntPtr /*(vtkIdList*)*/ callingObject, long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ vtkid);

// vtkIdType InsertNextId(const vtkIdType vtkid)
// vtkIdType InsertNextId(const vtkIdType vtkid)
[DllImport("vtkplugin", EntryPoint="vtkIdList_InsertNextId_0")] public static extern 
bool vtkIdList_InsertNextId_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkIdList*)*/ callingObject, long /*(vtkIdType)*/ vtkid);

// vtkIdType InsertUniqueId(const vtkIdType vtkid)
// vtkIdType InsertUniqueId(const vtkIdType vtkid)
[DllImport("vtkplugin", EntryPoint="vtkIdList_InsertUniqueId_0")] public static extern 
bool vtkIdList_InsertUniqueId_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkIdList*)*/ callingObject, long /*(vtkIdType)*/ vtkid);

// vtkIdType* GetPointer(const vtkIdType i)
// vtkIdType *GetPointer(const vtkIdType i)
[DllImport("vtkplugin", EntryPoint="vtkIdList_GetPointer_0")] public static extern 
bool vtkIdList_GetPointer_0(IntPtr /*(vtkIdType**)*/ return_value, IntPtr /*(vtkIdList*)*/ callingObject, long /*(vtkIdType)*/ i);

// vtkIdType* WritePointer(const vtkIdType i, const vtkIdType number)
// vtkIdType *WritePointer(const vtkIdType i, const vtkIdType number)
[DllImport("vtkplugin", EntryPoint="vtkIdList_WritePointer_0")] public static extern 
bool vtkIdList_WritePointer_0(IntPtr /*(vtkIdType**)*/ return_value, IntPtr /*(vtkIdList*)*/ callingObject, long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ number);

// void SetArray(vtkIdType * array, vtkIdType size)
// void SetArray(vtkIdType *array, vtkIdType size)
[DllImport("vtkplugin", EntryPoint="vtkIdList_SetArray_0")] public static extern 
bool vtkIdList_SetArray_0(IntPtr /*(vtkIdList*)*/ callingObject, IntPtr /*(vtkIdType*)*/ array, long /*(vtkIdType)*/ size);

// void Reset()
// void Reset()
[DllImport("vtkplugin", EntryPoint="vtkIdList_Reset_0")] public static extern 
bool vtkIdList_Reset_0(IntPtr /*(vtkIdList*)*/ callingObject);

// void Squeeze()
// void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkIdList_Squeeze_0")] public static extern 
bool vtkIdList_Squeeze_0(IntPtr /*(vtkIdList*)*/ callingObject);

// void DeepCopy(vtkIdList * ids)
// void DeepCopy(vtkIdList *ids)
[DllImport("vtkplugin", EntryPoint="vtkIdList_DeepCopy_0")] public static extern 
bool vtkIdList_DeepCopy_0(IntPtr /*(vtkIdList*)*/ callingObject, IntPtr /*(vtkIdList*)*/ ids);

// void DeleteId(vtkIdType vtkid)
// void DeleteId(vtkIdType vtkid)
[DllImport("vtkplugin", EntryPoint="vtkIdList_DeleteId_0")] public static extern 
bool vtkIdList_DeleteId_0(IntPtr /*(vtkIdList*)*/ callingObject, long /*(vtkIdType)*/ vtkid);

// vtkIdType IsId(vtkIdType vtkid)
// vtkIdType IsId(vtkIdType vtkid)
[DllImport("vtkplugin", EntryPoint="vtkIdList_IsId_0")] public static extern 
bool vtkIdList_IsId_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkIdList*)*/ callingObject, long /*(vtkIdType)*/ vtkid);

// void IntersectWith(vtkIdList * otherIds)
// void IntersectWith(vtkIdList* otherIds)
[DllImport("vtkplugin", EntryPoint="vtkIdList_IntersectWith_0")] public static extern 
bool vtkIdList_IntersectWith_0(IntPtr /*(vtkIdList*)*/ callingObject, IntPtr /*(vtkIdList*)*/ otherIds);

// vtkIdType* Resize(const vtkIdType sz)
// vtkIdType *Resize(const vtkIdType sz)
[DllImport("vtkplugin", EntryPoint="vtkIdList_Resize_0")] public static extern 
bool vtkIdList_Resize_0(IntPtr /*(vtkIdType**)*/ return_value, IntPtr /*(vtkIdList*)*/ callingObject, long /*(vtkIdType)*/ sz);

// void IntersectWith(vtkIdList & otherIds)
// void IntersectWith(vtkIdList& otherIds)
[DllImport("vtkplugin", EntryPoint="vtkIdList_IntersectWith_1")] public static extern 
bool vtkIdList_IntersectWith_1(IntPtr /*(vtkIdList*)*/ callingObject, IntPtr /*(vtkIdList&)*/ otherIds);

}
};
