
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkScalarsToColors : vtkObject {

//       Method: virtual const char * vtkScalarsToColors::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkScalarsToColors.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkScalarsToColors * vtkScalarsToColors::New()
// 
public static vtkScalarsToColors New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkScalarsToColors.New(p);
	vtkScalarsToColors result = new vtkScalarsToColors();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkScalarsToColors::IsOpaque()
// 
public int IsOpaque() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkScalarsToColors.IsOpaque(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkScalarsToColors::Build()
// 
public void Build() {
	VTK.API_vtkScalarsToColors.Build(obj);
}


//       Method: virtual double * vtkScalarsToColors::GetRange()
// 
public double[] GetRange() {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkScalarsToColors.GetRange(p,obj);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkScalarsToColors::SetRange(double min, double max)
// 
public void SetRange(double min, double max) {
	VTK.API_vtkScalarsToColors.SetRange(obj, min, max);
}


//       Method: virtual void vtkScalarsToColors::SetRange(const double rng[2])
// 
public void SetRange(double[] /*2*/ rng) {
	VTK.API_vtkScalarsToColors.SetRange(obj, rng);
}


//       Method: virtual void vtkScalarsToColors::GetColor(double v, double rgb[3])
// 
public void GetColor(double v, double[] /*3*/ rgb) {
	VTK.API_vtkScalarsToColors.GetColor(obj, v, rgb);
}


//       Method: double * vtkScalarsToColors::GetColor(double v)
// 
public double[] GetColor(double v) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkScalarsToColors.GetColor(p,obj, v);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual double vtkScalarsToColors::GetOpacity(double v)
// 
public double GetOpacity(double v) {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkScalarsToColors.GetOpacity(p,obj, v);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double vtkScalarsToColors::GetLuminance(double x)
// 
public double GetLuminance(double x) {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkScalarsToColors.GetLuminance(p,obj, x);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkScalarsToColors::SetAlpha(double alpha)
// 
public void SetAlpha(double alpha) {
	VTK.API_vtkScalarsToColors.SetAlpha(obj, alpha);
}


//       Method: virtual vtkUnsignedCharArray * vtkScalarsToColors::MapScalars(vtkDataArray* scalars, int colorMode, int component)
// 
public vtkUnsignedCharArray MapScalars(vtkDataArray/*vtkDataArray* */ scalars, int colorMode, int component) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkScalarsToColors.MapScalars(p,obj, scalars, colorMode, component);
	vtkUnsignedCharArray result = new vtkUnsignedCharArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkUnsignedCharArray * vtkScalarsToColors::MapScalars(vtkAbstractArray* scalars, int colorMode, int component)
// 
public vtkUnsignedCharArray MapScalars(vtkAbstractArray/*vtkAbstractArray* */ scalars, int colorMode, int component) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkScalarsToColors.MapScalars(p,obj, scalars, colorMode, component);
	vtkUnsignedCharArray result = new vtkUnsignedCharArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkScalarsToColors::SetVectorModeToMagnitude()
// 
public void SetVectorModeToMagnitude() {
	VTK.API_vtkScalarsToColors.SetVectorModeToMagnitude(obj);
}


//       Method: void vtkScalarsToColors::SetVectorModeToComponent()
// 
public void SetVectorModeToComponent() {
	VTK.API_vtkScalarsToColors.SetVectorModeToComponent(obj);
}


//       Method: void vtkScalarsToColors::SetVectorModeToRGBColors()
// 
public void SetVectorModeToRGBColors() {
	VTK.API_vtkScalarsToColors.SetVectorModeToRGBColors(obj);
}


//       Method: void vtkScalarsToColors::MapVectorsThroughTable(void* input, unsigned char* output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize)
// 
public void MapVectorsThroughTable(IntPtr/*void* */ input, byte/*unsigned char* */ output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize) {
	VTK.API_vtkScalarsToColors.MapVectorsThroughTable(obj, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat, vectorComponent, vectorSize);
}


//       Method: void vtkScalarsToColors::MapVectorsThroughTable(void* input, unsigned char* output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// 
public void MapVectorsThroughTable(IntPtr/*void* */ input, byte/*unsigned char* */ output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat) {
	VTK.API_vtkScalarsToColors.MapVectorsThroughTable(obj, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
}


//       Method: void vtkScalarsToColors::MapScalarsThroughTable(vtkDataArray* scalars, unsigned char* output, int outputFormat)
// 
public void MapScalarsThroughTable(vtkDataArray/*vtkDataArray* */ scalars, byte/*unsigned char* */ output, int outputFormat) {
	VTK.API_vtkScalarsToColors.MapScalarsThroughTable(obj, scalars, output, outputFormat);
}


//       Method: void vtkScalarsToColors::MapScalarsThroughTable(vtkDataArray* scalars, unsigned char* output)
// 
public void MapScalarsThroughTable(vtkDataArray/*vtkDataArray* */ scalars, byte/*unsigned char* */ output) {
	VTK.API_vtkScalarsToColors.MapScalarsThroughTable(obj, scalars, output);
}


//       Method: void vtkScalarsToColors::MapScalarsThroughTable(void* input, unsigned char* output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// 
public void MapScalarsThroughTable(IntPtr/*void* */ input, byte/*unsigned char* */ output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat) {
	VTK.API_vtkScalarsToColors.MapScalarsThroughTable(obj, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
}


//       Method: virtual void vtkScalarsToColors::MapScalarsThroughTable2(void* input, unsigned char* output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// 
public void MapScalarsThroughTable2(IntPtr/*void* */ input, byte/*unsigned char* */ output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat) {
	VTK.API_vtkScalarsToColors.MapScalarsThroughTable2(obj, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
}


//       Method: virtual void vtkScalarsToColors::DeepCopy(vtkScalarsToColors* o)
// 
public void DeepCopy(vtkScalarsToColors/*vtkScalarsToColors* */ o) {
	VTK.API_vtkScalarsToColors.DeepCopy(obj, o);
}


//       Method: virtual int vtkScalarsToColors::UsingLogScale()
// 
public int UsingLogScale() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkScalarsToColors.UsingLogScale(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkScalarsToColors::GetNumberOfAvailableColors()
// 
public long GetNumberOfAvailableColors() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkScalarsToColors.GetNumberOfAvailableColors(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkScalarsToColors::SetAnnotations(vtkAbstractArray* values, vtkStringArray* annotations)
// 
public void SetAnnotations(vtkAbstractArray/*vtkAbstractArray* */ values, vtkStringArray/*vtkStringArray* */ annotations) {
	VTK.API_vtkScalarsToColors.SetAnnotations(obj, values, annotations);
}


//       Method: vtkIdType vtkScalarsToColors::GetNumberOfAnnotatedValues()
// 
public long GetNumberOfAnnotatedValues() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkScalarsToColors.GetNumberOfAnnotatedValues(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkScalarsToColors::GetIndexedColor(vtkIdType i, double rgba[4])
// 
public void GetIndexedColor(long i, double[] /*4*/ rgba) {
	VTK.API_vtkScalarsToColors.GetIndexedColor(obj, i, rgba);
}


//       Method: virtual void vtkScalarsToColors::ResetAnnotations()
// 
public void ResetAnnotations() {
	VTK.API_vtkScalarsToColors.ResetAnnotations(obj);
}




}
};
