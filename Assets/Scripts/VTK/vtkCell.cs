

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCell : vtkObject {

// void Initialize(int npts, vtkIdType * pts, vtkPoints * p)
// "void Initialize(int npts, vtkIdType *pts, vtkPoints *p)"
public new void Initialize(int /*(int)*/ npts, long /*(vtkIdType*)*/ []pts, vtkPoints /*(vtkPoints*)*/ p) {
	API_vtkCell.Initialize_0(this, npts, pts, p);
}


// void Initialize(int npts, vtkPoints * p)
// "void Initialize(int npts, vtkPoints *p)"
public new void Initialize(int /*(int)*/ npts, vtkPoints /*(vtkPoints*)*/ p) {
	API_vtkCell.Initialize_1(this, npts, p);
}


// virtual void ShallowCopy(vtkCell * c)
// "virtual void ShallowCopy(vtkCell *c)"
public new void ShallowCopy(vtkCell /*(vtkCell*)*/ c) {
	API_vtkCell.ShallowCopy_0(this, c);
}


// virtual void DeepCopy(vtkCell * c)
// "virtual void DeepCopy(vtkCell *c)"
public new void DeepCopy(vtkCell /*(vtkCell*)*/ c) {
	API_vtkCell.DeepCopy_0(this, c);
}


// virtual int GetCellType()
// "virtual int GetCellType()"
public new int GetCellType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.GetCellType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int GetCellDimension()
// "virtual int GetCellDimension()"
public new int GetCellDimension() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.GetCellDimension_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int IsLinear()
// "virtual int IsLinear()"
public new int IsLinear() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.IsLinear_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int RequiresInitialization()
// "virtual int RequiresInitialization()"
public new int RequiresInitialization() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.RequiresInitialization_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void Initialize()
// "virtual void Initialize()"
public new void Initialize() {
	API_vtkCell.Initialize_2(this);
}


// virtual int IsExplicitCell()
// "virtual int IsExplicitCell()"
public new int IsExplicitCell() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.IsExplicitCell_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int RequiresExplicitFaceRepresentation()
// "virtual int RequiresExplicitFaceRepresentation()"
public new int RequiresExplicitFaceRepresentation() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.RequiresExplicitFaceRepresentation_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType* GetFaces()
// "virtual vtkIdType *GetFaces()"
public new long GetFaces() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCell.GetFaces_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkPoints* GetPoints()
// "vtkPoints *GetPoints()"
public new vtkPoints GetPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkCell.GetPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public new long GetNumberOfPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCell.GetNumberOfPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int GetNumberOfEdges()
// "virtual int GetNumberOfEdges()"
public new int GetNumberOfEdges() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.GetNumberOfEdges_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int GetNumberOfFaces()
// "virtual int GetNumberOfFaces()"
public new int GetNumberOfFaces() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.GetNumberOfFaces_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdList* GetPointIds()
// "vtkIdList *GetPointIds()"
public new vtkIdList GetPointIds() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkCell.GetPointIds_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetPointId(int ptId)
// "vtkIdType GetPointId(int ptId)"
public new long GetPointId(int /*(int)*/ ptId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCell.GetPointId_0(this, returnPointer, ptId);
	return Ptr.deref(returnPointer);
}


// virtual vtkCell* GetEdge(int edgeId)
// "virtual vtkCell *GetEdge(int edgeId)"
public new vtkCell GetEdge(int /*(int)*/ edgeId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkCell.GetEdge_0(this, returnPointer, edgeId);
	return Ptr.deref(returnPointer);
}


// virtual vtkCell* GetFace(int faceId)
// "virtual vtkCell *GetFace(int faceId)"
public new vtkCell GetFace(int /*(int)*/ faceId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkCell.GetFace_0(this, returnPointer, faceId);
	return Ptr.deref(returnPointer);
}


// virtual int CellBoundary(int subId, double pcoords[3], vtkIdList * pts)
// "virtual int CellBoundary(int subId, double pcoords[3], vtkIdList *pts)"
public new int CellBoundary(int /*(int)*/ subId, double /*(double[3])*/ []pcoords, vtkIdList /*(vtkIdList*)*/ pts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.CellBoundary_0(this, returnPointer, subId, pcoords, pts);
	return Ptr.deref(returnPointer);
}


// virtual int EvaluatePosition(double x[3], double * closestPoint, int & subId, double pcoords[3], double & dist2, double * weights)
// "virtual int EvaluatePosition(double x[3], double* closestPoint, int& subId, double pcoords[3], double& dist2, double *weights)"
public new int EvaluatePosition(double /*(double[3])*/ []x, double /*(double*)*/ []closestPoint, int /*(int&)*/ []subId, double /*(double[3])*/ []pcoords, double /*(double&)*/ []dist2, double /*(double*)*/ []weights) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.EvaluatePosition_0(this, returnPointer, x, closestPoint, *subId, pcoords, *dist2, weights);
	return Ptr.deref(returnPointer);
}


// virtual void EvaluateLocation(int & subId, double pcoords[3], double x[3], double * weights)
// "virtual void EvaluateLocation(int& subId, double pcoords[3], double x[3], double *weights)"
public new void EvaluateLocation(int /*(int&)*/ []subId, double /*(double[3])*/ []pcoords, double /*(double[3])*/ []x, double /*(double*)*/ []weights) {
	API_vtkCell.EvaluateLocation_0(this, *subId, pcoords, x, weights);
}


