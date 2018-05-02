
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkCellLinks {

// static vtkCellLinks* New()
// static vtkCellLinks *New()
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void BuildLinks(vtkDataSet * data)
// void BuildLinks(vtkDataSet *data)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_BuildLinks_0")] public static extern 
bool BuildLinks_0(IntPtr /*(vtkCellLinks*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ data);

// void BuildLinks(vtkDataSet * data, vtkCellArray * Connectivity)
// void BuildLinks(vtkDataSet *data, vtkCellArray *Connectivity)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_BuildLinks_1")] public static extern 
bool BuildLinks_1(IntPtr /*(vtkCellLinks*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ data, IntPtr /*(vtkCellArray*)*/ Connectivity);

// void Allocate(vtkIdType numLinks, vtkIdType ext = 1000)
// void Allocate(vtkIdType numLinks, vtkIdType ext=1000)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_Allocate_0")] public static extern 
bool Allocate_0(IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ numLinks, long /*(vtkIdType)*/ ext);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkCellLinks*)*/ callingObject);

// short GetNcells(vtkIdType ptId)
// unsigned short GetNcells(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_GetNcells_0")] public static extern 
bool GetNcells_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// vtkIdType* GetCells(vtkIdType ptId)
// vtkIdType *GetCells(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_GetCells_0")] public static extern 
bool GetCells_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// vtkIdType InsertNextPoint(int numLinks)
// vtkIdType InsertNextPoint(int numLinks)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_InsertNextPoint_0")] public static extern 
bool InsertNextPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellLinks*)*/ callingObject, int /*(int)*/ numLinks);

// void InsertNextCellReference(vtkIdType ptId, vtkIdType cellId)
// void InsertNextCellReference(vtkIdType ptId, vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_InsertNextCellReference_0")] public static extern 
bool InsertNextCellReference_0(IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId);

// void DeletePoint(vtkIdType ptId)
// void DeletePoint(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_DeletePoint_0")] public static extern 
bool DeletePoint_0(IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// void RemoveCellReference(vtkIdType cellId, vtkIdType ptId)
// void RemoveCellReference(vtkIdType cellId, vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_RemoveCellReference_0")] public static extern 
bool RemoveCellReference_0(IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ cellId, long /*(vtkIdType)*/ ptId);

// void AddCellReference(vtkIdType cellId, vtkIdType ptId)
// void AddCellReference(vtkIdType cellId, vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_AddCellReference_0")] public static extern 
bool AddCellReference_0(IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ cellId, long /*(vtkIdType)*/ ptId);

// void ResizeCellList(vtkIdType ptId, int size)
// void ResizeCellList(vtkIdType ptId, int size)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_ResizeCellList_0")] public static extern 
bool ResizeCellList_0(IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ ptId, int /*(int)*/ size);

// void Squeeze()
// void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_Squeeze_0")] public static extern 
bool Squeeze_0(IntPtr /*(vtkCellLinks*)*/ callingObject);

// void Reset()
// void Reset()
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_Reset_0")] public static extern 
bool Reset_0(IntPtr /*(vtkCellLinks*)*/ callingObject);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_GetActualMemorySize_0")] public static extern 
bool GetActualMemorySize_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkCellLinks*)*/ callingObject);

// void DeepCopy(vtkCellLinks * src)
// void DeepCopy(vtkCellLinks *src)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkCellLinks*)*/ callingObject, IntPtr /*(vtkCellLinks*)*/ src);

}
};
