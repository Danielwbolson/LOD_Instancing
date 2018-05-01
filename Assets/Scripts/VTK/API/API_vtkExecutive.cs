
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkExecutive {

// vtkAlgorithm* GetAlgorithm()
// vtkAlgorithm* GetAlgorithm()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetAlgorithm_0")] public static extern 
bool vtkExecutive_GetAlgorithm_0(IntPtr /*(vtkAlgorithm**)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject);

// virtual int UpdateInformation()
// virtual int UpdateInformation()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_UpdateInformation_0")] public static extern 
bool vtkExecutive_UpdateInformation_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject);

// virtual int Update()
// virtual int Update()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_Update_0")] public static extern 
bool vtkExecutive_Update_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject);

// virtual int Update(int port)
// virtual int Update(int port)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_Update_1")] public static extern 
bool vtkExecutive_Update_1(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port);

// int GetNumberOfInputPorts()
// int GetNumberOfInputPorts()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetNumberOfInputPorts_0")] public static extern 
bool vtkExecutive_GetNumberOfInputPorts_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject);

// int GetNumberOfOutputPorts()
// int GetNumberOfOutputPorts()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetNumberOfOutputPorts_0")] public static extern 
bool vtkExecutive_GetNumberOfOutputPorts_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject);

// int GetNumberOfInputConnections(int port)
// int GetNumberOfInputConnections(int port)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetNumberOfInputConnections_0")] public static extern 
bool vtkExecutive_GetNumberOfInputConnections_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port);

// vtkExecutive* GetInputExecutive(int port, int connection)
// vtkExecutive* GetInputExecutive(int port, int connection)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetInputExecutive_0")] public static extern 
bool vtkExecutive_GetInputExecutive_0(IntPtr /*(vtkExecutive**)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ connection);

// virtual vtkDataObject* GetOutputData(int port)
// virtual vtkDataObject* GetOutputData(int port)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetOutputData_0")] public static extern 
bool vtkExecutive_GetOutputData_0(IntPtr /*(vtkDataObject**)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port);

// virtual void SetOutputData(int port, vtkDataObject * ARG_0)
// virtual void SetOutputData(int port, vtkDataObject*)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_SetOutputData_0")] public static extern 
bool vtkExecutive_SetOutputData_0(IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkDataObject*)*/ ARG_0);

// virtual vtkDataObject* GetInputData(int port, int connection)
// virtual vtkDataObject* GetInputData(int port, int connection)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetInputData_0")] public static extern 
bool vtkExecutive_GetInputData_0(IntPtr /*(vtkDataObject**)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ connection);

// void Register(vtkObjectBase * o)
// void Register(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_Register_0")] public static extern 
bool vtkExecutive_Register_0(IntPtr /*(vtkExecutive*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_UnRegister_0")] public static extern 
bool vtkExecutive_UnRegister_0(IntPtr /*(vtkExecutive*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

}
};
