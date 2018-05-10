

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
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.New_0(returnPointer.GetPtr());
	return (vtkAlgorithm)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAlgorithm.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAlgorithm.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkAlgorithm* SafeDownCast(vtkObjectBase * o)
// "static vtkAlgorithm* SafeDownCast(vtkObjectBase *o)"
public static vtkAlgorithm SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkAlgorithm)(IntPtr)returnPointer;
}


// vtkAlgorithm* NewInstance()
// "vtkAlgorithm *NewInstance()"
public vtkAlgorithm NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkAlgorithm)(IntPtr)returnPointer;
}


// int HasExecutive()
// "int HasExecutive()"
public int HasExecutive() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.HasExecutive_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int ProcessRequest(vtkInformation * request, vtkInformationVector ** inInfo, vtkInformationVector * outInfo)
// "virtual int ProcessRequest(vtkInformation* request, vtkInformationVector** inInfo, vtkInformationVector* outInfo)"
public int ProcessRequest(vtkInformation /*(vtkInformation*)*/ request, vtkInformationVector /*(vtkInformationVector**)*/ inInfo, vtkInformationVector /*(vtkInformationVector*)*/ outInfo) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.ProcessRequest_0(returnPointer.GetPtr(), this, request, inInfo, outInfo);
	return (int)returnPointer;
}


// int ProcessRequest(vtkInformation * request, vtkCollection * inInfo, vtkInformationVector * outInfo)
// "int ProcessRequest(vtkInformation* request, vtkCollection* inInfo, vtkInformationVector* outInfo)"
public int ProcessRequest(vtkInformation /*(vtkInformation*)*/ request, vtkCollection /*(vtkCollection*)*/ inInfo, vtkInformationVector /*(vtkInformationVector*)*/ outInfo) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.ProcessRequest_1(returnPointer.GetPtr(), this, request, inInfo, outInfo);
	return (int)returnPointer;
}


// virtual int ComputePipelineMTime(vtkInformation * request, vtkInformationVector ** inInfoVec, vtkInformationVector * outInfoVec, int requestFromOutputPort, vtkMTimeType * mtime)
// "virtual int ComputePipelineMTime(vtkInformation* request, vtkInformationVector** inInfoVec, vtkInformationVector* outInfoVec, int requestFromOutputPort, vtkMTimeType* mtime)"
public int ComputePipelineMTime(vtkInformation /*(vtkInformation*)*/ request, vtkInformationVector /*(vtkInformationVector**)*/ inInfoVec, vtkInformationVector /*(vtkInformationVector*)*/ outInfoVec, int /*(int)*/ requestFromOutputPort, IntPtr /*(vtkMTimeType*)*/ mtime) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.ComputePipelineMTime_0(returnPointer.GetPtr(), this, request, inInfoVec, outInfoVec, requestFromOutputPort, mtime);
	return (int)returnPointer;
}


// virtual int ModifyRequest(vtkInformation * request, int when)
// "virtual int ModifyRequest(vtkInformation* request, int when)"
public int ModifyRequest(vtkInformation /*(vtkInformation*)*/ request, int /*(int)*/ when) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.ModifyRequest_0(returnPointer.GetPtr(), this, request, when);
	return (int)returnPointer;
}


// vtkInformation* GetInputPortInformation(int port)
// "vtkInformation* GetInputPortInformation(int port)"
public vtkInformation GetInputPortInformation(int /*(int)*/ port) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetInputPortInformation_0(returnPointer.GetPtr(), this, port);
	return (vtkInformation)(IntPtr)returnPointer;
}


// vtkInformation* GetOutputPortInformation(int port)
// "vtkInformation* GetOutputPortInformation(int port)"
public vtkInformation GetOutputPortInformation(int /*(int)*/ port) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetOutputPortInformation_0(returnPointer.GetPtr(), this, port);
	return (vtkInformation)(IntPtr)returnPointer;
}


// virtual vtkInformation* GetInformation()
// "virtual vtkInformation *GetInformation ()"
public vtkInformation GetInformation() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetInformation_0(returnPointer.GetPtr(), this);
	return (vtkInformation)(IntPtr)returnPointer;
}


// virtual void SetInformation(vtkInformation * ARG_0)
// "virtual void SetInformation(vtkInformation*)"
public void SetInformation(vtkInformation /*(vtkInformation*)*/ ARG_0) {
	VTK_API.API_vtkAlgorithm.SetInformation_0(this, ARG_0);
}


// int GetNumberOfInputPorts()
// "int GetNumberOfInputPorts()"
public int GetNumberOfInputPorts() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.GetNumberOfInputPorts_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetNumberOfOutputPorts()
// "int GetNumberOfOutputPorts()"
public int GetNumberOfOutputPorts() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
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


