

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkGenericCell : vtkCell {

// static vtkGenericCell* New()
// "static vtkGenericCell *New()"
public new static vtkGenericCell New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkGenericCell.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetPoints(vtkPoints * points)
// "void SetPoints(vtkPoints *points)"
public new void SetPoints(vtkPoints /*(vtkPoints*)*/ points) {
	API_vtkGenericCell.SetPoints_0(this, points);
}


// void SetPointIds(vtkIdList * pointIds)
// "void SetPointIds(vtkIdList *pointIds)"
public new void SetPointIds(vtkIdList /*(vtkIdList*)*/ pointIds) {
	API_vtkGenericCell.SetPointIds_0(this, pointIds);
}


// void ShallowCopy(vtkCell * c)
// "void ShallowCopy(vtkCell *c)"
public new void ShallowCopy(vtkCell /*(vtkCell*)*/ c) {
	API_vtkGenericCell.ShallowCopy_0(this, c);
}


// void DeepCopy(vtkCell * c)
// "void DeepCopy(vtkCell *c)"
public new void DeepCopy(vtkCell /*(vtkCell*)*/ c) {
	API_vtkGenericCell.DeepCopy_0(this, c);
}


// int GetCellType()
// "int GetCellType()"
public new int GetCellType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkGenericCell.GetCellType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetCellDimension()
// "int GetCellDimension()"
public new int GetCellDimension() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkGenericCell.GetCellDimension_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int IsLinear()
// "int IsLinear()"
public new int IsLinear() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkGenericCell.IsLinear_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int RequiresInitialization()
// "int RequiresInitialization()"
public new int RequiresInitialization() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkGenericCell.RequiresInitialization_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void Initialize()
// "void Initialize()"
public new void Initialize() {
	API_vtkGenericCell.Initialize_0(this);
}


// int RequiresExplicitFaceRepresentation()
// "int RequiresExplicitFaceRepresentation()"
public new int RequiresExplicitFaceRepresentation() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkGenericCell.RequiresExplicitFaceRepresentation_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetFaces(vtkIdType * faces)
// "void SetFaces(vtkIdType *faces)"
public new void SetFaces(long /*(vtkIdType*)*/ []faces) {
	API_vtkGenericCell.SetFaces_0(this, faces);
}


// vtkIdType* GetFaces()
// "vtkIdType *GetFaces()"
public new long GetFaces() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkGenericCell.GetFaces_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetNumberOfEdges()
// "int GetNumberOfEdges()"
public new int GetNumberOfEdges() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkGenericCell.GetNumberOfEdges_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetNumberOfFaces()
// "int GetNumberOfFaces()"
public new int GetNumberOfFaces() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkGenericCell.GetNumberOfFaces_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkCell* GetEdge(int edgeId)
// "vtkCell *GetEdge(int edgeId)"
public new vtkCell GetEdge(int /*(int)*/ edgeId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkGenericCell.GetEdge_0(this, returnPointer, edgeId);
	return Ptr.deref(returnPointer);
}


// vtkCell* GetFace(int faceId)
// "vtkCell *GetFace(int faceId)"
public new vtkCell GetFace(int /*(int)*/ faceId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkGenericCell.GetFace_0(this, returnPointer, faceId);
	return Ptr.deref(returnPointer);
}


// int CellBoundary(int subId, double pcoords[3], vtkIdList * pts)
// "int CellBoundary(int subId, double pcoords[3], vtkIdList *pts)"
public new int CellBoundary(int /*(int)*/ subId, double /*(double[3])*/ []pcoords, vtkIdList /*(vtkIdList*)*/ pts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkGenericCell.CellBoundary_0(this, returnPointer, subId, pcoords, pts);
	return Ptr.deref(returnPointer);
}


// int EvaluatePosition(double x[3], double * closestPoint, int & subId, double pcoords[3], double & dist2, double * weights)
// "int EvaluatePosition(double x[3], double* closestPoint, int& subId, double pcoords[3], double& dist2, double *weights)"
public new int EvaluatePosition(double /*(double[3])*/ []x, double /*(double*)*/ []closestPoint, int /*(int&)*/ []subId, double /*(double[3])*/ []pcoords, double /*(double&)*/ []dist2, double /*(double*)*/ []weights) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkGenericCell.EvaluatePosition_0(this, returnPointer, x, closestPoint, *subId, pcoords, *dist2, weights);
	return Ptr.deref(returnPointer);
}


