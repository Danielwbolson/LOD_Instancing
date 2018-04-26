
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkPolyData : vtkPointSet {

//       Method: static vtkPolyData * vtkPolyData::New()
// 
public static vtkPolyData New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.New(p);
	vtkPolyData result = new vtkPolyData();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkPolyData::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkPolyData.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkPolyData::GetDataObjectType()
// 
public int GetDataObjectType() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetDataObjectType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPolyData::CopyStructure(vtkDataSet* ds)
// 
public void CopyStructure(vtkDataSet/*vtkDataSet* */ ds) {
	VTK.API_vtkPolyData.CopyStructure(obj, ds);
}


//       Method: vtkIdType vtkPolyData::GetNumberOfCells()
// 
public long GetNumberOfCells() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetNumberOfCells(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkCell * vtkPolyData::GetCell(vtkIdType cellId)
// 
public vtkCell GetCell(long cellId) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetCell(p,obj, cellId);
	vtkCell result = new vtkCell();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPolyData::GetCell(vtkIdType cellId, vtkGenericCell* cell)
// 
public void GetCell(long cellId, vtkGenericCell/*vtkGenericCell* */ cell) {
	VTK.API_vtkPolyData.GetCell(obj, cellId, cell);
}


//       Method: int vtkPolyData::GetCellType(vtkIdType cellId)
// 
public int GetCellType(long cellId) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetCellType(p,obj, cellId);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPolyData::GetCellBounds(vtkIdType cellId, double bounds[6])
// 
public void GetCellBounds(long cellId, double[] /*6*/ bounds) {
	VTK.API_vtkPolyData.GetCellBounds(obj, cellId, bounds);
}


//       Method: void vtkPolyData::GetCellNeighbors(vtkIdType cellId, vtkIdList* ptIds, vtkIdList* cellIds)
// 
public void GetCellNeighbors(long cellId, vtkIdList/*vtkIdList* */ ptIds, vtkIdList/*vtkIdList* */ cellIds) {
	VTK.API_vtkPolyData.GetCellNeighbors(obj, cellId, ptIds, cellIds);
}


// //       Method: void vtkPolyData::CopyCells(vtkPolyData* pd, vtkIdList* idList, vtkPointLocator* locator)
// // 
// public void CopyCells(vtkPolyDatavtkPolyData*  pd, vtkIdList/*vtkIdList* */ idList, vtkPointLocator/*vtkPointLocator* */ locator) {
// 	VTK.API_vtkPolyData.CopyCells(obj, pd, idList, locator);
// }


//       Method: void vtkPolyData::GetCellPoints(vtkIdType cellId, vtkIdList* ptIds)
// 
public void GetCellPoints(long cellId, vtkIdList/*vtkIdList* */ ptIds) {
	VTK.API_vtkPolyData.GetCellPoints(obj, cellId, ptIds);
}


//       Method: void vtkPolyData::GetPointCells(vtkIdType ptId, vtkIdList* cellIds)
// 
public void GetPointCells(long ptId, vtkIdList/*vtkIdList* */ cellIds) {
	VTK.API_vtkPolyData.GetPointCells(obj, ptId, cellIds);
}


//       Method: void vtkPolyData::ComputeBounds()
// 
public void ComputeBounds() {
	VTK.API_vtkPolyData.ComputeBounds(obj);
}


//       Method: void vtkPolyData::Squeeze()
// 
public void Squeeze() {
	VTK.API_vtkPolyData.Squeeze(obj);
}


//       Method: int vtkPolyData::GetMaxCellSize()
// 
public int GetMaxCellSize() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetMaxCellSize(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkCellArray * vtkPolyData::GetVerts()
// 
public vtkCellArray GetVerts() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetVerts(p,obj);
	vtkCellArray result = new vtkCellArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkCellArray * vtkPolyData::GetLines()
// 
public vtkCellArray GetLines() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetLines(p,obj);
	vtkCellArray result = new vtkCellArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkCellArray * vtkPolyData::GetPolys()
// 
public vtkCellArray GetPolys() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetPolys(p,obj);
	vtkCellArray result = new vtkCellArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkCellArray * vtkPolyData::GetStrips()
// 
public vtkCellArray GetStrips() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetStrips(p,obj);
	vtkCellArray result = new vtkCellArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkPolyData::GetNumberOfVerts()
// 
public long GetNumberOfVerts() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetNumberOfVerts(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkPolyData::GetNumberOfLines()
// 
public long GetNumberOfLines() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetNumberOfLines(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkPolyData::GetNumberOfPolys()
// 
public long GetNumberOfPolys() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetNumberOfPolys(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkPolyData::GetNumberOfStrips()
// 
public long GetNumberOfStrips() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetNumberOfStrips(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPolyData::Allocate(vtkIdType numCells, int extSize)
// 
public void Allocate(long numCells, int extSize) {
	VTK.API_vtkPolyData.Allocate(obj, numCells, extSize);
}


//       Method: void vtkPolyData::Allocate(vtkPolyData* inPolyData, vtkIdType numCells, int extSize)
// 
public void Allocate(vtkPolyData/*vtkPolyData* */ inPolyData, long numCells, int extSize) {
	VTK.API_vtkPolyData.Allocate(obj, inPolyData, numCells, extSize);
}


//       Method: vtkIdType vtkPolyData::InsertNextCell(int type, int npts, vtkIdType* pts)
// 
public long InsertNextCell(int type, int npts, long/*vtkIdType* */ pts) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.InsertNextCell(p,obj, type, npts, pts);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkPolyData::InsertNextCell(int type, vtkIdList* pts)
// 
public long InsertNextCell(int type, vtkIdList/*vtkIdList* */ pts) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.InsertNextCell(p,obj, type, pts);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPolyData::Reset()
// 
public void Reset() {
	VTK.API_vtkPolyData.Reset(obj);
}


//       Method: void vtkPolyData::BuildCells()
// 
public void BuildCells() {
	VTK.API_vtkPolyData.BuildCells(obj);
}


//       Method: bool vtkPolyData::NeedToBuildCells()
// 
public bool NeedToBuildCells() {
	int numElements = 1;
	bool example = new bool();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.NeedToBuildCells(p,obj);
	bool result = Convert.ToBoolean(Marshal.ReadByte(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPolyData::BuildLinks(int initialSize)
// 
public void BuildLinks(int initialSize) {
	VTK.API_vtkPolyData.BuildLinks(obj, initialSize);
}


//       Method: void vtkPolyData::DeleteCells()
// 
public void DeleteCells() {
	VTK.API_vtkPolyData.DeleteCells(obj);
}


//       Method: void vtkPolyData::DeleteLinks()
// 
public void DeleteLinks() {
	VTK.API_vtkPolyData.DeleteLinks(obj);
}


//       Method: void vtkPolyData::GetCellEdgeNeighbors(vtkIdType cellId, vtkIdType p1, vtkIdType p2, vtkIdList* cellIds)
// 
public void GetCellEdgeNeighbors(long cellId, long p1, long p2, vtkIdList/*vtkIdList* */ cellIds) {
	VTK.API_vtkPolyData.GetCellEdgeNeighbors(obj, cellId, p1, p2, cellIds);
}


//       Method: int vtkPolyData::IsTriangle(int v1, int v2, int v3)
// 
public int IsTriangle(int v1, int v2, int v3) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.IsTriangle(p,obj, v1, v2, v3);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkPolyData::IsEdge(vtkIdType p1, vtkIdType p2)
// 
public int IsEdge(long p1, long p2) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.IsEdge(p,obj, p1, p2);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkPolyData::IsPointUsedByCell(vtkIdType ptId, vtkIdType cellId)
// 
public int IsPointUsedByCell(long ptId, long cellId) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.IsPointUsedByCell(p,obj, ptId, cellId);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPolyData::ReplaceCell(vtkIdType cellId, int npts, vtkIdType* pts)
// 
public void ReplaceCell(long cellId, int npts, long/*vtkIdType* */ pts) {
	VTK.API_vtkPolyData.ReplaceCell(obj, cellId, npts, pts);
}


//       Method: void vtkPolyData::ReplaceCellPoint(vtkIdType cellId, vtkIdType oldPtId, vtkIdType newPtId)
// 
public void ReplaceCellPoint(long cellId, long oldPtId, long newPtId) {
	VTK.API_vtkPolyData.ReplaceCellPoint(obj, cellId, oldPtId, newPtId);
}


//       Method: void vtkPolyData::ReverseCell(vtkIdType cellId)
// 
public void ReverseCell(long cellId) {
	VTK.API_vtkPolyData.ReverseCell(obj, cellId);
}


//       Method: void vtkPolyData::DeletePoint(vtkIdType ptId)
// 
public void DeletePoint(long ptId) {
	VTK.API_vtkPolyData.DeletePoint(obj, ptId);
}


//       Method: void vtkPolyData::DeleteCell(vtkIdType cellId)
// 
public void DeleteCell(long cellId) {
	VTK.API_vtkPolyData.DeleteCell(obj, cellId);
}


//       Method: void vtkPolyData::RemoveDeletedCells()
// 
public void RemoveDeletedCells() {
	VTK.API_vtkPolyData.RemoveDeletedCells(obj);
}


//       Method: vtkIdType vtkPolyData::InsertNextLinkedPoint(int numLinks)
// 
public long InsertNextLinkedPoint(int numLinks) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.InsertNextLinkedPoint(p,obj, numLinks);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkPolyData::InsertNextLinkedPoint(double x[3], int numLinks)
// 
public long InsertNextLinkedPoint(double[] /*3*/ x, int numLinks) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.InsertNextLinkedPoint(p,obj, x, numLinks);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkPolyData::InsertNextLinkedCell(int type, int npts, vtkIdType* pts)
// 
public long InsertNextLinkedCell(int type, int npts, long/*vtkIdType* */ pts) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.InsertNextLinkedCell(p,obj, type, npts, pts);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPolyData::ReplaceLinkedCell(vtkIdType cellId, int npts, vtkIdType* pts)
// 
public void ReplaceLinkedCell(long cellId, int npts, long/*vtkIdType* */ pts) {
	VTK.API_vtkPolyData.ReplaceLinkedCell(obj, cellId, npts, pts);
}


//       Method: void vtkPolyData::RemoveCellReference(vtkIdType cellId)
// 
public void RemoveCellReference(long cellId) {
	VTK.API_vtkPolyData.RemoveCellReference(obj, cellId);
}


//       Method: void vtkPolyData::AddCellReference(vtkIdType cellId)
// 
public void AddCellReference(long cellId) {
	VTK.API_vtkPolyData.AddCellReference(obj, cellId);
}


//       Method: void vtkPolyData::RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// 
public void RemoveReferenceToCell(long ptId, long cellId) {
	VTK.API_vtkPolyData.RemoveReferenceToCell(obj, ptId, cellId);
}


//       Method: void vtkPolyData::AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// 
public void AddReferenceToCell(long ptId, long cellId) {
	VTK.API_vtkPolyData.AddReferenceToCell(obj, ptId, cellId);
}


//       Method: void vtkPolyData::ResizeCellList(vtkIdType ptId, int size)
// 
public void ResizeCellList(long ptId, int size) {
	VTK.API_vtkPolyData.ResizeCellList(obj, ptId, size);
}


//       Method: void vtkPolyData::Initialize()
// 
public void Initialize() {
	VTK.API_vtkPolyData.Initialize(obj);
}


//       Method: virtual int vtkPolyData::GetPiece()
// 
public int GetPiece() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetPiece(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkPolyData::GetNumberOfPieces()
// 
public int GetNumberOfPieces() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetNumberOfPieces(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkPolyData::GetGhostLevel()
// 
public int GetGhostLevel() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetGhostLevel(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkPolyData::ShallowCopy(vtkDataObject* src)
// 
public void ShallowCopy(vtkDataObject/*vtkDataObject* */ src) {
	VTK.API_vtkPolyData.ShallowCopy(obj, src);
}


//       Method: void vtkPolyData::DeepCopy(vtkDataObject* src)
// 
public void DeepCopy(vtkDataObject/*vtkDataObject* */ src) {
	VTK.API_vtkPolyData.DeepCopy(obj, src);
}


//       Method: void vtkPolyData::RemoveGhostCells()
// 
public void RemoveGhostCells() {
	VTK.API_vtkPolyData.RemoveGhostCells(obj);
}


//       Method: static vtkPolyData * vtkPolyData::GetData(vtkInformation* info)
// 
public static vtkPolyData GetData(vtkInformation/*vtkInformation* */ info) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetData(p, info);
	vtkPolyData result = new vtkPolyData();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkPolyData * vtkPolyData::GetData(vtkInformationVector* v, int i)
// 
public static vtkPolyData GetData(vtkInformationVector/*vtkInformationVector* */ v, int i) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetData(p, v, i);
	vtkPolyData result = new vtkPolyData();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkMTimeType vtkPolyData::GetMeshMTime()
// 
public ulong GetMeshMTime() {
	int numElements = 1;
	ulong example = new ulong();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkPolyData.GetMeshMTime(p,obj);
	// UNSPECIFIED TYPE
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
