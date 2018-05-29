

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
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.New_0(returnPointer.GetPtr());
	return (vtkDataObject)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkDataObject.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkDataObject.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkDataObject* SafeDownCast(vtkObjectBase * o)
// "static vtkDataObject* SafeDownCast(vtkObjectBase *o)"
public static vtkDataObject SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkDataObject)(IntPtr)returnPointer;
}


// vtkDataObject* NewInstance()
// "vtkDataObject *NewInstance()"
public vtkDataObject NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkDataObject)(IntPtr)returnPointer;
}


// virtual vtkInformation* GetInformation()
// "virtual vtkInformation *GetInformation ()"
public vtkInformation GetInformation() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.GetInformation_0(returnPointer.GetPtr(), this);
	return (vtkInformation)(IntPtr)returnPointer;
}


// virtual void SetInformation(vtkInformation * ARG_0)
// "virtual void SetInformation(vtkInformation*)"
public void SetInformation(vtkInformation /*(vtkInformation*)*/ ARG_0) {
	VTK_API.API_vtkDataObject.SetInformation_0(this, ARG_0);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkDataObject.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	VTK_API.API_vtkDataObject.Initialize_0(this);
}


// void ReleaseData()
// "void ReleaseData()"
public void ReleaseData() {
	VTK_API.API_vtkDataObject.ReleaseData_0(this);
}


// virtual int GetDataReleased()
// "virtual int GetDataReleased ()"
public int GetDataReleased() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataObject.GetDataReleased_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// static void SetGlobalReleaseDataFlag(int val)
// "static void SetGlobalReleaseDataFlag(int val)"
public static void SetGlobalReleaseDataFlag(int /*(int)*/ val) {
	VTK_API.API_vtkDataObject.SetGlobalReleaseDataFlag_0(val);
}


// void GlobalReleaseDataFlagOn()
// "void GlobalReleaseDataFlagOn()"
public void GlobalReleaseDataFlagOn() {
	VTK_API.API_vtkDataObject.GlobalReleaseDataFlagOn_0(this);
}


// void GlobalReleaseDataFlagOff()
// "void GlobalReleaseDataFlagOff()"
public void GlobalReleaseDataFlagOff() {
	VTK_API.API_vtkDataObject.GlobalReleaseDataFlagOff_0(this);
}


// static int GetGlobalReleaseDataFlag()
// "static int GetGlobalReleaseDataFlag()"
public static int GetGlobalReleaseDataFlag() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataObject.GetGlobalReleaseDataFlag_0(returnPointer.GetPtr());
	return (int)returnPointer;
}


// virtual void SetFieldData(vtkFieldData * ARG_0)
// "virtual void SetFieldData(vtkFieldData*)"
public void SetFieldData(vtkFieldData /*(vtkFieldData*)*/ ARG_0) {
	VTK_API.API_vtkDataObject.SetFieldData_0(this, ARG_0);
}


// virtual vtkFieldData* GetFieldData()
// "virtual vtkFieldData *GetFieldData ()"
public vtkFieldData GetFieldData() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.GetFieldData_0(returnPointer.GetPtr(), this);
	return (vtkFieldData)(IntPtr)returnPointer;
}


// virtual int GetDataObjectType()
// "virtual int GetDataObjectType()"
public int GetDataObjectType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataObject.GetDataObjectType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkMTimeType GetUpdateTime()
// "vtkMTimeType GetUpdateTime()"
public ulong GetUpdateTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkDataObject.GetUpdateTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual long GetActualMemorySize()
// "virtual unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkDataObject.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual void CopyInformationFromPipeline(vtkInformation * ARG_0)
// "virtual void CopyInformationFromPipeline(vtkInformation* )"
public void CopyInformationFromPipeline(vtkInformation /*(vtkInformation*)*/ ARG_0) {
	VTK_API.API_vtkDataObject.CopyInformationFromPipeline_0(this, ARG_0);
}


