
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkCellArray {

// static vtkCellArray* New()
// static vtkCellArray *New()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_New_0")] public static extern 
bool vtkCellArray_New_0(IntPtr /*(vtkCellArray**)*/ return_value);

// int Allocate(vtkIdType sz, vtkIdType ext = 1000)
// int Allocate(vtkIdType sz, vtkIdType ext=1000)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_Allocate_0")] public static extern 
bool vtkCellArray_Allocate_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_Initialize_0")] public static extern 
bool vtkCellArray_Initialize_0(IntPtr /*(vtkCellArray*)*/ callingObject);

// vtkIdType EstimateSize(vtkIdType numCells, int maxPtsPerCell)
// vtkIdType EstimateSize(vtkIdType numCells, int maxPtsPerCell)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_EstimateSize_0")] public static extern 
bool vtkCellArray_EstimateSize_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ numCells, int /*(int)*/ maxPtsPerCell);

// void InitTraversal()
// void InitTraversal()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_InitTraversal_0")] public static extern 
bool vtkCellArray_InitTraversal_0(IntPtr /*(vtkCellArray*)*/ callingObject);

// int GetNextCell(vtkIdList * pts)
// int GetNextCell(vtkIdList *pts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetNextCell_0")] public static extern 
bool vtkCellArray_GetNextCell_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, IntPtr /*(vtkIdList*)*/ pts);

// vtkIdType GetSize()
// vtkIdType GetSize()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetSize_0")] public static extern 
bool vtkCellArray_GetSize_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

// vtkIdType GetNumberOfConnectivityEntries()
// vtkIdType GetNumberOfConnectivityEntries()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetNumberOfConnectivityEntries_0")] public static extern 
bool vtkCellArray_GetNumberOfConnectivityEntries_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

// void GetCell(vtkIdType loc, vtkIdType & npts, vtkIdType *& pts)
// void GetCell(vtkIdType loc, vtkIdType &npts, vtkIdType* &pts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetCell_0")] public static extern 
bool vtkCellArray_GetCell_0(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ loc, IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(vtkIdType*&)*/ pts);

// void GetCell(vtkIdType loc, vtkIdList * pts)
// void GetCell(vtkIdType loc, vtkIdList* pts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetCell_1")] public static extern 
bool vtkCellArray_GetCell_1(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ loc, IntPtr /*(vtkIdList*)*/ pts);

// vtkIdType InsertNextCell(vtkCell * cell)
// vtkIdType InsertNextCell(vtkCell *cell)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_InsertNextCell_0")] public static extern 
bool vtkCellArray_InsertNextCell_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, IntPtr /*(vtkCell*)*/ cell);

// vtkIdType InsertNextCell(vtkIdList * pts)
// vtkIdType InsertNextCell(vtkIdList *pts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_InsertNextCell_1")] public static extern 
bool vtkCellArray_InsertNextCell_1(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, IntPtr /*(vtkIdList*)*/ pts);

// vtkIdType InsertNextCell(int npts)
// vtkIdType InsertNextCell(int npts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_InsertNextCell_2")] public static extern 
bool vtkCellArray_InsertNextCell_2(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, int /*(int)*/ npts);

// void InsertCellPoint(vtkIdType id)
// void InsertCellPoint(vtkIdType id)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_InsertCellPoint_0")] public static extern 
bool vtkCellArray_InsertCellPoint_0(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ id);

// void UpdateCellCount(int npts)
// void UpdateCellCount(int npts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_UpdateCellCount_0")] public static extern 
bool vtkCellArray_UpdateCellCount_0(IntPtr /*(vtkCellArray*)*/ callingObject, int /*(int)*/ npts);

// vtkIdType GetInsertLocation(int npts)
// vtkIdType GetInsertLocation(int npts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetInsertLocation_0")] public static extern 
bool vtkCellArray_GetInsertLocation_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, int /*(int)*/ npts);

// vtkIdType GetTraversalLocation()
// vtkIdType GetTraversalLocation()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetTraversalLocation_0")] public static extern 
bool vtkCellArray_GetTraversalLocation_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

// void SetTraversalLocation(vtkIdType loc)
// void SetTraversalLocation(vtkIdType loc)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_SetTraversalLocation_0")] public static extern 
bool vtkCellArray_SetTraversalLocation_0(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ loc);

// vtkIdType GetTraversalLocation(vtkIdType npts)
// vtkIdType GetTraversalLocation(vtkIdType npts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetTraversalLocation_1")] public static extern 
bool vtkCellArray_GetTraversalLocation_1(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ npts);

// void ReverseCell(vtkIdType loc)
// void ReverseCell(vtkIdType loc)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_ReverseCell_0")] public static extern 
bool vtkCellArray_ReverseCell_0(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ loc);

// void ReplaceCell(vtkIdType loc, int npts, const vtkIdType * pts)
// void ReplaceCell(vtkIdType loc, int npts, const vtkIdType *pts)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_ReplaceCell_0")] public static extern 
bool vtkCellArray_ReplaceCell_0(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ loc, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts);

// int GetMaxCellSize()
// int GetMaxCellSize()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetMaxCellSize_0")] public static extern 
bool vtkCellArray_GetMaxCellSize_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

// vtkIdType* GetPointer()
// vtkIdType *GetPointer()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetPointer_0")] public static extern 
bool vtkCellArray_GetPointer_0(IntPtr /*(vtkIdType**)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

// vtkIdType* WritePointer(const vtkIdType ncells, const vtkIdType size)
// vtkIdType *WritePointer(const vtkIdType ncells, const vtkIdType size)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_WritePointer_0")] public static extern 
bool vtkCellArray_WritePointer_0(IntPtr /*(vtkIdType**)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ ncells, long /*(vtkIdType)*/ size);

// void SetCells(vtkIdType ncells, vtkIdTypeArray * cells)
// void SetCells(vtkIdType ncells, vtkIdTypeArray *cells)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_SetCells_0")] public static extern 
bool vtkCellArray_SetCells_0(IntPtr /*(vtkCellArray*)*/ callingObject, long /*(vtkIdType)*/ ncells, IntPtr /*(vtkIdTypeArray*)*/ cells);

// void DeepCopy(vtkCellArray * ca)
// void DeepCopy(vtkCellArray *ca)
[DllImport("vtkplugin", EntryPoint="vtkCellArray_DeepCopy_0")] public static extern 
bool vtkCellArray_DeepCopy_0(IntPtr /*(vtkCellArray*)*/ callingObject, IntPtr /*(vtkCellArray*)*/ ca);

// vtkIdTypeArray* GetData()
// vtkIdTypeArray* GetData()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetData_0")] public static extern 
bool vtkCellArray_GetData_0(IntPtr /*(vtkIdTypeArray**)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

// void Reset()
// void Reset()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_Reset_0")] public static extern 
bool vtkCellArray_Reset_0(IntPtr /*(vtkCellArray*)*/ callingObject);

// void Squeeze()
// void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_Squeeze_0")] public static extern 
bool vtkCellArray_Squeeze_0(IntPtr /*(vtkCellArray*)*/ callingObject);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkCellArray_GetActualMemorySize_0")] public static extern 
bool vtkCellArray_GetActualMemorySize_0(IntPtr /*(long*)*/ return_value, IntPtr /*(vtkCellArray*)*/ callingObject);

}
};
