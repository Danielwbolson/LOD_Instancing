

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationKey : vtkObjectBase {
		public vtkInformationKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationKey(IntPtr p) {return new vtkInformationKey(p);}
		public static implicit operator  IntPtr(vtkInformationKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// vtkInformationKey* NewInstance()
// "vtkInformationKey *NewInstance()"
public vtkInformationKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// void Register(vtkObjectBase * ARG_0)
// "void Register(vtkObjectBase*)"
public void Register(vtkObjectBase /*(vtkObjectBase*)*/ ARG_0) {
	VTK_API.API_vtkInformationKey.Register_0(this, ARG_0);
}


// void UnRegister(vtkObjectBase * ARG_0)
// "void UnRegister(vtkObjectBase*)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ ARG_0) {
	VTK_API.API_vtkInformationKey.UnRegister_0(this, ARG_0);
}


// char* GetName()
// "const char* GetName()"
public string GetName() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationKey.GetName_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// char* GetLocation()
// "const char* GetLocation()"
public string GetLocation() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationKey.GetLocation_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual void ShallowCopy(vtkInformation * from, vtkInformation * to)
// "virtual void ShallowCopy(vtkInformation* from, vtkInformation* to)"
public void ShallowCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationKey.ShallowCopy_0(this, from, to);
}


// virtual void DeepCopy(vtkInformation * from, vtkInformation * to)
// "virtual void DeepCopy(vtkInformation *from, vtkInformation *to)"
public void DeepCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationKey.DeepCopy_0(this, from, to);
}


// virtual int Has(vtkInformation * info)
// "virtual int Has(vtkInformation* info)"
public int Has(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformationKey.Has_0(returnPointer.GetPtr(), this, info);
	return (int)returnPointer;
}


// virtual void Remove(vtkInformation * info)
// "virtual void Remove(vtkInformation* info)"
public void Remove(vtkInformation /*(vtkInformation*)*/ info) {
	VTK_API.API_vtkInformationKey.Remove_0(this, info);
}


// virtual void Report(vtkInformation * info, vtkGarbageCollector * collector)
// "virtual void Report(vtkInformation* info, vtkGarbageCollector* collector)"
public void Report(vtkInformation /*(vtkInformation*)*/ info, vtkGarbageCollector /*(vtkGarbageCollector*)*/ collector) {
	VTK_API.API_vtkInformationKey.Report_0(this, info, collector);
}


// void Print(vtkInformation * info)
// "void Print(vtkInformation* info)"
public void Print(vtkInformation /*(vtkInformation*)*/ info) {
	VTK_API.API_vtkInformationKey.Print_0(this, info);
}


// virtual bool NeedToExecute(vtkInformation * ARG_0, vtkInformation * ARG_1)
// "virtual bool NeedToExecute(vtkInformation* , vtkInformation* )"
public bool NeedToExecute(vtkInformation /*(vtkInformation*)*/ ARG_0, vtkInformation /*(vtkInformation*)*/ ARG_1) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationKey.NeedToExecute_0(returnPointer.GetPtr(), this, ARG_0, ARG_1);
	return (bool)returnPointer;
}


// virtual void StoreMetaData(vtkInformation * ARG_0, vtkInformation * ARG_1, vtkInformation * ARG_2)
// "virtual void StoreMetaData(vtkInformation* , vtkInformation* , vtkInformation* )"
public void StoreMetaData(vtkInformation /*(vtkInformation*)*/ ARG_0, vtkInformation /*(vtkInformation*)*/ ARG_1, vtkInformation /*(vtkInformation*)*/ ARG_2) {
	VTK_API.API_vtkInformationKey.StoreMetaData_0(this, ARG_0, ARG_1, ARG_2);
}


// virtual void CopyDefaultInformation(vtkInformation * ARG_0, vtkInformation * ARG_1, vtkInformation * ARG_2)
// "virtual void CopyDefaultInformation(vtkInformation* , vtkInformation* , vtkInformation* )"
public void CopyDefaultInformation(vtkInformation /*(vtkInformation*)*/ ARG_0, vtkInformation /*(vtkInformation*)*/ ARG_1, vtkInformation /*(vtkInformation*)*/ ARG_2) {
	VTK_API.API_vtkInformationKey.CopyDefaultInformation_0(this, ARG_0, ARG_1, ARG_2);
}


}
};
