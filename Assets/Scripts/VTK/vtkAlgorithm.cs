

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAlgorithm : vtkObject {

// static vtkAlgorithm* New()
// "static vtkAlgorithm *New()"
public new static vtkAlgorithm New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkAlgorithm.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// int HasExecutive()
// "int HasExecutive()"
public new int HasExecutive() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.HasExecutive_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetNumberOfInputPorts()
// "int GetNumberOfInputPorts()"
public new int GetNumberOfInputPorts() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.GetNumberOfInputPorts_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetNumberOfOutputPorts()
// "int GetNumberOfOutputPorts()"
public new int GetNumberOfOutputPorts() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.GetNumberOfOutputPorts_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void Register(vtkObjectBase * o)
// "void Register(vtkObjectBase* o)"
public new void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	API_vtkAlgorithm.Register_0(this, o);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase* o)"
public new void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	API_vtkAlgorithm.UnRegister_0(this, o);
}


// void UpdateProgress(double amount)
// "void UpdateProgress(double amount)"
public new void UpdateProgress(double /*(double)*/ amount) {
	API_vtkAlgorithm.UpdateProgress_0(this, amount);
}


// void SetProgressText(const char * ptext)
// "void SetProgressText(const char* ptext)"
public new void SetProgressText(char /*(char*)*/ []ptext) {
	API_vtkAlgorithm.SetProgressText_0(this, ptext);
}


// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, const char * name)
// "virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, const char *name)"
public new void SetInputArrayToProcess(int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, int /*(int)*/ fieldAssociation, char /*(char*)*/ []name) {
	API_vtkAlgorithm.SetInputArrayToProcess_0(this, idx, port, connection, fieldAssociation, name);
}


// virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
// "virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)"
public new void SetInputArrayToProcess(int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, int /*(int)*/ fieldAssociation, int /*(int)*/ fieldAttributeType) {
	API_vtkAlgorithm.SetInputArrayToProcess_1(this, idx, port, connection, fieldAssociation, fieldAttributeType);
}


// virtual void SetInputArrayToProcess(int idx, int port, int connection, const char * fieldAssociation, const char * attributeTypeorName)
// "virtual void SetInputArrayToProcess(int idx, int port, int connection, const char* fieldAssociation, const char* attributeTypeorName)"
public new void SetInputArrayToProcess(int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, char /*(char*)*/ []fieldAssociation, char /*(char*)*/ []attributeTypeorName) {
	API_vtkAlgorithm.SetInputArrayToProcess_2(this, idx, port, connection, fieldAssociation, attributeTypeorName);
}


// void RemoveAllInputs()
// "void RemoveAllInputs()"
public new void RemoveAllInputs() {
	API_vtkAlgorithm.RemoveAllInputs_0(this);
}


// vtkDataObject* GetOutputDataObject(int port)
// "vtkDataObject* GetOutputDataObject(int port)"
public new vtkDataObject GetOutputDataObject(int /*(int)*/ port) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkAlgorithm.GetOutputDataObject_0(this, returnPointer, port);
	return Ptr.deref(returnPointer);
}


// vtkDataObject* GetInputDataObject(int port, int connection)
// "vtkDataObject *GetInputDataObject(int port, int connection)"
public new vtkDataObject GetInputDataObject(int /*(int)*/ port, int /*(int)*/ connection) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkAlgorithm.GetInputDataObject_0(this, returnPointer, port, connection);
	return Ptr.deref(returnPointer);
}


// virtual void SetInputConnection(int port, vtkAlgorithmOutput * input)
// "virtual void SetInputConnection(int port, vtkAlgorithmOutput* input)"
public new void SetInputConnection(int /*(int)*/ port, vtkAlgorithmOutput /*(vtkAlgorithmOutput*)*/ input) {
	API_vtkAlgorithm.SetInputConnection_0(this, port, input);
}


// virtual void SetInputConnection(vtkAlgorithmOutput * input)
// "virtual void SetInputConnection(vtkAlgorithmOutput* input)"
public new void SetInputConnection(vtkAlgorithmOutput /*(vtkAlgorithmOutput*)*/ input) {
	API_vtkAlgorithm.SetInputConnection_1(this, input);
}


