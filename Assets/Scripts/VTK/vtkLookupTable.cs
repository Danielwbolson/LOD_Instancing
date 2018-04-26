
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkLookupTable : vtkScalarsToColors {

//       Method: static vtkLookupTable * vtkLookupTable::New()
// 
public static vtkLookupTable New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkLookupTable.New(p);
	vtkLookupTable result = new vtkLookupTable();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkLookupTable::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkLookupTable.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkLookupTable::IsOpaque()
// 
public int IsOpaque() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkLookupTable.IsOpaque(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkLookupTable::Allocate(int sz, int ext)
// 
public int Allocate(int sz, int ext) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkLookupTable.Allocate(p,obj, sz, ext);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkLookupTable::Build()
// 
public void Build() {
	VTK.API_vtkLookupTable.Build(obj);
}


//       Method: virtual void vtkLookupTable::ForceBuild()
// 
public void ForceBuild() {
	VTK.API_vtkLookupTable.ForceBuild(obj);
}


//       Method: void vtkLookupTable::BuildSpecialColors()
// 
public void BuildSpecialColors() {
	VTK.API_vtkLookupTable.BuildSpecialColors(obj);
}


//       Method: void vtkLookupTable::SetRampToLinear()
// 
public void SetRampToLinear() {
	VTK.API_vtkLookupTable.SetRampToLinear(obj);
}


//       Method: void vtkLookupTable::SetRampToSCurve()
// 
public void SetRampToSCurve() {
	VTK.API_vtkLookupTable.SetRampToSCurve(obj);
}


//       Method: void vtkLookupTable::SetRampToSQRT()
// 
public void SetRampToSQRT() {
	VTK.API_vtkLookupTable.SetRampToSQRT(obj);
}


//       Method: void vtkLookupTable::SetScale(int scale)
// 
public void SetScale(int scale) {
	VTK.API_vtkLookupTable.SetScale(obj, scale);
}


//       Method: void vtkLookupTable::SetScaleToLinear()
// 
public void SetScaleToLinear() {
	VTK.API_vtkLookupTable.SetScaleToLinear(obj);
}


//       Method: void vtkLookupTable::SetScaleToLog10()
// 
public void SetScaleToLog10() {
	VTK.API_vtkLookupTable.SetScaleToLog10(obj);
}


//       Method: virtual void vtkLookupTable::SetTableRange(const double r[2])
// 
public void SetTableRange(double[] /*2*/ r) {
	VTK.API_vtkLookupTable.SetTableRange(obj, r);
}


//       Method: virtual void vtkLookupTable::SetTableRange(double min, double max)
// 
public void SetTableRange(double min, double max) {
	VTK.API_vtkLookupTable.SetTableRange(obj, min, max);
}


//       Method: static void vtkLookupTable::GetColorAsUnsignedChars(const double colorIn[4], unsigned char colorOut[4])
// 
public static void GetColorAsUnsignedChars(double[] /*4*/ colorIn, byte[] /*4*/ colorOut) {
	VTK.API_vtkLookupTable.GetColorAsUnsignedChars(colorIn, colorOut);
}


//       Method: void vtkLookupTable::GetColor(double x, double rgb[3])
// 
public void GetColor(double x, double[] /*3*/ rgb) {
	VTK.API_vtkLookupTable.GetColor(obj, x, rgb);
}


//       Method: double vtkLookupTable::GetOpacity(double v)
// 
public double GetOpacity(double v) {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkLookupTable.GetOpacity(p,obj, v);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkLookupTable::GetIndex(double v)
// 
public long GetIndex(double v) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkLookupTable.GetIndex(p,obj, v);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkLookupTable::SetNumberOfTableValues(vtkIdType number)
// 
public void SetNumberOfTableValues(long number) {
	VTK.API_vtkLookupTable.SetNumberOfTableValues(obj, number);
}


//       Method: vtkIdType vtkLookupTable::GetNumberOfTableValues()
// 
public long GetNumberOfTableValues() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkLookupTable.GetNumberOfTableValues(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkLookupTable::SetTableValue(vtkIdType indx, const double rgba[4])
// 
public void SetTableValue(long indx, double[] /*4*/ rgba) {
	VTK.API_vtkLookupTable.SetTableValue(obj, indx, rgba);
}


//       Method: virtual void vtkLookupTable::SetTableValue(vtkIdType indx, double r, double g, double b)
// 
public void SetTableValue(long indx, double r, double g, double b) {
	VTK.API_vtkLookupTable.SetTableValue(obj, indx, r, g, b);
}


//       Method: double * vtkLookupTable::GetTableValue(vtkIdType id)
// 
public double[] GetTableValue(long id) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkLookupTable.GetTableValue(p,obj, id);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkLookupTable::GetTableValue(vtkIdType id, double rgba[4])
// 
public void GetTableValue(long id, double[] /*4*/ rgba) {
	VTK.API_vtkLookupTable.GetTableValue(obj, id, rgba);
}


//       Method: double * vtkLookupTable::GetRange()
// 
public double[] GetRange() {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkLookupTable.GetRange(p,obj);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkLookupTable::SetRange(double min, double max)
// 
public void SetRange(double min, double max) {
	VTK.API_vtkLookupTable.SetRange(obj, min, max);
}


//       Method: void vtkLookupTable::SetRange(const double rng[2])
// 
public void SetRange(double[] /*2*/ rng) {
	VTK.API_vtkLookupTable.SetRange(obj, rng);
}


//       Method: static void vtkLookupTable::GetLogRange(const double range[2], double log_range[2])
// 
public static void GetLogRange(double[] /*2*/ range, double[] /*2*/ log_range) {
	VTK.API_vtkLookupTable.GetLogRange(range, log_range);
}


//       Method: static double vtkLookupTable::ApplyLogScale(double v, const double range[2], const double log_range[2])
// 
public static double ApplyLogScale(double v, double[] /*2*/ range, double[] /*2*/ log_range) {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkLookupTable.ApplyLogScale(p, v, range, log_range);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkLookupTable::MapScalarsThroughTable2(void* input, unsigned char* output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
// 
public void MapScalarsThroughTable2(IntPtr/*void* */ input, byte/*unsigned char* */ output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement) {
	VTK.API_vtkLookupTable.MapScalarsThroughTable2(obj, input, output, inputDataType, numberOfValues, inputIncrement, outputIncrement);
}


//       Method: void vtkLookupTable::DeepCopy(vtkScalarsToColors* lut)
// 
public void DeepCopy(vtkScalarsToColors/*vtkScalarsToColors* */ lut) {
	VTK.API_vtkLookupTable.DeepCopy(obj, lut);
}


//       Method: int vtkLookupTable::UsingLogScale()
// 
public int UsingLogScale() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkLookupTable.UsingLogScale(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkLookupTable::GetNumberOfAvailableColors()
// 
public long GetNumberOfAvailableColors() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkLookupTable.GetNumberOfAvailableColors(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkLookupTable::GetIndexedColor(vtkIdType idx, double rgba[4])
// 
public void GetIndexedColor(long idx, double[] /*4*/ rgba) {
	VTK.API_vtkLookupTable.GetIndexedColor(obj, idx, rgba);
}


}
};
