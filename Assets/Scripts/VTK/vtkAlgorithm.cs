

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAlgorithm : vtkObject {
		public vtkAlgorithm(IntPtr p) : base(p) {}
		public static implicit operator  vtkAlgorithm(IntPtr p) {return new vtkAlgorithm(p);}
		public static implicit operator  IntPtr(vtkAlgorithm o) {return o.GetPtr();}

// static vtkAlgorithm* New()
// "static vtkAlgorithm *New()"
public static vtkAlgorithm New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAlgorithm.New_0(returnPointer.GetPtr());
	return (vtkAlgorithm)(IntPtr)returnPointer;
}


// int HasExecutive()
// "int HasExecutive()"
public int HasExecutive() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.HasExecutive_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetNumberOfInputPorts()
// "int GetNumberOfInputPorts()"
public int GetNumberOfInputPorts() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.GetNumberOfInputPorts_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetNumberOfOutputPorts()
// "int GetNumberOfOutputPorts()"
public int GetNumberOfOutputPorts() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.GetNumberOfOutputPorts_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void Register(vtkObjectBase * o)
// "void Register(vtkObjectBase* o)"
public void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkAlgorithm.Register_0(this, o);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase* o)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkAlgorithm.UnRegister_0(this, o);
}


// void UpdateProgress(double amount)
// "void UpdateProgress(double amount)"
public void UpdateProgress(double /*(double)*/ amount) {
	VTK_API.API_vtkAlgorithm.UpdateProgress_0(this, amount);
}


// void SetProgressText(const char * ptext)
// "void SetProgressText(const char* ptext)"
public void SetProgressText(string /*(char*)*/ ptext) {
	VTK_API.API_vtkAlgorithm.SetProgressText_0(this, ptext);
}


// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, const char * name)
// "virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, const char *name)"
public void SetInputArrayToProcess(int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, int /*(int)*/ fieldAssociation, string /*(char*)*/ name) {
	VTK_API.API_vtkAlgorithm.SetInputArrayToProcess_0(this, idx, port, connection, fieldAssociation, name);
}


// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
// "virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)"
public void SetInputArrayToProcess(int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, int /*(int)*/ fieldAssociation, int /*(int)*/ fieldAttributeType) {
	VTK_API.API_vtkAlgorithm.SetInputArrayToProcess_1(this, idx, port, connection, fieldAssociation, fieldAttributeType);
}


// virtual void SetInputArrayToProcess(int idx, int port, int connection, const char * fieldAssociation, const char * attributeTypeorName)
// "virtual void SetInputArrayToProcess(int idx, int port, int connection, const char* fieldAssociation, const char* attributeTypeorName)"
public void SetInputArrayToProcess(int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, string /*(char*)*/ fieldAssociation, string /*(char*)*/ attributeTypeorName) {
	VTK_API.API_vtkAlgorithm.SetInputArrayToProcess_2(this, idx, port, connection, fieldAssociation, attributeTypeorName);
}


// void RemoveAllInputs()
// "void RemoveAllInputs()"
public void RemoveAllInputs() {
	VTK_API.API_vtkAlgorithm.RemoveAllInputs_0(this);
}


// vtkDataObject* GetOutputDataObject(int port)
// "vtkDataObject* GetOutputDataObject(int port)"
public vtkDataObject GetOutputDataObject(int /*(int)*/ port) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAlgorithm.GetOutputDataObject_0(returnPointer.GetPtr(), this, port);
	return (vtkDataObject)(IntPtr)returnPointer;
}


// vtkDataObject* GetInputDataObject(int port, int connection)
// "vtkDataObject *GetInputDataObject(int port, int connection)"
public vtkDataObject GetInputDataObject(int /*(int)*/ port, int /*(int)*/ connection) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAlgorithm.GetInputDataObject_0(returnPointer.GetPtr(), this, port, connection);
	return (vtkDataObject)(IntPtr)returnPointer;
}


// virtual void SetInputConnection(int port, vtkAlgorithmOutput * input)
// "virtual void SetInputConnection(int port, vtkAlgorithmOutput* input)"
public void SetInputConnection(int /*(int)*/ port, vtkAlgorithmOutput /*(vtkAlgorithmOutput*)*/ input) {
	VTK_API.API_vtkAlgorithm.SetInputConnection_0(this, port, input);
}


// virtual void SetInputConnection(vtkAlgorithmOutput * input)
// "virtual void SetInputConnection(vtkAlgorithmOutput* input)"
public void SetInputConnection(vtkAlgorithmOutput /*(vtkAlgorithmOutput*)*/ input) {
	VTK_API.API_vtkAlgorithm.SetInputConnection_1(this, input);
}


