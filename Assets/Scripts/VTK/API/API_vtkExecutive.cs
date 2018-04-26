
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

// virtual int ProcessRequest(vtkInformation * request, vtkInformationVector ** inInfo, vtkInformationVector * outInfo)
// virtual int ProcessRequest(vtkInformation* request, vtkInformationVector** inInfo, vtkInformationVector* outInfo)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_ProcessRequest_0")] public static extern 
bool vtkExecutive_ProcessRequest_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, IntPtr /*(vtkInformation*)*/ request, IntPtr /*(vtkInformationVector**)*/ inInfo, IntPtr /*(vtkInformationVector*)*/ outInfo);

// virtual int ComputePipelineMTime(vtkInformation * request, vtkInformationVector ** inInfoVec, vtkInformationVector * outInfoVec, int requestFromOutputPort, vtkMTimeType * mtime)
// virtual int ComputePipelineMTime(vtkInformation* request, vtkInformationVector** inInfoVec, vtkInformationVector* outInfoVec, int requestFromOutputPort, vtkMTimeType* mtime)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_ComputePipelineMTime_0")] public static extern 
bool vtkExecutive_ComputePipelineMTime_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, IntPtr /*(vtkInformation*)*/ request, IntPtr /*(vtkInformationVector**)*/ inInfoVec, IntPtr /*(vtkInformationVector*)*/ outInfoVec, int /*(int)*/ requestFromOutputPort, IntPtr /*(vtkMTimeType*)*/ mtime);

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

// virtual vtkInformation* GetOutputInformation(int port)
// virtual vtkInformation* GetOutputInformation(int port)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetOutputInformation_0")] public static extern 
bool vtkExecutive_GetOutputInformation_0(IntPtr /*(vtkInformation**)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port);

// vtkInformationVector* GetOutputInformation()
// vtkInformationVector* GetOutputInformation()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetOutputInformation_1")] public static extern 
bool vtkExecutive_GetOutputInformation_1(IntPtr /*(vtkInformationVector**)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject);

// vtkInformation* GetInputInformation(int port, int connection)
// vtkInformation* GetInputInformation(int port, int connection)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetInputInformation_0")] public static extern 
bool vtkExecutive_GetInputInformation_0(IntPtr /*(vtkInformation**)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ connection);

// vtkInformationVector* GetInputInformation(int port)
// vtkInformationVector* GetInputInformation(int port)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetInputInformation_1")] public static extern 
bool vtkExecutive_GetInputInformation_1(IntPtr /*(vtkInformationVector**)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port);

// vtkInformationVector** GetInputInformation()
// vtkInformationVector** GetInputInformation()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetInputInformation_2")] public static extern 
bool vtkExecutive_GetInputInformation_2(IntPtr /*(vtkInformationVector***)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject);

// vtkExecutive* GetInputExecutive(int port, int connection)
// vtkExecutive* GetInputExecutive(int port, int connection)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetInputExecutive_0")] public static extern 
bool vtkExecutive_GetInputExecutive_0(IntPtr /*(vtkExecutive**)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ connection);

// virtual vtkDataObject* GetOutputData(int port)
// virtual vtkDataObject* GetOutputData(int port)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetOutputData_0")] public static extern 
bool vtkExecutive_GetOutputData_0(IntPtr /*(vtkDataObject**)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port);

// virtual void SetOutputData(int port, vtkDataObject * ARG_0, vtkInformation * info)
// virtual void SetOutputData(int port, vtkDataObject*, vtkInformation *info)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_SetOutputData_0")] public static extern 
bool vtkExecutive_SetOutputData_0(IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkDataObject*)*/ ARG_0, IntPtr /*(vtkInformation*)*/ info);

// virtual void SetOutputData(int port, vtkDataObject * ARG_0)
// virtual void SetOutputData(int port, vtkDataObject*)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_SetOutputData_1")] public static extern 
bool vtkExecutive_SetOutputData_1(IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkDataObject*)*/ ARG_0);

// virtual vtkDataObject* GetInputData(int port, int connection)
// virtual vtkDataObject* GetInputData(int port, int connection)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetInputData_0")] public static extern 
bool vtkExecutive_GetInputData_0(IntPtr /*(vtkDataObject**)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ connection);

// virtual vtkDataObject* GetInputData(int port, int connection, vtkInformationVector ** inInfoVec)
// virtual vtkDataObject* GetInputData(int port, int connection, vtkInformationVector **inInfoVec)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_GetInputData_1")] public static extern 
bool vtkExecutive_GetInputData_1(IntPtr /*(vtkDataObject**)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ connection, IntPtr /*(vtkInformationVector**)*/ inInfoVec);

