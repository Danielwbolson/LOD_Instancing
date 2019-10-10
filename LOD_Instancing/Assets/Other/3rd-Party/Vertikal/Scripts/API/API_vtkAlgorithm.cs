
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAlgorithm {

// static vtkAlgorithm* New()
// static vtkAlgorithm *New()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, string /*(char*)*/ type);

// static vtkAlgorithm* SafeDownCast(vtkObjectBase * o)
// static vtkAlgorithm* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAlgorithm* NewInstance()
// vtkAlgorithm *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int HasExecutive()
// int HasExecutive()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_HasExecutive_0")] public static extern 
bool HasExecutive_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual int ProcessRequest(vtkInformation * request, vtkInformationVector ** inInfo, vtkInformationVector * outInfo)
// virtual int ProcessRequest(vtkInformation* request, vtkInformationVector** inInfo, vtkInformationVector* outInfo)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ProcessRequest_0")] public static extern 
bool ProcessRequest_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ request, IntPtr /*(vtkInformationVector**)*/ inInfo, IntPtr /*(vtkInformationVector*)*/ outInfo);

// int ProcessRequest(vtkInformation * request, vtkCollection * inInfo, vtkInformationVector * outInfo)
// int ProcessRequest(vtkInformation* request, vtkCollection* inInfo, vtkInformationVector* outInfo)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ProcessRequest_1")] public static extern 
bool ProcessRequest_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ request, IntPtr /*(vtkCollection*)*/ inInfo, IntPtr /*(vtkInformationVector*)*/ outInfo);

// virtual int ComputePipelineMTime(vtkInformation * request, vtkInformationVector ** inInfoVec, vtkInformationVector * outInfoVec, int requestFromOutputPort, vtkMTimeType * mtime)
// virtual int ComputePipelineMTime(vtkInformation* request, vtkInformationVector** inInfoVec, vtkInformationVector* outInfoVec, int requestFromOutputPort, vtkMTimeType* mtime)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ComputePipelineMTime_0")] public static extern 
bool ComputePipelineMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ request, IntPtr /*(vtkInformationVector**)*/ inInfoVec, IntPtr /*(vtkInformationVector*)*/ outInfoVec, int /*(int)*/ requestFromOutputPort, IntPtr /*(vtkMTimeType*)*/ mtime);

// virtual int ModifyRequest(vtkInformation * request, int when)
// virtual int ModifyRequest(vtkInformation* request, int when)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ModifyRequest_0")] public static extern 
bool ModifyRequest_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ request, int /*(int)*/ when);

// vtkInformation* GetInputPortInformation(int port)
// vtkInformation* GetInputPortInformation(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputPortInformation_0")] public static extern 
bool GetInputPortInformation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// vtkInformation* GetOutputPortInformation(int port)
// vtkInformation* GetOutputPortInformation(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetOutputPortInformation_0")] public static extern 
bool GetOutputPortInformation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// virtual vtkInformation* GetInformation()
// virtual vtkInformation *GetInformation ()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInformation_0")] public static extern 
bool GetInformation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual void SetInformation(vtkInformation * ARG_0)
// virtual void SetInformation(vtkInformation*)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInformation_0")] public static extern 
bool SetInformation_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ ARG_0);

// int GetNumberOfInputPorts()
// int GetNumberOfInputPorts()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetNumberOfInputPorts_0")] public static extern 
bool GetNumberOfInputPorts_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int GetNumberOfOutputPorts()
// int GetNumberOfOutputPorts()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetNumberOfOutputPorts_0")] public static extern 
bool GetNumberOfOutputPorts_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// void Register(vtkObjectBase * o)
// void Register(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_Register_0")] public static extern 
bool Register_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UnRegister_0")] public static extern 
bool UnRegister_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// virtual void SetAbortExecute(int _arg)
// virtual void SetAbortExecute (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetAbortExecute_0")] public static extern 
bool SetAbortExecute_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetAbortExecute()
// virtual int GetAbortExecute ()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetAbortExecute_0")] public static extern 
bool GetAbortExecute_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual void AbortExecuteOn()
// virtual void AbortExecuteOn ()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_AbortExecuteOn_0")] public static extern 
bool AbortExecuteOn_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual void AbortExecuteOff()
// virtual void AbortExecuteOff ()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_AbortExecuteOff_0")] public static extern 
bool AbortExecuteOff_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual void SetProgress(double _arg)
// virtual void SetProgress (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetProgress_0")] public static extern 
bool SetProgress_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetProgressMinValue()
// virtual double GetProgressMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetProgressMinValue_0")] public static extern 
bool GetProgressMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual double GetProgressMaxValue()
// virtual double GetProgressMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetProgressMaxValue_0")] public static extern 
bool GetProgressMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual double GetProgress()
// virtual double GetProgress ()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetProgress_0")] public static extern 
bool GetProgress_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// void UpdateProgress(double amount)
// void UpdateProgress(double amount)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateProgress_0")] public static extern 
bool UpdateProgress_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, double /*(double)*/ amount);

