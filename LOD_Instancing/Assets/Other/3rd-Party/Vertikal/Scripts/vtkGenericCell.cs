

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkGenericCell : vtkCell {
		public vtkGenericCell(IntPtr p) : base(p) {}
		public static implicit operator  vtkGenericCell(IntPtr p) {return new vtkGenericCell(p);}
		public static implicit operator  IntPtr(vtkGenericCell o) {return o.GetPtr();}

// static vtkGenericCell* New()
// "static vtkGenericCell *New()"
public static vtkGenericCell New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkGenericCell.New_0(returnPointer.GetPtr());
	return (vtkGenericCell)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkGenericCell.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkGenericCell.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkGenericCell* SafeDownCast(vtkObjectBase * o)
// "static vtkGenericCell* SafeDownCast(vtkObjectBase *o)"
public static vtkGenericCell SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkGenericCell.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkGenericCell)(IntPtr)returnPointer;
}


// vtkGenericCell* NewInstance()
// "vtkGenericCell *NewInstance()"
public vtkGenericCell NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkGenericCell.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkGenericCell)(IntPtr)returnPointer;
}


// void SetPoints(vtkPoints * points)
// "void SetPoints(vtkPoints *points)"
public void SetPoints(vtkPoints /*(vtkPoints*)*/ points) {
	VTK_API.API_vtkGenericCell.SetPoints_0(this, points);
}


// void SetPointIds(vtkIdList * pointIds)
// "void SetPointIds(vtkIdList *pointIds)"
public void SetPointIds(vtkIdList /*(vtkIdList*)*/ pointIds) {
	VTK_API.API_vtkGenericCell.SetPointIds_0(this, pointIds);
}


// void ShallowCopy(vtkCell * c)
// "void ShallowCopy(vtkCell *c)"
public void ShallowCopy(vtkCell /*(vtkCell*)*/ c) {
	VTK_API.API_vtkGenericCell.ShallowCopy_0(this, c);
}


// void DeepCopy(vtkCell * c)
// "void DeepCopy(vtkCell *c)"
public void DeepCopy(vtkCell /*(vtkCell*)*/ c) {
	VTK_API.API_vtkGenericCell.DeepCopy_0(this, c);
}


// int GetCellType()
// "int GetCellType()"
public int GetCellType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkGenericCell.GetCellType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetCellDimension()
// "int GetCellDimension()"
public int GetCellDimension() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkGenericCell.GetCellDimension_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int IsLinear()
// "int IsLinear()"
public int IsLinear() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkGenericCell.IsLinear_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int RequiresInitialization()
// "int RequiresInitialization()"
public int RequiresInitialization() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkGenericCell.RequiresInitialization_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkGenericCell.Initialize_0(this);
}


// int RequiresExplicitFaceRepresentation()
// "int RequiresExplicitFaceRepresentation()"
public int RequiresExplicitFaceRepresentation() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkGenericCell.RequiresExplicitFaceRepresentation_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetFaces(vtkIdType * faces)
// "void SetFaces(vtkIdType *faces)"
public void SetFaces(IntPtr /*(vtkIdType*)*/ faces) {
	VTK_API.API_vtkGenericCell.SetFaces_0(this, faces);
}


// vtkIdType* GetFaces()
// "vtkIdType *GetFaces()"
public IntPtr GetFaces() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkGenericCell.GetFaces_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// int GetNumberOfEdges()
// "int GetNumberOfEdges()"
public int GetNumberOfEdges() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkGenericCell.GetNumberOfEdges_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetNumberOfFaces()
// "int GetNumberOfFaces()"
public int GetNumberOfFaces() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkGenericCell.GetNumberOfFaces_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkCell* GetEdge(int edgeId)
// "vtkCell *GetEdge(int edgeId)"
public vtkCell GetEdge(int /*(int)*/ edgeId) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkGenericCell.GetEdge_0(returnPointer.GetPtr(), this, edgeId);
	return (vtkCell)(IntPtr)returnPointer;
}


// vtkCell* GetFace(int faceId)
// "vtkCell *GetFace(int faceId)"
public vtkCell GetFace(int /*(int)*/ faceId) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkGenericCell.GetFace_0(returnPointer.GetPtr(), this, faceId);
	return (vtkCell)(IntPtr)returnPointer;
}


// int CellBoundary(int subId, double pcoords[3], vtkIdList * pts)
// "int CellBoundary(int subId, double pcoords[3], vtkIdList *pts)"
public int CellBoundary(int /*(int)*/ subId, double /*(double[3])*/ []pcoords, vtkIdList /*(vtkIdList*)*/ pts) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkGenericCell.CellBoundary_0(returnPointer.GetPtr(), this, subId, pcoords, pts);
	return (int)returnPointer;
}


