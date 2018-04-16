
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public class vtkXMLUnstructuredGridReader : vtkXMLUnstructuredDataReader {

//       Method: virtual const char * vtkXMLUnstructuredGridReader::GetClassName()
// 
public static string GetClassName(IntPtr obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkXMLUnstructuredGridReader.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkXMLUnstructuredGridReader * vtkXMLUnstructuredGridReader::New()
// 
public static vtkXMLUnstructuredGridReader New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLUnstructuredGridReader.New(p);
			vtkXMLUnstructuredGridReader result = new vtkXMLUnstructuredGridReader(); 
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}

////       Method: static vtkXMLUnstructuredGridReader * vtkXMLUnstructuredGridReader::New()
//// 
//public static vtkXMLUnstructuredGridReader New2() {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkXMLUnstructuredGridReader.New(p);
//	IntPtr result = p;
//	Marshal.FreeHGlobal (p);
//	return result;
//}

//       Method: vtkUnstructuredGrid * vtkXMLUnstructuredGridReader::GetOutput()
// 
public static IntPtr GetOutput(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLUnstructuredGridReader.GetOutput(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkUnstructuredGrid * vtkXMLUnstructuredGridReader::GetOutput(int idx)
// 
public static IntPtr GetOutput(IntPtr obj, int idx) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLUnstructuredGridReader.GetOutput(p,obj, idx);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
