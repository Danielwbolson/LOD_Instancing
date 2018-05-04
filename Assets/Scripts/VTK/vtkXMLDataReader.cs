

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLDataReader : vtkXMLReader {
		public vtkXMLDataReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLDataReader(IntPtr p) {return new vtkXMLDataReader(p);}
		public static implicit operator  IntPtr(vtkXMLDataReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLDataReader.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLDataReader.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkXMLDataReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLDataReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLDataReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLDataReader.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkXMLDataReader)(IntPtr)returnPointer;
}


// vtkXMLDataReader* NewInstance()
// "vtkXMLDataReader *NewInstance()"
public vtkXMLDataReader NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLDataReader.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkXMLDataReader)(IntPtr)returnPointer;
}


// virtual vtkIdType GetNumberOfPoints()
// "virtual vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkXMLDataReader.GetNumberOfPoints_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual vtkIdType GetNumberOfCells()
// "virtual vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkXMLDataReader.GetNumberOfCells_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


}
};
