

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkScalarsToColors : vtkObject {
		public vtkScalarsToColors(IntPtr p) : base(p) {}
		public static implicit operator  vtkScalarsToColors(IntPtr p) {return new vtkScalarsToColors(p);}
		public static implicit operator  IntPtr(vtkScalarsToColors o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkScalarsToColors.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkScalarsToColors.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkScalarsToColors* SafeDownCast(vtkObjectBase * o)
// "static vtkScalarsToColors* SafeDownCast(vtkObjectBase *o)"
public static vtkScalarsToColors SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkScalarsToColors.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkScalarsToColors)(IntPtr)returnPointer;
}


// vtkScalarsToColors* NewInstance()
// "vtkScalarsToColors *NewInstance()"
public vtkScalarsToColors NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkScalarsToColors.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkScalarsToColors)(IntPtr)returnPointer;
}


// static vtkScalarsToColors* New()
// "static vtkScalarsToColors *New()"
public static vtkScalarsToColors New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkScalarsToColors.New_0(returnPointer.GetPtr());
	return (vtkScalarsToColors)(IntPtr)returnPointer;
}


// virtual int IsOpaque()
// "virtual int IsOpaque()"
public int IsOpaque() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkScalarsToColors.IsOpaque_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void Build()
// "virtual void Build()"
public void Build() {
	VTK_API.API_vtkScalarsToColors.Build_0(this);
}


// virtual double* GetRange()
// "virtual double *GetRange()"
public IntPtr GetRange() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkScalarsToColors.GetRange_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void SetRange(double min, double max)
// "virtual void SetRange(double min, double max)"
public void SetRange(double /*(double)*/ min, double /*(double)*/ max) {
	VTK_API.API_vtkScalarsToColors.SetRange_0(this, min, max);
}


// virtual void SetRange(const double rng[2])
// "virtual void SetRange(const double rng[2])"
public void SetRange(double /*(double[2])*/ []rng) {
	VTK_API.API_vtkScalarsToColors.SetRange_1(this, rng);
}


// virtual char* MapValue(double v)
// "virtual unsigned char *MapValue(double v)"
public string MapValue(double /*(double)*/ v) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkScalarsToColors.MapValue_0(returnPointer.GetPtr(), this, v);
	return (string)returnPointer;
}


// virtual void GetColor(double v, double rgb[3])
// "virtual void GetColor(double v, double rgb[3])"
public void GetColor(double /*(double)*/ v, double /*(double[3])*/ []rgb) {
	VTK_API.API_vtkScalarsToColors.GetColor_0(this, v, rgb);
}


// double* GetColor(double v)
// "double *GetColor(double v)"
public IntPtr GetColor(double /*(double)*/ v) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkScalarsToColors.GetColor_1(returnPointer.GetPtr(), this, v);
	return (IntPtr)returnPointer;
}


// virtual double GetOpacity(double v)
// "virtual double GetOpacity(double v)"
public double GetOpacity(double /*(double)*/ v) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkScalarsToColors.GetOpacity_0(returnPointer.GetPtr(), this, v);
	return (double)returnPointer;
}


// double GetLuminance(double x)
// "double GetLuminance(double x)"
public double GetLuminance(double /*(double)*/ x) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkScalarsToColors.GetLuminance_0(returnPointer.GetPtr(), this, x);
	return (double)returnPointer;
}


// virtual void SetAlpha(double alpha)
// "virtual void SetAlpha(double alpha)"
public void SetAlpha(double /*(double)*/ alpha) {
	VTK_API.API_vtkScalarsToColors.SetAlpha_0(this, alpha);
}


// virtual double GetAlpha()
// "virtual double GetAlpha ()"
public double GetAlpha() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkScalarsToColors.GetAlpha_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual vtkUnsignedCharArray* MapScalars(vtkDataArray * scalars, int colorMode, int component)
// "virtual vtkUnsignedCharArray *MapScalars(vtkDataArray *scalars, int colorMode, int component)"
public vtkUnsignedCharArray MapScalars(vtkDataArray /*(vtkDataArray*)*/ scalars, int /*(int)*/ colorMode, int /*(int)*/ component) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkScalarsToColors.MapScalars_0(returnPointer.GetPtr(), this, scalars, colorMode, component);
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// virtual vtkUnsignedCharArray* MapScalars(vtkAbstractArray * scalars, int colorMode, int component)
// "virtual vtkUnsignedCharArray *MapScalars(vtkAbstractArray *scalars, int colorMode, int component)"
public vtkUnsignedCharArray MapScalars(vtkAbstractArray /*(vtkAbstractArray*)*/ scalars, int /*(int)*/ colorMode, int /*(int)*/ component) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkScalarsToColors.MapScalars_1(returnPointer.GetPtr(), this, scalars, colorMode, component);
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// virtual void SetVectorMode(int _arg)
// "virtual void SetVectorMode (int _arg)"
public void SetVectorMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkScalarsToColors.SetVectorMode_0(this, _arg);
}


