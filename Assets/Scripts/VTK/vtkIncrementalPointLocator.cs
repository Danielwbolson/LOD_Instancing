

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkIncrementalPointLocator : vtkAbstractPointLocator {

// virtual vtkIdType FindClosestInsertedPoint(const double x[3])
// "virtual vtkIdType FindClosestInsertedPoint( const double x[3] )"
public new long FindClosestInsertedPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIncrementalPointLocator.FindClosestInsertedPoint_0(this, returnPointer, x);
	return Ptr.deref(returnPointer);
}


// virtual int InitPointInsertion(vtkPoints * newPts, const double bounds[6])
// "virtual int InitPointInsertion( vtkPoints * newPts, const double bounds[6] )"
public new int InitPointInsertion(vtkPoints /*(vtkPoints*)*/ newPts, double /*(double[6])*/ []bounds) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkIncrementalPointLocator.InitPointInsertion_0(this, returnPointer, newPts, bounds);
	return Ptr.deref(returnPointer);
}


// virtual int InitPointInsertion(vtkPoints * newPts, const double bounds[6], vtkIdType estSize)
// "virtual int InitPointInsertion( vtkPoints * newPts, const double bounds[6], vtkIdType estSize )"
public new int InitPointInsertion(vtkPoints /*(vtkPoints*)*/ newPts, double /*(double[6])*/ []bounds, long /*(vtkIdType)*/ estSize) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkIncrementalPointLocator.InitPointInsertion_1(this, returnPointer, newPts, bounds, estSize);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType IsInsertedPoint(double x, double y, double z)
// "virtual vtkIdType IsInsertedPoint( double x, double y, double z )"
public new long IsInsertedPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIncrementalPointLocator.IsInsertedPoint_0(this, returnPointer, x, y, z);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType IsInsertedPoint(const double x[3])
// "virtual vtkIdType IsInsertedPoint( const double x[3] )"
public new long IsInsertedPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIncrementalPointLocator.IsInsertedPoint_1(this, returnPointer, x);
	return Ptr.deref(returnPointer);
}


// virtual int InsertUniquePoint(const double x[3], vtkIdType & ptId)
// "virtual int InsertUniquePoint( const double x[3], vtkIdType & ptId )"
public new int InsertUniquePoint(double /*(double[3])*/ []x, long /*(vtkIdType&)*/ []ptId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkIncrementalPointLocator.InsertUniquePoint_0(this, returnPointer, x, *ptId);
	return Ptr.deref(returnPointer);
}


// virtual void InsertPoint(vtkIdType ptId, const double x[3])
// "virtual void InsertPoint( vtkIdType ptId, const double x[3] )"
public new void InsertPoint(long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []x) {
	API_vtkIncrementalPointLocator.InsertPoint_0(this, ptId, x);
}


// virtual vtkIdType InsertNextPoint(const double x[3])
// "virtual vtkIdType InsertNextPoint( const double x[3] )"
public new long InsertNextPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIncrementalPointLocator.InsertNextPoint_0(this, returnPointer, x);
	return Ptr.deref(returnPointer);
}


}
};
