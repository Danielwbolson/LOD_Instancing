
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public class vtkDataObject : vtkObject {

//       Method: static vtkDataObject * vtkDataObject::New()
// 
public static IntPtr New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.New(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkDataObject::GetClassName()
// 
public static string GetClassName(IntPtr obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkDataObject.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkDataObject::SetInformation(vtkInformation* ARG_0)
// 
public static void SetInformation(IntPtr obj, IntPtr/*vtkInformation* */ ARG_0) {
	VTK.API_vtkDataObject.SetInformation(obj, ARG_0);
}


//       Method: vtkMTimeType vtkDataObject::GetMTime()
// 
public static IntPtr GetMTime(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetMTime(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkDataObject::Initialize()
// 
public static void Initialize(IntPtr obj) {
	VTK.API_vtkDataObject.Initialize(obj);
}


//       Method: void vtkDataObject::ReleaseData()
// 
public static void ReleaseData(IntPtr obj) {
	VTK.API_vtkDataObject.ReleaseData(obj);
}


//       Method: static void vtkDataObject::SetGlobalReleaseDataFlag(int val)
// 
public static void SetGlobalReleaseDataFlag(int val) {
	VTK.API_vtkDataObject.SetGlobalReleaseDataFlag(val);
}


//       Method: void vtkDataObject::GlobalReleaseDataFlagOn()
// 
public static void GlobalReleaseDataFlagOn(IntPtr obj) {
	VTK.API_vtkDataObject.GlobalReleaseDataFlagOn(obj);
}


//       Method: void vtkDataObject::GlobalReleaseDataFlagOff()
// 
public static void GlobalReleaseDataFlagOff(IntPtr obj) {
	VTK.API_vtkDataObject.GlobalReleaseDataFlagOff(obj);
}


//       Method: static int vtkDataObject::GetGlobalReleaseDataFlag()
// 
public static int GetGlobalReleaseDataFlag() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetGlobalReleaseDataFlag(p);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkDataObject::SetFieldData(vtkFieldData* ARG_0)
// 
public static void SetFieldData(IntPtr obj, IntPtr/*vtkFieldData* */ ARG_0) {
	VTK.API_vtkDataObject.SetFieldData(obj, ARG_0);
}


//       Method: virtual int vtkDataObject::GetDataObjectType()
// 
public static int GetDataObjectType(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetDataObjectType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkMTimeType vtkDataObject::GetUpdateTime()
// 
public static IntPtr GetUpdateTime(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetUpdateTime(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformation * vtkDataObject::GetActiveFieldInformation(vtkInformation* info, int fieldAssociation, int attributeType)
// 
public static IntPtr GetActiveFieldInformation(IntPtr/*vtkInformation* */ info, int fieldAssociation, int attributeType) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetActiveFieldInformation(p, info, fieldAssociation, attributeType);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformation * vtkDataObject::GetNamedFieldInformation(vtkInformation* info, int fieldAssociation, const char* name)
// 
public static IntPtr GetNamedFieldInformation(IntPtr/*vtkInformation* */ info, int fieldAssociation, string/*const char* */ name) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetNamedFieldInformation(p, info, fieldAssociation, name);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static void vtkDataObject::RemoveNamedFieldInformation(vtkInformation* info, int fieldAssociation, const char* name)
// 
public static void RemoveNamedFieldInformation(IntPtr/*vtkInformation* */ info, int fieldAssociation, string/*const char* */ name) {
	VTK.API_vtkDataObject.RemoveNamedFieldInformation(info, fieldAssociation, name);
}


//       Method: static vtkInformation * vtkDataObject::SetActiveAttribute(vtkInformation* info, int fieldAssociation, const char* attributeName, int attributeType)
// 
public static IntPtr SetActiveAttribute(IntPtr/*vtkInformation* */ info, int fieldAssociation, string/*const char* */ attributeName, int attributeType) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.SetActiveAttribute(p, info, fieldAssociation, attributeName, attributeType);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static void vtkDataObject::SetActiveAttributeInfo(vtkInformation* info, int fieldAssociation, int attributeType, const char* name, int arrayType, int numComponents, int numTuples)
// 
public static void SetActiveAttributeInfo(IntPtr/*vtkInformation* */ info, int fieldAssociation, int attributeType, string/*const char* */ name, int arrayType, int numComponents, int numTuples) {
	VTK.API_vtkDataObject.SetActiveAttributeInfo(info, fieldAssociation, attributeType, name, arrayType, numComponents, numTuples);
}


//       Method: static void vtkDataObject::SetPointDataActiveScalarInfo(vtkInformation* info, int arrayType, int numComponents)
// 
public static void SetPointDataActiveScalarInfo(IntPtr/*vtkInformation* */ info, int arrayType, int numComponents) {
	VTK.API_vtkDataObject.SetPointDataActiveScalarInfo(info, arrayType, numComponents);
}


//       Method: void vtkDataObject::DataHasBeenGenerated()
// 
public static void DataHasBeenGenerated(IntPtr obj) {
	VTK.API_vtkDataObject.DataHasBeenGenerated(obj);
}


//       Method: virtual void vtkDataObject::PrepareForNewData()
// 
public static void PrepareForNewData(IntPtr obj) {
	VTK.API_vtkDataObject.PrepareForNewData(obj);
}


//       Method: virtual void vtkDataObject::ShallowCopy(vtkDataObject* src)
// 
public static void ShallowCopy(IntPtr obj, IntPtr/*vtkDataObject* */ src) {
	VTK.API_vtkDataObject.ShallowCopy(obj, src);
}


//       Method: virtual void vtkDataObject::DeepCopy(vtkDataObject* src)
// 
public static void DeepCopy(IntPtr obj, IntPtr/*vtkDataObject* */ src) {
	VTK.API_vtkDataObject.DeepCopy(obj, src);
}


//       Method: virtual int vtkDataObject::GetExtentType()
// 
public static int GetExtentType(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetExtentType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkDataObject::Crop(const int* updateExtent)
// 
public static void Crop(IntPtr obj, IntPtr/*const int* */ updateExtent) {
	VTK.API_vtkDataObject.Crop(obj, updateExtent);
}


//       Method: virtual vtkDataSetAttributes * vtkDataObject::GetAttributes(int type)
// 
public static IntPtr GetAttributes(IntPtr obj, int type) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetAttributes(p,obj, type);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkFieldData * vtkDataObject::GetAttributesAsFieldData(int type)
// 
public static IntPtr GetAttributesAsFieldData(IntPtr obj, int type) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetAttributesAsFieldData(p,obj, type);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkDataObject::GetAttributeTypeForArray(vtkAbstractArray* arr)
// 
public static int GetAttributeTypeForArray(IntPtr obj, IntPtr/*vtkAbstractArray* */ arr) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetAttributeTypeForArray(p,obj, arr);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkDataObject::GetNumberOfElements(int type)
// 
public static long GetNumberOfElements(IntPtr obj, int type) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetNumberOfElements(p,obj, type);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static const char * vtkDataObject::GetAssociationTypeAsString(int associationType)
// 
public static string GetAssociationTypeAsString(int associationType) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkDataObject.GetAssociationTypeAsString(p, associationType);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static int vtkDataObject::GetAssociationTypeFromString(const char* associationType)
// 
public static int GetAssociationTypeFromString(string/*const char* */ associationType) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetAssociationTypeFromString(p, associationType);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationStringKey * vtkDataObject::DATA_TYPE_NAME()
// 
public static IntPtr DATA_TYPE_NAME() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.DATA_TYPE_NAME(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationDataObjectKey * vtkDataObject::DATA_OBJECT()
// 
public static IntPtr DATA_OBJECT() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.DATA_OBJECT(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkDataObject::DATA_EXTENT_TYPE()
// 
public static IntPtr DATA_EXTENT_TYPE() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.DATA_EXTENT_TYPE(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerPointerKey * vtkDataObject::DATA_EXTENT()
// 
public static IntPtr DATA_EXTENT() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.DATA_EXTENT(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerVectorKey * vtkDataObject::ALL_PIECES_EXTENT()
// 
public static IntPtr ALL_PIECES_EXTENT() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.ALL_PIECES_EXTENT(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkDataObject::DATA_PIECE_NUMBER()
// 
public static IntPtr DATA_PIECE_NUMBER() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.DATA_PIECE_NUMBER(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkDataObject::DATA_NUMBER_OF_PIECES()
// 
public static IntPtr DATA_NUMBER_OF_PIECES() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.DATA_NUMBER_OF_PIECES(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkDataObject::DATA_NUMBER_OF_GHOST_LEVELS()
// 
public static IntPtr DATA_NUMBER_OF_GHOST_LEVELS() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.DATA_NUMBER_OF_GHOST_LEVELS(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationDoubleKey * vtkDataObject::DATA_TIME_STEP()
// 
public static IntPtr DATA_TIME_STEP() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.DATA_TIME_STEP(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationInformationVectorKey * vtkDataObject::POINT_DATA_VECTOR()
// 
public static IntPtr POINT_DATA_VECTOR() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.POINT_DATA_VECTOR(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationInformationVectorKey * vtkDataObject::CELL_DATA_VECTOR()
// 
public static IntPtr CELL_DATA_VECTOR() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.CELL_DATA_VECTOR(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationInformationVectorKey * vtkDataObject::VERTEX_DATA_VECTOR()
// 
public static IntPtr VERTEX_DATA_VECTOR() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.VERTEX_DATA_VECTOR(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationInformationVectorKey * vtkDataObject::EDGE_DATA_VECTOR()
// 
public static IntPtr EDGE_DATA_VECTOR() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.EDGE_DATA_VECTOR(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_ARRAY_TYPE()
// 
public static IntPtr FIELD_ARRAY_TYPE() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.FIELD_ARRAY_TYPE(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_ASSOCIATION()
// 
public static IntPtr FIELD_ASSOCIATION() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.FIELD_ASSOCIATION(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_ATTRIBUTE_TYPE()
// 
public static IntPtr FIELD_ATTRIBUTE_TYPE() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.FIELD_ATTRIBUTE_TYPE(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_ACTIVE_ATTRIBUTE()
// 
public static IntPtr FIELD_ACTIVE_ATTRIBUTE() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.FIELD_ACTIVE_ATTRIBUTE(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_NUMBER_OF_COMPONENTS()
// 
public static IntPtr FIELD_NUMBER_OF_COMPONENTS() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.FIELD_NUMBER_OF_COMPONENTS(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_NUMBER_OF_TUPLES()
// 
public static IntPtr FIELD_NUMBER_OF_TUPLES() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.FIELD_NUMBER_OF_TUPLES(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_OPERATION()
// 
public static IntPtr FIELD_OPERATION() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.FIELD_OPERATION(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationDoubleVectorKey * vtkDataObject::FIELD_RANGE()
// 
public static IntPtr FIELD_RANGE() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.FIELD_RANGE(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationIntegerVectorKey * vtkDataObject::PIECE_EXTENT()
// 
public static IntPtr PIECE_EXTENT() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.PIECE_EXTENT(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationStringKey * vtkDataObject::FIELD_NAME()
// 
public static IntPtr FIELD_NAME() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.FIELD_NAME(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationDoubleVectorKey * vtkDataObject::ORIGIN()
// 
public static IntPtr ORIGIN() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.ORIGIN(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationDoubleVectorKey * vtkDataObject::SPACING()
// 
public static IntPtr SPACING() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.SPACING(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationDoubleVectorKey * vtkDataObject::BOUNDING_BOX()
// 
public static IntPtr BOUNDING_BOX() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.BOUNDING_BOX(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationDataObjectKey * vtkDataObject::SIL()
// 
public static IntPtr SIL() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.SIL(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkDataObject * vtkDataObject::GetData(vtkInformation* info)
// 
public static IntPtr GetData(IntPtr/*vtkInformation* */ info) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetData(p, info);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkDataObject * vtkDataObject::GetData(vtkInformationVector* v, int i)
// 
public static IntPtr GetData(IntPtr/*vtkInformationVector* */ v, int i) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataObject.GetData(p, v, i);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