// virtual void AddInputConnection(int port, vtkAlgorithmOutput * input)
// "virtual void AddInputConnection(int port, vtkAlgorithmOutput* input)"
public new void AddInputConnection(int /*(int)*/ port, vtkAlgorithmOutput /*(vtkAlgorithmOutput*)*/ input) {
	API_vtkAlgorithm.AddInputConnection_0(this, port, input);
}


// virtual void AddInputConnection(vtkAlgorithmOutput * input)
// "virtual void AddInputConnection(vtkAlgorithmOutput* input)"
public new void AddInputConnection(vtkAlgorithmOutput /*(vtkAlgorithmOutput*)*/ input) {
	API_vtkAlgorithm.AddInputConnection_1(this, input);
}


// virtual void RemoveInputConnection(int port, vtkAlgorithmOutput * input)
// "virtual void RemoveInputConnection(int port, vtkAlgorithmOutput* input)"
public new void RemoveInputConnection(int /*(int)*/ port, vtkAlgorithmOutput /*(vtkAlgorithmOutput*)*/ input) {
	API_vtkAlgorithm.RemoveInputConnection_0(this, port, input);
}


// virtual void RemoveInputConnection(int port, int idx)
// "virtual void RemoveInputConnection(int port, int idx)"
public new void RemoveInputConnection(int /*(int)*/ port, int /*(int)*/ idx) {
	API_vtkAlgorithm.RemoveInputConnection_1(this, port, idx);
}


// virtual void RemoveAllInputConnections(int port)
// "virtual void RemoveAllInputConnections(int port)"
public new void RemoveAllInputConnections(int /*(int)*/ port) {
	API_vtkAlgorithm.RemoveAllInputConnections_0(this, port);
}


// virtual void SetInputDataObject(int port, vtkDataObject * data)
// "virtual void SetInputDataObject(int port, vtkDataObject* data)"
public new void SetInputDataObject(int /*(int)*/ port, vtkDataObject /*(vtkDataObject*)*/ data) {
	API_vtkAlgorithm.SetInputDataObject_0(this, port, data);
}


// virtual void SetInputDataObject(vtkDataObject * data)
// "virtual void SetInputDataObject(vtkDataObject* data)"
public new void SetInputDataObject(vtkDataObject /*(vtkDataObject*)*/ data) {
	API_vtkAlgorithm.SetInputDataObject_1(this, data);
}


// virtual void AddInputDataObject(int port, vtkDataObject * data)
// "virtual void AddInputDataObject(int port, vtkDataObject* data)"
public new void AddInputDataObject(int /*(int)*/ port, vtkDataObject /*(vtkDataObject*)*/ data) {
	API_vtkAlgorithm.AddInputDataObject_0(this, port, data);
}


// virtual void AddInputDataObject(vtkDataObject * data)
// "virtual void AddInputDataObject(vtkDataObject* data)"
public new void AddInputDataObject(vtkDataObject /*(vtkDataObject*)*/ data) {
	API_vtkAlgorithm.AddInputDataObject_1(this, data);
}


// vtkAlgorithmOutput* GetOutputPort(int index)
// "vtkAlgorithmOutput* GetOutputPort(int index)"
public new vtkAlgorithmOutput GetOutputPort(int /*(int)*/ index) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkAlgorithm.GetOutputPort_0(this, returnPointer, index);
	return Ptr.deref(returnPointer);
}


// vtkAlgorithmOutput* GetOutputPort()
// "vtkAlgorithmOutput* GetOutputPort()"
public new vtkAlgorithmOutput GetOutputPort() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkAlgorithm.GetOutputPort_1(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetNumberOfInputConnections(int port)
// "int GetNumberOfInputConnections(int port)"
public new int GetNumberOfInputConnections(int /*(int)*/ port) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.GetNumberOfInputConnections_0(this, returnPointer, port);
	return Ptr.deref(returnPointer);
}


// int GetTotalNumberOfInputConnections()
// "int GetTotalNumberOfInputConnections()"
public new int GetTotalNumberOfInputConnections() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.GetTotalNumberOfInputConnections_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkAlgorithmOutput* GetInputConnection(int port, int index)
// "vtkAlgorithmOutput* GetInputConnection(int port, int index)"
public new vtkAlgorithmOutput GetInputConnection(int /*(int)*/ port, int /*(int)*/ index) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkAlgorithm.GetInputConnection_0(this, returnPointer, port, index);
	return Ptr.deref(returnPointer);
}


