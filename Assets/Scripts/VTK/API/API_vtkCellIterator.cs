
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkCellIterator {

// void InitTraversal()
// void InitTraversal()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_InitTraversal_0")] public static extern 
bool vtkCellIterator_InitTraversal_0(IntPtr /*(vtkCellIterator*)*/ callingObject);

// void GoToNextCell()
// void GoToNextCell()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GoToNextCell_0")] public static extern 
bool vtkCellIterator_GoToNextCell_0(IntPtr /*(vtkCellIterator*)*/ callingObject);

// virtual bool IsDoneWithTraversal()
// virtual bool IsDoneWithTraversal()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_IsDoneWithTraversal_0")] public static extern 
bool vtkCellIterator_IsDoneWithTraversal_0(IntPtr /*(bool*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// int GetCellType()
// int GetCellType()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetCellType_0")] public static extern 
bool vtkCellIterator_GetCellType_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// int GetCellDimension()
// int GetCellDimension()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetCellDimension_0")] public static extern 
bool vtkCellIterator_GetCellDimension_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// virtual vtkIdType GetCellId()
// virtual vtkIdType GetCellId()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetCellId_0")] public static extern 
bool vtkCellIterator_GetCellId_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// vtkIdList* GetPointIds()
// vtkIdList *GetPointIds()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetPointIds_0")] public static extern 
bool vtkCellIterator_GetPointIds_0(IntPtr /*(vtkIdList**)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// vtkPoints* GetPoints()
// vtkPoints *GetPoints()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetPoints_0")] public static extern 
bool vtkCellIterator_GetPoints_0(IntPtr /*(vtkPoints**)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// vtkIdList* GetFaces()
// vtkIdList *GetFaces()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetFaces_0")] public static extern 
bool vtkCellIterator_GetFaces_0(IntPtr /*(vtkIdList**)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// void GetCell(vtkGenericCell * cell)
// void GetCell(vtkGenericCell *cell)
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetCell_0")] public static extern 
bool vtkCellIterator_GetCell_0(IntPtr /*(vtkCellIterator*)*/ callingObject, IntPtr /*(vtkGenericCell*)*/ cell);

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetNumberOfPoints_0")] public static extern 
bool vtkCellIterator_GetNumberOfPoints_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// vtkIdType GetNumberOfFaces()
// vtkIdType GetNumberOfFaces()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetNumberOfFaces_0")] public static extern 
bool vtkCellIterator_GetNumberOfFaces_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

}
};
