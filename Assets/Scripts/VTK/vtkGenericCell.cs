
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkGenericCell : vtkCell {

//       Method: static vtkGenericCell * vtkGenericCell::New()
// 
public static vtkGenericCell New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.New(p);
	vtkGenericCell result = new vtkGenericCell();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkGenericCell::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkGenericCell.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkGenericCell::SetPoints(vtkPoints* points)
// 
public void SetPoints(vtkPoints/*vtkPoints* */ points) {
	VTK.API_vtkGenericCell.SetPoints(obj, points);
}


//       Method: void vtkGenericCell::SetPointIds(vtkIdList* pointIds)
// 
public void SetPointIds(vtkIdList/*vtkIdList* */ pointIds) {
	VTK.API_vtkGenericCell.SetPointIds(obj, pointIds);
}


//       Method: void vtkGenericCell::ShallowCopy(vtkCell* c)
// 
public void ShallowCopy(vtkCell/*vtkCell* */ c) {
	VTK.API_vtkGenericCell.ShallowCopy(obj, c);
}


//       Method: void vtkGenericCell::DeepCopy(vtkCell* c)
// 
public void DeepCopy(vtkCell/*vtkCell* */ c) {
	VTK.API_vtkGenericCell.DeepCopy(obj, c);
}


//       Method: int vtkGenericCell::GetCellType()
// 
public int GetCellType() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.GetCellType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkGenericCell::GetCellDimension()
// 
public int GetCellDimension() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.GetCellDimension(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkGenericCell::IsLinear()
// 
public int IsLinear() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.IsLinear(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkGenericCell::RequiresInitialization()
// 
public int RequiresInitialization() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.RequiresInitialization(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkGenericCell::Initialize()
// 
public void Initialize() {
	VTK.API_vtkGenericCell.Initialize(obj);
}


//       Method: int vtkGenericCell::RequiresExplicitFaceRepresentation()
// 
public int RequiresExplicitFaceRepresentation() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.RequiresExplicitFaceRepresentation(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkGenericCell::SetFaces(vtkIdType* faces)
// 
public void SetFaces(long/*vtkIdType* */ faces) {
	VTK.API_vtkGenericCell.SetFaces(obj, faces);
}


//       Method: vtkIdType * vtkGenericCell::GetFaces()
// 
public long GetFaces() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.GetFaces(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkGenericCell::GetNumberOfEdges()
// 
public int GetNumberOfEdges() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.GetNumberOfEdges(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkGenericCell::GetNumberOfFaces()
// 
public int GetNumberOfFaces() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.GetNumberOfFaces(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkCell * vtkGenericCell::GetEdge(int edgeId)
// 
public vtkCell GetEdge(int edgeId) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.GetEdge(p,obj, edgeId);
	vtkCell result = new vtkCell();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkCell * vtkGenericCell::GetFace(int faceId)
// 
public vtkCell GetFace(int faceId) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.GetFace(p,obj, faceId);
	vtkCell result = new vtkCell();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkGenericCell::CellBoundary(int subId, double pcoords[3], vtkIdList* pts)
// 
public int CellBoundary(int subId, double[] /*3*/ pcoords, vtkIdList/*vtkIdList* */ pts) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.CellBoundary(p,obj, subId, pcoords, pts);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkGenericCell::Contour(double value, vtkDataArray* cellScalars, vtkIncrementalPointLocator* locator, vtkCellArray* verts, vtkCellArray* lines, vtkCellArray* polys, vtkPointData* inPd, vtkPointData* outPd, vtkCellData* inCd, vtkIdType cellId, vtkCellData* outCd)
// 
public void Contour(double value, vtkDataArray/*vtkDataArray* */ cellScalars, vtkIncrementalPointLocator/*vtkIncrementalPointLocator* */ locator, vtkCellArray/*vtkCellArray* */ verts, vtkCellArray/*vtkCellArray* */ lines, vtkCellArray/*vtkCellArray* */ polys, vtkPointData/*vtkPointData* */ inPd, vtkPointData/*vtkPointData* */ outPd, vtkCellData/*vtkCellData* */ inCd, long cellId, vtkCellData/*vtkCellData* */ outCd) {
	VTK.API_vtkGenericCell.Contour(obj, value, cellScalars, locator, verts, lines, polys, inPd, outPd, inCd, cellId, outCd);
}


//       Method: void vtkGenericCell::Clip(double value, vtkDataArray* cellScalars, vtkIncrementalPointLocator* locator, vtkCellArray* connectivity, vtkPointData* inPd, vtkPointData* outPd, vtkCellData* inCd, vtkIdType cellId, vtkCellData* outCd, int insideOut)
// 
public void Clip(double value, vtkDataArray/*vtkDataArray* */ cellScalars, vtkIncrementalPointLocator/*vtkIncrementalPointLocator* */ locator, vtkCellArray/*vtkCellArray* */ connectivity, vtkPointData/*vtkPointData* */ inPd, vtkPointData/*vtkPointData* */ outPd, vtkCellData/*vtkCellData* */ inCd, long cellId, vtkCellData/*vtkCellData* */ outCd, int insideOut) {
	VTK.API_vtkGenericCell.Clip(obj, value, cellScalars, locator, connectivity, inPd, outPd, inCd, cellId, outCd, insideOut);
}


//       Method: int vtkGenericCell::Triangulate(int index, vtkIdList* ptIds, vtkPoints* pts)
// 
public int Triangulate(int index, vtkIdList/*vtkIdList* */ ptIds, vtkPoints/*vtkPoints* */ pts) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.Triangulate(p,obj, index, ptIds, pts);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkGenericCell::Derivatives(int subId, double pcoords[3], double* values, int dim, double* derivs)
// 
public void Derivatives(int subId, double[] /*3*/ pcoords, double/*double* */ values, int dim, double/*double* */ derivs) {
	VTK.API_vtkGenericCell.Derivatives(obj, subId, pcoords, values, dim, derivs);
}


//       Method: int vtkGenericCell::GetParametricCenter(double pcoords[3])
// 
public int GetParametricCenter(double[] /*3*/ pcoords) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.GetParametricCenter(p,obj, pcoords);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double * vtkGenericCell::GetParametricCoords()
// 
public double[] GetParametricCoords() {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.GetParametricCoords(p,obj);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkGenericCell::IsPrimaryCell()
// 
public int IsPrimaryCell() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.IsPrimaryCell(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkGenericCell::InterpolateFunctions(double pcoords[3], double* weights)
// 
public void InterpolateFunctions(double[] /*3*/ pcoords, double/*double* */ weights) {
	VTK.API_vtkGenericCell.InterpolateFunctions(obj, pcoords, weights);
}


//       Method: void vtkGenericCell::InterpolateDerivs(double pcoords[3], double* derivs)
// 
public void InterpolateDerivs(double[] /*3*/ pcoords, double/*double* */ derivs) {
	VTK.API_vtkGenericCell.InterpolateDerivs(obj, pcoords, derivs);
}


//       Method: void vtkGenericCell::SetCellType(int cellType)
// 
public void SetCellType(int cellType) {
	VTK.API_vtkGenericCell.SetCellType(obj, cellType);
}


//       Method: void vtkGenericCell::SetCellTypeToEmptyCell()
// 
public void SetCellTypeToEmptyCell() {
	VTK.API_vtkGenericCell.SetCellTypeToEmptyCell(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToVertex()
// 
public void SetCellTypeToVertex() {
	VTK.API_vtkGenericCell.SetCellTypeToVertex(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToPolyVertex()
// 
public void SetCellTypeToPolyVertex() {
	VTK.API_vtkGenericCell.SetCellTypeToPolyVertex(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToLine()
// 
public void SetCellTypeToLine() {
	VTK.API_vtkGenericCell.SetCellTypeToLine(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToPolyLine()
// 
public void SetCellTypeToPolyLine() {
	VTK.API_vtkGenericCell.SetCellTypeToPolyLine(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToTriangle()
// 
public void SetCellTypeToTriangle() {
	VTK.API_vtkGenericCell.SetCellTypeToTriangle(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToTriangleStrip()
// 
public void SetCellTypeToTriangleStrip() {
	VTK.API_vtkGenericCell.SetCellTypeToTriangleStrip(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToPolygon()
// 
public void SetCellTypeToPolygon() {
	VTK.API_vtkGenericCell.SetCellTypeToPolygon(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToPixel()
// 
public void SetCellTypeToPixel() {
	VTK.API_vtkGenericCell.SetCellTypeToPixel(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToQuad()
// 
public void SetCellTypeToQuad() {
	VTK.API_vtkGenericCell.SetCellTypeToQuad(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToTetra()
// 
public void SetCellTypeToTetra() {
	VTK.API_vtkGenericCell.SetCellTypeToTetra(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToVoxel()
// 
public void SetCellTypeToVoxel() {
	VTK.API_vtkGenericCell.SetCellTypeToVoxel(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToHexahedron()
// 
public void SetCellTypeToHexahedron() {
	VTK.API_vtkGenericCell.SetCellTypeToHexahedron(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToWedge()
// 
public void SetCellTypeToWedge() {
	VTK.API_vtkGenericCell.SetCellTypeToWedge(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToPyramid()
// 
public void SetCellTypeToPyramid() {
	VTK.API_vtkGenericCell.SetCellTypeToPyramid(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToPentagonalPrism()
// 
public void SetCellTypeToPentagonalPrism() {
	VTK.API_vtkGenericCell.SetCellTypeToPentagonalPrism(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToHexagonalPrism()
// 
public void SetCellTypeToHexagonalPrism() {
	VTK.API_vtkGenericCell.SetCellTypeToHexagonalPrism(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToPolyhedron()
// 
public void SetCellTypeToPolyhedron() {
	VTK.API_vtkGenericCell.SetCellTypeToPolyhedron(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToConvexPointSet()
// 
public void SetCellTypeToConvexPointSet() {
	VTK.API_vtkGenericCell.SetCellTypeToConvexPointSet(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToQuadraticEdge()
// 
public void SetCellTypeToQuadraticEdge() {
	VTK.API_vtkGenericCell.SetCellTypeToQuadraticEdge(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToCubicLine()
// 
public void SetCellTypeToCubicLine() {
	VTK.API_vtkGenericCell.SetCellTypeToCubicLine(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToQuadraticTriangle()
// 
public void SetCellTypeToQuadraticTriangle() {
	VTK.API_vtkGenericCell.SetCellTypeToQuadraticTriangle(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToBiQuadraticTriangle()
// 
public void SetCellTypeToBiQuadraticTriangle() {
	VTK.API_vtkGenericCell.SetCellTypeToBiQuadraticTriangle(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToQuadraticQuad()
// 
public void SetCellTypeToQuadraticQuad() {
	VTK.API_vtkGenericCell.SetCellTypeToQuadraticQuad(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToQuadraticPolygon()
// 
public void SetCellTypeToQuadraticPolygon() {
	VTK.API_vtkGenericCell.SetCellTypeToQuadraticPolygon(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToQuadraticTetra()
// 
public void SetCellTypeToQuadraticTetra() {
	VTK.API_vtkGenericCell.SetCellTypeToQuadraticTetra(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToQuadraticHexahedron()
// 
public void SetCellTypeToQuadraticHexahedron() {
	VTK.API_vtkGenericCell.SetCellTypeToQuadraticHexahedron(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToQuadraticWedge()
// 
public void SetCellTypeToQuadraticWedge() {
	VTK.API_vtkGenericCell.SetCellTypeToQuadraticWedge(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToQuadraticPyramid()
// 
public void SetCellTypeToQuadraticPyramid() {
	VTK.API_vtkGenericCell.SetCellTypeToQuadraticPyramid(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToQuadraticLinearQuad()
// 
public void SetCellTypeToQuadraticLinearQuad() {
	VTK.API_vtkGenericCell.SetCellTypeToQuadraticLinearQuad(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToBiQuadraticQuad()
// 
public void SetCellTypeToBiQuadraticQuad() {
	VTK.API_vtkGenericCell.SetCellTypeToBiQuadraticQuad(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToQuadraticLinearWedge()
// 
public void SetCellTypeToQuadraticLinearWedge() {
	VTK.API_vtkGenericCell.SetCellTypeToQuadraticLinearWedge(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToBiQuadraticQuadraticWedge()
// 
public void SetCellTypeToBiQuadraticQuadraticWedge() {
	VTK.API_vtkGenericCell.SetCellTypeToBiQuadraticQuadraticWedge(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToTriQuadraticHexahedron()
// 
public void SetCellTypeToTriQuadraticHexahedron() {
	VTK.API_vtkGenericCell.SetCellTypeToTriQuadraticHexahedron(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToBiQuadraticQuadraticHexahedron()
// 
public void SetCellTypeToBiQuadraticQuadraticHexahedron() {
	VTK.API_vtkGenericCell.SetCellTypeToBiQuadraticQuadraticHexahedron(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToLagrangeTriangle()
// 
public void SetCellTypeToLagrangeTriangle() {
	VTK.API_vtkGenericCell.SetCellTypeToLagrangeTriangle(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToLagrangeTetra()
// 
public void SetCellTypeToLagrangeTetra() {
	VTK.API_vtkGenericCell.SetCellTypeToLagrangeTetra(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToLagrangeCurve()
// 
public void SetCellTypeToLagrangeCurve() {
	VTK.API_vtkGenericCell.SetCellTypeToLagrangeCurve(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToLagrangeQuadrilateral()
// 
public void SetCellTypeToLagrangeQuadrilateral() {
	VTK.API_vtkGenericCell.SetCellTypeToLagrangeQuadrilateral(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToLagrangeHexahedron()
// 
public void SetCellTypeToLagrangeHexahedron() {
	VTK.API_vtkGenericCell.SetCellTypeToLagrangeHexahedron(obj);
}


//       Method: void vtkGenericCell::SetCellTypeToLagrangeWedge()
// 
public void SetCellTypeToLagrangeWedge() {
	VTK.API_vtkGenericCell.SetCellTypeToLagrangeWedge(obj);
}


//       Method: static vtkCell * vtkGenericCell::InstantiateCell(int cellType)
// 
public static vtkCell InstantiateCell(int cellType) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.InstantiateCell(p, cellType);
	vtkCell result = new vtkCell();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkCell * vtkGenericCell::GetRepresentativeCell()
// 
public vtkCell GetRepresentativeCell() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkGenericCell.GetRepresentativeCell(p,obj);
	vtkCell result = new vtkCell();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
