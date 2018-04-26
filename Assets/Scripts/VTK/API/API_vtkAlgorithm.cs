
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkAlgorithm {

// static vtkAlgorithm* New()
// static vtkAlgorithm *New()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_New_0")] public static extern 
bool vtkAlgorithm_New_0(IntPtr /*(vtkAlgorithm**)*/ return_value);

// int HasExecutive()
// int HasExecutive()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_HasExecutive_0")] public static extern 
bool vtkAlgorithm_HasExecutive_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// vtkExecutive* GetExecutive()
// vtkExecutive* GetExecutive()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetExecutive_0")] public static extern 
bool vtkAlgorithm_GetExecutive_0(IntPtr /*(vtkExecutive**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual void SetExecutive(vtkExecutive * executive)
// virtual void SetExecutive(vtkExecutive* executive)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetExecutive_0")] public static extern 
bool vtkAlgorithm_SetExecutive_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkExecutive*)*/ executive);

// virtual int ProcessRequest(vtkInformation * request, vtkInformationVector ** inInfo, vtkInformationVector * outInfo)
// virtual int ProcessRequest(vtkInformation* request, vtkInformationVector** inInfo, vtkInformationVector* outInfo)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ProcessRequest_0")] public static extern 
bool vtkAlgorithm_ProcessRequest_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ request, IntPtr /*(vtkInformationVector**)*/ inInfo, IntPtr /*(vtkInformationVector*)*/ outInfo);

// int ProcessRequest(vtkInformation * request, vtkCollection * inInfo, vtkInformationVector * outInfo)
// int ProcessRequest(vtkInformation* request, vtkCollection* inInfo, vtkInformationVector* outInfo)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ProcessRequest_1")] public static extern 
bool vtkAlgorithm_ProcessRequest_1(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ request, IntPtr /*(vtkCollection*)*/ inInfo, IntPtr /*(vtkInformationVector*)*/ outInfo);

// virtual int ComputePipelineMTime(vtkInformation * request, vtkInformationVector ** inInfoVec, vtkInformationVector * outInfoVec, int requestFromOutputPort, vtkMTimeType * mtime)
// virtual int ComputePipelineMTime(vtkInformation* request, vtkInformationVector** inInfoVec, vtkInformationVector* outInfoVec, int requestFromOutputPort, vtkMTimeType* mtime)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ComputePipelineMTime_0")] public static extern 
bool vtkAlgorithm_ComputePipelineMTime_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ request, IntPtr /*(vtkInformationVector**)*/ inInfoVec, IntPtr /*(vtkInformationVector*)*/ outInfoVec, int /*(int)*/ requestFromOutputPort, IntPtr /*(vtkMTimeType*)*/ mtime);

// virtual int ModifyRequest(vtkInformation * request, int when)
// virtual int ModifyRequest(vtkInformation* request, int when)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ModifyRequest_0")] public static extern 
bool vtkAlgorithm_ModifyRequest_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ request, int /*(int)*/ when);

// vtkInformation* GetInputPortInformation(int port)
// vtkInformation* GetInputPortInformation(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputPortInformation_0")] public static extern 
bool vtkAlgorithm_GetInputPortInformation_0(IntPtr /*(vtkInformation**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// vtkInformation* GetOutputPortInformation(int port)
// vtkInformation* GetOutputPortInformation(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetOutputPortInformation_0")] public static extern 
bool vtkAlgorithm_GetOutputPortInformation_0(IntPtr /*(vtkInformation**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// virtual void SetInformation(vtkInformation * ARG_0)
// virtual void SetInformation(vtkInformation*)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInformation_0")] public static extern 
bool vtkAlgorithm_SetInformation_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ ARG_0);

// int GetNumberOfInputPorts()
// int GetNumberOfInputPorts()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetNumberOfInputPorts_0")] public static extern 
bool vtkAlgorithm_GetNumberOfInputPorts_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int GetNumberOfOutputPorts()
// int GetNumberOfOutputPorts()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetNumberOfOutputPorts_0")] public static extern 
bool vtkAlgorithm_GetNumberOfOutputPorts_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// void Register(vtkObjectBase * o)
// void Register(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_Register_0")] public static extern 
bool vtkAlgorithm_Register_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UnRegister_0")] public static extern 
bool vtkAlgorithm_UnRegister_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UpdateProgress(double amount)
// void UpdateProgress(double amount)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateProgress_0")] public static extern 
bool vtkAlgorithm_UpdateProgress_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, double /*(double)*/ amount);

