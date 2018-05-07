

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAssemblyNode : vtkObject {
		public vtkAssemblyNode(IntPtr p) : base(p) {}
		public static implicit operator  vtkAssemblyNode(IntPtr p) {return new vtkAssemblyNode(p);}
		public static implicit operator  IntPtr(vtkAssemblyNode o) {return o.GetPtr();}

// static vtkAssemblyNode* New()
// "static vtkAssemblyNode *New()"
public static vtkAssemblyNode New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAssemblyNode.New_0(returnPointer.GetPtr());
	return (vtkAssemblyNode)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAssemblyNode.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAssemblyNode.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkAssemblyNode* SafeDownCast(vtkObjectBase * o)
// "static vtkAssemblyNode* SafeDownCast(vtkObjectBase *o)"
public static vtkAssemblyNode SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAssemblyNode.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkAssemblyNode)(IntPtr)returnPointer;
}


// vtkAssemblyNode* NewInstance()
// "vtkAssemblyNode *NewInstance()"
public vtkAssemblyNode NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAssemblyNode.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkAssemblyNode)(IntPtr)returnPointer;
}


// virtual void SetViewProp(vtkProp * prop)
// "virtual void SetViewProp(vtkProp* prop)"
public void SetViewProp(vtkProp /*(vtkProp*)*/ prop) {
	VTK_API.API_vtkAssemblyNode.SetViewProp_0(this, prop);
}


// virtual vtkProp* GetViewProp()
// "virtual vtkProp *GetViewProp ()"
public vtkProp GetViewProp() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAssemblyNode.GetViewProp_0(returnPointer.GetPtr(), this);
	return (vtkProp)(IntPtr)returnPointer;
}


// void SetMatrix(vtkMatrix4x4 * matrix)
// "void SetMatrix(vtkMatrix4x4 *matrix)"
public void SetMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ matrix) {
	VTK_API.API_vtkAssemblyNode.SetMatrix_0(this, matrix);
}


// virtual vtkMatrix4x4* GetMatrix()
// "virtual vtkMatrix4x4 *GetMatrix ()"
public vtkMatrix4x4 GetMatrix() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAssemblyNode.GetMatrix_0(returnPointer.GetPtr(), this);
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkAssemblyNode.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


}
};
