
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkUnstructuredGridBase {

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject);

// virtual void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// virtual void Allocate(vtkIdType numCells=1000, int extSize=1000)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_Allocate_0")] public static extern 
bool Allocate_0(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds)
// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_InsertNextCell_0")] public static extern 
bool InsertNextCell_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, long /*(vtkIdType)*/ npts, IntPtr /*(vtkIdType*)*/ ptIds);

// virtual vtkIdType InsertNextCell(int type, vtkIdList * ptIds)
// virtual vtkIdType InsertNextCell(int type, vtkIdList *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_InsertNextCell_1")] public static extern 
bool InsertNextCell_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, IntPtr /*(vtkIdList*)*/ ptIds);

// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds, vtkIdType nfaces, vtkIdType * faces)
// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds, vtkIdType nfaces, vtkIdType *faces)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_InsertNextCell_2")] public static extern 
bool InsertNextCell_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, long /*(vtkIdType)*/ npts, IntPtr /*(vtkIdType*)*/ ptIds, long /*(vtkIdType)*/ nfaces, IntPtr /*(vtkIdType*)*/ faces);

// virtual void ReplaceCell(vtkIdType cellId, int npts, vtkIdType * pts)
// virtual void ReplaceCell(vtkIdType cellId, int npts, vtkIdType *pts)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_ReplaceCell_0")] public static extern 
bool ReplaceCell_0(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, long /*(vtkIdType)*/ cellId, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts);

// virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray * array)
// virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray *array)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetIdsOfCellsOfType_0")] public static extern 
bool GetIdsOfCellsOfType_0(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, IntPtr /*(vtkIdTypeArray*)*/ array);

// virtual int IsHomogeneous()
// virtual int IsHomogeneous()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_IsHomogeneous_0")] public static extern 
bool IsHomogeneous_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject);

}
};
