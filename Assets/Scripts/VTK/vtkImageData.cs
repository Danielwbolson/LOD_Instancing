

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkImageData : vtkDataSet {
		public vtkImageData(IntPtr p) : base(p) {}
		public static implicit operator  vtkImageData(IntPtr p) {return new vtkImageData(p);}
		public static implicit operator  IntPtr(vtkImageData o) {return o.GetPtr();}

// static vtkImageData* New()
// "static vtkImageData *New()"
public static vtkImageData New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.New_0(returnPointer.GetPtr());
	return (vtkImageData)(IntPtr)returnPointer;
}


// void CopyStructure(vtkDataSet * ds)
// "void CopyStructure(vtkDataSet *ds)"
public void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ ds) {
	VTK_API.API_vtkImageData.CopyStructure_0(this, ds);
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkImageData.GetDataObjectType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkImageData.GetNumberOfCells_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkImageData.GetNumberOfPoints_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// double* GetPoint(vtkIdType ptId)
// "double *GetPoint(vtkIdType ptId)"
public IntPtr GetPoint(long /*(vtkIdType)*/ ptId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.GetPoint_0(returnPointer.GetPtr(), this, ptId);
	return (IntPtr)returnPointer;
}


// void GetPoint(vtkIdType id, double x[3])
// "void GetPoint(vtkIdType id, double x[3])"
public void GetPoint(long /*(vtkIdType)*/ id, double /*(double[3])*/ []x) {
	VTK_API.API_vtkImageData.GetPoint_1(this, id, x);
}


// vtkCell* GetCell(vtkIdType cellId)
// "vtkCell *GetCell(vtkIdType cellId)"
public vtkCell GetCell(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.GetCell_0(returnPointer.GetPtr(), this, cellId);
	return (vtkCell)(IntPtr)returnPointer;
}


// vtkCell* GetCell(int i, int j, int k)
// "vtkCell *GetCell(int i, int j, int k)"
public vtkCell GetCell(int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.GetCell_1(returnPointer.GetPtr(), this, i, j, k);
	return (vtkCell)(IntPtr)returnPointer;
}


// void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// "void GetCell(vtkIdType cellId, vtkGenericCell *cell)"
public void GetCell(long /*(vtkIdType)*/ cellId, vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	VTK_API.API_vtkImageData.GetCell_2(this, cellId, cell);
}


// void GetCellBounds(vtkIdType cellId, double bounds[6])
// "void GetCellBounds(vtkIdType cellId, double bounds[6])"
public void GetCellBounds(long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkImageData.GetCellBounds_0(this, cellId, bounds);
}


// virtual vtkIdType FindPoint(double x, double y, double z)
// "virtual vtkIdType FindPoint(double x, double y, double z)"
public long FindPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkImageData.FindPoint_0(returnPointer.GetPtr(), this, x, y, z);
	return (long)returnPointer;
}


// vtkIdType FindPoint(double x[3])
// "vtkIdType FindPoint(double x[3])"
public long FindPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkImageData.FindPoint_1(returnPointer.GetPtr(), this, x);
	return (long)returnPointer;
}


// vtkIdType FindCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "vtkIdType FindCell( double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkImageData.FindCell_0(returnPointer.GetPtr(), this, x, cell, cellId, tol2, subId, pcoords, weights);
	return (long)returnPointer;
}


// vtkIdType FindCell(double x[3], vtkCell * cell, vtkGenericCell * gencell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "vtkIdType FindCell( double x[3], vtkCell *cell, vtkGenericCell *gencell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, vtkGenericCell /*(vtkGenericCell*)*/ gencell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkImageData.FindCell_1(returnPointer.GetPtr(), this, x, cell, gencell, cellId, tol2, subId, pcoords, weights);
	return (long)returnPointer;
}


// vtkCell* FindAndGetCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "vtkCell *FindAndGetCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public vtkCell FindAndGetCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.FindAndGetCell_0(returnPointer.GetPtr(), this, x, cell, cellId, tol2, subId, pcoords, weights);
	return (vtkCell)(IntPtr)returnPointer;
}


// int GetCellType(vtkIdType cellId)
// "int GetCellType(vtkIdType cellId)"
public int GetCellType(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkImageData.GetCellType_0(returnPointer.GetPtr(), this, cellId);
	return (int)returnPointer;
}


// void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// "void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)"
public void GetCellPoints(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	VTK_API.API_vtkImageData.GetCellPoints_0(this, cellId, ptIds);
}


