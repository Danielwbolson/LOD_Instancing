
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkUnstructuredGridAlgorithm {

// static vtkUnstructuredGridAlgorithm* New()
// static vtkUnstructuredGridAlgorithm *New()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridAlgorithm*)*/ callingObject, string /*(char*)*/ type);

// static vtkUnstructuredGridAlgorithm* SafeDownCast(vtkObjectBase * o)
// static vtkUnstructuredGridAlgorithm* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkUnstructuredGridAlgorithm* NewInstance()
// vtkUnstructuredGridAlgorithm *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkUnstructuredGridAlgorithm*)*/ callingObject);

// vtkUnstructuredGrid* GetOutput()
// vtkUnstructuredGrid* GetOutput()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_GetOutput_0")] public static extern 
bool GetOutput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkUnstructuredGridAlgorithm*)*/ callingObject);

// vtkUnstructuredGrid* GetOutput(int ARG_0)
// vtkUnstructuredGrid* GetOutput(int)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_GetOutput_1")] public static extern 
bool GetOutput_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkUnstructuredGridAlgorithm*)*/ callingObject, int /*(int)*/ ARG_0);

// virtual void SetOutput(vtkDataObject * d)
// virtual void SetOutput(vtkDataObject* d)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_SetOutput_0")] public static extern 
bool SetOutput_0(IntPtr /*(vtkUnstructuredGridAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ d);

// vtkDataObject* GetInput(int port)
// vtkDataObject *GetInput(int port)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_GetInput_0")] public static extern 
bool GetInput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkUnstructuredGridAlgorithm*)*/ callingObject, int /*(int)*/ port);

// vtkDataObject* GetInput()
// vtkDataObject *GetInput()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_GetInput_1")] public static extern 
bool GetInput_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkUnstructuredGridAlgorithm*)*/ callingObject);

// vtkUnstructuredGrid* GetUnstructuredGridInput(int port)
// vtkUnstructuredGrid *GetUnstructuredGridInput(int port)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_GetUnstructuredGridInput_0")] public static extern 
bool GetUnstructuredGridInput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkUnstructuredGridAlgorithm*)*/ callingObject, int /*(int)*/ port);

// void SetInputData(vtkDataObject * ARG_0)
// void SetInputData(vtkDataObject *)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_SetInputData_0")] public static extern 
bool SetInputData_0(IntPtr /*(vtkUnstructuredGridAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ ARG_0);

// void SetInputData(int ARG_0, vtkDataObject * ARG_1)
// void SetInputData(int, vtkDataObject*)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_SetInputData_1")] public static extern 
bool SetInputData_1(IntPtr /*(vtkUnstructuredGridAlgorithm*)*/ callingObject, int /*(int)*/ ARG_0, IntPtr /*(vtkDataObject*)*/ ARG_1);

// void AddInputData(vtkDataObject * ARG_0)
// void AddInputData(vtkDataObject *)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_AddInputData_0")] public static extern 
bool AddInputData_0(IntPtr /*(vtkUnstructuredGridAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ ARG_0);

// void AddInputData(int ARG_0, vtkDataObject * ARG_1)
// void AddInputData(int, vtkDataObject*)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridAlgorithm_AddInputData_1")] public static extern 
bool AddInputData_1(IntPtr /*(vtkUnstructuredGridAlgorithm*)*/ callingObject, int /*(int)*/ ARG_0, IntPtr /*(vtkDataObject*)*/ ARG_1);

}
};
