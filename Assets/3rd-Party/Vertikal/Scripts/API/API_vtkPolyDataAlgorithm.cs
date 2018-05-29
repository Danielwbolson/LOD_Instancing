
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPolyDataAlgorithm {

// static vtkPolyDataAlgorithm* New()
// static vtkPolyDataAlgorithm *New()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPolyDataAlgorithm*)*/ callingObject, string /*(char*)*/ type);

// static vtkPolyDataAlgorithm* SafeDownCast(vtkObjectBase * o)
// static vtkPolyDataAlgorithm* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPolyDataAlgorithm* NewInstance()
// vtkPolyDataAlgorithm *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPolyDataAlgorithm*)*/ callingObject);

// vtkPolyData* GetOutput()
// vtkPolyData* GetOutput()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_GetOutput_0")] public static extern 
bool GetOutput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPolyDataAlgorithm*)*/ callingObject);

// vtkPolyData* GetOutput(int ARG_0)
// vtkPolyData* GetOutput(int)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_GetOutput_1")] public static extern 
bool GetOutput_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPolyDataAlgorithm*)*/ callingObject, int /*(int)*/ ARG_0);

// virtual void SetOutput(vtkDataObject * d)
// virtual void SetOutput(vtkDataObject* d)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_SetOutput_0")] public static extern 
bool SetOutput_0(IntPtr /*(vtkPolyDataAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ d);

// int ProcessRequest(vtkInformation * ARG_0, vtkInformationVector ** ARG_1, vtkInformationVector * ARG_2)
// int ProcessRequest(vtkInformation*, vtkInformationVector**, vtkInformationVector*)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_ProcessRequest_0")] public static extern 
bool ProcessRequest_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPolyDataAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ ARG_0, IntPtr /*(vtkInformationVector**)*/ ARG_1, IntPtr /*(vtkInformationVector*)*/ ARG_2);

// vtkDataObject* GetInput()
// vtkDataObject* GetInput()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_GetInput_0")] public static extern 
bool GetInput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPolyDataAlgorithm*)*/ callingObject);

// vtkDataObject* GetInput(int port)
// vtkDataObject *GetInput(int port)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_GetInput_1")] public static extern 
bool GetInput_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPolyDataAlgorithm*)*/ callingObject, int /*(int)*/ port);

// vtkPolyData* GetPolyDataInput(int port)
// vtkPolyData *GetPolyDataInput(int port)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_GetPolyDataInput_0")] public static extern 
bool GetPolyDataInput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPolyDataAlgorithm*)*/ callingObject, int /*(int)*/ port);

// void SetInputData(vtkDataObject * ARG_0)
// void SetInputData(vtkDataObject *)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_SetInputData_0")] public static extern 
bool SetInputData_0(IntPtr /*(vtkPolyDataAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ ARG_0);

// void SetInputData(int ARG_0, vtkDataObject * ARG_1)
// void SetInputData(int, vtkDataObject*)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_SetInputData_1")] public static extern 
bool SetInputData_1(IntPtr /*(vtkPolyDataAlgorithm*)*/ callingObject, int /*(int)*/ ARG_0, IntPtr /*(vtkDataObject*)*/ ARG_1);

// void AddInputData(vtkDataObject * ARG_0)
// void AddInputData(vtkDataObject *)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_AddInputData_0")] public static extern 
bool AddInputData_0(IntPtr /*(vtkPolyDataAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ ARG_0);

// void AddInputData(int ARG_0, vtkDataObject * ARG_1)
// void AddInputData(int, vtkDataObject*)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataAlgorithm_AddInputData_1")] public static extern 
bool AddInputData_1(IntPtr /*(vtkPolyDataAlgorithm*)*/ callingObject, int /*(int)*/ ARG_0, IntPtr /*(vtkDataObject*)*/ ARG_1);

}
};
