

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractVolumeMapper : vtkAbstractMapper3D {
		public vtkAbstractVolumeMapper(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractVolumeMapper(IntPtr p) {return new vtkAbstractVolumeMapper(p);}
		public static implicit operator  IntPtr(vtkAbstractVolumeMapper o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAbstractVolumeMapper.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAbstractVolumeMapper.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkAbstractVolumeMapper* SafeDownCast(vtkObjectBase * o)
// "static vtkAbstractVolumeMapper* SafeDownCast(vtkObjectBase *o)"
public static vtkAbstractVolumeMapper SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractVolumeMapper.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkAbstractVolumeMapper)(IntPtr)returnPointer;
}


// vtkAbstractVolumeMapper* NewInstance()
// "vtkAbstractVolumeMapper *NewInstance()"
public vtkAbstractVolumeMapper NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractVolumeMapper.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkAbstractVolumeMapper)(IntPtr)returnPointer;
}


// vtkDataSet* GetDataSetInput()
// "vtkDataSet *GetDataSetInput()"
public vtkDataSet GetDataSetInput() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractVolumeMapper.GetDataSetInput_0(returnPointer.GetPtr(), this);
	return (vtkDataSet)(IntPtr)returnPointer;
}


// vtkDataObject* GetDataObjectInput()
// "vtkDataObject *GetDataObjectInput()"
public vtkDataObject GetDataObjectInput() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractVolumeMapper.GetDataObjectInput_0(returnPointer.GetPtr(), this);
	return (vtkDataObject)(IntPtr)returnPointer;
}


// double* GetBounds()
// "double *GetBounds()"
public IntPtr GetBounds() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractVolumeMapper.GetBounds_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public void GetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkAbstractVolumeMapper.GetBounds_1(this, bounds);
}


// virtual void SetScalarMode(int _arg)
// "virtual void SetScalarMode (int _arg)"
public void SetScalarMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkAbstractVolumeMapper.SetScalarMode_0(this, _arg);
}


// virtual int GetScalarMode()
// "virtual int GetScalarMode ()"
public int GetScalarMode() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractVolumeMapper.GetScalarMode_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetArrayAccessMode(int _arg)
// "virtual void SetArrayAccessMode (int _arg)"
public void SetArrayAccessMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkAbstractVolumeMapper.SetArrayAccessMode_0(this, _arg);
}


// void SetScalarModeToDefault()
// "void SetScalarModeToDefault()"
public void SetScalarModeToDefault() {
	VTK_API.API_vtkAbstractVolumeMapper.SetScalarModeToDefault_0(this);
}


// void SetScalarModeToUsePointData()
// "void SetScalarModeToUsePointData()"
public void SetScalarModeToUsePointData() {
	VTK_API.API_vtkAbstractVolumeMapper.SetScalarModeToUsePointData_0(this);
}


// void SetScalarModeToUseCellData()
// "void SetScalarModeToUseCellData()"
public void SetScalarModeToUseCellData() {
	VTK_API.API_vtkAbstractVolumeMapper.SetScalarModeToUseCellData_0(this);
}


// void SetScalarModeToUsePointFieldData()
// "void SetScalarModeToUsePointFieldData()"
public void SetScalarModeToUsePointFieldData() {
	VTK_API.API_vtkAbstractVolumeMapper.SetScalarModeToUsePointFieldData_0(this);
}


// void SetScalarModeToUseCellFieldData()
// "void SetScalarModeToUseCellFieldData()"
public void SetScalarModeToUseCellFieldData() {
	VTK_API.API_vtkAbstractVolumeMapper.SetScalarModeToUseCellFieldData_0(this);
}


// virtual void SelectScalarArray(int arrayNum)
// "virtual void SelectScalarArray(int arrayNum)"
public void SelectScalarArray(int /*(int)*/ arrayNum) {
	VTK_API.API_vtkAbstractVolumeMapper.SelectScalarArray_0(this, arrayNum);
}


// virtual void SelectScalarArray(const char * arrayName)
// "virtual void SelectScalarArray(const char* arrayName)"
public void SelectScalarArray(string /*(char*)*/ arrayName) {
	VTK_API.API_vtkAbstractVolumeMapper.SelectScalarArray_1(this, arrayName);
}


// virtual char* GetArrayName()
// "virtual char* GetArrayName()"
public string GetArrayName() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractVolumeMapper.GetArrayName_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual int GetArrayId()
// "virtual int GetArrayId()"
public int GetArrayId() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractVolumeMapper.GetArrayId_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetArrayAccessMode()
// "virtual int GetArrayAccessMode()"
public int GetArrayAccessMode() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractVolumeMapper.GetArrayAccessMode_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// char* GetScalarModeAsString()
// "const char *GetScalarModeAsString()"
public string GetScalarModeAsString() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractVolumeMapper.GetScalarModeAsString_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual float GetGradientMagnitudeScale()
// "virtual float GetGradientMagnitudeScale()"
public float GetGradientMagnitudeScale() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkAbstractVolumeMapper.GetGradientMagnitudeScale_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetGradientMagnitudeBias()
// "virtual float GetGradientMagnitudeBias()"
public float GetGradientMagnitudeBias() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkAbstractVolumeMapper.GetGradientMagnitudeBias_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetGradientMagnitudeScale(int ARG_0)
// "virtual float GetGradientMagnitudeScale(int)"
public float GetGradientMagnitudeScale(int /*(int)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkAbstractVolumeMapper.GetGradientMagnitudeScale_1(returnPointer.GetPtr(), this, ARG_0);
	return (float)returnPointer;
}


// virtual float GetGradientMagnitudeBias(int ARG_0)
// "virtual float GetGradientMagnitudeBias(int)"
public float GetGradientMagnitudeBias(int /*(int)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkAbstractVolumeMapper.GetGradientMagnitudeBias_1(returnPointer.GetPtr(), this, ARG_0);
	return (float)returnPointer;
}


// virtual void Render(vtkRenderer * ren, vtkVolume * vol)
// "virtual void Render(vtkRenderer *ren, vtkVolume *vol)"
public void Render(vtkRenderer /*(vtkRenderer*)*/ ren, vtkVolume /*(vtkVolume*)*/ vol) {
	VTK_API.API_vtkAbstractVolumeMapper.Render_0(this, ren, vol);
}


// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkAbstractVolumeMapper.ReleaseGraphicsResources_0(this, ARG_0);
}


}
};
