

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataObject : vtkObject {

// static vtkDataObject* New()
// "static vtkDataObject *New()"
public new static vtkDataObject New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataObject.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public new ulong GetMTime() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkDataObject.GetMTime_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void Initialize()
// "virtual void Initialize()"
public new void Initialize() {
	API_vtkDataObject.Initialize_0(this);
}


// void ReleaseData()
// "void ReleaseData()"
public new void ReleaseData() {
	API_vtkDataObject.ReleaseData_0(this);
}


// static void SetGlobalReleaseDataFlag(int val)
// "static void SetGlobalReleaseDataFlag(int val)"
public new static void SetGlobalReleaseDataFlag(int /*(int)*/ val) {
	API_vtkDataObject.SetGlobalReleaseDataFlag_0(val);
}


// void GlobalReleaseDataFlagOn()
// "void GlobalReleaseDataFlagOn()"
public new void GlobalReleaseDataFlagOn() {
	API_vtkDataObject.GlobalReleaseDataFlagOn_0(this);
}


// void GlobalReleaseDataFlagOff()
// "void GlobalReleaseDataFlagOff()"
public new void GlobalReleaseDataFlagOff() {
	API_vtkDataObject.GlobalReleaseDataFlagOff_0(this);
}


// static int GetGlobalReleaseDataFlag()
// "static int GetGlobalReleaseDataFlag()"
public new static int GetGlobalReleaseDataFlag() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataObject.GetGlobalReleaseDataFlag_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void SetFieldData(vtkFieldData * ARG_0)
// "virtual void SetFieldData(vtkFieldData*)"
public new void SetFieldData(vtkFieldData /*(vtkFieldData*)*/ ARG_0) {
	API_vtkDataObject.SetFieldData_0(this, ARG_0);
}


// virtual int GetDataObjectType()
// "virtual int GetDataObjectType()"
public new int GetDataObjectType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataObject.GetDataObjectType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkMTimeType GetUpdateTime()
// "vtkMTimeType GetUpdateTime()"
public new ulong GetUpdateTime() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkDataObject.GetUpdateTime_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual long GetActualMemorySize()
// "virtual unsigned long GetActualMemorySize()"
public new ulong GetActualMemorySize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkDataObject.GetActualMemorySize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void DataHasBeenGenerated()
// "void DataHasBeenGenerated()"
public new void DataHasBeenGenerated() {
	API_vtkDataObject.DataHasBeenGenerated_0(this);
}


// virtual void PrepareForNewData()
// "virtual void PrepareForNewData()"
public new void PrepareForNewData() {
	API_vtkDataObject.PrepareForNewData_0(this);
}


// virtual void ShallowCopy(vtkDataObject * src)
// "virtual void ShallowCopy(vtkDataObject *src)"
public new void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkDataObject.ShallowCopy_0(this, src);
}


// virtual void DeepCopy(vtkDataObject * src)
// "virtual void DeepCopy(vtkDataObject *src)"
public new void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkDataObject.DeepCopy_0(this, src);
}


// virtual int GetExtentType()
// "virtual int GetExtentType()"
public new int GetExtentType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataObject.GetExtentType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void Crop(const int * updateExtent)
// "virtual void Crop(const int* updateExtent)"
public new void Crop(int /*(int*)*/ []updateExtent) {
	API_vtkDataObject.Crop_0(this, updateExtent);
}


// virtual vtkDataSetAttributes* GetAttributes(int type)
// "virtual vtkDataSetAttributes* GetAttributes(int type)"
public new vtkDataSetAttributes GetAttributes(int /*(int)*/ type) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataObject.GetAttributes_0(this, returnPointer, type);
	return Ptr.deref(returnPointer);
}


// virtual vtkFieldData* GetAttributesAsFieldData(int type)
// "virtual vtkFieldData* GetAttributesAsFieldData(int type)"
public new vtkFieldData GetAttributesAsFieldData(int /*(int)*/ type) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataObject.GetAttributesAsFieldData_0(this, returnPointer, type);
	return Ptr.deref(returnPointer);
}


// virtual int GetAttributeTypeForArray(vtkAbstractArray * arr)
// "virtual int GetAttributeTypeForArray(vtkAbstractArray* arr)"
public new int GetAttributeTypeForArray(vtkAbstractArray /*(vtkAbstractArray*)*/ arr) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataObject.GetAttributeTypeForArray_0(this, returnPointer, arr);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType GetNumberOfElements(int type)
// "virtual vtkIdType GetNumberOfElements(int type)"
public new long GetNumberOfElements(int /*(int)*/ type) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkDataObject.GetNumberOfElements_0(this, returnPointer, type);
	return Ptr.deref(returnPointer);
}


// static char* GetAssociationTypeAsString(int associationType)
// "static const char* GetAssociationTypeAsString(int associationType)"
public new static char GetAssociationTypeAsString(int /*(int)*/ associationType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkDataObject.GetAssociationTypeAsString_0(returnPointer, associationType);
	return Ptr.deref(returnPointer);
}


// static int GetAssociationTypeFromString(const char * associationType)
// "static int GetAssociationTypeFromString(const char* associationType)"
public new static int GetAssociationTypeFromString(char /*(char*)*/ []associationType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataObject.GetAssociationTypeFromString_0(returnPointer, associationType);
	return Ptr.deref(returnPointer);
}


}
};
