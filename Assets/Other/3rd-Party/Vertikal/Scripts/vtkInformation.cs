

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformation : vtkObject {
		public vtkInformation(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformation(IntPtr p) {return new vtkInformation(p);}
		public static implicit operator  IntPtr(vtkInformation o) {return o.GetPtr();}

// static vtkInformation* New()
// "static vtkInformation *New()"
public static vtkInformation New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.New_0(returnPointer.GetPtr());
	return (vtkInformation)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformation.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformation.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformation* SafeDownCast(vtkObjectBase * o)
// "static vtkInformation* SafeDownCast(vtkObjectBase *o)"
public static vtkInformation SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformation)(IntPtr)returnPointer;
}


// vtkInformation* NewInstance()
// "vtkInformation *NewInstance()"
public vtkInformation NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformation)(IntPtr)returnPointer;
}


// void Modified()
// "void Modified()"
public void Modified() {
	VTK_API.API_vtkInformation.Modified_0(this);
}


// void Modified(vtkInformationKey * key)
// "void Modified(vtkInformationKey* key)"
public void Modified(vtkInformationKey /*(vtkInformationKey*)*/ key) {
	VTK_API.API_vtkInformation.Modified_1(this, key);
}


// void Clear()
// "void Clear()"
public void Clear() {
	VTK_API.API_vtkInformation.Clear_0(this);
}


// int GetNumberOfKeys()
// "int GetNumberOfKeys()"
public int GetNumberOfKeys() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.GetNumberOfKeys_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void Copy(vtkInformation * from, int deep = 0)
// "void Copy(vtkInformation* from, int deep=0)"
public void Copy(vtkInformation /*(vtkInformation*)*/ from, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.Copy_0(this, from, deep);
}


