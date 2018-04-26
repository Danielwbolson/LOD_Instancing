
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkIdTypeArray : vtkDataArray {

//       Method: virtual const char * vtkIdTypeArray::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkIdTypeArray.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkIdTypeArray * vtkIdTypeArray::New()
// 
public static vtkIdTypeArray New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdTypeArray.New(p);
	vtkIdTypeArray result = new vtkIdTypeArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkIdTypeArray::GetDataType()
// 
public int GetDataType() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdTypeArray.GetDataType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkIdTypeArray * vtkIdTypeArray::FastDownCast(vtkAbstractArray* source)
// 
public static vtkIdTypeArray FastDownCast(vtkAbstractArray/*vtkAbstractArray* */ source) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdTypeArray.FastDownCast(p, source);
	vtkIdTypeArray result = new vtkIdTypeArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkIdType vtkIdTypeArray::GetDataTypeValueMin()
// 
public static long GetDataTypeValueMin() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdTypeArray.GetDataTypeValueMin(p);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkIdType vtkIdTypeArray::GetDataTypeValueMax()
// 
public static long GetDataTypeValueMax() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdTypeArray.GetDataTypeValueMax(p);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
