
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkPoints : vtkObject {

//       Method: static vtkPoints * vtkPoints::New(int dataType)
// 
public static vtkPoints New(int dataType) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.New(p, dataType);
	vtkPoints result = new vtkPoints();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkPoints * vtkPoints::New()
// 
public static vtkPoints New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.New(p);
	vtkPoints result = new vtkPoints();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkPoints::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkPoints.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkPoints::Allocate(vtkIdType sz, vtkIdType ext)
// 
public int Allocate(long sz, long ext) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.Allocate(p,obj, sz, ext);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkPoints::Initialize()
// 
public void Initialize() {
	VTK.API_vtkPoints.Initialize(obj);
}


//       Method: virtual void vtkPoints::SetData(vtkDataArray* ARG_0)
// 
public void SetData(vtkDataArray/*vtkDataArray* */ ARG_0) {
	VTK.API_vtkPoints.SetData(obj, ARG_0);
}


//       Method: vtkDataArray * vtkPoints::GetData()
// 
public vtkDataArray GetData() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.GetData(p,obj);
	vtkDataArray result = new vtkDataArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkPoints::GetDataType()
// 
public int GetDataType() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.GetDataType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkPoints::SetDataType(int dataType)
// 
public void SetDataType(int dataType) {
	VTK.API_vtkPoints.SetDataType(obj, dataType);
}


//       Method: void vtkPoints::SetDataTypeToBit()
// 
public void SetDataTypeToBit() {
	VTK.API_vtkPoints.SetDataTypeToBit(obj);
}


//       Method: void vtkPoints::SetDataTypeToChar()
// 
public void SetDataTypeToChar() {
	VTK.API_vtkPoints.SetDataTypeToChar(obj);
}


//       Method: void vtkPoints::SetDataTypeToUnsignedChar()
// 
public void SetDataTypeToUnsignedChar() {
	VTK.API_vtkPoints.SetDataTypeToUnsignedChar(obj);
}


//       Method: void vtkPoints::SetDataTypeToShort()
// 
public void SetDataTypeToShort() {
	VTK.API_vtkPoints.SetDataTypeToShort(obj);
}


//       Method: void vtkPoints::SetDataTypeToUnsignedShort()
// 
public void SetDataTypeToUnsignedShort() {
	VTK.API_vtkPoints.SetDataTypeToUnsignedShort(obj);
}


//       Method: void vtkPoints::SetDataTypeToInt()
// 
public void SetDataTypeToInt() {
	VTK.API_vtkPoints.SetDataTypeToInt(obj);
}


//       Method: void vtkPoints::SetDataTypeToUnsignedInt()
// 
public void SetDataTypeToUnsignedInt() {
	VTK.API_vtkPoints.SetDataTypeToUnsignedInt(obj);
}


//       Method: void vtkPoints::SetDataTypeToLong()
// 
public void SetDataTypeToLong() {
	VTK.API_vtkPoints.SetDataTypeToLong(obj);
}


//       Method: void vtkPoints::SetDataTypeToUnsignedLong()
// 
public void SetDataTypeToUnsignedLong() {
	VTK.API_vtkPoints.SetDataTypeToUnsignedLong(obj);
}


//       Method: void vtkPoints::SetDataTypeToFloat()
// 
public void SetDataTypeToFloat() {
	VTK.API_vtkPoints.SetDataTypeToFloat(obj);
}


//       Method: void vtkPoints::SetDataTypeToDouble()
// 
public void SetDataTypeToDouble() {
	VTK.API_vtkPoints.SetDataTypeToDouble(obj);
}


//       Method: void * vtkPoints::GetVoidPointer(const int id)
// 
public IntPtr GetVoidPointer(int id) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.GetVoidPointer(p,obj, id);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkPoints::Squeeze()
// 
public void Squeeze() {
	VTK.API_vtkPoints.Squeeze(obj);
}


//       Method: virtual void vtkPoints::Reset()
// 
public void Reset() {
	VTK.API_vtkPoints.Reset(obj);
}


//       Method: virtual void vtkPoints::DeepCopy(vtkPoints* ad)
// 
public void DeepCopy(vtkPoints/*vtkPoints* */ ad) {
	VTK.API_vtkPoints.DeepCopy(obj, ad);
}


//       Method: virtual void vtkPoints::ShallowCopy(vtkPoints* ad)
// 
public void ShallowCopy(vtkPoints/*vtkPoints* */ ad) {
	VTK.API_vtkPoints.ShallowCopy(obj, ad);
}


//       Method: vtkIdType vtkPoints::GetNumberOfPoints()
// 
public long GetNumberOfPoints() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.GetNumberOfPoints(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double * vtkPoints::GetPoint(vtkIdType id)
// 
public double[] GetPoint(long id) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.GetPoint(p,obj, id);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPoints::GetPoint(vtkIdType id, double x[3])
// 
public void GetPoint(long id, double[] /*3*/ x) {
	VTK.API_vtkPoints.GetPoint(obj, id, x);
}


//       Method: void vtkPoints::SetPoint(vtkIdType id, const float x[3])
// 
public void SetPoint(long id, float[] /*3*/ x) {
	VTK.API_vtkPoints.SetPoint(obj, id, x);
}


//       Method: void vtkPoints::SetPoint(vtkIdType id, const double x[3])
// 
public void SetPoint(long id, double[] /*3*/ x) {
	VTK.API_vtkPoints.SetPoint(obj, id, x);
}


//       Method: void vtkPoints::SetPoint(vtkIdType id, double x, double y, double z)
// 
public void SetPoint(long id, double x, double y, double z) {
	VTK.API_vtkPoints.SetPoint(obj, id, x, y, z);
}


//       Method: void vtkPoints::InsertPoint(vtkIdType id, const float x[3])
// 
public void InsertPoint(long id, float[] /*3*/ x) {
	VTK.API_vtkPoints.InsertPoint(obj, id, x);
}


////  Constructor: vtkPoints::VTK_EXPECTS()
//// 
//public  VTK_EXPECTS() {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkPoints.VTK_EXPECTS(p,obj);
//	 result = new ();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}


//       Method: void vtkPoints::InsertPoint(vtkIdType id, const double x[3])
// 
public void InsertPoint(long id, double[] /*3*/ x) {
	VTK.API_vtkPoints.InsertPoint(obj, id, x);
}


////  Constructor: vtkPoints::VTK_EXPECTS()
//// 
//public  VTK_EXPECTS() {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkPoints.VTK_EXPECTS(p,obj);
//	 result = new ();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}


//       Method: void vtkPoints::InsertPoint(vtkIdType id, double x, double y, double z)
// 
public void InsertPoint(long id, double x, double y, double z) {
	VTK.API_vtkPoints.InsertPoint(obj, id, x, y, z);
}


////  Constructor: vtkPoints::VTK_EXPECTS()
//// 
//public  VTK_EXPECTS() {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkPoints.VTK_EXPECTS(p,obj);
//	 result = new ();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}


//       Method: void vtkPoints::InsertPoints(vtkIdList* dstIds, vtkIdList* srcIds, vtkPoints* source)
// 
public void InsertPoints(vtkIdList/*vtkIdList* */ dstIds, vtkIdList/*vtkIdList* */ srcIds, vtkPoints/*vtkPoints* */ source) {
	VTK.API_vtkPoints.InsertPoints(obj, dstIds, srcIds, source);
}


//       Method: void vtkPoints::InsertPoints(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkPoints* source)
// 
public void InsertPoints(long dstStart, long n, long srcStart, vtkPoints/*vtkPoints* */ source) {
	VTK.API_vtkPoints.InsertPoints(obj, dstStart, n, srcStart, source);
}


//       Method: vtkIdType vtkPoints::InsertNextPoint(const float x[3])
// 
public long InsertNextPoint(float[] /*3*/ x) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.InsertNextPoint(p,obj, x);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkPoints::InsertNextPoint(const double x[3])
// 
public long InsertNextPoint(double[] /*3*/ x) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.InsertNextPoint(p,obj, x);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkPoints::InsertNextPoint(double x, double y, double z)
// 
public long InsertNextPoint(double x, double y, double z) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.InsertNextPoint(p,obj, x, y, z);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPoints::SetNumberOfPoints(vtkIdType numPoints)
// 
public void SetNumberOfPoints(long numPoints) {
	VTK.API_vtkPoints.SetNumberOfPoints(obj, numPoints);
}


//       Method: int vtkPoints::Resize(vtkIdType numPoints)
// 
public int Resize(long numPoints) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.Resize(p,obj, numPoints);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPoints::GetPoints(vtkIdList* ptId, vtkPoints* fp)
// 
public void GetPoints(vtkIdList/*vtkIdList* */ ptId, vtkPoints/*vtkPoints* */ fp) {
	VTK.API_vtkPoints.GetPoints(obj, ptId, fp);
}


//       Method: virtual void vtkPoints::ComputeBounds()
// 
public void ComputeBounds() {
	VTK.API_vtkPoints.ComputeBounds(obj);
}


//       Method: double * vtkPoints::GetBounds()
// 
public double[] GetBounds() {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.GetBounds(p,obj);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPoints::GetBounds(double bounds[6])
// 
public void GetBounds(double[] /*6*/ bounds) {
	VTK.API_vtkPoints.GetBounds(obj, bounds);
}


//       Method: vtkMTimeType vtkPoints::GetMTime()
// 
public ulong GetMTime() {
	int numElements = 1;
	ulong example = new ulong();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPoints.GetMTime(p,obj);
	// UNSPECIFIED TYPE
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPoints::Modified()
// 
public void Modified() {
	VTK.API_vtkPoints.Modified(obj);
}


}
};
