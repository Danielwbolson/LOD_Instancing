
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public class vtkPointSet : vtkDataSet {

//       Method: virtual const char * vtkPointSet::GetClassName()
// 
public static string GetClassName(IntPtr obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkPointSet.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPointSet::Initialize()
// 
public static void Initialize(IntPtr obj) {
	VTK.API_vtkPointSet.Initialize(obj);
}


//       Method: void vtkPointSet::CopyStructure(vtkDataSet* pd)
// 
public static void CopyStructure(IntPtr obj, IntPtr/*vtkDataSet* */ pd) {
	VTK.API_vtkPointSet.CopyStructure(obj, pd);
}


//       Method: vtkIdType vtkPointSet::GetNumberOfPoints()
// 
public static long GetNumberOfPoints(IntPtr obj) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPointSet.GetNumberOfPoints(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPointSet::GetPoint(vtkIdType ptId, double x[3])
// 
public static void GetPoint(IntPtr obj, long ptId, double[] /*3*/ x) {
	VTK.API_vtkPointSet.GetPoint(obj, ptId, x);
}


//       Method: vtkIdType vtkPointSet::FindPoint(double x[3])
// 
public static long FindPoint(IntPtr obj, double[] /*3*/ x) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPointSet.FindPoint(p,obj, x);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkPointSet::FindPoint(double x, double y, double z)
// 
public static long FindPoint(IntPtr obj, double x, double y, double z) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPointSet.FindPoint(p,obj, x, y, z);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double * vtkPointSet::GetPoint(vtkIdType ptId)
// 
public static double[] GetPoint(IntPtr obj, long ptId) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPointSet.GetPoint(p,obj, ptId);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkCellIterator * vtkPointSet::NewCellIterator()
// 
public static IntPtr NewCellIterator(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPointSet.NewCellIterator(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkMTimeType vtkPointSet::GetMTime()
// 
public static IntPtr GetMTime(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPointSet.GetMTime(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPointSet::ComputeBounds()
// 
public static void ComputeBounds(IntPtr obj) {
	VTK.API_vtkPointSet.ComputeBounds(obj);
}


//       Method: void vtkPointSet::Squeeze()
// 
public static void Squeeze(IntPtr obj) {
	VTK.API_vtkPointSet.Squeeze(obj);
}


//       Method: virtual void vtkPointSet::SetPoints(vtkPoints* ARG_0)
// 
public static void SetPoints(IntPtr obj, IntPtr/*vtkPoints* */ ARG_0) {
	VTK.API_vtkPointSet.SetPoints(obj, ARG_0);
}


//       Method: void vtkPointSet::ShallowCopy(vtkDataObject* src)
// 
public static void ShallowCopy(IntPtr obj, IntPtr/*vtkDataObject* */ src) {
	VTK.API_vtkPointSet.ShallowCopy(obj, src);
}


//       Method: void vtkPointSet::DeepCopy(vtkDataObject* src)
// 
public static void DeepCopy(IntPtr obj, IntPtr/*vtkDataObject* */ src) {
	VTK.API_vtkPointSet.DeepCopy(obj, src);
}


//       Method: void vtkPointSet::Register(vtkObjectBase* o)
// 
public static void Register(IntPtr obj, IntPtr/*vtkObjectBase* */ o) {
	VTK.API_vtkPointSet.Register(obj, o);
}


//       Method: void vtkPointSet::UnRegister(vtkObjectBase* o)
// 
public static void UnRegister(IntPtr obj, IntPtr/*vtkObjectBase* */ o) {
	VTK.API_vtkPointSet.UnRegister(obj, o);
}


//       Method: static vtkPointSet * vtkPointSet::GetData(vtkInformation* info)
// 
public static IntPtr GetData(IntPtr/*vtkInformation* */ info) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPointSet.GetData(p, info);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkPointSet * vtkPointSet::GetData(vtkInformationVector* v, int i)
// 
public static IntPtr GetData(IntPtr/*vtkInformationVector* */ v, int i) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPointSet.GetData(p, v, i);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
