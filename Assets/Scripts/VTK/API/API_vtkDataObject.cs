
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkDataObject {

// static vtkDataObject* New()
// static vtkDataObject *New()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_New_0")] public static extern 
bool vtkDataObject_New_0(IntPtr /*(vtkDataObject**)*/ return_value);

// virtual void SetInformation(vtkInformation * ARG_0)
// virtual void SetInformation(vtkInformation*)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetInformation_0")] public static extern 
bool vtkDataObject_SetInformation_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkInformation*)*/ ARG_0);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetMTime_0")] public static extern 
bool vtkDataObject_GetMTime_0(IntPtr /*(vtkMTimeType*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void Initialize()
// virtual void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_Initialize_0")] public static extern 
bool vtkDataObject_Initialize_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// void ReleaseData()
// void ReleaseData()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_ReleaseData_0")] public static extern 
bool vtkDataObject_ReleaseData_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// static void SetGlobalReleaseDataFlag(int val)
// static void SetGlobalReleaseDataFlag(int val)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetGlobalReleaseDataFlag_0")] public static extern 
bool vtkDataObject_SetGlobalReleaseDataFlag_0(int /*(int)*/ val);

// void GlobalReleaseDataFlagOn()
// void GlobalReleaseDataFlagOn()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GlobalReleaseDataFlagOn_0")] public static extern 
bool vtkDataObject_GlobalReleaseDataFlagOn_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// void GlobalReleaseDataFlagOff()
// void GlobalReleaseDataFlagOff()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GlobalReleaseDataFlagOff_0")] public static extern 
bool vtkDataObject_GlobalReleaseDataFlagOff_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// static int GetGlobalReleaseDataFlag()
// static int GetGlobalReleaseDataFlag()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetGlobalReleaseDataFlag_0")] public static extern 
bool vtkDataObject_GetGlobalReleaseDataFlag_0(IntPtr /*(int*)*/ return_value);

// virtual void SetFieldData(vtkFieldData * ARG_0)
// virtual void SetFieldData(vtkFieldData*)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetFieldData_0")] public static extern 
bool vtkDataObject_SetFieldData_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkFieldData*)*/ ARG_0);

// virtual int GetDataObjectType()
// virtual int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetDataObjectType_0")] public static extern 
bool vtkDataObject_GetDataObjectType_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// vtkMTimeType GetUpdateTime()
// vtkMTimeType GetUpdateTime()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetUpdateTime_0")] public static extern 
bool vtkDataObject_GetUpdateTime_0(IntPtr /*(vtkMTimeType*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual long GetActualMemorySize()
// virtual unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetActualMemorySize_0")] public static extern 
bool vtkDataObject_GetActualMemorySize_0(IntPtr /*(long*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// static vtkInformation* GetActiveFieldInformation(vtkInformation * info, int fieldAssociation, int attributeType)
// static vtkInformation *GetActiveFieldInformation(vtkInformation *info, int fieldAssociation, int attributeType)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetActiveFieldInformation_0")] public static extern 
bool vtkDataObject_GetActiveFieldInformation_0(IntPtr /*(vtkInformation**)*/ return_value, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, int /*(int)*/ attributeType);

// static vtkInformation* GetNamedFieldInformation(vtkInformation * info, int fieldAssociation, const char * name)
// static vtkInformation *GetNamedFieldInformation(vtkInformation *info, int fieldAssociation, const char *name)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetNamedFieldInformation_0")] public static extern 
bool vtkDataObject_GetNamedFieldInformation_0(IntPtr /*(vtkInformation**)*/ return_value, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, IntPtr /*(char*)*/ name);

// static void RemoveNamedFieldInformation(vtkInformation * info, int fieldAssociation, const char * name)
// static void RemoveNamedFieldInformation(vtkInformation *info, int fieldAssociation, const char *name)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_RemoveNamedFieldInformation_0")] public static extern 
bool vtkDataObject_RemoveNamedFieldInformation_0(IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, IntPtr /*(char*)*/ name);

// static vtkInformation* SetActiveAttribute(vtkInformation * info, int fieldAssociation, const char * attributeName, int attributeType)
// static vtkInformation *SetActiveAttribute(vtkInformation *info, int fieldAssociation, const char *attributeName, int attributeType)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetActiveAttribute_0")] public static extern 
bool vtkDataObject_SetActiveAttribute_0(IntPtr /*(vtkInformation**)*/ return_value, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, IntPtr /*(char*)*/ attributeName, int /*(int)*/ attributeType);