// virtual int GetVectorMode()
// "virtual int GetVectorMode ()"
public int GetVectorMode() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkScalarsToColors.GetVectorMode_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetVectorModeToMagnitude()
// "void SetVectorModeToMagnitude()"
public void SetVectorModeToMagnitude() {
	VTK_API.API_vtkScalarsToColors.SetVectorModeToMagnitude_0(this);
}


// void SetVectorModeToComponent()
// "void SetVectorModeToComponent()"
public void SetVectorModeToComponent() {
	VTK_API.API_vtkScalarsToColors.SetVectorModeToComponent_0(this);
}


// void SetVectorModeToRGBColors()
// "void SetVectorModeToRGBColors()"
public void SetVectorModeToRGBColors() {
	VTK_API.API_vtkScalarsToColors.SetVectorModeToRGBColors_0(this);
}


// virtual void SetVectorComponent(int _arg)
// "virtual void SetVectorComponent (int _arg)"
public void SetVectorComponent(int /*(int)*/ _arg) {
	VTK_API.API_vtkScalarsToColors.SetVectorComponent_0(this, _arg);
}


// virtual int GetVectorComponent()
// "virtual int GetVectorComponent ()"
public int GetVectorComponent() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkScalarsToColors.GetVectorComponent_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetVectorSize(int _arg)
// "virtual void SetVectorSize (int _arg)"
public void SetVectorSize(int /*(int)*/ _arg) {
	VTK_API.API_vtkScalarsToColors.SetVectorSize_0(this, _arg);
}


// virtual int GetVectorSize()
// "virtual int GetVectorSize ()"
public int GetVectorSize() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkScalarsToColors.GetVectorSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void MapVectorsThroughTable(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize)
// "void MapVectorsThroughTable(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize)"
public void MapVectorsThroughTable(IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat, int /*(int)*/ vectorComponent, int /*(int)*/ vectorSize) {
	VTK_API.API_vtkScalarsToColors.MapVectorsThroughTable_0(this, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat, vectorComponent, vectorSize);
}