// void SetProgressText(const char * ptext)
// void SetProgressText(const char* ptext)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetProgressText_0")] public static extern 
bool vtkAlgorithm_SetProgressText_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(char*)*/ ptext);

// static vtkInformationIntegerKey* INPUT_IS_OPTIONAL()
// static vtkInformationIntegerKey* INPUT_IS_OPTIONAL()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_IS_OPTIONAL_0")] public static extern 
bool vtkAlgorithm_INPUT_IS_OPTIONAL_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* INPUT_IS_REPEATABLE()
// static vtkInformationIntegerKey* INPUT_IS_REPEATABLE()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_IS_REPEATABLE_0")] public static extern 
bool vtkAlgorithm_INPUT_IS_REPEATABLE_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationInformationVectorKey* INPUT_REQUIRED_FIELDS()
// static vtkInformationInformationVectorKey* INPUT_REQUIRED_FIELDS()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_REQUIRED_FIELDS_0")] public static extern 
bool vtkAlgorithm_INPUT_REQUIRED_FIELDS_0(IntPtr /*(vtkInformationInformationVectorKey**)*/ return_value);

// static vtkInformationStringVectorKey* INPUT_REQUIRED_DATA_TYPE()
// static vtkInformationStringVectorKey* INPUT_REQUIRED_DATA_TYPE()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_REQUIRED_DATA_TYPE_0")] public static extern 
bool vtkAlgorithm_INPUT_REQUIRED_DATA_TYPE_0(IntPtr /*(vtkInformationStringVectorKey**)*/ return_value);

// static vtkInformationInformationVectorKey* INPUT_ARRAYS_TO_PROCESS()
// static vtkInformationInformationVectorKey* INPUT_ARRAYS_TO_PROCESS()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_ARRAYS_TO_PROCESS_0")] public static extern 
bool vtkAlgorithm_INPUT_ARRAYS_TO_PROCESS_0(IntPtr /*(vtkInformationInformationVectorKey**)*/ return_value);

// static vtkInformationIntegerKey* INPUT_PORT()
// static vtkInformationIntegerKey* INPUT_PORT()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_PORT_0")] public static extern 
bool vtkAlgorithm_INPUT_PORT_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* INPUT_CONNECTION()
// static vtkInformationIntegerKey* INPUT_CONNECTION()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_INPUT_CONNECTION_0")] public static extern 
bool vtkAlgorithm_INPUT_CONNECTION_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* CAN_PRODUCE_SUB_EXTENT()
// static vtkInformationIntegerKey* CAN_PRODUCE_SUB_EXTENT()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_CAN_PRODUCE_SUB_EXTENT_0")] public static extern 
bool vtkAlgorithm_CAN_PRODUCE_SUB_EXTENT_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* CAN_HANDLE_PIECE_REQUEST()
// static vtkInformationIntegerKey* CAN_HANDLE_PIECE_REQUEST()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_CAN_HANDLE_PIECE_REQUEST_0")] public static extern 
bool vtkAlgorithm_CAN_HANDLE_PIECE_REQUEST_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, const char * name)
// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, const char *name)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputArrayToProcess_0")] public static extern 
bool vtkAlgorithm_SetInputArrayToProcess_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, int /*(int)*/ fieldAssociation, IntPtr /*(char*)*/ name);

// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputArrayToProcess_1")] public static extern 
bool vtkAlgorithm_SetInputArrayToProcess_1(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, int /*(int)*/ fieldAssociation, int /*(int)*/ fieldAttributeType);

