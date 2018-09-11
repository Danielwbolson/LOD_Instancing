
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkDataObject {

// static vtkDataObject* New()
// static vtkDataObject *New()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, string /*(char*)*/ type);

// static vtkDataObject* SafeDownCast(vtkObjectBase * o)
// static vtkDataObject* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkDataObject* NewInstance()
// vtkDataObject *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual vtkInformation* GetInformation()
// virtual vtkInformation *GetInformation ()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetInformation_0")] public static extern 
bool GetInformation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void SetInformation(vtkInformation * ARG_0)
// virtual void SetInformation(vtkInformation*)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetInformation_0")] public static extern 
bool SetInformation_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkInformation*)*/ ARG_0);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void Initialize()
// virtual void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// void ReleaseData()
// void ReleaseData()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_ReleaseData_0")] public static extern 
bool ReleaseData_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual int GetDataReleased()
// virtual int GetDataReleased ()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetDataReleased_0")] public static extern 
bool GetDataReleased_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// static void SetGlobalReleaseDataFlag(int val)
// static void SetGlobalReleaseDataFlag(int val)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetGlobalReleaseDataFlag_0")] public static extern 
bool SetGlobalReleaseDataFlag_0(int /*(int)*/ val);

// void GlobalReleaseDataFlagOn()
// void GlobalReleaseDataFlagOn()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GlobalReleaseDataFlagOn_0")] public static extern 
bool GlobalReleaseDataFlagOn_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// void GlobalReleaseDataFlagOff()
// void GlobalReleaseDataFlagOff()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GlobalReleaseDataFlagOff_0")] public static extern 
bool GlobalReleaseDataFlagOff_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// static int GetGlobalReleaseDataFlag()
// static int GetGlobalReleaseDataFlag()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetGlobalReleaseDataFlag_0")] public static extern 
bool GetGlobalReleaseDataFlag_0(IntPtr /*(IntPtr*)*/ return_value);

// virtual void SetFieldData(vtkFieldData * ARG_0)
// virtual void SetFieldData(vtkFieldData*)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetFieldData_0")] public static extern 
bool SetFieldData_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkFieldData*)*/ ARG_0);

// virtual vtkFieldData* GetFieldData()
// virtual vtkFieldData *GetFieldData ()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetFieldData_0")] public static extern 
bool GetFieldData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual int GetDataObjectType()
// virtual int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// vtkMTimeType GetUpdateTime()
// vtkMTimeType GetUpdateTime()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetUpdateTime_0")] public static extern 
bool GetUpdateTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual long GetActualMemorySize()
// virtual unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetActualMemorySize_0")] public static extern 
bool GetActualMemorySize_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void CopyInformationFromPipeline(vtkInformation * ARG_0)
// virtual void CopyInformationFromPipeline(vtkInformation* )
[DllImport("vtkplugin", EntryPoint="vtkDataObject_CopyInformationFromPipeline_0")] public static extern 
bool CopyInformationFromPipeline_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkInformation*)*/ ARG_0);

// virtual void CopyInformationToPipeline(vtkInformation * ARG_0)
// virtual void CopyInformationToPipeline(vtkInformation* )
[DllImport("vtkplugin", EntryPoint="vtkDataObject_CopyInformationToPipeline_0")] public static extern 
bool CopyInformationToPipeline_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkInformation*)*/ ARG_0);

// static vtkInformation* GetActiveFieldInformation(vtkInformation * info, int fieldAssociation, int attributeType)
// static vtkInformation *GetActiveFieldInformation(vtkInformation *info, int fieldAssociation, int attributeType)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetActiveFieldInformation_0")] public static extern 
bool GetActiveFieldInformation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, int /*(int)*/ attributeType);

// static vtkInformation* GetNamedFieldInformation(vtkInformation * info, int fieldAssociation, const char * name)
// static vtkInformation *GetNamedFieldInformation(vtkInformation *info, int fieldAssociation, const char *name)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetNamedFieldInformation_0")] public static extern 
bool GetNamedFieldInformation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, string /*(char*)*/ name);

// static void RemoveNamedFieldInformation(vtkInformation * info, int fieldAssociation, const char * name)
// static void RemoveNamedFieldInformation(vtkInformation *info, int fieldAssociation, const char *name)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_RemoveNamedFieldInformation_0")] public static extern 
bool RemoveNamedFieldInformation_0(IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, string /*(char*)*/ name);

// static vtkInformation* SetActiveAttribute(vtkInformation * info, int fieldAssociation, const char * attributeName, int attributeType)
// static vtkInformation *SetActiveAttribute(vtkInformation *info, int fieldAssociation, const char *attributeName, int attributeType)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetActiveAttribute_0")] public static extern 
bool SetActiveAttribute_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, string /*(char*)*/ attributeName, int /*(int)*/ attributeType);