// void EvaluateLocation(int & subId, double pcoords[3], double x[3], double * weights)
// "void EvaluateLocation(int& subId, double pcoords[3], double x[3], double *weights)"
public new void EvaluateLocation(int /*(int&)*/ []subId, double /*(double[3])*/ []pcoords, double /*(double[3])*/ []x, double /*(double*)*/ []weights) {
	API_vtkGenericCell.EvaluateLocation_0(this, *subId, pcoords, x, weights);
}


// void Contour(double value, vtkDataArray * cellScalars, vtkIncrementalPointLocator * locator, vtkCellArray * verts, vtkCellArray * lines, vtkCellArray * polys, vtkPointData * inPd, vtkPointData * outPd, vtkCellData * inCd, vtkIdType cellId, vtkCellData * outCd)
// "void Contour(double value, vtkDataArray *cellScalars, vtkIncrementalPointLocator *locator, vtkCellArray *verts, vtkCellArray *lines, vtkCellArray *polys, vtkPointData *inPd, vtkPointData *outPd, vtkCellData *inCd, vtkIdType cellId, vtkCellData *outCd)"
public new void Contour(double /*(double)*/ value, vtkDataArray /*(vtkDataArray*)*/ cellScalars, vtkIncrementalPointLocator /*(vtkIncrementalPointLocator*)*/ locator, vtkCellArray /*(vtkCellArray*)*/ verts, vtkCellArray /*(vtkCellArray*)*/ lines, vtkCellArray /*(vtkCellArray*)*/ polys, vtkPointData /*(vtkPointData*)*/ inPd, vtkPointData /*(vtkPointData*)*/ outPd, vtkCellData /*(vtkCellData*)*/ inCd, long /*(vtkIdType)*/ cellId, vtkCellData /*(vtkCellData*)*/ outCd) {
	API_vtkGenericCell.Contour_0(this, value, cellScalars, locator, verts, lines, polys, inPd, outPd, inCd, cellId, outCd);
}


// void Clip(double value, vtkDataArray * cellScalars, vtkIncrementalPointLocator * locator, vtkCellArray * connectivity, vtkPointData * inPd, vtkPointData * outPd, vtkCellData * inCd, vtkIdType cellId, vtkCellData * outCd, int insideOut)
// "void Clip(double value, vtkDataArray *cellScalars, vtkIncrementalPointLocator *locator, vtkCellArray *connectivity, vtkPointData *inPd, vtkPointData *outPd, vtkCellData *inCd, vtkIdType cellId, vtkCellData *outCd, int insideOut)"
public new void Clip(double /*(double)*/ value, vtkDataArray /*(vtkDataArray*)*/ cellScalars, vtkIncrementalPointLocator /*(vtkIncrementalPointLocator*)*/ locator, vtkCellArray /*(vtkCellArray*)*/ connectivity, vtkPointData /*(vtkPointData*)*/ inPd, vtkPointData /*(vtkPointData*)*/ outPd, vtkCellData /*(vtkCellData*)*/ inCd, long /*(vtkIdType)*/ cellId, vtkCellData /*(vtkCellData*)*/ outCd, int /*(int)*/ insideOut) {
	API_vtkGenericCell.Clip_0(this, value, cellScalars, locator, connectivity, inPd, outPd, inCd, cellId, outCd, insideOut);
}


// int IntersectWithLine(double p1[3], double p2[3], double tol, double & t, double x[3], double pcoords[3], int & subId)
// "int IntersectWithLine(double p1[3], double p2[3], double tol, double& t, double x[3], double pcoords[3], int& subId)"
public new int IntersectWithLine(double /*(double[3])*/ []p1, double /*(double[3])*/ []p2, double /*(double)*/ tol, double /*(double&)*/ []t, double /*(double[3])*/ []x, double /*(double[3])*/ []pcoords, int /*(int&)*/ []subId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkGenericCell.IntersectWithLine_0(this, returnPointer, p1, p2, tol, *t, x, pcoords, *subId);
	return Ptr.deref(returnPointer);
}


