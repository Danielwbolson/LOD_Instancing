

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataSetAttributes : vtkFieldData {
		public vtkDataSetAttributes(IntPtr p) : base(p) {}
		public static implicit operator  vtkDataSetAttributes(IntPtr p) {return new vtkDataSetAttributes(p);}
		public static implicit operator  IntPtr(vtkDataSetAttributes o) {return o.GetPtr();}

// static vtkDataSetAttributes* New()
// "static vtkDataSetAttributes *New()"
public static vtkDataSetAttributes New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.New_0(returnPointer.GetPtr());
	return (vtkDataSetAttributes)(IntPtr)returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	API_vtkDataSetAttributes.Initialize_0(this);
}


// virtual void Update()
// "virtual void Update()"
public void Update() {
	API_vtkDataSetAttributes.Update_0(this);
}


// void DeepCopy(vtkFieldData * pd)
// "void DeepCopy(vtkFieldData *pd)"
public void DeepCopy(vtkFieldData /*(vtkFieldData*)*/ pd) {
	API_vtkDataSetAttributes.DeepCopy_0(this, pd);
}


// void ShallowCopy(vtkFieldData * pd)
// "void ShallowCopy(vtkFieldData *pd)"
public void ShallowCopy(vtkFieldData /*(vtkFieldData*)*/ pd) {
	API_vtkDataSetAttributes.ShallowCopy_0(this, pd);
}


// static char* GhostArrayName()
// "static const char* GhostArrayName()"
public static string GhostArrayName() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GhostArrayName_0(returnPointer.GetPtr());
	return (string)returnPointer;
}


// int SetScalars(vtkDataArray * da)
// "int SetScalars(vtkDataArray* da)"
public int SetScalars(vtkDataArray /*(vtkDataArray*)*/ da) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetScalars_0(returnPointer.GetPtr(), this, da);
	return (int)returnPointer;
}


// int SetActiveScalars(const char * name)
// "int SetActiveScalars(const char* name)"
public int SetActiveScalars(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetActiveScalars_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// vtkDataArray* GetScalars()
// "vtkDataArray* GetScalars()"
public vtkDataArray GetScalars() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetScalars_0(returnPointer.GetPtr(), this);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// int SetVectors(vtkDataArray * da)
// "int SetVectors(vtkDataArray* da)"
public int SetVectors(vtkDataArray /*(vtkDataArray*)*/ da) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetVectors_0(returnPointer.GetPtr(), this, da);
	return (int)returnPointer;
}


// int SetActiveVectors(const char * name)
// "int SetActiveVectors(const char* name)"
public int SetActiveVectors(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetActiveVectors_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// vtkDataArray* GetVectors()
// "vtkDataArray* GetVectors()"
public vtkDataArray GetVectors() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetVectors_0(returnPointer.GetPtr(), this);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// int SetNormals(vtkDataArray * da)
// "int SetNormals(vtkDataArray* da)"
public int SetNormals(vtkDataArray /*(vtkDataArray*)*/ da) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetNormals_0(returnPointer.GetPtr(), this, da);
	return (int)returnPointer;
}


// int SetActiveNormals(const char * name)
// "int SetActiveNormals(const char* name)"
public int SetActiveNormals(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetActiveNormals_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// vtkDataArray* GetNormals()
// "vtkDataArray* GetNormals()"
public vtkDataArray GetNormals() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetNormals_0(returnPointer.GetPtr(), this);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// int SetTCoords(vtkDataArray * da)
// "int SetTCoords(vtkDataArray* da)"
public int SetTCoords(vtkDataArray /*(vtkDataArray*)*/ da) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetTCoords_0(returnPointer.GetPtr(), this, da);
	return (int)returnPointer;
}


// int SetActiveTCoords(const char * name)
// "int SetActiveTCoords(const char* name)"
public int SetActiveTCoords(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetActiveTCoords_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// vtkDataArray* GetTCoords()
// "vtkDataArray* GetTCoords()"
public vtkDataArray GetTCoords() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetTCoords_0(returnPointer.GetPtr(), this);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// int SetTensors(vtkDataArray * da)
// "int SetTensors(vtkDataArray* da)"
public int SetTensors(vtkDataArray /*(vtkDataArray*)*/ da) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetTensors_0(returnPointer.GetPtr(), this, da);
	return (int)returnPointer;
}


// int SetActiveTensors(const char * name)
// "int SetActiveTensors(const char* name)"
public int SetActiveTensors(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetActiveTensors_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// vtkDataArray* GetTensors()
// "vtkDataArray* GetTensors()"
public vtkDataArray GetTensors() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetTensors_0(returnPointer.GetPtr(), this);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// int SetGlobalIds(vtkDataArray * da)
// "int SetGlobalIds(vtkDataArray* da)"
public int SetGlobalIds(vtkDataArray /*(vtkDataArray*)*/ da) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetGlobalIds_0(returnPointer.GetPtr(), this, da);
	return (int)returnPointer;
}