// void Append(vtkInformation * from, int deep = 0)
// "void Append(vtkInformation* from, int deep=0)"
public void Append(vtkInformation /*(vtkInformation*)*/ from, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.Append_0(this, from, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationKey /*(vtkInformationKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_0(this, from, key, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationDataObjectKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationDataObjectKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationDataObjectKey /*(vtkInformationDataObjectKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_1(this, from, key, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationDoubleVectorKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationDoubleVectorKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_2(this, from, key, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationVariantKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationVariantKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationVariantKey /*(vtkInformationVariantKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_3(this, from, key, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationVariantVectorKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationVariantVectorKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationVariantVectorKey /*(vtkInformationVariantVectorKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_4(this, from, key, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationInformationKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationInformationKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationInformationKey /*(vtkInformationInformationKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_5(this, from, key, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationInformationVectorKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationInformationVectorKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationInformationVectorKey /*(vtkInformationInformationVectorKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_6(this, from, key, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationIntegerKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationIntegerKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationIntegerKey /*(vtkInformationIntegerKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_7(this, from, key, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationIntegerVectorKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationIntegerVectorKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_8(this, from, key, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationObjectBaseVectorKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationObjectBaseVectorKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationObjectBaseVectorKey /*(vtkInformationObjectBaseVectorKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_9(this, from, key, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationRequestKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationRequestKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationRequestKey /*(vtkInformationRequestKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_10(this, from, key, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationStringKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationStringKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationStringKey /*(vtkInformationStringKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_11(this, from, key, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationStringVectorKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationStringVectorKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationStringVectorKey /*(vtkInformationStringVectorKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_12(this, from, key, deep);
}


// void CopyEntry(vtkInformation * from, vtkInformationUnsignedLongKey * key, int deep = 0)
// "void CopyEntry(vtkInformation* from, vtkInformationUnsignedLongKey* key, int deep=0)"
public void CopyEntry(vtkInformation /*(vtkInformation*)*/ from, vtkInformationUnsignedLongKey /*(vtkInformationUnsignedLongKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntry_13(this, from, key, deep);
}


// void CopyEntries(vtkInformation * from, vtkInformationKeyVectorKey * key, int deep = 0)
// "void CopyEntries(vtkInformation* from, vtkInformationKeyVectorKey* key, int deep=0)"
public void CopyEntries(vtkInformation /*(vtkInformation*)*/ from, vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, int /*(int)*/ deep) {
	VTK_API.API_vtkInformation.CopyEntries_0(this, from, key, deep);
}


// int Has(vtkInformationKey * key)
// "int Has(vtkInformationKey* key)"
public int Has(vtkInformationKey /*(vtkInformationKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_0(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Remove(vtkInformationKey * key)
// "void Remove(vtkInformationKey* key)"
public void Remove(vtkInformationKey /*(vtkInformationKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_0(this, key);
}


// void Set(vtkInformationRequestKey * key)
// "void Set(vtkInformationRequestKey* key)"
public void Set(vtkInformationRequestKey /*(vtkInformationRequestKey*)*/ key) {
	VTK_API.API_vtkInformation.Set_0(this, key);
}


// void Remove(vtkInformationRequestKey * key)
// "void Remove(vtkInformationRequestKey* key)"
public void Remove(vtkInformationRequestKey /*(vtkInformationRequestKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_1(this, key);
}


// int Has(vtkInformationRequestKey * key)
// "int Has(vtkInformationRequestKey* key)"
public int Has(vtkInformationRequestKey /*(vtkInformationRequestKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_1(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Set(vtkInformationIntegerKey * key, int value)
// "void Set(vtkInformationIntegerKey* key, int value)"
public void Set(vtkInformationIntegerKey /*(vtkInformationIntegerKey*)*/ key, int /*(int)*/ value) {
	VTK_API.API_vtkInformation.Set_1(this, key, value);
}


// int Get(vtkInformationIntegerKey * key)
// "int Get(vtkInformationIntegerKey* key)"
public int Get(vtkInformationIntegerKey /*(vtkInformationIntegerKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Get_0(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Remove(vtkInformationIntegerKey * key)
// "void Remove(vtkInformationIntegerKey* key)"
public void Remove(vtkInformationIntegerKey /*(vtkInformationIntegerKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_2(this, key);
}


// int Has(vtkInformationIntegerKey * key)
// "int Has(vtkInformationIntegerKey* key)"
public int Has(vtkInformationIntegerKey /*(vtkInformationIntegerKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_2(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Set(vtkInformationIdTypeKey * key, vtkIdType value)
// "void Set(vtkInformationIdTypeKey* key, vtkIdType value)"
public void Set(vtkInformationIdTypeKey /*(vtkInformationIdTypeKey*)*/ key, long /*(vtkIdType)*/ value) {
	VTK_API.API_vtkInformation.Set_2(this, key, value);
}


// vtkIdType Get(vtkInformationIdTypeKey * key)
// "vtkIdType Get(vtkInformationIdTypeKey* key)"
public long Get(vtkInformationIdTypeKey /*(vtkInformationIdTypeKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkInformation.Get_1(returnPointer.GetPtr(), this, key);
	return (long)returnPointer;
}


// void Remove(vtkInformationIdTypeKey * key)
// "void Remove(vtkInformationIdTypeKey* key)"
public void Remove(vtkInformationIdTypeKey /*(vtkInformationIdTypeKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_3(this, key);
}


// int Has(vtkInformationIdTypeKey * key)
// "int Has(vtkInformationIdTypeKey* key)"
public int Has(vtkInformationIdTypeKey /*(vtkInformationIdTypeKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_3(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Set(vtkInformationDoubleKey * key, double value)
// "void Set(vtkInformationDoubleKey* key, double value)"
public void Set(vtkInformationDoubleKey /*(vtkInformationDoubleKey*)*/ key, double /*(double)*/ value) {
	VTK_API.API_vtkInformation.Set_3(this, key, value);
}


// double Get(vtkInformationDoubleKey * key)
// "double Get(vtkInformationDoubleKey* key)"
public double Get(vtkInformationDoubleKey /*(vtkInformationDoubleKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkInformation.Get_2(returnPointer.GetPtr(), this, key);
	return (double)returnPointer;
}


// void Remove(vtkInformationDoubleKey * key)
// "void Remove(vtkInformationDoubleKey* key)"
public void Remove(vtkInformationDoubleKey /*(vtkInformationDoubleKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_4(this, key);
}


// int Has(vtkInformationDoubleKey * key)
// "int Has(vtkInformationDoubleKey* key)"
public int Has(vtkInformationDoubleKey /*(vtkInformationDoubleKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_4(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Remove(vtkInformationVariantKey * key)
// "void Remove(vtkInformationVariantKey* key)"
public void Remove(vtkInformationVariantKey /*(vtkInformationVariantKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_5(this, key);
}


// int Has(vtkInformationVariantKey * key)
// "int Has(vtkInformationVariantKey* key)"
public int Has(vtkInformationVariantKey /*(vtkInformationVariantKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_5(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Append(vtkInformationIntegerVectorKey * key, int value)
// "void Append(vtkInformationIntegerVectorKey* key, int value)"
public void Append(vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ key, int /*(int)*/ value) {
	VTK_API.API_vtkInformation.Append_1(this, key, value);
}


// void Set(vtkInformationIntegerVectorKey * key, const int * value, int length)
// "void Set(vtkInformationIntegerVectorKey* key, const int* value, int length)"
public void Set(vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ key, IntPtr /*(int*)*/ value, int /*(int)*/ length) {
	VTK_API.API_vtkInformation.Set_4(this, key, value, length);
}


// void Set(vtkInformationIntegerVectorKey * key, int value1, int value2, int value3)
// "void Set(vtkInformationIntegerVectorKey* key, int value1, int value2, int value3)"
public void Set(vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ key, int /*(int)*/ value1, int /*(int)*/ value2, int /*(int)*/ value3) {
	VTK_API.API_vtkInformation.Set_5(this, key, value1, value2, value3);
}


// void Set(vtkInformationIntegerVectorKey * key, int value1, int value2, int value3, int value4, int value5, int value6)
// "void Set(vtkInformationIntegerVectorKey* key, int value1, int value2, int value3, int value4, int value5, int value6)"
public void Set(vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ key, int /*(int)*/ value1, int /*(int)*/ value2, int /*(int)*/ value3, int /*(int)*/ value4, int /*(int)*/ value5, int /*(int)*/ value6) {
	VTK_API.API_vtkInformation.Set_6(this, key, value1, value2, value3, value4, value5, value6);
}


// int* Get(vtkInformationIntegerVectorKey * key)
// "int* Get(vtkInformationIntegerVectorKey* key)"
public IntPtr Get(vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.Get_3(returnPointer.GetPtr(), this, key);
	return (IntPtr)returnPointer;
}


// int Get(vtkInformationIntegerVectorKey * key, int idx)
// "int Get(vtkInformationIntegerVectorKey* key, int idx)"
public int Get(vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ key, int /*(int)*/ idx) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Get_4(returnPointer.GetPtr(), this, key, idx);
	return (int)returnPointer;
}


