

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAlgorithmOutput : vtkObject {

// static vtkAlgorithmOutput* New()
// "static vtkAlgorithmOutput *New()"
public new static vtkAlgorithmOutput New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkAlgorithmOutput.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetIndex(int index)
// "void SetIndex(int index)"
public new void SetIndex(int /*(int)*/ index) {
	API_vtkAlgorithmOutput.SetIndex_0(this, index);
}


// int GetIndex()
// "int GetIndex()"
public new int GetIndex() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAlgorithmOutput.GetIndex_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkAlgorithm* GetProducer()
// "vtkAlgorithm* GetProducer()"
public new vtkAlgorithm GetProducer() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkAlgorithmOutput.GetProducer_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetProducer(vtkAlgorithm * producer)
// "void SetProducer(vtkAlgorithm* producer)"
public new void SetProducer(vtkAlgorithm /*(vtkAlgorithm*)*/ producer) {
	API_vtkAlgorithmOutput.SetProducer_0(this, producer);
}


}
};