// int SetActiveGlobalIds(const char * name)
// "int SetActiveGlobalIds(const char* name)"
public int SetActiveGlobalIds(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetActiveGlobalIds_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// vtkDataArray* GetGlobalIds()
// "vtkDataArray* GetGlobalIds()"
public vtkDataArray GetGlobalIds() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetGlobalIds_0(returnPointer.GetPtr(), this);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// int SetPedigreeIds(vtkAbstractArray * da)
// "int SetPedigreeIds(vtkAbstractArray* da)"
public int SetPedigreeIds(vtkAbstractArray /*(vtkAbstractArray*)*/ da) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetPedigreeIds_0(returnPointer.GetPtr(), this, da);
	return (int)returnPointer;
}


// int SetActivePedigreeIds(const char * name)
// "int SetActivePedigreeIds(const char* name)"
public int SetActivePedigreeIds(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetActivePedigreeIds_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// vtkAbstractArray* GetPedigreeIds()
// "vtkAbstractArray* GetPedigreeIds()"
public vtkAbstractArray GetPedigreeIds() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetPedigreeIds_0(returnPointer.GetPtr(), this);
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// vtkDataArray* GetScalars(const char * name)
// "vtkDataArray* GetScalars(const char* name)"
public vtkDataArray GetScalars(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetScalars_1(returnPointer.GetPtr(), this, name);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkDataArray* GetVectors(const char * name)
// "vtkDataArray* GetVectors(const char* name)"
public vtkDataArray GetVectors(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetVectors_1(returnPointer.GetPtr(), this, name);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkDataArray* GetNormals(const char * name)
// "vtkDataArray* GetNormals(const char* name)"
public vtkDataArray GetNormals(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetNormals_1(returnPointer.GetPtr(), this, name);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkDataArray* GetTCoords(const char * name)
// "vtkDataArray* GetTCoords(const char* name)"
public vtkDataArray GetTCoords(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetTCoords_1(returnPointer.GetPtr(), this, name);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkDataArray* GetTensors(const char * name)
// "vtkDataArray* GetTensors(const char* name)"
public vtkDataArray GetTensors(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetTensors_1(returnPointer.GetPtr(), this, name);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkDataArray* GetGlobalIds(const char * name)
// "vtkDataArray* GetGlobalIds(const char* name)"
public vtkDataArray GetGlobalIds(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetGlobalIds_1(returnPointer.GetPtr(), this, name);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkAbstractArray* GetPedigreeIds(const char * name)
// "vtkAbstractArray* GetPedigreeIds(const char* name)"
public vtkAbstractArray GetPedigreeIds(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetPedigreeIds_1(returnPointer.GetPtr(), this, name);
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// int SetActiveAttribute(const char * name, int attributeType)
// "int SetActiveAttribute(const char* name, int attributeType)"
public int SetActiveAttribute(string /*(char*)*/ name, int /*(int)*/ attributeType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetActiveAttribute_0(returnPointer.GetPtr(), this, name, attributeType);
	return (int)returnPointer;
}


// int SetActiveAttribute(int index, int attributeType)
// "int SetActiveAttribute(int index, int attributeType)"
public int SetActiveAttribute(int /*(int)*/ index, int /*(int)*/ attributeType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetActiveAttribute_1(returnPointer.GetPtr(), this, index, attributeType);
	return (int)returnPointer;
}


// void GetAttributeIndices(int * indexArray)
// "void GetAttributeIndices(int* indexArray)"
public void GetAttributeIndices(IntPtr /*(int*)*/ indexArray) {
	API_vtkDataSetAttributes.GetAttributeIndices_0(this, indexArray);
}


// int IsArrayAnAttribute(int idx)
// "int IsArrayAnAttribute(int idx)"
public int IsArrayAnAttribute(int /*(int)*/ idx) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.IsArrayAnAttribute_0(returnPointer.GetPtr(), this, idx);
	return (int)returnPointer;
}


// int SetAttribute(vtkAbstractArray * aa, int attributeType)
// "int SetAttribute(vtkAbstractArray* aa, int attributeType)"
public int SetAttribute(vtkAbstractArray /*(vtkAbstractArray*)*/ aa, int /*(int)*/ attributeType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.SetAttribute_0(returnPointer.GetPtr(), this, aa, attributeType);
	return (int)returnPointer;
}


// vtkDataArray* GetAttribute(int attributeType)
// "vtkDataArray* GetAttribute(int attributeType)"
public vtkDataArray GetAttribute(int /*(int)*/ attributeType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetAttribute_0(returnPointer.GetPtr(), this, attributeType);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkAbstractArray* GetAbstractAttribute(int attributeType)
// "vtkAbstractArray* GetAbstractAttribute(int attributeType)"
public vtkAbstractArray GetAbstractAttribute(int /*(int)*/ attributeType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetAbstractAttribute_0(returnPointer.GetPtr(), this, attributeType);
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// void RemoveArray(int index)
// "void RemoveArray(int index)"
public void RemoveArray(int /*(int)*/ index) {
	API_vtkDataSetAttributes.RemoveArray_0(this, index);
}


// static char* GetAttributeTypeAsString(int attributeType)
// "static const char* GetAttributeTypeAsString(int attributeType)"
public static string GetAttributeTypeAsString(int /*(int)*/ attributeType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetAttributeTypeAsString_0(returnPointer.GetPtr(), attributeType);
	return (string)returnPointer;
}


// static char* GetLongAttributeTypeAsString(int attributeType)
// "static const char* GetLongAttributeTypeAsString(int attributeType)"
public static string GetLongAttributeTypeAsString(int /*(int)*/ attributeType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataSetAttributes.GetLongAttributeTypeAsString_0(returnPointer.GetPtr(), attributeType);
	return (string)returnPointer;
}


// int GetCopyAttribute(int index, int ctype)
// "int GetCopyAttribute (int index, int ctype)"
public int GetCopyAttribute(int /*(int)*/ index, int /*(int)*/ ctype) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataSetAttributes.GetCopyAttribute_0(returnPointer.GetPtr(), this, index, ctype);
	return (int)returnPointer;
}


// void PassData(vtkFieldData * fd)
// "void PassData(vtkFieldData* fd)"
public void PassData(vtkFieldData /*(vtkFieldData*)*/ fd) {
	API_vtkDataSetAttributes.PassData_0(this, fd);
}


// void CopyAllocate(vtkDataSetAttributes * pd, vtkIdType sze = 0, vtkIdType ext = 1000)
// "void CopyAllocate(vtkDataSetAttributes* pd, vtkIdType sze=0, vtkIdType ext=1000)"
public void CopyAllocate(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ pd, long /*(vtkIdType)*/ sze, long /*(vtkIdType)*/ ext) {
	API_vtkDataSetAttributes.CopyAllocate_0(this, pd, sze, ext);
}


// void CopyAllocate(vtkDataSetAttributes * pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)
// "void CopyAllocate(vtkDataSetAttributes* pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)"
public void CopyAllocate(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ pd, long /*(vtkIdType)*/ sze, long /*(vtkIdType)*/ ext, int /*(int)*/ shallowCopyArrays) {
	API_vtkDataSetAttributes.CopyAllocate_1(this, pd, sze, ext, shallowCopyArrays);
}


// void SetupForCopy(vtkDataSetAttributes * pd)
// "void SetupForCopy(vtkDataSetAttributes* pd)"
public void SetupForCopy(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ pd) {
	API_vtkDataSetAttributes.SetupForCopy_0(this, pd);
}


// void CopyStructuredData(vtkDataSetAttributes * inDsa, const int * inExt, const int * outExt, bool setSize = true)
// "void CopyStructuredData(vtkDataSetAttributes *inDsa, const int *inExt, const int *outExt, bool setSize = true)"
public void CopyStructuredData(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ inDsa, IntPtr /*(int*)*/ inExt, IntPtr /*(int*)*/ outExt, bool /*(bool)*/ setSize) {
	API_vtkDataSetAttributes.CopyStructuredData_0(this, inDsa, inExt, outExt, setSize);
}


// void CopyData(vtkDataSetAttributes * fromPd, vtkIdType fromId, vtkIdType toId)
// "void CopyData(vtkDataSetAttributes *fromPd, vtkIdType fromId, vtkIdType toId)"
public void CopyData(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ fromPd, long /*(vtkIdType)*/ fromId, long /*(vtkIdType)*/ toId) {
	API_vtkDataSetAttributes.CopyData_0(this, fromPd, fromId, toId);
}


// void CopyData(vtkDataSetAttributes * fromPd, vtkIdList * fromIds, vtkIdList * toIds)
// "void CopyData(vtkDataSetAttributes *fromPd, vtkIdList *fromIds, vtkIdList *toIds)"
public void CopyData(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ fromPd, vtkIdList /*(vtkIdList*)*/ fromIds, vtkIdList /*(vtkIdList*)*/ toIds) {
	API_vtkDataSetAttributes.CopyData_1(this, fromPd, fromIds, toIds);
}


// void CopyData(vtkDataSetAttributes * fromPd, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
// "void CopyData(vtkDataSetAttributes *fromPd, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)"
public void CopyData(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ fromPd, long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart) {
	API_vtkDataSetAttributes.CopyData_2(this, fromPd, dstStart, n, srcStart);
}


// void CopyTuple(vtkAbstractArray * fromData, vtkAbstractArray * toData, vtkIdType fromId, vtkIdType toId)
// "void CopyTuple(vtkAbstractArray *fromData, vtkAbstractArray *toData, vtkIdType fromId, vtkIdType toId)"
public void CopyTuple(vtkAbstractArray /*(vtkAbstractArray*)*/ fromData, vtkAbstractArray /*(vtkAbstractArray*)*/ toData, long /*(vtkIdType)*/ fromId, long /*(vtkIdType)*/ toId) {
	API_vtkDataSetAttributes.CopyTuple_0(this, fromData, toData, fromId, toId);
}


// void CopyTuples(vtkAbstractArray * fromData, vtkAbstractArray * toData, vtkIdList * fromIds, vtkIdList * toIds)
// "void CopyTuples(vtkAbstractArray *fromData, vtkAbstractArray *toData, vtkIdList *fromIds, vtkIdList *toIds)"
public void CopyTuples(vtkAbstractArray /*(vtkAbstractArray*)*/ fromData, vtkAbstractArray /*(vtkAbstractArray*)*/ toData, vtkIdList /*(vtkIdList*)*/ fromIds, vtkIdList /*(vtkIdList*)*/ toIds) {
	API_vtkDataSetAttributes.CopyTuples_0(this, fromData, toData, fromIds, toIds);
}


// void CopyTuples(vtkAbstractArray * fromData, vtkAbstractArray * toData, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
// "void CopyTuples(vtkAbstractArray *fromData, vtkAbstractArray *toData, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)"
public void CopyTuples(vtkAbstractArray /*(vtkAbstractArray*)*/ fromData, vtkAbstractArray /*(vtkAbstractArray*)*/ toData, long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart) {
	API_vtkDataSetAttributes.CopyTuples_1(this, fromData, toData, dstStart, n, srcStart);
}


// void InterpolateAllocate(vtkDataSetAttributes * pd, vtkIdType sze = 0, vtkIdType ext = 1000)
// "void InterpolateAllocate(vtkDataSetAttributes* pd, vtkIdType sze=0, vtkIdType ext=1000)"
public void InterpolateAllocate(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ pd, long /*(vtkIdType)*/ sze, long /*(vtkIdType)*/ ext) {
	API_vtkDataSetAttributes.InterpolateAllocate_0(this, pd, sze, ext);
}


// void InterpolateAllocate(vtkDataSetAttributes * pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)
// "void InterpolateAllocate(vtkDataSetAttributes* pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)"
public void InterpolateAllocate(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ pd, long /*(vtkIdType)*/ sze, long /*(vtkIdType)*/ ext, int /*(int)*/ shallowCopyArrays) {
	API_vtkDataSetAttributes.InterpolateAllocate_1(this, pd, sze, ext, shallowCopyArrays);
}


// void InterpolatePoint(vtkDataSetAttributes * fromPd, vtkIdType toId, vtkIdList * ids, double * weights)
// "void InterpolatePoint(vtkDataSetAttributes *fromPd, vtkIdType toId, vtkIdList *ids, double *weights)"
public void InterpolatePoint(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ fromPd, long /*(vtkIdType)*/ toId, vtkIdList /*(vtkIdList*)*/ ids, IntPtr /*(double*)*/ weights) {
	API_vtkDataSetAttributes.InterpolatePoint_0(this, fromPd, toId, ids, weights);
}


// void InterpolateEdge(vtkDataSetAttributes * fromPd, vtkIdType toId, vtkIdType p1, vtkIdType p2, double t)
// "void InterpolateEdge(vtkDataSetAttributes *fromPd, vtkIdType toId, vtkIdType p1, vtkIdType p2, double t)"
public void InterpolateEdge(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ fromPd, long /*(vtkIdType)*/ toId, long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, double /*(double)*/ t) {
	API_vtkDataSetAttributes.InterpolateEdge_0(this, fromPd, toId, p1, p2, t);
}


// void InterpolateTime(vtkDataSetAttributes * from1, vtkDataSetAttributes * from2, vtkIdType id, double t)
// "void InterpolateTime(vtkDataSetAttributes *from1, vtkDataSetAttributes *from2, vtkIdType id, double t)"
public void InterpolateTime(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ from1, vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ from2, long /*(vtkIdType)*/ id, double /*(double)*/ t) {
	API_vtkDataSetAttributes.InterpolateTime_0(this, from1, from2, id, t);
}


}
};
