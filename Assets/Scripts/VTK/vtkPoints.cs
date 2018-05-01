

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPoints : vtkObject {

// static vtkPoints* New(int dataType)
// "static vtkPoints *New(int dataType)"
public new static vtkPoints New(int /*(int)*/ dataType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkPoints.New_0(returnPointer, dataType);
	return Ptr.deref(returnPointer);
}


// static vtkPoints* New()
// "static vtkPoints *New()"
public new static vtkPoints New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkPoints.New_1(returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int Allocate(vtkIdType sz, vtkIdType ext = 1000)
// "virtual int Allocate(vtkIdType sz, vtkIdType ext = 1000)"
public new int Allocate(long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPoints.Allocate_0(this, returnPointer, sz, ext);
	return Ptr.deref(returnPointer);
}


// virtual void Initialize()
// "virtual void Initialize()"
public new void Initialize() {
	API_vtkPoints.Initialize_0(this);
}


// virtual void SetData(vtkDataArray * ARG_0)
// "virtual void SetData(vtkDataArray *)"
public new void SetData(vtkDataArray /*(vtkDataArray*)*/ ARG_0) {
	API_vtkPoints.SetData_0(this, ARG_0);
}


// vtkDataArray* GetData()
// "vtkDataArray *GetData()"
public new vtkDataArray GetData() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkPoints.GetData_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int GetDataType()
// "virtual int GetDataType()"
public new int GetDataType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPoints.GetDataType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void SetDataType(int dataType)
// "virtual void SetDataType(int dataType)"
public new void SetDataType(int /*(int)*/ dataType) {
	API_vtkPoints.SetDataType_0(this, dataType);
}


// void SetDataTypeToBit()
// "void SetDataTypeToBit()"
public new void SetDataTypeToBit() {
	API_vtkPoints.SetDataTypeToBit_0(this);
}


// void SetDataTypeToChar()
// "void SetDataTypeToChar()"
public new void SetDataTypeToChar() {
	API_vtkPoints.SetDataTypeToChar_0(this);
}


// void SetDataTypeToUnsignedChar()
// "void SetDataTypeToUnsignedChar()"
public new void SetDataTypeToUnsignedChar() {
	API_vtkPoints.SetDataTypeToUnsignedChar_0(this);
}


// void SetDataTypeToShort()
// "void SetDataTypeToShort()"
public new void SetDataTypeToShort() {
	API_vtkPoints.SetDataTypeToShort_0(this);
}


// void SetDataTypeToUnsignedShort()
// "void SetDataTypeToUnsignedShort()"
public new void SetDataTypeToUnsignedShort() {
	API_vtkPoints.SetDataTypeToUnsignedShort_0(this);
}


// void SetDataTypeToInt()
// "void SetDataTypeToInt()"
public new void SetDataTypeToInt() {
	API_vtkPoints.SetDataTypeToInt_0(this);
}


// void SetDataTypeToUnsignedInt()
// "void SetDataTypeToUnsignedInt()"
public new void SetDataTypeToUnsignedInt() {
	API_vtkPoints.SetDataTypeToUnsignedInt_0(this);
}


// void SetDataTypeToLong()
// "void SetDataTypeToLong()"
public new void SetDataTypeToLong() {
	API_vtkPoints.SetDataTypeToLong_0(this);
}


// void SetDataTypeToUnsignedLong()
// "void SetDataTypeToUnsignedLong()"
public new void SetDataTypeToUnsignedLong() {
	API_vtkPoints.SetDataTypeToUnsignedLong_0(this);
}


// void SetDataTypeToFloat()
// "void SetDataTypeToFloat()"
public new void SetDataTypeToFloat() {
	API_vtkPoints.SetDataTypeToFloat_0(this);
}


// void SetDataTypeToDouble()
// "void SetDataTypeToDouble()"
public new void SetDataTypeToDouble() {
	API_vtkPoints.SetDataTypeToDouble_0(this);
}


// void* GetVoidPointer(const int id)
// "void *GetVoidPointer(const int id)"
public new IntPtr GetVoidPointer(int /*(int)*/ id) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkPoints.GetVoidPointer_0(this, returnPointer, id);
	return Ptr.deref(returnPointer);
}


// virtual void Squeeze()
// "virtual void Squeeze()"
public new void Squeeze() {
	API_vtkPoints.Squeeze_0(this);
}


// virtual void Reset()
// "virtual void Reset()"
public new void Reset() {
	API_vtkPoints.Reset_0(this);
}


// virtual void DeepCopy(vtkPoints * ad)
// "virtual void DeepCopy(vtkPoints *ad)"
public new void DeepCopy(vtkPoints /*(vtkPoints*)*/ ad) {
	API_vtkPoints.DeepCopy_0(this, ad);
}


// virtual void ShallowCopy(vtkPoints * ad)
// "virtual void ShallowCopy(vtkPoints *ad)"
public new void ShallowCopy(vtkPoints /*(vtkPoints*)*/ ad) {
	API_vtkPoints.ShallowCopy_0(this, ad);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public new ulong GetActualMemorySize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkPoints.GetActualMemorySize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public new long GetNumberOfPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPoints.GetNumberOfPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// double* GetPoint(vtkIdType id)
// "double *GetPoint(vtkIdType id)"
public new double GetPoint(long /*(vtkIdType)*/ id) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkPoints.GetPoint_0(this, returnPointer, id);
	return Ptr.deref(returnPointer);
}


// void GetPoint(vtkIdType id, double x[3])
// "void GetPoint(vtkIdType id, double x[3])"
public new void GetPoint(long /*(vtkIdType)*/ id, double /*(double[3])*/ []x) {
	API_vtkPoints.GetPoint_1(this, id, x);
}


// void SetPoint(vtkIdType id, const float x[3])
// "void SetPoint(vtkIdType id, const float x[3])"
public new void SetPoint(long /*(vtkIdType)*/ id, float /*(float[3])*/ []x) {
	API_vtkPoints.SetPoint_0(this, id, x);
}


// void SetPoint(vtkIdType id, const double x[3])
// "void SetPoint(vtkIdType id, const double x[3])"
public new void SetPoint(long /*(vtkIdType)*/ id, double /*(double[3])*/ []x) {
	API_vtkPoints.SetPoint_1(this, id, x);
}


// void SetPoint(vtkIdType id, double x, double y, double z)
// "void SetPoint(vtkIdType id, double x, double y, double z)"
public new void SetPoint(long /*(vtkIdType)*/ id, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	API_vtkPoints.SetPoint_2(this, id, x, y, z);
}


// void InsertPoint(vtkIdType id, const float x[3])
// "void InsertPoint(vtkIdType id, const float x[3])"
public new void InsertPoint(long /*(vtkIdType)*/ id, float /*(float[3])*/ []x) {
	API_vtkPoints.InsertPoint_0(this, id, x);
}


// void InsertPoint(vtkIdType id, const double x[3])
// "void InsertPoint(vtkIdType id, const double x[3])"
public new void InsertPoint(long /*(vtkIdType)*/ id, double /*(double[3])*/ []x) {
	API_vtkPoints.InsertPoint_1(this, id, x);
}


// void InsertPoint(vtkIdType id, double x, double y, double z)
// "void InsertPoint(vtkIdType id, double x, double y, double z)"
public new void InsertPoint(long /*(vtkIdType)*/ id, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	API_vtkPoints.InsertPoint_2(this, id, x, y, z);
}


// void InsertPoints(vtkIdList * dstIds, vtkIdList * srcIds, vtkPoints * source)
// "void InsertPoints(vtkIdList *dstIds, vtkIdList *srcIds, vtkPoints *source)"
public new void InsertPoints(vtkIdList /*(vtkIdList*)*/ dstIds, vtkIdList /*(vtkIdList*)*/ srcIds, vtkPoints /*(vtkPoints*)*/ source) {
	API_vtkPoints.InsertPoints_0(this, dstIds, srcIds, source);
}


// void InsertPoints(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkPoints * source)
// "void InsertPoints(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkPoints* source)"
public new void InsertPoints(long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, vtkPoints /*(vtkPoints*)*/ source) {
	API_vtkPoints.InsertPoints_1(this, dstStart, n, srcStart, source);
}


// vtkIdType InsertNextPoint(const float x[3])
// "vtkIdType InsertNextPoint(const float x[3])"
public new long InsertNextPoint(float /*(float[3])*/ []x) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPoints.InsertNextPoint_0(this, returnPointer, x);
	return Ptr.deref(returnPointer);
}


