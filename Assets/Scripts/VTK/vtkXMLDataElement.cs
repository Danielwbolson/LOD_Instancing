

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLDataElement : vtkObject {

// static vtkXMLDataElement* New()
// "static vtkXMLDataElement* New()"
public new static vtkXMLDataElement New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLDataElement.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void SetName(const char * _arg)
// "virtual void SetName (const char* _arg)"
public new void SetName(char /*(char*)*/ []_arg) {
	API_vtkXMLDataElement.SetName_0(this, _arg);
}


// char* GetAttribute(const char * name)
// "const char* GetAttribute(const char* name)"
public new char GetAttribute(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkXMLDataElement.GetAttribute_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// void SetAttribute(const char * name, const char * value)
// "void SetAttribute(const char* name, const char* value)"
public new void SetAttribute(char /*(char*)*/ []name, char /*(char*)*/ []value) {
	API_vtkXMLDataElement.SetAttribute_0(this, name, value);
}


// void SetCharacterData(const char * c, int length)
// "void SetCharacterData(const char* c, int length)"
public new void SetCharacterData(char /*(char*)*/ []c, int /*(int)*/ length) {
	API_vtkXMLDataElement.SetCharacterData_0(this, c, length);
}


// void AddCharacterData(const char * c, size_t length)
// "void AddCharacterData(const char* c, size_t length)"
public new void AddCharacterData(char /*(char*)*/ []c, ulong /*(size_t)*/ length) {
	API_vtkXMLDataElement.AddCharacterData_0(this, c, length);
}


// int GetScalarAttribute(const char * name, int & value)
// "int GetScalarAttribute(const char* name, int& value)"
public new int GetScalarAttribute(char /*(char*)*/ []name, int /*(int&)*/ []value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataElement.GetScalarAttribute_0(this, returnPointer, name, *value);
	return Ptr.deref(returnPointer);
}


// int GetScalarAttribute(const char * name, float & value)
// "int GetScalarAttribute(const char* name, float& value)"
public new int GetScalarAttribute(char /*(char*)*/ []name, float /*(float&)*/ []value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataElement.GetScalarAttribute_1(this, returnPointer, name, *value);
	return Ptr.deref(returnPointer);
}


// int GetScalarAttribute(const char * name, double & value)
// "int GetScalarAttribute(const char* name, double& value)"
public new int GetScalarAttribute(char /*(char*)*/ []name, double /*(double&)*/ []value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataElement.GetScalarAttribute_2(this, returnPointer, name, *value);
	return Ptr.deref(returnPointer);
}


// int GetScalarAttribute(const char * name, long & value)
// "int GetScalarAttribute(const char* name, long& value)"
public new int GetScalarAttribute(char /*(char*)*/ []name, long /*(long&)*/ []value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataElement.GetScalarAttribute_3(this, returnPointer, name, *value);
	return Ptr.deref(returnPointer);
}


// int GetScalarAttribute(const char * name, unsigned long & value)
// "int GetScalarAttribute(const char* name, unsigned long& value)"
public new int GetScalarAttribute(char /*(char*)*/ []name, ulong /*(long&)*/ []value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataElement.GetScalarAttribute_4(this, returnPointer, name, *value);
	return Ptr.deref(returnPointer);
}


// void SetIntAttribute(const char * name, int value)
// "void SetIntAttribute(const char* name, int value)"
public new void SetIntAttribute(char /*(char*)*/ []name, int /*(int)*/ value) {
	API_vtkXMLDataElement.SetIntAttribute_0(this, name, value);
}


// void SetFloatAttribute(const char * name, float value)
// "void SetFloatAttribute(const char* name, float value)"
public new void SetFloatAttribute(char /*(char*)*/ []name, float /*(float)*/ value) {
	API_vtkXMLDataElement.SetFloatAttribute_0(this, name, value);
}


// void SetDoubleAttribute(const char * name, double value)
// "void SetDoubleAttribute(const char* name, double value)"
public new void SetDoubleAttribute(char /*(char*)*/ []name, double /*(double)*/ value) {
	API_vtkXMLDataElement.SetDoubleAttribute_0(this, name, value);
}


// void SetUnsignedLongAttribute(const char * name, unsigned long value)
// "void SetUnsignedLongAttribute(const char* name, unsigned long value)"
public new void SetUnsignedLongAttribute(char /*(char*)*/ []name, ulong /*(long)*/ value) {
	API_vtkXMLDataElement.SetUnsignedLongAttribute_0(this, name, value);
}


// int GetVectorAttribute(const char * name, int length, int * value)
// "int GetVectorAttribute(const char* name, int length, int* value)"
public new int GetVectorAttribute(char /*(char*)*/ []name, int /*(int)*/ length, int /*(int*)*/ []value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataElement.GetVectorAttribute_0(this, returnPointer, name, length, value);
	return Ptr.deref(returnPointer);
}


// int GetVectorAttribute(const char * name, int length, float * value)
// "int GetVectorAttribute(const char* name, int length, float* value)"
public new int GetVectorAttribute(char /*(char*)*/ []name, int /*(int)*/ length, float /*(float*)*/ []value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataElement.GetVectorAttribute_1(this, returnPointer, name, length, value);
	return Ptr.deref(returnPointer);
}


// int GetVectorAttribute(const char * name, int length, double * value)
// "int GetVectorAttribute(const char* name, int length, double* value)"
public new int GetVectorAttribute(char /*(char*)*/ []name, int /*(int)*/ length, double /*(double*)*/ []value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataElement.GetVectorAttribute_2(this, returnPointer, name, length, value);
	return Ptr.deref(returnPointer);
}


// int GetVectorAttribute(const char * name, int length, long * value)
// "int GetVectorAttribute(const char* name, int length, long* value)"
public new int GetVectorAttribute(char /*(char*)*/ []name, int /*(int)*/ length, long /*(long*)*/ []value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataElement.GetVectorAttribute_3(this, returnPointer, name, length, value);
	return Ptr.deref(returnPointer);
}


// int GetVectorAttribute(const char * name, int length, unsigned long * value)
// "int GetVectorAttribute(const char* name, int length, unsigned long* value)"
public new int GetVectorAttribute(char /*(char*)*/ []name, int /*(int)*/ length, ulong /*(long*)*/ []value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataElement.GetVectorAttribute_4(this, returnPointer, name, length, value);
	return Ptr.deref(returnPointer);
}


// void SetVectorAttribute(const char * name, int length, const int * value)
// "void SetVectorAttribute(const char* name, int length, const int* value)"
public new void SetVectorAttribute(char /*(char*)*/ []name, int /*(int)*/ length, int /*(int*)*/ []value) {
	API_vtkXMLDataElement.SetVectorAttribute_0(this, name, length, value);
}


// void SetVectorAttribute(const char * name, int length, const float * value)
// "void SetVectorAttribute(const char* name, int length, const float* value)"
public new void SetVectorAttribute(char /*(char*)*/ []name, int /*(int)*/ length, float /*(float*)*/ []value) {
	API_vtkXMLDataElement.SetVectorAttribute_1(this, name, length, value);
}


// void SetVectorAttribute(const char * name, int length, const double * value)
// "void SetVectorAttribute(const char* name, int length, const double* value)"
public new void SetVectorAttribute(char /*(char*)*/ []name, int /*(int)*/ length, double /*(double*)*/ []value) {
	API_vtkXMLDataElement.SetVectorAttribute_2(this, name, length, value);
}


// void SetVectorAttribute(const char * name, int length, const unsigned long * value)
// "void SetVectorAttribute(const char* name, int length, const unsigned long* value)"
public new void SetVectorAttribute(char /*(char*)*/ []name, int /*(int)*/ length, ulong /*(long*)*/ []value) {
	API_vtkXMLDataElement.SetVectorAttribute_3(this, name, length, value);
}


// void SetVectorAttribute(const char * name, int length, long long const* value)
// "void SetVectorAttribute(const char* name, int length, long long const* value)"
public new void SetVectorAttribute(char /*(char*)*/ []name, int /*(int)*/ length, long /*(long longconst*)*/ []value) {
	API_vtkXMLDataElement.SetVectorAttribute_4(this, name, length, value);
}


// int GetWordTypeAttribute(const char * name, int & value)
// "int GetWordTypeAttribute(const char* name, int& value)"
public new int GetWordTypeAttribute(char /*(char*)*/ []name, int /*(int&)*/ []value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataElement.GetWordTypeAttribute_0(this, returnPointer, name, *value);
	return Ptr.deref(returnPointer);
}


// char* GetAttributeName(int idx)
// "const char* GetAttributeName(int idx)"
public new char GetAttributeName(int /*(int)*/ idx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkXMLDataElement.GetAttributeName_0(this, returnPointer, idx);
	return Ptr.deref(returnPointer);
}


// char* GetAttributeValue(int idx)
// "const char* GetAttributeValue(int idx)"
public new char GetAttributeValue(int /*(int)*/ idx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkXMLDataElement.GetAttributeValue_0(this, returnPointer, idx);
	return Ptr.deref(returnPointer);
}


// virtual void RemoveAttribute(const char * name)
// "virtual void RemoveAttribute(const char *name)"
public new void RemoveAttribute(char /*(char*)*/ []name) {
	API_vtkXMLDataElement.RemoveAttribute_0(this, name);
}


// virtual void RemoveAllAttributes()
// "virtual void RemoveAllAttributes()"
public new void RemoveAllAttributes() {
	API_vtkXMLDataElement.RemoveAllAttributes_0(this);
}


// vtkXMLDataElement* GetParent()
// "vtkXMLDataElement* GetParent()"
public new vtkXMLDataElement GetParent() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLDataElement.GetParent_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetParent(vtkXMLDataElement * parent)
// "void SetParent(vtkXMLDataElement* parent)"
public new void SetParent(vtkXMLDataElement /*(vtkXMLDataElement*)*/ parent) {
	API_vtkXMLDataElement.SetParent_0(this, parent);
}


// virtual vtkXMLDataElement* GetRoot()
// "virtual vtkXMLDataElement* GetRoot()"
public new vtkXMLDataElement GetRoot() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLDataElement.GetRoot_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetNumberOfNestedElements()
// "int GetNumberOfNestedElements()"
public new int GetNumberOfNestedElements() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataElement.GetNumberOfNestedElements_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkXMLDataElement* GetNestedElement(int index)
// "vtkXMLDataElement* GetNestedElement(int index)"
public new vtkXMLDataElement GetNestedElement(int /*(int)*/ index) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLDataElement.GetNestedElement_0(this, returnPointer, index);
	return Ptr.deref(returnPointer);
}


// void AddNestedElement(vtkXMLDataElement * element)
// "void AddNestedElement(vtkXMLDataElement* element)"
public new void AddNestedElement(vtkXMLDataElement /*(vtkXMLDataElement*)*/ element) {
	API_vtkXMLDataElement.AddNestedElement_0(this, element);
}


// virtual void RemoveNestedElement(vtkXMLDataElement * ARG_0)
// "virtual void RemoveNestedElement(vtkXMLDataElement *)"
public new void RemoveNestedElement(vtkXMLDataElement /*(vtkXMLDataElement*)*/ ARG_0) {
	API_vtkXMLDataElement.RemoveNestedElement_0(this, ARG_0);
}


// virtual void RemoveAllNestedElements()
// "virtual void RemoveAllNestedElements()"
public new void RemoveAllNestedElements() {
	API_vtkXMLDataElement.RemoveAllNestedElements_0(this);
}


// vtkXMLDataElement* FindNestedElement(const char * id)
// "vtkXMLDataElement* FindNestedElement(const char* id)"
public new vtkXMLDataElement FindNestedElement(char /*(char*)*/ []id) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLDataElement.FindNestedElement_0(this, returnPointer, id);
	return Ptr.deref(returnPointer);
}