// static void SetActiveAttributeInfo(vtkInformation * info, int fieldAssociation, int attributeType, const char * name, int arrayType, int numComponents, int numTuples)
// static void SetActiveAttributeInfo(vtkInformation *info, int fieldAssociation, int attributeType, const char *name, int arrayType, int numComponents, int numTuples)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetActiveAttributeInfo_0")] public static extern 
bool SetActiveAttributeInfo_0(IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ fieldAssociation, int /*(int)*/ attributeType, string /*(char*)*/ name, int /*(int)*/ arrayType, int /*(int)*/ numComponents, int /*(int)*/ numTuples);

// static void SetPointDataActiveScalarInfo(vtkInformation * info, int arrayType, int numComponents)
// static void SetPointDataActiveScalarInfo(vtkInformation *info, int arrayType, int numComponents)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetPointDataActiveScalarInfo_0")] public static extern 
bool SetPointDataActiveScalarInfo_0(IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ arrayType, int /*(int)*/ numComponents);

// void DataHasBeenGenerated()
// void DataHasBeenGenerated()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DataHasBeenGenerated_0")] public static extern 
bool DataHasBeenGenerated_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void PrepareForNewData()
// virtual void PrepareForNewData()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_PrepareForNewData_0")] public static extern 
bool PrepareForNewData_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void ShallowCopy(vtkDataObject * src)
// virtual void ShallowCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// virtual void DeepCopy(vtkDataObject * src)
// virtual void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// virtual int GetExtentType()
// virtual int GetExtentType()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetExtentType_0")] public static extern 
bool GetExtentType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void Crop(const int * updateExtent)
// virtual void Crop(const int* updateExtent)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_Crop_0")] public static extern 
bool Crop_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(int*)*/ updateExtent);

// virtual vtkDataSetAttributes* GetAttributes(int type)
// virtual vtkDataSetAttributes* GetAttributes(int type)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAttributes_0")] public static extern 
bool GetAttributes_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, int /*(int)*/ type);

// virtual vtkFieldData* GetAttributesAsFieldData(int type)
// virtual vtkFieldData* GetAttributesAsFieldData(int type)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAttributesAsFieldData_0")] public static extern 
bool GetAttributesAsFieldData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, int /*(int)*/ type);

// virtual int GetAttributeTypeForArray(vtkAbstractArray * arr)
// virtual int GetAttributeTypeForArray(vtkAbstractArray* arr)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAttributeTypeForArray_0")] public static extern 
bool GetAttributeTypeForArray_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ arr);

// virtual vtkIdType GetNumberOfElements(int type)
// virtual vtkIdType GetNumberOfElements(int type)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetNumberOfElements_0")] public static extern 
bool GetNumberOfElements_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, int /*(int)*/ type);

// static char* GetAssociationTypeAsString(int associationType)
// static const char* GetAssociationTypeAsString(int associationType)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAssociationTypeAsString_0")] public static extern 
bool GetAssociationTypeAsString_0(IntPtr /*(IntPtr**)*/ return_value, int /*(int)*/ associationType);

// static int GetAssociationTypeFromString(const char * associationType)
// static int GetAssociationTypeFromString(const char* associationType)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAssociationTypeFromString_0")] public static extern 
bool GetAssociationTypeFromString_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ associationType);

