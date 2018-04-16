
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkAlgorithm {

//       Method: static vtkAlgorithm * vtkAlgorithm::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAlgorithm_New_0")] public static extern 
bool New(IntPtr /*vtkAlgorithm** */ ret);

//       Method: virtual const char * vtkAlgorithm::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: int vtkAlgorithm::HasExecutive()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_HasExecutive_0")] public static extern 
bool HasExecutive(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: vtkExecutive * vtkAlgorithm::GetExecutive()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetExecutive_0")] public static extern 
bool GetExecutive(IntPtr /*vtkExecutive** */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: virtual void vtkAlgorithm::SetExecutive(vtkExecutive* executive)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_SetExecutive_0")] public static extern 
bool SetExecutive(IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkExecutive* */ executive);

//       Method: virtual int vtkAlgorithm::ProcessRequest(vtkInformation* request, vtkInformationVector** inInfo, vtkInformationVector* outInfo)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_ProcessRequest_0")] public static extern 
bool ProcessRequest(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkInformation* */ request, IntPtr/*vtkInformationVector** */ inInfo, IntPtr/*vtkInformationVector* */ outInfo);

////       Method: int vtkAlgorithm::ProcessRequest(vtkInformation* request, vtkCollection* inInfo, vtkInformationVector* outInfo)
//// 
//[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_ProcessRequest_1")] public static extern 
//bool ProcessRequest(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkInformation* */ request, IntPtr/*vtkCollection* */ inInfo, IntPtr/*vtkInformationVector* */ outInfo);
//
//       Method: virtual int vtkAlgorithm::ComputePipelineMTime(vtkInformation* request, vtkInformationVector** inInfoVec, vtkInformationVector* outInfoVec, int requestFromOutputPort, vtkMTimeType* mtime)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_ComputePipelineMTime_0")] public static extern 
bool ComputePipelineMTime(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkInformation* */ request, IntPtr/*vtkInformationVector** */ inInfoVec, IntPtr/*vtkInformationVector* */ outInfoVec, int requestFromOutputPort, IntPtr/*vtkMTimeType* */ mtime);

//       Method: virtual int vtkAlgorithm::ModifyRequest(vtkInformation* request, int when)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_ModifyRequest_0")] public static extern 
bool ModifyRequest(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkInformation* */ request, int when);

//       Method: vtkInformation * vtkAlgorithm::GetInputPortInformation(int port)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetInputPortInformation_0")] public static extern 
bool GetInputPortInformation(IntPtr /*vtkInformation** */ ret, IntPtr /*vtkAlgorithm* */ obj, int port);

//       Method: vtkInformation * vtkAlgorithm::GetOutputPortInformation(int port)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetOutputPortInformation_0")] public static extern 
bool GetOutputPortInformation(IntPtr /*vtkInformation** */ ret, IntPtr /*vtkAlgorithm* */ obj, int port);

//       Method: virtual void vtkAlgorithm::SetInformation(vtkInformation* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_SetInformation_0")] public static extern 
bool SetInformation(IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkInformation* */ ARG_0);

//       Method: int vtkAlgorithm::GetNumberOfInputPorts()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetNumberOfInputPorts_0")] public static extern 
bool GetNumberOfInputPorts(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: int vtkAlgorithm::GetNumberOfOutputPorts()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetNumberOfOutputPorts_0")] public static extern 
bool GetNumberOfOutputPorts(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: void vtkAlgorithm::Register(vtkObjectBase* o)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_Register_0")] public static extern 
bool Register(IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkObjectBase* */ o);

//       Method: void vtkAlgorithm::UnRegister(vtkObjectBase* o)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_UnRegister_0")] public static extern 
bool UnRegister(IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkObjectBase* */ o);

//       Method: void vtkAlgorithm::UpdateProgress(double amount)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_UpdateProgress_0")] public static extern 
bool UpdateProgress(IntPtr /*vtkAlgorithm* */ obj, double amount);

//       Method: void vtkAlgorithm::SetProgressText(const char* ptext)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_SetProgressText_0")] public static extern 
bool SetProgressText(IntPtr /*vtkAlgorithm* */ obj, string/*const char* */ ptext);

//       Method: static vtkInformationIntegerKey * vtkAlgorithm::INPUT_IS_OPTIONAL()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAlgorithm_INPUT_IS_OPTIONAL_0")] public static extern 
bool INPUT_IS_OPTIONAL(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkAlgorithm::INPUT_IS_REPEATABLE()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAlgorithm_INPUT_IS_REPEATABLE_0")] public static extern 
bool INPUT_IS_REPEATABLE(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationInformationVectorKey * vtkAlgorithm::INPUT_REQUIRED_FIELDS()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAlgorithm_INPUT_REQUIRED_FIELDS_0")] public static extern 
bool INPUT_REQUIRED_FIELDS(IntPtr /*vtkInformationInformationVectorKey** */ ret);

//       Method: static vtkInformationStringVectorKey * vtkAlgorithm::INPUT_REQUIRED_DATA_TYPE()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAlgorithm_INPUT_REQUIRED_DATA_TYPE_0")] public static extern 
bool INPUT_REQUIRED_DATA_TYPE(IntPtr /*vtkInformationStringVectorKey** */ ret);

//       Method: static vtkInformationInformationVectorKey * vtkAlgorithm::INPUT_ARRAYS_TO_PROCESS()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAlgorithm_INPUT_ARRAYS_TO_PROCESS_0")] public static extern 
bool INPUT_ARRAYS_TO_PROCESS(IntPtr /*vtkInformationInformationVectorKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkAlgorithm::INPUT_PORT()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAlgorithm_INPUT_PORT_0")] public static extern 
bool INPUT_PORT(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkAlgorithm::INPUT_CONNECTION()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAlgorithm_INPUT_CONNECTION_0")] public static extern 
bool INPUT_CONNECTION(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkAlgorithm::CAN_PRODUCE_SUB_EXTENT()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAlgorithm_CAN_PRODUCE_SUB_EXTENT_0")] public static extern 
bool CAN_PRODUCE_SUB_EXTENT(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkAlgorithm::CAN_HANDLE_PIECE_REQUEST()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAlgorithm_CAN_HANDLE_PIECE_REQUEST_0")] public static extern 
bool CAN_HANDLE_PIECE_REQUEST(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: virtual void vtkAlgorithm::SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_SetInputArrayToProcess_0")] public static extern 
bool SetInputArrayToProcess(IntPtr /*vtkAlgorithm* */ obj, int idx, int port, int connection, int fieldAssociation, string/*const char* */ name);

//       Method: virtual void vtkAlgorithm::SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_SetInputArrayToProcess_1")] public static extern 
bool SetInputArrayToProcess(IntPtr /*vtkAlgorithm* */ obj, int idx, int port, int connection, int fieldAssociation, int fieldAttributeType);

//       Method: virtual void vtkAlgorithm::SetInputArrayToProcess(int idx, vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_SetInputArrayToProcess_2")] public static extern 
bool SetInputArrayToProcess(IntPtr /*vtkAlgorithm* */ obj, int idx, IntPtr/*vtkInformation* */ info);

//       Method: virtual void vtkAlgorithm::SetInputArrayToProcess(int idx, int port, int connection, const char* fieldAssociation, const char* attributeTypeorName)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_SetInputArrayToProcess_3")] public static extern 
bool SetInputArrayToProcess(IntPtr /*vtkAlgorithm* */ obj, int idx, int port, int connection, string/*const char* */ fieldAssociation, string/*const char* */ attributeTypeorName);

//       Method: vtkInformation * vtkAlgorithm::GetInputArrayInformation(int idx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetInputArrayInformation_0")] public static extern 
bool GetInputArrayInformation(IntPtr /*vtkInformation** */ ret, IntPtr /*vtkAlgorithm* */ obj, int idx);

//       Method: void vtkAlgorithm::RemoveAllInputs()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_RemoveAllInputs_0")] public static extern 
bool RemoveAllInputs(IntPtr /*vtkAlgorithm* */ obj);

//       Method: vtkDataObject * vtkAlgorithm::GetOutputDataObject(int port)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetOutputDataObject_0")] public static extern 
bool GetOutputDataObject(IntPtr /*vtkDataObject** */ ret, IntPtr /*vtkAlgorithm* */ obj, int port);

//       Method: vtkDataObject * vtkAlgorithm::GetInputDataObject(int port, int connection)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetInputDataObject_0")] public static extern 
bool GetInputDataObject(IntPtr /*vtkDataObject** */ ret, IntPtr /*vtkAlgorithm* */ obj, int port, int connection);

//       Method: virtual void vtkAlgorithm::SetInputConnection(int port, vtkAlgorithmOutput* input)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_SetInputConnection_0")] public static extern 
bool SetInputConnection(IntPtr /*vtkAlgorithm* */ obj, int port, IntPtr/*vtkAlgorithmOutput* */ input);

//       Method: virtual void vtkAlgorithm::SetInputConnection(vtkAlgorithmOutput* input)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_SetInputConnection_1")] public static extern 
bool SetInputConnection(IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkAlgorithmOutput* */ input);

//       Method: virtual void vtkAlgorithm::AddInputConnection(int port, vtkAlgorithmOutput* input)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_AddInputConnection_0")] public static extern 
bool AddInputConnection(IntPtr /*vtkAlgorithm* */ obj, int port, IntPtr/*vtkAlgorithmOutput* */ input);

//       Method: virtual void vtkAlgorithm::AddInputConnection(vtkAlgorithmOutput* input)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_AddInputConnection_1")] public static extern 
bool AddInputConnection(IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkAlgorithmOutput* */ input);

//       Method: virtual void vtkAlgorithm::RemoveInputConnection(int port, vtkAlgorithmOutput* input)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_RemoveInputConnection_0")] public static extern 
bool RemoveInputConnection(IntPtr /*vtkAlgorithm* */ obj, int port, IntPtr/*vtkAlgorithmOutput* */ input);

//       Method: virtual void vtkAlgorithm::RemoveInputConnection(int port, int idx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_RemoveInputConnection_1")] public static extern 
bool RemoveInputConnection(IntPtr /*vtkAlgorithm* */ obj, int port, int idx);

//       Method: virtual void vtkAlgorithm::RemoveAllInputConnections(int port)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_RemoveAllInputConnections_0")] public static extern 
bool RemoveAllInputConnections(IntPtr /*vtkAlgorithm* */ obj, int port);

//       Method: virtual void vtkAlgorithm::SetInputDataObject(int port, vtkDataObject* data)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_SetInputDataObject_0")] public static extern 
bool SetInputDataObject(IntPtr /*vtkAlgorithm* */ obj, int port, IntPtr/*vtkDataObject* */ data);

//       Method: virtual void vtkAlgorithm::SetInputDataObject(vtkDataObject* data)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_SetInputDataObject_1")] public static extern 
bool SetInputDataObject(IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkDataObject* */ data);

//       Method: virtual void vtkAlgorithm::AddInputDataObject(int port, vtkDataObject* data)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_AddInputDataObject_0")] public static extern 
bool AddInputDataObject(IntPtr /*vtkAlgorithm* */ obj, int port, IntPtr/*vtkDataObject* */ data);

//       Method: virtual void vtkAlgorithm::AddInputDataObject(vtkDataObject* data)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_AddInputDataObject_1")] public static extern 
bool AddInputDataObject(IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkDataObject* */ data);

//       Method: vtkAlgorithmOutput * vtkAlgorithm::GetOutputPort(int index)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetOutputPort_0")] public static extern 
bool GetOutputPort(IntPtr /*vtkAlgorithmOutput** */ ret, IntPtr /*vtkAlgorithm* */ obj, int index);

//       Method: vtkAlgorithmOutput * vtkAlgorithm::GetOutputPort()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetOutputPort_1")] public static extern 
bool GetOutputPort(IntPtr /*vtkAlgorithmOutput** */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: int vtkAlgorithm::GetNumberOfInputConnections(int port)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetNumberOfInputConnections_0")] public static extern 
bool GetNumberOfInputConnections(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, int port);

//       Method: int vtkAlgorithm::GetTotalNumberOfInputConnections()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetTotalNumberOfInputConnections_0")] public static extern 
bool GetTotalNumberOfInputConnections(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: vtkAlgorithmOutput * vtkAlgorithm::GetInputConnection(int port, int index)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetInputConnection_0")] public static extern 
bool GetInputConnection(IntPtr /*vtkAlgorithmOutput** */ ret, IntPtr /*vtkAlgorithm* */ obj, int port, int index);

//       Method: vtkAlgorithm * vtkAlgorithm::GetInputAlgorithm(int port, int index)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetInputAlgorithm_1")] public static extern 
bool GetInputAlgorithm(IntPtr /*vtkAlgorithm** */ ret, IntPtr /*vtkAlgorithm* */ obj, int port, int index);

//       Method: vtkAlgorithm * vtkAlgorithm::GetInputAlgorithm()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetInputAlgorithm_2")] public static extern 
bool GetInputAlgorithm(IntPtr /*vtkAlgorithm** */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: vtkExecutive * vtkAlgorithm::GetInputExecutive(int port, int index)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetInputExecutive_0")] public static extern 
bool GetInputExecutive(IntPtr /*vtkExecutive** */ ret, IntPtr /*vtkAlgorithm* */ obj, int port, int index);

//       Method: vtkExecutive * vtkAlgorithm::GetInputExecutive()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetInputExecutive_1")] public static extern 
bool GetInputExecutive(IntPtr /*vtkExecutive** */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: vtkInformation * vtkAlgorithm::GetInputInformation(int port, int index)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetInputInformation_0")] public static extern 
bool GetInputInformation(IntPtr /*vtkInformation** */ ret, IntPtr /*vtkAlgorithm* */ obj, int port, int index);

//       Method: vtkInformation * vtkAlgorithm::GetInputInformation()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetInputInformation_1")] public static extern 
bool GetInputInformation(IntPtr /*vtkInformation** */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: vtkInformation * vtkAlgorithm::GetOutputInformation(int port)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetOutputInformation_0")] public static extern 
bool GetOutputInformation(IntPtr /*vtkInformation** */ ret, IntPtr /*vtkAlgorithm* */ obj, int port);

//       Method: virtual void vtkAlgorithm::Update(int port)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_Update_0")] public static extern 
bool Update(IntPtr /*vtkAlgorithm* */ obj, int port);

//       Method: virtual void vtkAlgorithm::Update()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_Update_1")] public static extern 
bool Update(IntPtr /*vtkAlgorithm* */ obj);

//       Method: virtual int vtkAlgorithm::Update(int port, vtkInformationVector* requests)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_Update_2")] public static extern 
bool Update(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, int port, IntPtr/*vtkInformationVector* */ requests);

//       Method: virtual int vtkAlgorithm::Update(vtkInformation* requests)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_Update_3")] public static extern 
bool Update(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkInformation* */ requests);

//       Method: virtual int vtkAlgorithm::UpdatePiece(int piece, int numPieces, int ghostLevels, const int extents[6])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_UpdatePiece_0")] public static extern 
bool UpdatePiece(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, int piece, int numPieces, int ghostLevels,  int[] /*6*/ extents);

//       Method: virtual int vtkAlgorithm::UpdateExtent(const int extents[6])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_UpdateExtent_0")] public static extern 
bool UpdateExtent(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj,  int[] /*6*/ extents);

//       Method: virtual int vtkAlgorithm::UpdateTimeStep(double time, int numPieces, int ghostLevels, const int extents[6])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_UpdateTimeStep_0")] public static extern 
bool UpdateTimeStep(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, double time, int numPieces, int ghostLevels, int[] /*6*/ extents);

//       Method: virtual void vtkAlgorithm::UpdateInformation()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_UpdateInformation_0")] public static extern 
bool UpdateInformation(IntPtr /*vtkAlgorithm* */ obj);

//       Method: virtual void vtkAlgorithm::UpdateDataObject()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_UpdateDataObject_0")] public static extern 
bool UpdateDataObject(IntPtr /*vtkAlgorithm* */ obj);

//       Method: virtual void vtkAlgorithm::PropagateUpdateExtent()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_PropagateUpdateExtent_0")] public static extern 
bool PropagateUpdateExtent(IntPtr /*vtkAlgorithm* */ obj);

//       Method: virtual void vtkAlgorithm::UpdateWholeExtent()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_UpdateWholeExtent_0")] public static extern 
bool UpdateWholeExtent(IntPtr /*vtkAlgorithm* */ obj);

//       Method: virtual void vtkAlgorithm::SetReleaseDataFlag(int ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_SetReleaseDataFlag_0")] public static extern 
bool SetReleaseDataFlag(IntPtr /*vtkAlgorithm* */ obj, int ARG_0);

//       Method: virtual int vtkAlgorithm::GetReleaseDataFlag()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetReleaseDataFlag_0")] public static extern 
bool GetReleaseDataFlag(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: void vtkAlgorithm::ReleaseDataFlagOn()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_ReleaseDataFlagOn_0")] public static extern 
bool ReleaseDataFlagOn(IntPtr /*vtkAlgorithm* */ obj);

//       Method: void vtkAlgorithm::ReleaseDataFlagOff()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_ReleaseDataFlagOff_0")] public static extern 
bool ReleaseDataFlagOff(IntPtr /*vtkAlgorithm* */ obj);

//       Method: int vtkAlgorithm::UpdateExtentIsEmpty(vtkInformation* pinfo, vtkDataObject* output)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_UpdateExtentIsEmpty_0")] public static extern 
bool UpdateExtentIsEmpty(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkInformation* */ pinfo, IntPtr/*vtkDataObject* */ output);

//       Method: int vtkAlgorithm::UpdateExtentIsEmpty(vtkInformation* pinfo, int extentType)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_UpdateExtentIsEmpty_1")] public static extern 
bool UpdateExtentIsEmpty(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkInformation* */ pinfo, int extentType);

//       Method: static void vtkAlgorithm::SetDefaultExecutivePrototype(vtkExecutive* proto)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAlgorithm_SetDefaultExecutivePrototype_0")] public static extern 
bool SetDefaultExecutivePrototype(IntPtr/*vtkExecutive* */ proto);

//       Method: int * vtkAlgorithm::GetUpdateExtent()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetUpdateExtent_0")] public static extern 
bool GetUpdateExtent(IntPtr /*int** */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: int * vtkAlgorithm::GetUpdateExtent(int port)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetUpdateExtent_1")] public static extern 
bool GetUpdateExtent(IntPtr /*int** */ ret, IntPtr /*vtkAlgorithm* */ obj, int port);

//       Method: void vtkAlgorithm::GetUpdateExtent(int extent[6])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetUpdateExtent_4")] public static extern 
bool GetUpdateExtent(IntPtr /*vtkAlgorithm* */ obj, int[] /*6*/ extent);

//       Method: void vtkAlgorithm::GetUpdateExtent(int port, int extent[6])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetUpdateExtent_5")] public static extern 
bool GetUpdateExtent(IntPtr /*vtkAlgorithm* */ obj, int port, int[] /*6*/ extent);

//       Method: int vtkAlgorithm::GetUpdatePiece()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetUpdatePiece_0")] public static extern 
bool GetUpdatePiece(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: int vtkAlgorithm::GetUpdatePiece(int port)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetUpdatePiece_1")] public static extern 
bool GetUpdatePiece(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, int port);

//       Method: int vtkAlgorithm::GetUpdateNumberOfPieces()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetUpdateNumberOfPieces_0")] public static extern 
bool GetUpdateNumberOfPieces(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: int vtkAlgorithm::GetUpdateNumberOfPieces(int port)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetUpdateNumberOfPieces_1")] public static extern 
bool GetUpdateNumberOfPieces(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, int port);

//       Method: int vtkAlgorithm::GetUpdateGhostLevel()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetUpdateGhostLevel_0")] public static extern 
bool GetUpdateGhostLevel(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj);

//       Method: int vtkAlgorithm::GetUpdateGhostLevel(int port)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_GetUpdateGhostLevel_1")] public static extern 
bool GetUpdateGhostLevel(IntPtr /*int* */ ret, IntPtr /*vtkAlgorithm* */ obj, int port);

//       Method: void vtkAlgorithm::SetProgressObserver(vtkProgressObserver* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAlgorithm_SetProgressObserver_0")] public static extern 
bool SetProgressObserver(IntPtr /*vtkAlgorithm* */ obj, IntPtr/*vtkProgressObserver* */ ARG_0);

}
};
