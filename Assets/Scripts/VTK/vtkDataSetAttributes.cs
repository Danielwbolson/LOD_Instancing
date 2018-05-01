

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataSetAttributes : vtkFieldData {

// static vtkDataSetAttributes* New()
// "static vtkDataSetAttributes *New()"
public new static vtkDataSetAttributes New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// void Initialize()
// "void Initialize()"
public new void Initialize() {
	API_vtkDataSetAttributes.Initialize_0(this);
}


// virtual void Update()
// "virtual void Update()"
public new void Update() {
	API_vtkDataSetAttributes.Update_0(this);
}


// void DeepCopy(vtkFieldData * pd)
// "void DeepCopy(vtkFieldData *pd)"
public new void DeepCopy(vtkFieldData /*(vtkFieldData*)*/ pd) {
	API_vtkDataSetAttributes.DeepCopy_0(this, pd);
}


// void ShallowCopy(vtkFieldData * pd)
// "void ShallowCopy(vtkFieldData *pd)"
public new void ShallowCopy(vtkFieldData /*(vtkFieldData*)*/ pd) {
	API_vtkDataSetAttributes.ShallowCopy_0(this, pd);
}


// static char* GhostArrayName()
// "static const char* GhostArrayName()"
public new static char GhostArrayName() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkDataSetAttributes.GhostArrayName_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// int SetScalars(vtkDataArray * da)
// "int SetScalars(vtkDataArray* da)"
public new int SetScalars(vtkDataArray /*(vtkDataArray*)*/ da) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetScalars_0(this, returnPointer, da);
	return Ptr.deref(returnPointer);
}


// int SetActiveScalars(const char * name)
// "int SetActiveScalars(const char* name)"
public new int SetActiveScalars(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetActiveScalars_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetScalars()
// "vtkDataArray* GetScalars()"
public new vtkDataArray GetScalars() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetScalars_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int SetVectors(vtkDataArray * da)
// "int SetVectors(vtkDataArray* da)"
public new int SetVectors(vtkDataArray /*(vtkDataArray*)*/ da) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetVectors_0(this, returnPointer, da);
	return Ptr.deref(returnPointer);
}


// int SetActiveVectors(const char * name)
// "int SetActiveVectors(const char* name)"
public new int SetActiveVectors(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetActiveVectors_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetVectors()
// "vtkDataArray* GetVectors()"
public new vtkDataArray GetVectors() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetVectors_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int SetNormals(vtkDataArray * da)
// "int SetNormals(vtkDataArray* da)"
public new int SetNormals(vtkDataArray /*(vtkDataArray*)*/ da) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetNormals_0(this, returnPointer, da);
	return Ptr.deref(returnPointer);
}


// int SetActiveNormals(const char * name)
// "int SetActiveNormals(const char* name)"
public new int SetActiveNormals(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetActiveNormals_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetNormals()
// "vtkDataArray* GetNormals()"
public new vtkDataArray GetNormals() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetNormals_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int SetTCoords(vtkDataArray * da)
// "int SetTCoords(vtkDataArray* da)"
public new int SetTCoords(vtkDataArray /*(vtkDataArray*)*/ da) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetTCoords_0(this, returnPointer, da);
	return Ptr.deref(returnPointer);
}


// int SetActiveTCoords(const char * name)
// "int SetActiveTCoords(const char* name)"
public new int SetActiveTCoords(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetActiveTCoords_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetTCoords()
// "vtkDataArray* GetTCoords()"
public new vtkDataArray GetTCoords() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetTCoords_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int SetTensors(vtkDataArray * da)
// "int SetTensors(vtkDataArray* da)"
public new int SetTensors(vtkDataArray /*(vtkDataArray*)*/ da) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetTensors_0(this, returnPointer, da);
	return Ptr.deref(returnPointer);
}


// int SetActiveTensors(const char * name)
// "int SetActiveTensors(const char* name)"
public new int SetActiveTensors(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetActiveTensors_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetTensors()
// "vtkDataArray* GetTensors()"
public new vtkDataArray GetTensors() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetTensors_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int SetGlobalIds(vtkDataArray * da)
// "int SetGlobalIds(vtkDataArray* da)"
public new int SetGlobalIds(vtkDataArray /*(vtkDataArray*)*/ da) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetGlobalIds_0(this, returnPointer, da);
	return Ptr.deref(returnPointer);
}


