
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public class vtkAlgorithm : vtkObject {

//       Method: static vtkAlgorithm * vtkAlgorithm::New()
// 
public static IntPtr New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.New(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkAlgorithm::GetClassName()
// 
public static string GetClassName(IntPtr obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkAlgorithm.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkAlgorithm::HasExecutive()
// 
public static int HasExecutive(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.HasExecutive(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkExecutive * vtkAlgorithm::GetExecutive()
// 
public static IntPtr GetExecutive(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetExecutive(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAlgorithm::SetExecutive(vtkExecutive* executive)
// 
public static void SetExecutive(IntPtr obj, IntPtr/*vtkExecutive* */ executive) {
	VTK.API_vtkAlgorithm.SetExecutive(obj, executive);
}


//       Method: virtual int vtkAlgorithm::ProcessRequest(vtkInformation* request, vtkInformationVector** inInfo, vtkInformationVector* outInfo)
// 
public static int ProcessRequest(IntPtr obj, IntPtr/*vtkInformation* */ request, IntPtr/*vtkInformationVector** */ inInfo, IntPtr/*vtkInformationVector* */ outInfo) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.ProcessRequest(p,obj, request, inInfo, outInfo);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


////       Method: int vtkAlgorithm::ProcessRequest(vtkInformation* request, vtkCollection* inInfo, vtkInformationVector* outInfo)
//// 
//public static int ProcessRequest(IntPtr obj, IntPtr/*vtkInformation* */ request, IntPtr/*vtkCollection* */ inInfo, IntPtr/*vtkInformationVector* */ outInfo) {
//	int numElements = 1;
//	int example = new int();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkAlgorithm.ProcessRequest(p,obj, request, inInfo, outInfo);
//	int result = Convert.ToInt32(Marshal.ReadInt32(p));
//	Marshal.FreeHGlobal (p);
//	return result;
//}


//       Method: virtual int vtkAlgorithm::ComputePipelineMTime(vtkInformation* request, vtkInformationVector** inInfoVec, vtkInformationVector* outInfoVec, int requestFromOutputPort, vtkMTimeType* mtime)
// 
public static int ComputePipelineMTime(IntPtr obj, IntPtr/*vtkInformation* */ request, IntPtr/*vtkInformationVector** */ inInfoVec, IntPtr/*vtkInformationVector* */ outInfoVec, int requestFromOutputPort, IntPtr/*vtkMTimeType* */ mtime) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.ComputePipelineMTime(p,obj, request, inInfoVec, outInfoVec, requestFromOutputPort, mtime);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkAlgorithm::ModifyRequest(vtkInformation* request, int when)
// 
public static int ModifyRequest(IntPtr obj, IntPtr/*vtkInformation* */ request, int when) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.ModifyRequest(p,obj, request, when);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkInformation * vtkAlgorithm::GetInputPortInformation(int port)
// 
public static IntPtr GetInputPortInformation(IntPtr obj, int port) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetInputPortInformation(p,obj, port);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkInformation * vtkAlgorithm::GetOutputPortInformation(int port)
// 
public static IntPtr GetOutputPortInformation(IntPtr obj, int port) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetOutputPortInformation(p,obj, port);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAlgorithm::SetInformation(vtkInformation* ARG_0)
// 
public static void SetInformation(IntPtr obj, IntPtr/*vtkInformation* */ ARG_0) {
	VTK.API_vtkAlgorithm.SetInformation(obj, ARG_0);
}


//       Method: int vtkAlgorithm::GetNumberOfInputPorts()
// 
public static int GetNumberOfInputPorts(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetNumberOfInputPorts(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkAlgorithm::GetNumberOfOutputPorts()
// 
public static int GetNumberOfOutputPorts(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetNumberOfOutputPorts(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkAlgorithm::Register(vtkObjectBase* o)
// 
public static void Register(IntPtr obj, IntPtr/*vtkObjectBase* */ o) {
	VTK.API_vtkAlgorithm.Register(obj, o);
}


//       Method: void vtkAlgorithm::UnRegister(vtkObjectBase* o)
// 
public static void UnRegister(IntPtr obj, IntPtr/*vtkObjectBase* */ o) {
	VTK.API_vtkAlgorithm.UnRegister(obj, o);
}


//       Method: void vtkAlgorithm::UpdateProgress(double amount)
// 
public static void UpdateProgress(IntPtr obj, double amount) {
	VTK.API_vtkAlgorithm.UpdateProgress(obj, amount);
}


//       Method: void vtkAlgorithm::SetProgressText(const char* ptext)
// 
public static void SetProgressText(IntPtr obj, string/*const char* */ ptext) {
	VTK.API_vtkAlgorithm.SetProgressText(obj, ptext);
}


//       Method: static vtkInformationIntegerKey * vtkAlgorithm::INPUT_IS_OPTIONAL()
// 
public static IntPtr INPUT_IS_OPTIONAL() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.INPUT_IS_OPTIONAL(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkAlgorithm::INPUT_IS_REPEATABLE()
// 
public static IntPtr INPUT_IS_REPEATABLE() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.INPUT_IS_REPEATABLE(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationInformationVectorKey * vtkAlgorithm::INPUT_REQUIRED_FIELDS()
// 
public static IntPtr INPUT_REQUIRED_FIELDS() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.INPUT_REQUIRED_FIELDS(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationStringVectorKey * vtkAlgorithm::INPUT_REQUIRED_DATA_TYPE()
// 
public static IntPtr INPUT_REQUIRED_DATA_TYPE() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.INPUT_REQUIRED_DATA_TYPE(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationInformationVectorKey * vtkAlgorithm::INPUT_ARRAYS_TO_PROCESS()
// 
public static IntPtr INPUT_ARRAYS_TO_PROCESS() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.INPUT_ARRAYS_TO_PROCESS(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkAlgorithm::INPUT_PORT()
// 
public static IntPtr INPUT_PORT() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.INPUT_PORT(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkAlgorithm::INPUT_CONNECTION()
// 
public static IntPtr INPUT_CONNECTION() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.INPUT_CONNECTION(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkAlgorithm::CAN_PRODUCE_SUB_EXTENT()
// 
public static IntPtr CAN_PRODUCE_SUB_EXTENT() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.CAN_PRODUCE_SUB_EXTENT(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkAlgorithm::CAN_HANDLE_PIECE_REQUEST()
// 
public static IntPtr CAN_HANDLE_PIECE_REQUEST() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.CAN_HANDLE_PIECE_REQUEST(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAlgorithm::SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, const char* name)
// 
public static void SetInputArrayToProcess(IntPtr obj, int idx, int port, int connection, int fieldAssociation, string/*const char* */ name) {
	VTK.API_vtkAlgorithm.SetInputArrayToProcess(obj, idx, port, connection, fieldAssociation, name);
}


//       Method: virtual void vtkAlgorithm::SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
// 
public static void SetInputArrayToProcess(IntPtr obj, int idx, int port, int connection, int fieldAssociation, int fieldAttributeType) {
	VTK.API_vtkAlgorithm.SetInputArrayToProcess(obj, idx, port, connection, fieldAssociation, fieldAttributeType);
}


//       Method: virtual void vtkAlgorithm::SetInputArrayToProcess(int idx, vtkInformation* info)
// 
public static void SetInputArrayToProcess(IntPtr obj, int idx, IntPtr/*vtkInformation* */ info) {
	VTK.API_vtkAlgorithm.SetInputArrayToProcess(obj, idx, info);
}


//       Method: virtual void vtkAlgorithm::SetInputArrayToProcess(int idx, int port, int connection, const char* fieldAssociation, const char* attributeTypeorName)
// 
public static void SetInputArrayToProcess(IntPtr obj, int idx, int port, int connection, string/*const char* */ fieldAssociation, string/*const char* */ attributeTypeorName) {
	VTK.API_vtkAlgorithm.SetInputArrayToProcess(obj, idx, port, connection, fieldAssociation, attributeTypeorName);
}


//       Method: vtkInformation * vtkAlgorithm::GetInputArrayInformation(int idx)
// 
public static IntPtr GetInputArrayInformation(IntPtr obj, int idx) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetInputArrayInformation(p,obj, idx);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkAlgorithm::RemoveAllInputs()
// 
public static void RemoveAllInputs(IntPtr obj) {
	VTK.API_vtkAlgorithm.RemoveAllInputs(obj);
}


//       Method: vtkDataObject * vtkAlgorithm::GetOutputDataObject(int port)
// 
public static IntPtr GetOutputDataObject(IntPtr obj, int port) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetOutputDataObject(p,obj, port);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataObject * vtkAlgorithm::GetInputDataObject(int port, int connection)
// 
public static IntPtr GetInputDataObject(IntPtr obj, int port, int connection) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetInputDataObject(p,obj, port, connection);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAlgorithm::SetInputConnection(int port, vtkAlgorithmOutput* input)
// 
public static void SetInputConnection(IntPtr obj, int port, IntPtr/*vtkAlgorithmOutput* */ input) {
	VTK.API_vtkAlgorithm.SetInputConnection(obj, port, input);
}


//       Method: virtual void vtkAlgorithm::SetInputConnection(vtkAlgorithmOutput* input)
// 
public static void SetInputConnection(IntPtr obj, IntPtr/*vtkAlgorithmOutput* */ input) {
	VTK.API_vtkAlgorithm.SetInputConnection(obj, input);
}


//       Method: virtual void vtkAlgorithm::AddInputConnection(int port, vtkAlgorithmOutput* input)
// 
public static void AddInputConnection(IntPtr obj, int port, IntPtr/*vtkAlgorithmOutput* */ input) {
	VTK.API_vtkAlgorithm.AddInputConnection(obj, port, input);
}


//       Method: virtual void vtkAlgorithm::AddInputConnection(vtkAlgorithmOutput* input)
// 
public static void AddInputConnection(IntPtr obj, IntPtr/*vtkAlgorithmOutput* */ input) {
	VTK.API_vtkAlgorithm.AddInputConnection(obj, input);
}


//       Method: virtual void vtkAlgorithm::RemoveInputConnection(int port, vtkAlgorithmOutput* input)
// 
public static void RemoveInputConnection(IntPtr obj, int port, IntPtr/*vtkAlgorithmOutput* */ input) {
	VTK.API_vtkAlgorithm.RemoveInputConnection(obj, port, input);
}


//       Method: virtual void vtkAlgorithm::RemoveInputConnection(int port, int idx)
// 
public static void RemoveInputConnection(IntPtr obj, int port, int idx) {
	VTK.API_vtkAlgorithm.RemoveInputConnection(obj, port, idx);
}


//       Method: virtual void vtkAlgorithm::RemoveAllInputConnections(int port)
// 
public static void RemoveAllInputConnections(IntPtr obj, int port) {
	VTK.API_vtkAlgorithm.RemoveAllInputConnections(obj, port);
}


//       Method: virtual void vtkAlgorithm::SetInputDataObject(int port, vtkDataObject* data)
// 
public static void SetInputDataObject(IntPtr obj, int port, IntPtr/*vtkDataObject* */ data) {
	VTK.API_vtkAlgorithm.SetInputDataObject(obj, port, data);
}


//       Method: virtual void vtkAlgorithm::SetInputDataObject(vtkDataObject* data)
// 
public static void SetInputDataObject(IntPtr obj, IntPtr/*vtkDataObject* */ data) {
	VTK.API_vtkAlgorithm.SetInputDataObject(obj, data);
}


//       Method: virtual void vtkAlgorithm::AddInputDataObject(int port, vtkDataObject* data)
// 
public static void AddInputDataObject(IntPtr obj, int port, IntPtr/*vtkDataObject* */ data) {
	VTK.API_vtkAlgorithm.AddInputDataObject(obj, port, data);
}


//       Method: virtual void vtkAlgorithm::AddInputDataObject(vtkDataObject* data)
// 
public static void AddInputDataObject(IntPtr obj, IntPtr/*vtkDataObject* */ data) {
	VTK.API_vtkAlgorithm.AddInputDataObject(obj, data);
}


//       Method: vtkAlgorithmOutput * vtkAlgorithm::GetOutputPort(int index)
// 
public static IntPtr GetOutputPort(IntPtr obj, int index) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetOutputPort(p,obj, index);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkAlgorithmOutput * vtkAlgorithm::GetOutputPort()
// 
public static IntPtr GetOutputPort(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetOutputPort(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkAlgorithm::GetNumberOfInputConnections(int port)
// 
public static int GetNumberOfInputConnections(IntPtr obj, int port) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetNumberOfInputConnections(p,obj, port);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkAlgorithm::GetTotalNumberOfInputConnections()
// 
public static int GetTotalNumberOfInputConnections(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetTotalNumberOfInputConnections(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkAlgorithmOutput * vtkAlgorithm::GetInputConnection(int port, int index)
// 
public static IntPtr GetInputConnection(IntPtr obj, int port, int index) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetInputConnection(p,obj, port, index);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkAlgorithm * vtkAlgorithm::GetInputAlgorithm(int port, int index)
// 
public static IntPtr GetInputAlgorithm(IntPtr obj, int port, int index) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetInputAlgorithm(p,obj, port, index);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkAlgorithm * vtkAlgorithm::GetInputAlgorithm()
// 
public static IntPtr GetInputAlgorithm(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetInputAlgorithm(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkExecutive * vtkAlgorithm::GetInputExecutive(int port, int index)
// 
public static IntPtr GetInputExecutive(IntPtr obj, int port, int index) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetInputExecutive(p,obj, port, index);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkExecutive * vtkAlgorithm::GetInputExecutive()
// 
public static IntPtr GetInputExecutive(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetInputExecutive(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkInformation * vtkAlgorithm::GetInputInformation(int port, int index)
// 
public static IntPtr GetInputInformation(IntPtr obj, int port, int index) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetInputInformation(p,obj, port, index);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkInformation * vtkAlgorithm::GetInputInformation()
// 
public static IntPtr GetInputInformation(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetInputInformation(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkInformation * vtkAlgorithm::GetOutputInformation(int port)
// 
public static IntPtr GetOutputInformation(IntPtr obj, int port) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetOutputInformation(p,obj, port);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAlgorithm::Update(int port)
// 
public static void Update(IntPtr obj, int port) {
	VTK.API_vtkAlgorithm.Update(obj, port);
}


//       Method: virtual void vtkAlgorithm::Update()
// 
public static void Update(IntPtr obj) {
	VTK.API_vtkAlgorithm.Update(obj);
}


//       Method: virtual int vtkAlgorithm::Update(int port, vtkInformationVector* requests)
// 
public static int Update(IntPtr obj, int port, IntPtr/*vtkInformationVector* */ requests) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.Update(p,obj, port, requests);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkAlgorithm::Update(vtkInformation* requests)
// 
public static int Update(IntPtr obj, IntPtr/*vtkInformation* */ requests) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.Update(p,obj, requests);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkAlgorithm::UpdatePiece(int piece, int numPieces, int ghostLevels, const int extents[6])
// 
public static int UpdatePiece(IntPtr obj, int piece, int numPieces, int ghostLevels, int[] /*6*/ extents) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.UpdatePiece(p,obj, piece, numPieces, ghostLevels, extents);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkAlgorithm::UpdateExtent(const int extents[6])
// 
public static int UpdateExtent(IntPtr obj, int[] /*6*/ extents) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.UpdateExtent(p,obj, extents);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkAlgorithm::UpdateTimeStep(double time, int numPieces, int ghostLevels, const int extents[6])
// 
public static int UpdateTimeStep(IntPtr obj, double time, int numPieces, int ghostLevels, int[] /*6*/ extents) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.UpdateTimeStep(p,obj, time, numPieces, ghostLevels, extents);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAlgorithm::UpdateInformation()
// 
public static void UpdateInformation(IntPtr obj) {
	VTK.API_vtkAlgorithm.UpdateInformation(obj);
}


//       Method: virtual void vtkAlgorithm::UpdateDataObject()
// 
public static void UpdateDataObject(IntPtr obj) {
	VTK.API_vtkAlgorithm.UpdateDataObject(obj);
}


//       Method: virtual void vtkAlgorithm::PropagateUpdateExtent()
// 
public static void PropagateUpdateExtent(IntPtr obj) {
	VTK.API_vtkAlgorithm.PropagateUpdateExtent(obj);
}


//       Method: virtual void vtkAlgorithm::UpdateWholeExtent()
// 
public static void UpdateWholeExtent(IntPtr obj) {
	VTK.API_vtkAlgorithm.UpdateWholeExtent(obj);
}


//       Method: virtual void vtkAlgorithm::SetReleaseDataFlag(int ARG_0)
// 
public static void SetReleaseDataFlag(IntPtr obj, int ARG_0) {
	VTK.API_vtkAlgorithm.SetReleaseDataFlag(obj, ARG_0);
}


//       Method: virtual int vtkAlgorithm::GetReleaseDataFlag()
// 
public static int GetReleaseDataFlag(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetReleaseDataFlag(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkAlgorithm::ReleaseDataFlagOn()
// 
public static void ReleaseDataFlagOn(IntPtr obj) {
	VTK.API_vtkAlgorithm.ReleaseDataFlagOn(obj);
}


//       Method: void vtkAlgorithm::ReleaseDataFlagOff()
// 
public static void ReleaseDataFlagOff(IntPtr obj) {
	VTK.API_vtkAlgorithm.ReleaseDataFlagOff(obj);
}


//       Method: int vtkAlgorithm::UpdateExtentIsEmpty(vtkInformation* pinfo, vtkDataObject* output)
// 
public static int UpdateExtentIsEmpty(IntPtr obj, IntPtr/*vtkInformation* */ pinfo, IntPtr/*vtkDataObject* */ output) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.UpdateExtentIsEmpty(p,obj, pinfo, output);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkAlgorithm::UpdateExtentIsEmpty(vtkInformation* pinfo, int extentType)
// 
public static int UpdateExtentIsEmpty(IntPtr obj, IntPtr/*vtkInformation* */ pinfo, int extentType) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.UpdateExtentIsEmpty(p,obj, pinfo, extentType);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static void vtkAlgorithm::SetDefaultExecutivePrototype(vtkExecutive* proto)
// 
public static void SetDefaultExecutivePrototype(IntPtr/*vtkExecutive* */ proto) {
	VTK.API_vtkAlgorithm.SetDefaultExecutivePrototype(proto);
}


////       Method: int * vtkAlgorithm::GetUpdateExtent()
//// 
//public static int[] GetUpdateExtent(IntPtr obj) {
//	int numElements = 1;
//	int[] example = new int[numElements];
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkAlgorithm.GetUpdateExtent(p,obj);
//	// UNSPECIFIED TYPE
//	Marshal.FreeHGlobal (p);
//	return result;
//}
//

////       Method: int * vtkAlgorithm::GetUpdateExtent(int port)
//// 
//public static int[] GetUpdateExtent(IntPtr obj, int port) {
//	int numElements = 1;
//	int[] example = new int[numElements];
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkAlgorithm.GetUpdateExtent(p,obj, port);
//	// UNSPECIFIED TYPE
//	Marshal.FreeHGlobal (p);
//	return result;
//}
//

//       Method: void vtkAlgorithm::GetUpdateExtent(int extent[6])
// 
public static void GetUpdateExtent(IntPtr obj, int[] /*6*/ extent) {
	VTK.API_vtkAlgorithm.GetUpdateExtent(obj, extent);
}


//       Method: void vtkAlgorithm::GetUpdateExtent(int port, int extent[6])
// 
public static void GetUpdateExtent(IntPtr obj, int port, int[] /*6*/ extent) {
	VTK.API_vtkAlgorithm.GetUpdateExtent(obj, port, extent);
}


//       Method: int vtkAlgorithm::GetUpdatePiece()
// 
public static int GetUpdatePiece(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetUpdatePiece(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkAlgorithm::GetUpdatePiece(int port)
// 
public static int GetUpdatePiece(IntPtr obj, int port) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetUpdatePiece(p,obj, port);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkAlgorithm::GetUpdateNumberOfPieces()
// 
public static int GetUpdateNumberOfPieces(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetUpdateNumberOfPieces(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkAlgorithm::GetUpdateNumberOfPieces(int port)
// 
public static int GetUpdateNumberOfPieces(IntPtr obj, int port) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetUpdateNumberOfPieces(p,obj, port);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkAlgorithm::GetUpdateGhostLevel()
// 
public static int GetUpdateGhostLevel(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetUpdateGhostLevel(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkAlgorithm::GetUpdateGhostLevel(int port)
// 
public static int GetUpdateGhostLevel(IntPtr obj, int port) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAlgorithm.GetUpdateGhostLevel(p,obj, port);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkAlgorithm::SetProgressObserver(vtkProgressObserver* ARG_0)
// 
public static void SetProgressObserver(IntPtr obj, IntPtr/*vtkProgressObserver* */ ARG_0) {
	VTK.API_vtkAlgorithm.SetProgressObserver(obj, ARG_0);
}


}
};
