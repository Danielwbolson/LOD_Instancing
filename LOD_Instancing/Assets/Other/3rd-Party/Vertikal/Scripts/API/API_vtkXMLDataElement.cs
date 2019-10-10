
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkXMLDataElement {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ type);

// static vtkXMLDataElement* SafeDownCast(vtkObjectBase * o)
// static vtkXMLDataElement* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkXMLDataElement* NewInstance()
// vtkXMLDataElement *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// static vtkXMLDataElement* New()
// static vtkXMLDataElement* New()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual char* GetName()
// virtual char* GetName ()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetName_0")] public static extern 
bool GetName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// virtual void SetName(const char * _arg)
// virtual void SetName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetName_0")] public static extern 
bool SetName_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetId()
// virtual char* GetId ()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetId_0")] public static extern 
bool GetId_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// virtual void SetId(const char * _arg)
// virtual void SetId (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetId_0")] public static extern 
bool SetId_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ _arg);

// char* GetAttribute(const char * name)
// const char* GetAttribute(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetAttribute_0")] public static extern 
bool GetAttribute_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name);

// void SetAttribute(const char * name, const char * value)
// void SetAttribute(const char* name, const char* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetAttribute_0")] public static extern 
bool SetAttribute_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, string /*(char*)*/ value);

// void SetCharacterData(const char * c, int length)
// void SetCharacterData(const char* c, int length)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetCharacterData_0")] public static extern 
bool SetCharacterData_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ c, int /*(int)*/ length);

// void AddCharacterData(const char * c, size_t length)
// void AddCharacterData(const char* c, size_t length)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_AddCharacterData_0")] public static extern 
bool AddCharacterData_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ c, ulong /*(size_t)*/ length);

// virtual char* GetCharacterData()
// virtual char* GetCharacterData ()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetCharacterData_0")] public static extern 
bool GetCharacterData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// int GetScalarAttribute(const char * name, int & value)
// int GetScalarAttribute(const char* name, int& value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetScalarAttribute_0")] public static extern 
bool GetScalarAttribute_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, IntPtr /*(int&)*/ value);

// int GetScalarAttribute(const char * name, float & value)
// int GetScalarAttribute(const char* name, float& value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetScalarAttribute_1")] public static extern 
bool GetScalarAttribute_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, IntPtr /*(float&)*/ value);

// int GetScalarAttribute(const char * name, double & value)
// int GetScalarAttribute(const char* name, double& value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetScalarAttribute_2")] public static extern 
bool GetScalarAttribute_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, IntPtr /*(double&)*/ value);

// int GetScalarAttribute(const char * name, long & value)
// int GetScalarAttribute(const char* name, long& value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetScalarAttribute_3")] public static extern 
bool GetScalarAttribute_3(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, IntPtr /*(long&)*/ value);

// int GetScalarAttribute(const char * name, unsigned long & value)
// int GetScalarAttribute(const char* name, unsigned long& value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetScalarAttribute_4")] public static extern 
bool GetScalarAttribute_4(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, IntPtr /*(unsigned long&)*/ value);

// void SetIntAttribute(const char * name, int value)
// void SetIntAttribute(const char* name, int value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetIntAttribute_0")] public static extern 
bool SetIntAttribute_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ value);

// void SetFloatAttribute(const char * name, float value)
// void SetFloatAttribute(const char* name, float value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetFloatAttribute_0")] public static extern 
bool SetFloatAttribute_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, float /*(float)*/ value);

// void SetDoubleAttribute(const char * name, double value)
// void SetDoubleAttribute(const char* name, double value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetDoubleAttribute_0")] public static extern 
bool SetDoubleAttribute_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, double /*(double)*/ value);

// void SetUnsignedLongAttribute(const char * name, unsigned long value)
// void SetUnsignedLongAttribute(const char* name, unsigned long value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetUnsignedLongAttribute_0")] public static extern 
bool SetUnsignedLongAttribute_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, ulong /*(unsigned long)*/ value);

// int GetVectorAttribute(const char * name, int length, int * value)
// int GetVectorAttribute(const char* name, int length, int* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetVectorAttribute_0")] public static extern 
bool GetVectorAttribute_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(int*)*/ value);

// int GetVectorAttribute(const char * name, int length, float * value)
// int GetVectorAttribute(const char* name, int length, float* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetVectorAttribute_1")] public static extern 
bool GetVectorAttribute_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(float*)*/ value);

// int GetVectorAttribute(const char * name, int length, double * value)
// int GetVectorAttribute(const char* name, int length, double* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetVectorAttribute_2")] public static extern 
bool GetVectorAttribute_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(double*)*/ value);

// int GetVectorAttribute(const char * name, int length, long * value)
// int GetVectorAttribute(const char* name, int length, long* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetVectorAttribute_3")] public static extern 
bool GetVectorAttribute_3(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(long*)*/ value);