// int SetActiveGlobalIds(const char * name)
// "int SetActiveGlobalIds(const char* name)"
public new int SetActiveGlobalIds(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetActiveGlobalIds_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetGlobalIds()
// "vtkDataArray* GetGlobalIds()"
public new vtkDataArray GetGlobalIds() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetGlobalIds_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int SetPedigreeIds(vtkAbstractArray * da)
// "int SetPedigreeIds(vtkAbstractArray* da)"
public new int SetPedigreeIds(vtkAbstractArray /*(vtkAbstractArray*)*/ da) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetPedigreeIds_0(this, returnPointer, da);
	return Ptr.deref(returnPointer);
}


// int SetActivePedigreeIds(const char * name)
// "int SetActivePedigreeIds(const char* name)"
public new int SetActivePedigreeIds(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetActivePedigreeIds_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkAbstractArray* GetPedigreeIds()
// "vtkAbstractArray* GetPedigreeIds()"
public new vtkAbstractArray GetPedigreeIds() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetPedigreeIds_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetScalars(const char * name)
// "vtkDataArray* GetScalars(const char* name)"
public new vtkDataArray GetScalars(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetScalars_1(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetVectors(const char * name)
// "vtkDataArray* GetVectors(const char* name)"
public new vtkDataArray GetVectors(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetVectors_1(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetNormals(const char * name)
// "vtkDataArray* GetNormals(const char* name)"
public new vtkDataArray GetNormals(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetNormals_1(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetTCoords(const char * name)
// "vtkDataArray* GetTCoords(const char* name)"
public new vtkDataArray GetTCoords(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetTCoords_1(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetTensors(const char * name)
// "vtkDataArray* GetTensors(const char* name)"
public new vtkDataArray GetTensors(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetTensors_1(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetGlobalIds(const char * name)
// "vtkDataArray* GetGlobalIds(const char* name)"
public new vtkDataArray GetGlobalIds(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetGlobalIds_1(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkAbstractArray* GetPedigreeIds(const char * name)
// "vtkAbstractArray* GetPedigreeIds(const char* name)"
public new vtkAbstractArray GetPedigreeIds(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetPedigreeIds_1(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// int SetActiveAttribute(const char * name, int attributeType)
// "int SetActiveAttribute(const char* name, int attributeType)"
public new int SetActiveAttribute(char /*(char*)*/ []name, int /*(int)*/ attributeType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetActiveAttribute_0(this, returnPointer, name, attributeType);
	return Ptr.deref(returnPointer);
}


// int SetActiveAttribute(int index, int attributeType)
// "int SetActiveAttribute(int index, int attributeType)"
public new int SetActiveAttribute(int /*(int)*/ index, int /*(int)*/ attributeType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetActiveAttribute_1(this, returnPointer, index, attributeType);
	return Ptr.deref(returnPointer);
}


// void GetAttributeIndices(int * indexArray)
// "void GetAttributeIndices(int* indexArray)"
public new void GetAttributeIndices(int /*(int*)*/ []indexArray) {
	API_vtkDataSetAttributes.GetAttributeIndices_0(this, indexArray);
}


// int IsArrayAnAttribute(int idx)
// "int IsArrayAnAttribute(int idx)"
public new int IsArrayAnAttribute(int /*(int)*/ idx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.IsArrayAnAttribute_0(this, returnPointer, idx);
	return Ptr.deref(returnPointer);
}


// int SetAttribute(vtkAbstractArray * aa, int attributeType)
// "int SetAttribute(vtkAbstractArray* aa, int attributeType)"
public new int SetAttribute(vtkAbstractArray /*(vtkAbstractArray*)*/ aa, int /*(int)*/ attributeType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.SetAttribute_0(this, returnPointer, aa, attributeType);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetAttribute(int attributeType)
// "vtkDataArray* GetAttribute(int attributeType)"
public new vtkDataArray GetAttribute(int /*(int)*/ attributeType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetAttribute_0(this, returnPointer, attributeType);
	return Ptr.deref(returnPointer);
}


// vtkAbstractArray* GetAbstractAttribute(int attributeType)
// "vtkAbstractArray* GetAbstractAttribute(int attributeType)"
public new vtkAbstractArray GetAbstractAttribute(int /*(int)*/ attributeType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSetAttributes.GetAbstractAttribute_0(this, returnPointer, attributeType);
	return Ptr.deref(returnPointer);
}


// void RemoveArray(int index)
// "void RemoveArray(int index)"
public new void RemoveArray(int /*(int)*/ index) {
	API_vtkDataSetAttributes.RemoveArray_0(this, index);
}


// static char* GetAttributeTypeAsString(int attributeType)
// "static const char* GetAttributeTypeAsString(int attributeType)"
public new static char GetAttributeTypeAsString(int /*(int)*/ attributeType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkDataSetAttributes.GetAttributeTypeAsString_0(returnPointer, attributeType);
	return Ptr.deref(returnPointer);
}


// static char* GetLongAttributeTypeAsString(int attributeType)
// "static const char* GetLongAttributeTypeAsString(int attributeType)"
public new static char GetLongAttributeTypeAsString(int /*(int)*/ attributeType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkDataSetAttributes.GetLongAttributeTypeAsString_0(returnPointer, attributeType);
	return Ptr.deref(returnPointer);
}


// int GetCopyAttribute(int index, int ctype)
// "int GetCopyAttribute (int index, int ctype)"
public new int GetCopyAttribute(int /*(int)*/ index, int /*(int)*/ ctype) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSetAttributes.GetCopyAttribute_0(this, returnPointer, index, ctype);
	return Ptr.deref(returnPointer);
}


// void PassData(vtkFieldData * fd)
// "void PassData(vtkFieldData* fd)"
public new void PassData(vtkFieldData /*(vtkFieldData*)*/ fd) {
	API_vtkDataSetAttributes.PassData_0(this, fd);
}


// void CopyAllocate(vtkDataSetAttributes * pd, vtkIdType sze = 0, vtkIdType ext = 1000)
// "void CopyAllocate(vtkDataSetAttributes* pd, vtkIdType sze=0, vtkIdType ext=1000)"
public new void CopyAllocate(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ pd, long /*(vtkIdType)*/ sze, long /*(vtkIdType)*/ ext) {
	API_vtkDataSetAttributes.CopyAllocate_0(this, pd, sze, ext);
}


// void CopyAllocate(vtkDataSetAttributes * pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)
// "void CopyAllocate(vtkDataSetAttributes* pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)"
public new void CopyAllocate(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ pd, long /*(vtkIdType)*/ sze, long /*(vtkIdType)*/ ext, int /*(int)*/ shallowCopyArrays) {
	API_vtkDataSetAttributes.CopyAllocate_1(this, pd, sze, ext, shallowCopyArrays);
}


// void SetupForCopy(vtkDataSetAttributes * pd)
// "void SetupForCopy(vtkDataSetAttributes* pd)"
public new void SetupForCopy(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ pd) {
	API_vtkDataSetAttributes.SetupForCopy_0(this, pd);
}


// void CopyStructuredData(vtkDataSetAttributes * inDsa, const int * inExt, const int * outExt, bool setSize = true)
// "void CopyStructuredData(vtkDataSetAttributes *inDsa, const int *inExt, const int *outExt, bool setSize = true)"
public new void CopyStructuredData(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ inDsa, int /*(int*)*/ []inExt, int /*(int*)*/ []outExt, bool /*(bool)*/ setSize) {
	API_vtkDataSetAttributes.CopyStructuredData_0(this, inDsa, inExt, outExt, setSize);
}


// void CopyData(vtkDataSetAttributes * fromPd, vtkIdType fromId, vtkIdType toId)
// "void CopyData(vtkDataSetAttributes *fromPd, vtkIdType fromId, vtkIdType toId)"
public new void CopyData(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ fromPd, long /*(vtkIdType)*/ fromId, long /*(vtkIdType)*/ toId) {
	API_vtkDataSetAttributes.CopyData_0(this, fromPd, fromId, toId);
}


// void CopyData(vtkDataSetAttributes * fromPd, vtkIdList * fromIds, vtkIdList * toIds)
// "void CopyData(vtkDataSetAttributes *fromPd, vtkIdList *fromIds, vtkIdList *toIds)"
public new void CopyData(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ fromPd, vtkIdList /*(vtkIdList*)*/ fromIds, vtkIdList /*(vtkIdList*)*/ toIds) {
	API_vtkDataSetAttributes.CopyData_1(this, fromPd, fromIds, toIds);
}


// void CopyData(vtkDataSetAttributes * fromPd, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
// "void CopyData(vtkDataSetAttributes *fromPd, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)"
public new void CopyData(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ fromPd, long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart) {
	API_vtkDataSetAttributes.CopyData_2(this, fromPd, dstStart, n, srcStart);
}


// void CopyTuple(vtkAbstractArray * fromData, vtkAbstractArray * toData, vtkIdType fromId, vtkIdType toId)
// "void CopyTuple(vtkAbstractArray *fromData, vtkAbstractArray *toData, vtkIdType fromId, vtkIdType toId)"
public new void CopyTuple(vtkAbstractArray /*(vtkAbstractArray*)*/ fromData, vtkAbstractArray /*(vtkAbstractArray*)*/ toData, long /*(vtkIdType)*/ fromId, long /*(vtkIdType)*/ toId) {
	API_vtkDataSetAttributes.CopyTuple_0(this, fromData, toData, fromId, toId);
}


// void CopyTuples(vtkAbstractArray * fromData, vtkAbstractArray * toData, vtkIdList * fromIds, vtkIdList * toIds)
// "void CopyTuples(vtkAbstractArray *fromData, vtkAbstractArray *toData, vtkIdList *fromIds, vtkIdList *toIds)"
public new void CopyTuples(vtkAbstractArray /*(vtkAbstractArray*)*/ fromData, vtkAbstractArray /*(vtkAbstractArray*)*/ toData, vtkIdList /*(vtkIdList*)*/ fromIds, vtkIdList /*(vtkIdList*)*/ toIds) {
	API_vtkDataSetAttributes.CopyTuples_0(this, fromData, toData, fromIds, toIds);
}


// void CopyTuples(vtkAbstractArray * fromData, vtkAbstractArray * toData, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
// "void CopyTuples(vtkAbstractArray *fromData, vtkAbstractArray *toData, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)"
public new void CopyTuples(vtkAbstractArray /*(vtkAbstractArray*)*/ fromData, vtkAbstractArray /*(vtkAbstractArray*)*/ toData, long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart) {
	API_vtkDataSetAttributes.CopyTuples_1(this, fromData, toData, dstStart, n, srcStart);
}


// void InterpolateAllocate(vtkDataSetAttributes * pd, vtkIdType sze = 0, vtkIdType ext = 1000)
// "void InterpolateAllocate(vtkDataSetAttributes* pd, vtkIdType sze=0, vtkIdType ext=1000)"
public new void InterpolateAllocate(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ pd, long /*(vtkIdType)*/ sze, long /*(vtkIdType)*/ ext) {
	API_vtkDataSetAttributes.InterpolateAllocate_0(this, pd, sze, ext);
}


// void InterpolateAllocate(vtkDataSetAttributes * pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)
// "void InterpolateAllocate(vtkDataSetAttributes* pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)"
public new void InterpolateAllocate(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ pd, long /*(vtkIdType)*/ sze, long /*(vtkIdType)*/ ext, int /*(int)*/ shallowCopyArrays) {
	API_vtkDataSetAttributes.InterpolateAllocate_1(this, pd, sze, ext, shallowCopyArrays);
}


// void InterpolatePoint(vtkDataSetAttributes * fromPd, vtkIdType toId, vtkIdList * ids, double * weights)
// "void InterpolatePoint(vtkDataSetAttributes *fromPd, vtkIdType toId, vtkIdList *ids, double *weights)"
public new void InterpolatePoint(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ fromPd, long /*(vtkIdType)*/ toId, vtkIdList /*(vtkIdList*)*/ ids, double /*(double*)*/ []weights) {
	API_vtkDataSetAttributes.InterpolatePoint_0(this, fromPd, toId, ids, weights);
}


// void InterpolateEdge(vtkDataSetAttributes * fromPd, vtkIdType toId, vtkIdType p1, vtkIdType p2, double t)
// "void InterpolateEdge(vtkDataSetAttributes *fromPd, vtkIdType toId, vtkIdType p1, vtkIdType p2, double t)"
public new void InterpolateEdge(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ fromPd, long /*(vtkIdType)*/ toId, long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, double /*(double)*/ t) {
	API_vtkDataSetAttributes.InterpolateEdge_0(this, fromPd, toId, p1, p2, t);
}


// void InterpolateTime(vtkDataSetAttributes * from1, vtkDataSetAttributes * from2, vtkIdType id, double t)
// "void InterpolateTime(vtkDataSetAttributes *from1, vtkDataSetAttributes *from2, vtkIdType id, double t)"
public new void InterpolateTime(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ from1, vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ from2, long /*(vtkIdType)*/ id, double /*(double)*/ t) {
	API_vtkDataSetAttributes.InterpolateTime_0(this, from1, from2, id, t);
}


}
};
