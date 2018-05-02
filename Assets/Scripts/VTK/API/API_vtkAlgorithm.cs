
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

// int HasExecutive()
// int HasExecutive()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_HasExecutive_0")] public static extern 
bool HasExecutive_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject);

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

// void UpdateProgress(double amount)
// void UpdateProgress(double amount)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdateProgress_0")] public static extern 
bool UpdateProgress_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, double /*(double)*/ amount);

// void SetProgressText(const char * ptext)
// void SetProgressText(const char* ptext)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetProgressText_0")] public static extern 
bool SetProgressText_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, string /*(char*)*/ ptext);

// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, const char * name)
// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, const char *name)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputArrayToProcess_0")] public static extern 
bool SetInputArrayToProcess_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, int /*(int)*/ fieldAssociation, string /*(char*)*/ name);

// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputArrayToProcess_1")] public static extern 
bool SetInputArrayToProcess_1(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, int /*(int)*/ fieldAssociation, int /*(int)*/ fieldAttributeType);

// virtual void SetInputArrayToProcess(int idx, int port, int connection, const char * fieldAssociation, const char * attributeTypeorName)
// virtual void SetInputArrayToProcess(int idx, int port, int connection, const char* fieldAssociation, const char* attributeTypeorName)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_SetInputArrayToProcess_2")] public static extern 
bool SetInputArrayToProcess_2(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, string /*(char*)*/ fieldAssociation, string /*(char*)*/ attributeTypeorName);

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

// virtual void Update(int port)
// virtual void Update(int port)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_Update_0")] public static extern 
bool Update_0(IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ port);

// virtual void Update()
// virtual void Update()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_Update_1")] public static extern 
bool Update_1(IntPtr /*(vtkAlgorithm*)*/ callingObject);

// virtual int UpdatePiece(int piece, int numPieces, int ghostLevels, const int extents[6] = nullptr)
// virtual int UpdatePiece( int piece, int numPieces, int ghostLevels, const int extents[6]=nullptr)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithm_UpdatePiece_0")] public static extern 
bool UpdatePiece_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithm*)*/ callingObject, int /*(int)*/ piece, int /*(int)*/ numPieces, int /*(int)*/ ghostLevels, int /*(int[6])*/ []extents);

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

}
};
