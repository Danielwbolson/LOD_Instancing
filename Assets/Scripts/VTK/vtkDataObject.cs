

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataObject : vtkObject {
		public vtkDataObject(IntPtr p) : base(p) {}
		public static implicit operator  vtkDataObject(IntPtr p) {return new vtkDataObject(p);}
		public static implicit operator  IntPtr(vtkDataObject o) {return o.GetPtr();}

// static vtkDataObject* New()
// "static vtkDataObject *New()"
public static vtkDataObject New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataObject.New_0(returnPointer.GetPtr());
	return (vtkDataObject)(IntPtr)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	API_vtkDataObject.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	API_vtkDataObject.Initialize_0(this);
}


// void ReleaseData()
// "void ReleaseData()"
public void ReleaseData() {
	API_vtkDataObject.ReleaseData_0(this);
}


// static void SetGlobalReleaseDataFlag(int val)
// "static void SetGlobalReleaseDataFlag(int val)"
public static void SetGlobalReleaseDataFlag(int /*(int)*/ val) {
	API_vtkDataObject.SetGlobalReleaseDataFlag_0(val);
}


// void GlobalReleaseDataFlagOn()
// "void GlobalReleaseDataFlagOn()"
public void GlobalReleaseDataFlagOn() {
	API_vtkDataObject.GlobalReleaseDataFlagOn_0(this);
}


// void GlobalReleaseDataFlagOff()
// "void GlobalReleaseDataFlagOff()"
public void GlobalReleaseDataFlagOff() {
	API_vtkDataObject.GlobalReleaseDataFlagOff_0(this);
}


// static int GetGlobalReleaseDataFlag()
// "static int GetGlobalReleaseDataFlag()"
public static int GetGlobalReleaseDataFlag() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataObject.GetGlobalReleaseDataFlag_0(returnPointer.GetPtr());
	return (int)returnPointer;
}


// virtual void SetFieldData(vtkFieldData * ARG_0)
// "virtual void SetFieldData(vtkFieldData*)"
public void SetFieldData(vtkFieldData /*(vtkFieldData*)*/ ARG_0) {
	API_vtkDataObject.SetFieldData_0(this, ARG_0);
}


// virtual int GetDataObjectType()
// "virtual int GetDataObjectType()"
public int GetDataObjectType() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataObject.GetDataObjectType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkMTimeType GetUpdateTime()
// "vtkMTimeType GetUpdateTime()"
public ulong GetUpdateTime() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	API_vtkDataObject.GetUpdateTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual long GetActualMemorySize()
// "virtual unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	API_vtkDataObject.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void DataHasBeenGenerated()
// "void DataHasBeenGenerated()"
public void DataHasBeenGenerated() {
	API_vtkDataObject.DataHasBeenGenerated_0(this);
}


// virtual void PrepareForNewData()
// "virtual void PrepareForNewData()"
public void PrepareForNewData() {
	API_vtkDataObject.PrepareForNewData_0(this);
}


// virtual void ShallowCopy(vtkDataObject * src)
// "virtual void ShallowCopy(vtkDataObject *src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkDataObject.ShallowCopy_0(this, src);
}


// virtual void DeepCopy(vtkDataObject * src)
// "virtual void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkDataObject.DeepCopy_0(this, src);
}


// virtual int GetExtentType()
// "virtual int GetExtentType()"
public int GetExtentType() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataObject.GetExtentType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void Crop(const int * updateExtent)
// "virtual void Crop(const int* updateExtent)"
public void Crop(IntPtr /*(int*)*/ updateExtent) {
	API_vtkDataObject.Crop_0(this, updateExtent);
}


// virtual vtkDataSetAttributes* GetAttributes(int type)
// "virtual vtkDataSetAttributes* GetAttributes(int type)"
public vtkDataSetAttributes GetAttributes(int /*(int)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataObject.GetAttributes_0(returnPointer.GetPtr(), this, type);
	return (vtkDataSetAttributes)(IntPtr)returnPointer;
}


// virtual vtkFieldData* GetAttributesAsFieldData(int type)
// "virtual vtkFieldData* GetAttributesAsFieldData(int type)"
public vtkFieldData GetAttributesAsFieldData(int /*(int)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataObject.GetAttributesAsFieldData_0(returnPointer.GetPtr(), this, type);
	return (vtkFieldData)(IntPtr)returnPointer;
}


// virtual int GetAttributeTypeForArray(vtkAbstractArray * arr)
// "virtual int GetAttributeTypeForArray(vtkAbstractArray* arr)"
public int GetAttributeTypeForArray(vtkAbstractArray /*(vtkAbstractArray*)*/ arr) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataObject.GetAttributeTypeForArray_0(returnPointer.GetPtr(), this, arr);
	return (int)returnPointer;
}


// virtual vtkIdType GetNumberOfElements(int type)
// "virtual vtkIdType GetNumberOfElements(int type)"
public long GetNumberOfElements(int /*(int)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkDataObject.GetNumberOfElements_0(returnPointer.GetPtr(), this, type);
	return (long)returnPointer;
}


// static char* GetAssociationTypeAsString(int associationType)
// "static const char* GetAssociationTypeAsString(int associationType)"
public static string GetAssociationTypeAsString(int /*(int)*/ associationType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataObject.GetAssociationTypeAsString_0(returnPointer.GetPtr(), associationType);
	return (string)returnPointer;
}


// static int GetAssociationTypeFromString(const char * associationType)
// "static int GetAssociationTypeFromString(const char* associationType)"
public static int GetAssociationTypeFromString(string /*(char*)*/ associationType) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkDataObject.GetAssociationTypeFromString_0(returnPointer.GetPtr(), associationType);
	return (int)returnPointer;
}


}
};
