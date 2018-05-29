

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkFXAAOptions : vtkObject {
		public vtkFXAAOptions(IntPtr p) : base(p) {}
		public static implicit operator  vtkFXAAOptions(IntPtr p) {return new vtkFXAAOptions(p);}
		public static implicit operator  IntPtr(vtkFXAAOptions o) {return o.GetPtr();}

// static vtkFXAAOptions* New()
// "static vtkFXAAOptions* New()"
public static vtkFXAAOptions New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFXAAOptions.New_0(returnPointer.GetPtr());
	return (vtkFXAAOptions)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkFXAAOptions.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkFXAAOptions.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkFXAAOptions* SafeDownCast(vtkObjectBase * o)
// "static vtkFXAAOptions* SafeDownCast(vtkObjectBase *o)"
public static vtkFXAAOptions SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFXAAOptions.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkFXAAOptions)(IntPtr)returnPointer;
}


// vtkFXAAOptions* NewInstance()
// "vtkFXAAOptions *NewInstance()"
public vtkFXAAOptions NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFXAAOptions.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkFXAAOptions)(IntPtr)returnPointer;
}


// virtual void SetRelativeContrastThreshold(float _arg)
// "virtual void SetRelativeContrastThreshold (float _arg)"
public void SetRelativeContrastThreshold(float /*(float)*/ _arg) {
	VTK_API.API_vtkFXAAOptions.SetRelativeContrastThreshold_0(this, _arg);
}


// virtual float GetRelativeContrastThresholdMinValue()
// "virtual float GetRelativeContrastThresholdMinValue ()"
public float GetRelativeContrastThresholdMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFXAAOptions.GetRelativeContrastThresholdMinValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetRelativeContrastThresholdMaxValue()
// "virtual float GetRelativeContrastThresholdMaxValue ()"
public float GetRelativeContrastThresholdMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFXAAOptions.GetRelativeContrastThresholdMaxValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetRelativeContrastThreshold()
// "virtual float GetRelativeContrastThreshold ()"
public float GetRelativeContrastThreshold() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFXAAOptions.GetRelativeContrastThreshold_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual void SetHardContrastThreshold(float _arg)
// "virtual void SetHardContrastThreshold (float _arg)"
public void SetHardContrastThreshold(float /*(float)*/ _arg) {
	VTK_API.API_vtkFXAAOptions.SetHardContrastThreshold_0(this, _arg);
}


// virtual float GetHardContrastThresholdMinValue()
// "virtual float GetHardContrastThresholdMinValue ()"
public float GetHardContrastThresholdMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFXAAOptions.GetHardContrastThresholdMinValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetHardContrastThresholdMaxValue()
// "virtual float GetHardContrastThresholdMaxValue ()"
public float GetHardContrastThresholdMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFXAAOptions.GetHardContrastThresholdMaxValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetHardContrastThreshold()
// "virtual float GetHardContrastThreshold ()"
public float GetHardContrastThreshold() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFXAAOptions.GetHardContrastThreshold_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual void SetSubpixelBlendLimit(float _arg)
// "virtual void SetSubpixelBlendLimit (float _arg)"
public void SetSubpixelBlendLimit(float /*(float)*/ _arg) {
	VTK_API.API_vtkFXAAOptions.SetSubpixelBlendLimit_0(this, _arg);
}


// virtual float GetSubpixelBlendLimitMinValue()
// "virtual float GetSubpixelBlendLimitMinValue ()"
public float GetSubpixelBlendLimitMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFXAAOptions.GetSubpixelBlendLimitMinValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetSubpixelBlendLimitMaxValue()
// "virtual float GetSubpixelBlendLimitMaxValue ()"
public float GetSubpixelBlendLimitMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFXAAOptions.GetSubpixelBlendLimitMaxValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetSubpixelBlendLimit()
// "virtual float GetSubpixelBlendLimit ()"
public float GetSubpixelBlendLimit() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFXAAOptions.GetSubpixelBlendLimit_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual void SetSubpixelContrastThreshold(float _arg)
// "virtual void SetSubpixelContrastThreshold (float _arg)"
public void SetSubpixelContrastThreshold(float /*(float)*/ _arg) {
	VTK_API.API_vtkFXAAOptions.SetSubpixelContrastThreshold_0(this, _arg);
}


// virtual float GetSubpixelContrastThresholdMinValue()
// "virtual float GetSubpixelContrastThresholdMinValue ()"
public float GetSubpixelContrastThresholdMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFXAAOptions.GetSubpixelContrastThresholdMinValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetSubpixelContrastThresholdMaxValue()
// "virtual float GetSubpixelContrastThresholdMaxValue ()"
public float GetSubpixelContrastThresholdMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFXAAOptions.GetSubpixelContrastThresholdMaxValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetSubpixelContrastThreshold()
// "virtual float GetSubpixelContrastThreshold ()"
public float GetSubpixelContrastThreshold() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFXAAOptions.GetSubpixelContrastThreshold_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual void SetUseHighQualityEndpoints(bool _arg)
// "virtual void SetUseHighQualityEndpoints (bool _arg)"
public void SetUseHighQualityEndpoints(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkFXAAOptions.SetUseHighQualityEndpoints_0(this, _arg);
}


// virtual bool GetUseHighQualityEndpoints()
// "virtual bool GetUseHighQualityEndpoints ()"
public bool GetUseHighQualityEndpoints() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkFXAAOptions.GetUseHighQualityEndpoints_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void UseHighQualityEndpointsOn()
// "virtual void UseHighQualityEndpointsOn ()"
public void UseHighQualityEndpointsOn() {
	VTK_API.API_vtkFXAAOptions.UseHighQualityEndpointsOn_0(this);
}


// virtual void UseHighQualityEndpointsOff()
// "virtual void UseHighQualityEndpointsOff ()"
public void UseHighQualityEndpointsOff() {
	VTK_API.API_vtkFXAAOptions.UseHighQualityEndpointsOff_0(this);
}


// virtual void SetEndpointSearchIterations(int _arg)
// "virtual void SetEndpointSearchIterations (int _arg)"
public void SetEndpointSearchIterations(int /*(int)*/ _arg) {
	VTK_API.API_vtkFXAAOptions.SetEndpointSearchIterations_0(this, _arg);
}


// virtual int GetEndpointSearchIterationsMinValue()
// "virtual int GetEndpointSearchIterationsMinValue ()"
public int GetEndpointSearchIterationsMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkFXAAOptions.GetEndpointSearchIterationsMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetEndpointSearchIterationsMaxValue()
// "virtual int GetEndpointSearchIterationsMaxValue ()"
public int GetEndpointSearchIterationsMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkFXAAOptions.GetEndpointSearchIterationsMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetEndpointSearchIterations()
// "virtual int GetEndpointSearchIterations ()"
public int GetEndpointSearchIterations() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkFXAAOptions.GetEndpointSearchIterations_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


}
};
