
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkSelectionNode {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkSelectionNode*)*/ callingObject, string /*(char*)*/ type);

// static vtkSelectionNode* SafeDownCast(vtkObjectBase * o)
// static vtkSelectionNode* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkSelectionNode* NewInstance()
// vtkSelectionNode *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkSelectionNode*)*/ callingObject);

// static vtkSelectionNode* New()
// static vtkSelectionNode* New()
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual void Initialize()
// virtual void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkSelectionNode*)*/ callingObject);

// virtual void SetSelectionList(vtkAbstractArray * ARG_0)
// virtual void SetSelectionList(vtkAbstractArray*)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_SetSelectionList_0")] public static extern 
bool SetSelectionList_0(IntPtr /*(vtkSelectionNode*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ ARG_0);

// virtual vtkAbstractArray* GetSelectionList()
// virtual vtkAbstractArray* GetSelectionList()
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_GetSelectionList_0")] public static extern 
bool GetSelectionList_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkSelectionNode*)*/ callingObject);

// virtual void SetSelectionData(vtkDataSetAttributes * data)
// virtual void SetSelectionData(vtkDataSetAttributes* data)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_SetSelectionData_0")] public static extern 
bool SetSelectionData_0(IntPtr /*(vtkSelectionNode*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ data);

// virtual vtkDataSetAttributes* GetSelectionData()
// virtual vtkDataSetAttributes *GetSelectionData ()
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_GetSelectionData_0")] public static extern 
bool GetSelectionData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkSelectionNode*)*/ callingObject);

// virtual void DeepCopy(vtkSelectionNode * src)
// virtual void DeepCopy(vtkSelectionNode* src)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkSelectionNode*)*/ callingObject, IntPtr /*(vtkSelectionNode*)*/ src);

// virtual void ShallowCopy(vtkSelectionNode * src)
// virtual void ShallowCopy(vtkSelectionNode* src)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkSelectionNode*)*/ callingObject, IntPtr /*(vtkSelectionNode*)*/ src);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkSelectionNode*)*/ callingObject);

// virtual void SetContentType(int type)
// virtual void SetContentType(int type)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_SetContentType_0")] public static extern 
bool SetContentType_0(IntPtr /*(vtkSelectionNode*)*/ callingObject, int /*(int)*/ type);

// virtual int GetContentType()
// virtual int GetContentType()
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_GetContentType_0")] public static extern 
bool GetContentType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkSelectionNode*)*/ callingObject);

// virtual void SetFieldType(int type)
// virtual void SetFieldType(int type)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_SetFieldType_0")] public static extern 
bool SetFieldType_0(IntPtr /*(vtkSelectionNode*)*/ callingObject, int /*(int)*/ type);

// virtual int GetFieldType()
// virtual int GetFieldType()
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_GetFieldType_0")] public static extern 
bool GetFieldType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkSelectionNode*)*/ callingObject);

// static int ConvertSelectionFieldToAttributeType(int val)
// static int ConvertSelectionFieldToAttributeType(int val)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_ConvertSelectionFieldToAttributeType_0")] public static extern 
bool ConvertSelectionFieldToAttributeType_0(IntPtr /*(IntPtr*)*/ return_value, int /*(int)*/ val);

// static int ConvertAttributeTypeToSelectionField(int val)
// static int ConvertAttributeTypeToSelectionField(int val)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_ConvertAttributeTypeToSelectionField_0")] public static extern 
bool ConvertAttributeTypeToSelectionField_0(IntPtr /*(IntPtr*)*/ return_value, int /*(int)*/ val);

// virtual void SetQueryString(const char * _arg)
// virtual void SetQueryString (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_SetQueryString_0")] public static extern 
bool SetQueryString_0(IntPtr /*(vtkSelectionNode*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetQueryString()
// virtual char* GetQueryString ()
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_GetQueryString_0")] public static extern 
bool GetQueryString_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkSelectionNode*)*/ callingObject);

// void UnionSelectionList(vtkSelectionNode * other)
// void UnionSelectionList(vtkSelectionNode* other)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_UnionSelectionList_0")] public static extern 
bool UnionSelectionList_0(IntPtr /*(vtkSelectionNode*)*/ callingObject, IntPtr /*(vtkSelectionNode*)*/ other);

// void SubtractSelectionList(vtkSelectionNode * other)
// void SubtractSelectionList(vtkSelectionNode* other)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_SubtractSelectionList_0")] public static extern 
bool SubtractSelectionList_0(IntPtr /*(vtkSelectionNode*)*/ callingObject, IntPtr /*(vtkSelectionNode*)*/ other);

// bool EqualProperties(vtkSelectionNode * other, bool fullcompare = true)
// bool EqualProperties(vtkSelectionNode* other, bool fullcompare=true)
[DllImport("vtkplugin", EntryPoint="vtkSelectionNode_EqualProperties_0")] public static extern 
bool EqualProperties_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkSelectionNode*)*/ callingObject, IntPtr /*(vtkSelectionNode*)*/ other, bool /*(bool)*/ fullcompare);

}
};
