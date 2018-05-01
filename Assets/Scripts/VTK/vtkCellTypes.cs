

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellTypes : vtkObject {

// static vtkCellTypes* New()
// "static vtkCellTypes *New()"
public new static vtkCellTypes New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkCellTypes.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// int Allocate(int sz = 512, int ext = 1000)
// "int Allocate(int sz=512, int ext=1000)"
public new int Allocate(int /*(int)*/ sz, int /*(int)*/ ext) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCellTypes.Allocate_0(this, returnPointer, sz, ext);
	return Ptr.deref(returnPointer);
}


// void InsertCell(vtkIdType id, unsigned char type, vtkIdType loc)
// "void InsertCell(vtkIdType id, unsigned char type, vtkIdType loc)"
public new void InsertCell(long /*(vtkIdType)*/ id, char /*(char)*/ type, long /*(vtkIdType)*/ loc) {
	API_vtkCellTypes.InsertCell_0(this, id, type, loc);
}


// vtkIdType InsertNextCell(unsigned char type, vtkIdType loc)
// "vtkIdType InsertNextCell(unsigned char type, vtkIdType loc)"
public new long InsertNextCell(char /*(char)*/ type, long /*(vtkIdType)*/ loc) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellTypes.InsertNextCell_0(this, returnPointer, type, loc);
	return Ptr.deref(returnPointer);
}


// void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray * cellTypes, vtkIdTypeArray * cellLocations)
// "void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray *cellTypes, vtkIdTypeArray *cellLocations)"
public new void SetCellTypes(long /*(vtkIdType)*/ ncells, vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ cellTypes, vtkIdTypeArray /*(vtkIdTypeArray*)*/ cellLocations) {
	API_vtkCellTypes.SetCellTypes_0(this, ncells, cellTypes, cellLocations);
}


// void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray * cellTypes, vtkIntArray * cellLocations)
// "void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray *cellTypes, vtkIntArray *cellLocations)"
public new void SetCellTypes(long /*(vtkIdType)*/ ncells, vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ cellTypes, vtkIntArray /*(vtkIntArray*)*/ cellLocations) {
	API_vtkCellTypes.SetCellTypes_1(this, ncells, cellTypes, cellLocations);
}


// vtkIdType GetCellLocation(vtkIdType cellId)
// "vtkIdType GetCellLocation(vtkIdType cellId)"
public new long GetCellLocation(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellTypes.GetCellLocation_0(this, returnPointer, cellId);
	return Ptr.deref(returnPointer);
}


// void DeleteCell(vtkIdType cellId)
// "void DeleteCell(vtkIdType cellId)"
public new void DeleteCell(long /*(vtkIdType)*/ cellId) {
	API_vtkCellTypes.DeleteCell_0(this, cellId);
}


// vtkIdType GetNumberOfTypes()
// "vtkIdType GetNumberOfTypes()"
public new long GetNumberOfTypes() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellTypes.GetNumberOfTypes_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int IsType(unsigned char type)
// "int IsType(unsigned char type)"
public new int IsType(char /*(char)*/ type) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCellTypes.IsType_0(this, returnPointer, type);
	return Ptr.deref(returnPointer);
}


// vtkIdType InsertNextType(unsigned char type)
// "vtkIdType InsertNextType(unsigned char type)"
public new long InsertNextType(char /*(char)*/ type) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellTypes.InsertNextType_0(this, returnPointer, type);
	return Ptr.deref(returnPointer);
}


// char GetCellType(vtkIdType cellId)
// "unsigned char GetCellType(vtkIdType cellId)"
public new char GetCellType(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkCellTypes.GetCellType_0(this, returnPointer, cellId);
	return Ptr.deref(returnPointer);
}


// void Squeeze()
// "void Squeeze()"
public new void Squeeze() {
	API_vtkCellTypes.Squeeze_0(this);
}


// void Reset()
// "void Reset()"
public new void Reset() {
	API_vtkCellTypes.Reset_0(this);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public new ulong GetActualMemorySize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkCellTypes.GetActualMemorySize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void DeepCopy(vtkCellTypes * src)
// "void DeepCopy(vtkCellTypes *src)"
public new void DeepCopy(vtkCellTypes /*(vtkCellTypes*)*/ src) {
	API_vtkCellTypes.DeepCopy_0(this, src);
}


// static char* GetClassNameFromTypeId(int typeId)
// "static const char* GetClassNameFromTypeId(int typeId)"
public new static char GetClassNameFromTypeId(int /*(int)*/ typeId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkCellTypes.GetClassNameFromTypeId_0(returnPointer, typeId);
	return Ptr.deref(returnPointer);
}


// static int GetTypeIdFromClassName(const char * classname)
// "static int GetTypeIdFromClassName(const char* classname)"
public new static int GetTypeIdFromClassName(char /*(char*)*/ []classname) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCellTypes.GetTypeIdFromClassName_0(returnPointer, classname);
	return Ptr.deref(returnPointer);
}


// static int IsLinear(unsigned char type)
// "static int IsLinear(unsigned char type)"
public new static int IsLinear(char /*(char)*/ type) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCellTypes.IsLinear_0(returnPointer, type);
	return Ptr.deref(returnPointer);
}


}
};