// void SetProgressText(const char * ptext)
// void SetProgressText(const char* ptext)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetProgressText_0")] public static extern 
bool SetProgressText_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, string /*(char*)*/ ptext);

// virtual char* GetProgressText()
// virtual char* GetProgressText ()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetProgressText_0")] public static extern 
bool GetProgressText_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual long GetErrorCode()
// virtual unsigned long GetErrorCode ()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetErrorCode_0")] public static extern 
bool GetErrorCode_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// static vtkInformationIntegerKey* INPUT_IS_OPTIONAL()
// static vtkInformationIntegerKey* INPUT_IS_OPTIONAL()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_IS_OPTIONAL_0")] public static extern 
bool INPUT_IS_OPTIONAL_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* INPUT_IS_REPEATABLE()
// static vtkInformationIntegerKey* INPUT_IS_REPEATABLE()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_IS_REPEATABLE_0")] public static extern 
bool INPUT_IS_REPEATABLE_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationInformationVectorKey* INPUT_REQUIRED_FIELDS()
// static vtkInformationInformationVectorKey* INPUT_REQUIRED_FIELDS()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_REQUIRED_FIELDS_0")] public static extern 
bool INPUT_REQUIRED_FIELDS_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationStringVectorKey* INPUT_REQUIRED_DATA_TYPE()
// static vtkInformationStringVectorKey* INPUT_REQUIRED_DATA_TYPE()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_REQUIRED_DATA_TYPE_0")] public static extern 
bool INPUT_REQUIRED_DATA_TYPE_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationInformationVectorKey* INPUT_ARRAYS_TO_PROCESS()
// static vtkInformationInformationVectorKey* INPUT_ARRAYS_TO_PROCESS()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_ARRAYS_TO_PROCESS_0")] public static extern 
bool INPUT_ARRAYS_TO_PROCESS_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* INPUT_PORT()
// static vtkInformationIntegerKey* INPUT_PORT()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_PORT_0")] public static extern 
bool INPUT_PORT_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* INPUT_CONNECTION()
// static vtkInformationIntegerKey* INPUT_CONNECTION()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_CONNECTION_0")] public static extern 
bool INPUT_CONNECTION_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* CAN_PRODUCE_SUB_EXTENT()
// static vtkInformationIntegerKey* CAN_PRODUCE_SUB_EXTENT()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_CAN_PRODUCE_SUB_EXTENT_0")] public static extern 
bool CAN_PRODUCE_SUB_EXTENT_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* CAN_HANDLE_PIECE_REQUEST()
// static vtkInformationIntegerKey* CAN_HANDLE_PIECE_REQUEST()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_CAN_HANDLE_PIECE_REQUEST_0")] public static extern 
bool CAN_HANDLE_PIECE_REQUEST_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, const char * name)
// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, const char *name)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputArrayToProcess_0")] public static extern 
bool SetInputArrayToProcess_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, int /*(int)*/ fieldAssociation, string /*(char*)*/ name);

// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputArrayToProcess_1")] public static extern 
bool SetInputArrayToProcess_1(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, int /*(int)*/ fieldAssociation, int /*(int)*/ fieldAttributeType);

// virtual void SetInputArrayToProcess(int idx, vtkInformation * info)
// virtual void SetInputArrayToProcess(int idx, vtkInformation *info)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputArrayToProcess_2")] public static extern 
bool SetInputArrayToProcess_2(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ idx, IntPtr /*(vtkInformation*)*/ info);

