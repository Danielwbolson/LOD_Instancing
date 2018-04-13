
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkUnstructuredGridBase {

//       Method: int vtkUnstructuredGridBase::GetDataObjectType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGridBase_GetDataObjectType_0")] public static extern 
bool GetDataObjectType(IntPtr /*int* */ ret, IntPtr /*vtkUnstructuredGridBase* */ obj);

//       Method: virtual void vtkUnstructuredGridBase::Allocate(vtkIdType numCells, int extSize)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGridBase_Allocate_0")] public static extern 
bool Allocate(IntPtr /*vtkUnstructuredGridBase* */ obj, long numCells, int extSize);

//       Method: void vtkUnstructuredGridBase::DeepCopy(vtkDataObject* src)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGridBase_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkUnstructuredGridBase* */ obj, IntPtr/*vtkDataObject* */ src);

//       Method: virtual vtkIdType vtkUnstructuredGridBase::InsertNextCell(int type, vtkIdType npts, vtkIdType* ptIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGridBase_InsertNextCell_0")] public static extern 
bool InsertNextCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkUnstructuredGridBase* */ obj, int type, long npts, IntPtr/*vtkIdType* */ ptIds);

//       Method: virtual vtkIdType vtkUnstructuredGridBase::InsertNextCell(int type, vtkIdList* ptIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGridBase_InsertNextCell_1")] public static extern 
bool InsertNextCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkUnstructuredGridBase* */ obj, int type, IntPtr/*vtkIdList* */ ptIds);

//       Method: virtual vtkIdType vtkUnstructuredGridBase::InsertNextCell(int type, vtkIdType npts, vtkIdType* ptIds, vtkIdType nfaces, vtkIdType* faces)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGridBase_InsertNextCell_2")] public static extern 
bool InsertNextCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkUnstructuredGridBase* */ obj, int type, long npts, IntPtr/*vtkIdType* */ ptIds, long nfaces, IntPtr/*vtkIdType* */ faces);

//       Method: virtual void vtkUnstructuredGridBase::ReplaceCell(vtkIdType cellId, int npts, vtkIdType* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGridBase_ReplaceCell_0")] public static extern 
bool ReplaceCell(IntPtr /*vtkUnstructuredGridBase* */ obj, long cellId, int npts, IntPtr/*vtkIdType* */ pts);

//       Method: virtual void vtkUnstructuredGridBase::GetIdsOfCellsOfType(int type, vtkIdTypeArray* array)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGridBase_GetIdsOfCellsOfType_0")] public static extern 
bool GetIdsOfCellsOfType(IntPtr /*vtkUnstructuredGridBase* */ obj, int type, IntPtr/*vtkIdTypeArray* */ array);

//       Method: virtual int vtkUnstructuredGridBase::IsHomogeneous()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGridBase_IsHomogeneous_0")] public static extern 
bool IsHomogeneous(IntPtr /*int* */ ret, IntPtr /*vtkUnstructuredGridBase* */ obj);

//       Method: static vtkUnstructuredGridBase * vtkUnstructuredGridBase::GetData(vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkUnstructuredGridBase_GetData_0")] public static extern 
bool GetData(IntPtr /*vtkUnstructuredGridBase** */ ret, IntPtr/*vtkInformation* */ info);

//       Method: static vtkUnstructuredGridBase * vtkUnstructuredGridBase::GetData(vtkInformationVector* v, int i)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkUnstructuredGridBase_GetData_1")] public static extern 
bool GetData(IntPtr /*vtkUnstructuredGridBase** */ ret, IntPtr/*vtkInformationVector* */ v, int i);

}
};