// virtual void CopyInformationToPipeline(vtkInformation * ARG_0)
// "virtual void CopyInformationToPipeline(vtkInformation* )"
public void CopyInformationToPipeline(vtkInformation /*(vtkInformation*)*/ ARG_0) {
	VTK_API.API_vtkDataObject.CopyInformationToPipeline_0(this, ARG_0);
}


// static vtkInformation* GetActiveFieldInformation(vtkInformation * info, int fieldAssociation, int attributeType)
// "static vtkInformation *GetActiveFieldInformation(vtkInformation *info, int fieldAssociation, int attributeType)"
public static vtkInformation GetActiveFieldInformation(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, int /*(int)*/ attributeType) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.GetActiveFieldInformation_0(returnPointer.GetPtr(), info, fieldAssociation, attributeType);
	return (vtkInformation)(IntPtr)returnPointer;
}


// static vtkInformation* GetNamedFieldInformation(vtkInformation * info, int fieldAssociation, const char * name)
// "static vtkInformation *GetNamedFieldInformation(vtkInformation *info, int fieldAssociation, const char *name)"
public static vtkInformation GetNamedFieldInformation(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, string /*(char*)*/ name) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.GetNamedFieldInformation_0(returnPointer.GetPtr(), info, fieldAssociation, name);
	return (vtkInformation)(IntPtr)returnPointer;
}


// static void RemoveNamedFieldInformation(vtkInformation * info, int fieldAssociation, const char * name)
// "static void RemoveNamedFieldInformation(vtkInformation *info, int fieldAssociation, const char *name)"
public static void RemoveNamedFieldInformation(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, string /*(char*)*/ name) {
	VTK_API.API_vtkDataObject.RemoveNamedFieldInformation_0(info, fieldAssociation, name);
}


// static vtkInformation* SetActiveAttribute(vtkInformation * info, int fieldAssociation, const char * attributeName, int attributeType)
// "static vtkInformation *SetActiveAttribute(vtkInformation *info, int fieldAssociation, const char *attributeName, int attributeType)"
public static vtkInformation SetActiveAttribute(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, string /*(char*)*/ attributeName, int /*(int)*/ attributeType) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.SetActiveAttribute_0(returnPointer.GetPtr(), info, fieldAssociation, attributeName, attributeType);
	return (vtkInformation)(IntPtr)returnPointer;
}


// static void SetActiveAttributeInfo(vtkInformation * info, int fieldAssociation, int attributeType, const char * name, int arrayType, int numComponents, int numTuples)
// "static void SetActiveAttributeInfo(vtkInformation *info, int fieldAssociation, int attributeType, const char *name, int arrayType, int numComponents, int numTuples)"
public static void SetActiveAttributeInfo(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, int /*(int)*/ attributeType, string /*(char*)*/ name, int /*(int)*/ arrayType, int /*(int)*/ numComponents, int /*(int)*/ numTuples) {
	VTK_API.API_vtkDataObject.SetActiveAttributeInfo_0(info, fieldAssociation, attributeType, name, arrayType, numComponents, numTuples);
}


// static void SetPointDataActiveScalarInfo(vtkInformation * info, int arrayType, int numComponents)
// "static void SetPointDataActiveScalarInfo(vtkInformation *info, int arrayType, int numComponents)"
public static void SetPointDataActiveScalarInfo(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ arrayType, int /*(int)*/ numComponents) {
	VTK_API.API_vtkDataObject.SetPointDataActiveScalarInfo_0(info, arrayType, numComponents);
}


// void DataHasBeenGenerated()
// "void DataHasBeenGenerated()"
public void DataHasBeenGenerated() {
	VTK_API.API_vtkDataObject.DataHasBeenGenerated_0(this);
}


// virtual void PrepareForNewData()
// "virtual void PrepareForNewData()"
public void PrepareForNewData() {
	VTK_API.API_vtkDataObject.PrepareForNewData_0(this);
}


// virtual void ShallowCopy(vtkDataObject * src)
// "virtual void ShallowCopy(vtkDataObject *src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkDataObject.ShallowCopy_0(this, src);
}