// virtual void SetInputArrayToProcess(int idx, int port, int connection, const char * fieldAssociation, const char * attributeTypeorName)
// virtual void SetInputArrayToProcess(int idx, int port, int connection, const char* fieldAssociation, const char* attributeTypeorName)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputArrayToProcess_3")] public static extern 
bool SetInputArrayToProcess_3(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, string /*(char*)*/ fieldAssociation, string /*(char*)*/ attributeTypeorName);

// vtkInformation* GetInputArrayInformation(int idx)
// vtkInformation *GetInputArrayInformation(int idx)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputArrayInformation_0")] public static extern 
bool GetInputArrayInformation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ idx);

// void RemoveAllInputs()
// void RemoveAllInputs()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_RemoveAllInputs_0")] public static extern 
bool RemoveAllInputs_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// vtkDataObject* GetOutputDataObject(int port)
// vtkDataObject* GetOutputDataObject(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetOutputDataObject_0")] public static extern 
bool GetOutputDataObject_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// vtkDataObject* GetInputDataObject(int port, int connection)
// vtkDataObject *GetInputDataObject(int port, int connection)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputDataObject_0")] public static extern 
bool GetInputDataObject_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ connection);

// virtual void SetInputConnection(int port, vtkAlgorithmOutput * input)
// virtual void SetInputConnection(int port, vtkAlgorithmOutput* input)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputConnection_0")] public static extern 
bool SetInputConnection_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkAlgorithmOutput*)*/ input);

// virtual void SetInputConnection(vtkAlgorithmOutput * input)
// virtual void SetInputConnection(vtkAlgorithmOutput* input)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputConnection_1")] public static extern 
bool SetInputConnection_1(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkAlgorithmOutput*)*/ input);

// virtual void AddInputConnection(int port, vtkAlgorithmOutput * input)
// virtual void AddInputConnection(int port, vtkAlgorithmOutput* input)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_AddInputConnection_0")] public static extern 
bool AddInputConnection_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkAlgorithmOutput*)*/ input);

// virtual void AddInputConnection(vtkAlgorithmOutput * input)
// virtual void AddInputConnection(vtkAlgorithmOutput* input)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_AddInputConnection_1")] public static extern 
bool AddInputConnection_1(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkAlgorithmOutput*)*/ input);

// virtual void RemoveInputConnection(int port, vtkAlgorithmOutput * input)
// virtual void RemoveInputConnection(int port, vtkAlgorithmOutput* input)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_RemoveInputConnection_0")] public static extern 
bool RemoveInputConnection_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkAlgorithmOutput*)*/ input);

// virtual void RemoveInputConnection(int port, int idx)
// virtual void RemoveInputConnection(int port, int idx)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_RemoveInputConnection_1")] public static extern 
bool RemoveInputConnection_1(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ idx);

// virtual void RemoveAllInputConnections(int port)
// virtual void RemoveAllInputConnections(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_RemoveAllInputConnections_0")] public static extern 
bool RemoveAllInputConnections_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// virtual void SetInputDataObject(int port, vtkDataObject * data)
// virtual void SetInputDataObject(int port, vtkDataObject* data)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputDataObject_0")] public static extern 
bool SetInputDataObject_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkDataObject*)*/ data);

// virtual void SetInputDataObject(vtkDataObject * data)
// virtual void SetInputDataObject(vtkDataObject* data)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputDataObject_1")] public static extern 
bool SetInputDataObject_1(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ data);

// virtual void AddInputDataObject(int port, vtkDataObject * data)
// virtual void AddInputDataObject(int port, vtkDataObject* data)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_AddInputDataObject_0")] public static extern 
bool AddInputDataObject_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkDataObject*)*/ data);

// virtual void AddInputDataObject(vtkDataObject * data)
// virtual void AddInputDataObject(vtkDataObject* data)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_AddInputDataObject_1")] public static extern 
bool AddInputDataObject_1(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ data);

// vtkAlgorithmOutput* GetOutputPort(int index)
// vtkAlgorithmOutput* GetOutputPort(int index)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetOutputPort_0")] public static extern 
bool GetOutputPort_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ index);