// static void SetActiveAttributeInfo(vtkInformation * info, int fieldAssociation, int attributeType, const char * name, int arrayType, int numComponents, int numTuples)
// static void SetActiveAttributeInfo(vtkInformation *info, int fieldAssociation, int attributeType, const char *name, int arrayType, int numComponents, int numTuples)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetActiveAttributeInfo_0")] public static extern 
bool vtkDataObject_SetActiveAttributeInfo_0(IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, int /*(int)*/ attributeType, IntPtr /*(char*)*/ name, int /*(int)*/ arrayType, int /*(int)*/ numComponents, int /*(int)*/ numTuples);

// static void SetPointDataActiveScalarInfo(vtkInformation * info, int arrayType, int numComponents)
// static void SetPointDataActiveScalarInfo(vtkInformation *info, int arrayType, int numComponents)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetPointDataActiveScalarInfo_0")] public static extern 
bool vtkDataObject_SetPointDataActiveScalarInfo_0(IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ arrayType, int /*(int)*/ numComponents);

// void DataHasBeenGenerated()
// void DataHasBeenGenerated()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DataHasBeenGenerated_0")] public static extern 
bool vtkDataObject_DataHasBeenGenerated_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void PrepareForNewData()
// virtual void PrepareForNewData()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_PrepareForNewData_0")] public static extern 
bool vtkDataObject_PrepareForNewData_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void ShallowCopy(vtkDataObject * src)
// virtual void ShallowCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_ShallowCopy_0")] public static extern 
bool vtkDataObject_ShallowCopy_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// virtual void DeepCopy(vtkDataObject * src)
// virtual void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DeepCopy_0")] public static extern 
bool vtkDataObject_DeepCopy_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// virtual int GetExtentType()
// virtual int GetExtentType()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetExtentType_0")] public static extern 
bool vtkDataObject_GetExtentType_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void Crop(const int * updateExtent)
// virtual void Crop(const int* updateExtent)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_Crop_0")] public static extern 
bool vtkDataObject_Crop_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(int*)*/ updateExtent);

// virtual vtkDataSetAttributes* GetAttributes(int type)
// virtual vtkDataSetAttributes* GetAttributes(int type)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAttributes_0")] public static extern 
bool vtkDataObject_GetAttributes_0(IntPtr /*(vtkDataSetAttributes**)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, int /*(int)*/ type);

// virtual vtkFieldData* GetAttributesAsFieldData(int type)
// virtual vtkFieldData* GetAttributesAsFieldData(int type)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAttributesAsFieldData_0")] public static extern 
bool vtkDataObject_GetAttributesAsFieldData_0(IntPtr /*(vtkFieldData**)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, int /*(int)*/ type);

// virtual int GetAttributeTypeForArray(vtkAbstractArray * arr)
// virtual int GetAttributeTypeForArray(vtkAbstractArray* arr)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAttributeTypeForArray_0")] public static extern 
bool vtkDataObject_GetAttributeTypeForArray_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ arr);

// virtual vtkIdType GetNumberOfElements(int type)
// virtual vtkIdType GetNumberOfElements(int type)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetNumberOfElements_0")] public static extern 
bool vtkDataObject_GetNumberOfElements_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, int /*(int)*/ type);

// static char* GetAssociationTypeAsString(int associationType)
// static const char* GetAssociationTypeAsString(int associationType)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAssociationTypeAsString_0")] public static extern 
bool vtkDataObject_GetAssociationTypeAsString_0(IntPtr /*(char**)*/ return_value, int /*(int)*/ associationType);

// static int GetAssociationTypeFromString(const char * associationType)
// static int GetAssociationTypeFromString(const char* associationType)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAssociationTypeFromString_0")] public static extern 
bool vtkDataObject_GetAssociationTypeFromString_0(IntPtr /*(int*)*/ return_value, IntPtr /*(char*)*/ associationType);

// static vtkInformationStringKey* DATA_TYPE_NAME()
// static vtkInformationStringKey* DATA_TYPE_NAME()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_TYPE_NAME_0")] public static extern 
bool vtkDataObject_DATA_TYPE_NAME_0(IntPtr /*(vtkInformationStringKey**)*/ return_value);

