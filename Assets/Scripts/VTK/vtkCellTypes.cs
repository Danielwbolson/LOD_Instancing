
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkCellTypes : vtkObject {

//       Method: static vtkCellTypes * vtkCellTypes::New()
// 
public static vtkCellTypes New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellTypes.New(p);
	vtkCellTypes result = new vtkCellTypes();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkCellTypes::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkCellTypes.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkCellTypes::Allocate(int sz, int ext)
// 
public int Allocate(int sz, int ext) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellTypes.Allocate(p,obj, sz, ext);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCellTypes::InsertCell(vtkIdType id, unsigned char type, vtkIdType loc)
// 
public void InsertCell(long id, byte type, long loc) {
	VTK.API_vtkCellTypes.InsertCell(obj, id, type, loc);
}


//       Method: vtkIdType vtkCellTypes::InsertNextCell(unsigned char type, vtkIdType loc)
// 
public long InsertNextCell(byte type, long loc) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellTypes.InsertNextCell(p,obj, type, loc);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCellTypes::SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray* cellTypes, vtkIdTypeArray* cellLocations)
// 
public void SetCellTypes(long ncells, vtkUnsignedCharArray/*vtkUnsignedCharArray* */ cellTypes, vtkIdTypeArray/*vtkIdTypeArray* */ cellLocations) {
	VTK.API_vtkCellTypes.SetCellTypes(obj, ncells, cellTypes, cellLocations);
}


//       Method: void vtkCellTypes::SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray* cellTypes, vtkIntArray* cellLocations)
// 
public void SetCellTypes(long ncells, vtkUnsignedCharArray/*vtkUnsignedCharArray* */ cellTypes, vtkIntArray/*vtkIntArray* */ cellLocations) {
	VTK.API_vtkCellTypes.SetCellTypes(obj, ncells, cellTypes, cellLocations);
}


//       Method: vtkIdType vtkCellTypes::GetCellLocation(vtkIdType cellId)
// 
public long GetCellLocation(long cellId) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellTypes.GetCellLocation(p,obj, cellId);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCellTypes::DeleteCell(vtkIdType cellId)
// 
public void DeleteCell(long cellId) {
	VTK.API_vtkCellTypes.DeleteCell(obj, cellId);
}


//       Method: vtkIdType vtkCellTypes::GetNumberOfTypes()
// 
public long GetNumberOfTypes() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellTypes.GetNumberOfTypes(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkCellTypes::IsType(unsigned char type)
// 
public int IsType(byte type) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellTypes.IsType(p,obj, type);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkCellTypes::InsertNextType(unsigned char type)
// 
public long InsertNextType(byte type) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellTypes.InsertNextType(p,obj, type);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCellTypes::Squeeze()
// 
public void Squeeze() {
	VTK.API_vtkCellTypes.Squeeze(obj);
}


//       Method: void vtkCellTypes::Reset()
// 
public void Reset() {
	VTK.API_vtkCellTypes.Reset(obj);
}


//       Method: void vtkCellTypes::DeepCopy(vtkCellTypes* src)
// 
public void DeepCopy(vtkCellTypes/*vtkCellTypes* */ src) {
	VTK.API_vtkCellTypes.DeepCopy(obj, src);
}


//       Method: static const char * vtkCellTypes::GetClassNameFromTypeId(int typeId)
// 
public static string GetClassNameFromTypeId(int typeId) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkCellTypes.GetClassNameFromTypeId(p, typeId);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static int vtkCellTypes::GetTypeIdFromClassName(const char* classname)
// 
public static int GetTypeIdFromClassName(string/*const char* */ classname) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellTypes.GetTypeIdFromClassName(p, classname);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static int vtkCellTypes::IsLinear(unsigned char type)
// 
public static int IsLinear(byte type) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellTypes.IsLinear(p, type);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
