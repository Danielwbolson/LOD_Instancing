

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLImageDataReader : vtkXMLStructuredDataReader {
		public vtkXMLImageDataReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLImageDataReader(IntPtr p) {return new vtkXMLImageDataReader(p);}
		public static implicit operator  IntPtr(vtkXMLImageDataReader o) {return o.GetPtr();}

// static vtkXMLImageDataReader* New()
// "static vtkXMLImageDataReader *New()"
public static vtkXMLImageDataReader New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLImageDataReader.New_0(returnPointer.GetPtr());
	return (vtkXMLImageDataReader)(IntPtr)returnPointer;
}


// vtkImageData* GetOutput()
// "vtkImageData *GetOutput()"
public vtkImageData GetOutput() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLImageDataReader.GetOutput_0(returnPointer.GetPtr(), this);
	return (vtkImageData)(IntPtr)returnPointer;
}


// vtkImageData* GetOutput(int idx)
// "vtkImageData *GetOutput(int idx)"
public vtkImageData GetOutput(int /*(int)*/ idx) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLImageDataReader.GetOutput_1(returnPointer.GetPtr(), this, idx);
	return (vtkImageData)(IntPtr)returnPointer;
}


}
};
