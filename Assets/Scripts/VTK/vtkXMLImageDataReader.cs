

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLImageDataReader : vtkXMLStructuredDataReader {
		public vtkXMLImageDataReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLImageDataReader(IntPtr p) {return new vtkXMLImageDataReader(p);}
		public static implicit operator  IntPtr(vtkXMLImageDataReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkXMLImageDataReader.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkXMLImageDataReader.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkXMLImageDataReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLImageDataReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLImageDataReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkXMLImageDataReader.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkXMLImageDataReader)(IntPtr)returnPointer;
}


// vtkXMLImageDataReader* NewInstance()
// "vtkXMLImageDataReader *NewInstance()"
public vtkXMLImageDataReader NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkXMLImageDataReader.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkXMLImageDataReader)(IntPtr)returnPointer;
}


// static vtkXMLImageDataReader* New()
// "static vtkXMLImageDataReader *New()"
public static vtkXMLImageDataReader New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkXMLImageDataReader.New_0(returnPointer.GetPtr());
	return (vtkXMLImageDataReader)(IntPtr)returnPointer;
}


// vtkImageData* GetOutput()
// "vtkImageData *GetOutput()"
public vtkImageData GetOutput() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkXMLImageDataReader.GetOutput_0(returnPointer.GetPtr(), this);
	return (vtkImageData)(IntPtr)returnPointer;
}


// vtkImageData* GetOutput(int idx)
// "vtkImageData *GetOutput(int idx)"
public vtkImageData GetOutput(int /*(int)*/ idx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkXMLImageDataReader.GetOutput_1(returnPointer.GetPtr(), this, idx);
	return (vtkImageData)(IntPtr)returnPointer;
}


}
};