// virtual void DeepCopy(vtkDataObject * src)
// "virtual void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkDataObject.DeepCopy_0(this, src);
}


// virtual int GetExtentType()
// "virtual int GetExtentType()"
public int GetExtentType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataObject.GetExtentType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void Crop(const int * updateExtent)
// "virtual void Crop(const int* updateExtent)"
public void Crop(IntPtr /*(int*)*/ updateExtent) {
	VTK_API.API_vtkDataObject.Crop_0(this, updateExtent);
}


// virtual vtkDataSetAttributes* GetAttributes(int type)
// "virtual vtkDataSetAttributes* GetAttributes(int type)"
public vtkDataSetAttributes GetAttributes(int /*(int)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.GetAttributes_0(returnPointer.GetPtr(), this, type);
	return (vtkDataSetAttributes)(IntPtr)returnPointer;
}


// virtual vtkFieldData* GetAttributesAsFieldData(int type)
// "virtual vtkFieldData* GetAttributesAsFieldData(int type)"
public vtkFieldData GetAttributesAsFieldData(int /*(int)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.GetAttributesAsFieldData_0(returnPointer.GetPtr(), this, type);
	return (vtkFieldData)(IntPtr)returnPointer;
}


// virtual int GetAttributeTypeForArray(vtkAbstractArray * arr)
// "virtual int GetAttributeTypeForArray(vtkAbstractArray* arr)"
public int GetAttributeTypeForArray(vtkAbstractArray /*(vtkAbstractArray*)*/ arr) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataObject.GetAttributeTypeForArray_0(returnPointer.GetPtr(), this, arr);
	return (int)returnPointer;
}


// virtual vtkIdType GetNumberOfElements(int type)
// "virtual vtkIdType GetNumberOfElements(int type)"
public long GetNumberOfElements(int /*(int)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkDataObject.GetNumberOfElements_0(returnPointer.GetPtr(), this, type);
	return (long)returnPointer;
}


// static char* GetAssociationTypeAsString(int associationType)
// "static const char* GetAssociationTypeAsString(int associationType)"
public static string GetAssociationTypeAsString(int /*(int)*/ associationType) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.GetAssociationTypeAsString_0(returnPointer.GetPtr(), associationType);
	return (string)returnPointer;
}


// static int GetAssociationTypeFromString(const char * associationType)
// "static int GetAssociationTypeFromString(const char* associationType)"
public static int GetAssociationTypeFromString(string /*(char*)*/ associationType) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataObject.GetAssociationTypeFromString_0(returnPointer.GetPtr(), associationType);
	return (int)returnPointer;
}


// static vtkInformationStringKey* DATA_TYPE_NAME()
// "static vtkInformationStringKey* DATA_TYPE_NAME()"
public static vtkInformationStringKey DATA_TYPE_NAME() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.DATA_TYPE_NAME_0(returnPointer.GetPtr());
	return (vtkInformationStringKey)(IntPtr)returnPointer;
}


