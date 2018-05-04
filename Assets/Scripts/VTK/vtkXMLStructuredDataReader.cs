

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLStructuredDataReader : vtkXMLDataReader {
		public vtkXMLStructuredDataReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLStructuredDataReader(IntPtr p) {return new vtkXMLStructuredDataReader(p);}
		public static implicit operator  IntPtr(vtkXMLStructuredDataReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLStructuredDataReader.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLStructuredDataReader.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkXMLStructuredDataReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLStructuredDataReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLStructuredDataReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLStructuredDataReader.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkXMLStructuredDataReader)(IntPtr)returnPointer;
}


// vtkXMLStructuredDataReader* NewInstance()
// "vtkXMLStructuredDataReader *NewInstance()"
public vtkXMLStructuredDataReader NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLStructuredDataReader.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkXMLStructuredDataReader)(IntPtr)returnPointer;
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkXMLStructuredDataReader.GetNumberOfPoints_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkXMLStructuredDataReader.GetNumberOfCells_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual void SetWholeSlices(int _arg)
// "virtual void SetWholeSlices (int _arg)"
public void SetWholeSlices(int /*(int)*/ _arg) {
	VTK_API.API_vtkXMLStructuredDataReader.SetWholeSlices_0(this, _arg);
}


// virtual int GetWholeSlices()
// "virtual int GetWholeSlices ()"
public int GetWholeSlices() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLStructuredDataReader.GetWholeSlices_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void WholeSlicesOn()
// "virtual void WholeSlicesOn ()"
public void WholeSlicesOn() {
	VTK_API.API_vtkXMLStructuredDataReader.WholeSlicesOn_0(this);
}


// virtual void WholeSlicesOff()
// "virtual void WholeSlicesOff ()"
public void WholeSlicesOff() {
	VTK_API.API_vtkXMLStructuredDataReader.WholeSlicesOff_0(this);
}


}
};