// virtual void SetAbortExecute(int _arg)
// "virtual void SetAbortExecute (int _arg)"
public void SetAbortExecute(int /*(int)*/ _arg) {
	VTK_API.API_vtkAlgorithm.SetAbortExecute_0(this, _arg);
}


// virtual int GetAbortExecute()
// "virtual int GetAbortExecute ()"
public int GetAbortExecute() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.GetAbortExecute_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void AbortExecuteOn()
// "virtual void AbortExecuteOn ()"
public void AbortExecuteOn() {
	VTK_API.API_vtkAlgorithm.AbortExecuteOn_0(this);
}


// virtual void AbortExecuteOff()
// "virtual void AbortExecuteOff ()"
public void AbortExecuteOff() {
	VTK_API.API_vtkAlgorithm.AbortExecuteOff_0(this);
}


// virtual void SetProgress(double _arg)
// "virtual void SetProgress (double _arg)"
public void SetProgress(double /*(double)*/ _arg) {
	VTK_API.API_vtkAlgorithm.SetProgress_0(this, _arg);
}


// virtual double GetProgressMinValue()
// "virtual double GetProgressMinValue ()"
public double GetProgressMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkAlgorithm.GetProgressMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetProgressMaxValue()
// "virtual double GetProgressMaxValue ()"
public double GetProgressMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkAlgorithm.GetProgressMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetProgress()
// "virtual double GetProgress ()"
public double GetProgress() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkAlgorithm.GetProgress_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
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


// virtual char* GetProgressText()
// "virtual char* GetProgressText ()"
public string GetProgressText() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetProgressText_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual long GetErrorCode()
// "virtual unsigned long GetErrorCode ()"
public ulong GetErrorCode() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkAlgorithm.GetErrorCode_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// static vtkInformationIntegerKey* INPUT_IS_OPTIONAL()
// "static vtkInformationIntegerKey* INPUT_IS_OPTIONAL()"
public static vtkInformationIntegerKey INPUT_IS_OPTIONAL() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.INPUT_IS_OPTIONAL_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* INPUT_IS_REPEATABLE()
// "static vtkInformationIntegerKey* INPUT_IS_REPEATABLE()"
public static vtkInformationIntegerKey INPUT_IS_REPEATABLE() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.INPUT_IS_REPEATABLE_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationInformationVectorKey* INPUT_REQUIRED_FIELDS()
// "static vtkInformationInformationVectorKey* INPUT_REQUIRED_FIELDS()"
public static vtkInformationInformationVectorKey INPUT_REQUIRED_FIELDS() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.INPUT_REQUIRED_FIELDS_0(returnPointer.GetPtr());
	return (vtkInformationInformationVectorKey)(IntPtr)returnPointer;
}


// static vtkInformationStringVectorKey* INPUT_REQUIRED_DATA_TYPE()
// "static vtkInformationStringVectorKey* INPUT_REQUIRED_DATA_TYPE()"
public static vtkInformationStringVectorKey INPUT_REQUIRED_DATA_TYPE() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.INPUT_REQUIRED_DATA_TYPE_0(returnPointer.GetPtr());
	return (vtkInformationStringVectorKey)(IntPtr)returnPointer;
}