// int Triangulate(int index, vtkIdList * ptIds, vtkPoints * pts)
// "int Triangulate(int index, vtkIdList *ptIds, vtkPoints *pts)"
public new int Triangulate(int /*(int)*/ index, vtkIdList /*(vtkIdList*)*/ ptIds, vtkPoints /*(vtkPoints*)*/ pts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkGenericCell.Triangulate_0(this, returnPointer, index, ptIds, pts);
	return Ptr.deref(returnPointer);
}


// void Derivatives(int subId, double pcoords[3], double * values, int dim, double * derivs)
// "void Derivatives(int subId, double pcoords[3], double *values, int dim, double *derivs)"
public new void Derivatives(int /*(int)*/ subId, double /*(double[3])*/ []pcoords, double /*(double*)*/ []values, int /*(int)*/ dim, double /*(double*)*/ []derivs) {
	API_vtkGenericCell.Derivatives_0(this, subId, pcoords, values, dim, derivs);
}


// int GetParametricCenter(double pcoords[3])
// "int GetParametricCenter(double pcoords[3])"
public new int GetParametricCenter(double /*(double[3])*/ []pcoords) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkGenericCell.GetParametricCenter_0(this, returnPointer, pcoords);
	return Ptr.deref(returnPointer);
}


// double* GetParametricCoords()
// "double *GetParametricCoords()"
public new double GetParametricCoords() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkGenericCell.GetParametricCoords_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int IsPrimaryCell()
// "int IsPrimaryCell()"
public new int IsPrimaryCell() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkGenericCell.IsPrimaryCell_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void InterpolateFunctions(double pcoords[3], double * weights)
// "void InterpolateFunctions(double pcoords[3], double *weights)"
public new void InterpolateFunctions(double /*(double[3])*/ []pcoords, double /*(double*)*/ []weights) {
	API_vtkGenericCell.InterpolateFunctions_0(this, pcoords, weights);
}


// void InterpolateDerivs(double pcoords[3], double * derivs)
// "void InterpolateDerivs(double pcoords[3], double *derivs)"
public new void InterpolateDerivs(double /*(double[3])*/ []pcoords, double /*(double*)*/ []derivs) {
	API_vtkGenericCell.InterpolateDerivs_0(this, pcoords, derivs);
}


// void SetCellType(int cellType)
// "void SetCellType(int cellType)"
public new void SetCellType(int /*(int)*/ cellType) {
	API_vtkGenericCell.SetCellType_0(this, cellType);
}


// void SetCellTypeToEmptyCell()
// "void SetCellTypeToEmptyCell()"
public new void SetCellTypeToEmptyCell() {
	API_vtkGenericCell.SetCellTypeToEmptyCell_0(this);
}


// void SetCellTypeToVertex()
// "void SetCellTypeToVertex()"
public new void SetCellTypeToVertex() {
	API_vtkGenericCell.SetCellTypeToVertex_0(this);
}


// void SetCellTypeToPolyVertex()
// "void SetCellTypeToPolyVertex()"
public new void SetCellTypeToPolyVertex() {
	API_vtkGenericCell.SetCellTypeToPolyVertex_0(this);
}


// void SetCellTypeToLine()
// "void SetCellTypeToLine()"
public new void SetCellTypeToLine() {
	API_vtkGenericCell.SetCellTypeToLine_0(this);
}


// void SetCellTypeToPolyLine()
// "void SetCellTypeToPolyLine()"
public new void SetCellTypeToPolyLine() {
	API_vtkGenericCell.SetCellTypeToPolyLine_0(this);
}


// void SetCellTypeToTriangle()
// "void SetCellTypeToTriangle()"
public new void SetCellTypeToTriangle() {
	API_vtkGenericCell.SetCellTypeToTriangle_0(this);
}


// void SetCellTypeToTriangleStrip()
// "void SetCellTypeToTriangleStrip()"
public new void SetCellTypeToTriangleStrip() {
	API_vtkGenericCell.SetCellTypeToTriangleStrip_0(this);
}


// void SetCellTypeToPolygon()
// "void SetCellTypeToPolygon()"
public new void SetCellTypeToPolygon() {
	API_vtkGenericCell.SetCellTypeToPolygon_0(this);
}


// void SetCellTypeToPixel()
// "void SetCellTypeToPixel()"
public new void SetCellTypeToPixel() {
	API_vtkGenericCell.SetCellTypeToPixel_0(this);
}