// virtual void Contour(double value, vtkDataArray * cellScalars, vtkIncrementalPointLocator * locator, vtkCellArray * verts, vtkCellArray * lines, vtkCellArray * polys, vtkPointData * inPd, vtkPointData * outPd, vtkCellData * inCd, vtkIdType cellId, vtkCellData * outCd)
// "virtual void Contour(double value, vtkDataArray *cellScalars, vtkIncrementalPointLocator *locator, vtkCellArray *verts, vtkCellArray *lines, vtkCellArray *polys, vtkPointData *inPd, vtkPointData *outPd, vtkCellData *inCd, vtkIdType cellId, vtkCellData *outCd)"
public new void Contour(double /*(double)*/ value, vtkDataArray /*(vtkDataArray*)*/ cellScalars, vtkIncrementalPointLocator /*(vtkIncrementalPointLocator*)*/ locator, vtkCellArray /*(vtkCellArray*)*/ verts, vtkCellArray /*(vtkCellArray*)*/ lines, vtkCellArray /*(vtkCellArray*)*/ polys, vtkPointData /*(vtkPointData*)*/ inPd, vtkPointData /*(vtkPointData*)*/ outPd, vtkCellData /*(vtkCellData*)*/ inCd, long /*(vtkIdType)*/ cellId, vtkCellData /*(vtkCellData*)*/ outCd) {
	API_vtkCell.Contour_0(this, value, cellScalars, locator, verts, lines, polys, inPd, outPd, inCd, cellId, outCd);
}


// virtual void Clip(double value, vtkDataArray * cellScalars, vtkIncrementalPointLocator * locator, vtkCellArray * connectivity, vtkPointData * inPd, vtkPointData * outPd, vtkCellData * inCd, vtkIdType cellId, vtkCellData * outCd, int insideOut)
// "virtual void Clip(double value, vtkDataArray *cellScalars, vtkIncrementalPointLocator *locator, vtkCellArray *connectivity, vtkPointData *inPd, vtkPointData *outPd, vtkCellData *inCd, vtkIdType cellId, vtkCellData *outCd, int insideOut)"
public new void Clip(double /*(double)*/ value, vtkDataArray /*(vtkDataArray*)*/ cellScalars, vtkIncrementalPointLocator /*(vtkIncrementalPointLocator*)*/ locator, vtkCellArray /*(vtkCellArray*)*/ connectivity, vtkPointData /*(vtkPointData*)*/ inPd, vtkPointData /*(vtkPointData*)*/ outPd, vtkCellData /*(vtkCellData*)*/ inCd, long /*(vtkIdType)*/ cellId, vtkCellData /*(vtkCellData*)*/ outCd, int /*(int)*/ insideOut) {
	API_vtkCell.Clip_0(this, value, cellScalars, locator, connectivity, inPd, outPd, inCd, cellId, outCd, insideOut);
}


// virtual int IntersectWithLine(double p1[3], double p2[3], double tol, double & t, double x[3], double pcoords[3], int & subId)
// "virtual int IntersectWithLine(double p1[3], double p2[3], double tol, double& t, double x[3], double pcoords[3], int& subId)"
public new int IntersectWithLine(double /*(double[3])*/ []p1, double /*(double[3])*/ []p2, double /*(double)*/ tol, double /*(double&)*/ []t, double /*(double[3])*/ []x, double /*(double[3])*/ []pcoords, int /*(int&)*/ []subId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.IntersectWithLine_0(this, returnPointer, p1, p2, tol, *t, x, pcoords, *subId);
	return Ptr.deref(returnPointer);
}


// virtual int Triangulate(int index, vtkIdList * ptIds, vtkPoints * pts)
// "virtual int Triangulate(int index, vtkIdList *ptIds, vtkPoints *pts)"
public new int Triangulate(int /*(int)*/ index, vtkIdList /*(vtkIdList*)*/ ptIds, vtkPoints /*(vtkPoints*)*/ pts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.Triangulate_0(this, returnPointer, index, ptIds, pts);
	return Ptr.deref(returnPointer);
}


// virtual void Derivatives(int subId, double pcoords[3], double * values, int dim, double * derivs)
// "virtual void Derivatives(int subId, double pcoords[3], double *values, int dim, double *derivs)"
public new void Derivatives(int /*(int)*/ subId, double /*(double[3])*/ []pcoords, double /*(double*)*/ []values, int /*(int)*/ dim, double /*(double*)*/ []derivs) {
	API_vtkCell.Derivatives_0(this, subId, pcoords, values, dim, derivs);
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public new void GetBounds(double /*(double[6])*/ []bounds) {
	API_vtkCell.GetBounds_0(this, bounds);
}


// double* GetBounds()
// "double *GetBounds()"
public new double GetBounds() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkCell.GetBounds_1(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// double GetLength2()
// "double GetLength2()"
public new double GetLength2() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkCell.GetLength2_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int GetParametricCenter(double pcoords[3])
// "virtual int GetParametricCenter(double pcoords[3])"
public new int GetParametricCenter(double /*(double[3])*/ []pcoords) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.GetParametricCenter_0(this, returnPointer, pcoords);
	return Ptr.deref(returnPointer);
}


// virtual double GetParametricDistance(double pcoords[3])
// "virtual double GetParametricDistance(double pcoords[3])"
public new double GetParametricDistance(double /*(double[3])*/ []pcoords) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkCell.GetParametricDistance_0(this, returnPointer, pcoords);
	return Ptr.deref(returnPointer);
}


// virtual int IsPrimaryCell()
// "virtual int IsPrimaryCell()"
public new int IsPrimaryCell() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCell.IsPrimaryCell_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual double* GetParametricCoords()
// "virtual double *GetParametricCoords()"
public new double GetParametricCoords() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkCell.GetParametricCoords_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
