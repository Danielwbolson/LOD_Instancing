
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkDataObject {

//       Method: static vtkDataObject * vtkDataObject::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_New_0")] public static extern 
bool New(IntPtr /*vtkDataObject** */ ret);

//       Method: virtual void vtkDataObject::SetInformation(vtkInformation* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_SetInformation_0")] public static extern 
bool SetInformation(IntPtr /*vtkDataObject* */ obj, IntPtr/*vtkInformation* */ ARG_0);

//       Method: vtkMTimeType vtkDataObject::GetMTime()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_GetMTime_0")] public static extern 
bool GetMTime(IntPtr /*vtkMTimeType* */ ret, IntPtr /*vtkDataObject* */ obj);

//       Method: virtual void vtkDataObject::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkDataObject* */ obj);

//       Method: void vtkDataObject::ReleaseData()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_ReleaseData_0")] public static extern 
bool ReleaseData(IntPtr /*vtkDataObject* */ obj);

//       Method: static void vtkDataObject::SetGlobalReleaseDataFlag(int val)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_SetGlobalReleaseDataFlag_0")] public static extern 
bool SetGlobalReleaseDataFlag(int val);

//       Method: void vtkDataObject::GlobalReleaseDataFlagOn()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_GlobalReleaseDataFlagOn_0")] public static extern 
bool GlobalReleaseDataFlagOn(IntPtr /*vtkDataObject* */ obj);

//       Method: void vtkDataObject::GlobalReleaseDataFlagOff()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_GlobalReleaseDataFlagOff_0")] public static extern 
bool GlobalReleaseDataFlagOff(IntPtr /*vtkDataObject* */ obj);

//       Method: static int vtkDataObject::GetGlobalReleaseDataFlag()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_GetGlobalReleaseDataFlag_0")] public static extern 
bool GetGlobalReleaseDataFlag(IntPtr /*int* */ ret);

//       Method: virtual void vtkDataObject::SetFieldData(vtkFieldData* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_SetFieldData_0")] public static extern 
bool SetFieldData(IntPtr /*vtkDataObject* */ obj, IntPtr/*vtkFieldData* */ ARG_0);

//       Method: virtual int vtkDataObject::GetDataObjectType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_GetDataObjectType_0")] public static extern 
bool GetDataObjectType(IntPtr /*int* */ ret, IntPtr /*vtkDataObject* */ obj);

//       Method: vtkMTimeType vtkDataObject::GetUpdateTime()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_GetUpdateTime_0")] public static extern 
bool GetUpdateTime(IntPtr /*vtkMTimeType* */ ret, IntPtr /*vtkDataObject* */ obj);

//       Method: static vtkInformation * vtkDataObject::GetActiveFieldInformation(vtkInformation* info, int fieldAssociation, int attributeType)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_GetActiveFieldInformation_0")] public static extern 
bool GetActiveFieldInformation(IntPtr /*vtkInformation** */ ret, IntPtr/*vtkInformation* */ info, int fieldAssociation, int attributeType);

//       Method: static vtkInformation * vtkDataObject::GetNamedFieldInformation(vtkInformation* info, int fieldAssociation, const char* name)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_GetNamedFieldInformation_0")] public static extern 
bool GetNamedFieldInformation(IntPtr /*vtkInformation** */ ret, IntPtr/*vtkInformation* */ info, int fieldAssociation, IntPtr/*const char* */ name);

//       Method: static void vtkDataObject::RemoveNamedFieldInformation(vtkInformation* info, int fieldAssociation, const char* name)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_RemoveNamedFieldInformation_0")] public static extern 
bool RemoveNamedFieldInformation(IntPtr/*vtkInformation* */ info, int fieldAssociation, IntPtr/*const char* */ name);

//       Method: static vtkInformation * vtkDataObject::SetActiveAttribute(vtkInformation* info, int fieldAssociation, const char* attributeName, int attributeType)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_SetActiveAttribute_0")] public static extern 
bool SetActiveAttribute(IntPtr /*vtkInformation** */ ret, IntPtr/*vtkInformation* */ info, int fieldAssociation, IntPtr/*const char* */ attributeName, int attributeType);

//       Method: static void vtkDataObject::SetActiveAttributeInfo(vtkInformation* info, int fieldAssociation, int attributeType, const char* name, int arrayType, int numComponents, int numTuples)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_SetActiveAttributeInfo_0")] public static extern 
bool SetActiveAttributeInfo(IntPtr/*vtkInformation* */ info, int fieldAssociation, int attributeType, IntPtr/*const char* */ name, int arrayType, int numComponents, int numTuples);

//       Method: static void vtkDataObject::SetPointDataActiveScalarInfo(vtkInformation* info, int arrayType, int numComponents)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_SetPointDataActiveScalarInfo_0")] public static extern 
bool SetPointDataActiveScalarInfo(IntPtr/*vtkInformation* */ info, int arrayType, int numComponents);

//       Method: void vtkDataObject::DataHasBeenGenerated()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_DataHasBeenGenerated_0")] public static extern 
bool DataHasBeenGenerated(IntPtr /*vtkDataObject* */ obj);

//       Method: virtual void vtkDataObject::PrepareForNewData()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_PrepareForNewData_0")] public static extern 
bool PrepareForNewData(IntPtr /*vtkDataObject* */ obj);

//       Method: virtual void vtkDataObject::ShallowCopy(vtkDataObject* src)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_ShallowCopy_0")] public static extern 
bool ShallowCopy(IntPtr /*vtkDataObject* */ obj, IntPtr/*vtkDataObject* */ src);

//       Method: virtual void vtkDataObject::DeepCopy(vtkDataObject* src)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkDataObject* */ obj, IntPtr/*vtkDataObject* */ src);

//       Method: virtual int vtkDataObject::GetExtentType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_GetExtentType_0")] public static extern 
bool GetExtentType(IntPtr /*int* */ ret, IntPtr /*vtkDataObject* */ obj);

//       Method: virtual void vtkDataObject::Crop(const int* updateExtent)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_Crop_0")] public static extern 
bool Crop(IntPtr /*vtkDataObject* */ obj, IntPtr/*const int* */ updateExtent);

//       Method: virtual vtkDataSetAttributes * vtkDataObject::GetAttributes(int type)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_GetAttributes_0")] public static extern 
bool GetAttributes(IntPtr /*vtkDataSetAttributes** */ ret, IntPtr /*vtkDataObject* */ obj, int type);

//       Method: virtual vtkFieldData * vtkDataObject::GetAttributesAsFieldData(int type)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_GetAttributesAsFieldData_0")] public static extern 
bool GetAttributesAsFieldData(IntPtr /*vtkFieldData** */ ret, IntPtr /*vtkDataObject* */ obj, int type);

//       Method: virtual int vtkDataObject::GetAttributeTypeForArray(vtkAbstractArray* arr)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_GetAttributeTypeForArray_0")] public static extern 
bool GetAttributeTypeForArray(IntPtr /*int* */ ret, IntPtr /*vtkDataObject* */ obj, IntPtr/*vtkAbstractArray* */ arr);

//       Method: virtual vtkIdType vtkDataObject::GetNumberOfElements(int type)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataObject_GetNumberOfElements_0")] public static extern 
bool GetNumberOfElements(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkDataObject* */ obj, int type);

//       Method: static int vtkDataObject::GetAssociationTypeFromString(const char* associationType)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_GetAssociationTypeFromString_0")] public static extern 
bool GetAssociationTypeFromString(IntPtr /*int* */ ret, IntPtr/*const char* */ associationType);

//       Method: static vtkInformationStringKey * vtkDataObject::DATA_TYPE_NAME()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_DATA_TYPE_NAME_0")] public static extern 
bool DATA_TYPE_NAME(IntPtr /*vtkInformationStringKey** */ ret);

//       Method: static vtkInformationDataObjectKey * vtkDataObject::DATA_OBJECT()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_DATA_OBJECT_0")] public static extern 
bool DATA_OBJECT(IntPtr /*vtkInformationDataObjectKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkDataObject::DATA_EXTENT_TYPE()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_DATA_EXTENT_TYPE_0")] public static extern 
bool DATA_EXTENT_TYPE(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationIntegerPointerKey * vtkDataObject::DATA_EXTENT()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_DATA_EXTENT_0")] public static extern 
bool DATA_EXTENT(IntPtr /*vtkInformationIntegerPointerKey** */ ret);

//       Method: static vtkInformationIntegerVectorKey * vtkDataObject::ALL_PIECES_EXTENT()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_ALL_PIECES_EXTENT_0")] public static extern 
bool ALL_PIECES_EXTENT(IntPtr /*vtkInformationIntegerVectorKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkDataObject::DATA_PIECE_NUMBER()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_DATA_PIECE_NUMBER_0")] public static extern 
bool DATA_PIECE_NUMBER(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkDataObject::DATA_NUMBER_OF_PIECES()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_DATA_NUMBER_OF_PIECES_0")] public static extern 
bool DATA_NUMBER_OF_PIECES(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkDataObject::DATA_NUMBER_OF_GHOST_LEVELS()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_DATA_NUMBER_OF_GHOST_LEVELS_0")] public static extern 
bool DATA_NUMBER_OF_GHOST_LEVELS(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationDoubleKey * vtkDataObject::DATA_TIME_STEP()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_DATA_TIME_STEP_0")] public static extern 
bool DATA_TIME_STEP(IntPtr /*vtkInformationDoubleKey** */ ret);

//       Method: static vtkInformationInformationVectorKey * vtkDataObject::POINT_DATA_VECTOR()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_POINT_DATA_VECTOR_0")] public static extern 
bool POINT_DATA_VECTOR(IntPtr /*vtkInformationInformationVectorKey** */ ret);

//       Method: static vtkInformationInformationVectorKey * vtkDataObject::CELL_DATA_VECTOR()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_CELL_DATA_VECTOR_0")] public static extern 
bool CELL_DATA_VECTOR(IntPtr /*vtkInformationInformationVectorKey** */ ret);

//       Method: static vtkInformationInformationVectorKey * vtkDataObject::VERTEX_DATA_VECTOR()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_VERTEX_DATA_VECTOR_0")] public static extern 
bool VERTEX_DATA_VECTOR(IntPtr /*vtkInformationInformationVectorKey** */ ret);

//       Method: static vtkInformationInformationVectorKey * vtkDataObject::EDGE_DATA_VECTOR()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_EDGE_DATA_VECTOR_0")] public static extern 
bool EDGE_DATA_VECTOR(IntPtr /*vtkInformationInformationVectorKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_ARRAY_TYPE()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_FIELD_ARRAY_TYPE_0")] public static extern 
bool FIELD_ARRAY_TYPE(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_ASSOCIATION()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_FIELD_ASSOCIATION_0")] public static extern 
bool FIELD_ASSOCIATION(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_ATTRIBUTE_TYPE()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_FIELD_ATTRIBUTE_TYPE_0")] public static extern 
bool FIELD_ATTRIBUTE_TYPE(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_ACTIVE_ATTRIBUTE()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_FIELD_ACTIVE_ATTRIBUTE_0")] public static extern 
bool FIELD_ACTIVE_ATTRIBUTE(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_NUMBER_OF_COMPONENTS()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_FIELD_NUMBER_OF_COMPONENTS_0")] public static extern 
bool FIELD_NUMBER_OF_COMPONENTS(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_NUMBER_OF_TUPLES()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_FIELD_NUMBER_OF_TUPLES_0")] public static extern 
bool FIELD_NUMBER_OF_TUPLES(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationIntegerKey * vtkDataObject::FIELD_OPERATION()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_FIELD_OPERATION_0")] public static extern 
bool FIELD_OPERATION(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationDoubleVectorKey * vtkDataObject::FIELD_RANGE()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_FIELD_RANGE_0")] public static extern 
bool FIELD_RANGE(IntPtr /*vtkInformationDoubleVectorKey** */ ret);

//       Method: static vtkInformationIntegerVectorKey * vtkDataObject::PIECE_EXTENT()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_PIECE_EXTENT_0")] public static extern 
bool PIECE_EXTENT(IntPtr /*vtkInformationIntegerVectorKey** */ ret);

//       Method: static vtkInformationStringKey * vtkDataObject::FIELD_NAME()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_FIELD_NAME_0")] public static extern 
bool FIELD_NAME(IntPtr /*vtkInformationStringKey** */ ret);

//       Method: static vtkInformationDoubleVectorKey * vtkDataObject::ORIGIN()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_ORIGIN_0")] public static extern 
bool ORIGIN(IntPtr /*vtkInformationDoubleVectorKey** */ ret);

//       Method: static vtkInformationDoubleVectorKey * vtkDataObject::SPACING()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_SPACING_0")] public static extern 
bool SPACING(IntPtr /*vtkInformationDoubleVectorKey** */ ret);

//       Method: static vtkInformationDoubleVectorKey * vtkDataObject::BOUNDING_BOX()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_BOUNDING_BOX_0")] public static extern 
bool BOUNDING_BOX(IntPtr /*vtkInformationDoubleVectorKey** */ ret);

//       Method: static vtkInformationDataObjectKey * vtkDataObject::SIL()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_SIL_0")] public static extern 
bool SIL(IntPtr /*vtkInformationDataObjectKey** */ ret);

//       Method: static vtkDataObject * vtkDataObject::GetData(vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_GetData_0")] public static extern 
bool GetData(IntPtr /*vtkDataObject** */ ret, IntPtr/*vtkInformation* */ info);

//       Method: static vtkDataObject * vtkDataObject::GetData(vtkInformationVector* v, int i)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataObject_GetData_1")] public static extern 
bool GetData(IntPtr /*vtkDataObject** */ ret, IntPtr/*vtkInformationVector* */ v, int i);

}
};