// void SetCellTypeToQuad()
// "void SetCellTypeToQuad()"
public new void SetCellTypeToQuad() {
	API_vtkGenericCell.SetCellTypeToQuad_0(this);
}


// void SetCellTypeToTetra()
// "void SetCellTypeToTetra()"
public new void SetCellTypeToTetra() {
	API_vtkGenericCell.SetCellTypeToTetra_0(this);
}


// void SetCellTypeToVoxel()
// "void SetCellTypeToVoxel()"
public new void SetCellTypeToVoxel() {
	API_vtkGenericCell.SetCellTypeToVoxel_0(this);
}


// void SetCellTypeToHexahedron()
// "void SetCellTypeToHexahedron()"
public new void SetCellTypeToHexahedron() {
	API_vtkGenericCell.SetCellTypeToHexahedron_0(this);
}


// void SetCellTypeToWedge()
// "void SetCellTypeToWedge()"
public new void SetCellTypeToWedge() {
	API_vtkGenericCell.SetCellTypeToWedge_0(this);
}


// void SetCellTypeToPyramid()
// "void SetCellTypeToPyramid()"
public new void SetCellTypeToPyramid() {
	API_vtkGenericCell.SetCellTypeToPyramid_0(this);
}


// void SetCellTypeToPentagonalPrism()
// "void SetCellTypeToPentagonalPrism()"
public new void SetCellTypeToPentagonalPrism() {
	API_vtkGenericCell.SetCellTypeToPentagonalPrism_0(this);
}


// void SetCellTypeToHexagonalPrism()
// "void SetCellTypeToHexagonalPrism()"
public new void SetCellTypeToHexagonalPrism() {
	API_vtkGenericCell.SetCellTypeToHexagonalPrism_0(this);
}


// void SetCellTypeToPolyhedron()
// "void SetCellTypeToPolyhedron()"
public new void SetCellTypeToPolyhedron() {
	API_vtkGenericCell.SetCellTypeToPolyhedron_0(this);
}


// void SetCellTypeToConvexPointSet()
// "void SetCellTypeToConvexPointSet()"
public new void SetCellTypeToConvexPointSet() {
	API_vtkGenericCell.SetCellTypeToConvexPointSet_0(this);
}


// void SetCellTypeToQuadraticEdge()
// "void SetCellTypeToQuadraticEdge()"
public new void SetCellTypeToQuadraticEdge() {
	API_vtkGenericCell.SetCellTypeToQuadraticEdge_0(this);
}


// void SetCellTypeToCubicLine()
// "void SetCellTypeToCubicLine()"
public new void SetCellTypeToCubicLine() {
	API_vtkGenericCell.SetCellTypeToCubicLine_0(this);
}


// void SetCellTypeToQuadraticTriangle()
// "void SetCellTypeToQuadraticTriangle()"
public new void SetCellTypeToQuadraticTriangle() {
	API_vtkGenericCell.SetCellTypeToQuadraticTriangle_0(this);
}


// void SetCellTypeToBiQuadraticTriangle()
// "void SetCellTypeToBiQuadraticTriangle()"
public new void SetCellTypeToBiQuadraticTriangle() {
	API_vtkGenericCell.SetCellTypeToBiQuadraticTriangle_0(this);
}


// void SetCellTypeToQuadraticQuad()
// "void SetCellTypeToQuadraticQuad()"
public new void SetCellTypeToQuadraticQuad() {
	API_vtkGenericCell.SetCellTypeToQuadraticQuad_0(this);
}


// void SetCellTypeToQuadraticPolygon()
// "void SetCellTypeToQuadraticPolygon()"
public new void SetCellTypeToQuadraticPolygon() {
	API_vtkGenericCell.SetCellTypeToQuadraticPolygon_0(this);
}


// void SetCellTypeToQuadraticTetra()
// "void SetCellTypeToQuadraticTetra()"
public new void SetCellTypeToQuadraticTetra() {
	API_vtkGenericCell.SetCellTypeToQuadraticTetra_0(this);
}


// void SetCellTypeToQuadraticHexahedron()
// "void SetCellTypeToQuadraticHexahedron()"
public new void SetCellTypeToQuadraticHexahedron() {
	API_vtkGenericCell.SetCellTypeToQuadraticHexahedron_0(this);
}


