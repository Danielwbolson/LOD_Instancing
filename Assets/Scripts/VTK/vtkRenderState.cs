

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkRenderState {
		public static implicit operator  vtkRenderState(IntPtr p) {return new vtkRenderState(p);}
		public static implicit operator  IntPtr(vtkRenderState o) {return o.GetPtr();}

// bool IsValid()
// "bool IsValid()"
public bool IsValid() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderState.IsValid_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// vtkRenderer* GetRenderer()
// "vtkRenderer *GetRenderer()"
public vtkRenderer GetRenderer() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderState.GetRenderer_0(returnPointer.GetPtr(), this);
	return (vtkRenderer)(IntPtr)returnPointer;
}


// vtkFrameBufferObjectBase* GetFrameBuffer()
// "vtkFrameBufferObjectBase *GetFrameBuffer()"
public vtkFrameBufferObjectBase GetFrameBuffer() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderState.GetFrameBuffer_0(returnPointer.GetPtr(), this);
	return (vtkFrameBufferObjectBase)(IntPtr)returnPointer;
}


// void SetFrameBuffer(vtkFrameBufferObjectBase * fbo)
// "void SetFrameBuffer(vtkFrameBufferObjectBase *fbo)"
public void SetFrameBuffer(vtkFrameBufferObjectBase /*(vtkFrameBufferObjectBase*)*/ fbo) {
	VTK_API.API_vtkRenderState.SetFrameBuffer_0(this, fbo);
}


// void GetWindowSize(int size[2])
// "void GetWindowSize(int size[2])"
public void GetWindowSize(int /*(int[2])*/ []size) {
	VTK_API.API_vtkRenderState.GetWindowSize_0(this, size);
}


// vtkProp** GetPropArray()
// "vtkProp **GetPropArray()"
public vtkProp GetPropArray() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderState.GetPropArray_0(returnPointer.GetPtr(), this);
	return (vtkProp)(IntPtr)returnPointer;
}


// int GetPropArrayCount()
// "int GetPropArrayCount()"
public int GetPropArrayCount() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderState.GetPropArrayCount_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetPropArrayAndCount(vtkProp ** propArray, int propArrayCount)
// "void SetPropArrayAndCount(vtkProp **propArray, int propArrayCount)"
public void SetPropArrayAndCount(vtkProp /*(vtkProp**)*/ propArray, int /*(int)*/ propArrayCount) {
	VTK_API.API_vtkRenderState.SetPropArrayAndCount_0(this, propArray, propArrayCount);
}


}
};
