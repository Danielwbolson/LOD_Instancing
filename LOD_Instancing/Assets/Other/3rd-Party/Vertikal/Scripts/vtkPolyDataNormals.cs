

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPolyDataNormals : vtkPolyDataAlgorithm {
		public vtkPolyDataNormals(IntPtr p) : base(p) {}
		public static implicit operator  vtkPolyDataNormals(IntPtr p) {return new vtkPolyDataNormals(p);}
		public static implicit operator  IntPtr(vtkPolyDataNormals o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPolyDataNormals.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPolyDataNormals.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkPolyDataNormals* SafeDownCast(vtkObjectBase * o)
// "static vtkPolyDataNormals* SafeDownCast(vtkObjectBase *o)"
public static vtkPolyDataNormals SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPolyDataNormals.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkPolyDataNormals)(IntPtr)returnPointer;
}


// vtkPolyDataNormals* NewInstance()
// "vtkPolyDataNormals *NewInstance()"
public vtkPolyDataNormals NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPolyDataNormals.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkPolyDataNormals)(IntPtr)returnPointer;
}


// static vtkPolyDataNormals* New()
// "static vtkPolyDataNormals *New()"
public static vtkPolyDataNormals New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPolyDataNormals.New_0(returnPointer.GetPtr());
	return (vtkPolyDataNormals)(IntPtr)returnPointer;
}