// static vtkInformationStringKey* DATA_TYPE_NAME()
// static vtkInformationStringKey* DATA_TYPE_NAME()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_TYPE_NAME_0")] public static extern 
bool DATA_TYPE_NAME_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationDataObjectKey* DATA_OBJECT()
// static vtkInformationDataObjectKey* DATA_OBJECT()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_OBJECT_0")] public static extern 
bool DATA_OBJECT_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* DATA_EXTENT_TYPE()
// static vtkInformationIntegerKey* DATA_EXTENT_TYPE()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_EXTENT_TYPE_0")] public static extern 
bool DATA_EXTENT_TYPE_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerPointerKey* DATA_EXTENT()
// static vtkInformationIntegerPointerKey* DATA_EXTENT()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_EXTENT_0")] public static extern 
bool DATA_EXTENT_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerVectorKey* ALL_PIECES_EXTENT()
// static vtkInformationIntegerVectorKey* ALL_PIECES_EXTENT()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_ALL_PIECES_EXTENT_0")] public static extern 
bool ALL_PIECES_EXTENT_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* DATA_PIECE_NUMBER()
// static vtkInformationIntegerKey* DATA_PIECE_NUMBER()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_PIECE_NUMBER_0")] public static extern 
bool DATA_PIECE_NUMBER_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* DATA_NUMBER_OF_PIECES()
// static vtkInformationIntegerKey* DATA_NUMBER_OF_PIECES()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_NUMBER_OF_PIECES_0")] public static extern 
bool DATA_NUMBER_OF_PIECES_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* DATA_NUMBER_OF_GHOST_LEVELS()
// static vtkInformationIntegerKey* DATA_NUMBER_OF_GHOST_LEVELS()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_NUMBER_OF_GHOST_LEVELS_0")] public static extern 
bool DATA_NUMBER_OF_GHOST_LEVELS_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationDoubleKey* DATA_TIME_STEP()
// static vtkInformationDoubleKey* DATA_TIME_STEP()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DATA_TIME_STEP_0")] public static extern 
bool DATA_TIME_STEP_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationInformationVectorKey* POINT_DATA_VECTOR()
// static vtkInformationInformationVectorKey* POINT_DATA_VECTOR()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_POINT_DATA_VECTOR_0")] public static extern 
bool POINT_DATA_VECTOR_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationInformationVectorKey* CELL_DATA_VECTOR()
// static vtkInformationInformationVectorKey* CELL_DATA_VECTOR()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_CELL_DATA_VECTOR_0")] public static extern 
bool CELL_DATA_VECTOR_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationInformationVectorKey* VERTEX_DATA_VECTOR()
// static vtkInformationInformationVectorKey* VERTEX_DATA_VECTOR()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_VERTEX_DATA_VECTOR_0")] public static extern 
bool VERTEX_DATA_VECTOR_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationInformationVectorKey* EDGE_DATA_VECTOR()
// static vtkInformationInformationVectorKey* EDGE_DATA_VECTOR()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_EDGE_DATA_VECTOR_0")] public static extern 
bool EDGE_DATA_VECTOR_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_ARRAY_TYPE()
// static vtkInformationIntegerKey* FIELD_ARRAY_TYPE()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_ARRAY_TYPE_0")] public static extern 
bool FIELD_ARRAY_TYPE_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_ASSOCIATION()
// static vtkInformationIntegerKey* FIELD_ASSOCIATION()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_ASSOCIATION_0")] public static extern 
bool FIELD_ASSOCIATION_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_ATTRIBUTE_TYPE()
// static vtkInformationIntegerKey* FIELD_ATTRIBUTE_TYPE()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_ATTRIBUTE_TYPE_0")] public static extern 
bool FIELD_ATTRIBUTE_TYPE_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_ACTIVE_ATTRIBUTE()
// static vtkInformationIntegerKey* FIELD_ACTIVE_ATTRIBUTE()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_ACTIVE_ATTRIBUTE_0")] public static extern 
bool FIELD_ACTIVE_ATTRIBUTE_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_NUMBER_OF_COMPONENTS()
// static vtkInformationIntegerKey* FIELD_NUMBER_OF_COMPONENTS()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_NUMBER_OF_COMPONENTS_0")] public static extern 
bool FIELD_NUMBER_OF_COMPONENTS_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_NUMBER_OF_TUPLES()
// static vtkInformationIntegerKey* FIELD_NUMBER_OF_TUPLES()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_NUMBER_OF_TUPLES_0")] public static extern 
bool FIELD_NUMBER_OF_TUPLES_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerKey* FIELD_OPERATION()
// static vtkInformationIntegerKey* FIELD_OPERATION()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_OPERATION_0")] public static extern 
bool FIELD_OPERATION_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationDoubleVectorKey* FIELD_RANGE()
// static vtkInformationDoubleVectorKey* FIELD_RANGE()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_RANGE_0")] public static extern 
bool FIELD_RANGE_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationIntegerVectorKey* PIECE_EXTENT()
// static vtkInformationIntegerVectorKey* PIECE_EXTENT()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_PIECE_EXTENT_0")] public static extern 
bool PIECE_EXTENT_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationStringKey* FIELD_NAME()
// static vtkInformationStringKey* FIELD_NAME()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_FIELD_NAME_0")] public static extern 
bool FIELD_NAME_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationDoubleVectorKey* ORIGIN()
// static vtkInformationDoubleVectorKey* ORIGIN()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_ORIGIN_0")] public static extern 
bool ORIGIN_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationDoubleVectorKey* SPACING()
// static vtkInformationDoubleVectorKey* SPACING()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SPACING_0")] public static extern 
bool SPACING_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationDoubleVectorKey* BOUNDING_BOX()
// static vtkInformationDoubleVectorKey* BOUNDING_BOX()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_BOUNDING_BOX_0")] public static extern 
bool BOUNDING_BOX_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationDataObjectKey* SIL()
// static vtkInformationDataObjectKey* SIL()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SIL_0")] public static extern 
bool SIL_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkDataObject* GetData(vtkInformation * info)
// static vtkDataObject* GetData(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetData_0")] public static extern 
bool GetData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformation*)*/ info);

// static vtkDataObject* GetData(vtkInformationVector * v, int i = 0)
// static vtkDataObject* GetData(vtkInformationVector* v, int i=0)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetData_1")] public static extern 
bool GetData_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationVector*)*/ v, int /*(int)*/ i);

}
};
