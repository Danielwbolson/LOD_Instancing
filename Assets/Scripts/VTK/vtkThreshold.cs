

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkThreshold : vtkUnstructuredGridAlgorithm {
		public vtkThreshold(IntPtr p) : base(p) {}
		public static implicit operator  vtkThreshold(IntPtr p) {return new vtkThreshold(p);}
		public static implicit operator  IntPtr(vtkThreshold o) {return o.GetPtr();}

// static vtkThreshold* New()
// "static vtkThreshold *New()"
public static vtkThreshold New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkThreshold.New_0(returnPointer.GetPtr());
	return (vtkThreshold)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkThreshold.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkThreshold.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkThreshold* SafeDownCast(vtkObjectBase * o)
// "static vtkThreshold* SafeDownCast(vtkObjectBase *o)"
public static vtkThreshold SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkThreshold.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkThreshold)(IntPtr)returnPointer;
}


// vtkThreshold* NewInstance()
// "vtkThreshold *NewInstance()"
public vtkThreshold NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkThreshold.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkThreshold)(IntPtr)returnPointer;
}


// void ThresholdByLower(double lower)
// "void ThresholdByLower(double lower)"
public void ThresholdByLower(double /*(double)*/ lower) {
	VTK_API.API_vtkThreshold.ThresholdByLower_0(this, lower);
}


// void ThresholdByUpper(double upper)
// "void ThresholdByUpper(double upper)"
public void ThresholdByUpper(double /*(double)*/ upper) {
	VTK_API.API_vtkThreshold.ThresholdByUpper_0(this, upper);
}


// void ThresholdBetween(double lower, double upper)
// "void ThresholdBetween(double lower, double upper)"
public void ThresholdBetween(double /*(double)*/ lower, double /*(double)*/ upper) {
	VTK_API.API_vtkThreshold.ThresholdBetween_0(this, lower, upper);
}


// virtual double GetUpperThreshold()
// "virtual double GetUpperThreshold ()"
public double GetUpperThreshold() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkThreshold.GetUpperThreshold_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetLowerThreshold()
// "virtual double GetLowerThreshold ()"
public double GetLowerThreshold() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkThreshold.GetLowerThreshold_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetAttributeMode(int _arg)
// "virtual void SetAttributeMode (int _arg)"
public void SetAttributeMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkThreshold.SetAttributeMode_0(this, _arg);
}


// virtual int GetAttributeMode()
// "virtual int GetAttributeMode ()"
public int GetAttributeMode() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkThreshold.GetAttributeMode_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetAttributeModeToDefault()
// "void SetAttributeModeToDefault()"
public void SetAttributeModeToDefault() {
	VTK_API.API_vtkThreshold.SetAttributeModeToDefault_0(this);
}


// void SetAttributeModeToUsePointData()
// "void SetAttributeModeToUsePointData()"
public void SetAttributeModeToUsePointData() {
	VTK_API.API_vtkThreshold.SetAttributeModeToUsePointData_0(this);
}


// void SetAttributeModeToUseCellData()
// "void SetAttributeModeToUseCellData()"
public void SetAttributeModeToUseCellData() {
	VTK_API.API_vtkThreshold.SetAttributeModeToUseCellData_0(this);
}


// char* GetAttributeModeAsString()
// "const char *GetAttributeModeAsString()"
public string GetAttributeModeAsString() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkThreshold.GetAttributeModeAsString_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual void SetComponentMode(int _arg)
// "virtual void SetComponentMode (int _arg)"
public void SetComponentMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkThreshold.SetComponentMode_0(this, _arg);
}


// virtual int GetComponentModeMinValue()
// "virtual int GetComponentModeMinValue ()"
public int GetComponentModeMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkThreshold.GetComponentModeMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetComponentModeMaxValue()
// "virtual int GetComponentModeMaxValue ()"
public int GetComponentModeMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkThreshold.GetComponentModeMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetComponentMode()
// "virtual int GetComponentMode ()"
public int GetComponentMode() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkThreshold.GetComponentMode_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetComponentModeToUseSelected()
// "void SetComponentModeToUseSelected()"
public void SetComponentModeToUseSelected() {
	VTK_API.API_vtkThreshold.SetComponentModeToUseSelected_0(this);
}


