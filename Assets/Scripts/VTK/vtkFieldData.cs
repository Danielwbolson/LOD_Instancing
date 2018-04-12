
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public class vtkFieldData : vtkObject {

//       Method: static vtkFieldData * vtkFieldData::New()
// 
public static IntPtr New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkFieldData.New(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkFieldData::GetClassName()
// 
public static string GetClassName(IntPtr obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkFieldData.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkFieldData::Initialize()
// 
public static void Initialize(IntPtr obj) {
	VTK.API_vtkFieldData.Initialize(obj);
}


//       Method: int vtkFieldData::Allocate(vtkIdType sz)
// 
public static int Allocate(IntPtr obj, long sz) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkFieldData.Allocate(p,obj, sz);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkFieldData::CopyStructure(vtkFieldData* ARG_0)
// 
public static void CopyStructure(IntPtr obj, IntPtr/*vtkFieldData* */ ARG_0) {
	VTK.API_vtkFieldData.CopyStructure(obj, ARG_0);
}


//       Method: void vtkFieldData::AllocateArrays(int num)
// 
public static void AllocateArrays(IntPtr obj, int num) {
	VTK.API_vtkFieldData.AllocateArrays(obj, num);
}


//       Method: int vtkFieldData::GetNumberOfArrays()
// 
public static int GetNumberOfArrays(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkFieldData.GetNumberOfArrays(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkFieldData::AddArray(vtkAbstractArray* array)
// 
public static int AddArray(IntPtr obj, IntPtr/*vtkAbstractArray* */ array) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkFieldData.AddArray(p,obj, array);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkFieldData::RemoveArray(const char* name)
// 
public static void RemoveArray(IntPtr obj, string/*const char* */ name) {
	VTK.API_vtkFieldData.RemoveArray(obj, name);
}


//       Method: virtual void vtkFieldData::RemoveArray(int index)
// 
public static void RemoveArray(IntPtr obj, int index) {
	VTK.API_vtkFieldData.RemoveArray(obj, index);
}


//       Method: vtkDataArray * vtkFieldData::GetArray(int i)
// 
public static IntPtr GetArray(IntPtr obj, int i) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkFieldData.GetArray(p,obj, i);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkFieldData::GetArray(const char* arrayName)
// 
public static IntPtr GetArray(IntPtr obj, string/*const char* */ arrayName) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkFieldData.GetArray(p,obj, arrayName);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkAbstractArray * vtkFieldData::GetAbstractArray(int i)
// 
public static IntPtr GetAbstractArray(IntPtr obj, int i) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkFieldData.GetAbstractArray(p,obj, i);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkAbstractArray * vtkFieldData::GetAbstractArray(const char* arrayName)
// 
public static IntPtr GetAbstractArray(IntPtr obj, string/*const char* */ arrayName) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkFieldData.GetAbstractArray(p,obj, arrayName);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkFieldData::HasArray(const char* name)
// 
public static int HasArray(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkFieldData.HasArray(p,obj, name);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkFieldData::PassData(vtkFieldData* fd)
// 
public static void PassData(IntPtr obj, IntPtr/*vtkFieldData* */ fd) {
	VTK.API_vtkFieldData.PassData(obj, fd);
}


//       Method: void vtkFieldData::CopyFieldOn(const char* name)
// 
public static void CopyFieldOn(IntPtr obj, string/*const char* */ name) {
	VTK.API_vtkFieldData.CopyFieldOn(obj, name);
}


//       Method: void vtkFieldData::CopyFieldOff(const char* name)
// 
public static void CopyFieldOff(IntPtr obj, string/*const char* */ name) {
	VTK.API_vtkFieldData.CopyFieldOff(obj, name);
}


//       Method: virtual void vtkFieldData::CopyAllOn(int unused)
// 
public static void CopyAllOn(IntPtr obj, int unused) {
	VTK.API_vtkFieldData.CopyAllOn(obj, unused);
}


//       Method: virtual void vtkFieldData::CopyAllOff(int unused)
// 
public static void CopyAllOff(IntPtr obj, int unused) {
	VTK.API_vtkFieldData.CopyAllOff(obj, unused);
}


//       Method: virtual void vtkFieldData::DeepCopy(vtkFieldData* da)
// 
public static void DeepCopy(IntPtr obj, IntPtr/*vtkFieldData* */ da) {
	VTK.API_vtkFieldData.DeepCopy(obj, da);
}


//       Method: virtual void vtkFieldData::ShallowCopy(vtkFieldData* da)
// 
public static void ShallowCopy(IntPtr obj, IntPtr/*vtkFieldData* */ da) {
	VTK.API_vtkFieldData.ShallowCopy(obj, da);
}


//       Method: void vtkFieldData::Squeeze()
// 
public static void Squeeze(IntPtr obj) {
	VTK.API_vtkFieldData.Squeeze(obj);
}


//       Method: void vtkFieldData::Reset()
// 
public static void Reset(IntPtr obj) {
	VTK.API_vtkFieldData.Reset(obj);
}


//       Method: vtkMTimeType vtkFieldData::GetMTime()
// 
public static IntPtr GetMTime(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkFieldData.GetMTime(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkFieldData::GetField(vtkIdList* ptId, vtkFieldData* f)
// 
public static void GetField(IntPtr obj, IntPtr/*vtkIdList* */ ptId, IntPtr/*vtkFieldData* */ f) {
	VTK.API_vtkFieldData.GetField(obj, ptId, f);
}


//       Method: int vtkFieldData::GetNumberOfComponents()
// 
public static int GetNumberOfComponents(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkFieldData.GetNumberOfComponents(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkFieldData::GetNumberOfTuples()
// 
public static long GetNumberOfTuples(IntPtr obj) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkFieldData.GetNumberOfTuples(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkFieldData::SetNumberOfTuples(const vtkIdType number)
// 
public static void SetNumberOfTuples(IntPtr obj, long number) {
	VTK.API_vtkFieldData.SetNumberOfTuples(obj, number);
}


//       Method: void vtkFieldData::SetTuple(const vtkIdType i, const vtkIdType j, vtkFieldData* source)
// 
public static void SetTuple(IntPtr obj, long i, long j, IntPtr/*vtkFieldData* */ source) {
	VTK.API_vtkFieldData.SetTuple(obj, i, j, source);
}


//       Method: void vtkFieldData::InsertTuple(const vtkIdType i, const vtkIdType j, vtkFieldData* source)
// 
public static void InsertTuple(IntPtr obj, long i, long j, IntPtr/*vtkFieldData* */ source) {
	VTK.API_vtkFieldData.InsertTuple(obj, i, j, source);
}


//       Method: vtkIdType vtkFieldData::InsertNextTuple(const vtkIdType j, vtkFieldData* source)
// 
public static long InsertNextTuple(IntPtr obj, long j, IntPtr/*vtkFieldData* */ source) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkFieldData.InsertNextTuple(p,obj, j, source);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