// static vtkInformationDataObjectKey* DATA_OBJECT()
// static vtkInformationDataObjectKey* DATA_OBJECT()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_OBJECT_0")] public static extern 
bool vtkDataObject_DATA_OBJECT_0(IntPtr /*(vtkInformationDataObjectKey**)*/ return_value);

// static vtkInformationIntegerKey* DATA_EXTENT_TYPE()
// static vtkInformationIntegerKey* DATA_EXTENT_TYPE()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_EXTENT_TYPE_0")] public static extern 
bool vtkDataObject_DATA_EXTENT_TYPE_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerPointerKey* DATA_EXTENT()
// static vtkInformationIntegerPointerKey* DATA_EXTENT()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_EXTENT_0")] public static extern 
bool vtkDataObject_DATA_EXTENT_0(IntPtr /*(vtkInformationIntegerPointerKey**)*/ return_value);

// static vtkInformationIntegerVectorKey* ALL_PIECES_EXTENT()
// static vtkInformationIntegerVectorKey* ALL_PIECES_EXTENT()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_ALL_PIECES_EXTENT_0")] public static extern 
bool vtkDataObject_ALL_PIECES_EXTENT_0(IntPtr /*(vtkInformationIntegerVectorKey**)*/ return_value);

// static vtkInformationIntegerKey* DATA_PIECE_NUMBER()
// static vtkInformationIntegerKey* DATA_PIECE_NUMBER()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_PIECE_NUMBER_0")] public static extern 
bool vtkDataObject_DATA_PIECE_NUMBER_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* DATA_NUMBER_OF_PIECES()
// static vtkInformationIntegerKey* DATA_NUMBER_OF_PIECES()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_NUMBER_OF_PIECES_0")] public static extern 
bool vtkDataObject_DATA_NUMBER_OF_PIECES_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* DATA_NUMBER_OF_GHOST_LEVELS()
// static vtkInformationIntegerKey* DATA_NUMBER_OF_GHOST_LEVELS()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_NUMBER_OF_GHOST_LEVELS_0")] public static extern 
bool vtkDataObject_DATA_NUMBER_OF_GHOST_LEVELS_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationDoubleKey* DATA_TIME_STEP()
// static vtkInformationDoubleKey* DATA_TIME_STEP()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_TIME_STEP_0")] public static extern 
bool vtkDataObject_DATA_TIME_STEP_0(IntPtr /*(vtkInformationDoubleKey**)*/ return_value);

// static vtkInformationInformationVectorKey* POINT_DATA_VECTOR()
// static vtkInformationInformationVectorKey* POINT_DATA_VECTOR()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_POINT_DATA_VECTOR_0")] public static extern 
bool vtkDataObject_POINT_DATA_VECTOR_0(IntPtr /*(vtkInformationInformationVectorKey**)*/ return_value);

// static vtkInformationInformationVectorKey* CELL_DATA_VECTOR()
// static vtkInformationInformationVectorKey* CELL_DATA_VECTOR()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_CELL_DATA_VECTOR_0")] public static extern 
bool vtkDataObject_CELL_DATA_VECTOR_0(IntPtr /*(vtkInformationInformationVectorKey**)*/ return_value);

// static vtkInformationInformationVectorKey* VERTEX_DATA_VECTOR()
// static vtkInformationInformationVectorKey* VERTEX_DATA_VECTOR()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_VERTEX_DATA_VECTOR_0")] public static extern 
bool vtkDataObject_VERTEX_DATA_VECTOR_0(IntPtr /*(vtkInformationInformationVectorKey**)*/ return_value);

