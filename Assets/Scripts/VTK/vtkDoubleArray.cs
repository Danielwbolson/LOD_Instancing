
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkDoubleArray : vtkDataArray {

//       Method: virtual const char * vtkDoubleArray::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkDoubleArray.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkDoubleArray * vtkDoubleArray::New()
// 
public static vtkDoubleArray New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDoubleArray.New(p);
	vtkDoubleArray result = new vtkDoubleArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkDoubleArray * vtkDoubleArray::FastDownCast(vtkAbstractArray* source)
// 
public static vtkDoubleArray FastDownCast(vtkAbstractArray/*vtkAbstractArray* */ source) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDoubleArray.FastDownCast(p, source);
	vtkDoubleArray result = new vtkDoubleArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static double vtkDoubleArray::GetDataTypeValueMin()
// 
public static double GetDataTypeValueMin() {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDoubleArray.GetDataTypeValueMin(p);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static double vtkDoubleArray::GetDataTypeValueMax()
// 
public static double GetDataTypeValueMax() {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDoubleArray.GetDataTypeValueMax(p);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