// static vtkInformationInformationVectorKey* INPUT_ARRAYS_TO_PROCESS()
// "static vtkInformationInformationVectorKey* INPUT_ARRAYS_TO_PROCESS()"
public static vtkInformationInformationVectorKey INPUT_ARRAYS_TO_PROCESS() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.INPUT_ARRAYS_TO_PROCESS_0(returnPointer.GetPtr());
	return (vtkInformationInformationVectorKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* INPUT_PORT()
// "static vtkInformationIntegerKey* INPUT_PORT()"
public static vtkInformationIntegerKey INPUT_PORT() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.INPUT_PORT_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* INPUT_CONNECTION()
// "static vtkInformationIntegerKey* INPUT_CONNECTION()"
public static vtkInformationIntegerKey INPUT_CONNECTION() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.INPUT_CONNECTION_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* CAN_PRODUCE_SUB_EXTENT()
// "static vtkInformationIntegerKey* CAN_PRODUCE_SUB_EXTENT()"
public static vtkInformationIntegerKey CAN_PRODUCE_SUB_EXTENT() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.CAN_PRODUCE_SUB_EXTENT_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* CAN_HANDLE_PIECE_REQUEST()
// "static vtkInformationIntegerKey* CAN_HANDLE_PIECE_REQUEST()"
public static vtkInformationIntegerKey CAN_HANDLE_PIECE_REQUEST() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.CAN_HANDLE_PIECE_REQUEST_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
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


// virtual void SetInputArrayToProcess(int idx, vtkInformation * info)
// "virtual void SetInputArrayToProcess(int idx, vtkInformation *info)"
public void SetInputArrayToProcess(int /*(int)*/ idx, vtkInformation /*(vtkInformation*)*/ info) {
	VTK_API.API_vtkAlgorithm.SetInputArrayToProcess_2(this, idx, info);
}


// virtual void SetInputArrayToProcess(int idx, int port, int connection, const char * fieldAssociation, const char * attributeTypeorName)
// "virtual void SetInputArrayToProcess(int idx, int port, int connection, const char* fieldAssociation, const char* attributeTypeorName)"
public void SetInputArrayToProcess(int /*(int)*/ idx, int /*(int)*/ port, int /*(int)*/ connection, string /*(char*)*/ fieldAssociation, string /*(char*)*/ attributeTypeorName) {
	VTK_API.API_vtkAlgorithm.SetInputArrayToProcess_3(this, idx, port, connection, fieldAssociation, attributeTypeorName);
}


// vtkInformation* GetInputArrayInformation(int idx)
// "vtkInformation *GetInputArrayInformation(int idx)"
public vtkInformation GetInputArrayInformation(int /*(int)*/ idx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetInputArrayInformation_0(returnPointer.GetPtr(), this, idx);
	return (vtkInformation)(IntPtr)returnPointer;
}


// void RemoveAllInputs()
// "void RemoveAllInputs()"
public void RemoveAllInputs() {
	VTK_API.API_vtkAlgorithm.RemoveAllInputs_0(this);
}


// vtkDataObject* GetOutputDataObject(int port)
// "vtkDataObject* GetOutputDataObject(int port)"
public vtkDataObject GetOutputDataObject(int /*(int)*/ port) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetOutputDataObject_0(returnPointer.GetPtr(), this, port);
	return (vtkDataObject)(IntPtr)returnPointer;
}


// vtkDataObject* GetInputDataObject(int port, int connection)
// "vtkDataObject *GetInputDataObject(int port, int connection)"
public vtkDataObject GetInputDataObject(int /*(int)*/ port, int /*(int)*/ connection) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
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
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetOutputPort_0(returnPointer.GetPtr(), this, index);
	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
}


// vtkAlgorithmOutput* GetOutputPort()
// "vtkAlgorithmOutput* GetOutputPort()"
public vtkAlgorithmOutput GetOutputPort() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetOutputPort_1(returnPointer.GetPtr(), this);
	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
}


// int GetNumberOfInputConnections(int port)
// "int GetNumberOfInputConnections(int port)"
public int GetNumberOfInputConnections(int /*(int)*/ port) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.GetNumberOfInputConnections_0(returnPointer.GetPtr(), this, port);
	return (int)returnPointer;
}


// int GetTotalNumberOfInputConnections()
// "int GetTotalNumberOfInputConnections()"
public int GetTotalNumberOfInputConnections() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.GetTotalNumberOfInputConnections_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkAlgorithmOutput* GetInputConnection(int port, int index)
// "vtkAlgorithmOutput* GetInputConnection(int port, int index)"
public vtkAlgorithmOutput GetInputConnection(int /*(int)*/ port, int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetInputConnection_0(returnPointer.GetPtr(), this, port, index);
	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
}


// vtkAlgorithm* GetInputAlgorithm(int port, int index, int & algPort)
// "vtkAlgorithm* GetInputAlgorithm(int port, int index, int& algPort)"
public vtkAlgorithm GetInputAlgorithm(int /*(int)*/ port, int /*(int)*/ index, IntPtr /*(int&)*/ algPort) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetInputAlgorithm_0(returnPointer.GetPtr(), this, port, index, algPort);
	return (vtkAlgorithm)(IntPtr)returnPointer;
}


// vtkAlgorithm* GetInputAlgorithm(int port, int index)
// "vtkAlgorithm* GetInputAlgorithm(int port, int index)"
public vtkAlgorithm GetInputAlgorithm(int /*(int)*/ port, int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetInputAlgorithm_1(returnPointer.GetPtr(), this, port, index);
	return (vtkAlgorithm)(IntPtr)returnPointer;
}


// vtkAlgorithm* GetInputAlgorithm()
// "vtkAlgorithm* GetInputAlgorithm()"
public vtkAlgorithm GetInputAlgorithm() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetInputAlgorithm_2(returnPointer.GetPtr(), this);
	return (vtkAlgorithm)(IntPtr)returnPointer;
}


// vtkInformation* GetInputInformation(int port, int index)
// "vtkInformation* GetInputInformation(int port, int index)"
public vtkInformation GetInputInformation(int /*(int)*/ port, int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetInputInformation_0(returnPointer.GetPtr(), this, port, index);
	return (vtkInformation)(IntPtr)returnPointer;
}


