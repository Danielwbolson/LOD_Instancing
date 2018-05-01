
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkDataSetAttributes {

// static vtkDataSetAttributes* New()
// static vtkDataSetAttributes *New()
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_New_0")] public static extern 
bool New_0(IntPtr /*(vtkDataSetAttributes**)*/ return_value);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject);

// virtual void Update()
// virtual void Update()
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_Update_0")] public static extern 
bool Update_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject);

// void DeepCopy(vtkFieldData * pd)
// void DeepCopy(vtkFieldData *pd)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkFieldData*)*/ pd);

// void ShallowCopy(vtkFieldData * pd)
// void ShallowCopy(vtkFieldData *pd)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkFieldData*)*/ pd);

// static char* GhostArrayName()
// static const char* GhostArrayName()
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GhostArrayName_0")] public static extern 
bool GhostArrayName_0(IntPtr /*(char**)*/ return_value);

// int SetScalars(vtkDataArray * da)
// int SetScalars(vtkDataArray* da)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetScalars_0")] public static extern 
bool SetScalars_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ da);

// int SetActiveScalars(const char * name)
// int SetActiveScalars(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetActiveScalars_0")] public static extern 
bool SetActiveScalars_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkDataArray* GetScalars()
// vtkDataArray* GetScalars()
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetScalars_0")] public static extern 
bool GetScalars_0(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject);

// int SetVectors(vtkDataArray * da)
// int SetVectors(vtkDataArray* da)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetVectors_0")] public static extern 
bool SetVectors_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ da);

// int SetActiveVectors(const char * name)
// int SetActiveVectors(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetActiveVectors_0")] public static extern 
bool SetActiveVectors_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkDataArray* GetVectors()
// vtkDataArray* GetVectors()
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetVectors_0")] public static extern 
bool GetVectors_0(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject);

// int SetNormals(vtkDataArray * da)
// int SetNormals(vtkDataArray* da)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetNormals_0")] public static extern 
bool SetNormals_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ da);

// int SetActiveNormals(const char * name)
// int SetActiveNormals(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetActiveNormals_0")] public static extern 
bool SetActiveNormals_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkDataArray* GetNormals()
// vtkDataArray* GetNormals()
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetNormals_0")] public static extern 
bool GetNormals_0(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject);

// int SetTCoords(vtkDataArray * da)
// int SetTCoords(vtkDataArray* da)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetTCoords_0")] public static extern 
bool SetTCoords_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ da);

// int SetActiveTCoords(const char * name)
// int SetActiveTCoords(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetActiveTCoords_0")] public static extern 
bool SetActiveTCoords_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkDataArray* GetTCoords()
// vtkDataArray* GetTCoords()
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetTCoords_0")] public static extern 
bool GetTCoords_0(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject);

// int SetTensors(vtkDataArray * da)
// int SetTensors(vtkDataArray* da)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetTensors_0")] public static extern 
bool SetTensors_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ da);

// int SetActiveTensors(const char * name)
// int SetActiveTensors(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetActiveTensors_0")] public static extern 
bool SetActiveTensors_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkDataArray* GetTensors()
// vtkDataArray* GetTensors()
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetTensors_0")] public static extern 
bool GetTensors_0(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject);

// int SetGlobalIds(vtkDataArray * da)
// int SetGlobalIds(vtkDataArray* da)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetGlobalIds_0")] public static extern 
bool SetGlobalIds_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ da);

// int SetActiveGlobalIds(const char * name)
// int SetActiveGlobalIds(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetActiveGlobalIds_0")] public static extern 
bool SetActiveGlobalIds_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkDataArray* GetGlobalIds()
// vtkDataArray* GetGlobalIds()
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetGlobalIds_0")] public static extern 
bool GetGlobalIds_0(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject);

// int SetPedigreeIds(vtkAbstractArray * da)
// int SetPedigreeIds(vtkAbstractArray* da)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetPedigreeIds_0")] public static extern 
bool SetPedigreeIds_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ da);

// int SetActivePedigreeIds(const char * name)
// int SetActivePedigreeIds(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetActivePedigreeIds_0")] public static extern 
bool SetActivePedigreeIds_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkAbstractArray* GetPedigreeIds()
// vtkAbstractArray* GetPedigreeIds()
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetPedigreeIds_0")] public static extern 
bool GetPedigreeIds_0(IntPtr /*(vtkAbstractArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject);

// vtkDataArray* GetScalars(const char * name)
// vtkDataArray* GetScalars(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetScalars_1")] public static extern 
bool GetScalars_1(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkDataArray* GetVectors(const char * name)
// vtkDataArray* GetVectors(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetVectors_1")] public static extern 
bool GetVectors_1(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkDataArray* GetNormals(const char * name)
// vtkDataArray* GetNormals(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetNormals_1")] public static extern 
bool GetNormals_1(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkDataArray* GetTCoords(const char * name)
// vtkDataArray* GetTCoords(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetTCoords_1")] public static extern 
bool GetTCoords_1(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkDataArray* GetTensors(const char * name)
// vtkDataArray* GetTensors(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetTensors_1")] public static extern 
bool GetTensors_1(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkDataArray* GetGlobalIds(const char * name)
// vtkDataArray* GetGlobalIds(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetGlobalIds_1")] public static extern 
bool GetGlobalIds_1(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// vtkAbstractArray* GetPedigreeIds(const char * name)
// vtkAbstractArray* GetPedigreeIds(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetPedigreeIds_1")] public static extern 
bool GetPedigreeIds_1(IntPtr /*(vtkAbstractArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name);

// int SetActiveAttribute(const char * name, int attributeType)
// int SetActiveAttribute(const char* name, int attributeType)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetActiveAttribute_0")] public static extern 
bool SetActiveAttribute_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(char*)*/ name, int /*(int)*/ attributeType);

