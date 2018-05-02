
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkCellArray {

// static vtkCellArray* New()
// static vtkCellArray *New()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// int Allocate(vtkIdType sz, vtkIdType ext = 1000)
// int Allocate(vtkIdType sz, vtkIdType ext=1000)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_Allocate_0")] public static extern 
bool Allocate_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkCellArray*)*/ callingObject);

// vtkIdType EstimateSize(vtkIdType numCells, int maxPtsPerCell)
// vtkIdType EstimateSize(vtkIdType numCells, int maxPtsPerCell)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_EstimateSize_0")] public static extern 
bool EstimateSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ numCells, int /*(int)*/ maxPtsPerCell);

// void InitTraversal()
// void InitTraversal()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_InitTraversal_0")] public static extern 
bool InitTraversal_0(IntPtr /*(vtkCellArray*)*/ callingObject);

// int GetNextCell(vtkIdList * pts)
// int GetNextCell(vtkIdList *pts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetNextCell_0")] public static extern 
bool GetNextCell_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, IntPtr /*(vtkIdList*)*/ pts);

// vtkIdType GetSize()
// vtkIdType GetSize()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetSize_0")] public static extern 
bool GetSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

// vtkIdType GetNumberOfConnectivityEntries()
// vtkIdType GetNumberOfConnectivityEntries()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetNumberOfConnectivityEntries_0")] public static extern 
bool GetNumberOfConnectivityEntries_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

// void GetCell(vtkIdType loc, vtkIdType & npts, vtkIdType *& pts)
// void GetCell(vtkIdType loc, vtkIdType &npts, vtkIdType* &pts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetCell_0")] public static extern 
bool GetCell_0(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ loc, IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(vtkIdType*&)*/ pts);

// void GetCell(vtkIdType loc, vtkIdList * pts)
// void GetCell(vtkIdType loc, vtkIdList* pts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetCell_1")] public static extern 
bool GetCell_1(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ loc, IntPtr /*(vtkIdList*)*/ pts);

// vtkIdType InsertNextCell(vtkCell * cell)
// vtkIdType InsertNextCell(vtkCell *cell)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_InsertNextCell_0")] public static extern 
bool InsertNextCell_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, IntPtr /*(vtkCell*)*/ cell);

// vtkIdType InsertNextCell(vtkIdList * pts)
// vtkIdType InsertNextCell(vtkIdList *pts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_InsertNextCell_1")] public static extern 
bool InsertNextCell_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, IntPtr /*(vtkIdList*)*/ pts);

// vtkIdType InsertNextCell(int npts)
// vtkIdType InsertNextCell(int npts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_InsertNextCell_2")] public static extern 
bool InsertNextCell_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, int /*(int)*/ npts);

// void InsertCellPoint(vtkIdType id)
// void InsertCellPoint(vtkIdType id)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_InsertCellPoint_0")] public static extern 
bool InsertCellPoint_0(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ id);

// void UpdateCellCount(int npts)
// void UpdateCellCount(int npts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_UpdateCellCount_0")] public static extern 
bool UpdateCellCount_0(IntPtr /*(vtkCellArray*)*/ callingObject, int /*(int)*/ npts);

// vtkIdType GetInsertLocation(int npts)
// vtkIdType GetInsertLocation(int npts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetInsertLocation_0")] public static extern 
bool GetInsertLocation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, int /*(int)*/ npts);

// vtkIdType GetTraversalLocation()
// vtkIdType GetTraversalLocation()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetTraversalLocation_0")] public static extern 
bool GetTraversalLocation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

// void SetTraversalLocation(vtkIdType loc)
// void SetTraversalLocation(vtkIdType loc)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_SetTraversalLocation_0")] public static extern 
bool SetTraversalLocation_0(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ loc);

// vtkIdType GetTraversalLocation(vtkIdType npts)
// vtkIdType GetTraversalLocation(vtkIdType npts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetTraversalLocation_1")] public static extern 
bool GetTraversalLocation_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ npts);

// void ReverseCell(vtkIdType loc)
// void ReverseCell(vtkIdType loc)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_ReverseCell_0")] public static extern 
bool ReverseCell_0(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ loc);

// void ReplaceCell(vtkIdType loc, int npts, const vtkIdType * pts)
// void ReplaceCell(vtkIdType loc, int npts, const vtkIdType *pts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_ReplaceCell_0")] public static extern 
bool ReplaceCell_0(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ loc, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts);

// int GetMaxCellSize()
// int GetMaxCellSize()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetMaxCellSize_0")] public static extern 
bool GetMaxCellSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

// vtkIdType* GetPointer()
// vtkIdType *GetPointer()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetPointer_0")] public static extern 
bool GetPointer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

// vtkIdType* WritePointer(const vtkIdType ncells, const vtkIdType size)
// vtkIdType *WritePointer(const vtkIdType ncells, const vtkIdType size)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_WritePointer_0")] public static extern 
bool WritePointer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ ncells, long /*(vtkIdType)*/ size);

// void SetCells(vtkIdType ncells, vtkIdTypeArray * cells)
// void SetCells(vtkIdType ncells, vtkIdTypeArray *cells)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_SetCells_0")] public static extern 
bool SetCells_0(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ ncells, IntPtr /*(vtkIdTypeArray*)*/ cells);

// void DeepCopy(vtkCellArray * ca)
// void DeepCopy(vtkCellArray *ca)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkCellArray*)*/ callingObject, IntPtr /*(vtkCellArray*)*/ ca);

// vtkIdTypeArray* GetData()
// vtkIdTypeArray* GetData()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetData_0")] public static extern 
bool GetData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

// void Reset()
// void Reset()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_Reset_0")] public static extern 
bool Reset_0(IntPtr /*(vtkCellArray*)*/ callingObject);

// void Squeeze()
// void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_Squeeze_0")] public static extern 
bool Squeeze_0(IntPtr /*(vtkCellArray*)*/ callingObject);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetActualMemorySize_0")] public static extern 
bool GetActualMemorySize_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

}
};