// int EvaluatePosition(double x[3], double * closestPoint, int & subId, double pcoords[3], double & dist2, double * weights)
// "int EvaluatePosition(double x[3], double* closestPoint, int& subId, double pcoords[3], double& dist2, double *weights)"
public int EvaluatePosition(double /*(double[3])*/ []x, IntPtr /*(double*)*/ closestPoint, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double&)*/ dist2, IntPtr /*(double*)*/ weights) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkGenericCell.EvaluatePosition_0(returnPointer.GetPtr(), this, x, closestPoint, subId, pcoords, dist2, weights);
	return (int)returnPointer;
}


// void EvaluateLocation(int & subId, double pcoords[3], double x[3], double * weights)
// "void EvaluateLocation(int& subId, double pcoords[3], double x[3], double *weights)"
public void EvaluateLocation(IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, double /*(double[3])*/ []x, IntPtr /*(double*)*/ weights) {
	VTK_API.API_vtkGenericCell.EvaluateLocation_0(this, subId, pcoords, x, weights);
}


// void Contour(double value, vtkDataArray * cellScalars, vtkIncrementalPointLocator * locator, vtkCellArray * verts, vtkCellArray * lines, vtkCellArray * polys, vtkPointData * inPd, vtkPointData * outPd, vtkCellData * inCd, vtkIdType cellId, vtkCellData * outCd)
// "void Contour(double value, vtkDataArray *cellScalars, vtkIncrementalPointLocator *locator, vtkCellArray *verts, vtkCellArray *lines, vtkCellArray *polys, vtkPointData *inPd, vtkPointData *outPd, vtkCellData *inCd, vtkIdType cellId, vtkCellData *outCd)"
public void Contour(double /*(double)*/ value, vtkDataArray /*(vtkDataArray*)*/ cellScalars, vtkIncrementalPointLocator /*(vtkIncrementalPointLocator*)*/ locator, vtkCellArray /*(vtkCellArray*)*/ verts, vtkCellArray /*(vtkCellArray*)*/ lines, vtkCellArray /*(vtkCellArray*)*/ polys, vtkPointData /*(vtkPointData*)*/ inPd, vtkPointData /*(vtkPointData*)*/ outPd, vtkCellData /*(vtkCellData*)*/ inCd, long /*(vtkIdType)*/ cellId, vtkCellData /*(vtkCellData*)*/ outCd) {
	VTK_API.API_vtkGenericCell.Contour_0(this, value, cellScalars, locator, verts, lines, polys, inPd, outPd, inCd, cellId, outCd);
}


// void Clip(double value, vtkDataArray * cellScalars, vtkIncrementalPointLocator * locator, vtkCellArray * connectivity, vtkPointData * inPd, vtkPointData * outPd, vtkCellData * inCd, vtkIdType cellId, vtkCellData * outCd, int insideOut)
// "void Clip(double value, vtkDataArray *cellScalars, vtkIncrementalPointLocator *locator, vtkCellArray *connectivity, vtkPointData *inPd, vtkPointData *outPd, vtkCellData *inCd, vtkIdType cellId, vtkCellData *outCd, int insideOut)"
public void Clip(double /*(double)*/ value, vtkDataArray /*(vtkDataArray*)*/ cellScalars, vtkIncrementalPointLocator /*(vtkIncrementalPointLocator*)*/ locator, vtkCellArray /*(vtkCellArray*)*/ connectivity, vtkPointData /*(vtkPointData*)*/ inPd, vtkPointData /*(vtkPointData*)*/ outPd, vtkCellData /*(vtkCellData*)*/ inCd, long /*(vtkIdType)*/ cellId, vtkCellData /*(vtkCellData*)*/ outCd, int /*(int)*/ insideOut) {
	VTK_API.API_vtkGenericCell.Clip_0(this, value, cellScalars, locator, connectivity, inPd, outPd, inCd, cellId, outCd, insideOut);
}


// int IntersectWithLine(double p1[3], double p2[3], double tol, double & t, double x[3], double pcoords[3], int & subId)
// "int IntersectWithLine(double p1[3], double p2[3], double tol, double& t, double x[3], double pcoords[3], int& subId)"
public int IntersectWithLine(double /*(double[3])*/ []p1, double /*(double[3])*/ []p2, double /*(double)*/ tol, IntPtr /*(double&)*/ t, double /*(double[3])*/ []x, double /*(double[3])*/ []pcoords, IntPtr /*(int&)*/ subId) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkGenericCell.IntersectWithLine_0(returnPointer.GetPtr(), this, p1, p2, tol, t, x, pcoords, subId);
	return (int)returnPointer;
}