// virtual void SetFeatureAngle(double _arg)
// "virtual void SetFeatureAngle (double _arg)"
public void SetFeatureAngle(double /*(double)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetFeatureAngle_0(this, _arg);
}


// virtual double GetFeatureAngleMinValue()
// "virtual double GetFeatureAngleMinValue ()"
public double GetFeatureAngleMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkPolyDataNormals.GetFeatureAngleMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetFeatureAngleMaxValue()
// "virtual double GetFeatureAngleMaxValue ()"
public double GetFeatureAngleMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkPolyDataNormals.GetFeatureAngleMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetFeatureAngle()
// "virtual double GetFeatureAngle ()"
public double GetFeatureAngle() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkPolyDataNormals.GetFeatureAngle_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetSplitting(int _arg)
// "virtual void SetSplitting (int _arg)"
public void SetSplitting(int /*(int)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetSplitting_0(this, _arg);
}


// virtual int GetSplitting()
// "virtual int GetSplitting ()"
public int GetSplitting() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPolyDataNormals.GetSplitting_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SplittingOn()
// "virtual void SplittingOn ()"
public void SplittingOn() {
	VTK_API.API_vtkPolyDataNormals.SplittingOn_0(this);
}


// virtual void SplittingOff()
// "virtual void SplittingOff ()"
public void SplittingOff() {
	VTK_API.API_vtkPolyDataNormals.SplittingOff_0(this);
}


// virtual void SetConsistency(int _arg)
// "virtual void SetConsistency (int _arg)"
public void SetConsistency(int /*(int)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetConsistency_0(this, _arg);
}


// virtual int GetConsistency()
// "virtual int GetConsistency ()"
public int GetConsistency() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPolyDataNormals.GetConsistency_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void ConsistencyOn()
// "virtual void ConsistencyOn ()"
public void ConsistencyOn() {
	VTK_API.API_vtkPolyDataNormals.ConsistencyOn_0(this);
}


// virtual void ConsistencyOff()
// "virtual void ConsistencyOff ()"
public void ConsistencyOff() {
	VTK_API.API_vtkPolyDataNormals.ConsistencyOff_0(this);
}


// virtual void SetAutoOrientNormals(int _arg)
// "virtual void SetAutoOrientNormals (int _arg)"
public void SetAutoOrientNormals(int /*(int)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetAutoOrientNormals_0(this, _arg);
}


// virtual int GetAutoOrientNormals()
// "virtual int GetAutoOrientNormals ()"
public int GetAutoOrientNormals() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPolyDataNormals.GetAutoOrientNormals_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void AutoOrientNormalsOn()
// "virtual void AutoOrientNormalsOn ()"
public void AutoOrientNormalsOn() {
	VTK_API.API_vtkPolyDataNormals.AutoOrientNormalsOn_0(this);
}


// virtual void AutoOrientNormalsOff()
// "virtual void AutoOrientNormalsOff ()"
public void AutoOrientNormalsOff() {
	VTK_API.API_vtkPolyDataNormals.AutoOrientNormalsOff_0(this);
}


// virtual void SetComputePointNormals(int _arg)
// "virtual void SetComputePointNormals (int _arg)"
public void SetComputePointNormals(int /*(int)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetComputePointNormals_0(this, _arg);
}


// virtual int GetComputePointNormals()
// "virtual int GetComputePointNormals ()"
public int GetComputePointNormals() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPolyDataNormals.GetComputePointNormals_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void ComputePointNormalsOn()
// "virtual void ComputePointNormalsOn ()"
public void ComputePointNormalsOn() {
	VTK_API.API_vtkPolyDataNormals.ComputePointNormalsOn_0(this);
}


// virtual void ComputePointNormalsOff()
// "virtual void ComputePointNormalsOff ()"
public void ComputePointNormalsOff() {
	VTK_API.API_vtkPolyDataNormals.ComputePointNormalsOff_0(this);
}


// virtual void SetComputeCellNormals(int _arg)
// "virtual void SetComputeCellNormals (int _arg)"
public void SetComputeCellNormals(int /*(int)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetComputeCellNormals_0(this, _arg);
}


// virtual int GetComputeCellNormals()
// "virtual int GetComputeCellNormals ()"
public int GetComputeCellNormals() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPolyDataNormals.GetComputeCellNormals_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void ComputeCellNormalsOn()
// "virtual void ComputeCellNormalsOn ()"
public void ComputeCellNormalsOn() {
	VTK_API.API_vtkPolyDataNormals.ComputeCellNormalsOn_0(this);
}


// virtual void ComputeCellNormalsOff()
// "virtual void ComputeCellNormalsOff ()"
public void ComputeCellNormalsOff() {
	VTK_API.API_vtkPolyDataNormals.ComputeCellNormalsOff_0(this);
}


// virtual void SetFlipNormals(int _arg)
// "virtual void SetFlipNormals (int _arg)"
public void SetFlipNormals(int /*(int)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetFlipNormals_0(this, _arg);
}


// virtual int GetFlipNormals()
// "virtual int GetFlipNormals ()"
public int GetFlipNormals() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPolyDataNormals.GetFlipNormals_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void FlipNormalsOn()
// "virtual void FlipNormalsOn ()"
public void FlipNormalsOn() {
	VTK_API.API_vtkPolyDataNormals.FlipNormalsOn_0(this);
}


// virtual void FlipNormalsOff()
// "virtual void FlipNormalsOff ()"
public void FlipNormalsOff() {
	VTK_API.API_vtkPolyDataNormals.FlipNormalsOff_0(this);
}


// virtual void SetNonManifoldTraversal(int _arg)
// "virtual void SetNonManifoldTraversal (int _arg)"
public void SetNonManifoldTraversal(int /*(int)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetNonManifoldTraversal_0(this, _arg);
}


// virtual int GetNonManifoldTraversal()
// "virtual int GetNonManifoldTraversal ()"
public int GetNonManifoldTraversal() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPolyDataNormals.GetNonManifoldTraversal_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void NonManifoldTraversalOn()
// "virtual void NonManifoldTraversalOn ()"
public void NonManifoldTraversalOn() {
	VTK_API.API_vtkPolyDataNormals.NonManifoldTraversalOn_0(this);
}


// virtual void NonManifoldTraversalOff()
// "virtual void NonManifoldTraversalOff ()"
public void NonManifoldTraversalOff() {
	VTK_API.API_vtkPolyDataNormals.NonManifoldTraversalOff_0(this);
}


// virtual void SetOutputPointsPrecision(int _arg)
// "virtual void SetOutputPointsPrecision (int _arg)"
public void SetOutputPointsPrecision(int /*(int)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetOutputPointsPrecision_0(this, _arg);
}


// virtual int GetOutputPointsPrecisionMinValue()
// "virtual int GetOutputPointsPrecisionMinValue ()"
public int GetOutputPointsPrecisionMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPolyDataNormals.GetOutputPointsPrecisionMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetOutputPointsPrecisionMaxValue()
// "virtual int GetOutputPointsPrecisionMaxValue ()"
public int GetOutputPointsPrecisionMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPolyDataNormals.GetOutputPointsPrecisionMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetOutputPointsPrecision()
// "virtual int GetOutputPointsPrecision ()"
public int GetOutputPointsPrecision() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPolyDataNormals.GetOutputPointsPrecision_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


}
};