// int GetVectorAttribute(const char * name, int length, unsigned long * value)
// int GetVectorAttribute(const char* name, int length, unsigned long* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetVectorAttribute_4")] public static extern 
bool GetVectorAttribute_4(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(unsigned long*)*/ value);

// void SetVectorAttribute(const char * name, int length, const int * value)
// void SetVectorAttribute(const char* name, int length, const int* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetVectorAttribute_0")] public static extern 
bool SetVectorAttribute_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(int*)*/ value);

// void SetVectorAttribute(const char * name, int length, const float * value)
// void SetVectorAttribute(const char* name, int length, const float* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetVectorAttribute_1")] public static extern 
bool SetVectorAttribute_1(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(float*)*/ value);

// void SetVectorAttribute(const char * name, int length, const double * value)
// void SetVectorAttribute(const char* name, int length, const double* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetVectorAttribute_2")] public static extern 
bool SetVectorAttribute_2(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(double*)*/ value);

// void SetVectorAttribute(const char * name, int length, const unsigned long * value)
// void SetVectorAttribute(const char* name, int length, const unsigned long* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetVectorAttribute_3")] public static extern 
bool SetVectorAttribute_3(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(unsigned long*)*/ value);

// int GetScalarAttribute(const char * name, long long & value)
// int GetScalarAttribute(const char* name, long long& value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetScalarAttribute_5")] public static extern 
bool GetScalarAttribute_5(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, IntPtr /*(long long&)*/ value);

// int GetVectorAttribute(const char * name, int length, long long * value)
// int GetVectorAttribute(const char* name, int length, long long* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetVectorAttribute_5")] public static extern 
bool GetVectorAttribute_5(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(long long*)*/ value);

// void SetVectorAttribute(const char * name, int length, long long const* value)
// void SetVectorAttribute(const char* name, int length, long long const* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetVectorAttribute_4")] public static extern 
bool SetVectorAttribute_4(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(long longconst*)*/ value);

// int GetScalarAttribute(const char * name, unsigned long long & value)
// int GetScalarAttribute(const char* name, unsigned long long& value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetScalarAttribute_6")] public static extern 
bool GetScalarAttribute_6(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, IntPtr /*(unsigned long long&)*/ value);

// int GetVectorAttribute(const char * name, int length, unsigned long long * value)
// int GetVectorAttribute(const char* name, int length, unsigned long long* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetVectorAttribute_6")] public static extern 
bool GetVectorAttribute_6(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(unsigned long long*)*/ value);

// void SetVectorAttribute(const char * name, int length, unsigned long long const* value)
// void SetVectorAttribute(const char* name, int length, unsigned long long const* value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetVectorAttribute_5")] public static extern 
bool SetVectorAttribute_5(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(unsigned long longconst*)*/ value);

// int GetWordTypeAttribute(const char * name, int & value)
// int GetWordTypeAttribute(const char* name, int& value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetWordTypeAttribute_0")] public static extern 
bool GetWordTypeAttribute_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, IntPtr /*(int&)*/ value);

// virtual int GetNumberOfAttributes()
// virtual int GetNumberOfAttributes ()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetNumberOfAttributes_0")] public static extern 
bool GetNumberOfAttributes_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// char* GetAttributeName(int idx)
// const char* GetAttributeName(int idx)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetAttributeName_0")] public static extern 
bool GetAttributeName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, int /*(int)*/ idx);

// char* GetAttributeValue(int idx)
// const char* GetAttributeValue(int idx)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetAttributeValue_0")] public static extern 
bool GetAttributeValue_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, int /*(int)*/ idx);

// virtual void RemoveAttribute(const char * name)
// virtual void RemoveAttribute(const char *name)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_RemoveAttribute_0")] public static extern 
bool RemoveAttribute_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name);

// virtual void RemoveAllAttributes()
// virtual void RemoveAllAttributes()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_RemoveAllAttributes_0")] public static extern 
bool RemoveAllAttributes_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// vtkXMLDataElement* GetParent()
// vtkXMLDataElement* GetParent()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetParent_0")] public static extern 
bool GetParent_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// void SetParent(vtkXMLDataElement * parent)
// void SetParent(vtkXMLDataElement* parent)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetParent_0")] public static extern 
bool SetParent_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, IntPtr /*(vtkXMLDataElement*)*/ parent);

// virtual vtkXMLDataElement* GetRoot()
// virtual vtkXMLDataElement* GetRoot()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetRoot_0")] public static extern 
bool GetRoot_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// int GetNumberOfNestedElements()
// int GetNumberOfNestedElements()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetNumberOfNestedElements_0")] public static extern 
bool GetNumberOfNestedElements_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// vtkXMLDataElement* GetNestedElement(int index)
// vtkXMLDataElement* GetNestedElement(int index)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetNestedElement_0")] public static extern 
bool GetNestedElement_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, int /*(int)*/ index);

