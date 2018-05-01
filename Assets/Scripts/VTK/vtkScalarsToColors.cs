

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkScalarsToColors : vtkObject {

// static vtkScalarsToColors* New()
// "static vtkScalarsToColors *New()"
public new static vtkScalarsToColors New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkScalarsToColors.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int IsOpaque()
// "virtual int IsOpaque()"
public new int IsOpaque() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkScalarsToColors.IsOpaque_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void Build()
// "virtual void Build()"
public new void Build() {
	API_vtkScalarsToColors.Build_0(this);
}


// virtual double* GetRange()
// "virtual double *GetRange()"
public new double GetRange() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkScalarsToColors.GetRange_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void SetRange(double min, double max)
// "virtual void SetRange(double min, double max)"
public new void SetRange(double /*(double)*/ min, double /*(double)*/ max) {
	API_vtkScalarsToColors.SetRange_0(this, min, max);
}


// virtual void SetRange(const double rng[2])
// "virtual void SetRange(const double rng[2])"
public new void SetRange(double /*(double[2])*/ []rng) {
	API_vtkScalarsToColors.SetRange_1(this, rng);
}


// virtual char* MapValue(double v)
// "virtual unsigned char *MapValue(double v)"
public new char MapValue(double /*(double)*/ v) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkScalarsToColors.MapValue_0(this, returnPointer, v);
	return Ptr.deref(returnPointer);
}


// virtual void GetColor(double v, double rgb[3])
// "virtual void GetColor(double v, double rgb[3])"
public new void GetColor(double /*(double)*/ v, double /*(double[3])*/ []rgb) {
	API_vtkScalarsToColors.GetColor_0(this, v, rgb);
}


// double* GetColor(double v)
// "double *GetColor(double v)"
public new double GetColor(double /*(double)*/ v) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkScalarsToColors.GetColor_1(this, returnPointer, v);
	return Ptr.deref(returnPointer);
}


// virtual double GetOpacity(double v)
// "virtual double GetOpacity(double v)"
public new double GetOpacity(double /*(double)*/ v) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkScalarsToColors.GetOpacity_0(this, returnPointer, v);
	return Ptr.deref(returnPointer);
}


// double GetLuminance(double x)
// "double GetLuminance(double x)"
public new double GetLuminance(double /*(double)*/ x) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkScalarsToColors.GetLuminance_0(this, returnPointer, x);
	return Ptr.deref(returnPointer);
}


// virtual void SetAlpha(double alpha)
// "virtual void SetAlpha(double alpha)"
public new void SetAlpha(double /*(double)*/ alpha) {
	API_vtkScalarsToColors.SetAlpha_0(this, alpha);
}


// virtual vtkUnsignedCharArray* MapScalars(vtkDataArray * scalars, int colorMode, int component)
// "virtual vtkUnsignedCharArray *MapScalars(vtkDataArray *scalars, int colorMode, int component)"
public new vtkUnsignedCharArray MapScalars(vtkDataArray /*(vtkDataArray*)*/ scalars, int /*(int)*/ colorMode, int /*(int)*/ component) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkScalarsToColors.MapScalars_0(this, returnPointer, scalars, colorMode, component);
	return Ptr.deref(returnPointer);
}


// virtual vtkUnsignedCharArray* MapScalars(vtkAbstractArray * scalars, int colorMode, int component)
// "virtual vtkUnsignedCharArray *MapScalars(vtkAbstractArray *scalars, int colorMode, int component)"
public new vtkUnsignedCharArray MapScalars(vtkAbstractArray /*(vtkAbstractArray*)*/ scalars, int /*(int)*/ colorMode, int /*(int)*/ component) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkScalarsToColors.MapScalars_1(this, returnPointer, scalars, colorMode, component);
	return Ptr.deref(returnPointer);
}


// void SetVectorModeToMagnitude()
// "void SetVectorModeToMagnitude()"
public new void SetVectorModeToMagnitude() {
	API_vtkScalarsToColors.SetVectorModeToMagnitude_0(this);
}


// void SetVectorModeToComponent()
// "void SetVectorModeToComponent()"
public new void SetVectorModeToComponent() {
	API_vtkScalarsToColors.SetVectorModeToComponent_0(this);
}


// void SetVectorModeToRGBColors()
// "void SetVectorModeToRGBColors()"
public new void SetVectorModeToRGBColors() {
	API_vtkScalarsToColors.SetVectorModeToRGBColors_0(this);
}


// void MapVectorsThroughTable(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize)
// "void MapVectorsThroughTable(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize)"
public new void MapVectorsThroughTable(IntPtr /*(void*)*/ []input, char /*(char*)*/ []output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat, int /*(int)*/ vectorComponent, int /*(int)*/ vectorSize) {
	API_vtkScalarsToColors.MapVectorsThroughTable_0(this, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat, vectorComponent, vectorSize);
}


