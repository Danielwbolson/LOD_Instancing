
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public class vtkPointData : vtkDataSetAttributes {

//       Method: static vtkPointData * vtkPointData::New()
// 
public static IntPtr New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPointData.New(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkPointData::GetClassName()
// 
public static string GetClassName(IntPtr obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkPointData.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPointData::NullPoint(vtkIdType ptId)
// 
public static void NullPoint(IntPtr obj, long ptId) {
	VTK.API_vtkPointData.NullPoint(obj, ptId);
}


}
};
