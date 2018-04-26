
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkIncrementalPointLocator : vtkAbstractPointLocator {

//       Method: virtual const char * vtkIncrementalPointLocator::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkIncrementalPointLocator.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkIncrementalPointLocator::FindClosestInsertedPoint(const double x[3])
// 
public long FindClosestInsertedPoint(double[] /*3*/ x) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIncrementalPointLocator.FindClosestInsertedPoint(p,obj, x);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkIncrementalPointLocator::InitPointInsertion(vtkPoints* newPts, const double bounds[6])
// 
public int InitPointInsertion(vtkPoints/*vtkPoints* */ newPts, double[] /*6*/ bounds) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIncrementalPointLocator.InitPointInsertion(p,obj, newPts, bounds);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkIncrementalPointLocator::InitPointInsertion(vtkPoints* newPts, const double bounds[6], vtkIdType estSize)
// 
public int InitPointInsertion(vtkPoints/*vtkPoints* */ newPts, double[] /*6*/ bounds, long estSize) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIncrementalPointLocator.InitPointInsertion(p,obj, newPts, bounds, estSize);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkIncrementalPointLocator::IsInsertedPoint(double x, double y, double z)
// 
public long IsInsertedPoint(double x, double y, double z) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIncrementalPointLocator.IsInsertedPoint(p,obj, x, y, z);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkIncrementalPointLocator::IsInsertedPoint(const double x[3])
// 
public long IsInsertedPoint(double[] /*3*/ x) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIncrementalPointLocator.IsInsertedPoint(p,obj, x);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkIncrementalPointLocator::InsertPoint(vtkIdType ptId, const double x[3])
// 
public void InsertPoint(long ptId, double[] /*3*/ x) {
	VTK.API_vtkIncrementalPointLocator.InsertPoint(obj, ptId, x);
}


//       Method: virtual vtkIdType vtkIncrementalPointLocator::InsertNextPoint(const double x[3])
// 
public long InsertNextPoint(double[] /*3*/ x) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIncrementalPointLocator.InsertNextPoint(p,obj, x);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
