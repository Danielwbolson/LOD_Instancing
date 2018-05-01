

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkLookupTable : vtkScalarsToColors {

// static vtkLookupTable* New()
// "static vtkLookupTable *New()"
public new static vtkLookupTable New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkLookupTable.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// int IsOpaque()
// "int IsOpaque()"
public new int IsOpaque() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkLookupTable.IsOpaque_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int Allocate(int sz = 256, int ext = 256)
// "int Allocate(int sz=256, int ext=256)"
public new int Allocate(int /*(int)*/ sz, int /*(int)*/ ext) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkLookupTable.Allocate_0(this, returnPointer, sz, ext);
	return Ptr.deref(returnPointer);
}


// void Build()
// "void Build()"
public new void Build() {
	API_vtkLookupTable.Build_0(this);
}


// virtual void ForceBuild()
// "virtual void ForceBuild()"
public new void ForceBuild() {
	API_vtkLookupTable.ForceBuild_0(this);
}


// void BuildSpecialColors()
// "void BuildSpecialColors()"
public new void BuildSpecialColors() {
	API_vtkLookupTable.BuildSpecialColors_0(this);
}


// void SetRampToLinear()
// "void SetRampToLinear()"
public new void SetRampToLinear() {
	API_vtkLookupTable.SetRampToLinear_0(this);
}


// void SetRampToSCurve()
// "void SetRampToSCurve()"
public new void SetRampToSCurve() {
	API_vtkLookupTable.SetRampToSCurve_0(this);
}


// void SetRampToSQRT()
// "void SetRampToSQRT()"
public new void SetRampToSQRT() {
	API_vtkLookupTable.SetRampToSQRT_0(this);
}


// void SetScale(int scale)
// "void SetScale(int scale)"
public new void SetScale(int /*(int)*/ scale) {
	API_vtkLookupTable.SetScale_0(this, scale);
}


// void SetScaleToLinear()
// "void SetScaleToLinear()"
public new void SetScaleToLinear() {
	API_vtkLookupTable.SetScaleToLinear_0(this);
}


// void SetScaleToLog10()
// "void SetScaleToLog10()"
public new void SetScaleToLog10() {
	API_vtkLookupTable.SetScaleToLog10_0(this);
}


// virtual void SetTableRange(const double r[2])
// "virtual void SetTableRange(const double r[2])"
public new void SetTableRange(double /*(double[2])*/ []r) {
	API_vtkLookupTable.SetTableRange_0(this, r);
}


// virtual void SetTableRange(double min, double max)
// "virtual void SetTableRange(double min, double max)"
public new void SetTableRange(double /*(double)*/ min, double /*(double)*/ max) {
	API_vtkLookupTable.SetTableRange_1(this, min, max);
}


// char* GetNanColorAsUnsignedChars()
// "unsigned char* GetNanColorAsUnsignedChars()"
public new char GetNanColorAsUnsignedChars() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkLookupTable.GetNanColorAsUnsignedChars_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// static void GetColorAsUnsignedChars(const double colorIn[4], unsigned char colorOut[4])
// "static void GetColorAsUnsignedChars(const double colorIn[4], unsigned char colorOut[4])"
public new static void GetColorAsUnsignedChars(double /*(double[4])*/ []colorIn, char /*(char[4])*/ []colorOut) {
	API_vtkLookupTable.GetColorAsUnsignedChars_0(colorIn, colorOut);
}


// char* MapValue(double v)
// "unsigned char* MapValue(double v)"
public new char MapValue(double /*(double)*/ v) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkLookupTable.MapValue_0(this, returnPointer, v);
	return Ptr.deref(returnPointer);
}


// void GetColor(double x, double rgb[3])
// "void GetColor(double x, double rgb[3])"
public new void GetColor(double /*(double)*/ x, double /*(double[3])*/ []rgb) {
	API_vtkLookupTable.GetColor_0(this, x, rgb);
}


// double GetOpacity(double v)
// "double GetOpacity(double v)"
public new double GetOpacity(double /*(double)*/ v) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkLookupTable.GetOpacity_0(this, returnPointer, v);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType GetIndex(double v)
// "virtual vtkIdType GetIndex(double v)"
public new long GetIndex(double /*(double)*/ v) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkLookupTable.GetIndex_0(this, returnPointer, v);
	return Ptr.deref(returnPointer);
}


// void SetNumberOfTableValues(vtkIdType number)
// "void SetNumberOfTableValues(vtkIdType number)"
public new void SetNumberOfTableValues(long /*(vtkIdType)*/ number) {
	API_vtkLookupTable.SetNumberOfTableValues_0(this, number);
}


