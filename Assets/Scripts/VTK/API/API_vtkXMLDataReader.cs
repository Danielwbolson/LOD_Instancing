
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkXMLDataReader {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataReader_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataReader_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataReader*)*/ callingObject, string /*(char*)*/ type);

// static vtkXMLDataReader* SafeDownCast(vtkObjectBase * o)
// static vtkXMLDataReader* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataReader_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkXMLDataReader* NewInstance()
// vtkXMLDataReader *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataReader_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataReader*)*/ callingObject);

// virtual vtkIdType GetNumberOfPoints()
// virtual vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataReader_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataReader*)*/ callingObject);

// virtual vtkIdType GetNumberOfCells()
// virtual vtkIdType GetNumberOfCells()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataReader_GetNumberOfCells_0")] public static extern 
bool GetNumberOfCells_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataReader*)*/ callingObject);

}
};
