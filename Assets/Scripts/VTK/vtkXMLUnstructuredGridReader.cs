

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLUnstructuredGridReader : vtkXMLUnstructuredDataReader {

// static vtkXMLUnstructuredGridReader* New()
// "static vtkXMLUnstructuredGridReader *New()"
public new static vtkXMLUnstructuredGridReader New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLUnstructuredGridReader.New_0(returnPointer);
           return returnPointer;
}


// vtkUnstructuredGrid* GetOutput()
// "vtkUnstructuredGrid *GetOutput()"
public new vtkUnstructuredGrid GetOutput() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLUnstructuredGridReader.GetOutput_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkUnstructuredGrid* GetOutput(int idx)
// "vtkUnstructuredGrid *GetOutput(int idx)"
public new vtkUnstructuredGrid GetOutput(int /*(int)*/ idx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLUnstructuredGridReader.GetOutput_1(this, returnPointer, idx);
	return Ptr.deref(returnPointer);
}


}
};