// vtkAlgorithm* GetInputAlgorithm(int port, int index, int & algPort)
// "vtkAlgorithm* GetInputAlgorithm(int port, int index, int& algPort)"
public new vtkAlgorithm GetInputAlgorithm(int /*(int)*/ port, int /*(int)*/ index, int /*(int&)*/ []algPort) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkAlgorithm.GetInputAlgorithm_0(this, returnPointer, port, index, *algPort);
	return Ptr.deref(returnPointer);
}


// vtkAlgorithm* GetInputAlgorithm(int port, int index)
// "vtkAlgorithm* GetInputAlgorithm(int port, int index)"
public new vtkAlgorithm GetInputAlgorithm(int /*(int)*/ port, int /*(int)*/ index) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkAlgorithm.GetInputAlgorithm_1(this, returnPointer, port, index);
	return Ptr.deref(returnPointer);
}


// vtkAlgorithm* GetInputAlgorithm()
// "vtkAlgorithm* GetInputAlgorithm()"
public new vtkAlgorithm GetInputAlgorithm() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkAlgorithm.GetInputAlgorithm_2(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void Update(int port)
// "virtual void Update(int port)"
public new void Update(int /*(int)*/ port) {
	API_vtkAlgorithm.Update_0(this, port);
}


// virtual void Update()
// "virtual void Update()"
public new void Update() {
	API_vtkAlgorithm.Update_1(this);
}


// virtual int UpdatePiece(int piece, int numPieces, int ghostLevels, const int extents[6] = nullptr)
// "virtual int UpdatePiece( int piece, int numPieces, int ghostLevels, const int extents[6]=nullptr)"
public new int UpdatePiece(int /*(int)*/ piece, int /*(int)*/ numPieces, int /*(int)*/ ghostLevels, int /*(int[6])*/ []extents) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.UpdatePiece_0(this, returnPointer, piece, numPieces, ghostLevels, extents);
	return Ptr.deref(returnPointer);
}


// virtual int UpdateExtent(const int extents[6])
// "virtual int UpdateExtent(const int extents[6])"
public new int UpdateExtent(int /*(int[6])*/ []extents) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.UpdateExtent_0(this, returnPointer, extents);
	return Ptr.deref(returnPointer);
}


// virtual void UpdateInformation()
// "virtual void UpdateInformation()"
public new void UpdateInformation() {
	API_vtkAlgorithm.UpdateInformation_0(this);
}


// virtual void UpdateDataObject()
// "virtual void UpdateDataObject()"
public new void UpdateDataObject() {
	API_vtkAlgorithm.UpdateDataObject_0(this);
}


// virtual void PropagateUpdateExtent()
// "virtual void PropagateUpdateExtent()"
public new void PropagateUpdateExtent() {
	API_vtkAlgorithm.PropagateUpdateExtent_0(this);
}


// virtual void UpdateWholeExtent()
// "virtual void UpdateWholeExtent()"
public new void UpdateWholeExtent() {
	API_vtkAlgorithm.UpdateWholeExtent_0(this);
}


// void ConvertTotalInputToPortConnection(int ind, int & port, int & conn)
// "void ConvertTotalInputToPortConnection(int ind, int& port, int& conn)"
public new void ConvertTotalInputToPortConnection(int /*(int)*/ ind, int /*(int&)*/ []port, int /*(int&)*/ []conn) {
	API_vtkAlgorithm.ConvertTotalInputToPortConnection_0(this, ind, *port, *conn);
}


// virtual void SetReleaseDataFlag(int ARG_0)
// "virtual void SetReleaseDataFlag(int)"
public new void SetReleaseDataFlag(int /*(int)*/ ARG_0) {
	API_vtkAlgorithm.SetReleaseDataFlag_0(this, ARG_0);
}


// virtual int GetReleaseDataFlag()
// "virtual int GetReleaseDataFlag()"
public new int GetReleaseDataFlag() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.GetReleaseDataFlag_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void ReleaseDataFlagOn()
// "void ReleaseDataFlagOn()"
public new void ReleaseDataFlagOn() {
	API_vtkAlgorithm.ReleaseDataFlagOn_0(this);
}