// vtkIdType GetNumberOfTableValues()
// "vtkIdType GetNumberOfTableValues()"
public new long GetNumberOfTableValues() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkLookupTable.GetNumberOfTableValues_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void SetTableValue(vtkIdType indx, const double rgba[4])
// "virtual void SetTableValue(vtkIdType indx, const double rgba[4])"
public new void SetTableValue(long /*(vtkIdType)*/ indx, double /*(double[4])*/ []rgba) {
	API_vtkLookupTable.SetTableValue_0(this, indx, rgba);
}


// double* GetTableValue(vtkIdType id)
// "double *GetTableValue(vtkIdType id)"
public new double GetTableValue(long /*(vtkIdType)*/ id) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkLookupTable.GetTableValue_0(this, returnPointer, id);
	return Ptr.deref(returnPointer);
}


// void GetTableValue(vtkIdType id, double rgba[4])
// "void GetTableValue(vtkIdType id, double rgba[4])"
public new void GetTableValue(long /*(vtkIdType)*/ id, double /*(double[4])*/ []rgba) {
	API_vtkLookupTable.GetTableValue_1(this, id, rgba);
}


// char* GetPointer(vtkIdType id)
// "unsigned char *GetPointer(vtkIdType id)"
public new char GetPointer(long /*(vtkIdType)*/ id) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkLookupTable.GetPointer_0(this, returnPointer, id);
	return Ptr.deref(returnPointer);
}


// char* WritePointer(vtkIdType id, int number)
// "unsigned char *WritePointer(vtkIdType id, int number)"
public new char WritePointer(long /*(vtkIdType)*/ id, int /*(int)*/ number) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkLookupTable.WritePointer_0(this, returnPointer, id, number);
	return Ptr.deref(returnPointer);
}


// double* GetRange()
// "double *GetRange()"
public new double GetRange() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkLookupTable.GetRange_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetRange(double min, double max)
// "void SetRange(double min, double max)"
public new void SetRange(double /*(double)*/ min, double /*(double)*/ max) {
	API_vtkLookupTable.SetRange_0(this, min, max);
}


// void SetRange(const double rng[2])
// "void SetRange(const double rng[2])"
public new void SetRange(double /*(double[2])*/ []rng) {
	API_vtkLookupTable.SetRange_1(this, rng);
}


// static void GetLogRange(const double range[2], double log_range[2])
// "static void GetLogRange(const double range[2], double log_range[2])"
public new static void GetLogRange(double /*(double[2])*/ []range, double /*(double[2])*/ []log_range) {
	API_vtkLookupTable.GetLogRange_0(range, log_range);
}


// static double ApplyLogScale(double v, const double range[2], const double log_range[2])
// "static double ApplyLogScale(double v, const double range[2], const double log_range[2])"
public new static double ApplyLogScale(double /*(double)*/ v, double /*(double[2])*/ []range, double /*(double[2])*/ []log_range) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkLookupTable.ApplyLogScale_0(returnPointer, v, range, log_range);
	return Ptr.deref(returnPointer);
}


// void SetTable(vtkUnsignedCharArray * ARG_0)
// "void SetTable(vtkUnsignedCharArray *)"
public new void SetTable(vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ ARG_0) {
	API_vtkLookupTable.SetTable_0(this, ARG_0);
}


// void MapScalarsThroughTable2(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
// "void MapScalarsThroughTable2(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)"
public new void MapScalarsThroughTable2(IntPtr /*(void*)*/ []input, char /*(char*)*/ []output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputIncrement) {
	API_vtkLookupTable.MapScalarsThroughTable2_0(this, input, output, inputDataType, numberOfValues, inputIncrement, outputIncrement);
}


// void DeepCopy(vtkScalarsToColors * lut)
// "void DeepCopy(vtkScalarsToColors *lut)"
public new void DeepCopy(vtkScalarsToColors /*(vtkScalarsToColors*)*/ lut) {
	API_vtkLookupTable.DeepCopy_0(this, lut);
}


// int UsingLogScale()
// "int UsingLogScale()"
public new int UsingLogScale() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkLookupTable.UsingLogScale_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfAvailableColors()
// "vtkIdType GetNumberOfAvailableColors()"
public new long GetNumberOfAvailableColors() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkLookupTable.GetNumberOfAvailableColors_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void GetIndexedColor(vtkIdType idx, double rgba[4])
// "void GetIndexedColor(vtkIdType idx, double rgba[4])"
public new void GetIndexedColor(long /*(vtkIdType)*/ idx, double /*(double[4])*/ []rgba) {
	API_vtkLookupTable.GetIndexedColor_0(this, idx, rgba);
}


}
};
