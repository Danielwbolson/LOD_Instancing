
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public class vtkObjectBase {

//       Method: const char * vtkObjectBase::GetClassName()
// 
public static string GetClassName(IntPtr obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkObjectBase.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: const char * vtkObjectBase::GetClassNameA()
// 
public static string GetClassNameA(IntPtr obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkObjectBase.GetClassNameA(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: const char * vtkObjectBase::GetClassNameW()
// 
public static string GetClassNameW(IntPtr obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkObjectBase.GetClassNameW(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkTypeBool vtkObjectBase::IsTypeOf(const char* name)
// 
public static bool IsTypeOf(string/*const char* */ name) {
	int numElements = 1;
	bool example = new bool();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObjectBase.IsTypeOf(p, name);
	bool result = Convert.ToBoolean(Marshal.ReadByte(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkTypeBool vtkObjectBase::IsA(const char* name)
// 
public static bool IsA(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	bool example = new bool();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObjectBase.IsA(p,obj, name);
	bool result = Convert.ToBoolean(Marshal.ReadByte(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkObjectBase::Delete()
// 
public static void Delete(IntPtr obj) {
	VTK.API_vtkObjectBase.Delete(obj);
}


//       Method: virtual void vtkObjectBase::FastDelete()
// 
public static void FastDelete(IntPtr obj) {
	VTK.API_vtkObjectBase.FastDelete(obj);
}


//       Method: static vtkObjectBase * vtkObjectBase::New()
// 
public static IntPtr New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObjectBase.New(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkObjectBase::InitializeObjectBase()
// 
public static void InitializeObjectBase(IntPtr obj) {
	VTK.API_vtkObjectBase.InitializeObjectBase(obj);
}


//       Method: virtual void vtkObjectBase::Register(vtkObjectBase* o)
// 
public static void Register(IntPtr obj, IntPtr/*vtkObjectBase* */ o) {
	VTK.API_vtkObjectBase.Register(obj, o);
}


//       Method: virtual void vtkObjectBase::UnRegister(vtkObjectBase* o)
// 
public static void UnRegister(IntPtr obj, IntPtr/*vtkObjectBase* */ o) {
	VTK.API_vtkObjectBase.UnRegister(obj, o);
}


//       Method: int vtkObjectBase::GetReferenceCount()
// 
public static int GetReferenceCount(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObjectBase.GetReferenceCount(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkObjectBase::SetReferenceCount(int ARG_0)
// 
public static void SetReferenceCount(IntPtr obj, int ARG_0) {
	VTK.API_vtkObjectBase.SetReferenceCount(obj, ARG_0);
}


}
};
