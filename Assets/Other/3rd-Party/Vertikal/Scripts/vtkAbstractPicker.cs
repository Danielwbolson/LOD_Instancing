

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractPicker : vtkObject {
		public vtkAbstractPicker(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractPicker(IntPtr p) {return new vtkAbstractPicker(p);}
		public static implicit operator  IntPtr(vtkAbstractPicker o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAbstractPicker.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAbstractPicker.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkAbstractPicker* SafeDownCast(vtkObjectBase * o)
// "static vtkAbstractPicker* SafeDownCast(vtkObjectBase *o)"
public static vtkAbstractPicker SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractPicker.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkAbstractPicker)(IntPtr)returnPointer;
}


// vtkAbstractPicker* NewInstance()
// "vtkAbstractPicker *NewInstance()"
public vtkAbstractPicker NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractPicker.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkAbstractPicker)(IntPtr)returnPointer;
}


// virtual vtkRenderer* GetRenderer()
// "virtual vtkRenderer *GetRenderer ()"
public vtkRenderer GetRenderer() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractPicker.GetRenderer_0(returnPointer.GetPtr(), this);
	return (vtkRenderer)(IntPtr)returnPointer;
}


// virtual double* GetSelectionPoint()
// "virtual double *GetSelectionPoint ()"
public IntPtr GetSelectionPoint() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractPicker.GetSelectionPoint_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetSelectionPoint(double data[3])
// "virtual void GetSelectionPoint (double data[3])"
public void GetSelectionPoint(double /*(double[3])*/ []data) {
	VTK_API.API_vtkAbstractPicker.GetSelectionPoint_1(this, data);
}


// virtual double* GetPickPosition()
// "virtual double *GetPickPosition ()"
public IntPtr GetPickPosition() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractPicker.GetPickPosition_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetPickPosition(double data[3])
// "virtual void GetPickPosition (double data[3])"
public void GetPickPosition(double /*(double[3])*/ []data) {
	VTK_API.API_vtkAbstractPicker.GetPickPosition_1(this, data);
}


// virtual int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer * renderer)
// "virtual int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer *renderer)"
public int Pick(double /*(double)*/ selectionX, double /*(double)*/ selectionY, double /*(double)*/ selectionZ, vtkRenderer /*(vtkRenderer*)*/ renderer) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractPicker.Pick_0(returnPointer.GetPtr(), this, selectionX, selectionY, selectionZ, renderer);
	return (int)returnPointer;
}


// int Pick(double selectionPt[3], vtkRenderer * ren)
// "int Pick(double selectionPt[3], vtkRenderer *ren)"
public int Pick(double /*(double[3])*/ []selectionPt, vtkRenderer /*(vtkRenderer*)*/ ren) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractPicker.Pick_1(returnPointer.GetPtr(), this, selectionPt, ren);
	return (int)returnPointer;
}


// virtual int Pick3DPoint(double ARG_0[3], vtkRenderer * ARG_1)
// "virtual int Pick3DPoint(double [3], vtkRenderer * )"
public int Pick3DPoint(double /*(double[3])*/ []ARG_0, vtkRenderer /*(vtkRenderer*)*/ ARG_1) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractPicker.Pick3DPoint_0(returnPointer.GetPtr(), this, ARG_0, ARG_1);
	return (int)returnPointer;
}


// virtual int Pick3DRay(double ARG_0[3], double ARG_1[4], vtkRenderer * ARG_2)
// "virtual int Pick3DRay(double [3], double [4], vtkRenderer * )"
public int Pick3DRay(double /*(double[3])*/ []ARG_0, double /*(double[4])*/ []ARG_1, vtkRenderer /*(vtkRenderer*)*/ ARG_2) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractPicker.Pick3DRay_0(returnPointer.GetPtr(), this, ARG_0, ARG_1, ARG_2);
	return (int)returnPointer;
}


// virtual void SetPickFromList(int _arg)
// "virtual void SetPickFromList (int _arg)"
public void SetPickFromList(int /*(int)*/ _arg) {
	VTK_API.API_vtkAbstractPicker.SetPickFromList_0(this, _arg);
}


// virtual int GetPickFromList()
// "virtual int GetPickFromList ()"
public int GetPickFromList() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractPicker.GetPickFromList_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void PickFromListOn()
// "virtual void PickFromListOn ()"
public void PickFromListOn() {
	VTK_API.API_vtkAbstractPicker.PickFromListOn_0(this);
}


// virtual void PickFromListOff()
// "virtual void PickFromListOff ()"
public void PickFromListOff() {
	VTK_API.API_vtkAbstractPicker.PickFromListOff_0(this);
}


// void InitializePickList()
// "void InitializePickList()"
public void InitializePickList() {
	VTK_API.API_vtkAbstractPicker.InitializePickList_0(this);
}


// void AddPickList(vtkProp * ARG_0)
// "void AddPickList(vtkProp *)"
public void AddPickList(vtkProp /*(vtkProp*)*/ ARG_0) {
	VTK_API.API_vtkAbstractPicker.AddPickList_0(this, ARG_0);
}


// void DeletePickList(vtkProp * ARG_0)
// "void DeletePickList(vtkProp *)"
public void DeletePickList(vtkProp /*(vtkProp*)*/ ARG_0) {
	VTK_API.API_vtkAbstractPicker.DeletePickList_0(this, ARG_0);
}


// vtkPropCollection* GetPickList()
// "vtkPropCollection *GetPickList()"
public vtkPropCollection GetPickList() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractPicker.GetPickList_0(returnPointer.GetPtr(), this);
	return (vtkPropCollection)(IntPtr)returnPointer;
}


}
};