// virtual void SetInputArrayToProcess(int idx, vtkInformation * info)
// virtual void SetInputArrayToProcess(int idx, vtkInformation *info)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputArrayToProcess_2")] public static extern 
bool vtkAlgorithm_SetInputArrayToProcess_2(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ idx, IntPtr /*(vtkInformation*)*/ info);

// virtual void SetInputArrayToProcess(int idx, int port, int connection, const char * fieldAssociation, const char * attributeTypeorName)
// virtual void SetInputArrayToProcess(int idx, int port, int connection, const char* fieldAssociation, const char* attributeTypeorName)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputArrayToProcess_3")] public static extern 
bool vtkAlgorithm_SetInputArrayToProcess_3(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, IntPtr /*(char*)*/ fieldAssociation, IntPtr /*(char*)*/ attributeTypeorName);

// vtkInformation* GetInputArrayInformation(int idx)
// vtkInformation *GetInputArrayInformation(int idx)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputArrayInformation_0")] public static extern 
bool vtkAlgorithm_GetInputArrayInformation_0(IntPtr /*(vtkInformation**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ idx);

// void RemoveAllInputs()
// void RemoveAllInputs()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_RemoveAllInputs_0")] public static extern 
bool vtkAlgorithm_RemoveAllInputs_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// vtkDataObject* GetOutputDataObject(int port)
// vtkDataObject* GetOutputDataObject(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetOutputDataObject_0")] public static extern 
bool vtkAlgorithm_GetOutputDataObject_0(IntPtr /*(vtkDataObject**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// vtkDataObject* GetInputDataObject(int port, int connection)
// vtkDataObject *GetInputDataObject(int port, int connection)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputDataObject_0")] public static extern 
bool vtkAlgorithm_GetInputDataObject_0(IntPtr /*(vtkDataObject**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ connection);

// virtual void SetInputConnection(int port, vtkAlgorithmOutput * input)
// virtual void SetInputConnection(int port, vtkAlgorithmOutput* input)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputConnection_0")] public static extern 
bool vtkAlgorithm_SetInputConnection_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkAlgorithmOutput*)*/ input);

// virtual void SetInputConnection(vtkAlgorithmOutput * input)
// virtual void SetInputConnection(vtkAlgorithmOutput* input)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputConnection_1")] public static extern 
bool vtkAlgorithm_SetInputConnection_1(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkAlgorithmOutput*)*/ input);

// virtual void AddInputConnection(int port, vtkAlgorithmOutput * input)
// virtual void AddInputConnection(int port, vtkAlgorithmOutput* input)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_AddInputConnection_0")] public static extern 
bool vtkAlgorithm_AddInputConnection_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkAlgorithmOutput*)*/ input);

// virtual void AddInputConnection(vtkAlgorithmOutput * input)
// virtual void AddInputConnection(vtkAlgorithmOutput* input)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_AddInputConnection_1")] public static extern 
bool vtkAlgorithm_AddInputConnection_1(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkAlgorithmOutput*)*/ input);

// virtual void RemoveInputConnection(int port, vtkAlgorithmOutput * input)
// virtual void RemoveInputConnection(int port, vtkAlgorithmOutput* input)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_RemoveInputConnection_0")] public static extern 
bool vtkAlgorithm_RemoveInputConnection_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkAlgorithmOutput*)*/ input);

// virtual void RemoveInputConnection(int port, int idx)
// virtual void RemoveInputConnection(int port, int idx)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_RemoveInputConnection_1")] public static extern 
bool vtkAlgorithm_RemoveInputConnection_1(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ idx);

// virtual void RemoveAllInputConnections(int port)
// virtual void RemoveAllInputConnections(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_RemoveAllInputConnections_0")] public static extern 
bool vtkAlgorithm_RemoveAllInputConnections_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// virtual void SetInputDataObject(int port, vtkDataObject * data)
// virtual void SetInputDataObject(int port, vtkDataObject* data)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputDataObject_0")] public static extern 
bool vtkAlgorithm_SetInputDataObject_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkDataObject*)*/ data);

