
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkUnsignedCharArray : vtkDataArray {

//       Method: virtual const char * vtkUnsignedCharArray::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkUnsignedCharArray.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkUnsignedCharArray * vtkUnsignedCharArray::New()
// 
public static vtkUnsignedCharArray New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnsignedCharArray.New(p);
	vtkUnsignedCharArray result = new vtkUnsignedCharArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkUnsignedCharArray * vtkUnsignedCharArray::FastDownCast(vtkAbstractArray* source)
// 
public static vtkUnsignedCharArray FastDownCast(vtkAbstractArray/*vtkAbstractArray* */ source) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnsignedCharArray.FastDownCast(p, source);
	vtkUnsignedCharArray result = new vtkUnsignedCharArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