// vtkAlgorithmOutput* GetOutputPort()
// vtkAlgorithmOutput* GetOutputPort()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetOutputPort_1")] public static extern 
bool GetOutputPort_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int GetNumberOfInputConnections(int port)
// int GetNumberOfInputConnections(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetNumberOfInputConnections_0")] public static extern 
bool GetNumberOfInputConnections_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// int GetTotalNumberOfInputConnections()
// int GetTotalNumberOfInputConnections()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetTotalNumberOfInputConnections_0")] public static extern 
bool GetTotalNumberOfInputConnections_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// vtkAlgorithmOutput* GetInputConnection(int port, int index)
// vtkAlgorithmOutput* GetInputConnection(int port, int index)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputConnection_0")] public static extern 
bool GetInputConnection_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ index);

// vtkAlgorithm* GetInputAlgorithm(int port, int index, int & algPort)
// vtkAlgorithm* GetInputAlgorithm(int port, int index, int& algPort)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputAlgorithm_0")] public static extern 
bool GetInputAlgorithm_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ index, IntPtr /*(int&)*/ algPort);

// vtkAlgorithm* GetInputAlgorithm(int port, int index)
// vtkAlgorithm* GetInputAlgorithm(int port, int index)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputAlgorithm_1")] public static extern 
bool GetInputAlgorithm_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ index);

// vtkAlgorithm* GetInputAlgorithm()
// vtkAlgorithm* GetInputAlgorithm()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputAlgorithm_2")] public static extern 
bool GetInputAlgorithm_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// vtkInformation* GetInputInformation(int port, int index)
// vtkInformation* GetInputInformation(int port, int index)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputInformation_0")] public static extern 
bool GetInputInformation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ index);

// vtkInformation* GetInputInformation()
// vtkInformation* GetInputInformation()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputInformation_1")] public static extern 
bool GetInputInformation_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// vtkInformation* GetOutputInformation(int port)
// vtkInformation* GetOutputInformation(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetOutputInformation_0")] public static extern 
bool GetOutputInformation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// virtual void Update(int port)
// virtual void Update(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_Update_0")] public static extern 
bool Update_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// virtual void Update()
// virtual void Update()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_Update_1")] public static extern 
bool Update_1(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual int Update(int port, vtkInformationVector * requests)
// virtual int Update(int port, vtkInformationVector* requests)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_Update_2")] public static extern 
bool Update_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkInformationVector*)*/ requests);

// virtual int Update(vtkInformation * requests)
// virtual int Update(vtkInformation* requests)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_Update_3")] public static extern 
bool Update_3(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ requests);

// virtual int UpdateExtent(const int extents[6])
// virtual int UpdateExtent(const int extents[6])
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateExtent_0")] public static extern 
bool UpdateExtent_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int[6])*/ []extents);

// virtual void UpdateInformation()
// virtual void UpdateInformation()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateInformation_0")] public static extern 
bool UpdateInformation_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual void UpdateDataObject()
// virtual void UpdateDataObject()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateDataObject_0")] public static extern 
bool UpdateDataObject_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual void PropagateUpdateExtent()
// virtual void PropagateUpdateExtent()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_PropagateUpdateExtent_0")] public static extern 
bool PropagateUpdateExtent_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual void UpdateWholeExtent()
// virtual void UpdateWholeExtent()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateWholeExtent_0")] public static extern 
bool UpdateWholeExtent_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// void ConvertTotalInputToPortConnection(int ind, int & port, int & conn)
// void ConvertTotalInputToPortConnection(int ind, int& port, int& conn)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ConvertTotalInputToPortConnection_0")] public static extern 
bool ConvertTotalInputToPortConnection_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ ind, IntPtr /*(int&)*/ port, IntPtr /*(int&)*/ conn);

// virtual void SetReleaseDataFlag(int ARG_0)
// virtual void SetReleaseDataFlag(int)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetReleaseDataFlag_0")] public static extern 
bool SetReleaseDataFlag_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ ARG_0);

