

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLUnstructuredGridReader : vtkXMLUnstructuredDataReader {
		public vtkXMLUnstructuredGridReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLUnstructuredGridReader(IntPtr p) {return new vtkXMLUnstructuredGridReader(p);}
		public static implicit operator  IntPtr(vtkXMLUnstructuredGridReader o) {return o.GetPtr();}

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