// virtual void AddInputConnection(int port, vtkAlgorithmOutput * input)
// "virtual void AddInputConnection(int port, vtkAlgorithmOutput* input)"
public void AddInputConnection(int /*(int)*/ port, vtkAlgorithmOutput /*(vtkAlgorithmOutput*)*/ input) {
	VTK_API.API_vtkAlgorithm.AddInputConnection_0(this, port, input);
}


// virtual void AddInputConnection(vtkAlgorithmOutput * input)
// "virtual void AddInputConnection(vtkAlgorithmOutput* input)"
public void AddInputConnection(vtkAlgorithmOutput /*(vtkAlgorithmOutput*)*/ input) {
	VTK_API.API_vtkAlgorithm.AddInputConnection_1(this, input);
}


// virtual void RemoveInputConnection(int port, vtkAlgorithmOutput * input)
// "virtual void RemoveInputConnection(int port, vtkAlgorithmOutput* input)"
public void RemoveInputConnection(int /*(int)*/ port, vtkAlgorithmOutput /*(vtkAlgorithmOutput*)*/ input) {
	VTK_API.API_vtkAlgorithm.RemoveInputConnection_0(this, port, input);
}


// virtual void RemoveInputConnection(int port, int idx)
// "virtual void RemoveInputConnection(int port, int idx)"
public void RemoveInputConnection(int /*(int)*/ port, int /*(int)*/ idx) {
	VTK_API.API_vtkAlgorithm.RemoveInputConnection_1(this, port, idx);
}


// virtual void RemoveAllInputConnections(int port)
// "virtual void RemoveAllInputConnections(int port)"
public void RemoveAllInputConnections(int /*(int)*/ port) {
	VTK_API.API_vtkAlgorithm.RemoveAllInputConnections_0(this, port);
}


// virtual void SetInputDataObject(int port, vtkDataObject * data)
// "virtual void SetInputDataObject(int port, vtkDataObject* data)"
public void SetInputDataObject(int /*(int)*/ port, vtkDataObject /*(vtkDataObject*)*/ data) {
	VTK_API.API_vtkAlgorithm.SetInputDataObject_0(this, port, data);
}


// virtual void SetInputDataObject(vtkDataObject * data)
// "virtual void SetInputDataObject(vtkDataObject* data)"
public void SetInputDataObject(vtkDataObject /*(vtkDataObject*)*/ data) {
	VTK_API.API_vtkAlgorithm.SetInputDataObject_1(this, data);
}


// virtual void AddInputDataObject(int port, vtkDataObject * data)
// "virtual void AddInputDataObject(int port, vtkDataObject* data)"
public void AddInputDataObject(int /*(int)*/ port, vtkDataObject /*(vtkDataObject*)*/ data) {
	VTK_API.API_vtkAlgorithm.AddInputDataObject_0(this, port, data);
}


// virtual void AddInputDataObject(vtkDataObject * data)
// "virtual void AddInputDataObject(vtkDataObject* data)"
public void AddInputDataObject(vtkDataObject /*(vtkDataObject*)*/ data) {
	VTK_API.API_vtkAlgorithm.AddInputDataObject_1(this, data);
}


// vtkAlgorithmOutput* GetOutputPort(int index)
// "vtkAlgorithmOutput* GetOutputPort(int index)"
public vtkAlgorithmOutput GetOutputPort(int /*(int)*/ index) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAlgorithm.GetOutputPort_0(returnPointer.GetPtr(), this, index);
	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
}


// vtkAlgorithmOutput* GetOutputPort()
// "vtkAlgorithmOutput* GetOutputPort()"
public vtkAlgorithmOutput GetOutputPort() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAlgorithm.GetOutputPort_1(returnPointer.GetPtr(), this);
	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
}


// int GetNumberOfInputConnections(int port)
// "int GetNumberOfInputConnections(int port)"
public int GetNumberOfInputConnections(int /*(int)*/ port) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.GetNumberOfInputConnections_0(returnPointer.GetPtr(), this, port);
	return (int)returnPointer;
}


// int GetTotalNumberOfInputConnections()
// "int GetTotalNumberOfInputConnections()"
public int GetTotalNumberOfInputConnections() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.GetTotalNumberOfInputConnections_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkAlgorithmOutput* GetInputConnection(int port, int index)
// "vtkAlgorithmOutput* GetInputConnection(int port, int index)"
public vtkAlgorithmOutput GetInputConnection(int /*(int)*/ port, int /*(int)*/ index) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAlgorithm.GetInputConnection_0(returnPointer.GetPtr(), this, port, index);
	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
}