// void SetSharedInputInformation(vtkInformationVector ** inInfoVec)
// void SetSharedInputInformation(vtkInformationVector** inInfoVec)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_SetSharedInputInformation_0")] public static extern 
bool vtkExecutive_SetSharedInputInformation_0(IntPtr /*(vtkExecutive*)*/ callingObject, IntPtr /*(vtkInformationVector**)*/ inInfoVec);

// void SetSharedOutputInformation(vtkInformationVector * outInfoVec)
// void SetSharedOutputInformation(vtkInformationVector* outInfoVec)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_SetSharedOutputInformation_0")] public static extern 
bool vtkExecutive_SetSharedOutputInformation_0(IntPtr /*(vtkExecutive*)*/ callingObject, IntPtr /*(vtkInformationVector*)*/ outInfoVec);

// void Register(vtkObjectBase * o)
// void Register(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_Register_0")] public static extern 
bool vtkExecutive_Register_0(IntPtr /*(vtkExecutive*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_UnRegister_0")] public static extern 
bool vtkExecutive_UnRegister_0(IntPtr /*(vtkExecutive*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// static vtkInformationExecutivePortKey* PRODUCER()
// static vtkInformationExecutivePortKey* PRODUCER()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_PRODUCER_0")] public static extern 
bool vtkExecutive_PRODUCER_0(IntPtr /*(vtkInformationExecutivePortKey**)*/ return_value);

// static vtkInformationExecutivePortVectorKey* CONSUMERS()
// static vtkInformationExecutivePortVectorKey* CONSUMERS()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_CONSUMERS_0")] public static extern 
bool vtkExecutive_CONSUMERS_0(IntPtr /*(vtkInformationExecutivePortVectorKey**)*/ return_value);

// static vtkInformationIntegerKey* FROM_OUTPUT_PORT()
// static vtkInformationIntegerKey* FROM_OUTPUT_PORT()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_FROM_OUTPUT_PORT_0")] public static extern 
bool vtkExecutive_FROM_OUTPUT_PORT_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* ALGORITHM_BEFORE_FORWARD()
// static vtkInformationIntegerKey* ALGORITHM_BEFORE_FORWARD()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_ALGORITHM_BEFORE_FORWARD_0")] public static extern 
bool vtkExecutive_ALGORITHM_BEFORE_FORWARD_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* ALGORITHM_AFTER_FORWARD()
// static vtkInformationIntegerKey* ALGORITHM_AFTER_FORWARD()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_ALGORITHM_AFTER_FORWARD_0")] public static extern 
bool vtkExecutive_ALGORITHM_AFTER_FORWARD_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* ALGORITHM_DIRECTION()
// static vtkInformationIntegerKey* ALGORITHM_DIRECTION()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_ALGORITHM_DIRECTION_0")] public static extern 
bool vtkExecutive_ALGORITHM_DIRECTION_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* FORWARD_DIRECTION()
// static vtkInformationIntegerKey* FORWARD_DIRECTION()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_FORWARD_DIRECTION_0")] public static extern 
bool vtkExecutive_FORWARD_DIRECTION_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationKeyVectorKey* KEYS_TO_COPY()
// static vtkInformationKeyVectorKey* KEYS_TO_COPY()
[DllImport("vtkplugin", EntryPoint="vtkExecutive_KEYS_TO_COPY_0")] public static extern 
bool vtkExecutive_KEYS_TO_COPY_0(IntPtr /*(vtkInformationKeyVectorKey**)*/ return_value);

// virtual int CallAlgorithm(vtkInformation * request, int direction, vtkInformationVector ** inInfo, vtkInformationVector * outInfo)
// virtual int CallAlgorithm(vtkInformation* request, int direction, vtkInformationVector** inInfo, vtkInformationVector* outInfo)
[DllImport("vtkplugin", EntryPoint="vtkExecutive_CallAlgorithm_0")] public static extern 
bool vtkExecutive_CallAlgorithm_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkExecutive*)*/ callingObject, IntPtr /*(vtkInformation*)*/ request, int /*(int)*/ direction, IntPtr /*(vtkInformationVector**)*/ inInfo, IntPtr /*(vtkInformationVector*)*/ outInfo);

}
};