// void AddNestedElement(vtkXMLDataElement * element)
// void AddNestedElement(vtkXMLDataElement* element)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_AddNestedElement_0")] public static extern 
bool AddNestedElement_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, IntPtr /*(vtkXMLDataElement*)*/ element);

// virtual void RemoveNestedElement(vtkXMLDataElement * ARG_0)
// virtual void RemoveNestedElement(vtkXMLDataElement *)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_RemoveNestedElement_0")] public static extern 
bool RemoveNestedElement_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, IntPtr /*(vtkXMLDataElement*)*/ ARG_0);

// virtual void RemoveAllNestedElements()
// virtual void RemoveAllNestedElements()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_RemoveAllNestedElements_0")] public static extern 
bool RemoveAllNestedElements_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// vtkXMLDataElement* FindNestedElement(const char * id)
// vtkXMLDataElement* FindNestedElement(const char* id)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_FindNestedElement_0")] public static extern 
bool FindNestedElement_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ id);

// vtkXMLDataElement* FindNestedElementWithName(const char * name)
// vtkXMLDataElement* FindNestedElementWithName(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_FindNestedElementWithName_0")] public static extern 
bool FindNestedElementWithName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name);

// vtkXMLDataElement* FindNestedElementWithNameAndId(const char * name, const char * id)
// vtkXMLDataElement* FindNestedElementWithNameAndId( const char* name, const char* id)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_FindNestedElementWithNameAndId_0")] public static extern 
bool FindNestedElementWithNameAndId_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, string /*(char*)*/ id);

// vtkXMLDataElement* FindNestedElementWithNameAndAttribute(const char * name, const char * att_name, const char * att_value)
// vtkXMLDataElement* FindNestedElementWithNameAndAttribute( const char* name, const char* att_name, const char* att_value)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_FindNestedElementWithNameAndAttribute_0")] public static extern 
bool FindNestedElementWithNameAndAttribute_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name, string /*(char*)*/ att_name, string /*(char*)*/ att_value);

// vtkXMLDataElement* LookupElementWithName(const char * name)
// vtkXMLDataElement* LookupElementWithName(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_LookupElementWithName_0")] public static extern 
bool LookupElementWithName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ name);

// vtkXMLDataElement* LookupElement(const char * id)
// vtkXMLDataElement* LookupElement(const char* id)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_LookupElement_0")] public static extern 
bool LookupElement_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ id);

// virtual vtkTypeInt64 GetXMLByteIndex()
// virtual vtkTypeInt64 GetXMLByteIndex ()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetXMLByteIndex_0")] public static extern 
bool GetXMLByteIndex_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// virtual void SetXMLByteIndex(vtkTypeInt64 _arg)
// virtual void SetXMLByteIndex (vtkTypeInt64 _arg)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetXMLByteIndex_0")] public static extern 
bool SetXMLByteIndex_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, long /*(vtkTypeInt64)*/ _arg);

// virtual int IsEqualTo(vtkXMLDataElement * elem)
// virtual int IsEqualTo(vtkXMLDataElement *elem)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_IsEqualTo_0")] public static extern 
bool IsEqualTo_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject, IntPtr /*(vtkXMLDataElement*)*/ elem);

// virtual void DeepCopy(vtkXMLDataElement * elem)
// virtual void DeepCopy(vtkXMLDataElement *elem)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, IntPtr /*(vtkXMLDataElement*)*/ elem);

// virtual void SetAttributeEncoding(int _arg)
// virtual void SetAttributeEncoding (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetAttributeEncoding_0")] public static extern 
bool SetAttributeEncoding_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetAttributeEncodingMinValue()
// virtual int GetAttributeEncodingMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetAttributeEncodingMinValue_0")] public static extern 
bool GetAttributeEncodingMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// virtual int GetAttributeEncodingMaxValue()
// virtual int GetAttributeEncodingMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetAttributeEncodingMaxValue_0")] public static extern 
bool GetAttributeEncodingMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// virtual int GetAttributeEncoding()
// virtual int GetAttributeEncoding ()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetAttributeEncoding_0")] public static extern 
bool GetAttributeEncoding_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// void PrintXML(const char * fname)
// void PrintXML(const char* fname)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_PrintXML_0")] public static extern 
bool PrintXML_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, string /*(char*)*/ fname);

// virtual int GetCharacterDataWidth()
// virtual int GetCharacterDataWidth ()
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_GetCharacterDataWidth_0")] public static extern 
bool GetCharacterDataWidth_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLDataElement*)*/ callingObject);

// virtual void SetCharacterDataWidth(int _arg)
// virtual void SetCharacterDataWidth (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkXMLDataElement_SetCharacterDataWidth_0")] public static extern 
bool SetCharacterDataWidth_0(IntPtr /*(vtkXMLDataElement*)*/ callingObject, int /*(int)*/ _arg);

}
};
