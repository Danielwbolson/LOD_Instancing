

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractPointLocator : vtkLocator {
		public vtkAbstractPointLocator(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractPointLocator(IntPtr p) {return new vtkAbstractPointLocator(p);}
		public static implicit operator  IntPtr(vtkAbstractPointLocator o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkAbstractPointLocator.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkAbstractPointLocator.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkAbstractPointLocator* SafeDownCast(vtkObjectBase * o)
// "static vtkAbstractPointLocator* SafeDownCast(vtkObjectBase *o)"
public static vtkAbstractPointLocator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAbstractPointLocator.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkAbstractPointLocator)(IntPtr)returnPointer;
}


// vtkAbstractPointLocator* NewInstance()
// "vtkAbstractPointLocator *NewInstance()"
public vtkAbstractPointLocator NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAbstractPointLocator.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkAbstractPointLocator)(IntPtr)returnPointer;
}


// virtual vtkIdType FindClosestPoint(const double x[3])
// "virtual vtkIdType FindClosestPoint(const double x[3])"
public long FindClosestPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkAbstractPointLocator.FindClosestPoint_0(returnPointer.GetPtr(), this, x);
	return (long)returnPointer;
}


// vtkIdType FindClosestPoint(double x, double y, double z)
// "vtkIdType FindClosestPoint(double x, double y, double z)"
public long FindClosestPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkAbstractPointLocator.FindClosestPoint_1(returnPointer.GetPtr(), this, x, y, z);
	return (long)returnPointer;
}


// virtual vtkIdType FindClosestPointWithinRadius(double radius, const double x[3], double & dist2)
// "virtual vtkIdType FindClosestPointWithinRadius( double radius, const double x[3], double& dist2)"
public long FindClosestPointWithinRadius(double /*(double)*/ radius, double /*(double[3])*/ []x, IntPtr /*(double&)*/ dist2) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkAbstractPointLocator.FindClosestPointWithinRadius_0(returnPointer.GetPtr(), this, radius, x, dist2);
	return (long)returnPointer;
}


// virtual void FindClosestNPoints(int N, const double x[3], vtkIdList * result)
// "virtual void FindClosestNPoints( int N, const double x[3], vtkIdList *result)"
public void FindClosestNPoints(int /*(int)*/ N, double /*(double[3])*/ []x, vtkIdList /*(vtkIdList*)*/ result) {
	VTK_API.API_vtkAbstractPointLocator.FindClosestNPoints_0(this, N, x, result);
}


// void FindClosestNPoints(int N, double x, double y, double z, vtkIdList * result)
// "void FindClosestNPoints(int N, double x, double y, double z, vtkIdList *result)"
public void FindClosestNPoints(int /*(int)*/ N, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, vtkIdList /*(vtkIdList*)*/ result) {
	VTK_API.API_vtkAbstractPointLocator.FindClosestNPoints_1(this, N, x, y, z, result);
}


// virtual void FindPointsWithinRadius(double R, const double x[3], vtkIdList * result)
// "virtual void FindPointsWithinRadius(double R, const double x[3], vtkIdList *result)"
public void FindPointsWithinRadius(double /*(double)*/ R, double /*(double[3])*/ []x, vtkIdList /*(vtkIdList*)*/ result) {
	VTK_API.API_vtkAbstractPointLocator.FindPointsWithinRadius_0(this, R, x, result);
}


// void FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList * result)
// "void FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList *result)"
public void FindPointsWithinRadius(double /*(double)*/ R, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, vtkIdList /*(vtkIdList*)*/ result) {
	VTK_API.API_vtkAbstractPointLocator.FindPointsWithinRadius_1(this, R, x, y, z, result);
}


// virtual double* GetBounds()
// "virtual double *GetBounds()"
public IntPtr GetBounds() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAbstractPointLocator.GetBounds_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetBounds(double * ARG_0)
// "virtual void GetBounds(double*)"
public void GetBounds(IntPtr /*(double*)*/ ARG_0) {
	VTK_API.API_vtkAbstractPointLocator.GetBounds_1(this, ARG_0);
}


// virtual vtkIdType GetNumberOfBuckets()
// "virtual vtkIdType GetNumberOfBuckets ()"
public long GetNumberOfBuckets() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkAbstractPointLocator.GetNumberOfBuckets_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


}
};
