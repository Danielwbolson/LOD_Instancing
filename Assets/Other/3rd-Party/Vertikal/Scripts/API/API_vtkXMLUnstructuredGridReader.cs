
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkXMLUnstructuredGridReader {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredGridReader_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredGridReader_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLUnstructuredGridReader*)*/ callingObject, string /*(char*)*/ type);

// static vtkXMLUnstructuredGridReader* SafeDownCast(vtkObjectBase * o)
// static vtkXMLUnstructuredGridReader* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredGridReader_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkXMLUnstructuredGridReader* NewInstance()
// vtkXMLUnstructuredGridReader *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredGridReader_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLUnstructuredGridReader*)*/ callingObject);

// static vtkXMLUnstructuredGridReader* New()
// static vtkXMLUnstructuredGridReader *New()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredGridReader_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// vtkUnstructuredGrid* GetOutput()
// vtkUnstructuredGrid *GetOutput()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredGridReader_GetOutput_0")] public static extern 
bool GetOutput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLUnstructuredGridReader*)*/ callingObject);

// vtkUnstructuredGrid* GetOutput(int idx)
// vtkUnstructuredGrid *GetOutput(int idx)
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredGridReader_GetOutput_1")] public static extern 
bool GetOutput_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLUnstructuredGridReader*)*/ callingObject, int /*(int)*/ idx);

}
};