// int Triangulate(int index, vtkIdList * ptIds, vtkPoints * pts)
// "int Triangulate(int index, vtkIdList *ptIds, vtkPoints *pts)"
public int Triangulate(int /*(int)*/ index, vtkIdList /*(vtkIdList*)*/ ptIds, vtkPoints /*(vtkPoints*)*/ pts) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkGenericCell.Triangulate_0(returnPointer.GetPtr(), this, index, ptIds, pts);
	return (int)returnPointer;
}


// void Derivatives(int subId, double pcoords[3], double * values, int dim, double * derivs)
// "void Derivatives(int subId, double pcoords[3], double *values, int dim, double *derivs)"
public void Derivatives(int /*(int)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ values, int /*(int)*/ dim, IntPtr /*(double*)*/ derivs) {
	VTK_API.API_vtkGenericCell.Derivatives_0(this, subId, pcoords, values, dim, derivs);
}


// int GetParametricCenter(double pcoords[3])
// "int GetParametricCenter(double pcoords[3])"
public int GetParametricCenter(double /*(double[3])*/ []pcoords) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkGenericCell.GetParametricCenter_0(returnPointer.GetPtr(), this, pcoords);
	return (int)returnPointer;
}


// double* GetParametricCoords()
// "double *GetParametricCoords()"
public IntPtr GetParametricCoords() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkGenericCell.GetParametricCoords_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// int IsPrimaryCell()
// "int IsPrimaryCell()"
public int IsPrimaryCell() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkGenericCell.IsPrimaryCell_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void InterpolateFunctions(double pcoords[3], double * weights)
// "void InterpolateFunctions(double pcoords[3], double *weights)"
public void InterpolateFunctions(double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights) {
	VTK_API.API_vtkGenericCell.InterpolateFunctions_0(this, pcoords, weights);
}


// void InterpolateDerivs(double pcoords[3], double * derivs)
// "void InterpolateDerivs(double pcoords[3], double *derivs)"
public void InterpolateDerivs(double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ derivs) {
	VTK_API.API_vtkGenericCell.InterpolateDerivs_0(this, pcoords, derivs);
}


// void SetCellType(int cellType)
// "void SetCellType(int cellType)"
public void SetCellType(int /*(int)*/ cellType) {
	VTK_API.API_vtkGenericCell.SetCellType_0(this, cellType);
}


// void SetCellTypeToEmptyCell()
// "void SetCellTypeToEmptyCell()"
public void SetCellTypeToEmptyCell() {
	VTK_API.API_vtkGenericCell.SetCellTypeToEmptyCell_0(this);
}


// void SetCellTypeToVertex()
// "void SetCellTypeToVertex()"
public void SetCellTypeToVertex() {
	VTK_API.API_vtkGenericCell.SetCellTypeToVertex_0(this);
}


// void SetCellTypeToPolyVertex()
// "void SetCellTypeToPolyVertex()"
public void SetCellTypeToPolyVertex() {
	VTK_API.API_vtkGenericCell.SetCellTypeToPolyVertex_0(this);
}


// void SetCellTypeToLine()
// "void SetCellTypeToLine()"
public void SetCellTypeToLine() {
	VTK_API.API_vtkGenericCell.SetCellTypeToLine_0(this);
}


// void SetCellTypeToPolyLine()
// "void SetCellTypeToPolyLine()"
public void SetCellTypeToPolyLine() {
	VTK_API.API_vtkGenericCell.SetCellTypeToPolyLine_0(this);
}


// void SetCellTypeToTriangle()
// "void SetCellTypeToTriangle()"
public void SetCellTypeToTriangle() {
	VTK_API.API_vtkGenericCell.SetCellTypeToTriangle_0(this);
}


// void SetCellTypeToTriangleStrip()
// "void SetCellTypeToTriangleStrip()"
public void SetCellTypeToTriangleStrip() {
	VTK_API.API_vtkGenericCell.SetCellTypeToTriangleStrip_0(this);
}


// void SetCellTypeToPolygon()
// "void SetCellTypeToPolygon()"
public void SetCellTypeToPolygon() {
	VTK_API.API_vtkGenericCell.SetCellTypeToPolygon_0(this);
}


// void SetCellTypeToPixel()
// "void SetCellTypeToPixel()"
public void SetCellTypeToPixel() {
	VTK_API.API_vtkGenericCell.SetCellTypeToPixel_0(this);
}


