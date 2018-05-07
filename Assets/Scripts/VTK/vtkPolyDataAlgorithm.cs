

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPolyDataAlgorithm : vtkAlgorithm {
		public vtkPolyDataAlgorithm(IntPtr p) : base(p) {}
		public static implicit operator  vtkPolyDataAlgorithm(IntPtr p) {return new vtkPolyDataAlgorithm(p);}
		public static implicit operator  IntPtr(vtkPolyDataAlgorithm o) {return o.GetPtr();}

// static vtkPolyDataAlgorithm* New()
// "static vtkPolyDataAlgorithm *New()"
public static vtkPolyDataAlgorithm New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPolyDataAlgorithm.New_0(returnPointer.GetPtr());
	return (vtkPolyDataAlgorithm)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPolyDataAlgorithm.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPolyDataAlgorithm.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkPolyDataAlgorithm* SafeDownCast(vtkObjectBase * o)
// "static vtkPolyDataAlgorithm* SafeDownCast(vtkObjectBase *o)"
public static vtkPolyDataAlgorithm SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPolyDataAlgorithm.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkPolyDataAlgorithm)(IntPtr)returnPointer;
}


// vtkPolyDataAlgorithm* NewInstance()
// "vtkPolyDataAlgorithm *NewInstance()"
public vtkPolyDataAlgorithm NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPolyDataAlgorithm.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkPolyDataAlgorithm)(IntPtr)returnPointer;
}


// vtkPolyData* GetOutput()
// "vtkPolyData* GetOutput()"
public vtkPolyData GetOutput() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPolyDataAlgorithm.GetOutput_0(returnPointer.GetPtr(), this);
	return (vtkPolyData)(IntPtr)returnPointer;
}


// vtkPolyData* GetOutput(int ARG_0)
// "vtkPolyData* GetOutput(int)"
public vtkPolyData GetOutput(int /*(int)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPolyDataAlgorithm.GetOutput_1(returnPointer.GetPtr(), this, ARG_0);
	return (vtkPolyData)(IntPtr)returnPointer;
}


// virtual void SetOutput(vtkDataObject * d)
// "virtual void SetOutput(vtkDataObject* d)"
public void SetOutput(vtkDataObject /*(vtkDataObject*)*/ d) {
	VTK_API.API_vtkPolyDataAlgorithm.SetOutput_0(this, d);
}


// vtkDataObject* GetInput()
// "vtkDataObject* GetInput()"
public vtkDataObject GetInput() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPolyDataAlgorithm.GetInput_0(returnPointer.GetPtr(), this);
	return (vtkDataObject)(IntPtr)returnPointer;
}


// vtkDataObject* GetInput(int port)
// "vtkDataObject *GetInput(int port)"
public vtkDataObject GetInput(int /*(int)*/ port) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPolyDataAlgorithm.GetInput_1(returnPointer.GetPtr(), this, port);
	return (vtkDataObject)(IntPtr)returnPointer;
}


// vtkPolyData* GetPolyDataInput(int port)
// "vtkPolyData *GetPolyDataInput(int port)"
public vtkPolyData GetPolyDataInput(int /*(int)*/ port) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPolyDataAlgorithm.GetPolyDataInput_0(returnPointer.GetPtr(), this, port);
	return (vtkPolyData)(IntPtr)returnPointer;
}


// void SetInputData(vtkDataObject * ARG_0)
// "void SetInputData(vtkDataObject *)"
public void SetInputData(vtkDataObject /*(vtkDataObject*)*/ ARG_0) {
	VTK_API.API_vtkPolyDataAlgorithm.SetInputData_0(this, ARG_0);
}


// void SetInputData(int ARG_0, vtkDataObject * ARG_1)
// "void SetInputData(int, vtkDataObject*)"
public void SetInputData(int /*(int)*/ ARG_0, vtkDataObject /*(vtkDataObject*)*/ ARG_1) {
	VTK_API.API_vtkPolyDataAlgorithm.SetInputData_1(this, ARG_0, ARG_1);
}


// void AddInputData(vtkDataObject * ARG_0)
// "void AddInputData(vtkDataObject *)"
public void AddInputData(vtkDataObject /*(vtkDataObject*)*/ ARG_0) {
	VTK_API.API_vtkPolyDataAlgorithm.AddInputData_0(this, ARG_0);
}


// void AddInputData(int ARG_0, vtkDataObject * ARG_1)
// "void AddInputData(int, vtkDataObject*)"
public void AddInputData(int /*(int)*/ ARG_0, vtkDataObject /*(vtkDataObject*)*/ ARG_1) {
	VTK_API.API_vtkPolyDataAlgorithm.AddInputData_1(this, ARG_0, ARG_1);
}


}
};