// void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// "void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)"
public void GetPointCells(long /*(vtkIdType)*/ ptId, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkImageData.GetPointCells_0(this, ptId, cellIds);
}


// void ComputeBounds()
// "void ComputeBounds()"
public void ComputeBounds() {
	VTK_API.API_vtkImageData.ComputeBounds_0(this);
}


// int GetMaxCellSize()
// "int GetMaxCellSize()"
public int GetMaxCellSize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkImageData.GetMaxCellSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkImageData.Initialize_0(this);
}


// virtual void SetDimensions(int i, int j, int k)
// "virtual void SetDimensions(int i, int j, int k)"
public void SetDimensions(int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k) {
	VTK_API.API_vtkImageData.SetDimensions_0(this, i, j, k);
}


// virtual void SetDimensions(const int dims[3])
// "virtual void SetDimensions(const int dims[3])"
public void SetDimensions(int /*(int[3])*/ []dims) {
	VTK_API.API_vtkImageData.SetDimensions_1(this, dims);
}


// virtual int* GetDimensions()
// "virtual int *GetDimensions()"
public IntPtr GetDimensions() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.GetDimensions_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetDimensions(int dims[3])
// "virtual void GetDimensions(int dims[3])"
public void GetDimensions(int /*(int[3])*/ []dims) {
	VTK_API.API_vtkImageData.GetDimensions_1(this, dims);
}


// virtual int ComputeStructuredCoordinates(const double x[3], int ijk[3], double pcoords[3])
// "virtual int ComputeStructuredCoordinates( const double x[3], int ijk[3], double pcoords[3])"
public int ComputeStructuredCoordinates(double /*(double[3])*/ []x, int /*(int[3])*/ []ijk, double /*(double[3])*/ []pcoords) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkImageData.ComputeStructuredCoordinates_0(returnPointer.GetPtr(), this, x, ijk, pcoords);
	return (int)returnPointer;
}


// static int ComputeStructuredCoordinates(const double x[3], int ijk[3], double pcoords[3], const int * extent, const double * spacing, const double * origin, const double * bounds)
// "static int ComputeStructuredCoordinates( const double x[3], int ijk[3], double pcoords[3], const int* extent, const double* spacing, const double* origin, const double* bounds)"
public static int ComputeStructuredCoordinates(double /*(double[3])*/ []x, int /*(int[3])*/ []ijk, double /*(double[3])*/ []pcoords, IntPtr /*(int*)*/ extent, IntPtr /*(double*)*/ spacing, IntPtr /*(double*)*/ origin, IntPtr /*(double*)*/ bounds) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkImageData.ComputeStructuredCoordinates_1(returnPointer.GetPtr(), x, ijk, pcoords, extent, spacing, origin, bounds);
	return (int)returnPointer;
}


// virtual void GetVoxelGradient(int i, int j, int k, vtkDataArray * s, vtkDataArray * g)
// "virtual void GetVoxelGradient( int i,int j,int k, vtkDataArray *s, vtkDataArray *g)"
public void GetVoxelGradient(int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k, vtkDataArray /*(vtkDataArray*)*/ s, vtkDataArray /*(vtkDataArray*)*/ g) {
	VTK_API.API_vtkImageData.GetVoxelGradient_0(this, i, j, k, s, g);
}


// virtual void GetPointGradient(int i, int j, int k, vtkDataArray * s, double g[3])
// "virtual void GetPointGradient( int i, int j, int k, vtkDataArray *s, double g[3])"
public void GetPointGradient(int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k, vtkDataArray /*(vtkDataArray*)*/ s, double /*(double[3])*/ []g) {
	VTK_API.API_vtkImageData.GetPointGradient_0(this, i, j, k, s, g);
}


// virtual int GetDataDimension()
// "virtual int GetDataDimension()"
public int GetDataDimension() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkImageData.GetDataDimension_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual vtkIdType ComputePointId(int ijk[3])
// "virtual vtkIdType ComputePointId(int ijk[3])"
public long ComputePointId(int /*(int[3])*/ []ijk) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkImageData.ComputePointId_0(returnPointer.GetPtr(), this, ijk);
	return (long)returnPointer;
}


// virtual vtkIdType ComputeCellId(int ijk[3])
// "virtual vtkIdType ComputeCellId(int ijk[3])"
public long ComputeCellId(int /*(int[3])*/ []ijk) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkImageData.ComputeCellId_0(returnPointer.GetPtr(), this, ijk);
	return (long)returnPointer;
}