// void MapVectorsThroughTable(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// "void MapVectorsThroughTable(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)"
public new void MapVectorsThroughTable(IntPtr /*(void*)*/ []input, char /*(char*)*/ []output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat) {
	API_vtkScalarsToColors.MapVectorsThroughTable_1(this, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
}


// void MapScalarsThroughTable(vtkDataArray * scalars, unsigned char * output, int outputFormat)
// "void MapScalarsThroughTable(vtkDataArray *scalars, unsigned char *output, int outputFormat)"
public new void MapScalarsThroughTable(vtkDataArray /*(vtkDataArray*)*/ scalars, char /*(char*)*/ []output, int /*(int)*/ outputFormat) {
	API_vtkScalarsToColors.MapScalarsThroughTable_0(this, scalars, output, outputFormat);
}


// void MapScalarsThroughTable(vtkDataArray * scalars, unsigned char * output)
// "void MapScalarsThroughTable(vtkDataArray *scalars, unsigned char *output)"
public new void MapScalarsThroughTable(vtkDataArray /*(vtkDataArray*)*/ scalars, char /*(char*)*/ []output) {
	API_vtkScalarsToColors.MapScalarsThroughTable_1(this, scalars, output);
}


// void MapScalarsThroughTable(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// "void MapScalarsThroughTable(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)"
public new void MapScalarsThroughTable(IntPtr /*(void*)*/ []input, char /*(char*)*/ []output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat) {
	API_vtkScalarsToColors.MapScalarsThroughTable_2(this, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
}


// virtual void MapScalarsThroughTable2(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// "virtual void MapScalarsThroughTable2(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)"
public new void MapScalarsThroughTable2(IntPtr /*(void*)*/ []input, char /*(char*)*/ []output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat) {
	API_vtkScalarsToColors.MapScalarsThroughTable2_0(this, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
}


// virtual void DeepCopy(vtkScalarsToColors * o)
// "virtual void DeepCopy(vtkScalarsToColors *o)"
public new void DeepCopy(vtkScalarsToColors /*(vtkScalarsToColors*)*/ o) {
	API_vtkScalarsToColors.DeepCopy_0(this, o);
}


// virtual int UsingLogScale()
// "virtual int UsingLogScale()"
public new int UsingLogScale() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkScalarsToColors.UsingLogScale_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType GetNumberOfAvailableColors()
// "virtual vtkIdType GetNumberOfAvailableColors()"
public new long GetNumberOfAvailableColors() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkScalarsToColors.GetNumberOfAvailableColors_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void SetAnnotations(vtkAbstractArray * values, vtkStringArray * annotations)
// "virtual void SetAnnotations( vtkAbstractArray* values, vtkStringArray* annotations )"
public new void SetAnnotations(vtkAbstractArray /*(vtkAbstractArray*)*/ values, vtkStringArray /*(vtkStringArray*)*/ annotations) {
	API_vtkScalarsToColors.SetAnnotations_0(this, values, annotations);
}


// virtual vtkIdType SetAnnotation(vtkStdString value, vtkStdString annotation)
// "virtual vtkIdType SetAnnotation(vtkStdString value, vtkStdString annotation)"
public new long SetAnnotation(string /*(vtkStdString)*/ value, string /*(vtkStdString)*/ annotation) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkScalarsToColors.SetAnnotation_0(this, returnPointer, value, annotation);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfAnnotatedValues()
// "vtkIdType GetNumberOfAnnotatedValues()"
public new long GetNumberOfAnnotatedValues() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkScalarsToColors.GetNumberOfAnnotatedValues_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkStdString GetAnnotation(vtkIdType idx)
// "vtkStdString GetAnnotation(vtkIdType idx)"
public new string GetAnnotation(long /*(vtkIdType)*/ idx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new string())*return_elements);
	API_vtkScalarsToColors.GetAnnotation_0(this, returnPointer, idx);
	return Ptr.deref(returnPointer);
}


// virtual void GetIndexedColor(vtkIdType i, double rgba[4])
// "virtual void GetIndexedColor(vtkIdType i, double rgba[4])"
public new void GetIndexedColor(long /*(vtkIdType)*/ i, double /*(double[4])*/ []rgba) {
	API_vtkScalarsToColors.GetIndexedColor_0(this, i, rgba);
}


// virtual void ResetAnnotations()
// "virtual void ResetAnnotations()"
public new void ResetAnnotations() {
	API_vtkScalarsToColors.ResetAnnotations_0(this);
}


}
};