// void ReleaseDataFlagOff()
// "void ReleaseDataFlagOff()"
public new void ReleaseDataFlagOff() {
	API_vtkAlgorithm.ReleaseDataFlagOff_0(this);
}


// int* GetUpdateExtent()
// "int* GetUpdateExtent()"
public new int GetUpdateExtent() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.GetUpdateExtent_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int* GetUpdateExtent(int port)
// "int* GetUpdateExtent(int port)"
public new int GetUpdateExtent(int /*(int)*/ port) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.GetUpdateExtent_1(this, returnPointer, port);
	return Ptr.deref(returnPointer);
}


// void GetUpdateExtent(int & x0, int & x1, int & y0, int & y1, int & z0, int & z1)
// "void GetUpdateExtent(int& x0, int& x1, int& y0, int& y1, int& z0, int& z1)"
public new void GetUpdateExtent(int /*(int&)*/ []x0, int /*(int&)*/ []x1, int /*(int&)*/ []y0, int /*(int&)*/ []y1, int /*(int&)*/ []z0, int /*(int&)*/ []z1) {
	API_vtkAlgorithm.GetUpdateExtent_2(this, *x0, *x1, *y0, *y1, *z0, *z1);
}


// void GetUpdateExtent(int port, int & x0, int & x1, int & y0, int & y1, int & z0, int & z1)
// "void GetUpdateExtent(int port, int& x0, int& x1, int& y0, int& y1, int& z0, int& z1)"
public new void GetUpdateExtent(int /*(int)*/ port, int /*(int&)*/ []x0, int /*(int&)*/ []x1, int /*(int&)*/ []y0, int /*(int&)*/ []y1, int /*(int&)*/ []z0, int /*(int&)*/ []z1) {
	API_vtkAlgorithm.GetUpdateExtent_3(this, port, *x0, *x1, *y0, *y1, *z0, *z1);
}


// void GetUpdateExtent(int extent[6])
// "void GetUpdateExtent(int extent[6])"
public new void GetUpdateExtent(int /*(int[6])*/ []extent) {
	API_vtkAlgorithm.GetUpdateExtent_4(this, extent);
}


// void GetUpdateExtent(int port, int extent[6])
// "void GetUpdateExtent(int port, int extent[6])"
public new void GetUpdateExtent(int /*(int)*/ port, int /*(int[6])*/ []extent) {
	API_vtkAlgorithm.GetUpdateExtent_5(this, port, extent);
}


// int GetUpdatePiece()
// "int GetUpdatePiece()"
public new int GetUpdatePiece() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.GetUpdatePiece_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetUpdatePiece(int port)
// "int GetUpdatePiece(int port)"
public new int GetUpdatePiece(int /*(int)*/ port) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.GetUpdatePiece_1(this, returnPointer, port);
	return Ptr.deref(returnPointer);
}


// int GetUpdateNumberOfPieces()
// "int GetUpdateNumberOfPieces()"
public new int GetUpdateNumberOfPieces() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.GetUpdateNumberOfPieces_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetUpdateNumberOfPieces(int port)
// "int GetUpdateNumberOfPieces(int port)"
public new int GetUpdateNumberOfPieces(int /*(int)*/ port) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.GetUpdateNumberOfPieces_1(this, returnPointer, port);
	return Ptr.deref(returnPointer);
}


// int GetUpdateGhostLevel()
// "int GetUpdateGhostLevel()"
public new int GetUpdateGhostLevel() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.GetUpdateGhostLevel_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetUpdateGhostLevel(int port)
// "int GetUpdateGhostLevel(int port)"
public new int GetUpdateGhostLevel(int /*(int)*/ port) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithm.GetUpdateGhostLevel_1(this, returnPointer, port);
	return Ptr.deref(returnPointer);
}


// void SetProgressObserver(vtkProgressObserver * ARG_0)
// "void SetProgressObserver(vtkProgressObserver*)"
public new void SetProgressObserver(vtkProgressObserver /*(vtkProgressObserver*)*/ ARG_0) {
	API_vtkAlgorithm.SetProgressObserver_0(this, ARG_0);
}


}
};
