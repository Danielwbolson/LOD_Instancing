

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLUnstructuredGridReader : vtkXMLUnstructuredDataReader {
		public vtkXMLUnstructuredGridReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLUnstructuredGridReader(IntPtr p) {return new vtkXMLUnstructuredGridReader(p);}
		public static implicit operator  IntPtr(vtkXMLUnstructuredGridReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLUnstructuredGridReader.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLUnstructuredGridReader.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkXMLUnstructuredGridReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLUnstructuredGridReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLUnstructuredGridReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLUnstructuredGridReader.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkXMLUnstructuredGridReader)(IntPtr)returnPointer;
}


// vtkXMLUnstructuredGridReader* NewInstance()
// "vtkXMLUnstructuredGridReader *NewInstance()"
public vtkXMLUnstructuredGridReader NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLUnstructuredGridReader.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkXMLUnstructuredGridReader)(IntPtr)returnPointer;
}


// static vtkXMLUnstructuredGridReader* New()
// "static vtkXMLUnstructuredGridReader *New()"
public static vtkXMLUnstructuredGridReader New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLUnstructuredGridReader.New_0(returnPointer.GetPtr());
	return (vtkXMLUnstructuredGridReader)(IntPtr)returnPointer;
}


// vtkUnstructuredGrid* GetOutput()
// "vtkUnstructuredGrid *GetOutput()"
public vtkUnstructuredGrid GetOutput() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLUnstructuredGridReader.GetOutput_0(returnPointer.GetPtr(), this);
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// vtkUnstructuredGrid* GetOutput(int idx)
// "vtkUnstructuredGrid *GetOutput(int idx)"
public vtkUnstructuredGrid GetOutput(int /*(int)*/ idx) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLUnstructuredGridReader.GetOutput_1(returnPointer.GetPtr(), this, idx);
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


}
};
