
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkImageAlgorithm {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageAlgorithm*)*/ callingObject, string /*(char*)*/ type);

// static vtkImageAlgorithm* SafeDownCast(vtkObjectBase * o)
// static vtkImageAlgorithm* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkImageAlgorithm* NewInstance()
// vtkImageAlgorithm *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageAlgorithm*)*/ callingObject);

// vtkImageData* GetOutput()
// vtkImageData* GetOutput()
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_GetOutput_0")] public static extern 
bool GetOutput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageAlgorithm*)*/ callingObject);

// vtkImageData* GetOutput(int ARG_0)
// vtkImageData* GetOutput(int)
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_GetOutput_1")] public static extern 
bool GetOutput_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageAlgorithm*)*/ callingObject, int /*(int)*/ ARG_0);

// virtual void SetOutput(vtkDataObject * d)
// virtual void SetOutput(vtkDataObject* d)
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_SetOutput_0")] public static extern 
bool SetOutput_0(IntPtr /*(vtkImageAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ d);

// int ProcessRequest(vtkInformation * ARG_0, vtkInformationVector ** ARG_1, vtkInformationVector * ARG_2)
// int ProcessRequest(vtkInformation*, vtkInformationVector**, vtkInformationVector*)
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_ProcessRequest_0")] public static extern 
bool ProcessRequest_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ ARG_0, IntPtr /*(vtkInformationVector**)*/ ARG_1, IntPtr /*(vtkInformationVector*)*/ ARG_2);

// void SetInputData(vtkDataObject * ARG_0)
// void SetInputData(vtkDataObject *)
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_SetInputData_0")] public static extern 
bool SetInputData_0(IntPtr /*(vtkImageAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ ARG_0);

// void SetInputData(int ARG_0, vtkDataObject * ARG_1)
// void SetInputData(int, vtkDataObject*)
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_SetInputData_1")] public static extern 
bool SetInputData_1(IntPtr /*(vtkImageAlgorithm*)*/ callingObject, int /*(int)*/ ARG_0, IntPtr /*(vtkDataObject*)*/ ARG_1);

// vtkDataObject* GetInput(int port)
// vtkDataObject *GetInput(int port)
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_GetInput_0")] public static extern 
bool GetInput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageAlgorithm*)*/ callingObject, int /*(int)*/ port);

// vtkDataObject* GetInput()
// vtkDataObject *GetInput()
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_GetInput_1")] public static extern 
bool GetInput_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageAlgorithm*)*/ callingObject);

// vtkImageData* GetImageDataInput(int port)
// vtkImageData *GetImageDataInput(int port)
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_GetImageDataInput_0")] public static extern 
bool GetImageDataInput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageAlgorithm*)*/ callingObject, int /*(int)*/ port);

// virtual void AddInputData(vtkDataObject * ARG_0)
// virtual void AddInputData(vtkDataObject *)
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_AddInputData_0")] public static extern 
bool AddInputData_0(IntPtr /*(vtkImageAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ ARG_0);

// virtual void AddInputData(int ARG_0, vtkDataObject * ARG_1)
// virtual void AddInputData(int, vtkDataObject*)
[DllImport("vtkplugin", EntryPoint="vtkImageAlgorithm_AddInputData_1")] public static extern 
bool AddInputData_1(IntPtr /*(vtkImageAlgorithm*)*/ callingObject, int /*(int)*/ ARG_0, IntPtr /*(vtkDataObject*)*/ ARG_1);

}
};