// virtual int GetReleaseDataFlag()
// virtual int GetReleaseDataFlag()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetReleaseDataFlag_0")] public static extern 
bool GetReleaseDataFlag_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// void ReleaseDataFlagOn()
// void ReleaseDataFlagOn()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ReleaseDataFlagOn_0")] public static extern 
bool ReleaseDataFlagOn_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// void ReleaseDataFlagOff()
// void ReleaseDataFlagOff()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ReleaseDataFlagOff_0")] public static extern 
bool ReleaseDataFlagOff_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int UpdateExtentIsEmpty(vtkInformation * pinfo, vtkDataObject * output)
// int UpdateExtentIsEmpty(vtkInformation *pinfo, vtkDataObject *output)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateExtentIsEmpty_0")] public static extern 
bool UpdateExtentIsEmpty_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ pinfo, IntPtr /*(vtkDataObject*)*/ output);

// int UpdateExtentIsEmpty(vtkInformation * pinfo, int extentType)
// int UpdateExtentIsEmpty(vtkInformation *pinfo, int extentType)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateExtentIsEmpty_1")] public static extern 
bool UpdateExtentIsEmpty_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ pinfo, int /*(int)*/ extentType);

// int* GetUpdateExtent()
// int* GetUpdateExtent()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateExtent_0")] public static extern 
bool GetUpdateExtent_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int* GetUpdateExtent(int port)
// int* GetUpdateExtent(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateExtent_1")] public static extern 
bool GetUpdateExtent_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// void GetUpdateExtent(int & x0, int & x1, int & y0, int & y1, int & z0, int & z1)
// void GetUpdateExtent(int& x0, int& x1, int& y0, int& y1, int& z0, int& z1)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateExtent_2")] public static extern 
bool GetUpdateExtent_2(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(int&)*/ x0, IntPtr /*(int&)*/ x1, IntPtr /*(int&)*/ y0, IntPtr /*(int&)*/ y1, IntPtr /*(int&)*/ z0, IntPtr /*(int&)*/ z1);

// void GetUpdateExtent(int port, int & x0, int & x1, int & y0, int & y1, int & z0, int & z1)
// void GetUpdateExtent(int port, int& x0, int& x1, int& y0, int& y1, int& z0, int& z1)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateExtent_3")] public static extern 
bool GetUpdateExtent_3(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(int&)*/ x0, IntPtr /*(int&)*/ x1, IntPtr /*(int&)*/ y0, IntPtr /*(int&)*/ y1, IntPtr /*(int&)*/ z0, IntPtr /*(int&)*/ z1);

// void GetUpdateExtent(int extent[6])
// void GetUpdateExtent(int extent[6])
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateExtent_4")] public static extern 
bool GetUpdateExtent_4(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int[6])*/ []extent);

// void GetUpdateExtent(int port, int extent[6])
// void GetUpdateExtent(int port, int extent[6])
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateExtent_5")] public static extern 
bool GetUpdateExtent_5(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int[6])*/ []extent);

// int GetUpdatePiece()
// int GetUpdatePiece()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdatePiece_0")] public static extern 
bool GetUpdatePiece_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int GetUpdatePiece(int port)
// int GetUpdatePiece(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdatePiece_1")] public static extern 
bool GetUpdatePiece_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// int GetUpdateNumberOfPieces()
// int GetUpdateNumberOfPieces()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateNumberOfPieces_0")] public static extern 
bool GetUpdateNumberOfPieces_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int GetUpdateNumberOfPieces(int port)
// int GetUpdateNumberOfPieces(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateNumberOfPieces_1")] public static extern 
bool GetUpdateNumberOfPieces_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// int GetUpdateGhostLevel()
// int GetUpdateGhostLevel()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateGhostLevel_0")] public static extern 
bool GetUpdateGhostLevel_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int GetUpdateGhostLevel(int port)
// int GetUpdateGhostLevel(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateGhostLevel_1")] public static extern 
bool GetUpdateGhostLevel_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// void SetProgressObserver(vtkProgressObserver * ARG_0)
// void SetProgressObserver(vtkProgressObserver*)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetProgressObserver_0")] public static extern 
bool SetProgressObserver_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkProgressObserver*)*/ ARG_0);

// virtual vtkProgressObserver* GetProgressObserver()
// virtual vtkProgressObserver *GetProgressObserver ()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetProgressObserver_0")] public static extern 
bool GetProgressObserver_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

}
};
