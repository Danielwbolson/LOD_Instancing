

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkLookupTable : vtkScalarsToColors {
		public vtkLookupTable(IntPtr p) : base(p) {}
		public static implicit operator  vtkLookupTable(IntPtr p) {return new vtkLookupTable(p);}
		public static implicit operator  IntPtr(vtkLookupTable o) {return o.GetPtr();}

// static vtkLookupTable* New()
// "static vtkLookupTable *New()"
public static vtkLookupTable New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkLookupTable.New_0(returnPointer.GetPtr());
	return (vtkLookupTable)(IntPtr)returnPointer;
}


// int IsOpaque()
// "int IsOpaque()"
public int IsOpaque() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkLookupTable.IsOpaque_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int Allocate(int sz = 256, int ext = 256)
// "int Allocate(int sz=256, int ext=256)"
public int Allocate(int /*(int)*/ sz, int /*(int)*/ ext) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkLookupTable.Allocate_0(returnPointer.GetPtr(), this, sz, ext);
	return (int)returnPointer;
}


// void Build()
// "void Build()"
public void Build() {
	API_vtkLookupTable.Build_0(this);
}


// virtual void ForceBuild()
// "virtual void ForceBuild()"
public void ForceBuild() {
	API_vtkLookupTable.ForceBuild_0(this);
}


// void BuildSpecialColors()
// "void BuildSpecialColors()"
public void BuildSpecialColors() {
	API_vtkLookupTable.BuildSpecialColors_0(this);
}


// void SetRampToLinear()
// "void SetRampToLinear()"
public void SetRampToLinear() {
	API_vtkLookupTable.SetRampToLinear_0(this);
}


// void SetRampToSCurve()
// "void SetRampToSCurve()"
public void SetRampToSCurve() {
	API_vtkLookupTable.SetRampToSCurve_0(this);
}


// void SetRampToSQRT()
// "void SetRampToSQRT()"
public void SetRampToSQRT() {
	API_vtkLookupTable.SetRampToSQRT_0(this);
}


// void SetScale(int scale)
// "void SetScale(int scale)"
public void SetScale(int /*(int)*/ scale) {
	API_vtkLookupTable.SetScale_0(this, scale);
}


// void SetScaleToLinear()
// "void SetScaleToLinear()"
public void SetScaleToLinear() {
	API_vtkLookupTable.SetScaleToLinear_0(this);
}


// void SetScaleToLog10()
// "void SetScaleToLog10()"
public void SetScaleToLog10() {
	API_vtkLookupTable.SetScaleToLog10_0(this);
}


// virtual void SetTableRange(const double r[2])
// "virtual void SetTableRange(const double r[2])"
public void SetTableRange(double /*(double[2])*/ []r) {
	API_vtkLookupTable.SetTableRange_0(this, r);
}


// virtual void SetTableRange(double min, double max)
// "virtual void SetTableRange(double min, double max)"
public void SetTableRange(double /*(double)*/ min, double /*(double)*/ max) {
	API_vtkLookupTable.SetTableRange_1(this, min, max);
}


// char* GetNanColorAsUnsignedChars()
// "unsigned char* GetNanColorAsUnsignedChars()"
public string GetNanColorAsUnsignedChars() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkLookupTable.GetNanColorAsUnsignedChars_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// static void GetColorAsUnsignedChars(const double colorIn[4], unsigned char colorOut[4])
// "static void GetColorAsUnsignedChars(const double colorIn[4], unsigned char colorOut[4])"
public static void GetColorAsUnsignedChars(double /*(double[4])*/ []colorIn, char /*(unsigned char[4])*/ []colorOut) {
	API_vtkLookupTable.GetColorAsUnsignedChars_0(colorIn, colorOut);
}


// char* MapValue(double v)
// "unsigned char* MapValue(double v)"
public string MapValue(double /*(double)*/ v) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkLookupTable.MapValue_0(returnPointer.GetPtr(), this, v);
	return (string)returnPointer;
}


// void GetColor(double x, double rgb[3])
// "void GetColor(double x, double rgb[3])"
public void GetColor(double /*(double)*/ x, double /*(double[3])*/ []rgb) {
	API_vtkLookupTable.GetColor_0(this, x, rgb);
}


// double GetOpacity(double v)
// "double GetOpacity(double v)"
public double GetOpacity(double /*(double)*/ v) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new double(), return_elements);
	API_vtkLookupTable.GetOpacity_0(returnPointer.GetPtr(), this, v);
	return (double)returnPointer;
}


// virtual vtkIdType GetIndex(double v)
// "virtual vtkIdType GetIndex(double v)"
public long GetIndex(double /*(double)*/ v) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkLookupTable.GetIndex_0(returnPointer.GetPtr(), this, v);
	return (long)returnPointer;
}