// virtual void SetAxisUpdateExtent(int axis, int min, int max, const int * updateExtent, int * axisUpdateExtent)
// "virtual void SetAxisUpdateExtent(int axis, int min, int max, const int* updateExtent, int* axisUpdateExtent)"
public void SetAxisUpdateExtent(int /*(int)*/ axis, int /*(int)*/ min, int /*(int)*/ max, IntPtr /*(int*)*/ updateExtent, IntPtr /*(int*)*/ axisUpdateExtent) {
	VTK_API.API_vtkImageData.SetAxisUpdateExtent_0(this, axis, min, max, updateExtent, axisUpdateExtent);
}


// virtual void GetAxisUpdateExtent(int axis, int & min, int & max, const int * updateExtent)
// "virtual void GetAxisUpdateExtent(int axis, int &min, int &max, const int* updateExtent)"
public void GetAxisUpdateExtent(int /*(int)*/ axis, IntPtr /*(int&)*/ min, IntPtr /*(int&)*/ max, IntPtr /*(int*)*/ updateExtent) {
	VTK_API.API_vtkImageData.GetAxisUpdateExtent_0(this, axis, min, max, updateExtent);
}


// virtual void SetExtent(int extent[6])
// "virtual void SetExtent(int extent[6])"
public void SetExtent(int /*(int[6])*/ []extent) {
	VTK_API.API_vtkImageData.SetExtent_0(this, extent);
}


// virtual void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
// "virtual void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)"
public void SetExtent(int /*(int)*/ x1, int /*(int)*/ x2, int /*(int)*/ y1, int /*(int)*/ y2, int /*(int)*/ z1, int /*(int)*/ z2) {
	VTK_API.API_vtkImageData.SetExtent_1(this, x1, x2, y1, y2, z1, z2);
}


// virtual double GetScalarTypeMin()
// "virtual double GetScalarTypeMin()"
public double GetScalarTypeMin() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new double(), return_elements);
	VTK_API.API_vtkImageData.GetScalarTypeMin_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetScalarTypeMax()
// "virtual double GetScalarTypeMax()"
public double GetScalarTypeMax() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new double(), return_elements);
	VTK_API.API_vtkImageData.GetScalarTypeMax_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual int GetScalarSize()
// "virtual int GetScalarSize()"
public int GetScalarSize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkImageData.GetScalarSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual vtkIdType* GetIncrements()
// "virtual vtkIdType *GetIncrements()"
public IntPtr GetIncrements() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.GetIncrements_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetIncrements(vtkIdType & incX, vtkIdType & incY, vtkIdType & incZ)
// "virtual void GetIncrements(vtkIdType &incX, vtkIdType &incY, vtkIdType &incZ)"
public void GetIncrements(IntPtr /*(vtkIdType&)*/ incX, IntPtr /*(vtkIdType&)*/ incY, IntPtr /*(vtkIdType&)*/ incZ) {
	VTK_API.API_vtkImageData.GetIncrements_1(this, incX, incY, incZ);
}


// virtual void GetIncrements(vtkIdType inc[3])
// "virtual void GetIncrements(vtkIdType inc[3])"
public void GetIncrements(long /*(vtkIdType[3])*/ []inc) {
	VTK_API.API_vtkImageData.GetIncrements_2(this, inc);
}


// virtual vtkIdType* GetIncrements(vtkDataArray * scalars)
// "virtual vtkIdType *GetIncrements(vtkDataArray *scalars)"
public IntPtr GetIncrements(vtkDataArray /*(vtkDataArray*)*/ scalars) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.GetIncrements_3(returnPointer.GetPtr(), this, scalars);
	return (IntPtr)returnPointer;
}


// virtual void GetIncrements(vtkDataArray * scalars, vtkIdType & incX, vtkIdType & incY, vtkIdType & incZ)
// "virtual void GetIncrements(vtkDataArray *scalars, vtkIdType &incX, vtkIdType &incY, vtkIdType &incZ)"
public void GetIncrements(vtkDataArray /*(vtkDataArray*)*/ scalars, IntPtr /*(vtkIdType&)*/ incX, IntPtr /*(vtkIdType&)*/ incY, IntPtr /*(vtkIdType&)*/ incZ) {
	VTK_API.API_vtkImageData.GetIncrements_4(this, scalars, incX, incY, incZ);
}


