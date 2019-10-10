

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataArraySelection : vtkObject {
		public vtkDataArraySelection(IntPtr p) : base(p) {}
		public static implicit operator  vtkDataArraySelection(IntPtr p) {return new vtkDataArraySelection(p);}
		public static implicit operator  IntPtr(vtkDataArraySelection o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkDataArraySelection.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkDataArraySelection.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkDataArraySelection* SafeDownCast(vtkObjectBase * o)
// "static vtkDataArraySelection* SafeDownCast(vtkObjectBase *o)"
public static vtkDataArraySelection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArraySelection.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkDataArraySelection)(IntPtr)returnPointer;
}


// vtkDataArraySelection* NewInstance()
// "vtkDataArraySelection *NewInstance()"
public vtkDataArraySelection NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArraySelection.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkDataArraySelection)(IntPtr)returnPointer;
}


// static vtkDataArraySelection* New()
// "static vtkDataArraySelection* New()"
public static vtkDataArraySelection New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArraySelection.New_0(returnPointer.GetPtr());
	return (vtkDataArraySelection)(IntPtr)returnPointer;
}


// void EnableArray(const char * name)
// "void EnableArray(const char* name)"
public void EnableArray(string /*(char*)*/ name) {
	VTK_API.API_vtkDataArraySelection.EnableArray_0(this, name);
}


// void DisableArray(const char * name)
// "void DisableArray(const char* name)"
public void DisableArray(string /*(char*)*/ name) {
	VTK_API.API_vtkDataArraySelection.DisableArray_0(this, name);
}


// int ArrayIsEnabled(const char * name)
// "int ArrayIsEnabled(const char* name)"
public int ArrayIsEnabled(string /*(char*)*/ name) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataArraySelection.ArrayIsEnabled_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// int ArrayExists(const char * name)
// "int ArrayExists(const char* name)"
public int ArrayExists(string /*(char*)*/ name) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataArraySelection.ArrayExists_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// void EnableAllArrays()
// "void EnableAllArrays()"
public void EnableAllArrays() {
	VTK_API.API_vtkDataArraySelection.EnableAllArrays_0(this);
}


// void DisableAllArrays()
// "void DisableAllArrays()"
public void DisableAllArrays() {
	VTK_API.API_vtkDataArraySelection.DisableAllArrays_0(this);
}


// int GetNumberOfArrays()
// "int GetNumberOfArrays()"
public int GetNumberOfArrays() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataArraySelection.GetNumberOfArrays_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetNumberOfArraysEnabled()
// "int GetNumberOfArraysEnabled()"
public int GetNumberOfArraysEnabled() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataArraySelection.GetNumberOfArraysEnabled_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// char* GetArrayName(int index)
// "const char* GetArrayName(int index)"
public string GetArrayName(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArraySelection.GetArrayName_0(returnPointer.GetPtr(), this, index);
	return (string)returnPointer;
}


// int GetArrayIndex(const char * name)
// "int GetArrayIndex(const char *name)"
public int GetArrayIndex(string /*(char*)*/ name) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataArraySelection.GetArrayIndex_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// int GetEnabledArrayIndex(const char * name)
// "int GetEnabledArrayIndex(const char* name)"
public int GetEnabledArrayIndex(string /*(char*)*/ name) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataArraySelection.GetEnabledArrayIndex_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// int GetArraySetting(const char * name)
// "int GetArraySetting(const char* name)"
public int GetArraySetting(string /*(char*)*/ name) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataArraySelection.GetArraySetting_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// int GetArraySetting(int index)
// "int GetArraySetting(int index)"
public int GetArraySetting(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataArraySelection.GetArraySetting_1(returnPointer.GetPtr(), this, index);
	return (int)returnPointer;
}


// void RemoveAllArrays()
// "void RemoveAllArrays()"
public void RemoveAllArrays() {
	VTK_API.API_vtkDataArraySelection.RemoveAllArrays_0(this);
}


// int AddArray(const char * name)
// "int AddArray(const char* name)"
public int AddArray(string /*(char*)*/ name) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataArraySelection.AddArray_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// void RemoveArrayByIndex(int index)
// "void RemoveArrayByIndex(int index)"
public void RemoveArrayByIndex(int /*(int)*/ index) {
	VTK_API.API_vtkDataArraySelection.RemoveArrayByIndex_0(this, index);
}


// void RemoveArrayByName(const char * name)
// "void RemoveArrayByName(const char* name)"
public void RemoveArrayByName(string /*(char*)*/ name) {
	VTK_API.API_vtkDataArraySelection.RemoveArrayByName_0(this, name);
}


// void SetArrays(const char *const* names, int numArrays)
// "void SetArrays(const char* const* names, int numArrays)"
public void SetArrays(string /*(char*const*)*/ names, int /*(int)*/ numArrays) {
	VTK_API.API_vtkDataArraySelection.SetArrays_0(this, names, numArrays);
}


// void SetArraysWithDefault(const char *const* names, int numArrays, int defaultStatus)
// "void SetArraysWithDefault(const char* const* names, int numArrays, int defaultStatus)"
public void SetArraysWithDefault(string /*(char*const*)*/ names, int /*(int)*/ numArrays, int /*(int)*/ defaultStatus) {
	VTK_API.API_vtkDataArraySelection.SetArraysWithDefault_0(this, names, numArrays, defaultStatus);
}


// void CopySelections(vtkDataArraySelection * selections)
// "void CopySelections(vtkDataArraySelection* selections)"
public void CopySelections(vtkDataArraySelection /*(vtkDataArraySelection*)*/ selections) {
	VTK_API.API_vtkDataArraySelection.CopySelections_0(this, selections);
}


}
};
