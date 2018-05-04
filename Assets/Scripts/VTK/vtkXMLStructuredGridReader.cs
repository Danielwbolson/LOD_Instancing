

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLStructuredGridReader : vtkXMLStructuredDataReader {
		public vtkXMLStructuredGridReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLStructuredGridReader(IntPtr p) {return new vtkXMLStructuredGridReader(p);}
		public static implicit operator  IntPtr(vtkXMLStructuredGridReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLStructuredGridReader.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLStructuredGridReader.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkXMLStructuredGridReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLStructuredGridReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLStructuredGridReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLStructuredGridReader.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkXMLStructuredGridReader)(IntPtr)returnPointer;
}


// vtkXMLStructuredGridReader* NewInstance()
// "vtkXMLStructuredGridReader *NewInstance()"
public vtkXMLStructuredGridReader NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLStructuredGridReader.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkXMLStructuredGridReader)(IntPtr)returnPointer;
}


// static vtkXMLStructuredGridReader* New()
// "static vtkXMLStructuredGridReader *New()"
public static vtkXMLStructuredGridReader New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLStructuredGridReader.New_0(returnPointer.GetPtr());
	return (vtkXMLStructuredGridReader)(IntPtr)returnPointer;
}


// vtkStructuredGrid* GetOutput()
// "vtkStructuredGrid *GetOutput()"
public vtkStructuredGrid GetOutput() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLStructuredGridReader.GetOutput_0(returnPointer.GetPtr(), this);
	return (vtkStructuredGrid)(IntPtr)returnPointer;
}


// vtkStructuredGrid* GetOutput(int idx)
// "vtkStructuredGrid *GetOutput(int idx)"
public vtkStructuredGrid GetOutput(int /*(int)*/ idx) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLStructuredGridReader.GetOutput_1(returnPointer.GetPtr(), this, idx);
	return (vtkStructuredGrid)(IntPtr)returnPointer;
}


}
};