// static vtkInformationDataObjectKey* DATA_OBJECT()
// "static vtkInformationDataObjectKey* DATA_OBJECT()"
public static vtkInformationDataObjectKey DATA_OBJECT() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.DATA_OBJECT_0(returnPointer.GetPtr());
	return (vtkInformationDataObjectKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* DATA_EXTENT_TYPE()
// "static vtkInformationIntegerKey* DATA_EXTENT_TYPE()"
public static vtkInformationIntegerKey DATA_EXTENT_TYPE() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.DATA_EXTENT_TYPE_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerPointerKey* DATA_EXTENT()
// "static vtkInformationIntegerPointerKey* DATA_EXTENT()"
public static vtkInformationIntegerPointerKey DATA_EXTENT() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.DATA_EXTENT_0(returnPointer.GetPtr());
	return (vtkInformationIntegerPointerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerVectorKey* ALL_PIECES_EXTENT()
// "static vtkInformationIntegerVectorKey* ALL_PIECES_EXTENT()"
public static vtkInformationIntegerVectorKey ALL_PIECES_EXTENT() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.ALL_PIECES_EXTENT_0(returnPointer.GetPtr());
	return (vtkInformationIntegerVectorKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* DATA_PIECE_NUMBER()
// "static vtkInformationIntegerKey* DATA_PIECE_NUMBER()"
public static vtkInformationIntegerKey DATA_PIECE_NUMBER() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.DATA_PIECE_NUMBER_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* DATA_NUMBER_OF_PIECES()
// "static vtkInformationIntegerKey* DATA_NUMBER_OF_PIECES()"
public static vtkInformationIntegerKey DATA_NUMBER_OF_PIECES() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.DATA_NUMBER_OF_PIECES_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* DATA_NUMBER_OF_GHOST_LEVELS()
// "static vtkInformationIntegerKey* DATA_NUMBER_OF_GHOST_LEVELS()"
public static vtkInformationIntegerKey DATA_NUMBER_OF_GHOST_LEVELS() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.DATA_NUMBER_OF_GHOST_LEVELS_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationDoubleKey* DATA_TIME_STEP()
// "static vtkInformationDoubleKey* DATA_TIME_STEP()"
public static vtkInformationDoubleKey DATA_TIME_STEP() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.DATA_TIME_STEP_0(returnPointer.GetPtr());
	return (vtkInformationDoubleKey)(IntPtr)returnPointer;
}


// static vtkInformationInformationVectorKey* POINT_DATA_VECTOR()
// "static vtkInformationInformationVectorKey* POINT_DATA_VECTOR()"
public static vtkInformationInformationVectorKey POINT_DATA_VECTOR() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.POINT_DATA_VECTOR_0(returnPointer.GetPtr());
	return (vtkInformationInformationVectorKey)(IntPtr)returnPointer;
}


// static vtkInformationInformationVectorKey* CELL_DATA_VECTOR()
// "static vtkInformationInformationVectorKey* CELL_DATA_VECTOR()"
public static vtkInformationInformationVectorKey CELL_DATA_VECTOR() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.CELL_DATA_VECTOR_0(returnPointer.GetPtr());
	return (vtkInformationInformationVectorKey)(IntPtr)returnPointer;
}


// static vtkInformationInformationVectorKey* VERTEX_DATA_VECTOR()
// "static vtkInformationInformationVectorKey* VERTEX_DATA_VECTOR()"
public static vtkInformationInformationVectorKey VERTEX_DATA_VECTOR() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.VERTEX_DATA_VECTOR_0(returnPointer.GetPtr());
	return (vtkInformationInformationVectorKey)(IntPtr)returnPointer;
}