// vtkXMLDataElement* FindNestedElementWithName(const char * name)
// "vtkXMLDataElement* FindNestedElementWithName(const char* name)"
public new vtkXMLDataElement FindNestedElementWithName(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLDataElement.FindNestedElementWithName_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkXMLDataElement* FindNestedElementWithNameAndId(const char * name, const char * id)
// "vtkXMLDataElement* FindNestedElementWithNameAndId( const char* name, const char* id)"
public new vtkXMLDataElement FindNestedElementWithNameAndId(char /*(char*)*/ []name, char /*(char*)*/ []id) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLDataElement.FindNestedElementWithNameAndId_0(this, returnPointer, name, id);
	return Ptr.deref(returnPointer);
}


// vtkXMLDataElement* FindNestedElementWithNameAndAttribute(const char * name, const char * att_name, const char * att_value)
// "vtkXMLDataElement* FindNestedElementWithNameAndAttribute( const char* name, const char* att_name, const char* att_value)"
public new vtkXMLDataElement FindNestedElementWithNameAndAttribute(char /*(char*)*/ []name, char /*(char*)*/ []att_name, char /*(char*)*/ []att_value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLDataElement.FindNestedElementWithNameAndAttribute_0(this, returnPointer, name, att_name, att_value);
	return Ptr.deref(returnPointer);
}