// virtual void GetIncrements(vtkDataArray * scalars, vtkIdType inc[3])
// "virtual void GetIncrements(vtkDataArray *scalars, vtkIdType inc[3])"
public void GetIncrements(vtkDataArray /*(vtkDataArray*)*/ scalars, long /*(vtkIdType[3])*/ []inc) {
	VTK_API.API_vtkImageData.GetIncrements_5(this, scalars, inc);
}


// virtual void GetContinuousIncrements(int extent[6], vtkIdType & incX, vtkIdType & incY, vtkIdType & incZ)
// "virtual void GetContinuousIncrements( int extent[6], vtkIdType &incX, vtkIdType &incY, vtkIdType &incZ)"
public void GetContinuousIncrements(int /*(int[6])*/ []extent, IntPtr /*(vtkIdType&)*/ incX, IntPtr /*(vtkIdType&)*/ incY, IntPtr /*(vtkIdType&)*/ incZ) {
	VTK_API.API_vtkImageData.GetContinuousIncrements_0(this, extent, incX, incY, incZ);
}


// virtual void GetContinuousIncrements(vtkDataArray * scalars, int extent[6], vtkIdType & incX, vtkIdType & incY, vtkIdType & incZ)
// "virtual void GetContinuousIncrements(vtkDataArray *scalars, int extent[6], vtkIdType &incX, vtkIdType &incY, vtkIdType &incZ)"
public void GetContinuousIncrements(vtkDataArray /*(vtkDataArray*)*/ scalars, int /*(int[6])*/ []extent, IntPtr /*(vtkIdType&)*/ incX, IntPtr /*(vtkIdType&)*/ incY, IntPtr /*(vtkIdType&)*/ incZ) {
	VTK_API.API_vtkImageData.GetContinuousIncrements_1(this, scalars, extent, incX, incY, incZ);
}


// virtual void* GetScalarPointerForExtent(int extent[6])
// "virtual void *GetScalarPointerForExtent(int extent[6])"
public IntPtr GetScalarPointerForExtent(int /*(int[6])*/ []extent) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.GetScalarPointerForExtent_0(returnPointer.GetPtr(), this, extent);
	return (IntPtr)returnPointer;
}


// virtual void* GetScalarPointer(int coordinates[3])
// "virtual void *GetScalarPointer(int coordinates[3])"
public IntPtr GetScalarPointer(int /*(int[3])*/ []coordinates) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.GetScalarPointer_0(returnPointer.GetPtr(), this, coordinates);
	return (IntPtr)returnPointer;
}


// virtual void* GetScalarPointer(int x, int y, int z)
// "virtual void *GetScalarPointer(int x, int y, int z)"
public IntPtr GetScalarPointer(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ z) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.GetScalarPointer_1(returnPointer.GetPtr(), this, x, y, z);
	return (IntPtr)returnPointer;
}


// virtual void* GetScalarPointer()
// "virtual void *GetScalarPointer()"
public IntPtr GetScalarPointer() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.GetScalarPointer_2(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual float GetScalarComponentAsFloat(int x, int y, int z, int component)
// "virtual float GetScalarComponentAsFloat(int x, int y, int z, int component)"
public float GetScalarComponentAsFloat(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ z, int /*(int)*/ component) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new float(), return_elements);
	VTK_API.API_vtkImageData.GetScalarComponentAsFloat_0(returnPointer.GetPtr(), this, x, y, z, component);
	return (float)returnPointer;
}


// virtual void SetScalarComponentFromFloat(int x, int y, int z, int component, float v)
// "virtual void SetScalarComponentFromFloat( int x, int y, int z, int component, float v)"
public void SetScalarComponentFromFloat(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ z, int /*(int)*/ component, float /*(float)*/ v) {
	VTK_API.API_vtkImageData.SetScalarComponentFromFloat_0(this, x, y, z, component, v);
}


// virtual double GetScalarComponentAsDouble(int x, int y, int z, int component)
// "virtual double GetScalarComponentAsDouble(int x, int y, int z, int component)"
public double GetScalarComponentAsDouble(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ z, int /*(int)*/ component) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new double(), return_elements);
	VTK_API.API_vtkImageData.GetScalarComponentAsDouble_0(returnPointer.GetPtr(), this, x, y, z, component);
	return (double)returnPointer;
}


// virtual void SetScalarComponentFromDouble(int x, int y, int z, int component, double v)
// "virtual void SetScalarComponentFromDouble( int x, int y, int z, int component, double v)"
public void SetScalarComponentFromDouble(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ z, int /*(int)*/ component, double /*(double)*/ v) {
	VTK_API.API_vtkImageData.SetScalarComponentFromDouble_0(this, x, y, z, component, v);
}