// int SetActiveAttribute(int index, int attributeType)
// int SetActiveAttribute(int index, int attributeType)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetActiveAttribute_1")] public static extern 
bool SetActiveAttribute_1(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, int /*(int)*/ index, int /*(int)*/ attributeType);

// void GetAttributeIndices(int * indexArray)
// void GetAttributeIndices(int* indexArray)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetAttributeIndices_0")] public static extern 
bool GetAttributeIndices_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(int*)*/ indexArray);

// int IsArrayAnAttribute(int idx)
// int IsArrayAnAttribute(int idx)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_IsArrayAnAttribute_0")] public static extern 
bool IsArrayAnAttribute_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, int /*(int)*/ idx);

// int SetAttribute(vtkAbstractArray * aa, int attributeType)
// int SetAttribute(vtkAbstractArray* aa, int attributeType)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetAttribute_0")] public static extern 
bool SetAttribute_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ aa, int /*(int)*/ attributeType);

// vtkDataArray* GetAttribute(int attributeType)
// vtkDataArray* GetAttribute(int attributeType)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetAttribute_0")] public static extern 
bool GetAttribute_0(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, int /*(int)*/ attributeType);

// vtkAbstractArray* GetAbstractAttribute(int attributeType)
// vtkAbstractArray* GetAbstractAttribute(int attributeType)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetAbstractAttribute_0")] public static extern 
bool GetAbstractAttribute_0(IntPtr /*(vtkAbstractArray**)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, int /*(int)*/ attributeType);

// void RemoveArray(int index)
// void RemoveArray(int index)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_RemoveArray_0")] public static extern 
bool RemoveArray_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, int /*(int)*/ index);

// static char* GetAttributeTypeAsString(int attributeType)
// static const char* GetAttributeTypeAsString(int attributeType)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetAttributeTypeAsString_0")] public static extern 
bool GetAttributeTypeAsString_0(IntPtr /*(char**)*/ return_value, int /*(int)*/ attributeType);

// static char* GetLongAttributeTypeAsString(int attributeType)
// static const char* GetLongAttributeTypeAsString(int attributeType)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetLongAttributeTypeAsString_0")] public static extern 
bool GetLongAttributeTypeAsString_0(IntPtr /*(char**)*/ return_value, int /*(int)*/ attributeType);

// int GetCopyAttribute(int index, int ctype)
// int GetCopyAttribute (int index, int ctype)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_GetCopyAttribute_0")] public static extern 
bool GetCopyAttribute_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataSetAttributes*)*/ callingObject, int /*(int)*/ index, int /*(int)*/ ctype);

// void PassData(vtkFieldData * fd)
// void PassData(vtkFieldData* fd)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_PassData_0")] public static extern 
bool PassData_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkFieldData*)*/ fd);

// void CopyAllocate(vtkDataSetAttributes * pd, vtkIdType sze = 0, vtkIdType ext = 1000)
// void CopyAllocate(vtkDataSetAttributes* pd, vtkIdType sze=0, vtkIdType ext=1000)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_CopyAllocate_0")] public static extern 
bool CopyAllocate_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ pd, long /*(vtkIdType)*/ sze, long /*(vtkIdType)*/ ext);

// void CopyAllocate(vtkDataSetAttributes * pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)
// void CopyAllocate(vtkDataSetAttributes* pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_CopyAllocate_1")] public static extern 
bool CopyAllocate_1(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ pd, long /*(vtkIdType)*/ sze, long /*(vtkIdType)*/ ext, int /*(int)*/ shallowCopyArrays);

// void SetupForCopy(vtkDataSetAttributes * pd)
// void SetupForCopy(vtkDataSetAttributes* pd)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_SetupForCopy_0")] public static extern 
bool SetupForCopy_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ pd);

// void CopyStructuredData(vtkDataSetAttributes * inDsa, const int * inExt, const int * outExt, bool setSize = true)
// void CopyStructuredData(vtkDataSetAttributes *inDsa, const int *inExt, const int *outExt, bool setSize = true)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_CopyStructuredData_0")] public static extern 
bool CopyStructuredData_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ inDsa, IntPtr /*(int*)*/ inExt, IntPtr /*(int*)*/ outExt, bool /*(bool)*/ setSize);

