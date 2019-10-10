

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkFeatureEdges : vtkPolyDataAlgorithm {
		public vtkFeatureEdges(IntPtr p) : base(p) {}
		public static implicit operator  vtkFeatureEdges(IntPtr p) {return new vtkFeatureEdges(p);}
		public static implicit operator  IntPtr(vtkFeatureEdges o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkFeatureEdges.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkFeatureEdges.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkFeatureEdges* SafeDownCast(vtkObjectBase * o)
// "static vtkFeatureEdges* SafeDownCast(vtkObjectBase *o)"
public static vtkFeatureEdges SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFeatureEdges.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkFeatureEdges)(IntPtr)returnPointer;
}


// vtkFeatureEdges* NewInstance()
// "vtkFeatureEdges *NewInstance()"
public vtkFeatureEdges NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFeatureEdges.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkFeatureEdges)(IntPtr)returnPointer;
}


// static vtkFeatureEdges* New()
// "static vtkFeatureEdges *New()"
public static vtkFeatureEdges New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFeatureEdges.New_0(returnPointer.GetPtr());
	return (vtkFeatureEdges)(IntPtr)returnPointer;
}


// virtual void SetBoundaryEdges(int _arg)
// "virtual void SetBoundaryEdges (int _arg)"
public void SetBoundaryEdges(int /*(int)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetBoundaryEdges_0(this, _arg);
}


// virtual int GetBoundaryEdges()
// "virtual int GetBoundaryEdges ()"
public int GetBoundaryEdges() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkFeatureEdges.GetBoundaryEdges_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void BoundaryEdgesOn()
// "virtual void BoundaryEdgesOn ()"
public void BoundaryEdgesOn() {
	VTK_API.API_vtkFeatureEdges.BoundaryEdgesOn_0(this);
}


// virtual void BoundaryEdgesOff()
// "virtual void BoundaryEdgesOff ()"
public void BoundaryEdgesOff() {
	VTK_API.API_vtkFeatureEdges.BoundaryEdgesOff_0(this);
}


// virtual void SetFeatureEdges(int _arg)
// "virtual void SetFeatureEdges (int _arg)"
public void SetFeatureEdges(int /*(int)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetFeatureEdges_0(this, _arg);
}


// virtual int GetFeatureEdges()
// "virtual int GetFeatureEdges ()"
public int GetFeatureEdges() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkFeatureEdges.GetFeatureEdges_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void FeatureEdgesOn()
// "virtual void FeatureEdgesOn ()"
public void FeatureEdgesOn() {
	VTK_API.API_vtkFeatureEdges.FeatureEdgesOn_0(this);
}


// virtual void FeatureEdgesOff()
// "virtual void FeatureEdgesOff ()"
public void FeatureEdgesOff() {
	VTK_API.API_vtkFeatureEdges.FeatureEdgesOff_0(this);
}


// virtual void SetFeatureAngle(double _arg)
// "virtual void SetFeatureAngle (double _arg)"
public void SetFeatureAngle(double /*(double)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetFeatureAngle_0(this, _arg);
}


// virtual double GetFeatureAngleMinValue()
// "virtual double GetFeatureAngleMinValue ()"
public double GetFeatureAngleMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkFeatureEdges.GetFeatureAngleMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetFeatureAngleMaxValue()
// "virtual double GetFeatureAngleMaxValue ()"
public double GetFeatureAngleMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkFeatureEdges.GetFeatureAngleMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetFeatureAngle()
// "virtual double GetFeatureAngle ()"
public double GetFeatureAngle() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkFeatureEdges.GetFeatureAngle_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetNonManifoldEdges(int _arg)
// "virtual void SetNonManifoldEdges (int _arg)"
public void SetNonManifoldEdges(int /*(int)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetNonManifoldEdges_0(this, _arg);
}


// virtual int GetNonManifoldEdges()
// "virtual int GetNonManifoldEdges ()"
public int GetNonManifoldEdges() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkFeatureEdges.GetNonManifoldEdges_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void NonManifoldEdgesOn()
// "virtual void NonManifoldEdgesOn ()"
public void NonManifoldEdgesOn() {
	VTK_API.API_vtkFeatureEdges.NonManifoldEdgesOn_0(this);
}


// virtual void NonManifoldEdgesOff()
// "virtual void NonManifoldEdgesOff ()"
public void NonManifoldEdgesOff() {
	VTK_API.API_vtkFeatureEdges.NonManifoldEdgesOff_0(this);
}


// virtual void SetManifoldEdges(int _arg)
// "virtual void SetManifoldEdges (int _arg)"
public void SetManifoldEdges(int /*(int)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetManifoldEdges_0(this, _arg);
}


// virtual int GetManifoldEdges()
// "virtual int GetManifoldEdges ()"
public int GetManifoldEdges() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkFeatureEdges.GetManifoldEdges_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void ManifoldEdgesOn()
// "virtual void ManifoldEdgesOn ()"
public void ManifoldEdgesOn() {
	VTK_API.API_vtkFeatureEdges.ManifoldEdgesOn_0(this);
}


// virtual void ManifoldEdgesOff()
// "virtual void ManifoldEdgesOff ()"
public void ManifoldEdgesOff() {
	VTK_API.API_vtkFeatureEdges.ManifoldEdgesOff_0(this);
}


// virtual void SetColoring(int _arg)
// "virtual void SetColoring (int _arg)"
public void SetColoring(int /*(int)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetColoring_0(this, _arg);
}


// virtual int GetColoring()
// "virtual int GetColoring ()"
public int GetColoring() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkFeatureEdges.GetColoring_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void ColoringOn()
// "virtual void ColoringOn ()"
public void ColoringOn() {
	VTK_API.API_vtkFeatureEdges.ColoringOn_0(this);
}


// virtual void ColoringOff()
// "virtual void ColoringOff ()"
public void ColoringOff() {
	VTK_API.API_vtkFeatureEdges.ColoringOff_0(this);
}


// void SetLocator(vtkIncrementalPointLocator * locator)
// "void SetLocator(vtkIncrementalPointLocator *locator)"
public void SetLocator(vtkIncrementalPointLocator /*(vtkIncrementalPointLocator*)*/ locator) {
	VTK_API.API_vtkFeatureEdges.SetLocator_0(this, locator);
}


// virtual vtkIncrementalPointLocator* GetLocator()
// "virtual vtkIncrementalPointLocator *GetLocator ()"
public vtkIncrementalPointLocator GetLocator() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFeatureEdges.GetLocator_0(returnPointer.GetPtr(), this);
	return (vtkIncrementalPointLocator)(IntPtr)returnPointer;
}


// void CreateDefaultLocator()
// "void CreateDefaultLocator()"
public void CreateDefaultLocator() {
	VTK_API.API_vtkFeatureEdges.CreateDefaultLocator_0(this);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkFeatureEdges.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual void SetOutputPointsPrecision(int _arg)
// "virtual void SetOutputPointsPrecision (int _arg)"
public void SetOutputPointsPrecision(int /*(int)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetOutputPointsPrecision_0(this, _arg);
}


// virtual int GetOutputPointsPrecision()
// "virtual int GetOutputPointsPrecision ()"
public int GetOutputPointsPrecision() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkFeatureEdges.GetOutputPointsPrecision_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


}
};
