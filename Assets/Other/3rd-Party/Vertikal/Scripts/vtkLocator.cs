

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkLocator : vtkObject {
		public vtkLocator(IntPtr p) : base(p) {}
		public static implicit operator  vtkLocator(IntPtr p) {return new vtkLocator(p);}
		public static implicit operator  IntPtr(vtkLocator o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkLocator.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkLocator.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkLocator* SafeDownCast(vtkObjectBase * o)
// "static vtkLocator* SafeDownCast(vtkObjectBase *o)"
public static vtkLocator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLocator.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkLocator)(IntPtr)returnPointer;
}


// vtkLocator* NewInstance()
// "vtkLocator *NewInstance()"
public vtkLocator NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLocator.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkLocator)(IntPtr)returnPointer;
}


// virtual void SetDataSet(vtkDataSet * ARG_0)
// "virtual void SetDataSet(vtkDataSet*)"
public void SetDataSet(vtkDataSet /*(vtkDataSet*)*/ ARG_0) {
	VTK_API.API_vtkLocator.SetDataSet_0(this, ARG_0);
}


// virtual vtkDataSet* GetDataSet()
// "virtual vtkDataSet *GetDataSet ()"
public vtkDataSet GetDataSet() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLocator.GetDataSet_0(returnPointer.GetPtr(), this);
	return (vtkDataSet)(IntPtr)returnPointer;
}


// virtual void SetMaxLevel(int _arg)
// "virtual void SetMaxLevel (int _arg)"
public void SetMaxLevel(int /*(int)*/ _arg) {
	VTK_API.API_vtkLocator.SetMaxLevel_0(this, _arg);
}


// virtual int GetMaxLevelMinValue()
// "virtual int GetMaxLevelMinValue ()"
public int GetMaxLevelMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLocator.GetMaxLevelMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetMaxLevelMaxValue()
// "virtual int GetMaxLevelMaxValue ()"
public int GetMaxLevelMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLocator.GetMaxLevelMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetMaxLevel()
// "virtual int GetMaxLevel ()"
public int GetMaxLevel() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLocator.GetMaxLevel_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetLevel()
// "virtual int GetLevel ()"
public int GetLevel() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLocator.GetLevel_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetAutomatic(int _arg)
// "virtual void SetAutomatic (int _arg)"
public void SetAutomatic(int /*(int)*/ _arg) {
	VTK_API.API_vtkLocator.SetAutomatic_0(this, _arg);
}


// virtual int GetAutomatic()
// "virtual int GetAutomatic ()"
public int GetAutomatic() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLocator.GetAutomatic_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void AutomaticOn()
// "virtual void AutomaticOn ()"
public void AutomaticOn() {
	VTK_API.API_vtkLocator.AutomaticOn_0(this);
}


// virtual void AutomaticOff()
// "virtual void AutomaticOff ()"
public void AutomaticOff() {
	VTK_API.API_vtkLocator.AutomaticOff_0(this);
}


// virtual void SetTolerance(double _arg)
// "virtual void SetTolerance (double _arg)"
public void SetTolerance(double /*(double)*/ _arg) {
	VTK_API.API_vtkLocator.SetTolerance_0(this, _arg);
}


// virtual double GetToleranceMinValue()
// "virtual double GetToleranceMinValue ()"
public double GetToleranceMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkLocator.GetToleranceMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetToleranceMaxValue()
// "virtual double GetToleranceMaxValue ()"
public double GetToleranceMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkLocator.GetToleranceMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetTolerance()
// "virtual double GetTolerance ()"
public double GetTolerance() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkLocator.GetTolerance_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void Update()
// "virtual void Update()"
public void Update() {
	VTK_API.API_vtkLocator.Update_0(this);
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	VTK_API.API_vtkLocator.Initialize_0(this);
}


// virtual void BuildLocator()
// "virtual void BuildLocator()"
public void BuildLocator() {
	VTK_API.API_vtkLocator.BuildLocator_0(this);
}


// virtual void FreeSearchStructure()
// "virtual void FreeSearchStructure()"
public void FreeSearchStructure() {
	VTK_API.API_vtkLocator.FreeSearchStructure_0(this);
}


// virtual void GenerateRepresentation(int level, vtkPolyData * pd)
// "virtual void GenerateRepresentation(int level, vtkPolyData *pd)"
public void GenerateRepresentation(int /*(int)*/ level, vtkPolyData /*(vtkPolyData*)*/ pd) {
	VTK_API.API_vtkLocator.GenerateRepresentation_0(this, level, pd);
}


// virtual vtkMTimeType GetBuildTime()
// "virtual vtkMTimeType GetBuildTime ()"
public ulong GetBuildTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkLocator.GetBuildTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void Register(vtkObjectBase * o)
// "void Register(vtkObjectBase *o)"
public void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkLocator.Register_0(this, o);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase *o)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkLocator.UnRegister_0(this, o);
}


}
};
