
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkIdList {

//       Method: static vtkIdList * vtkIdList::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkIdList_New_0")] public static extern 
bool New(IntPtr /*vtkIdList** */ ret);

//       Method: void vtkIdList::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkIdList* */ obj);

//       Method: int vtkIdList::Allocate(const vtkIdType sz, const int strategy)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_Allocate_0")] public static extern 
bool Allocate(IntPtr /*int* */ ret, IntPtr /*vtkIdList* */ obj, long sz, int strategy);

//       Method: virtual const char * vtkIdList::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkIdList* */ obj);

//       Method: vtkIdType vtkIdList::GetNumberOfIds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_GetNumberOfIds_0")] public static extern 
bool GetNumberOfIds(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkIdList* */ obj);

//       Method: vtkIdType vtkIdList::GetId(const vtkIdType i)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_GetId_0")] public static extern 
bool GetId(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkIdList* */ obj, long i);

//       Method: void vtkIdList::SetNumberOfIds(const vtkIdType number)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_SetNumberOfIds_0")] public static extern 
bool SetNumberOfIds(IntPtr /*vtkIdList* */ obj, long number);

//       Method: void vtkIdList::SetId(const vtkIdType i, const vtkIdType vtkid)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_SetId_0")] public static extern 
bool SetId(IntPtr /*vtkIdList* */ obj, long i, long vtkid);

//       Method: void vtkIdList::InsertId(const vtkIdType i, const vtkIdType vtkid)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_InsertId_0")] public static extern 
bool InsertId(IntPtr /*vtkIdList* */ obj, long i, long vtkid);

//  Constructor: vtkIdList::VTK_EXPECTS()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_VTK_EXPECTS_0")] public static extern 
bool VTK_EXPECTS(IntPtr /*vtkIdList* */ obj);

//       Method: vtkIdType vtkIdList::InsertNextId(const vtkIdType vtkid)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_InsertNextId_0")] public static extern 
bool InsertNextId(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkIdList* */ obj, long vtkid);

//       Method: vtkIdType vtkIdList::InsertUniqueId(const vtkIdType vtkid)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_InsertUniqueId_0")] public static extern 
bool InsertUniqueId(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkIdList* */ obj, long vtkid);

//       Method: vtkIdType * vtkIdList::GetPointer(const vtkIdType i)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_GetPointer_0")] public static extern 
bool GetPointer(IntPtr /*vtkIdType** */ ret, IntPtr /*vtkIdList* */ obj, long i);

//       Method: vtkIdType * vtkIdList::WritePointer(const vtkIdType i, const vtkIdType number)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_WritePointer_0")] public static extern 
bool WritePointer(IntPtr /*vtkIdType** */ ret, IntPtr /*vtkIdList* */ obj, long i, long number);

//       Method: void vtkIdList::SetArray(vtkIdType* array, vtkIdType size)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_SetArray_0")] public static extern 
bool SetArray(IntPtr /*vtkIdList* */ obj, IntPtr/*vtkIdType* */ array, long size);

//       Method: void vtkIdList::Reset()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_Reset_0")] public static extern 
bool Reset(IntPtr /*vtkIdList* */ obj);

//       Method: void vtkIdList::Squeeze()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_Squeeze_0")] public static extern 
bool Squeeze(IntPtr /*vtkIdList* */ obj);

//       Method: void vtkIdList::DeepCopy(vtkIdList* ids)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkIdList* */ obj, IntPtr/*vtkIdList* */ ids);

//       Method: void vtkIdList::DeleteId(vtkIdType vtkid)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_DeleteId_0")] public static extern 
bool DeleteId(IntPtr /*vtkIdList* */ obj, long vtkid);

//       Method: vtkIdType vtkIdList::IsId(vtkIdType vtkid)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_IsId_0")] public static extern 
bool IsId(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkIdList* */ obj, long vtkid);

//       Method: void vtkIdList::IntersectWith(vtkIdList* otherIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_IntersectWith_0")] public static extern 
bool IntersectWith(IntPtr /*vtkIdList* */ obj, IntPtr/*vtkIdList* */ otherIds);

//       Method: vtkIdType * vtkIdList::Resize(const vtkIdType sz)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIdList_Resize_0")] public static extern 
bool Resize(IntPtr /*vtkIdType** */ ret, IntPtr /*vtkIdList* */ obj, long sz);

}
};
