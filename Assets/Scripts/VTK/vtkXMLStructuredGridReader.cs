

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLStructuredGridReader : vtkXMLStructuredDataReader {

// static vtkXMLStructuredGridReader* New()
// "static vtkXMLStructuredGridReader *New()"
public new static vtkXMLStructuredGridReader New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLStructuredGridReader.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkStructuredGrid* GetOutput()
// "vtkStructuredGrid *GetOutput()"
public new vtkStructuredGrid GetOutput() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLStructuredGridReader.GetOutput_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkStructuredGrid* GetOutput(int idx)
// "vtkStructuredGrid *GetOutput(int idx)"
public new vtkStructuredGrid GetOutput(int /*(int)*/ idx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLStructuredGridReader.GetOutput_1(this, returnPointer, idx);
	return Ptr.deref(returnPointer);
}


}
};