// vtkAlgorithm* GetInputAlgorithm(int port, int index, int & algPort)
// "vtkAlgorithm* GetInputAlgorithm(int port, int index, int& algPort)"
public vtkAlgorithm GetInputAlgorithm(int /*(int)*/ port, int /*(int)*/ index, IntPtr /*(int&)*/ algPort) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAlgorithm.GetInputAlgorithm_0(returnPointer.GetPtr(), this, port, index, algPort);
	return (vtkAlgorithm)(IntPtr)returnPointer;
}


// vtkAlgorithm* GetInputAlgorithm(int port, int index)
// "vtkAlgorithm* GetInputAlgorithm(int port, int index)"
public vtkAlgorithm GetInputAlgorithm(int /*(int)*/ port, int /*(int)*/ index) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAlgorithm.GetInputAlgorithm_1(returnPointer.GetPtr(), this, port, index);
	return (vtkAlgorithm)(IntPtr)returnPointer;
}


// vtkAlgorithm* GetInputAlgorithm()
// "vtkAlgorithm* GetInputAlgorithm()"
public vtkAlgorithm GetInputAlgorithm() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAlgorithm.GetInputAlgorithm_2(returnPointer.GetPtr(), this);
	return (vtkAlgorithm)(IntPtr)returnPointer;
}


// virtual void Update(int port)
// "virtual void Update(int port)"
public void Update(int /*(int)*/ port) {
	VTK_API.API_vtkAlgorithm.Update_0(this, port);
}


// virtual void Update()
// "virtual void Update()"
public void Update() {
	VTK_API.API_vtkAlgorithm.Update_1(this);
}


// virtual int UpdatePiece(int piece, int numPieces, int ghostLevels, const int extents[6] = nullptr)
// "virtual int UpdatePiece( int piece, int numPieces, int ghostLevels, const int extents[6]=nullptr)"
public int UpdatePiece(int /*(int)*/ piece, int /*(int)*/ numPieces, int /*(int)*/ ghostLevels, int /*(int[6])*/ []extents) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.UpdatePiece_0(returnPointer.GetPtr(), this, piece, numPieces, ghostLevels, extents);
	return (int)returnPointer;
}


// virtual int UpdateExtent(const int extents[6])
// "virtual int UpdateExtent(const int extents[6])"
public int UpdateExtent(int /*(int[6])*/ []extents) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.UpdateExtent_0(returnPointer.GetPtr(), this, extents);
	return (int)returnPointer;
}


// virtual void UpdateInformation()
// "virtual void UpdateInformation()"
public void UpdateInformation() {
	VTK_API.API_vtkAlgorithm.UpdateInformation_0(this);
}


// virtual void UpdateDataObject()
// "virtual void UpdateDataObject()"
public void UpdateDataObject() {
	VTK_API.API_vtkAlgorithm.UpdateDataObject_0(this);
}


// virtual void PropagateUpdateExtent()
// "virtual void PropagateUpdateExtent()"
public void PropagateUpdateExtent() {
	VTK_API.API_vtkAlgorithm.PropagateUpdateExtent_0(this);
}


// virtual void UpdateWholeExtent()
// "virtual void UpdateWholeExtent()"
public void UpdateWholeExtent() {
	VTK_API.API_vtkAlgorithm.UpdateWholeExtent_0(this);
}


// void ConvertTotalInputToPortConnection(int ind, int & port, int & conn)
// "void ConvertTotalInputToPortConnection(int ind, int& port, int& conn)"
public void ConvertTotalInputToPortConnection(int /*(int)*/ ind, IntPtr /*(int&)*/ port, IntPtr /*(int&)*/ conn) {
	VTK_API.API_vtkAlgorithm.ConvertTotalInputToPortConnection_0(this, ind, port, conn);
}


// virtual void SetReleaseDataFlag(int ARG_0)
// "virtual void SetReleaseDataFlag(int)"
public void SetReleaseDataFlag(int /*(int)*/ ARG_0) {
	VTK_API.API_vtkAlgorithm.SetReleaseDataFlag_0(this, ARG_0);
}


// virtual int GetReleaseDataFlag()
// "virtual int GetReleaseDataFlag()"
public int GetReleaseDataFlag() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.GetReleaseDataFlag_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void ReleaseDataFlagOn()
// "void ReleaseDataFlagOn()"
public void ReleaseDataFlagOn() {
	VTK_API.API_vtkAlgorithm.ReleaseDataFlagOn_0(this);
}


