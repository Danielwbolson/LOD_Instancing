
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkXMLUnstructuredDataReader {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject, string /*(char*)*/ type);

// static vtkXMLUnstructuredDataReader* SafeDownCast(vtkObjectBase * o)
// static vtkXMLUnstructuredDataReader* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkXMLUnstructuredDataReader* NewInstance()
// vtkXMLUnstructuredDataReader *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject);

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject);

// vtkIdType GetNumberOfCells()
// vtkIdType GetNumberOfCells()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_GetNumberOfCells_0")] public static extern 
bool GetNumberOfCells_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject);

// virtual vtkIdType GetNumberOfPieces()
// virtual vtkIdType GetNumberOfPieces()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_GetNumberOfPieces_0")] public static extern 
bool GetNumberOfPieces_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject);

// void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
// void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_SetupUpdateExtent_0")] public static extern 
bool SetupUpdateExtent_0(IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject, int /*(int)*/ piece, int /*(int)*/ numberOfPieces, int /*(int)*/ ghostLevel);

}
};
