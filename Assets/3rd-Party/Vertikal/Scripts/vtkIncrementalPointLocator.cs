

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkIncrementalPointLocator : vtkAbstractPointLocator {
		public vtkIncrementalPointLocator(IntPtr p) : base(p) {}
		public static implicit operator  vtkIncrementalPointLocator(IntPtr p) {return new vtkIncrementalPointLocator(p);}
		public static implicit operator  IntPtr(vtkIncrementalPointLocator o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkIncrementalPointLocator.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkIncrementalPointLocator.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkIncrementalPointLocator* SafeDownCast(vtkObjectBase * o)
// "static vtkIncrementalPointLocator* SafeDownCast(vtkObjectBase *o)"
public static vtkIncrementalPointLocator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkIncrementalPointLocator.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkIncrementalPointLocator)(IntPtr)returnPointer;
}


// vtkIncrementalPointLocator* NewInstance()
// "vtkIncrementalPointLocator *NewInstance()"
public vtkIncrementalPointLocator NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkIncrementalPointLocator.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkIncrementalPointLocator)(IntPtr)returnPointer;
}


// virtual vtkIdType FindClosestInsertedPoint(const double x[3])
// "virtual vtkIdType FindClosestInsertedPoint( const double x[3] )"
public long FindClosestInsertedPoint(double /*(double[3])*/ []x) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkIncrementalPointLocator.FindClosestInsertedPoint_0(returnPointer.GetPtr(), this, x);
	return (long)returnPointer;
}


// virtual int InitPointInsertion(vtkPoints * newPts, const double bounds[6])
// "virtual int InitPointInsertion( vtkPoints * newPts, const double bounds[6] )"
public int InitPointInsertion(vtkPoints /*(vtkPoints*)*/ newPts, double /*(double[6])*/ []bounds) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkIncrementalPointLocator.InitPointInsertion_0(returnPointer.GetPtr(), this, newPts, bounds);
	return (int)returnPointer;
}


// virtual int InitPointInsertion(vtkPoints * newPts, const double bounds[6], vtkIdType estSize)
// "virtual int InitPointInsertion( vtkPoints * newPts, const double bounds[6], vtkIdType estSize )"
public int InitPointInsertion(vtkPoints /*(vtkPoints*)*/ newPts, double /*(double[6])*/ []bounds, long /*(vtkIdType)*/ estSize) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkIncrementalPointLocator.InitPointInsertion_1(returnPointer.GetPtr(), this, newPts, bounds, estSize);
	return (int)returnPointer;
}


// virtual vtkIdType IsInsertedPoint(double x, double y, double z)
// "virtual vtkIdType IsInsertedPoint( double x, double y, double z )"
public long IsInsertedPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkIncrementalPointLocator.IsInsertedPoint_0(returnPointer.GetPtr(), this, x, y, z);
	return (long)returnPointer;
}


// virtual vtkIdType IsInsertedPoint(const double x[3])
// "virtual vtkIdType IsInsertedPoint( const double x[3] )"
public long IsInsertedPoint(double /*(double[3])*/ []x) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkIncrementalPointLocator.IsInsertedPoint_1(returnPointer.GetPtr(), this, x);
	return (long)returnPointer;
}


// virtual int InsertUniquePoint(const double x[3], vtkIdType & ptId)
// "virtual int InsertUniquePoint( const double x[3], vtkIdType & ptId )"
public int InsertUniquePoint(double /*(double[3])*/ []x, IntPtr /*(vtkIdType&)*/ ptId) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkIncrementalPointLocator.InsertUniquePoint_0(returnPointer.GetPtr(), this, x, ptId);
	return (int)returnPointer;
}


// virtual void InsertPoint(vtkIdType ptId, const double x[3])
// "virtual void InsertPoint( vtkIdType ptId, const double x[3] )"
public void InsertPoint(long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []x) {
	VTK_API.API_vtkIncrementalPointLocator.InsertPoint_0(this, ptId, x);
}


// virtual vtkIdType InsertNextPoint(const double x[3])
// "virtual vtkIdType InsertNextPoint( const double x[3] )"
public long InsertNextPoint(double /*(double[3])*/ []x) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkIncrementalPointLocator.InsertNextPoint_0(returnPointer.GetPtr(), this, x);
	return (long)returnPointer;
}


}
};