// void SetCellTypeToQuad()
// "void SetCellTypeToQuad()"
public void SetCellTypeToQuad() {
	VTK_API.API_vtkGenericCell.SetCellTypeToQuad_0(this);
}


// void SetCellTypeToTetra()
// "void SetCellTypeToTetra()"
public void SetCellTypeToTetra() {
	VTK_API.API_vtkGenericCell.SetCellTypeToTetra_0(this);
}


// void SetCellTypeToVoxel()
// "void SetCellTypeToVoxel()"
public void SetCellTypeToVoxel() {
	VTK_API.API_vtkGenericCell.SetCellTypeToVoxel_0(this);
}


// void SetCellTypeToHexahedron()
// "void SetCellTypeToHexahedron()"
public void SetCellTypeToHexahedron() {
	VTK_API.API_vtkGenericCell.SetCellTypeToHexahedron_0(this);
}


// void SetCellTypeToWedge()
// "void SetCellTypeToWedge()"
public void SetCellTypeToWedge() {
	VTK_API.API_vtkGenericCell.SetCellTypeToWedge_0(this);
}


// void SetCellTypeToPyramid()
// "void SetCellTypeToPyramid()"
public void SetCellTypeToPyramid() {
	VTK_API.API_vtkGenericCell.SetCellTypeToPyramid_0(this);
}


// void SetCellTypeToPentagonalPrism()
// "void SetCellTypeToPentagonalPrism()"
public void SetCellTypeToPentagonalPrism() {
	VTK_API.API_vtkGenericCell.SetCellTypeToPentagonalPrism_0(this);
}


// void SetCellTypeToHexagonalPrism()
// "void SetCellTypeToHexagonalPrism()"
public void SetCellTypeToHexagonalPrism() {
	VTK_API.API_vtkGenericCell.SetCellTypeToHexagonalPrism_0(this);
}


// void SetCellTypeToPolyhedron()
// "void SetCellTypeToPolyhedron()"
public void SetCellTypeToPolyhedron() {
	VTK_API.API_vtkGenericCell.SetCellTypeToPolyhedron_0(this);
}


// void SetCellTypeToConvexPointSet()
// "void SetCellTypeToConvexPointSet()"
public void SetCellTypeToConvexPointSet() {
	VTK_API.API_vtkGenericCell.SetCellTypeToConvexPointSet_0(this);
}


// void SetCellTypeToQuadraticEdge()
// "void SetCellTypeToQuadraticEdge()"
public void SetCellTypeToQuadraticEdge() {
	VTK_API.API_vtkGenericCell.SetCellTypeToQuadraticEdge_0(this);
}


// void SetCellTypeToCubicLine()
// "void SetCellTypeToCubicLine()"
public void SetCellTypeToCubicLine() {
	VTK_API.API_vtkGenericCell.SetCellTypeToCubicLine_0(this);
}


// void SetCellTypeToQuadraticTriangle()
// "void SetCellTypeToQuadraticTriangle()"
public void SetCellTypeToQuadraticTriangle() {
	VTK_API.API_vtkGenericCell.SetCellTypeToQuadraticTriangle_0(this);
}


// void SetCellTypeToBiQuadraticTriangle()
// "void SetCellTypeToBiQuadraticTriangle()"
public void SetCellTypeToBiQuadraticTriangle() {
	VTK_API.API_vtkGenericCell.SetCellTypeToBiQuadraticTriangle_0(this);
}


// void SetCellTypeToQuadraticQuad()
// "void SetCellTypeToQuadraticQuad()"
public void SetCellTypeToQuadraticQuad() {
	VTK_API.API_vtkGenericCell.SetCellTypeToQuadraticQuad_0(this);
}


// void SetCellTypeToQuadraticPolygon()
// "void SetCellTypeToQuadraticPolygon()"
public void SetCellTypeToQuadraticPolygon() {
	VTK_API.API_vtkGenericCell.SetCellTypeToQuadraticPolygon_0(this);
}


// void SetCellTypeToQuadraticTetra()
// "void SetCellTypeToQuadraticTetra()"
public void SetCellTypeToQuadraticTetra() {
	VTK_API.API_vtkGenericCell.SetCellTypeToQuadraticTetra_0(this);
}


// void SetCellTypeToQuadraticHexahedron()
// "void SetCellTypeToQuadraticHexahedron()"
public void SetCellTypeToQuadraticHexahedron() {
	VTK_API.API_vtkGenericCell.SetCellTypeToQuadraticHexahedron_0(this);
}


