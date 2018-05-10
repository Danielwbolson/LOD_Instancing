

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationObjectBaseVectorKey : vtkInformationKey {
		public vtkInformationObjectBaseVectorKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationObjectBaseVectorKey(IntPtr p) {return new vtkInformationObjectBaseVectorKey(p);}
		public static implicit operator  IntPtr(vtkInformationObjectBaseVectorKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationObjectBaseVectorKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationObjectBaseVectorKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationObjectBaseVectorKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationObjectBaseVectorKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationObjectBaseVectorKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationObjectBaseVectorKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationObjectBaseVectorKey)(IntPtr)returnPointer;
}


// vtkInformationObjectBaseVectorKey* NewInstance()
// "vtkInformationObjectBaseVectorKey *NewInstance()"
public vtkInformationObjectBaseVectorKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationObjectBaseVectorKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationObjectBaseVectorKey)(IntPtr)returnPointer;
}


// void Clear(vtkInformation * info)
// "void Clear(vtkInformation* info)"
public void Clear(vtkInformation /*(vtkInformation*)*/ info) {
	VTK_API.API_vtkInformationObjectBaseVectorKey.Clear_0(this, info);
}


// void Resize(vtkInformation * info, int n)
// "void Resize(vtkInformation* info, int n)"
public void Resize(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ n) {
	VTK_API.API_vtkInformationObjectBaseVectorKey.Resize_0(this, info, n);
}


// int Size(vtkInformation * info)
// "int Size(vtkInformation* info)"
public int Size(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformationObjectBaseVectorKey.Size_0(returnPointer.GetPtr(), this, info);
	return (int)returnPointer;
}


// int Length(vtkInformation * info)
// "int Length(vtkInformation* info)"
public int Length(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformationObjectBaseVectorKey.Length_0(returnPointer.GetPtr(), this, info);
	return (int)returnPointer;
}


// void Append(vtkInformation * info, vtkObjectBase * value)
// "void Append(vtkInformation* info, vtkObjectBase *value)"
public void Append(vtkInformation /*(vtkInformation*)*/ info, vtkObjectBase /*(vtkObjectBase*)*/ value) {
	VTK_API.API_vtkInformationObjectBaseVectorKey.Append_0(this, info, value);
}


// void Set(vtkInformation * info, vtkObjectBase * value, int i)
// "void Set(vtkInformation* info, vtkObjectBase *value, int i)"
public void Set(vtkInformation /*(vtkInformation*)*/ info, vtkObjectBase /*(vtkObjectBase*)*/ value, int /*(int)*/ i) {
	VTK_API.API_vtkInformationObjectBaseVectorKey.Set_0(this, info, value, i);
}


// void Remove(vtkInformation * info, vtkObjectBase * val)
// "void Remove(vtkInformation *info, vtkObjectBase *val)"
public void Remove(vtkInformation /*(vtkInformation*)*/ info, vtkObjectBase /*(vtkObjectBase*)*/ val) {
	VTK_API.API_vtkInformationObjectBaseVectorKey.Remove_0(this, info, val);
}


// void Remove(vtkInformation * info, int idx)
// "void Remove(vtkInformation *info, int idx)"
public void Remove(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ idx) {
	VTK_API.API_vtkInformationObjectBaseVectorKey.Remove_1(this, info, idx);
}


// void SetRange(vtkInformation * info, vtkObjectBase ** source, int from, int to, int n)
// "void SetRange(vtkInformation* info, vtkObjectBase **source, int from, int to, int n)"
public void SetRange(vtkInformation /*(vtkInformation*)*/ info, vtkObjectBase /*(vtkObjectBase**)*/ source, int /*(int)*/ from, int /*(int)*/ to, int /*(int)*/ n) {
	VTK_API.API_vtkInformationObjectBaseVectorKey.SetRange_0(this, info, source, from, to, n);
}


// void GetRange(vtkInformation * info, vtkObjectBase ** dest, int from, int to, int n)
// "void GetRange(vtkInformation *info, vtkObjectBase **dest, int from, int to, int n)"
public void GetRange(vtkInformation /*(vtkInformation*)*/ info, vtkObjectBase /*(vtkObjectBase**)*/ dest, int /*(int)*/ from, int /*(int)*/ to, int /*(int)*/ n) {
	VTK_API.API_vtkInformationObjectBaseVectorKey.GetRange_0(this, info, dest, from, to, n);
}


// vtkObjectBase* Get(vtkInformation * info, int idx)
// "vtkObjectBase *Get(vtkInformation* info, int idx)"
public vtkObjectBase Get(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ idx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationObjectBaseVectorKey.Get_0(returnPointer.GetPtr(), this, info, idx);
	return (vtkObjectBase)(IntPtr)returnPointer;
}


// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// "void ShallowCopy(vtkInformation* from, vtkInformation* to)"
public void ShallowCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationObjectBaseVectorKey.ShallowCopy_0(this, from, to);
}


}
};