// virtual void SetInputDataObject(vtkDataObject * data)
// virtual void SetInputDataObject(vtkDataObject* data)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputDataObject_1")] public static extern 
bool vtkAlgorithm_SetInputDataObject_1(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ data);

// virtual void AddInputDataObject(int port, vtkDataObject * data)
// virtual void AddInputDataObject(int port, vtkDataObject* data)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_AddInputDataObject_0")] public static extern 
bool vtkAlgorithm_AddInputDataObject_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkDataObject*)*/ data);

// virtual void AddInputDataObject(vtkDataObject * data)
// virtual void AddInputDataObject(vtkDataObject* data)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_AddInputDataObject_1")] public static extern 
bool vtkAlgorithm_AddInputDataObject_1(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ data);

// vtkAlgorithmOutput* GetOutputPort(int index)
// vtkAlgorithmOutput* GetOutputPort(int index)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetOutputPort_0")] public static extern 
bool vtkAlgorithm_GetOutputPort_0(IntPtr /*(vtkAlgorithmOutput**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ index);

// vtkAlgorithmOutput* GetOutputPort()
// vtkAlgorithmOutput* GetOutputPort()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetOutputPort_1")] public static extern 
bool vtkAlgorithm_GetOutputPort_1(IntPtr /*(vtkAlgorithmOutput**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int GetNumberOfInputConnections(int port)
// int GetNumberOfInputConnections(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetNumberOfInputConnections_0")] public static extern 
bool vtkAlgorithm_GetNumberOfInputConnections_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// int GetTotalNumberOfInputConnections()
// int GetTotalNumberOfInputConnections()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetTotalNumberOfInputConnections_0")] public static extern 
bool vtkAlgorithm_GetTotalNumberOfInputConnections_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// vtkAlgorithmOutput* GetInputConnection(int port, int index)
// vtkAlgorithmOutput* GetInputConnection(int port, int index)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputConnection_0")] public static extern 
bool vtkAlgorithm_GetInputConnection_0(IntPtr /*(vtkAlgorithmOutput**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ index);

// vtkAlgorithm* GetInputAlgorithm(int port, int index, int & algPort)
// vtkAlgorithm* GetInputAlgorithm(int port, int index, int& algPort)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputAlgorithm_0")] public static extern 
bool vtkAlgorithm_GetInputAlgorithm_0(IntPtr /*(vtkAlgorithm**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ index, IntPtr /*(int&)*/ algPort);

// vtkAlgorithm* GetInputAlgorithm(int port, int index)
// vtkAlgorithm* GetInputAlgorithm(int port, int index)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputAlgorithm_1")] public static extern 
bool vtkAlgorithm_GetInputAlgorithm_1(IntPtr /*(vtkAlgorithm**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ index);

// vtkAlgorithm* GetInputAlgorithm()
// vtkAlgorithm* GetInputAlgorithm()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputAlgorithm_2")] public static extern 
bool vtkAlgorithm_GetInputAlgorithm_2(IntPtr /*(vtkAlgorithm**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// vtkExecutive* GetInputExecutive(int port, int index)
// vtkExecutive* GetInputExecutive(int port, int index)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputExecutive_0")] public static extern 
bool vtkAlgorithm_GetInputExecutive_0(IntPtr /*(vtkExecutive**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ index);

// vtkExecutive* GetInputExecutive()
// vtkExecutive* GetInputExecutive()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputExecutive_1")] public static extern 
bool vtkAlgorithm_GetInputExecutive_1(IntPtr /*(vtkExecutive**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// vtkInformation* GetInputInformation(int port, int index)
// vtkInformation* GetInputInformation(int port, int index)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputInformation_0")] public static extern 
bool vtkAlgorithm_GetInputInformation_0(IntPtr /*(vtkInformation**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int)*/ index);

