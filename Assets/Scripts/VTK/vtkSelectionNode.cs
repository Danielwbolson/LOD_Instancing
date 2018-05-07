

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkSelectionNode : vtkObject {
		public vtkSelectionNode(IntPtr p) : base(p) {}
		public static implicit operator  vtkSelectionNode(IntPtr p) {return new vtkSelectionNode(p);}
		public static implicit operator  IntPtr(vtkSelectionNode o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkSelectionNode.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkSelectionNode.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkSelectionNode* SafeDownCast(vtkObjectBase * o)
// "static vtkSelectionNode* SafeDownCast(vtkObjectBase *o)"
public static vtkSelectionNode SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkSelectionNode.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkSelectionNode)(IntPtr)returnPointer;
}


// vtkSelectionNode* NewInstance()
// "vtkSelectionNode *NewInstance()"
public vtkSelectionNode NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkSelectionNode.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkSelectionNode)(IntPtr)returnPointer;
}


// static vtkSelectionNode* New()
// "static vtkSelectionNode* New()"
public static vtkSelectionNode New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkSelectionNode.New_0(returnPointer.GetPtr());
	return (vtkSelectionNode)(IntPtr)returnPointer;
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	VTK_API.API_vtkSelectionNode.Initialize_0(this);
}


// virtual void SetSelectionList(vtkAbstractArray * ARG_0)
// "virtual void SetSelectionList(vtkAbstractArray*)"
public void SetSelectionList(vtkAbstractArray /*(vtkAbstractArray*)*/ ARG_0) {
	VTK_API.API_vtkSelectionNode.SetSelectionList_0(this, ARG_0);
}


// virtual vtkAbstractArray* GetSelectionList()
// "virtual vtkAbstractArray* GetSelectionList()"
public vtkAbstractArray GetSelectionList() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkSelectionNode.GetSelectionList_0(returnPointer.GetPtr(), this);
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// virtual void SetSelectionData(vtkDataSetAttributes * data)
// "virtual void SetSelectionData(vtkDataSetAttributes* data)"
public void SetSelectionData(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ data) {
	VTK_API.API_vtkSelectionNode.SetSelectionData_0(this, data);
}


// virtual vtkDataSetAttributes* GetSelectionData()
// "virtual vtkDataSetAttributes *GetSelectionData ()"
public vtkDataSetAttributes GetSelectionData() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkSelectionNode.GetSelectionData_0(returnPointer.GetPtr(), this);
	return (vtkDataSetAttributes)(IntPtr)returnPointer;
}


// virtual void DeepCopy(vtkSelectionNode * src)
// "virtual void DeepCopy(vtkSelectionNode* src)"
public void DeepCopy(vtkSelectionNode /*(vtkSelectionNode*)*/ src) {
	VTK_API.API_vtkSelectionNode.DeepCopy_0(this, src);
}


// virtual void ShallowCopy(vtkSelectionNode * src)
// "virtual void ShallowCopy(vtkSelectionNode* src)"
public void ShallowCopy(vtkSelectionNode /*(vtkSelectionNode*)*/ src) {
	VTK_API.API_vtkSelectionNode.ShallowCopy_0(this, src);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkSelectionNode.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual void SetContentType(int type)
// "virtual void SetContentType(int type)"
public void SetContentType(int /*(int)*/ type) {
	VTK_API.API_vtkSelectionNode.SetContentType_0(this, type);
}


// virtual int GetContentType()
// "virtual int GetContentType()"
public int GetContentType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkSelectionNode.GetContentType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetFieldType(int type)
// "virtual void SetFieldType(int type)"
public void SetFieldType(int /*(int)*/ type) {
	VTK_API.API_vtkSelectionNode.SetFieldType_0(this, type);
}


// virtual int GetFieldType()
// "virtual int GetFieldType()"
public int GetFieldType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkSelectionNode.GetFieldType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// static int ConvertSelectionFieldToAttributeType(int val)
// "static int ConvertSelectionFieldToAttributeType(int val)"
public static int ConvertSelectionFieldToAttributeType(int /*(int)*/ val) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkSelectionNode.ConvertSelectionFieldToAttributeType_0(returnPointer.GetPtr(), val);
	return (int)returnPointer;
}


// static int ConvertAttributeTypeToSelectionField(int val)
// "static int ConvertAttributeTypeToSelectionField(int val)"
public static int ConvertAttributeTypeToSelectionField(int /*(int)*/ val) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkSelectionNode.ConvertAttributeTypeToSelectionField_0(returnPointer.GetPtr(), val);
	return (int)returnPointer;
}


// virtual void SetQueryString(const char * _arg)
// "virtual void SetQueryString (const char* _arg)"
public void SetQueryString(string /*(char*)*/ _arg) {
	VTK_API.API_vtkSelectionNode.SetQueryString_0(this, _arg);
}


// virtual char* GetQueryString()
// "virtual char* GetQueryString ()"
public string GetQueryString() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkSelectionNode.GetQueryString_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// void UnionSelectionList(vtkSelectionNode * other)
// "void UnionSelectionList(vtkSelectionNode* other)"
public void UnionSelectionList(vtkSelectionNode /*(vtkSelectionNode*)*/ other) {
	VTK_API.API_vtkSelectionNode.UnionSelectionList_0(this, other);
}


// void SubtractSelectionList(vtkSelectionNode * other)
// "void SubtractSelectionList(vtkSelectionNode* other)"
public void SubtractSelectionList(vtkSelectionNode /*(vtkSelectionNode*)*/ other) {
	VTK_API.API_vtkSelectionNode.SubtractSelectionList_0(this, other);
}


// bool EqualProperties(vtkSelectionNode * other, bool fullcompare = true)
// "bool EqualProperties(vtkSelectionNode* other, bool fullcompare=true)"
public bool EqualProperties(vtkSelectionNode /*(vtkSelectionNode*)*/ other, bool /*(bool)*/ fullcompare) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkSelectionNode.EqualProperties_0(returnPointer.GetPtr(), this, other, fullcompare);
	return (bool)returnPointer;
}


}
};
