

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkSelection : vtkDataObject {
		public vtkSelection(IntPtr p) : base(p) {}
		public static implicit operator  vtkSelection(IntPtr p) {return new vtkSelection(p);}
		public static implicit operator  IntPtr(vtkSelection o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkSelection.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkSelection.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkSelection* SafeDownCast(vtkObjectBase * o)
// "static vtkSelection* SafeDownCast(vtkObjectBase *o)"
public static vtkSelection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkSelection.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkSelection)(IntPtr)returnPointer;
}


// vtkSelection* NewInstance()
// "vtkSelection *NewInstance()"
public vtkSelection NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkSelection.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkSelection)(IntPtr)returnPointer;
}


// static vtkSelection* New()
// "static vtkSelection* New()"
public static vtkSelection New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkSelection.New_0(returnPointer.GetPtr());
	return (vtkSelection)(IntPtr)returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkSelection.Initialize_0(this);
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkSelection.GetDataObjectType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetNumberOfNodes()
// "unsigned int GetNumberOfNodes()"
public uint GetNumberOfNodes() {
	ReturnPointer returnPointer = new ReturnPointer(new uint());
	VTK_API.API_vtkSelection.GetNumberOfNodes_0(returnPointer.GetPtr(), this);
	return (uint)returnPointer;
}


// virtual vtkSelectionNode* GetNode(unsigned int idx)
// "virtual vtkSelectionNode* GetNode(unsigned int idx)"
public vtkSelectionNode GetNode(uint /*(unsigned int)*/ idx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkSelection.GetNode_0(returnPointer.GetPtr(), this, idx);
	return (vtkSelectionNode)(IntPtr)returnPointer;
}


// virtual void AddNode(vtkSelectionNode * ARG_0)
// "virtual void AddNode(vtkSelectionNode*)"
public void AddNode(vtkSelectionNode /*(vtkSelectionNode*)*/ ARG_0) {
	VTK_API.API_vtkSelection.AddNode_0(this, ARG_0);
}


// virtual void RemoveNode(unsigned int idx)
// "virtual void RemoveNode(unsigned int idx)"
public void RemoveNode(uint /*(unsigned int)*/ idx) {
	VTK_API.API_vtkSelection.RemoveNode_0(this, idx);
}


// virtual void RemoveNode(vtkSelectionNode * ARG_0)
// "virtual void RemoveNode(vtkSelectionNode*)"
public void RemoveNode(vtkSelectionNode /*(vtkSelectionNode*)*/ ARG_0) {
	VTK_API.API_vtkSelection.RemoveNode_1(this, ARG_0);
}


// virtual void RemoveAllNodes()
// "virtual void RemoveAllNodes()"
public void RemoveAllNodes() {
	VTK_API.API_vtkSelection.RemoveAllNodes_0(this);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject* src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkSelection.DeepCopy_0(this, src);
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject* src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkSelection.ShallowCopy_0(this, src);
}


// virtual void Union(vtkSelection * selection)
// "virtual void Union(vtkSelection* selection)"
public void Union(vtkSelection /*(vtkSelection*)*/ selection) {
	VTK_API.API_vtkSelection.Union_0(this, selection);
}


// virtual void Union(vtkSelectionNode * node)
// "virtual void Union(vtkSelectionNode* node)"
public void Union(vtkSelectionNode /*(vtkSelectionNode*)*/ node) {
	VTK_API.API_vtkSelection.Union_1(this, node);
}


// virtual void Subtract(vtkSelection * selection)
// "virtual void Subtract(vtkSelection* selection)"
public void Subtract(vtkSelection /*(vtkSelection*)*/ selection) {
	VTK_API.API_vtkSelection.Subtract_0(this, selection);
}


// virtual void Subtract(vtkSelectionNode * node)
// "virtual void Subtract(vtkSelectionNode* node)"
public void Subtract(vtkSelectionNode /*(vtkSelectionNode*)*/ node) {
	VTK_API.API_vtkSelection.Subtract_1(this, node);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkSelection.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual void Dump()
// "virtual void Dump()"
public void Dump() {
	VTK_API.API_vtkSelection.Dump_0(this);
}


}
};
