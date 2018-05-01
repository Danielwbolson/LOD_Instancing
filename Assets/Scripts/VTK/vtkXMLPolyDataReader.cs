

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLPolyDataReader : vtkXMLUnstructuredDataReader {

// static vtkXMLPolyDataReader* New()
// "static vtkXMLPolyDataReader *New()"
public new static vtkXMLPolyDataReader New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLPolyDataReader.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkPolyData* GetOutput()
// "vtkPolyData *GetOutput()"
public new vtkPolyData GetOutput() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLPolyDataReader.GetOutput_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkPolyData* GetOutput(int idx)
// "vtkPolyData *GetOutput(int idx)"
public new vtkPolyData GetOutput(int /*(int)*/ idx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLPolyDataReader.GetOutput_1(this, returnPointer, idx);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType GetNumberOfVerts()
// "virtual vtkIdType GetNumberOfVerts()"
public new long GetNumberOfVerts() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkXMLPolyDataReader.GetNumberOfVerts_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType GetNumberOfLines()
// "virtual vtkIdType GetNumberOfLines()"
public new long GetNumberOfLines() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkXMLPolyDataReader.GetNumberOfLines_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType GetNumberOfStrips()
// "virtual vtkIdType GetNumberOfStrips()"
public new long GetNumberOfStrips() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkXMLPolyDataReader.GetNumberOfStrips_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType GetNumberOfPolys()
// "virtual vtkIdType GetNumberOfPolys()"
public new long GetNumberOfPolys() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkXMLPolyDataReader.GetNumberOfPolys_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