// void SetCellTypeToQuadraticWedge()
// "void SetCellTypeToQuadraticWedge()"
public new void SetCellTypeToQuadraticWedge() {
	API_vtkGenericCell.SetCellTypeToQuadraticWedge_0(this);
}


// void SetCellTypeToQuadraticPyramid()
// "void SetCellTypeToQuadraticPyramid()"
public new void SetCellTypeToQuadraticPyramid() {
	API_vtkGenericCell.SetCellTypeToQuadraticPyramid_0(this);
}


// void SetCellTypeToQuadraticLinearQuad()
// "void SetCellTypeToQuadraticLinearQuad()"
public new void SetCellTypeToQuadraticLinearQuad() {
	API_vtkGenericCell.SetCellTypeToQuadraticLinearQuad_0(this);
}


// void SetCellTypeToBiQuadraticQuad()
// "void SetCellTypeToBiQuadraticQuad()"
public new void SetCellTypeToBiQuadraticQuad() {
	API_vtkGenericCell.SetCellTypeToBiQuadraticQuad_0(this);
}


// void SetCellTypeToQuadraticLinearWedge()
// "void SetCellTypeToQuadraticLinearWedge()"
public new void SetCellTypeToQuadraticLinearWedge() {
	API_vtkGenericCell.SetCellTypeToQuadraticLinearWedge_0(this);
}


// void SetCellTypeToBiQuadraticQuadraticWedge()
// "void SetCellTypeToBiQuadraticQuadraticWedge()"
public new void SetCellTypeToBiQuadraticQuadraticWedge() {
	API_vtkGenericCell.SetCellTypeToBiQuadraticQuadraticWedge_0(this);
}


// void SetCellTypeToTriQuadraticHexahedron()
// "void SetCellTypeToTriQuadraticHexahedron()"
public new void SetCellTypeToTriQuadraticHexahedron() {
	API_vtkGenericCell.SetCellTypeToTriQuadraticHexahedron_0(this);
}


// void SetCellTypeToBiQuadraticQuadraticHexahedron()
// "void SetCellTypeToBiQuadraticQuadraticHexahedron()"
public new void SetCellTypeToBiQuadraticQuadraticHexahedron() {
	API_vtkGenericCell.SetCellTypeToBiQuadraticQuadraticHexahedron_0(this);
}


// void SetCellTypeToLagrangeTriangle()
// "void SetCellTypeToLagrangeTriangle()"
public new void SetCellTypeToLagrangeTriangle() {
	API_vtkGenericCell.SetCellTypeToLagrangeTriangle_0(this);
}


// void SetCellTypeToLagrangeTetra()
// "void SetCellTypeToLagrangeTetra()"
public new void SetCellTypeToLagrangeTetra() {
	API_vtkGenericCell.SetCellTypeToLagrangeTetra_0(this);
}


// void SetCellTypeToLagrangeCurve()
// "void SetCellTypeToLagrangeCurve()"
public new void SetCellTypeToLagrangeCurve() {
	API_vtkGenericCell.SetCellTypeToLagrangeCurve_0(this);
}


// void SetCellTypeToLagrangeQuadrilateral()
// "void SetCellTypeToLagrangeQuadrilateral()"
public new void SetCellTypeToLagrangeQuadrilateral() {
	API_vtkGenericCell.SetCellTypeToLagrangeQuadrilateral_0(this);
}


// void SetCellTypeToLagrangeHexahedron()
// "void SetCellTypeToLagrangeHexahedron()"
public new void SetCellTypeToLagrangeHexahedron() {
	API_vtkGenericCell.SetCellTypeToLagrangeHexahedron_0(this);
}


// void SetCellTypeToLagrangeWedge()
// "void SetCellTypeToLagrangeWedge()"
public new void SetCellTypeToLagrangeWedge() {
	API_vtkGenericCell.SetCellTypeToLagrangeWedge_0(this);
}


// static vtkCell* InstantiateCell(int cellType)
// "static vtkCell* InstantiateCell(int cellType)"
public new static vtkCell InstantiateCell(int /*(int)*/ cellType) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkGenericCell.InstantiateCell_0(returnPointer, cellType);
	return Ptr.deref(returnPointer);
}


// vtkCell* GetRepresentativeCell()
// "vtkCell* GetRepresentativeCell()"
public new vtkCell GetRepresentativeCell() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkGenericCell.GetRepresentativeCell_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