// void Get(vtkInformationIntegerVectorKey * key, int * value)
// "void Get(vtkInformationIntegerVectorKey* key, int* value)"
public void Get(vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ key, IntPtr /*(int*)*/ value) {
	VTK_API.API_vtkInformation.Get_5(this, key, value);
}


// int Length(vtkInformationIntegerVectorKey * key)
// "int Length(vtkInformationIntegerVectorKey* key)"
public int Length(vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Length_0(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Remove(vtkInformationIntegerVectorKey * key)
// "void Remove(vtkInformationIntegerVectorKey* key)"
public void Remove(vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_6(this, key);
}


// int Has(vtkInformationIntegerVectorKey * key)
// "int Has(vtkInformationIntegerVectorKey* key)"
public int Has(vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_6(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Append(vtkInformationStringVectorKey * key, const char * value)
// "void Append(vtkInformationStringVectorKey* key, const char* value)"
public void Append(vtkInformationStringVectorKey /*(vtkInformationStringVectorKey*)*/ key, string /*(char*)*/ value) {
	VTK_API.API_vtkInformation.Append_2(this, key, value);
}


// void Set(vtkInformationStringVectorKey * key, const char * value, int idx = 0)
// "void Set(vtkInformationStringVectorKey* key, const char* value, int idx = 0)"
public void Set(vtkInformationStringVectorKey /*(vtkInformationStringVectorKey*)*/ key, string /*(char*)*/ value, int /*(int)*/ idx) {
	VTK_API.API_vtkInformation.Set_7(this, key, value, idx);
}


// char* Get(vtkInformationStringVectorKey * key, int idx = 0)
// "const char* Get(vtkInformationStringVectorKey* key, int idx = 0)"
public string Get(vtkInformationStringVectorKey /*(vtkInformationStringVectorKey*)*/ key, int /*(int)*/ idx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.Get_6(returnPointer.GetPtr(), this, key, idx);
	return (string)returnPointer;
}


// int Length(vtkInformationStringVectorKey * key)
// "int Length(vtkInformationStringVectorKey* key)"
public int Length(vtkInformationStringVectorKey /*(vtkInformationStringVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Length_1(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Remove(vtkInformationStringVectorKey * key)
// "void Remove(vtkInformationStringVectorKey* key)"
public void Remove(vtkInformationStringVectorKey /*(vtkInformationStringVectorKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_7(this, key);
}


// int Has(vtkInformationStringVectorKey * key)
// "int Has(vtkInformationStringVectorKey* key)"
public int Has(vtkInformationStringVectorKey /*(vtkInformationStringVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_7(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Set(vtkInformationIntegerPointerKey * key, int * value, int length)
// "void Set(vtkInformationIntegerPointerKey* key, int* value, int length)"
public void Set(vtkInformationIntegerPointerKey /*(vtkInformationIntegerPointerKey*)*/ key, IntPtr /*(int*)*/ value, int /*(int)*/ length) {
	VTK_API.API_vtkInformation.Set_8(this, key, value, length);
}


// int* Get(vtkInformationIntegerPointerKey * key)
// "int* Get(vtkInformationIntegerPointerKey* key)"
public IntPtr Get(vtkInformationIntegerPointerKey /*(vtkInformationIntegerPointerKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.Get_7(returnPointer.GetPtr(), this, key);
	return (IntPtr)returnPointer;
}


// void Get(vtkInformationIntegerPointerKey * key, int * value)
// "void Get(vtkInformationIntegerPointerKey* key, int* value)"
public void Get(vtkInformationIntegerPointerKey /*(vtkInformationIntegerPointerKey*)*/ key, IntPtr /*(int*)*/ value) {
	VTK_API.API_vtkInformation.Get_8(this, key, value);
}


// int Length(vtkInformationIntegerPointerKey * key)
// "int Length(vtkInformationIntegerPointerKey* key)"
public int Length(vtkInformationIntegerPointerKey /*(vtkInformationIntegerPointerKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Length_2(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Remove(vtkInformationIntegerPointerKey * key)
// "void Remove(vtkInformationIntegerPointerKey* key)"
public void Remove(vtkInformationIntegerPointerKey /*(vtkInformationIntegerPointerKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_8(this, key);
}


// int Has(vtkInformationIntegerPointerKey * key)
// "int Has(vtkInformationIntegerPointerKey* key)"
public int Has(vtkInformationIntegerPointerKey /*(vtkInformationIntegerPointerKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_8(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Set(vtkInformationUnsignedLongKey * key, unsigned long value)
// "void Set(vtkInformationUnsignedLongKey* key, unsigned long value)"
public void Set(vtkInformationUnsignedLongKey /*(vtkInformationUnsignedLongKey*)*/ key, ulong /*(unsigned long)*/ value) {
	VTK_API.API_vtkInformation.Set_9(this, key, value);
}


// long Get(vtkInformationUnsignedLongKey * key)
// "unsigned long Get(vtkInformationUnsignedLongKey* key)"
public ulong Get(vtkInformationUnsignedLongKey /*(vtkInformationUnsignedLongKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkInformation.Get_9(returnPointer.GetPtr(), this, key);
	return (ulong)returnPointer;
}


// void Remove(vtkInformationUnsignedLongKey * key)
// "void Remove(vtkInformationUnsignedLongKey* key)"
public void Remove(vtkInformationUnsignedLongKey /*(vtkInformationUnsignedLongKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_9(this, key);
}


// int Has(vtkInformationUnsignedLongKey * key)
// "int Has(vtkInformationUnsignedLongKey* key)"
public int Has(vtkInformationUnsignedLongKey /*(vtkInformationUnsignedLongKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_9(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Append(vtkInformationDoubleVectorKey * key, double value)
// "void Append(vtkInformationDoubleVectorKey* key, double value)"
public void Append(vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ key, double /*(double)*/ value) {
	VTK_API.API_vtkInformation.Append_3(this, key, value);
}


// void Set(vtkInformationDoubleVectorKey * key, const double * value, int length)
// "void Set(vtkInformationDoubleVectorKey* key, const double* value, int length)"
public void Set(vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ key, IntPtr /*(double*)*/ value, int /*(int)*/ length) {
	VTK_API.API_vtkInformation.Set_10(this, key, value, length);
}


// void Set(vtkInformationDoubleVectorKey * key, double value1, double value2, double value3)
// "void Set(vtkInformationDoubleVectorKey* key, double value1, double value2, double value3)"
public void Set(vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ key, double /*(double)*/ value1, double /*(double)*/ value2, double /*(double)*/ value3) {
	VTK_API.API_vtkInformation.Set_11(this, key, value1, value2, value3);
}


// void Set(vtkInformationDoubleVectorKey * key, double value1, double value2, double value3, double value4, double value5, double value6)
// "void Set(vtkInformationDoubleVectorKey* key, double value1, double value2, double value3, double value4, double value5, double value6)"
public void Set(vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ key, double /*(double)*/ value1, double /*(double)*/ value2, double /*(double)*/ value3, double /*(double)*/ value4, double /*(double)*/ value5, double /*(double)*/ value6) {
	VTK_API.API_vtkInformation.Set_12(this, key, value1, value2, value3, value4, value5, value6);
}


// double* Get(vtkInformationDoubleVectorKey * key)
// "double* Get(vtkInformationDoubleVectorKey* key)"
public IntPtr Get(vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.Get_10(returnPointer.GetPtr(), this, key);
	return (IntPtr)returnPointer;
}


// double Get(vtkInformationDoubleVectorKey * key, int idx)
// "double Get(vtkInformationDoubleVectorKey* key, int idx)"
public double Get(vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ key, int /*(int)*/ idx) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkInformation.Get_11(returnPointer.GetPtr(), this, key, idx);
	return (double)returnPointer;
}


// void Get(vtkInformationDoubleVectorKey * key, double * value)
// "void Get(vtkInformationDoubleVectorKey* key, double* value)"
public void Get(vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ key, IntPtr /*(double*)*/ value) {
	VTK_API.API_vtkInformation.Get_12(this, key, value);
}


// int Length(vtkInformationDoubleVectorKey * key)
// "int Length(vtkInformationDoubleVectorKey* key)"
public int Length(vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Length_3(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Remove(vtkInformationDoubleVectorKey * key)
// "void Remove(vtkInformationDoubleVectorKey* key)"
public void Remove(vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_10(this, key);
}


// int Has(vtkInformationDoubleVectorKey * key)
// "int Has(vtkInformationDoubleVectorKey* key)"
public int Has(vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_10(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// int Length(vtkInformationVariantVectorKey * key)
// "int Length(vtkInformationVariantVectorKey* key)"
public int Length(vtkInformationVariantVectorKey /*(vtkInformationVariantVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Length_4(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Remove(vtkInformationVariantVectorKey * key)
// "void Remove(vtkInformationVariantVectorKey* key)"
public void Remove(vtkInformationVariantVectorKey /*(vtkInformationVariantVectorKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_11(this, key);
}


// int Has(vtkInformationVariantVectorKey * key)
// "int Has(vtkInformationVariantVectorKey* key)"
public int Has(vtkInformationVariantVectorKey /*(vtkInformationVariantVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_11(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Append(vtkInformationKeyVectorKey * key, vtkInformationKey * value)
// "void Append(vtkInformationKeyVectorKey* key, vtkInformationKey* value)"
public void Append(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationKey /*(vtkInformationKey*)*/ value) {
	VTK_API.API_vtkInformation.Append_4(this, key, value);
}


// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationKey * value)
// "void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationKey* value)"
public void AppendUnique(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationKey /*(vtkInformationKey*)*/ value) {
	VTK_API.API_vtkInformation.AppendUnique_0(this, key, value);
}


// void Set(vtkInformationKeyVectorKey * key, vtkInformationKey *const* value, int length)
// "void Set(vtkInformationKeyVectorKey* key, vtkInformationKey*const * value, int length)"
public void Set(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationKey /*(vtkInformationKey*const*)*/ value, int /*(int)*/ length) {
	VTK_API.API_vtkInformation.Set_13(this, key, value, length);
}


// void Remove(vtkInformationKeyVectorKey * key, vtkInformationKey * value)
// "void Remove(vtkInformationKeyVectorKey* key, vtkInformationKey* value)"
public void Remove(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationKey /*(vtkInformationKey*)*/ value) {
	VTK_API.API_vtkInformation.Remove_12(this, key, value);
}


// vtkInformationKey** Get(vtkInformationKeyVectorKey * key)
// "vtkInformationKey** Get(vtkInformationKeyVectorKey* key)"
public vtkInformationKey Get(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.Get_13(returnPointer.GetPtr(), this, key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// vtkInformationKey* Get(vtkInformationKeyVectorKey * key, int idx)
// "vtkInformationKey* Get(vtkInformationKeyVectorKey* key, int idx)"
public vtkInformationKey Get(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, int /*(int)*/ idx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.Get_14(returnPointer.GetPtr(), this, key, idx);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// void Get(vtkInformationKeyVectorKey * key, vtkInformationKey ** value)
// "void Get(vtkInformationKeyVectorKey* key, vtkInformationKey** value)"
public void Get(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationKey /*(vtkInformationKey**)*/ value) {
	VTK_API.API_vtkInformation.Get_15(this, key, value);
}


// int Length(vtkInformationKeyVectorKey * key)
// "int Length(vtkInformationKeyVectorKey* key)"
public int Length(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Length_5(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Remove(vtkInformationKeyVectorKey * key)
// "void Remove(vtkInformationKeyVectorKey* key)"
public void Remove(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_13(this, key);
}


// int Has(vtkInformationKeyVectorKey * key)
// "int Has(vtkInformationKeyVectorKey* key)"
public int Has(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_12(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Append(vtkInformationKeyVectorKey * key, vtkInformationDataObjectKey * value)
// "void Append(vtkInformationKeyVectorKey* key, vtkInformationDataObjectKey* value)"
public void Append(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationDataObjectKey /*(vtkInformationDataObjectKey*)*/ value) {
	VTK_API.API_vtkInformation.Append_5(this, key, value);
}


// void Append(vtkInformationKeyVectorKey * key, vtkInformationDoubleKey * value)
// "void Append(vtkInformationKeyVectorKey* key, vtkInformationDoubleKey* value)"
public void Append(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationDoubleKey /*(vtkInformationDoubleKey*)*/ value) {
	VTK_API.API_vtkInformation.Append_6(this, key, value);
}


// void Append(vtkInformationKeyVectorKey * key, vtkInformationDoubleVectorKey * value)
// "void Append(vtkInformationKeyVectorKey* key, vtkInformationDoubleVectorKey* value)"
public void Append(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ value) {
	VTK_API.API_vtkInformation.Append_7(this, key, value);
}


// void Append(vtkInformationKeyVectorKey * key, vtkInformationInformationKey * value)
// "void Append(vtkInformationKeyVectorKey* key, vtkInformationInformationKey* value)"
public void Append(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationInformationKey /*(vtkInformationInformationKey*)*/ value) {
	VTK_API.API_vtkInformation.Append_8(this, key, value);
}


// void Append(vtkInformationKeyVectorKey * key, vtkInformationInformationVectorKey * value)
// "void Append(vtkInformationKeyVectorKey* key, vtkInformationInformationVectorKey* value)"
public void Append(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationInformationVectorKey /*(vtkInformationInformationVectorKey*)*/ value) {
	VTK_API.API_vtkInformation.Append_9(this, key, value);
}


// void Append(vtkInformationKeyVectorKey * key, vtkInformationIntegerKey * value)
// "void Append(vtkInformationKeyVectorKey* key, vtkInformationIntegerKey* value)"
public void Append(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationIntegerKey /*(vtkInformationIntegerKey*)*/ value) {
	VTK_API.API_vtkInformation.Append_10(this, key, value);
}


// void Append(vtkInformationKeyVectorKey * key, vtkInformationIntegerVectorKey * value)
// "void Append(vtkInformationKeyVectorKey* key, vtkInformationIntegerVectorKey* value)"
public void Append(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ value) {
	VTK_API.API_vtkInformation.Append_11(this, key, value);
}


// void Append(vtkInformationKeyVectorKey * key, vtkInformationStringKey * value)
// "void Append(vtkInformationKeyVectorKey* key, vtkInformationStringKey* value)"
public void Append(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationStringKey /*(vtkInformationStringKey*)*/ value) {
	VTK_API.API_vtkInformation.Append_12(this, key, value);
}


// void Append(vtkInformationKeyVectorKey * key, vtkInformationStringVectorKey * value)
// "void Append(vtkInformationKeyVectorKey* key, vtkInformationStringVectorKey* value)"
public void Append(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationStringVectorKey /*(vtkInformationStringVectorKey*)*/ value) {
	VTK_API.API_vtkInformation.Append_13(this, key, value);
}


// void Append(vtkInformationKeyVectorKey * key, vtkInformationObjectBaseKey * value)
// "void Append(vtkInformationKeyVectorKey* key, vtkInformationObjectBaseKey* value)"
public void Append(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationObjectBaseKey /*(vtkInformationObjectBaseKey*)*/ value) {
	VTK_API.API_vtkInformation.Append_14(this, key, value);
}


// void Append(vtkInformationKeyVectorKey * key, vtkInformationUnsignedLongKey * value)
// "void Append(vtkInformationKeyVectorKey* key, vtkInformationUnsignedLongKey* value)"
public void Append(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationUnsignedLongKey /*(vtkInformationUnsignedLongKey*)*/ value) {
	VTK_API.API_vtkInformation.Append_15(this, key, value);
}


// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationDataObjectKey * value)
// "void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationDataObjectKey* value)"
public void AppendUnique(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationDataObjectKey /*(vtkInformationDataObjectKey*)*/ value) {
	VTK_API.API_vtkInformation.AppendUnique_1(this, key, value);
}


// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationDoubleKey * value)
// "void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationDoubleKey* value)"
public void AppendUnique(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationDoubleKey /*(vtkInformationDoubleKey*)*/ value) {
	VTK_API.API_vtkInformation.AppendUnique_2(this, key, value);
}


// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationDoubleVectorKey * value)
// "void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationDoubleVectorKey* value)"
public void AppendUnique(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ value) {
	VTK_API.API_vtkInformation.AppendUnique_3(this, key, value);
}


// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationInformationKey * value)
// "void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationInformationKey* value)"
public void AppendUnique(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationInformationKey /*(vtkInformationInformationKey*)*/ value) {
	VTK_API.API_vtkInformation.AppendUnique_4(this, key, value);
}


// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationInformationVectorKey * value)
// "void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationInformationVectorKey* value)"
public void AppendUnique(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationInformationVectorKey /*(vtkInformationInformationVectorKey*)*/ value) {
	VTK_API.API_vtkInformation.AppendUnique_5(this, key, value);
}


// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationIntegerKey * value)
// "void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationIntegerKey* value)"
public void AppendUnique(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationIntegerKey /*(vtkInformationIntegerKey*)*/ value) {
	VTK_API.API_vtkInformation.AppendUnique_6(this, key, value);
}


// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationIntegerVectorKey * value)
// "void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationIntegerVectorKey* value)"
public void AppendUnique(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ value) {
	VTK_API.API_vtkInformation.AppendUnique_7(this, key, value);
}


// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationStringKey * value)
// "void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationStringKey* value)"
public void AppendUnique(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationStringKey /*(vtkInformationStringKey*)*/ value) {
	VTK_API.API_vtkInformation.AppendUnique_8(this, key, value);
}


// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationStringVectorKey * value)
// "void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationStringVectorKey* value)"
public void AppendUnique(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationStringVectorKey /*(vtkInformationStringVectorKey*)*/ value) {
	VTK_API.API_vtkInformation.AppendUnique_9(this, key, value);
}


// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationObjectBaseKey * value)
// "void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationObjectBaseKey* value)"
public void AppendUnique(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationObjectBaseKey /*(vtkInformationObjectBaseKey*)*/ value) {
	VTK_API.API_vtkInformation.AppendUnique_10(this, key, value);
}


// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationUnsignedLongKey * value)
// "void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationUnsignedLongKey* value)"
public void AppendUnique(vtkInformationKeyVectorKey /*(vtkInformationKeyVectorKey*)*/ key, vtkInformationUnsignedLongKey /*(vtkInformationUnsignedLongKey*)*/ value) {
	VTK_API.API_vtkInformation.AppendUnique_11(this, key, value);
}


// void Set(vtkInformationStringKey * key, const char * ARG_0)
// "void Set(vtkInformationStringKey* key, const char*)"
public void Set(vtkInformationStringKey /*(vtkInformationStringKey*)*/ key, string /*(char*)*/ ARG_0) {
	VTK_API.API_vtkInformation.Set_14(this, key, ARG_0);
}


// char* Get(vtkInformationStringKey * key)
// "const char* Get(vtkInformationStringKey* key)"
public string Get(vtkInformationStringKey /*(vtkInformationStringKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.Get_16(returnPointer.GetPtr(), this, key);
	return (string)returnPointer;
}


// void Remove(vtkInformationStringKey * key)
// "void Remove(vtkInformationStringKey* key)"
public void Remove(vtkInformationStringKey /*(vtkInformationStringKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_14(this, key);
}


// int Has(vtkInformationStringKey * key)
// "int Has(vtkInformationStringKey* key)"
public int Has(vtkInformationStringKey /*(vtkInformationStringKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_13(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Set(vtkInformationInformationKey * key, vtkInformation * ARG_0)
// "void Set(vtkInformationInformationKey* key, vtkInformation*)"
public void Set(vtkInformationInformationKey /*(vtkInformationInformationKey*)*/ key, vtkInformation /*(vtkInformation*)*/ ARG_0) {
	VTK_API.API_vtkInformation.Set_15(this, key, ARG_0);
}


// vtkInformation* Get(vtkInformationInformationKey * key)
// "vtkInformation* Get(vtkInformationInformationKey* key)"
public vtkInformation Get(vtkInformationInformationKey /*(vtkInformationInformationKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.Get_17(returnPointer.GetPtr(), this, key);
	return (vtkInformation)(IntPtr)returnPointer;
}


// void Remove(vtkInformationInformationKey * key)
// "void Remove(vtkInformationInformationKey* key)"
public void Remove(vtkInformationInformationKey /*(vtkInformationInformationKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_15(this, key);
}


// int Has(vtkInformationInformationKey * key)
// "int Has(vtkInformationInformationKey* key)"
public int Has(vtkInformationInformationKey /*(vtkInformationInformationKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_14(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Set(vtkInformationInformationVectorKey * key, vtkInformationVector * ARG_0)
// "void Set(vtkInformationInformationVectorKey* key, vtkInformationVector*)"
public void Set(vtkInformationInformationVectorKey /*(vtkInformationInformationVectorKey*)*/ key, vtkInformationVector /*(vtkInformationVector*)*/ ARG_0) {
	VTK_API.API_vtkInformation.Set_16(this, key, ARG_0);
}


// vtkInformationVector* Get(vtkInformationInformationVectorKey * key)
// "vtkInformationVector* Get(vtkInformationInformationVectorKey* key)"
public vtkInformationVector Get(vtkInformationInformationVectorKey /*(vtkInformationInformationVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.Get_18(returnPointer.GetPtr(), this, key);
	return (vtkInformationVector)(IntPtr)returnPointer;
}


// void Remove(vtkInformationInformationVectorKey * key)
// "void Remove(vtkInformationInformationVectorKey* key)"
public void Remove(vtkInformationInformationVectorKey /*(vtkInformationInformationVectorKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_16(this, key);
}


// int Has(vtkInformationInformationVectorKey * key)
// "int Has(vtkInformationInformationVectorKey* key)"
public int Has(vtkInformationInformationVectorKey /*(vtkInformationInformationVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_15(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Set(vtkInformationObjectBaseKey * key, vtkObjectBase * ARG_0)
// "void Set(vtkInformationObjectBaseKey* key, vtkObjectBase*)"
public void Set(vtkInformationObjectBaseKey /*(vtkInformationObjectBaseKey*)*/ key, vtkObjectBase /*(vtkObjectBase*)*/ ARG_0) {
	VTK_API.API_vtkInformation.Set_17(this, key, ARG_0);
}


// vtkObjectBase* Get(vtkInformationObjectBaseKey * key)
// "vtkObjectBase* Get(vtkInformationObjectBaseKey* key)"
public vtkObjectBase Get(vtkInformationObjectBaseKey /*(vtkInformationObjectBaseKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.Get_19(returnPointer.GetPtr(), this, key);
	return (vtkObjectBase)(IntPtr)returnPointer;
}


// void Remove(vtkInformationObjectBaseKey * key)
// "void Remove(vtkInformationObjectBaseKey* key)"
public void Remove(vtkInformationObjectBaseKey /*(vtkInformationObjectBaseKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_17(this, key);
}


// int Has(vtkInformationObjectBaseKey * key)
// "int Has(vtkInformationObjectBaseKey* key)"
public int Has(vtkInformationObjectBaseKey /*(vtkInformationObjectBaseKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_16(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Append(vtkInformationObjectBaseVectorKey * key, vtkObjectBase * data)
// "void Append(vtkInformationObjectBaseVectorKey* key, vtkObjectBase *data)"
public void Append(vtkInformationObjectBaseVectorKey /*(vtkInformationObjectBaseVectorKey*)*/ key, vtkObjectBase /*(vtkObjectBase*)*/ data) {
	VTK_API.API_vtkInformation.Append_16(this, key, data);
}


// void Set(vtkInformationObjectBaseVectorKey * key, vtkObjectBase * value, int idx = 0)
// "void Set(vtkInformationObjectBaseVectorKey *key, vtkObjectBase* value, int idx = 0)"
public void Set(vtkInformationObjectBaseVectorKey /*(vtkInformationObjectBaseVectorKey*)*/ key, vtkObjectBase /*(vtkObjectBase*)*/ value, int /*(int)*/ idx) {
	VTK_API.API_vtkInformation.Set_18(this, key, value, idx);
}


// vtkObjectBase* Get(vtkInformationObjectBaseVectorKey * key, int idx = 0)
// "vtkObjectBase* Get(vtkInformationObjectBaseVectorKey *key, int idx = 0)"
public vtkObjectBase Get(vtkInformationObjectBaseVectorKey /*(vtkInformationObjectBaseVectorKey*)*/ key, int /*(int)*/ idx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.Get_20(returnPointer.GetPtr(), this, key, idx);
	return (vtkObjectBase)(IntPtr)returnPointer;
}


// int Length(vtkInformationObjectBaseVectorKey * key)
// "int Length(vtkInformationObjectBaseVectorKey *key)"
public int Length(vtkInformationObjectBaseVectorKey /*(vtkInformationObjectBaseVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Length_6(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Remove(vtkInformationObjectBaseVectorKey * key)
// "void Remove(vtkInformationObjectBaseVectorKey *key)"
public void Remove(vtkInformationObjectBaseVectorKey /*(vtkInformationObjectBaseVectorKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_18(this, key);
}


// void Remove(vtkInformationObjectBaseVectorKey * key, vtkObjectBase * objectToRemove)
// "void Remove(vtkInformationObjectBaseVectorKey *key, vtkObjectBase *objectToRemove)"
public void Remove(vtkInformationObjectBaseVectorKey /*(vtkInformationObjectBaseVectorKey*)*/ key, vtkObjectBase /*(vtkObjectBase*)*/ objectToRemove) {
	VTK_API.API_vtkInformation.Remove_19(this, key, objectToRemove);
}


// void Remove(vtkInformationObjectBaseVectorKey * key, int indexToRemove)
// "void Remove(vtkInformationObjectBaseVectorKey *key, int indexToRemove)"
public void Remove(vtkInformationObjectBaseVectorKey /*(vtkInformationObjectBaseVectorKey*)*/ key, int /*(int)*/ indexToRemove) {
	VTK_API.API_vtkInformation.Remove_20(this, key, indexToRemove);
}


// int Has(vtkInformationObjectBaseVectorKey * key)
// "int Has(vtkInformationObjectBaseVectorKey *key)"
public int Has(vtkInformationObjectBaseVectorKey /*(vtkInformationObjectBaseVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_17(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// void Set(vtkInformationDataObjectKey * key, vtkDataObject * ARG_0)
// "void Set(vtkInformationDataObjectKey* key, vtkDataObject *)"
public void Set(vtkInformationDataObjectKey /*(vtkInformationDataObjectKey*)*/ key, vtkDataObject /*(vtkDataObject*)*/ ARG_0) {
	VTK_API.API_vtkInformation.Set_19(this, key, ARG_0);
}


// void Remove(vtkInformationDataObjectKey * key)
// "void Remove(vtkInformationDataObjectKey* key)"
public void Remove(vtkInformationDataObjectKey /*(vtkInformationDataObjectKey*)*/ key) {
	VTK_API.API_vtkInformation.Remove_21(this, key);
}


// int Has(vtkInformationDataObjectKey * key)
// "int Has(vtkInformationDataObjectKey* key)"
public int Has(vtkInformationDataObjectKey /*(vtkInformationDataObjectKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformation.Has_18(returnPointer.GetPtr(), this, key);
	return (int)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationDataObjectKey * key)
// "static vtkInformationKey* GetKey(vtkInformationDataObjectKey* key)"
public static vtkInformationKey GetKey(vtkInformationDataObjectKey /*(vtkInformationDataObjectKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_0(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationDoubleKey * key)
// "static vtkInformationKey* GetKey(vtkInformationDoubleKey* key)"
public static vtkInformationKey GetKey(vtkInformationDoubleKey /*(vtkInformationDoubleKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_1(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationDoubleVectorKey * key)
// "static vtkInformationKey* GetKey(vtkInformationDoubleVectorKey* key)"
public static vtkInformationKey GetKey(vtkInformationDoubleVectorKey /*(vtkInformationDoubleVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_2(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationInformationKey * key)
// "static vtkInformationKey* GetKey(vtkInformationInformationKey* key)"
public static vtkInformationKey GetKey(vtkInformationInformationKey /*(vtkInformationInformationKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_3(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationInformationVectorKey * key)
// "static vtkInformationKey* GetKey(vtkInformationInformationVectorKey* key)"
public static vtkInformationKey GetKey(vtkInformationInformationVectorKey /*(vtkInformationInformationVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_4(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationIntegerKey * key)
// "static vtkInformationKey* GetKey(vtkInformationIntegerKey* key)"
public static vtkInformationKey GetKey(vtkInformationIntegerKey /*(vtkInformationIntegerKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_5(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationIntegerVectorKey * key)
// "static vtkInformationKey* GetKey(vtkInformationIntegerVectorKey* key)"
public static vtkInformationKey GetKey(vtkInformationIntegerVectorKey /*(vtkInformationIntegerVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_6(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationRequestKey * key)
// "static vtkInformationKey* GetKey(vtkInformationRequestKey* key)"
public static vtkInformationKey GetKey(vtkInformationRequestKey /*(vtkInformationRequestKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_7(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationStringKey * key)
// "static vtkInformationKey* GetKey(vtkInformationStringKey* key)"
public static vtkInformationKey GetKey(vtkInformationStringKey /*(vtkInformationStringKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_8(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationStringVectorKey * key)
// "static vtkInformationKey* GetKey(vtkInformationStringVectorKey* key)"
public static vtkInformationKey GetKey(vtkInformationStringVectorKey /*(vtkInformationStringVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_9(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationKey * key)
// "static vtkInformationKey* GetKey(vtkInformationKey* key)"
public static vtkInformationKey GetKey(vtkInformationKey /*(vtkInformationKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_10(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationUnsignedLongKey * key)
// "static vtkInformationKey* GetKey(vtkInformationUnsignedLongKey* key)"
public static vtkInformationKey GetKey(vtkInformationUnsignedLongKey /*(vtkInformationUnsignedLongKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_11(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationVariantKey * key)
// "static vtkInformationKey* GetKey(vtkInformationVariantKey* key)"
public static vtkInformationKey GetKey(vtkInformationVariantKey /*(vtkInformationVariantKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_12(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// static vtkInformationKey* GetKey(vtkInformationVariantVectorKey * key)
// "static vtkInformationKey* GetKey(vtkInformationVariantVectorKey* key)"
public static vtkInformationKey GetKey(vtkInformationVariantVectorKey /*(vtkInformationVariantVectorKey*)*/ key) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetKey_13(returnPointer.GetPtr(), key);
	return (vtkInformationKey)(IntPtr)returnPointer;
}


// void Register(vtkObjectBase * o)
// "void Register(vtkObjectBase* o)"
public void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkInformation.Register_0(this, o);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase* o)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkInformation.UnRegister_0(this, o);
}


// void SetRequest(vtkInformationRequestKey * request)
// "void SetRequest(vtkInformationRequestKey* request)"
public void SetRequest(vtkInformationRequestKey /*(vtkInformationRequestKey*)*/ request) {
	VTK_API.API_vtkInformation.SetRequest_0(this, request);
}


// vtkInformationRequestKey* GetRequest()
// "vtkInformationRequestKey* GetRequest()"
public vtkInformationRequestKey GetRequest() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformation.GetRequest_0(returnPointer.GetPtr(), this);
	return (vtkInformationRequestKey)(IntPtr)returnPointer;
}


}
};
