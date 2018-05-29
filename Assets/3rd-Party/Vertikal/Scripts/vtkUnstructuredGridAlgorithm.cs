

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkUnstructuredGridAlgorithm : vtkAlgorithm {
		public vtkUnstructuredGridAlgorithm(IntPtr p) : base(p) {}
		public static implicit operator  vtkUnstructuredGridAlgorithm(IntPtr p) {return new vtkUnstructuredGridAlgorithm(p);}
		public static implicit operator  IntPtr(vtkUnstructuredGridAlgorithm o) {return o.GetPtr();}

// static vtkUnstructuredGridAlgorithm* New()
// "static vtkUnstructuredGridAlgorithm *New()"
public static vtkUnstructuredGridAlgorithm New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGridAlgorithm.New_0(returnPointer.GetPtr());
	return (vtkUnstructuredGridAlgorithm)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkUnstructuredGridAlgorithm.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkUnstructuredGridAlgorithm.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkUnstructuredGridAlgorithm* SafeDownCast(vtkObjectBase * o)
// "static vtkUnstructuredGridAlgorithm* SafeDownCast(vtkObjectBase *o)"
public static vtkUnstructuredGridAlgorithm SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGridAlgorithm.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkUnstructuredGridAlgorithm)(IntPtr)returnPointer;
}


// vtkUnstructuredGridAlgorithm* NewInstance()
// "vtkUnstructuredGridAlgorithm *NewInstance()"
public vtkUnstructuredGridAlgorithm NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGridAlgorithm.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkUnstructuredGridAlgorithm)(IntPtr)returnPointer;
}


// vtkUnstructuredGrid* GetOutput()
// "vtkUnstructuredGrid* GetOutput()"
public vtkUnstructuredGrid GetOutput() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGridAlgorithm.GetOutput_0(returnPointer.GetPtr(), this);
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// vtkUnstructuredGrid* GetOutput(int ARG_0)
// "vtkUnstructuredGrid* GetOutput(int)"
public vtkUnstructuredGrid GetOutput(int /*(int)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGridAlgorithm.GetOutput_1(returnPointer.GetPtr(), this, ARG_0);
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// virtual void SetOutput(vtkDataObject * d)
// "virtual void SetOutput(vtkDataObject* d)"
public void SetOutput(vtkDataObject /*(vtkDataObject*)*/ d) {
	VTK_API.API_vtkUnstructuredGridAlgorithm.SetOutput_0(this, d);
}


// int ProcessRequest(vtkInformation * ARG_0, vtkInformationVector ** ARG_1, vtkInformationVector * ARG_2)
// "int ProcessRequest(vtkInformation*, vtkInformationVector**, vtkInformationVector*)"
public int ProcessRequest(vtkInformation /*(vtkInformation*)*/ ARG_0, vtkInformationVector /*(vtkInformationVector**)*/ ARG_1, vtkInformationVector /*(vtkInformationVector*)*/ ARG_2) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkUnstructuredGridAlgorithm.ProcessRequest_0(returnPointer.GetPtr(), this, ARG_0, ARG_1, ARG_2);
	return (int)returnPointer;
}


// vtkDataObject* GetInput(int port)
// "vtkDataObject *GetInput(int port)"
public vtkDataObject GetInput(int /*(int)*/ port) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGridAlgorithm.GetInput_0(returnPointer.GetPtr(), this, port);
	return (vtkDataObject)(IntPtr)returnPointer;
}


// vtkDataObject* GetInput()
// "vtkDataObject *GetInput()"
public vtkDataObject GetInput() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGridAlgorithm.GetInput_1(returnPointer.GetPtr(), this);
	return (vtkDataObject)(IntPtr)returnPointer;
}


// vtkUnstructuredGrid* GetUnstructuredGridInput(int port)
// "vtkUnstructuredGrid *GetUnstructuredGridInput(int port)"
public vtkUnstructuredGrid GetUnstructuredGridInput(int /*(int)*/ port) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGridAlgorithm.GetUnstructuredGridInput_0(returnPointer.GetPtr(), this, port);
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// void SetInputData(vtkDataObject * ARG_0)
// "void SetInputData(vtkDataObject *)"
public void SetInputData(vtkDataObject /*(vtkDataObject*)*/ ARG_0) {
	VTK_API.API_vtkUnstructuredGridAlgorithm.SetInputData_0(this, ARG_0);
}


// void SetInputData(int ARG_0, vtkDataObject * ARG_1)
// "void SetInputData(int, vtkDataObject*)"
public void SetInputData(int /*(int)*/ ARG_0, vtkDataObject /*(vtkDataObject*)*/ ARG_1) {
	VTK_API.API_vtkUnstructuredGridAlgorithm.SetInputData_1(this, ARG_0, ARG_1);
}


// void AddInputData(vtkDataObject * ARG_0)
// "void AddInputData(vtkDataObject *)"
public void AddInputData(vtkDataObject /*(vtkDataObject*)*/ ARG_0) {
	VTK_API.API_vtkUnstructuredGridAlgorithm.AddInputData_0(this, ARG_0);
}


// void AddInputData(int ARG_0, vtkDataObject * ARG_1)
// "void AddInputData(int, vtkDataObject*)"
public void AddInputData(int /*(int)*/ ARG_0, vtkDataObject /*(vtkDataObject*)*/ ARG_1) {
	VTK_API.API_vtkUnstructuredGridAlgorithm.AddInputData_1(this, ARG_0, ARG_1);
}


}
};
