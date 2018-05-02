
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkCellTypes {

// static vtkCellTypes* New()
// static vtkCellTypes *New()
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// int Allocate(int sz = 512, int ext = 1000)
// int Allocate(int sz=512, int ext=1000)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_Allocate_0")] public static extern 
bool Allocate_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellTypes*)*/ callingObject, int /*(int)*/ sz, int /*(int)*/ ext);

// void InsertCell(vtkIdType id, unsigned char type, vtkIdType loc)
// void InsertCell(vtkIdType id, unsigned char type, vtkIdType loc)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_InsertCell_0")] public static extern 
bool InsertCell_0(IntPtr /*(vtkCellTypes*)*/ callingObject, long /*(vtkIdType)*/ id, char /*(unsigned char)*/ type, long /*(vtkIdType)*/ loc);

// vtkIdType InsertNextCell(unsigned char type, vtkIdType loc)
// vtkIdType InsertNextCell(unsigned char type, vtkIdType loc)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_InsertNextCell_0")] public static extern 
bool InsertNextCell_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellTypes*)*/ callingObject, char /*(unsigned char)*/ type, long /*(vtkIdType)*/ loc);

// void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray * cellTypes, vtkIdTypeArray * cellLocations)
// void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray *cellTypes, vtkIdTypeArray *cellLocations)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_SetCellTypes_0")] public static extern 
bool SetCellTypes_0(IntPtr /*(vtkCellTypes*)*/ callingObject, long /*(vtkIdType)*/ ncells, IntPtr /*(vtkUnsignedCharArray*)*/ cellTypes, IntPtr /*(vtkIdTypeArray*)*/ cellLocations);

// void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray * cellTypes, vtkIntArray * cellLocations)
// void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray *cellTypes, vtkIntArray *cellLocations)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_SetCellTypes_1")] public static extern 
bool SetCellTypes_1(IntPtr /*(vtkCellTypes*)*/ callingObject, long /*(vtkIdType)*/ ncells, IntPtr /*(vtkUnsignedCharArray*)*/ cellTypes, IntPtr /*(vtkIntArray*)*/ cellLocations);

// vtkIdType GetCellLocation(vtkIdType cellId)
// vtkIdType GetCellLocation(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_GetCellLocation_0")] public static extern 
bool GetCellLocation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellTypes*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// void DeleteCell(vtkIdType cellId)
// void DeleteCell(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_DeleteCell_0")] public static extern 
bool DeleteCell_0(IntPtr /*(vtkCellTypes*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// vtkIdType GetNumberOfTypes()
// vtkIdType GetNumberOfTypes()
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_GetNumberOfTypes_0")] public static extern 
bool GetNumberOfTypes_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellTypes*)*/ callingObject);

// int IsType(unsigned char type)
// int IsType(unsigned char type)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_IsType_0")] public static extern 
bool IsType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellTypes*)*/ callingObject, char /*(unsigned char)*/ type);

// vtkIdType InsertNextType(unsigned char type)
// vtkIdType InsertNextType(unsigned char type)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_InsertNextType_0")] public static extern 
bool InsertNextType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCellTypes*)*/ callingObject, char /*(unsigned char)*/ type);

// char GetCellType(vtkIdType cellId)
// unsigned char GetCellType(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_GetCellType_0")] public static extern 
bool GetCellType_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkCellTypes*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// void Squeeze()
// void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_Squeeze_0")] public static extern 
bool Squeeze_0(IntPtr /*(vtkCellTypes*)*/ callingObject);

// void Reset()
// void Reset()
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_Reset_0")] public static extern 
bool Reset_0(IntPtr /*(vtkCellTypes*)*/ callingObject);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_GetActualMemorySize_0")] public static extern 
bool GetActualMemorySize_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkCellTypes*)*/ callingObject);

// void DeepCopy(vtkCellTypes * src)
// void DeepCopy(vtkCellTypes *src)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkCellTypes*)*/ callingObject, IntPtr /*(vtkCellTypes*)*/ src);

// static char* GetClassNameFromTypeId(int typeId)
// static const char* GetClassNameFromTypeId(int typeId)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_GetClassNameFromTypeId_0")] public static extern 
bool GetClassNameFromTypeId_0(IntPtr /*(IntPtr**)*/ return_value, int /*(int)*/ typeId);

// static int GetTypeIdFromClassName(const char * classname)
// static int GetTypeIdFromClassName(const char* classname)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_GetTypeIdFromClassName_0")] public static extern 
bool GetTypeIdFromClassName_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ classname);

// static int IsLinear(unsigned char type)
// static int IsLinear(unsigned char type)
[DllImport("vtkplugin", EntryPoint="vtkCellTypes_IsLinear_0")] public static extern 
bool IsLinear_0(IntPtr /*(IntPtr*)*/ return_value, char /*(unsigned char)*/ type);

}
};
