
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkXMLStructuredGridReader {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredGridReader_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredGridReader_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLStructuredGridReader*)*/ callingObject, string /*(char*)*/ type);

// static vtkXMLStructuredGridReader* SafeDownCast(vtkObjectBase * o)
// static vtkXMLStructuredGridReader* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredGridReader_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkXMLStructuredGridReader* NewInstance()
// vtkXMLStructuredGridReader *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredGridReader_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLStructuredGridReader*)*/ callingObject);

// static vtkXMLStructuredGridReader* New()
// static vtkXMLStructuredGridReader *New()
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredGridReader_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// vtkStructuredGrid* GetOutput()
// vtkStructuredGrid *GetOutput()
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredGridReader_GetOutput_0")] public static extern 
bool GetOutput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLStructuredGridReader*)*/ callingObject);

// vtkStructuredGrid* GetOutput(int idx)
// vtkStructuredGrid *GetOutput(int idx)
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredGridReader_GetOutput_1")] public static extern 
bool GetOutput_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLStructuredGridReader*)*/ callingObject, int /*(int)*/ idx);

}
};
