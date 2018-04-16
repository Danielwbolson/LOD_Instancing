
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkCell : vtkObject {

//       Method: virtual const char * vtkCell::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkCell.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCell::Initialize(int npts, vtkIdType* pts, vtkPoints* p)
// 
public void Initialize(int npts, long/*vtkIdType* */ pts, vtkPoints/*vtkPoints* */ p) {
	VTK.API_vtkCell.Initialize(obj, npts, pts, p);
}


//       Method: void vtkCell::Initialize(int npts, vtkPoints* p)
// 
public void Initialize(int npts, vtkPoints/*vtkPoints* */ p) {
	VTK.API_vtkCell.Initialize(obj, npts, p);
}


//       Method: virtual void vtkCell::ShallowCopy(vtkCell* c)
// 
public void ShallowCopy(vtkCell/*vtkCell* */ c) {
	VTK.API_vtkCell.ShallowCopy(obj, c);
}


//       Method: virtual void vtkCell::DeepCopy(vtkCell* c)
// 
public void DeepCopy(vtkCell/*vtkCell* */ c) {
	VTK.API_vtkCell.DeepCopy(obj, c);
}


//       Method: virtual int vtkCell::GetCellType()
// 
public int GetCellType() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetCellType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkCell::GetCellDimension()
// 
public int GetCellDimension() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetCellDimension(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkCell::IsLinear()
// 
public int IsLinear() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.IsLinear(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkCell::RequiresInitialization()
// 
public int RequiresInitialization() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.RequiresInitialization(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkCell::Initialize()
// 
public void Initialize() {
	VTK.API_vtkCell.Initialize(obj);
}


//       Method: virtual int vtkCell::IsExplicitCell()
// 
public int IsExplicitCell() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.IsExplicitCell(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkCell::RequiresExplicitFaceRepresentation()
// 
public int RequiresExplicitFaceRepresentation() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.RequiresExplicitFaceRepresentation(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType * vtkCell::GetFaces()
// 
public long GetFaces() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetFaces(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkPoints * vtkCell::GetPoints()
// 
public vtkPoints GetPoints() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetPoints(p,obj);
	vtkPoints result = new vtkPoints();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkCell::GetNumberOfPoints()
// 
public long GetNumberOfPoints() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetNumberOfPoints(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkCell::GetNumberOfEdges()
// 
public int GetNumberOfEdges() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetNumberOfEdges(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkCell::GetNumberOfFaces()
// 
public int GetNumberOfFaces() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetNumberOfFaces(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdList * vtkCell::GetPointIds()
// 
public vtkIdList GetPointIds() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetPointIds(p,obj);
	vtkIdList result = new vtkIdList();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkCell::GetPointId(int ptId)
// 
public long GetPointId(int ptId) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetPointId(p,obj, ptId);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkCell * vtkCell::GetEdge(int edgeId)
// 
public vtkCell GetEdge(int edgeId) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetEdge(p,obj, edgeId);
	vtkCell result = new vtkCell();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkCell * vtkCell::GetFace(int faceId)
// 
public vtkCell GetFace(int faceId) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetFace(p,obj, faceId);
	vtkCell result = new vtkCell();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkCell::CellBoundary(int subId, double pcoords[3], vtkIdList* pts)
// 
public int CellBoundary(int subId, double[] /*3*/ pcoords, vtkIdList/*vtkIdList* */ pts) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.CellBoundary(p,obj, subId, pcoords, pts);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkCell::Contour(double value, vtkDataArray* cellScalars, vtkIncrementalPointLocator* locator, vtkCellArray* verts, vtkCellArray* lines, vtkCellArray* polys, vtkPointData* inPd, vtkPointData* outPd, vtkCellData* inCd, vtkIdType cellId, vtkCellData* outCd)
// 
public void Contour(double value, vtkDataArray/*vtkDataArray* */ cellScalars, vtkIncrementalPointLocator/*vtkIncrementalPointLocator* */ locator, vtkCellArray/*vtkCellArray* */ verts, vtkCellArray/*vtkCellArray* */ lines, vtkCellArray/*vtkCellArray* */ polys, vtkPointData/*vtkPointData* */ inPd, vtkPointData/*vtkPointData* */ outPd, vtkCellData/*vtkCellData* */ inCd, long cellId, vtkCellData/*vtkCellData* */ outCd) {
	VTK.API_vtkCell.Contour(obj, value, cellScalars, locator, verts, lines, polys, inPd, outPd, inCd, cellId, outCd);
}


//       Method: virtual void vtkCell::Clip(double value, vtkDataArray* cellScalars, vtkIncrementalPointLocator* locator, vtkCellArray* connectivity, vtkPointData* inPd, vtkPointData* outPd, vtkCellData* inCd, vtkIdType cellId, vtkCellData* outCd, int insideOut)
// 
public void Clip(double value, vtkDataArray/*vtkDataArray* */ cellScalars, vtkIncrementalPointLocator/*vtkIncrementalPointLocator* */ locator, vtkCellArray/*vtkCellArray* */ connectivity, vtkPointData/*vtkPointData* */ inPd, vtkPointData/*vtkPointData* */ outPd, vtkCellData/*vtkCellData* */ inCd, long cellId, vtkCellData/*vtkCellData* */ outCd, int insideOut) {
	VTK.API_vtkCell.Clip(obj, value, cellScalars, locator, connectivity, inPd, outPd, inCd, cellId, outCd, insideOut);
}


//       Method: virtual int vtkCell::Triangulate(int index, vtkIdList* ptIds, vtkPoints* pts)
// 
public int Triangulate(int index, vtkIdList/*vtkIdList* */ ptIds, vtkPoints/*vtkPoints* */ pts) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.Triangulate(p,obj, index, ptIds, pts);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkCell::Derivatives(int subId, double pcoords[3], double* values, int dim, double* derivs)
// 
public void Derivatives(int subId, double[] /*3*/ pcoords, double/*double* */ values, int dim, double/*double* */ derivs) {
	VTK.API_vtkCell.Derivatives(obj, subId, pcoords, values, dim, derivs);
}


//       Method: void vtkCell::GetBounds(double bounds[6])
// 
public void GetBounds(double[] /*6*/ bounds) {
	VTK.API_vtkCell.GetBounds(obj, bounds);
}


//       Method: double * vtkCell::GetBounds()
// 
public double[] GetBounds() {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetBounds(p,obj);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double vtkCell::GetLength2()
// 
public double GetLength2() {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetLength2(p,obj);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkCell::GetParametricCenter(double pcoords[3])
// 
public int GetParametricCenter(double[] /*3*/ pcoords) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetParametricCenter(p,obj, pcoords);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual double vtkCell::GetParametricDistance(double pcoords[3])
// 
public double GetParametricDistance(double[] /*3*/ pcoords) {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetParametricDistance(p,obj, pcoords);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkCell::IsPrimaryCell()
// 
public int IsPrimaryCell() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.IsPrimaryCell(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual double * vtkCell::GetParametricCoords()
// 
public double[] GetParametricCoords() {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCell.GetParametricCoords(p,obj);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