// void MapVectorsThroughTable(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// "void MapVectorsThroughTable(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)"
public void MapVectorsThroughTable(IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat) {
	VTK_API.API_vtkScalarsToColors.MapVectorsThroughTable_1(this, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
}


// void MapScalarsThroughTable(vtkDataArray * scalars, unsigned char * output, int outputFormat)
// "void MapScalarsThroughTable(vtkDataArray *scalars, unsigned char *output, int outputFormat)"
public void MapScalarsThroughTable(vtkDataArray /*(vtkDataArray*)*/ scalars, string /*(unsigned char*)*/ output, int /*(int)*/ outputFormat) {
	VTK_API.API_vtkScalarsToColors.MapScalarsThroughTable_0(this, scalars, output, outputFormat);
}


// void MapScalarsThroughTable(vtkDataArray * scalars, unsigned char * output)
// "void MapScalarsThroughTable(vtkDataArray *scalars, unsigned char *output)"
public void MapScalarsThroughTable(vtkDataArray /*(vtkDataArray*)*/ scalars, string /*(unsigned char*)*/ output) {
	VTK_API.API_vtkScalarsToColors.MapScalarsThroughTable_1(this, scalars, output);
}


// void MapScalarsThroughTable(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// "void MapScalarsThroughTable(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)"
public void MapScalarsThroughTable(IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat) {
	VTK_API.API_vtkScalarsToColors.MapScalarsThroughTable_2(this, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
}


// virtual void MapScalarsThroughTable2(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// "virtual void MapScalarsThroughTable2(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)"
public void MapScalarsThroughTable2(IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat) {
	VTK_API.API_vtkScalarsToColors.MapScalarsThroughTable2_0(this, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
}


// virtual void DeepCopy(vtkScalarsToColors * o)
// "virtual void DeepCopy(vtkScalarsToColors *o)"
public void DeepCopy(vtkScalarsToColors /*(vtkScalarsToColors*)*/ o) {
	VTK_API.API_vtkScalarsToColors.DeepCopy_0(this, o);
}


// virtual int UsingLogScale()
// "virtual int UsingLogScale()"
public int UsingLogScale() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkScalarsToColors.UsingLogScale_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual vtkIdType GetNumberOfAvailableColors()
// "virtual vtkIdType GetNumberOfAvailableColors()"
public long GetNumberOfAvailableColors() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkScalarsToColors.GetNumberOfAvailableColors_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual void SetAnnotations(vtkAbstractArray * values, vtkStringArray * annotations)
// "virtual void SetAnnotations( vtkAbstractArray* values, vtkStringArray* annotations )"
public void SetAnnotations(vtkAbstractArray /*(vtkAbstractArray*)*/ values, vtkStringArray /*(vtkStringArray*)*/ annotations) {
	VTK_API.API_vtkScalarsToColors.SetAnnotations_0(this, values, annotations);
}


// virtual vtkAbstractArray* GetAnnotatedValues()
// "virtual vtkAbstractArray *GetAnnotatedValues ()"
public vtkAbstractArray GetAnnotatedValues() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkScalarsToColors.GetAnnotatedValues_0(returnPointer.GetPtr(), this);
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// virtual vtkStringArray* GetAnnotations()
// "virtual vtkStringArray *GetAnnotations ()"
public vtkStringArray GetAnnotations() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkScalarsToColors.GetAnnotations_0(returnPointer.GetPtr(), this);
	return (vtkStringArray)(IntPtr)returnPointer;
}


// virtual vtkIdType SetAnnotation(vtkStdString value, vtkStdString annotation)
// "virtual vtkIdType SetAnnotation(vtkStdString value, vtkStdString annotation)"
public long SetAnnotation(string /*(vtkStdString)*/ value, string /*(vtkStdString)*/ annotation) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkScalarsToColors.SetAnnotation_0(returnPointer.GetPtr(), this, value, annotation);
	return (long)returnPointer;
}


// vtkIdType GetNumberOfAnnotatedValues()
// "vtkIdType GetNumberOfAnnotatedValues()"
public long GetNumberOfAnnotatedValues() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkScalarsToColors.GetNumberOfAnnotatedValues_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkStdString GetAnnotation(vtkIdType idx)
// "vtkStdString GetAnnotation(vtkIdType idx)"
public string GetAnnotation(long /*(vtkIdType)*/ idx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkScalarsToColors.GetAnnotation_0(returnPointer.GetPtr(), this, idx);
	return (string)returnPointer;
}


// virtual void GetIndexedColor(vtkIdType i, double rgba[4])
// "virtual void GetIndexedColor(vtkIdType i, double rgba[4])"
public void GetIndexedColor(long /*(vtkIdType)*/ i, double /*(double[4])*/ []rgba) {
	VTK_API.API_vtkScalarsToColors.GetIndexedColor_0(this, i, rgba);
}


// virtual void ResetAnnotations()
// "virtual void ResetAnnotations()"
public void ResetAnnotations() {
	VTK_API.API_vtkScalarsToColors.ResetAnnotations_0(this);
}


// virtual void SetIndexedLookup(int _arg)
// "virtual void SetIndexedLookup (int _arg)"
public void SetIndexedLookup(int /*(int)*/ _arg) {
	VTK_API.API_vtkScalarsToColors.SetIndexedLookup_0(this, _arg);
}


// virtual int GetIndexedLookup()
// "virtual int GetIndexedLookup ()"
public int GetIndexedLookup() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkScalarsToColors.GetIndexedLookup_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void IndexedLookupOn()
// "virtual void IndexedLookupOn ()"
public void IndexedLookupOn() {
	VTK_API.API_vtkScalarsToColors.IndexedLookupOn_0(this);
}


// virtual void IndexedLookupOff()
// "virtual void IndexedLookupOff ()"
public void IndexedLookupOff() {
	VTK_API.API_vtkScalarsToColors.IndexedLookupOff_0(this);
}


}
};