// void SetNumberOfTableValues(vtkIdType number)
// "void SetNumberOfTableValues(vtkIdType number)"
public void SetNumberOfTableValues(long /*(vtkIdType)*/ number) {
	API_vtkLookupTable.SetNumberOfTableValues_0(this, number);
}


// vtkIdType GetNumberOfTableValues()
// "vtkIdType GetNumberOfTableValues()"
public long GetNumberOfTableValues() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkLookupTable.GetNumberOfTableValues_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual void SetTableValue(vtkIdType indx, const double rgba[4])
// "virtual void SetTableValue(vtkIdType indx, const double rgba[4])"
public void SetTableValue(long /*(vtkIdType)*/ indx, double /*(double[4])*/ []rgba) {
	API_vtkLookupTable.SetTableValue_0(this, indx, rgba);
}


// double* GetTableValue(vtkIdType id)
// "double *GetTableValue(vtkIdType id)"
public IntPtr GetTableValue(long /*(vtkIdType)*/ id) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkLookupTable.GetTableValue_0(returnPointer.GetPtr(), this, id);
	return (IntPtr)returnPointer;
}


// void GetTableValue(vtkIdType id, double rgba[4])
// "void GetTableValue(vtkIdType id, double rgba[4])"
public void GetTableValue(long /*(vtkIdType)*/ id, double /*(double[4])*/ []rgba) {
	API_vtkLookupTable.GetTableValue_1(this, id, rgba);
}


// char* GetPointer(vtkIdType id)
// "unsigned char *GetPointer(vtkIdType id)"
public string GetPointer(long /*(vtkIdType)*/ id) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkLookupTable.GetPointer_0(returnPointer.GetPtr(), this, id);
	return (string)returnPointer;
}


// char* WritePointer(vtkIdType id, int number)
// "unsigned char *WritePointer(vtkIdType id, int number)"
public string WritePointer(long /*(vtkIdType)*/ id, int /*(int)*/ number) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkLookupTable.WritePointer_0(returnPointer.GetPtr(), this, id, number);
	return (string)returnPointer;
}


// double* GetRange()
// "double *GetRange()"
public IntPtr GetRange() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkLookupTable.GetRange_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void SetRange(double min, double max)
// "void SetRange(double min, double max)"
public void SetRange(double /*(double)*/ min, double /*(double)*/ max) {
	API_vtkLookupTable.SetRange_0(this, min, max);
}


// void SetRange(const double rng[2])
// "void SetRange(const double rng[2])"
public void SetRange(double /*(double[2])*/ []rng) {
	API_vtkLookupTable.SetRange_1(this, rng);
}


// static void GetLogRange(const double range[2], double log_range[2])
// "static void GetLogRange(const double range[2], double log_range[2])"
public static void GetLogRange(double /*(double[2])*/ []range, double /*(double[2])*/ []log_range) {
	API_vtkLookupTable.GetLogRange_0(range, log_range);
}


// static double ApplyLogScale(double v, const double range[2], const double log_range[2])
// "static double ApplyLogScale(double v, const double range[2], const double log_range[2])"
public static double ApplyLogScale(double /*(double)*/ v, double /*(double[2])*/ []range, double /*(double[2])*/ []log_range) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new double(), return_elements);
	API_vtkLookupTable.ApplyLogScale_0(returnPointer.GetPtr(), v, range, log_range);
	return (double)returnPointer;
}


// void SetTable(vtkUnsignedCharArray * ARG_0)
// "void SetTable(vtkUnsignedCharArray *)"
public void SetTable(vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ ARG_0) {
	API_vtkLookupTable.SetTable_0(this, ARG_0);
}


// void MapScalarsThroughTable2(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
// "void MapScalarsThroughTable2(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)"
public void MapScalarsThroughTable2(IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputIncrement) {
	API_vtkLookupTable.MapScalarsThroughTable2_0(this, input, output, inputDataType, numberOfValues, inputIncrement, outputIncrement);
}


// void DeepCopy(vtkScalarsToColors * lut)
// "void DeepCopy(vtkScalarsToColors *lut)"
public void DeepCopy(vtkScalarsToColors /*(vtkScalarsToColors*)*/ lut) {
	API_vtkLookupTable.DeepCopy_0(this, lut);
}


// int UsingLogScale()
// "int UsingLogScale()"
public int UsingLogScale() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkLookupTable.UsingLogScale_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkIdType GetNumberOfAvailableColors()
// "vtkIdType GetNumberOfAvailableColors()"
public long GetNumberOfAvailableColors() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkLookupTable.GetNumberOfAvailableColors_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void GetIndexedColor(vtkIdType idx, double rgba[4])
// "void GetIndexedColor(vtkIdType idx, double rgba[4])"
public void GetIndexedColor(long /*(vtkIdType)*/ idx, double /*(double[4])*/ []rgba) {
	API_vtkLookupTable.GetIndexedColor_0(this, idx, rgba);
}


}
};
