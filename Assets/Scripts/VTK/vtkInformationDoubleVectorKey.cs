
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkInformationDoubleVectorKey : vtkInformationKey {

//       Method: virtual const char * vtkInformationDoubleVectorKey::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkInformationDoubleVectorKey.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


////  Constructor: vtkInformationDoubleVectorKey::vtkInformationDoubleVectorKey(const char* name, const char* location)
//// 
//public  vtkInformationDoubleVectorKey(string/*const char* */ name, string/*const char* */ location) {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey(p,obj, name, location);
//	 result = new ();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}
//

//       Method: static vtkInformationDoubleVectorKey * vtkInformationDoubleVectorKey::MakeKey(const char* name, const char* location)
// 
public static vtkInformationDoubleVectorKey MakeKey(string/*const char* */ name, string/*const char* */ location) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkInformationDoubleVectorKey.MakeKey(p, name, location);
	vtkInformationDoubleVectorKey result = new vtkInformationDoubleVectorKey();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkInformationDoubleVectorKey::Append(vtkInformation* info, double value)
// 
public void Append(vtkInformation/*vtkInformation* */ info, double value) {
	VTK.API_vtkInformationDoubleVectorKey.Append(obj, info, value);
}


//       Method: void vtkInformationDoubleVectorKey::Set(vtkInformation* info, const double* value, int length)
// 
public void Set(vtkInformation/*vtkInformation* */ info, double/*const double* */ value, int length) {
	VTK.API_vtkInformationDoubleVectorKey.Set(obj, info, value, length);
}


//       Method: double * vtkInformationDoubleVectorKey::Get(vtkInformation* info)
// 
public double[] Get(vtkInformation/*vtkInformation* */ info) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkInformationDoubleVectorKey.Get(p,obj, info);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double vtkInformationDoubleVectorKey::Get(vtkInformation* info, int idx)
// 
public double Get(vtkInformation/*vtkInformation* */ info, int idx) {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkInformationDoubleVectorKey.Get(p,obj, info, idx);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkInformationDoubleVectorKey::Get(vtkInformation* info, double* value)
// 
public void Get(vtkInformation/*vtkInformation* */ info, double/*double* */ value) {
	VTK.API_vtkInformationDoubleVectorKey.Get(obj, info, value);
}


//       Method: int vtkInformationDoubleVectorKey::Length(vtkInformation* info)
// 
public int Length(vtkInformation/*vtkInformation* */ info) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkInformationDoubleVectorKey.Length(p,obj, info);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkInformationDoubleVectorKey::ShallowCopy(vtkInformation* from, vtkInformation* to)
// 
public void ShallowCopy(vtkInformation/*vtkInformation* */ from, vtkInformation/*vtkInformation* */ to) {
	VTK.API_vtkInformationDoubleVectorKey.ShallowCopy(obj, from, to);
}


}
};