// void CopyData(vtkDataSetAttributes * fromPd, vtkIdType fromId, vtkIdType toId)
// void CopyData(vtkDataSetAttributes *fromPd, vtkIdType fromId, vtkIdType toId)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_CopyData_0")] public static extern 
bool CopyData_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ fromPd, long /*(vtkIdType)*/ fromId, long /*(vtkIdType)*/ toId);

// void CopyData(vtkDataSetAttributes * fromPd, vtkIdList * fromIds, vtkIdList * toIds)
// void CopyData(vtkDataSetAttributes *fromPd, vtkIdList *fromIds, vtkIdList *toIds)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_CopyData_1")] public static extern 
bool CopyData_1(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ fromPd, IntPtr /*(vtkIdList*)*/ fromIds, IntPtr /*(vtkIdList*)*/ toIds);

// void CopyData(vtkDataSetAttributes * fromPd, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
// void CopyData(vtkDataSetAttributes *fromPd, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_CopyData_2")] public static extern 
bool CopyData_2(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ fromPd, long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart);

// void CopyTuple(vtkAbstractArray * fromData, vtkAbstractArray * toData, vtkIdType fromId, vtkIdType toId)
// void CopyTuple(vtkAbstractArray *fromData, vtkAbstractArray *toData, vtkIdType fromId, vtkIdType toId)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_CopyTuple_0")] public static extern 
bool CopyTuple_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ fromData, IntPtr /*(vtkAbstractArray*)*/ toData, long /*(vtkIdType)*/ fromId, long /*(vtkIdType)*/ toId);

// void CopyTuples(vtkAbstractArray * fromData, vtkAbstractArray * toData, vtkIdList * fromIds, vtkIdList * toIds)
// void CopyTuples(vtkAbstractArray *fromData, vtkAbstractArray *toData, vtkIdList *fromIds, vtkIdList *toIds)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_CopyTuples_0")] public static extern 
bool CopyTuples_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ fromData, IntPtr /*(vtkAbstractArray*)*/ toData, IntPtr /*(vtkIdList*)*/ fromIds, IntPtr /*(vtkIdList*)*/ toIds);

// void CopyTuples(vtkAbstractArray * fromData, vtkAbstractArray * toData, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
// void CopyTuples(vtkAbstractArray *fromData, vtkAbstractArray *toData, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_CopyTuples_1")] public static extern 
bool CopyTuples_1(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ fromData, IntPtr /*(vtkAbstractArray*)*/ toData, long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart);

// void InterpolateAllocate(vtkDataSetAttributes * pd, vtkIdType sze = 0, vtkIdType ext = 1000)
// void InterpolateAllocate(vtkDataSetAttributes* pd, vtkIdType sze=0, vtkIdType ext=1000)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_InterpolateAllocate_0")] public static extern 
bool InterpolateAllocate_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ pd, long /*(vtkIdType)*/ sze, long /*(vtkIdType)*/ ext);

// void InterpolateAllocate(vtkDataSetAttributes * pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)
// void InterpolateAllocate(vtkDataSetAttributes* pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_InterpolateAllocate_1")] public static extern 
bool InterpolateAllocate_1(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ pd, long /*(vtkIdType)*/ sze, long /*(vtkIdType)*/ ext, int /*(int)*/ shallowCopyArrays);

// void InterpolatePoint(vtkDataSetAttributes * fromPd, vtkIdType toId, vtkIdList * ids, double * weights)
// void InterpolatePoint(vtkDataSetAttributes *fromPd, vtkIdType toId, vtkIdList *ids, double *weights)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_InterpolatePoint_0")] public static extern 
bool InterpolatePoint_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ fromPd, long /*(vtkIdType)*/ toId, IntPtr /*(vtkIdList*)*/ ids, IntPtr /*(double*)*/ weights);

// void InterpolateEdge(vtkDataSetAttributes * fromPd, vtkIdType toId, vtkIdType p1, vtkIdType p2, double t)
// void InterpolateEdge(vtkDataSetAttributes *fromPd, vtkIdType toId, vtkIdType p1, vtkIdType p2, double t)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_InterpolateEdge_0")] public static extern 
bool InterpolateEdge_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ fromPd, long /*(vtkIdType)*/ toId, long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, double /*(double)*/ t);

// void InterpolateTime(vtkDataSetAttributes * from1, vtkDataSetAttributes * from2, vtkIdType id, double t)
// void InterpolateTime(vtkDataSetAttributes *from1, vtkDataSetAttributes *from2, vtkIdType id, double t)
[DllImport("vtkplugin", EntryPoint="vtkDataSetAttributes_InterpolateTime_0")] public static extern 
bool InterpolateTime_0(IntPtr /*(vtkDataSetAttributes*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ from1, IntPtr /*(vtkDataSetAttributes*)*/ from2, long /*(vtkIdType)*/ id, double /*(double)*/ t);

}
};