// static vtkInformationInformationVectorKey* EDGE_DATA_VECTOR()
// static vtkInformationInformationVectorKey* EDGE_DATA_VECTOR()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_EDGE_DATA_VECTOR_0")] public static extern 
bool vtkDataObject_EDGE_DATA_VECTOR_0(IntPtr /*(vtkInformationInformationVectorKey**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_ARRAY_TYPE()
// static vtkInformationIntegerKey* FIELD_ARRAY_TYPE()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_ARRAY_TYPE_0")] public static extern 
bool vtkDataObject_FIELD_ARRAY_TYPE_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_ASSOCIATION()
// static vtkInformationIntegerKey* FIELD_ASSOCIATION()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_ASSOCIATION_0")] public static extern 
bool vtkDataObject_FIELD_ASSOCIATION_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_ATTRIBUTE_TYPE()
// static vtkInformationIntegerKey* FIELD_ATTRIBUTE_TYPE()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_ATTRIBUTE_TYPE_0")] public static extern 
bool vtkDataObject_FIELD_ATTRIBUTE_TYPE_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_ACTIVE_ATTRIBUTE()
// static vtkInformationIntegerKey* FIELD_ACTIVE_ATTRIBUTE()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_ACTIVE_ATTRIBUTE_0")] public static extern 
bool vtkDataObject_FIELD_ACTIVE_ATTRIBUTE_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_NUMBER_OF_COMPONENTS()
// static vtkInformationIntegerKey* FIELD_NUMBER_OF_COMPONENTS()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_NUMBER_OF_COMPONENTS_0")] public static extern 
bool vtkDataObject_FIELD_NUMBER_OF_COMPONENTS_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_NUMBER_OF_TUPLES()
// static vtkInformationIntegerKey* FIELD_NUMBER_OF_TUPLES()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_NUMBER_OF_TUPLES_0")] public static extern 
bool vtkDataObject_FIELD_NUMBER_OF_TUPLES_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_OPERATION()
// static vtkInformationIntegerKey* FIELD_OPERATION()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_OPERATION_0")] public static extern 
bool vtkDataObject_FIELD_OPERATION_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value);

// static vtkInformationDoubleVectorKey* FIELD_RANGE()
// static vtkInformationDoubleVectorKey* FIELD_RANGE()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_RANGE_0")] public static extern 
bool vtkDataObject_FIELD_RANGE_0(IntPtr /*(vtkInformationDoubleVectorKey**)*/ return_value);

// static vtkInformationIntegerVectorKey* PIECE_EXTENT()
// static vtkInformationIntegerVectorKey* PIECE_EXTENT()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_PIECE_EXTENT_0")] public static extern 
bool vtkDataObject_PIECE_EXTENT_0(IntPtr /*(vtkInformationIntegerVectorKey**)*/ return_value);

// static vtkInformationStringKey* FIELD_NAME()
// static vtkInformationStringKey* FIELD_NAME()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_NAME_0")] public static extern 
bool vtkDataObject_FIELD_NAME_0(IntPtr /*(vtkInformationStringKey**)*/ return_value);

// static vtkInformationDoubleVectorKey* ORIGIN()
// static vtkInformationDoubleVectorKey* ORIGIN()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_ORIGIN_0")] public static extern 
bool vtkDataObject_ORIGIN_0(IntPtr /*(vtkInformationDoubleVectorKey**)*/ return_value);

// static vtkInformationDoubleVectorKey* SPACING()
// static vtkInformationDoubleVectorKey* SPACING()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SPACING_0")] public static extern 
bool vtkDataObject_SPACING_0(IntPtr /*(vtkInformationDoubleVectorKey**)*/ return_value);

// static vtkInformationDoubleVectorKey* BOUNDING_BOX()
// static vtkInformationDoubleVectorKey* BOUNDING_BOX()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_BOUNDING_BOX_0")] public static extern 
bool vtkDataObject_BOUNDING_BOX_0(IntPtr /*(vtkInformationDoubleVectorKey**)*/ return_value);

// static vtkInformationDataObjectKey* SIL()
// static vtkInformationDataObjectKey* SIL()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SIL_0")] public static extern 
bool vtkDataObject_SIL_0(IntPtr /*(vtkInformationDataObjectKey**)*/ return_value);

// static vtkDataObject* GetData(vtkInformation * info)
// static vtkDataObject* GetData(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetData_0")] public static extern 
bool vtkDataObject_GetData_0(IntPtr /*(vtkDataObject**)*/ return_value, IntPtr /*(vtkInformation*)*/ info);

// static vtkDataObject* GetData(vtkInformationVector * v, int i = 0)
// static vtkDataObject* GetData(vtkInformationVector* v, int i=0)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetData_1")] public static extern 
bool vtkDataObject_GetData_1(IntPtr /*(vtkDataObject**)*/ return_value, IntPtr /*(vtkInformationVector*)*/ v, int /*(int)*/ i);

}
};
