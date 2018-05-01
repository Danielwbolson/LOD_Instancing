

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractPointLocator : vtkLocator {

// virtual vtkIdType FindClosestPoint(const double x[3])
// "virtual vtkIdType FindClosestPoint(const double x[3])"
public new long FindClosestPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkAbstractPointLocator.FindClosestPoint_0(this, returnPointer, x);
	return Ptr.deref(returnPointer);
}


// vtkIdType FindClosestPoint(double x, double y, double z)
// "vtkIdType FindClosestPoint(double x, double y, double z)"
public new long FindClosestPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkAbstractPointLocator.FindClosestPoint_1(this, returnPointer, x, y, z);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType FindClosestPointWithinRadius(double radius, const double x[3], double & dist2)
// "virtual vtkIdType FindClosestPointWithinRadius( double radius, const double x[3], double& dist2)"
public new long FindClosestPointWithinRadius(double /*(double)*/ radius, double /*(double[3])*/ []x, double /*(double&)*/ []dist2) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkAbstractPointLocator.FindClosestPointWithinRadius_0(this, returnPointer, radius, x, *dist2);
	return Ptr.deref(returnPointer);
}


// virtual void FindClosestNPoints(int N, const double x[3], vtkIdList * result)
// "virtual void FindClosestNPoints( int N, const double x[3], vtkIdList *result)"
public new void FindClosestNPoints(int /*(int)*/ N, double /*(double[3])*/ []x, vtkIdList /*(vtkIdList*)*/ result) {
	API_vtkAbstractPointLocator.FindClosestNPoints_0(this, N, x, result);
}


// void FindClosestNPoints(int N, double x, double y, double z, vtkIdList * result)
// "void FindClosestNPoints(int N, double x, double y, double z, vtkIdList *result)"
public new void FindClosestNPoints(int /*(int)*/ N, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, vtkIdList /*(vtkIdList*)*/ result) {
	API_vtkAbstractPointLocator.FindClosestNPoints_1(this, N, x, y, z, result);
}


// virtual void FindPointsWithinRadius(double R, const double x[3], vtkIdList * result)
// "virtual void FindPointsWithinRadius(double R, const double x[3], vtkIdList *result)"
public new void FindPointsWithinRadius(double /*(double)*/ R, double /*(double[3])*/ []x, vtkIdList /*(vtkIdList*)*/ result) {
	API_vtkAbstractPointLocator.FindPointsWithinRadius_0(this, R, x, result);
}


// void FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList * result)
// "void FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList *result)"
public new void FindPointsWithinRadius(double /*(double)*/ R, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, vtkIdList /*(vtkIdList*)*/ result) {
	API_vtkAbstractPointLocator.FindPointsWithinRadius_1(this, R, x, y, z, result);
}


// virtual double* GetBounds()
// "virtual double *GetBounds()"
public new double GetBounds() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkAbstractPointLocator.GetBounds_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void GetBounds(double * ARG_0)
// "virtual void GetBounds(double*)"
public new void GetBounds(double /*(double*)*/ []ARG_0) {
	API_vtkAbstractPointLocator.GetBounds_1(this, ARG_0);
}


}
};
