
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkCellArray {

//       Method: virtual const char * vtkCellArray::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkCellArray* */ obj);

//       Method: static vtkCellArray * vtkCellArray::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkCellArray_New_0")] public static extern 
bool New(IntPtr /*vtkCellArray** */ ret);

//       Method: int vtkCellArray::Allocate(vtkIdType sz, vtkIdType ext)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_Allocate_0")] public static extern 
bool Allocate(IntPtr /*int* */ ret, IntPtr /*vtkCellArray* */ obj, long sz, long ext);

//       Method: void vtkCellArray::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkCellArray* */ obj);

//       Method: vtkIdType vtkCellArray::EstimateSize(vtkIdType numCells, int maxPtsPerCell)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_EstimateSize_0")] public static extern 
bool EstimateSize(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellArray* */ obj, long numCells, int maxPtsPerCell);

//       Method: void vtkCellArray::InitTraversal()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_InitTraversal_0")] public static extern 
bool InitTraversal(IntPtr /*vtkCellArray* */ obj);

//       Method: int vtkCellArray::GetNextCell(vtkIdList* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_GetNextCell_1")] public static extern 
bool GetNextCell(IntPtr /*int* */ ret, IntPtr /*vtkCellArray* */ obj, IntPtr/*vtkIdList* */ pts);

//       Method: vtkIdType vtkCellArray::GetSize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_GetSize_0")] public static extern 
bool GetSize(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellArray* */ obj);

//       Method: vtkIdType vtkCellArray::GetNumberOfConnectivityEntries()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_GetNumberOfConnectivityEntries_0")] public static extern 
bool GetNumberOfConnectivityEntries(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellArray* */ obj);

//       Method: void vtkCellArray::GetCell(vtkIdType loc, vtkIdList* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_GetCell_1")] public static extern 
bool GetCell(IntPtr /*vtkCellArray* */ obj, long loc, IntPtr/*vtkIdList* */ pts);

//       Method: vtkIdType vtkCellArray::InsertNextCell(vtkCell* cell)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_InsertNextCell_0")] public static extern 
bool InsertNextCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellArray* */ obj, IntPtr/*vtkCell* */ cell);

//       Method: vtkIdType vtkCellArray::InsertNextCell(vtkIdType npts, const vtkIdType* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_InsertNextCell_1")] public static extern 
bool InsertNextCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellArray* */ obj, long npts, IntPtr/*const vtkIdType* */ pts);

////       Method: vtkIdType vtkCellArray::InsertNextCell(vtkIdList* pts)
//// 
//[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_InsertNextCell_2")] public static extern 
//bool InsertNextCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellArray* */ obj, IntPtr/*vtkIdList* */ pts);
//
//       Method: vtkIdType vtkCellArray::InsertNextCell(int npts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_InsertNextCell_3")] public static extern 
bool InsertNextCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellArray* */ obj, int npts);

//       Method: void vtkCellArray::InsertCellPoint(vtkIdType id)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_InsertCellPoint_0")] public static extern 
bool InsertCellPoint(IntPtr /*vtkCellArray* */ obj, long id);

//       Method: void vtkCellArray::UpdateCellCount(int npts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_UpdateCellCount_0")] public static extern 
bool UpdateCellCount(IntPtr /*vtkCellArray* */ obj, int npts);

//       Method: vtkIdType vtkCellArray::GetInsertLocation(int npts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_GetInsertLocation_0")] public static extern 
bool GetInsertLocation(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellArray* */ obj, int npts);

//       Method: vtkIdType vtkCellArray::GetTraversalLocation()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_GetTraversalLocation_0")] public static extern 
bool GetTraversalLocation(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellArray* */ obj);

//       Method: void vtkCellArray::SetTraversalLocation(vtkIdType loc)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_SetTraversalLocation_0")] public static extern 
bool SetTraversalLocation(IntPtr /*vtkCellArray* */ obj, long loc);

//       Method: vtkIdType vtkCellArray::GetTraversalLocation(vtkIdType npts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_GetTraversalLocation_1")] public static extern 
bool GetTraversalLocation(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellArray* */ obj, long npts);

//       Method: void vtkCellArray::ReverseCell(vtkIdType loc)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_ReverseCell_0")] public static extern 
bool ReverseCell(IntPtr /*vtkCellArray* */ obj, long loc);

//       Method: void vtkCellArray::ReplaceCell(vtkIdType loc, int npts, const vtkIdType* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_ReplaceCell_0")] public static extern 
bool ReplaceCell(IntPtr /*vtkCellArray* */ obj, long loc, int npts, IntPtr/*const vtkIdType* */ pts);

//       Method: int vtkCellArray::GetMaxCellSize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_GetMaxCellSize_0")] public static extern 
bool GetMaxCellSize(IntPtr /*int* */ ret, IntPtr /*vtkCellArray* */ obj);

//       Method: vtkIdType * vtkCellArray::GetPointer()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_GetPointer_0")] public static extern 
bool GetPointer(IntPtr /*vtkIdType** */ ret, IntPtr /*vtkCellArray* */ obj);

//       Method: vtkIdType * vtkCellArray::WritePointer(const vtkIdType ncells, const vtkIdType size)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_WritePointer_0")] public static extern 
bool WritePointer(IntPtr /*vtkIdType** */ ret, IntPtr /*vtkCellArray* */ obj, long ncells, long size);

//       Method: void vtkCellArray::SetCells(vtkIdType ncells, vtkIdTypeArray* cells)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_SetCells_0")] public static extern 
bool SetCells(IntPtr /*vtkCellArray* */ obj, long ncells, IntPtr/*vtkIdTypeArray* */ cells);

//       Method: void vtkCellArray::DeepCopy(vtkCellArray* ca)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkCellArray* */ obj, IntPtr/*vtkCellArray* */ ca);

//       Method: vtkIdTypeArray * vtkCellArray::GetData()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_GetData_0")] public static extern 
bool GetData(IntPtr /*vtkIdTypeArray** */ ret, IntPtr /*vtkCellArray* */ obj);

//       Method: void vtkCellArray::Reset()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_Reset_0")] public static extern 
bool Reset(IntPtr /*vtkCellArray* */ obj);

//       Method: void vtkCellArray::Squeeze()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellArray_Squeeze_0")] public static extern 
bool Squeeze(IntPtr /*vtkCellArray* */ obj);

}
};
