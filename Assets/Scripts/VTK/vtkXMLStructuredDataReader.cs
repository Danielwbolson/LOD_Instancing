

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
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkXMLStructuredDataReader.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkXMLStructuredDataReader.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkXMLStructuredDataReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLStructuredDataReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLStructuredDataReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkXMLStructuredDataReader.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkXMLStructuredDataReader)(IntPtr)returnPointer;
}


// vtkXMLStructuredDataReader* NewInstance()
// "vtkXMLStructuredDataReader *NewInstance()"
public vtkXMLStructuredDataReader NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkXMLStructuredDataReader.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkXMLStructuredDataReader)(IntPtr)returnPointer;
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkXMLStructuredDataReader.GetNumberOfPoints_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
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
	ReturnPointer returnPointer = new ReturnPointer(new int());
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


// void CopyOutputInformation(vtkInformation * outInfo, int port)
// "void CopyOutputInformation(vtkInformation *outInfo, int port)"
public void CopyOutputInformation(vtkInformation /*(vtkInformation*)*/ outInfo, int /*(int)*/ port) {
	VTK_API.API_vtkXMLStructuredDataReader.CopyOutputInformation_0(this, outInfo, port);
}


}
};