// vtkXMLDataElement* LookupElementWithName(const char * name)
// "vtkXMLDataElement* LookupElementWithName(const char* name)"
public new vtkXMLDataElement LookupElementWithName(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLDataElement.LookupElementWithName_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkXMLDataElement* LookupElement(const char * id)
// "vtkXMLDataElement* LookupElement(const char* id)"
public new vtkXMLDataElement LookupElement(char /*(char*)*/ []id) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLDataElement.LookupElement_0(this, returnPointer, id);
	return Ptr.deref(returnPointer);
}


// virtual int IsEqualTo(vtkXMLDataElement * elem)
// "virtual int IsEqualTo(vtkXMLDataElement *elem)"
public new int IsEqualTo(vtkXMLDataElement /*(vtkXMLDataElement*)*/ elem) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLDataElement.IsEqualTo_0(this, returnPointer, elem);
	return Ptr.deref(returnPointer);
}


// virtual void DeepCopy(vtkXMLDataElement * elem)
// "virtual void DeepCopy(vtkXMLDataElement *elem)"
public new void DeepCopy(vtkXMLDataElement /*(vtkXMLDataElement*)*/ elem) {
	API_vtkXMLDataElement.DeepCopy_0(this, elem);
}


// void PrintXML(const char * fname)
// "void PrintXML(const char* fname)"
public new void PrintXML(char /*(char*)*/ []fname) {
	API_vtkXMLDataElement.PrintXML_0(this, fname);
}


}
};
