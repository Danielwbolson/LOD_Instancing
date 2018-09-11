
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkCellIterator {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject, string /*(char*)*/ type);

// static vtkCellIterator* SafeDownCast(vtkObjectBase * o)
// static vtkCellIterator* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkCellIterator* NewInstance()
// vtkCellIterator *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// void InitTraversal()
// void InitTraversal()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_InitTraversal_0")] public static extern 
bool InitTraversal_0(IntPtr /*(vtkCellIterator*)*/ callingObject);

// void GoToNextCell()
// void GoToNextCell()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GoToNextCell_0")] public static extern 
bool GoToNextCell_0(IntPtr /*(vtkCellIterator*)*/ callingObject);

// virtual bool IsDoneWithTraversal()
// virtual bool IsDoneWithTraversal()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_IsDoneWithTraversal_0")] public static extern 
bool IsDoneWithTraversal_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// int GetCellType()
// int GetCellType()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetCellType_0")] public static extern 
bool GetCellType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// int GetCellDimension()
// int GetCellDimension()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetCellDimension_0")] public static extern 
bool GetCellDimension_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// virtual vtkIdType GetCellId()
// virtual vtkIdType GetCellId()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetCellId_0")] public static extern 
bool GetCellId_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// vtkIdList* GetPointIds()
// vtkIdList *GetPointIds()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetPointIds_0")] public static extern 
bool GetPointIds_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// vtkPoints* GetPoints()
// vtkPoints *GetPoints()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetPoints_0")] public static extern 
bool GetPoints_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// vtkIdList* GetFaces()
// vtkIdList *GetFaces()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetFaces_0")] public static extern 
bool GetFaces_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// void GetCell(vtkGenericCell * cell)
// void GetCell(vtkGenericCell *cell)
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetCell_0")] public static extern 
bool GetCell_0(IntPtr /*(vtkCellIterator*)*/ callingObject, IntPtr /*(vtkGenericCell*)*/ cell);

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// vtkIdType GetNumberOfFaces()
// vtkIdType GetNumberOfFaces()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetNumberOfFaces_0")] public static extern 
bool GetNumberOfFaces_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// void InitTraversal()
// void InitTraversal()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_InitTraversal_1")] public static extern 
bool InitTraversal_1(IntPtr /*(vtkCellIterator*)*/ callingObject);

// void GoToNextCell()
// void GoToNextCell()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GoToNextCell_1")] public static extern 
bool GoToNextCell_1(IntPtr /*(vtkCellIterator*)*/ callingObject);

// virtual bool IsDoneWithTraversal()
// virtual bool IsDoneWithTraversal()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_IsDoneWithTraversal_1")] public static extern 
bool IsDoneWithTraversal_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// int GetCellType()
// int GetCellType()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetCellType_1")] public static extern 
bool GetCellType_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// int GetCellDimension()
// int GetCellDimension()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetCellDimension_1")] public static extern 
bool GetCellDimension_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// virtual vtkIdType GetCellId()
// virtual vtkIdType GetCellId()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetCellId_1")] public static extern 
bool GetCellId_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// vtkIdList* GetPointIds()
// vtkIdList *GetPointIds()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetPointIds_1")] public static extern 
bool GetPointIds_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// vtkPoints* GetPoints()
// vtkPoints *GetPoints()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetPoints_1")] public static extern 
bool GetPoints_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// vtkIdList* GetFaces()
// vtkIdList *GetFaces()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetFaces_1")] public static extern 
bool GetFaces_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// void GetCell(vtkGenericCell * cell)
// void GetCell(vtkGenericCell *cell)
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetCell_1")] public static extern 
bool GetCell_1(IntPtr /*(vtkCellIterator*)*/ callingObject, IntPtr /*(vtkGenericCell*)*/ cell);

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetNumberOfPoints_1")] public static extern 
bool GetNumberOfPoints_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

// vtkIdType GetNumberOfFaces()
// vtkIdType GetNumberOfFaces()
[DllImport("vtkplugin", EntryPoint="vtkCellIterator_GetNumberOfFaces_1")] public static extern 
bool GetNumberOfFaces_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellIterator*)*/ callingObject);

}
};