// void SetComponentModeToUseAll()
// "void SetComponentModeToUseAll()"
public void SetComponentModeToUseAll() {
	VTK_API.API_vtkThreshold.SetComponentModeToUseAll_0(this);
}


// void SetComponentModeToUseAny()
// "void SetComponentModeToUseAny()"
public void SetComponentModeToUseAny() {
	VTK_API.API_vtkThreshold.SetComponentModeToUseAny_0(this);
}


// char* GetComponentModeAsString()
// "const char *GetComponentModeAsString()"
public string GetComponentModeAsString() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkThreshold.GetComponentModeAsString_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual void SetSelectedComponent(int _arg)
// "virtual void SetSelectedComponent (int _arg)"
public void SetSelectedComponent(int /*(int)*/ _arg) {
	VTK_API.API_vtkThreshold.SetSelectedComponent_0(this, _arg);
}


// virtual int GetSelectedComponentMinValue()
// "virtual int GetSelectedComponentMinValue ()"
public int GetSelectedComponentMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkThreshold.GetSelectedComponentMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetSelectedComponentMaxValue()
// "virtual int GetSelectedComponentMaxValue ()"
public int GetSelectedComponentMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkThreshold.GetSelectedComponentMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetSelectedComponent()
// "virtual int GetSelectedComponent ()"
public int GetSelectedComponent() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkThreshold.GetSelectedComponent_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetAllScalars(int _arg)
// "virtual void SetAllScalars (int _arg)"
public void SetAllScalars(int /*(int)*/ _arg) {
	VTK_API.API_vtkThreshold.SetAllScalars_0(this, _arg);
}


// virtual int GetAllScalars()
// "virtual int GetAllScalars ()"
public int GetAllScalars() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkThreshold.GetAllScalars_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void AllScalarsOn()
// "virtual void AllScalarsOn ()"
public void AllScalarsOn() {
	VTK_API.API_vtkThreshold.AllScalarsOn_0(this);
}


// virtual void AllScalarsOff()
// "virtual void AllScalarsOff ()"
public void AllScalarsOff() {
	VTK_API.API_vtkThreshold.AllScalarsOff_0(this);
}


// virtual void SetUseContinuousCellRange(int _arg)
// "virtual void SetUseContinuousCellRange (int _arg)"
public void SetUseContinuousCellRange(int /*(int)*/ _arg) {
	VTK_API.API_vtkThreshold.SetUseContinuousCellRange_0(this, _arg);
}


// virtual int GetUseContinuousCellRange()
// "virtual int GetUseContinuousCellRange ()"
public int GetUseContinuousCellRange() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkThreshold.GetUseContinuousCellRange_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void UseContinuousCellRangeOn()
// "virtual void UseContinuousCellRangeOn ()"
public void UseContinuousCellRangeOn() {
	VTK_API.API_vtkThreshold.UseContinuousCellRangeOn_0(this);
}


// virtual void UseContinuousCellRangeOff()
// "virtual void UseContinuousCellRangeOff ()"
public void UseContinuousCellRangeOff() {
	VTK_API.API_vtkThreshold.UseContinuousCellRangeOff_0(this);
}


// void SetPointsDataTypeToDouble()
// "void SetPointsDataTypeToDouble()"
public void SetPointsDataTypeToDouble() {
	VTK_API.API_vtkThreshold.SetPointsDataTypeToDouble_0(this);
}


// void SetPointsDataTypeToFloat()
// "void SetPointsDataTypeToFloat()"
public void SetPointsDataTypeToFloat() {
	VTK_API.API_vtkThreshold.SetPointsDataTypeToFloat_0(this);
}


// void SetPointsDataType(int type)
// "void SetPointsDataType(int type)"
public void SetPointsDataType(int /*(int)*/ type) {
	VTK_API.API_vtkThreshold.SetPointsDataType_0(this, type);
}


// int GetPointsDataType()
// "int GetPointsDataType()"
public int GetPointsDataType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkThreshold.GetPointsDataType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetOutputPointsPrecision(int precision)
// "void SetOutputPointsPrecision(int precision)"
public void SetOutputPointsPrecision(int /*(int)*/ precision) {
	VTK_API.API_vtkThreshold.SetOutputPointsPrecision_0(this, precision);
}


// int GetOutputPointsPrecision()
// "int GetOutputPointsPrecision()"
public int GetOutputPointsPrecision() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkThreshold.GetOutputPointsPrecision_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


}
};
