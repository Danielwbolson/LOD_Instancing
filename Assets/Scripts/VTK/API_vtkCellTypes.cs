
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkCellTypes {

//       Method: static vtkCellTypes * vtkCellTypes::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkCellTypes_New_0")] public static extern 
bool New(IntPtr /*vtkCellTypes** */ ret);

//       Method: virtual const char * vtkCellTypes::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkCellTypes* */ obj);

//       Method: int vtkCellTypes::Allocate(int sz, int ext)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_Allocate_0")] public static extern 
bool Allocate(IntPtr /*int* */ ret, IntPtr /*vtkCellTypes* */ obj, int sz, int ext);

//       Method: void vtkCellTypes::InsertCell(vtkIdType id, unsigned char type, vtkIdType loc)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_InsertCell_0")] public static extern 
bool InsertCell(IntPtr /*vtkCellTypes* */ obj, long id, byte type, long loc);

//       Method: vtkIdType vtkCellTypes::InsertNextCell(unsigned char type, vtkIdType loc)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_InsertNextCell_0")] public static extern 
bool InsertNextCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellTypes* */ obj, byte type, long loc);

//       Method: void vtkCellTypes::SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray* cellTypes, vtkIdTypeArray* cellLocations)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_SetCellTypes_0")] public static extern 
bool SetCellTypes(IntPtr /*vtkCellTypes* */ obj, long ncells, IntPtr/*vtkUnsignedCharArray* */ cellTypes, IntPtr/*vtkIdTypeArray* */ cellLocations);

////       Method: void vtkCellTypes::SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray* cellTypes, vtkIntArray* cellLocations)
//// 
//[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_SetCellTypes_1")] public static extern 
//bool SetCellTypes(IntPtr /*vtkCellTypes* */ obj, long ncells, IntPtr/*vtkUnsignedCharArray* */ cellTypes, IntPtr/*vtkIntArray* */ cellLocations);
//
//       Method: vtkIdType vtkCellTypes::GetCellLocation(vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_GetCellLocation_0")] public static extern 
bool GetCellLocation(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellTypes* */ obj, long cellId);

//       Method: void vtkCellTypes::DeleteCell(vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_DeleteCell_0")] public static extern 
bool DeleteCell(IntPtr /*vtkCellTypes* */ obj, long cellId);

//       Method: vtkIdType vtkCellTypes::GetNumberOfTypes()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_GetNumberOfTypes_0")] public static extern 
bool GetNumberOfTypes(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellTypes* */ obj);

//       Method: int vtkCellTypes::IsType(unsigned char type)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_IsType_0")] public static extern 
bool IsType(IntPtr /*int* */ ret, IntPtr /*vtkCellTypes* */ obj, byte type);

//       Method: vtkIdType vtkCellTypes::InsertNextType(unsigned char type)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_InsertNextType_0")] public static extern 
bool InsertNextType(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellTypes* */ obj, byte type);

//       Method: void vtkCellTypes::Squeeze()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_Squeeze_0")] public static extern 
bool Squeeze(IntPtr /*vtkCellTypes* */ obj);

//       Method: void vtkCellTypes::Reset()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_Reset_0")] public static extern 
bool Reset(IntPtr /*vtkCellTypes* */ obj);

//       Method: void vtkCellTypes::DeepCopy(vtkCellTypes* src)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellTypes_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkCellTypes* */ obj, IntPtr/*vtkCellTypes* */ src);

//       Method: static const char * vtkCellTypes::GetClassNameFromTypeId(int typeId)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkCellTypes_GetClassNameFromTypeId_0")] public static extern 
bool GetClassNameFromTypeId(IntPtr /*const char** */ ret, int typeId);

//       Method: static int vtkCellTypes::GetTypeIdFromClassName(const char* classname)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkCellTypes_GetTypeIdFromClassName_0")] public static extern 
bool GetTypeIdFromClassName(IntPtr /*int* */ ret, string/*const char* */ classname);

//       Method: static int vtkCellTypes::IsLinear(unsigned char type)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkCellTypes_IsLinear_0")] public static extern 
bool IsLinear(IntPtr /*int* */ ret, byte type);

}
};