// vtkInformation* GetInputInformation()
// vtkInformation* GetInputInformation()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetInputInformation_1")] public static extern 
bool vtkAlgorithm_GetInputInformation_1(IntPtr /*(vtkInformation**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// vtkInformation* GetOutputInformation(int port)
// vtkInformation* GetOutputInformation(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetOutputInformation_0")] public static extern 
bool vtkAlgorithm_GetOutputInformation_0(IntPtr /*(vtkInformation**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// virtual void Update(int port)
// virtual void Update(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_Update_0")] public static extern 
bool vtkAlgorithm_Update_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// virtual void Update()
// virtual void Update()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_Update_1")] public static extern 
bool vtkAlgorithm_Update_1(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual int Update(int port, vtkInformationVector * requests)
// virtual int Update(int port, vtkInformationVector* requests)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_Update_2")] public static extern 
bool vtkAlgorithm_Update_2(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(vtkInformationVector*)*/ requests);

// virtual int Update(vtkInformation * requests)
// virtual int Update(vtkInformation* requests)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_Update_3")] public static extern 
bool vtkAlgorithm_Update_3(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ requests);

// virtual int UpdatePiece(int piece, int numPieces, int ghostLevels, const int extents[6] = nullptr)
// virtual int UpdatePiece( int piece, int numPieces, int ghostLevels, const int extents[6]=nullptr)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdatePiece_0")] public static extern 
bool vtkAlgorithm_UpdatePiece_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ piece, int /*(int)*/ numPieces, int /*(int)*/ ghostLevels, int /*(int[6])*/ []extents);

// virtual int UpdateExtent(const int extents[6])
// virtual int UpdateExtent(const int extents[6])
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateExtent_0")] public static extern 
bool vtkAlgorithm_UpdateExtent_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int[6])*/ []extents);

// virtual void UpdateInformation()
// virtual void UpdateInformation()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateInformation_0")] public static extern 
bool vtkAlgorithm_UpdateInformation_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual void UpdateDataObject()
// virtual void UpdateDataObject()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateDataObject_0")] public static extern 
bool vtkAlgorithm_UpdateDataObject_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual void PropagateUpdateExtent()
// virtual void PropagateUpdateExtent()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_PropagateUpdateExtent_0")] public static extern 
bool vtkAlgorithm_PropagateUpdateExtent_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual void UpdateWholeExtent()
// virtual void UpdateWholeExtent()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateWholeExtent_0")] public static extern 
bool vtkAlgorithm_UpdateWholeExtent_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// void ConvertTotalInputToPortConnection(int ind, int & port, int & conn)
// void ConvertTotalInputToPortConnection(int ind, int& port, int& conn)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ConvertTotalInputToPortConnection_0")] public static extern 
bool vtkAlgorithm_ConvertTotalInputToPortConnection_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ ind, IntPtr /*(int&)*/ port, IntPtr /*(int&)*/ conn);

// virtual void SetReleaseDataFlag(int ARG_0)
// virtual void SetReleaseDataFlag(int)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetReleaseDataFlag_0")] public static extern 
bool vtkAlgorithm_SetReleaseDataFlag_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ ARG_0);

// virtual int GetReleaseDataFlag()
// virtual int GetReleaseDataFlag()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetReleaseDataFlag_0")] public static extern 
bool vtkAlgorithm_GetReleaseDataFlag_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// void ReleaseDataFlagOn()
// void ReleaseDataFlagOn()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ReleaseDataFlagOn_0")] public static extern 
bool vtkAlgorithm_ReleaseDataFlagOn_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// void ReleaseDataFlagOff()
// void ReleaseDataFlagOff()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_ReleaseDataFlagOff_0")] public static extern 
bool vtkAlgorithm_ReleaseDataFlagOff_0(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int UpdateExtentIsEmpty(vtkInformation * pinfo, vtkDataObject * output)
// int UpdateExtentIsEmpty(vtkInformation *pinfo, vtkDataObject *output)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateExtentIsEmpty_0")] public static extern 
bool vtkAlgorithm_UpdateExtentIsEmpty_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ pinfo, IntPtr /*(vtkDataObject*)*/ output);

// int UpdateExtentIsEmpty(vtkInformation * pinfo, int extentType)
// int UpdateExtentIsEmpty(vtkInformation *pinfo, int extentType)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateExtentIsEmpty_1")] public static extern 
bool vtkAlgorithm_UpdateExtentIsEmpty_1(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkInformation*)*/ pinfo, int /*(int)*/ extentType);

