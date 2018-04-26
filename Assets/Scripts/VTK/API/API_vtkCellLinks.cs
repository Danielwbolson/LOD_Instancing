
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkCellLinks {

// static vtkCellLinks* New()
// static vtkCellLinks *New()
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_New_0")] public static extern 
bool vtkCellLinks_New_0(IntPtr /*(vtkCellLinks**)*/ return_value);

// void BuildLinks(vtkDataSet * data)
// void BuildLinks(vtkDataSet *data)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_BuildLinks_0")] public static extern 
bool vtkCellLinks_BuildLinks_0(IntPtr /*(vtkCellLinks*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ data);

// void BuildLinks(vtkDataSet * data, vtkCellArray * Connectivity)
// void BuildLinks(vtkDataSet *data, vtkCellArray *Connectivity)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_BuildLinks_1")] public static extern 
bool vtkCellLinks_BuildLinks_1(IntPtr /*(vtkCellLinks*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ data, IntPtr /*(vtkCellArray*)*/ Connectivity);

// void Allocate(vtkIdType numLinks, vtkIdType ext = 1000)
// void Allocate(vtkIdType numLinks, vtkIdType ext=1000)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_Allocate_0")] public static extern 
bool vtkCellLinks_Allocate_0(IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ numLinks, long /*(vtkIdType)*/ ext);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_Initialize_0")] public static extern 
bool vtkCellLinks_Initialize_0(IntPtr /*(vtkCellLinks*)*/ callingObject);

// Link& GetLink(vtkIdType ptId)
// Link &GetLink(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_GetLink_0")] public static extern 
bool vtkCellLinks_GetLink_0(IntPtr /*(Link*)*/ return_value, IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// short GetNcells(vtkIdType ptId)
// unsigned short GetNcells(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_GetNcells_0")] public static extern 
bool vtkCellLinks_GetNcells_0(IntPtr /*(short*)*/ return_value, IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// vtkIdType* GetCells(vtkIdType ptId)
// vtkIdType *GetCells(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_GetCells_0")] public static extern 
bool vtkCellLinks_GetCells_0(IntPtr /*(vtkIdType**)*/ return_value, IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// vtkIdType InsertNextPoint(int numLinks)
// vtkIdType InsertNextPoint(int numLinks)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_InsertNextPoint_0")] public static extern 
bool vtkCellLinks_InsertNextPoint_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCellLinks*)*/ callingObject, int /*(int)*/ numLinks);

// void InsertNextCellReference(vtkIdType ptId, vtkIdType cellId)
// void InsertNextCellReference(vtkIdType ptId, vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_InsertNextCellReference_0")] public static extern 
bool vtkCellLinks_InsertNextCellReference_0(IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId);

// void DeletePoint(vtkIdType ptId)
// void DeletePoint(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_DeletePoint_0")] public static extern 
bool vtkCellLinks_DeletePoint_0(IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// void RemoveCellReference(vtkIdType cellId, vtkIdType ptId)
// void RemoveCellReference(vtkIdType cellId, vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_RemoveCellReference_0")] public static extern 
bool vtkCellLinks_RemoveCellReference_0(IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ cellId, long /*(vtkIdType)*/ ptId);

// void AddCellReference(vtkIdType cellId, vtkIdType ptId)
// void AddCellReference(vtkIdType cellId, vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_AddCellReference_0")] public static extern 
bool vtkCellLinks_AddCellReference_0(IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ cellId, long /*(vtkIdType)*/ ptId);

// void ResizeCellList(vtkIdType ptId, int size)
// void ResizeCellList(vtkIdType ptId, int size)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_ResizeCellList_0")] public static extern 
bool vtkCellLinks_ResizeCellList_0(IntPtr /*(vtkCellLinks*)*/ callingObject, long /*(vtkIdType)*/ ptId, int /*(int)*/ size);

// void Squeeze()
// void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_Squeeze_0")] public static extern 
bool vtkCellLinks_Squeeze_0(IntPtr /*(vtkCellLinks*)*/ callingObject);

// void Reset()
// void Reset()
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_Reset_0")] public static extern 
bool vtkCellLinks_Reset_0(IntPtr /*(vtkCellLinks*)*/ callingObject);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_GetActualMemorySize_0")] public static extern 
bool vtkCellLinks_GetActualMemorySize_0(IntPtr /*(long*)*/ return_value, IntPtr /*(vtkCellLinks*)*/ callingObject);

// void DeepCopy(vtkCellLinks * src)
// void DeepCopy(vtkCellLinks *src)
[DllImport("vtkplugin", EntryPoint="vtkCellLinks_DeepCopy_0")] public static extern 
bool vtkCellLinks_DeepCopy_0(IntPtr /*(vtkCellLinks*)*/ callingObject, IntPtr /*(vtkCellLinks*)*/ src);

}
};
