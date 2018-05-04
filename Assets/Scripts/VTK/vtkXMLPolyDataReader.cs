

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLPolyDataReader : vtkXMLUnstructuredDataReader {
		public vtkXMLPolyDataReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLPolyDataReader(IntPtr p) {return new vtkXMLPolyDataReader(p);}
		public static implicit operator  IntPtr(vtkXMLPolyDataReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLPolyDataReader.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLPolyDataReader.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkXMLPolyDataReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLPolyDataReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLPolyDataReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLPolyDataReader.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkXMLPolyDataReader)(IntPtr)returnPointer;
}


// vtkXMLPolyDataReader* NewInstance()
// "vtkXMLPolyDataReader *NewInstance()"
public vtkXMLPolyDataReader NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLPolyDataReader.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkXMLPolyDataReader)(IntPtr)returnPointer;
}


// static vtkXMLPolyDataReader* New()
// "static vtkXMLPolyDataReader *New()"
public static vtkXMLPolyDataReader New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLPolyDataReader.New_0(returnPointer.GetPtr());
	return (vtkXMLPolyDataReader)(IntPtr)returnPointer;
}


// vtkPolyData* GetOutput()
// "vtkPolyData *GetOutput()"
public vtkPolyData GetOutput() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLPolyDataReader.GetOutput_0(returnPointer.GetPtr(), this);
	return (vtkPolyData)(IntPtr)returnPointer;
}


// vtkPolyData* GetOutput(int idx)
// "vtkPolyData *GetOutput(int idx)"
public vtkPolyData GetOutput(int /*(int)*/ idx) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLPolyDataReader.GetOutput_1(returnPointer.GetPtr(), this, idx);
	return (vtkPolyData)(IntPtr)returnPointer;
}


// virtual vtkIdType GetNumberOfVerts()
// "virtual vtkIdType GetNumberOfVerts()"
public long GetNumberOfVerts() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkXMLPolyDataReader.GetNumberOfVerts_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual vtkIdType GetNumberOfLines()
// "virtual vtkIdType GetNumberOfLines()"
public long GetNumberOfLines() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkXMLPolyDataReader.GetNumberOfLines_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual vtkIdType GetNumberOfStrips()
// "virtual vtkIdType GetNumberOfStrips()"
public long GetNumberOfStrips() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkXMLPolyDataReader.GetNumberOfStrips_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual vtkIdType GetNumberOfPolys()
// "virtual vtkIdType GetNumberOfPolys()"
public long GetNumberOfPolys() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkXMLPolyDataReader.GetNumberOfPolys_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


}
};
