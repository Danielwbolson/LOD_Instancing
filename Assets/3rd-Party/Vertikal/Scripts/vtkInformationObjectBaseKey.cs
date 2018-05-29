

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationObjectBaseKey : vtkInformationKey {
		public vtkInformationObjectBaseKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationObjectBaseKey(IntPtr p) {return new vtkInformationObjectBaseKey(p);}
		public static implicit operator  IntPtr(vtkInformationObjectBaseKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationObjectBaseKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationObjectBaseKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationObjectBaseKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationObjectBaseKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationObjectBaseKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationObjectBaseKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationObjectBaseKey)(IntPtr)returnPointer;
}


// vtkInformationObjectBaseKey* NewInstance()
// "vtkInformationObjectBaseKey *NewInstance()"
public vtkInformationObjectBaseKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationObjectBaseKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationObjectBaseKey)(IntPtr)returnPointer;
}


// void Set(vtkInformation * info, vtkObjectBase * ARG_0)
// "void Set(vtkInformation* info, vtkObjectBase*)"
public void Set(vtkInformation /*(vtkInformation*)*/ info, vtkObjectBase /*(vtkObjectBase*)*/ ARG_0) {
	VTK_API.API_vtkInformationObjectBaseKey.Set_0(this, info, ARG_0);
}


// vtkObjectBase* Get(vtkInformation * info)
// "vtkObjectBase* Get(vtkInformation* info)"
public vtkObjectBase Get(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationObjectBaseKey.Get_0(returnPointer.GetPtr(), this, info);
	return (vtkObjectBase)(IntPtr)returnPointer;
}


// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// "void ShallowCopy(vtkInformation* from, vtkInformation* to)"
public void ShallowCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationObjectBaseKey.ShallowCopy_0(this, from, to);
}


// void Report(vtkInformation * info, vtkGarbageCollector * collector)
// "void Report(vtkInformation* info, vtkGarbageCollector* collector)"
public void Report(vtkInformation /*(vtkInformation*)*/ info, vtkGarbageCollector /*(vtkGarbageCollector*)*/ collector) {
	VTK_API.API_vtkInformationObjectBaseKey.Report_0(this, info, collector);
}


}
};
