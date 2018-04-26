
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkAbstractPointLocator : vtkLocator {

//       Method: virtual const char * vtkAbstractPointLocator::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkAbstractPointLocator.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkAbstractPointLocator::FindClosestPoint(const double x[3])
// 
public long FindClosestPoint(double[] /*3*/ x) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractPointLocator.FindClosestPoint(p,obj, x);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkAbstractPointLocator::FindClosestPoint(double x, double y, double z)
// 
public long FindClosestPoint(double x, double y, double z) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractPointLocator.FindClosestPoint(p,obj, x, y, z);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAbstractPointLocator::FindClosestNPoints(int N, const double x[3], vtkIdList* result)
// 
public void FindClosestNPoints(int N, double[] /*3*/ x, vtkIdList/*vtkIdList* */ result) {
	VTK.API_vtkAbstractPointLocator.FindClosestNPoints(obj, N, x, result);
}


//       Method: void vtkAbstractPointLocator::FindClosestNPoints(int N, double x, double y, double z, vtkIdList* result)
// 
public void FindClosestNPoints(int N, double x, double y, double z, vtkIdList/*vtkIdList* */ result) {
	VTK.API_vtkAbstractPointLocator.FindClosestNPoints(obj, N, x, y, z, result);
}


//       Method: virtual void vtkAbstractPointLocator::FindPointsWithinRadius(double R, const double x[3], vtkIdList* result)
// 
public void FindPointsWithinRadius(double R, double[] /*3*/ x, vtkIdList/*vtkIdList* */ result) {
	VTK.API_vtkAbstractPointLocator.FindPointsWithinRadius(obj, R, x, result);
}


//       Method: void vtkAbstractPointLocator::FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList* result)
// 
public void FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList/*vtkIdList* */ result) {
	VTK.API_vtkAbstractPointLocator.FindPointsWithinRadius(obj, R, x, y, z, result);
}


//       Method: virtual double * vtkAbstractPointLocator::GetBounds()
// 
public double[] GetBounds() {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractPointLocator.GetBounds(p,obj);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
