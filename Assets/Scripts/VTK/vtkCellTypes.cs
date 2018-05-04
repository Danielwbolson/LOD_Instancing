

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellTypes : vtkObject {
		public vtkCellTypes(IntPtr p) : base(p) {}
		public static implicit operator  vtkCellTypes(IntPtr p) {return new vtkCellTypes(p);}
		public static implicit operator  IntPtr(vtkCellTypes o) {return o.GetPtr();}

// static vtkCellTypes* New()
// "static vtkCellTypes *New()"
public static vtkCellTypes New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkCellTypes.New_0(returnPointer.GetPtr());
	return (vtkCellTypes)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkCellTypes.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkCellTypes.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkCellTypes* SafeDownCast(vtkObjectBase * o)
// "static vtkCellTypes* SafeDownCast(vtkObjectBase *o)"
public static vtkCellTypes SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkCellTypes.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkCellTypes)(IntPtr)returnPointer;
}


// vtkCellTypes* NewInstance()
// "vtkCellTypes *NewInstance()"
public vtkCellTypes NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkCellTypes.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkCellTypes)(IntPtr)returnPointer;
}


// int Allocate(int sz = 512, int ext = 1000)
// "int Allocate(int sz=512, int ext=1000)"
public int Allocate(int /*(int)*/ sz, int /*(int)*/ ext) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkCellTypes.Allocate_0(returnPointer.GetPtr(), this, sz, ext);
	return (int)returnPointer;
}


// void InsertCell(vtkIdType id, unsigned char type, vtkIdType loc)
// "void InsertCell(vtkIdType id, unsigned char type, vtkIdType loc)"
public void InsertCell(long /*(vtkIdType)*/ id, char /*(unsigned char)*/ type, long /*(vtkIdType)*/ loc) {
	VTK_API.API_vtkCellTypes.InsertCell_0(this, id, type, loc);
}


// vtkIdType InsertNextCell(unsigned char type, vtkIdType loc)
// "vtkIdType InsertNextCell(unsigned char type, vtkIdType loc)"
public long InsertNextCell(char /*(unsigned char)*/ type, long /*(vtkIdType)*/ loc) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkCellTypes.InsertNextCell_0(returnPointer.GetPtr(), this, type, loc);
	return (long)returnPointer;
}


// void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray * cellTypes, vtkIdTypeArray * cellLocations)
// "void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray *cellTypes, vtkIdTypeArray *cellLocations)"
public void SetCellTypes(long /*(vtkIdType)*/ ncells, vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ cellTypes, vtkIdTypeArray /*(vtkIdTypeArray*)*/ cellLocations) {
	VTK_API.API_vtkCellTypes.SetCellTypes_0(this, ncells, cellTypes, cellLocations);
}


// void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray * cellTypes, vtkIntArray * cellLocations)
// "void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray *cellTypes, vtkIntArray *cellLocations)"
public void SetCellTypes(long /*(vtkIdType)*/ ncells, vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ cellTypes, vtkIntArray /*(vtkIntArray*)*/ cellLocations) {
	VTK_API.API_vtkCellTypes.SetCellTypes_1(this, ncells, cellTypes, cellLocations);
}


// vtkIdType GetCellLocation(vtkIdType cellId)
// "vtkIdType GetCellLocation(vtkIdType cellId)"
public long GetCellLocation(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkCellTypes.GetCellLocation_0(returnPointer.GetPtr(), this, cellId);
	return (long)returnPointer;
}


// void DeleteCell(vtkIdType cellId)
// "void DeleteCell(vtkIdType cellId)"
public void DeleteCell(long /*(vtkIdType)*/ cellId) {
	VTK_API.API_vtkCellTypes.DeleteCell_0(this, cellId);
}


// vtkIdType GetNumberOfTypes()
// "vtkIdType GetNumberOfTypes()"
public long GetNumberOfTypes() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkCellTypes.GetNumberOfTypes_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// int IsType(unsigned char type)
// "int IsType(unsigned char type)"
public int IsType(char /*(unsigned char)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkCellTypes.IsType_0(returnPointer.GetPtr(), this, type);
	return (int)returnPointer;
}


// vtkIdType InsertNextType(unsigned char type)
// "vtkIdType InsertNextType(unsigned char type)"
public long InsertNextType(char /*(unsigned char)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkCellTypes.InsertNextType_0(returnPointer.GetPtr(), this, type);
	return (long)returnPointer;
}


// char GetCellType(vtkIdType cellId)
// "unsigned char GetCellType(vtkIdType cellId)"
public char GetCellType(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new char(), return_elements);
	VTK_API.API_vtkCellTypes.GetCellType_0(returnPointer.GetPtr(), this, cellId);
	return (char)returnPointer;
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkCellTypes.Squeeze_0(this);
}


// void Reset()
// "void Reset()"
public void Reset() {
	VTK_API.API_vtkCellTypes.Reset_0(this);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	VTK_API.API_vtkCellTypes.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void DeepCopy(vtkCellTypes * src)
// "void DeepCopy(vtkCellTypes *src)"
public void DeepCopy(vtkCellTypes /*(vtkCellTypes*)*/ src) {
	VTK_API.API_vtkCellTypes.DeepCopy_0(this, src);
}


// static char* GetClassNameFromTypeId(int typeId)
// "static const char* GetClassNameFromTypeId(int typeId)"
public static string GetClassNameFromTypeId(int /*(int)*/ typeId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkCellTypes.GetClassNameFromTypeId_0(returnPointer.GetPtr(), typeId);
	return (string)returnPointer;
}


// static int GetTypeIdFromClassName(const char * classname)
// "static int GetTypeIdFromClassName(const char* classname)"
public static int GetTypeIdFromClassName(string /*(char*)*/ classname) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkCellTypes.GetTypeIdFromClassName_0(returnPointer.GetPtr(), classname);
	return (int)returnPointer;
}


// static int IsLinear(unsigned char type)
// "static int IsLinear(unsigned char type)"
public static int IsLinear(char /*(unsigned char)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkCellTypes.IsLinear_0(returnPointer.GetPtr(), type);
	return (int)returnPointer;
}


}
};