// void SetCellTypeToQuadraticWedge()
// "void SetCellTypeToQuadraticWedge()"
public void SetCellTypeToQuadraticWedge() {
	VTK_API.API_vtkGenericCell.SetCellTypeToQuadraticWedge_0(this);
}


// void SetCellTypeToQuadraticPyramid()
// "void SetCellTypeToQuadraticPyramid()"
public void SetCellTypeToQuadraticPyramid() {
	VTK_API.API_vtkGenericCell.SetCellTypeToQuadraticPyramid_0(this);
}


// void SetCellTypeToQuadraticLinearQuad()
// "void SetCellTypeToQuadraticLinearQuad()"
public void SetCellTypeToQuadraticLinearQuad() {
	VTK_API.API_vtkGenericCell.SetCellTypeToQuadraticLinearQuad_0(this);
}


// void SetCellTypeToBiQuadraticQuad()
// "void SetCellTypeToBiQuadraticQuad()"
public void SetCellTypeToBiQuadraticQuad() {
	VTK_API.API_vtkGenericCell.SetCellTypeToBiQuadraticQuad_0(this);
}


// void SetCellTypeToQuadraticLinearWedge()
// "void SetCellTypeToQuadraticLinearWedge()"
public void SetCellTypeToQuadraticLinearWedge() {
	VTK_API.API_vtkGenericCell.SetCellTypeToQuadraticLinearWedge_0(this);
}


// void SetCellTypeToBiQuadraticQuadraticWedge()
// "void SetCellTypeToBiQuadraticQuadraticWedge()"
public void SetCellTypeToBiQuadraticQuadraticWedge() {
	VTK_API.API_vtkGenericCell.SetCellTypeToBiQuadraticQuadraticWedge_0(this);
}


// void SetCellTypeToTriQuadraticHexahedron()
// "void SetCellTypeToTriQuadraticHexahedron()"
public void SetCellTypeToTriQuadraticHexahedron() {
	VTK_API.API_vtkGenericCell.SetCellTypeToTriQuadraticHexahedron_0(this);
}


// void SetCellTypeToBiQuadraticQuadraticHexahedron()
// "void SetCellTypeToBiQuadraticQuadraticHexahedron()"
public void SetCellTypeToBiQuadraticQuadraticHexahedron() {
	VTK_API.API_vtkGenericCell.SetCellTypeToBiQuadraticQuadraticHexahedron_0(this);
}


// void SetCellTypeToLagrangeTriangle()
// "void SetCellTypeToLagrangeTriangle()"
public void SetCellTypeToLagrangeTriangle() {
	VTK_API.API_vtkGenericCell.SetCellTypeToLagrangeTriangle_0(this);
}


// void SetCellTypeToLagrangeTetra()
// "void SetCellTypeToLagrangeTetra()"
public void SetCellTypeToLagrangeTetra() {
	VTK_API.API_vtkGenericCell.SetCellTypeToLagrangeTetra_0(this);
}


// void SetCellTypeToLagrangeCurve()
// "void SetCellTypeToLagrangeCurve()"
public void SetCellTypeToLagrangeCurve() {
	VTK_API.API_vtkGenericCell.SetCellTypeToLagrangeCurve_0(this);
}


// void SetCellTypeToLagrangeQuadrilateral()
// "void SetCellTypeToLagrangeQuadrilateral()"
public void SetCellTypeToLagrangeQuadrilateral() {
	VTK_API.API_vtkGenericCell.SetCellTypeToLagrangeQuadrilateral_0(this);
}


// void SetCellTypeToLagrangeHexahedron()
// "void SetCellTypeToLagrangeHexahedron()"
public void SetCellTypeToLagrangeHexahedron() {
	VTK_API.API_vtkGenericCell.SetCellTypeToLagrangeHexahedron_0(this);
}


// void SetCellTypeToLagrangeWedge()
// "void SetCellTypeToLagrangeWedge()"
public void SetCellTypeToLagrangeWedge() {
	VTK_API.API_vtkGenericCell.SetCellTypeToLagrangeWedge_0(this);
}


// static vtkCell* InstantiateCell(int cellType)
// "static vtkCell* InstantiateCell(int cellType)"
public static vtkCell InstantiateCell(int /*(int)*/ cellType) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkGenericCell.InstantiateCell_0(returnPointer.GetPtr(), cellType);
	return (vtkCell)(IntPtr)returnPointer;
}


// vtkCell* GetRepresentativeCell()
// "vtkCell* GetRepresentativeCell()"
public vtkCell GetRepresentativeCell() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkGenericCell.GetRepresentativeCell_0(returnPointer.GetPtr(), this);
	return (vtkCell)(IntPtr)returnPointer;
}


}
};
