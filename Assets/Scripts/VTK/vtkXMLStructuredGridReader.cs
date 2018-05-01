

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLStructuredGridReader : vtkXMLStructuredDataReader {
		public vtkXMLStructuredGridReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLStructuredGridReader(IntPtr p) {return new vtkXMLStructuredGridReader(p);}
		public static implicit operator  IntPtr(vtkXMLStructuredGridReader o) {return o.GetPtr();}

// static vtkXMLStructuredGridReader* New()
// "static vtkXMLStructuredGridReader *New()"
public static vtkXMLStructuredGridReader New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkXMLStructuredGridReader.New_0(returnPointer.GetPtr());
	return (vtkXMLStructuredGridReader)(IntPtr)returnPointer;
}


// vtkStructuredGrid* GetOutput()
// "vtkStructuredGrid *GetOutput()"
public vtkStructuredGrid GetOutput() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkXMLStructuredGridReader.GetOutput_0(returnPointer.GetPtr(), this);
	return (vtkStructuredGrid)(IntPtr)returnPointer;
}


// vtkStructuredGrid* GetOutput(int idx)
// "vtkStructuredGrid *GetOutput(int idx)"
public vtkStructuredGrid GetOutput(int /*(int)*/ idx) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkXMLStructuredGridReader.GetOutput_1(returnPointer.GetPtr(), this, idx);
	return (vtkStructuredGrid)(IntPtr)returnPointer;
}


}
};