// vtkInformation* GetInputInformation()
// "vtkInformation* GetInputInformation()"
public vtkInformation GetInputInformation() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetInputInformation_1(returnPointer.GetPtr(), this);
	return (vtkInformation)(IntPtr)returnPointer;
}


// vtkInformation* GetOutputInformation(int port)
// "vtkInformation* GetOutputInformation(int port)"
public vtkInformation GetOutputInformation(int /*(int)*/ port) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetOutputInformation_0(returnPointer.GetPtr(), this, port);
	return (vtkInformation)(IntPtr)returnPointer;
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


// virtual int Update(int port, vtkInformationVector * requests)
// "virtual int Update(int port, vtkInformationVector* requests)"
public int Update(int /*(int)*/ port, vtkInformationVector /*(vtkInformationVector*)*/ requests) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.Update_2(returnPointer.GetPtr(), this, port, requests);
	return (int)returnPointer;
}


// virtual int Update(vtkInformation * requests)
// "virtual int Update(vtkInformation* requests)"
public int Update(vtkInformation /*(vtkInformation*)*/ requests) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.Update_3(returnPointer.GetPtr(), this, requests);
	return (int)returnPointer;
}


// virtual int UpdateExtent(const int extents[6])
// "virtual int UpdateExtent(const int extents[6])"
public int UpdateExtent(int /*(int[6])*/ []extents) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
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
	ReturnPointer returnPointer = new ReturnPointer(new int());
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


// int UpdateExtentIsEmpty(vtkInformation * pinfo, vtkDataObject * output)
// "int UpdateExtentIsEmpty(vtkInformation *pinfo, vtkDataObject *output)"
public int UpdateExtentIsEmpty(vtkInformation /*(vtkInformation*)*/ pinfo, vtkDataObject /*(vtkDataObject*)*/ output) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.UpdateExtentIsEmpty_0(returnPointer.GetPtr(), this, pinfo, output);
	return (int)returnPointer;
}


// int UpdateExtentIsEmpty(vtkInformation * pinfo, int extentType)
// "int UpdateExtentIsEmpty(vtkInformation *pinfo, int extentType)"
public int UpdateExtentIsEmpty(vtkInformation /*(vtkInformation*)*/ pinfo, int /*(int)*/ extentType) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.UpdateExtentIsEmpty_1(returnPointer.GetPtr(), this, pinfo, extentType);
	return (int)returnPointer;
}


// int* GetUpdateExtent()
// "int* GetUpdateExtent()"
public IntPtr GetUpdateExtent() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetUpdateExtent_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// int* GetUpdateExtent(int port)
// "int* GetUpdateExtent(int port)"
public IntPtr GetUpdateExtent(int /*(int)*/ port) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
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
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.GetUpdatePiece_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetUpdatePiece(int port)
// "int GetUpdatePiece(int port)"
public int GetUpdatePiece(int /*(int)*/ port) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.GetUpdatePiece_1(returnPointer.GetPtr(), this, port);
	return (int)returnPointer;
}


// int GetUpdateNumberOfPieces()
// "int GetUpdateNumberOfPieces()"
public int GetUpdateNumberOfPieces() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.GetUpdateNumberOfPieces_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetUpdateNumberOfPieces(int port)
// "int GetUpdateNumberOfPieces(int port)"
public int GetUpdateNumberOfPieces(int /*(int)*/ port) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.GetUpdateNumberOfPieces_1(returnPointer.GetPtr(), this, port);
	return (int)returnPointer;
}


// int GetUpdateGhostLevel()
// "int GetUpdateGhostLevel()"
public int GetUpdateGhostLevel() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.GetUpdateGhostLevel_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetUpdateGhostLevel(int port)
// "int GetUpdateGhostLevel(int port)"
public int GetUpdateGhostLevel(int /*(int)*/ port) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithm.GetUpdateGhostLevel_1(returnPointer.GetPtr(), this, port);
	return (int)returnPointer;
}


// void SetProgressObserver(vtkProgressObserver * ARG_0)
// "void SetProgressObserver(vtkProgressObserver*)"
public void SetProgressObserver(vtkProgressObserver /*(vtkProgressObserver*)*/ ARG_0) {
	VTK_API.API_vtkAlgorithm.SetProgressObserver_0(this, ARG_0);
}


// virtual vtkProgressObserver* GetProgressObserver()
// "virtual vtkProgressObserver *GetProgressObserver ()"
public vtkProgressObserver GetProgressObserver() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithm.GetProgressObserver_0(returnPointer.GetPtr(), this);
	return (vtkProgressObserver)(IntPtr)returnPointer;
}


}
};
