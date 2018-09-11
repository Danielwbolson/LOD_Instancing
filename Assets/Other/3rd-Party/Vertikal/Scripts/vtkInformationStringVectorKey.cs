

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationStringVectorKey : vtkInformationKey {
		public vtkInformationStringVectorKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationStringVectorKey(IntPtr p) {return new vtkInformationStringVectorKey(p);}
		public static implicit operator  IntPtr(vtkInformationStringVectorKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationStringVectorKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationStringVectorKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationStringVectorKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationStringVectorKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationStringVectorKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationStringVectorKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationStringVectorKey)(IntPtr)returnPointer;
}


// vtkInformationStringVectorKey* NewInstance()
// "vtkInformationStringVectorKey *NewInstance()"
public vtkInformationStringVectorKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationStringVectorKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationStringVectorKey)(IntPtr)returnPointer;
}


// void Append(vtkInformation * info, const char * value)
// "void Append(vtkInformation* info, const char* value)"
public void Append(vtkInformation /*(vtkInformation*)*/ info, string /*(char*)*/ value) {
	VTK_API.API_vtkInformationStringVectorKey.Append_0(this, info, value);
}


// void Set(vtkInformation * info, const char * value, int idx = 0)
// "void Set(vtkInformation* info, const char* value, int idx = 0)"
public void Set(vtkInformation /*(vtkInformation*)*/ info, string /*(char*)*/ value, int /*(int)*/ idx) {
	VTK_API.API_vtkInformationStringVectorKey.Set_0(this, info, value, idx);
}


// char* Get(vtkInformation * info, int idx = 0)
// "const char* Get(vtkInformation* info, int idx = 0)"
public string Get(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ idx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationStringVectorKey.Get_0(returnPointer.GetPtr(), this, info, idx);
	return (string)returnPointer;
}


// int Length(vtkInformation * info)
// "int Length(vtkInformation* info)"
public int Length(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformationStringVectorKey.Length_0(returnPointer.GetPtr(), this, info);
	return (int)returnPointer;
}


// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// "void ShallowCopy(vtkInformation* from, vtkInformation* to)"
public void ShallowCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationStringVectorKey.ShallowCopy_0(this, from, to);
}


}
};
