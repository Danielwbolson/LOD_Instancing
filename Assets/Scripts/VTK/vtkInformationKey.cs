
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkInformationKey : vtkObjectBase {

//       Method: const char * vtkInformationKey::GetName()
// 
public string GetName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkInformationKey.GetName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: const char * vtkInformationKey::GetLocation()
// 
public string GetLocation() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkInformationKey.GetLocation(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


////  Constructor: vtkInformationKey::vtkInformationKey(const char* name, const char* location)
//// 
//public  vtkInformationKey(string/*const char* */ name, string/*const char* */ location) {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkInformationKey.vtkInformationKey(p,obj, name, location);
//	 result = new ();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}
//

//       Method: virtual void vtkInformationKey::ShallowCopy(vtkInformation* from, vtkInformation* to)
// 
public void ShallowCopy(vtkInformation/*vtkInformation* */ from, vtkInformation/*vtkInformation* */ to) {
	VTK.API_vtkInformationKey.ShallowCopy(obj, from, to);
}


//       Method: virtual void vtkInformationKey::DeepCopy(vtkInformation* from, vtkInformation* to)
// 
public void DeepCopy(vtkInformation/*vtkInformation* */ from, vtkInformation/*vtkInformation* */ to) {
	VTK.API_vtkInformationKey.DeepCopy(obj, from, to);
}


//       Method: virtual int vtkInformationKey::Has(vtkInformation* info)
// 
public int Has(vtkInformation/*vtkInformation* */ info) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkInformationKey.Has(p,obj, info);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkInformationKey::Remove(vtkInformation* info)
// 
public void Remove(vtkInformation/*vtkInformation* */ info) {
	VTK.API_vtkInformationKey.Remove(obj, info);
}


//       Method: virtual void vtkInformationKey::Report(vtkInformation* info, vtkGarbageCollector* collector)
// 
public void Report(vtkInformation/*vtkInformation* */ info, vtkGarbageCollector/*vtkGarbageCollector* */ collector) {
	VTK.API_vtkInformationKey.Report(obj, info, collector);
}


}
};