// void ReleaseDataFlagOff()
// "void ReleaseDataFlagOff()"
public void ReleaseDataFlagOff() {
	VTK_API.API_vtkAlgorithm.ReleaseDataFlagOff_0(this);
}


// int* GetUpdateExtent()
// "int* GetUpdateExtent()"
public IntPtr GetUpdateExtent() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAlgorithm.GetUpdateExtent_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// int* GetUpdateExtent(int port)
// "int* GetUpdateExtent(int port)"
public IntPtr GetUpdateExtent(int /*(int)*/ port) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAlgorithm.GetUpdateExtent_1(returnPointer.GetPtr(), this, port);
	return (IntPtr)returnPointer;
}


// void GetUpdateExtent(int & x0, int & x1, int & y0, int & y1, int & z0, int & z1)
// "void GetUpdateExtent(int& x0, int& x1, int& y0, int& y1, int& z0, int& z1)"
public void GetUpdateExtent(IntPtr /*(int&)*/ x0, IntPtr /*(int&)*/ x1, IntPtr /*(int&)*/ y0, IntPtr /*(int&)*/ y1, IntPtr /*(int&)*/ z0, IntPtr /*(int&)*/ z1) {
	VTK_API.API_vtkAlgorithm.GetUpdateExtent_2(this, x0, x1, y0, y1, z0, z1);
}


// void GetUpdateExtent(int port, int & x0, int & x1, int & y0, int & y1, int & z0, int & z1)
// "void GetUpdateExtent(int port, int& x0, int& x1, int& y0, int& y1, int& z0, int& z1)"
public void GetUpdateExtent(int /*(int)*/ port, IntPtr /*(int&)*/ x0, IntPtr /*(int&)*/ x1, IntPtr /*(int&)*/ y0, IntPtr /*(int&)*/ y1, IntPtr /*(int&)*/ z0, IntPtr /*(int&)*/ z1) {
	VTK_API.API_vtkAlgorithm.GetUpdateExtent_3(this, port, x0, x1, y0, y1, z0, z1);
}


// void GetUpdateExtent(int extent[6])
// "void GetUpdateExtent(int extent[6])"
public void GetUpdateExtent(int /*(int[6])*/ []extent) {
	VTK_API.API_vtkAlgorithm.GetUpdateExtent_4(this, extent);
}


// void GetUpdateExtent(int port, int extent[6])
// "void GetUpdateExtent(int port, int extent[6])"
public void GetUpdateExtent(int /*(int)*/ port, int /*(int[6])*/ []extent) {
	VTK_API.API_vtkAlgorithm.GetUpdateExtent_5(this, port, extent);
}


// int GetUpdatePiece()
// "int GetUpdatePiece()"
public int GetUpdatePiece() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.GetUpdatePiece_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetUpdatePiece(int port)
// "int GetUpdatePiece(int port)"
public int GetUpdatePiece(int /*(int)*/ port) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.GetUpdatePiece_1(returnPointer.GetPtr(), this, port);
	return (int)returnPointer;
}


// int GetUpdateNumberOfPieces()
// "int GetUpdateNumberOfPieces()"
public int GetUpdateNumberOfPieces() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.GetUpdateNumberOfPieces_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetUpdateNumberOfPieces(int port)
// "int GetUpdateNumberOfPieces(int port)"
public int GetUpdateNumberOfPieces(int /*(int)*/ port) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.GetUpdateNumberOfPieces_1(returnPointer.GetPtr(), this, port);
	return (int)returnPointer;
}


// int GetUpdateGhostLevel()
// "int GetUpdateGhostLevel()"
public int GetUpdateGhostLevel() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.GetUpdateGhostLevel_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetUpdateGhostLevel(int port)
// "int GetUpdateGhostLevel(int port)"
public int GetUpdateGhostLevel(int /*(int)*/ port) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAlgorithm.GetUpdateGhostLevel_1(returnPointer.GetPtr(), this, port);
	return (int)returnPointer;
}


// void SetProgressObserver(vtkProgressObserver * ARG_0)
// "void SetProgressObserver(vtkProgressObserver*)"
public void SetProgressObserver(vtkProgressObserver /*(vtkProgressObserver*)*/ ARG_0) {
	VTK_API.API_vtkAlgorithm.SetProgressObserver_0(this, ARG_0);
}


}
};
