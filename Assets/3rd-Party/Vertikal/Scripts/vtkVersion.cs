

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkVersion : vtkObject {
		public vtkVersion(IntPtr p) : base(p) {}
		public static implicit operator  vtkVersion(IntPtr p) {return new vtkVersion(p);}
		public static implicit operator  IntPtr(vtkVersion o) {return o.GetPtr();}

// static vtkVersion* New()
// "static vtkVersion *New()"
public static vtkVersion New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVersion.New_0(returnPointer.GetPtr());
	return (vtkVersion)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkVersion.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkVersion.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkVersion* SafeDownCast(vtkObjectBase * o)
// "static vtkVersion* SafeDownCast(vtkObjectBase *o)"
public static vtkVersion SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVersion.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkVersion)(IntPtr)returnPointer;
}


// vtkVersion* NewInstance()
// "vtkVersion *NewInstance()"
public vtkVersion NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVersion.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkVersion)(IntPtr)returnPointer;
}


// static char* GetVTKVersion()
// "static const char *GetVTKVersion()"
public static string GetVTKVersion() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVersion.GetVTKVersion_0(returnPointer.GetPtr());
	return (string)returnPointer;
}


// static int GetVTKMajorVersion()
// "static int GetVTKMajorVersion()"
public static int GetVTKMajorVersion() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVersion.GetVTKMajorVersion_0(returnPointer.GetPtr());
	return (int)returnPointer;
}


// static int GetVTKMinorVersion()
// "static int GetVTKMinorVersion()"
public static int GetVTKMinorVersion() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVersion.GetVTKMinorVersion_0(returnPointer.GetPtr());
	return (int)returnPointer;
}


// static int GetVTKBuildVersion()
// "static int GetVTKBuildVersion()"
public static int GetVTKBuildVersion() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVersion.GetVTKBuildVersion_0(returnPointer.GetPtr());
	return (int)returnPointer;
}


// static char* GetVTKSourceVersion()
// "static const char *GetVTKSourceVersion()"
public static string GetVTKSourceVersion() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVersion.GetVTKSourceVersion_0(returnPointer.GetPtr());
	return (string)returnPointer;
}


}
};