// virtual void AllocateScalars(int dataType, int numComponents)
// "virtual void AllocateScalars(int dataType, int numComponents)"
public void AllocateScalars(int /*(int)*/ dataType, int /*(int)*/ numComponents) {
	VTK_API.API_vtkImageData.AllocateScalars_0(this, dataType, numComponents);
}


// virtual void CopyAndCastFrom(vtkImageData * inData, int extent[6])
// "virtual void CopyAndCastFrom(vtkImageData *inData, int extent[6])"
public void CopyAndCastFrom(vtkImageData /*(vtkImageData*)*/ inData, int /*(int[6])*/ []extent) {
	VTK_API.API_vtkImageData.CopyAndCastFrom_0(this, inData, extent);
}


// virtual void CopyAndCastFrom(vtkImageData * inData, int x0, int x1, int y0, int y1, int z0, int z1)
// "virtual void CopyAndCastFrom(vtkImageData *inData, int x0, int x1, int y0, int y1, int z0, int z1)"
public void CopyAndCastFrom(vtkImageData /*(vtkImageData*)*/ inData, int /*(int)*/ x0, int /*(int)*/ x1, int /*(int)*/ y0, int /*(int)*/ y1, int /*(int)*/ z0, int /*(int)*/ z1) {
	VTK_API.API_vtkImageData.CopyAndCastFrom_1(this, inData, x0, x1, y0, y1, z0, z1);
}


// void Crop(const int * updateExtent)
// "void Crop(const int* updateExtent)"
public void Crop(IntPtr /*(int*)*/ updateExtent) {
	VTK_API.API_vtkImageData.Crop_0(this, updateExtent);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	VTK_API.API_vtkImageData.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// int GetScalarType()
// "int GetScalarType()"
public int GetScalarType() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkImageData.GetScalarType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// char* GetScalarTypeAsString()
// "const char* GetScalarTypeAsString()"
public string GetScalarTypeAsString() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.GetScalarTypeAsString_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// int GetNumberOfScalarComponents()
// "int GetNumberOfScalarComponents()"
public int GetNumberOfScalarComponents() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkImageData.GetNumberOfScalarComponents_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void PrepareForNewData()
// "void PrepareForNewData()"
public void PrepareForNewData() {
	VTK_API.API_vtkImageData.PrepareForNewData_0(this);
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkImageData.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkImageData.DeepCopy_0(this, src);
}


// void* GetArrayPointerForExtent(vtkDataArray * array, int extent[6])
// "void *GetArrayPointerForExtent(vtkDataArray* array, int extent[6])"
public IntPtr GetArrayPointerForExtent(vtkDataArray /*(vtkDataArray*)*/ array, int /*(int[6])*/ []extent) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.GetArrayPointerForExtent_0(returnPointer.GetPtr(), this, array, extent);
	return (IntPtr)returnPointer;
}


// void* GetArrayPointer(vtkDataArray * array, int coordinates[3])
// "void *GetArrayPointer(vtkDataArray* array, int coordinates[3])"
public IntPtr GetArrayPointer(vtkDataArray /*(vtkDataArray*)*/ array, int /*(int[3])*/ []coordinates) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkImageData.GetArrayPointer_0(returnPointer.GetPtr(), this, array, coordinates);
	return (IntPtr)returnPointer;
}


// void GetArrayIncrements(vtkDataArray * array, vtkIdType increments[3])
// "void GetArrayIncrements(vtkDataArray *array, vtkIdType increments[3])"
public void GetArrayIncrements(vtkDataArray /*(vtkDataArray*)*/ array, long /*(vtkIdType[3])*/ []increments) {
	VTK_API.API_vtkImageData.GetArrayIncrements_0(this, array, increments);
}


// void ComputeInternalExtent(int * intExt, int * tgtExt, int * bnds)
// "void ComputeInternalExtent(int *intExt, int *tgtExt, int *bnds)"
public void ComputeInternalExtent(IntPtr /*(int*)*/ intExt, IntPtr /*(int*)*/ tgtExt, IntPtr /*(int*)*/ bnds) {
	VTK_API.API_vtkImageData.ComputeInternalExtent_0(this, intExt, tgtExt, bnds);
}


// int GetExtentType()
// "int GetExtentType()"
public int GetExtentType() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkImageData.GetExtentType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


}
};