// vtkIdType InsertNextPoint(const double x[3])
// "vtkIdType InsertNextPoint(const double x[3])"
public new long InsertNextPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPoints.InsertNextPoint_1(this, returnPointer, x);
	return Ptr.deref(returnPointer);
}


// vtkIdType InsertNextPoint(double x, double y, double z)
// "vtkIdType InsertNextPoint(double x, double y, double z)"
public new long InsertNextPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPoints.InsertNextPoint_2(this, returnPointer, x, y, z);
	return Ptr.deref(returnPointer);
}


// void SetNumberOfPoints(vtkIdType numPoints)
// "void SetNumberOfPoints(vtkIdType numPoints)"
public new void SetNumberOfPoints(long /*(vtkIdType)*/ numPoints) {
	API_vtkPoints.SetNumberOfPoints_0(this, numPoints);
}


// int Resize(vtkIdType numPoints)
// "int Resize(vtkIdType numPoints)"
public new int Resize(long /*(vtkIdType)*/ numPoints) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPoints.Resize_0(this, returnPointer, numPoints);
	return Ptr.deref(returnPointer);
}


// void GetPoints(vtkIdList * ptId, vtkPoints * fp)
// "void GetPoints(vtkIdList *ptId, vtkPoints *fp)"
public new void GetPoints(vtkIdList /*(vtkIdList*)*/ ptId, vtkPoints /*(vtkPoints*)*/ fp) {
	API_vtkPoints.GetPoints_0(this, ptId, fp);
}


// virtual void ComputeBounds()
// "virtual void ComputeBounds()"
public new void ComputeBounds() {
	API_vtkPoints.ComputeBounds_0(this);
}


// double* GetBounds()
// "double *GetBounds()"
public new double GetBounds() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkPoints.GetBounds_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public new void GetBounds(double /*(double[6])*/ []bounds) {
	API_vtkPoints.GetBounds_1(this, bounds);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public new ulong GetMTime() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkPoints.GetMTime_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void Modified()
// "void Modified()"
public new void Modified() {
	API_vtkPoints.Modified_0(this);
}


}
};
