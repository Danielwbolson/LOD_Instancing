

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAlgorithmOutput : vtkObject {
		public vtkAlgorithmOutput(IntPtr p) : base(p) {}
		public static implicit operator  vtkAlgorithmOutput(IntPtr p) {return new vtkAlgorithmOutput(p);}
		public static implicit operator  IntPtr(vtkAlgorithmOutput o) {return o.GetPtr();}

// static vtkAlgorithmOutput* New()
// "static vtkAlgorithmOutput *New()"
public static vtkAlgorithmOutput New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithmOutput.New_0(returnPointer.GetPtr());
	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAlgorithmOutput.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAlgorithmOutput.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkAlgorithmOutput* SafeDownCast(vtkObjectBase * o)
// "static vtkAlgorithmOutput* SafeDownCast(vtkObjectBase *o)"
public static vtkAlgorithmOutput SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithmOutput.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
}


// vtkAlgorithmOutput* NewInstance()
// "vtkAlgorithmOutput *NewInstance()"
public vtkAlgorithmOutput NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithmOutput.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
}


// void SetIndex(int index)
// "void SetIndex(int index)"
public void SetIndex(int /*(int)*/ index) {
	VTK_API.API_vtkAlgorithmOutput.SetIndex_0(this, index);
}


// int GetIndex()
// "int GetIndex()"
public int GetIndex() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAlgorithmOutput.GetIndex_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkAlgorithm* GetProducer()
// "vtkAlgorithm* GetProducer()"
public vtkAlgorithm GetProducer() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAlgorithmOutput.GetProducer_0(returnPointer.GetPtr(), this);
	return (vtkAlgorithm)(IntPtr)returnPointer;
}


// void SetProducer(vtkAlgorithm * producer)
// "void SetProducer(vtkAlgorithm* producer)"
public void SetProducer(vtkAlgorithm /*(vtkAlgorithm*)*/ producer) {
	VTK_API.API_vtkAlgorithmOutput.SetProducer_0(this, producer);
}


}
};
