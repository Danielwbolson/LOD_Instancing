

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAlgorithmOutput : vtkObject {
		public vtkAlgorithmOutput(IntPtr p) : base(p) {}
		public static implicit operator  vtkAlgorithmOutput(IntPtr p) {return new vtkAlgorithmOutput(p);}
		public static implicit operator  IntPtr(vtkAlgorithmOutput o) {return o.GetPtr();}

// static vtkAlgorithmOutput* New()
// "static vtkAlgorithmOutput *New()"
public static vtkAlgorithmOutput New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkAlgorithmOutput.New_0(returnPointer.GetPtr());
	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
}


// void SetIndex(int index)
// "void SetIndex(int index)"
public void SetIndex(int /*(int)*/ index) {
	API_vtkAlgorithmOutput.SetIndex_0(this, index);
}


// int GetIndex()
// "int GetIndex()"
public int GetIndex() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkAlgorithmOutput.GetIndex_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkAlgorithm* GetProducer()
// "vtkAlgorithm* GetProducer()"
public vtkAlgorithm GetProducer() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkAlgorithmOutput.GetProducer_0(returnPointer.GetPtr(), this);
	return (vtkAlgorithm)(IntPtr)returnPointer;
}


// void SetProducer(vtkAlgorithm * producer)
// "void SetProducer(vtkAlgorithm* producer)"
public void SetProducer(vtkAlgorithm /*(vtkAlgorithm*)*/ producer) {
	API_vtkAlgorithmOutput.SetProducer_0(this, producer);
}


}
};