// static void SetDefaultExecutivePrototype(vtkExecutive * proto)
// static void SetDefaultExecutivePrototype(vtkExecutive* proto)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetDefaultExecutivePrototype_0")] public static extern 
bool vtkAlgorithm_SetDefaultExecutivePrototype_0(IntPtr /*(vtkExecutive*)*/ proto);

// int* GetUpdateExtent()
// int* GetUpdateExtent()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateExtent_0")] public static extern 
bool vtkAlgorithm_GetUpdateExtent_0(IntPtr /*(int**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int* GetUpdateExtent(int port)
// int* GetUpdateExtent(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateExtent_1")] public static extern 
bool vtkAlgorithm_GetUpdateExtent_1(IntPtr /*(int**)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// void GetUpdateExtent(int & x0, int & x1, int & y0, int & y1, int & z0, int & z1)
// void GetUpdateExtent(int& x0, int& x1, int& y0, int& y1, int& z0, int& z1)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateExtent_2")] public static extern 
bool vtkAlgorithm_GetUpdateExtent_2(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(int&)*/ x0, IntPtr /*(int&)*/ x1, IntPtr /*(int&)*/ y0, IntPtr /*(int&)*/ y1, IntPtr /*(int&)*/ z0, IntPtr /*(int&)*/ z1);

// void GetUpdateExtent(int port, int & x0, int & x1, int & y0, int & y1, int & z0, int & z1)
// void GetUpdateExtent(int port, int& x0, int& x1, int& y0, int& y1, int& z0, int& z1)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateExtent_3")] public static extern 
bool vtkAlgorithm_GetUpdateExtent_3(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, IntPtr /*(int&)*/ x0, IntPtr /*(int&)*/ x1, IntPtr /*(int&)*/ y0, IntPtr /*(int&)*/ y1, IntPtr /*(int&)*/ z0, IntPtr /*(int&)*/ z1);

// void GetUpdateExtent(int extent[6])
// void GetUpdateExtent(int extent[6])
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateExtent_4")] public static extern 
bool vtkAlgorithm_GetUpdateExtent_4(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int[6])*/ []extent);

// void GetUpdateExtent(int port, int extent[6])
// void GetUpdateExtent(int port, int extent[6])
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateExtent_5")] public static extern 
bool vtkAlgorithm_GetUpdateExtent_5(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port, int /*(int[6])*/ []extent);

// int GetUpdatePiece()
// int GetUpdatePiece()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdatePiece_0")] public static extern 
bool vtkAlgorithm_GetUpdatePiece_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int GetUpdatePiece(int port)
// int GetUpdatePiece(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdatePiece_1")] public static extern 
bool vtkAlgorithm_GetUpdatePiece_1(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// int GetUpdateNumberOfPieces()
// int GetUpdateNumberOfPieces()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateNumberOfPieces_0")] public static extern 
bool vtkAlgorithm_GetUpdateNumberOfPieces_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int GetUpdateNumberOfPieces(int port)
// int GetUpdateNumberOfPieces(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateNumberOfPieces_1")] public static extern 
bool vtkAlgorithm_GetUpdateNumberOfPieces_1(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// int GetUpdateGhostLevel()
// int GetUpdateGhostLevel()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateGhostLevel_0")] public static extern 
bool vtkAlgorithm_GetUpdateGhostLevel_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

// int GetUpdateGhostLevel(int port)
// int GetUpdateGhostLevel(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_GetUpdateGhostLevel_1")] public static extern 
bool vtkAlgorithm_GetUpdateGhostLevel_1(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// void SetProgressObserver(vtkProgressObserver * ARG_0)
// void SetProgressObserver(vtkProgressObserver*)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetProgressObserver_0")] public static extern 
bool vtkAlgorithm_SetProgressObserver_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, IntPtr /*(vtkProgressObserver*)*/ ARG_0);

}
};