// static vtkInformationInformationVectorKey* EDGE_DATA_VECTOR()
// "static vtkInformationInformationVectorKey* EDGE_DATA_VECTOR()"
public static vtkInformationInformationVectorKey EDGE_DATA_VECTOR() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.EDGE_DATA_VECTOR_0(returnPointer.GetPtr());
	return (vtkInformationInformationVectorKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* FIELD_ARRAY_TYPE()
// "static vtkInformationIntegerKey* FIELD_ARRAY_TYPE()"
public static vtkInformationIntegerKey FIELD_ARRAY_TYPE() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.FIELD_ARRAY_TYPE_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* FIELD_ASSOCIATION()
// "static vtkInformationIntegerKey* FIELD_ASSOCIATION()"
public static vtkInformationIntegerKey FIELD_ASSOCIATION() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.FIELD_ASSOCIATION_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* FIELD_ATTRIBUTE_TYPE()
// "static vtkInformationIntegerKey* FIELD_ATTRIBUTE_TYPE()"
public static vtkInformationIntegerKey FIELD_ATTRIBUTE_TYPE() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.FIELD_ATTRIBUTE_TYPE_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* FIELD_ACTIVE_ATTRIBUTE()
// "static vtkInformationIntegerKey* FIELD_ACTIVE_ATTRIBUTE()"
public static vtkInformationIntegerKey FIELD_ACTIVE_ATTRIBUTE() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.FIELD_ACTIVE_ATTRIBUTE_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* FIELD_NUMBER_OF_COMPONENTS()
// "static vtkInformationIntegerKey* FIELD_NUMBER_OF_COMPONENTS()"
public static vtkInformationIntegerKey FIELD_NUMBER_OF_COMPONENTS() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.FIELD_NUMBER_OF_COMPONENTS_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* FIELD_NUMBER_OF_TUPLES()
// "static vtkInformationIntegerKey* FIELD_NUMBER_OF_TUPLES()"
public static vtkInformationIntegerKey FIELD_NUMBER_OF_TUPLES() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.FIELD_NUMBER_OF_TUPLES_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* FIELD_OPERATION()
// "static vtkInformationIntegerKey* FIELD_OPERATION()"
public static vtkInformationIntegerKey FIELD_OPERATION() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.FIELD_OPERATION_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationDoubleVectorKey* FIELD_RANGE()
// "static vtkInformationDoubleVectorKey* FIELD_RANGE()"
public static vtkInformationDoubleVectorKey FIELD_RANGE() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.FIELD_RANGE_0(returnPointer.GetPtr());
	return (vtkInformationDoubleVectorKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerVectorKey* PIECE_EXTENT()
// "static vtkInformationIntegerVectorKey* PIECE_EXTENT()"
public static vtkInformationIntegerVectorKey PIECE_EXTENT() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.PIECE_EXTENT_0(returnPointer.GetPtr());
	return (vtkInformationIntegerVectorKey)(IntPtr)returnPointer;
}


// static vtkInformationStringKey* FIELD_NAME()
// "static vtkInformationStringKey* FIELD_NAME()"
public static vtkInformationStringKey FIELD_NAME() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.FIELD_NAME_0(returnPointer.GetPtr());
	return (vtkInformationStringKey)(IntPtr)returnPointer;
}


// static vtkInformationDoubleVectorKey* ORIGIN()
// "static vtkInformationDoubleVectorKey* ORIGIN()"
public static vtkInformationDoubleVectorKey ORIGIN() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.ORIGIN_0(returnPointer.GetPtr());
	return (vtkInformationDoubleVectorKey)(IntPtr)returnPointer;
}


// static vtkInformationDoubleVectorKey* SPACING()
// "static vtkInformationDoubleVectorKey* SPACING()"
public static vtkInformationDoubleVectorKey SPACING() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.SPACING_0(returnPointer.GetPtr());
	return (vtkInformationDoubleVectorKey)(IntPtr)returnPointer;
}


// static vtkInformationDoubleVectorKey* BOUNDING_BOX()
// "static vtkInformationDoubleVectorKey* BOUNDING_BOX()"
public static vtkInformationDoubleVectorKey BOUNDING_BOX() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.BOUNDING_BOX_0(returnPointer.GetPtr());
	return (vtkInformationDoubleVectorKey)(IntPtr)returnPointer;
}


// static vtkInformationDataObjectKey* SIL()
// "static vtkInformationDataObjectKey* SIL()"
public static vtkInformationDataObjectKey SIL() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.SIL_0(returnPointer.GetPtr());
	return (vtkInformationDataObjectKey)(IntPtr)returnPointer;
}


// static vtkDataObject* GetData(vtkInformation * info)
// "static vtkDataObject* GetData(vtkInformation* info)"
public static vtkDataObject GetData(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.GetData_0(returnPointer.GetPtr(), info);
	return (vtkDataObject)(IntPtr)returnPointer;
}


// static vtkDataObject* GetData(vtkInformationVector * v, int i = 0)
// "static vtkDataObject* GetData(vtkInformationVector* v, int i=0)"
public static vtkDataObject GetData(vtkInformationVector /*(vtkInformationVector*)*/ v, int /*(int)*/ i) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataObject.GetData_1(returnPointer.GetPtr(), v, i);
	return (vtkDataObject)(IntPtr)returnPointer;
}


}
};
