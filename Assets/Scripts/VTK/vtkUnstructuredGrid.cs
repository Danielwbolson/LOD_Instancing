
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public class vtkUnstructuredGrid : vtkUnstructuredGridBase {

//       Method: static vtkUnstructuredGrid * vtkUnstructuredGrid::New()
// 
public static IntPtr New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.New(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkUnstructuredGrid::GetClassName()
// 
public static string GetClassName(IntPtr obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkUnstructuredGrid.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkUnstructuredGrid::GetDataObjectType()
// 
public static int GetDataObjectType(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetDataObjectType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkUnstructuredGrid::Allocate(vtkIdType numCells, int extSize)
// 
public static void Allocate(IntPtr obj, long numCells, int extSize) {
	VTK.API_vtkUnstructuredGrid.Allocate(obj, numCells, extSize);
}


//       Method: vtkIdType vtkUnstructuredGrid::InsertNextCell(int type, vtkIdType npts, vtkIdType* ptIds)
// 
public static long InsertNextCell(IntPtr obj, int type, long npts, IntPtr/*vtkIdType* */ ptIds) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.InsertNextCell(p,obj, type, npts, ptIds);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkUnstructuredGrid::InsertNextCell(int type, vtkIdList* ptIds)
// 
public static long InsertNextCell(IntPtr obj, int type, IntPtr/*vtkIdList* */ ptIds) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.InsertNextCell(p,obj, type, ptIds);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkUnstructuredGrid::InsertNextCell(int type, vtkIdType npts, vtkIdType* ptIds, vtkIdType nfaces, vtkIdType* faces)
// 
public static long InsertNextCell(IntPtr obj, int type, long npts, IntPtr/*vtkIdType* */ ptIds, long nfaces, IntPtr/*vtkIdType* */ faces) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.InsertNextCell(p,obj, type, npts, ptIds, nfaces, faces);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkUnstructuredGrid::Reset()
// 
public static void Reset(IntPtr obj) {
	VTK.API_vtkUnstructuredGrid.Reset(obj);
}


//       Method: void vtkUnstructuredGrid::CopyStructure(vtkDataSet* ds)
// 
public static void CopyStructure(IntPtr obj, IntPtr/*vtkDataSet* */ ds) {
	VTK.API_vtkUnstructuredGrid.CopyStructure(obj, ds);
}


//       Method: vtkIdType vtkUnstructuredGrid::GetNumberOfCells()
// 
public static long GetNumberOfCells(IntPtr obj) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetNumberOfCells(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkCell * vtkUnstructuredGrid::GetCell(vtkIdType cellId)
// 
public static IntPtr GetCell(IntPtr obj, long cellId) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetCell(p,obj, cellId);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkUnstructuredGrid::GetCell(vtkIdType cellId, vtkGenericCell* cell)
// 
public static void GetCell(IntPtr obj, long cellId, IntPtr/*vtkGenericCell* */ cell) {
	VTK.API_vtkUnstructuredGrid.GetCell(obj, cellId, cell);
}


//       Method: void vtkUnstructuredGrid::GetCellBounds(vtkIdType cellId, double bounds[6])
// 
public static void GetCellBounds(IntPtr obj, long cellId, double[] /*6*/ bounds) {
	VTK.API_vtkUnstructuredGrid.GetCellBounds(obj, cellId, bounds);
}


//       Method: void vtkUnstructuredGrid::GetCellPoints(vtkIdType cellId, vtkIdList* ptIds)
// 
public static void GetCellPoints(IntPtr obj, long cellId, IntPtr/*vtkIdList* */ ptIds) {
	VTK.API_vtkUnstructuredGrid.GetCellPoints(obj, cellId, ptIds);
}


//       Method: void vtkUnstructuredGrid::GetPointCells(vtkIdType ptId, vtkIdList* cellIds)
// 
public static void GetPointCells(IntPtr obj, long ptId, IntPtr/*vtkIdList* */ cellIds) {
	VTK.API_vtkUnstructuredGrid.GetPointCells(obj, ptId, cellIds);
}


//       Method: vtkCellIterator * vtkUnstructuredGrid::NewCellIterator()
// 
public static IntPtr NewCellIterator(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.NewCellIterator(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkUnstructuredGrid::GetCellType(vtkIdType cellId)
// 
public static int GetCellType(IntPtr obj, long cellId) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetCellType(p,obj, cellId);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkUnsignedCharArray * vtkUnstructuredGrid::GetCellTypesArray()
// 
public static IntPtr GetCellTypesArray(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetCellTypesArray(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdTypeArray * vtkUnstructuredGrid::GetCellLocationsArray()
// 
public static IntPtr GetCellLocationsArray(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetCellLocationsArray(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkUnstructuredGrid::Squeeze()
// 
public static void Squeeze(IntPtr obj) {
	VTK.API_vtkUnstructuredGrid.Squeeze(obj);
}


//       Method: void vtkUnstructuredGrid::Initialize()
// 
public static void Initialize(IntPtr obj) {
	VTK.API_vtkUnstructuredGrid.Initialize(obj);
}


//       Method: int vtkUnstructuredGrid::GetMaxCellSize()
// 
public static int GetMaxCellSize(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetMaxCellSize(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkUnstructuredGrid::BuildLinks()
// 
public static void BuildLinks(IntPtr obj) {
	VTK.API_vtkUnstructuredGrid.BuildLinks(obj);
}


//       Method: vtkCellLinks * vtkUnstructuredGrid::GetCellLinks()
// 
public static IntPtr GetCellLinks(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetCellLinks(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkUnstructuredGrid::GetFaceStream(vtkIdType cellId, vtkIdList* ptIds)
// 
public static void GetFaceStream(IntPtr obj, long cellId, IntPtr/*vtkIdList* */ ptIds) {
	VTK.API_vtkUnstructuredGrid.GetFaceStream(obj, cellId, ptIds);
}


//       Method: void vtkUnstructuredGrid::SetCells(int type, vtkCellArray* cells)
// 
public static void SetCells(IntPtr obj, int type, IntPtr/*vtkCellArray* */ cells) {
	VTK.API_vtkUnstructuredGrid.SetCells(obj, type, cells);
}


//       Method: void vtkUnstructuredGrid::SetCells(int* types, vtkCellArray* cells)
// 
public static void SetCells(IntPtr obj, IntPtr/*int* */ types, IntPtr/*vtkCellArray* */ cells) {
	VTK.API_vtkUnstructuredGrid.SetCells(obj, types, cells);
}


//       Method: void vtkUnstructuredGrid::SetCells(vtkUnsignedCharArray* cellTypes, vtkIdTypeArray* cellLocations, vtkCellArray* cells)
// 
public static void SetCells(IntPtr obj, IntPtr/*vtkUnsignedCharArray* */ cellTypes, IntPtr/*vtkIdTypeArray* */ cellLocations, IntPtr/*vtkCellArray* */ cells) {
	VTK.API_vtkUnstructuredGrid.SetCells(obj, cellTypes, cellLocations, cells);
}


//       Method: void vtkUnstructuredGrid::SetCells(vtkUnsignedCharArray* cellTypes, vtkIdTypeArray* cellLocations, vtkCellArray* cells, vtkIdTypeArray* faceLocations, vtkIdTypeArray* faces)
// 
public static void SetCells(IntPtr obj, IntPtr/*vtkUnsignedCharArray* */ cellTypes, IntPtr/*vtkIdTypeArray* */ cellLocations, IntPtr/*vtkCellArray* */ cells, IntPtr/*vtkIdTypeArray* */ faceLocations, IntPtr/*vtkIdTypeArray* */ faces) {
	VTK.API_vtkUnstructuredGrid.SetCells(obj, cellTypes, cellLocations, cells, faceLocations, faces);
}


//       Method: vtkCellArray * vtkUnstructuredGrid::GetCells()
// 
public static IntPtr GetCells(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetCells(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkUnstructuredGrid::ReplaceCell(vtkIdType cellId, int npts, vtkIdType* pts)
// 
public static void ReplaceCell(IntPtr obj, long cellId, int npts, IntPtr/*vtkIdType* */ pts) {
	VTK.API_vtkUnstructuredGrid.ReplaceCell(obj, cellId, npts, pts);
}


//       Method: vtkIdType vtkUnstructuredGrid::InsertNextLinkedCell(int type, int npts, vtkIdType* pts)
// 
public static long InsertNextLinkedCell(IntPtr obj, int type, int npts, IntPtr/*vtkIdType* */ pts) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.InsertNextLinkedCell(p,obj, type, npts, pts);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkUnstructuredGrid::RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// 
public static void RemoveReferenceToCell(IntPtr obj, long ptId, long cellId) {
	VTK.API_vtkUnstructuredGrid.RemoveReferenceToCell(obj, ptId, cellId);
}


//       Method: void vtkUnstructuredGrid::AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// 
public static void AddReferenceToCell(IntPtr obj, long ptId, long cellId) {
	VTK.API_vtkUnstructuredGrid.AddReferenceToCell(obj, ptId, cellId);
}


//       Method: void vtkUnstructuredGrid::ResizeCellList(vtkIdType ptId, int size)
// 
public static void ResizeCellList(IntPtr obj, long ptId, int size) {
	VTK.API_vtkUnstructuredGrid.ResizeCellList(obj, ptId, size);
}


//       Method: void vtkUnstructuredGrid::GetCellNeighbors(vtkIdType cellId, vtkIdList* ptIds, vtkIdList* cellIds)
// 
public static void GetCellNeighbors(IntPtr obj, long cellId, IntPtr/*vtkIdList* */ ptIds, IntPtr/*vtkIdList* */ cellIds) {
	VTK.API_vtkUnstructuredGrid.GetCellNeighbors(obj, cellId, ptIds, cellIds);
}


//       Method: virtual int vtkUnstructuredGrid::GetPiece()
// 
public static int GetPiece(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetPiece(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkUnstructuredGrid::GetNumberOfPieces()
// 
public static int GetNumberOfPieces(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetNumberOfPieces(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkUnstructuredGrid::GetGhostLevel()
// 
public static int GetGhostLevel(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetGhostLevel(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkUnstructuredGrid::ShallowCopy(vtkDataObject* src)
// 
public static void ShallowCopy(IntPtr obj, IntPtr/*vtkDataObject* */ src) {
	VTK.API_vtkUnstructuredGrid.ShallowCopy(obj, src);
}


//       Method: void vtkUnstructuredGrid::DeepCopy(vtkDataObject* src)
// 
public static void DeepCopy(IntPtr obj, IntPtr/*vtkDataObject* */ src) {
	VTK.API_vtkUnstructuredGrid.DeepCopy(obj, src);
}


//       Method: void vtkUnstructuredGrid::GetIdsOfCellsOfType(int type, vtkIdTypeArray* array)
// 
public static void GetIdsOfCellsOfType(IntPtr obj, int type, IntPtr/*vtkIdTypeArray* */ array) {
	VTK.API_vtkUnstructuredGrid.GetIdsOfCellsOfType(obj, type, array);
}


//       Method: int vtkUnstructuredGrid::IsHomogeneous()
// 
public static int IsHomogeneous(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.IsHomogeneous(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkUnstructuredGrid::RemoveGhostCells()
// 
public static void RemoveGhostCells(IntPtr obj) {
	VTK.API_vtkUnstructuredGrid.RemoveGhostCells(obj);
}


//       Method: static vtkUnstructuredGrid * vtkUnstructuredGrid::GetData(vtkInformation* info)
// 
public static IntPtr GetData(IntPtr/*vtkInformation* */ info) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetData(p, info);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkUnstructuredGrid * vtkUnstructuredGrid::GetData(vtkInformationVector* v, int i)
// 
public static IntPtr GetData(IntPtr/*vtkInformationVector* */ v, int i) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetData(p, v, i);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType * vtkUnstructuredGrid::GetFaces(vtkIdType cellId)
// 
public static long GetFaces(IntPtr obj, long cellId) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetFaces(p,obj, cellId);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdTypeArray * vtkUnstructuredGrid::GetFaces()
// 
public static IntPtr GetFaces(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetFaces(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdTypeArray * vtkUnstructuredGrid::GetFaceLocations()
// 
public static IntPtr GetFaceLocations(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetFaceLocations(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkUnstructuredGrid::InitializeFacesRepresentation(vtkIdType numPrevCells)
// 
public static int InitializeFacesRepresentation(IntPtr obj, long numPrevCells) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.InitializeFacesRepresentation(p,obj, numPrevCells);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkMTimeType vtkUnstructuredGrid::GetMeshMTime()
// 
public static IntPtr GetMeshMTime(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGrid.GetMeshMTime(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static void vtkUnstructuredGrid::ConvertFaceStreamPointIds(vtkIdList* faceStream, vtkIdType* idMap)
// 
public static void ConvertFaceStreamPointIds(IntPtr/*vtkIdList* */ faceStream, IntPtr/*vtkIdType* */ idMap) {
	VTK.API_vtkUnstructuredGrid.ConvertFaceStreamPointIds(faceStream, idMap);
}


//       Method: static void vtkUnstructuredGrid::ConvertFaceStreamPointIds(vtkIdType nfaces, vtkIdType* faceStream, vtkIdType* idMap)
// 
public static void ConvertFaceStreamPointIds(long nfaces, IntPtr/*vtkIdType* */ faceStream, IntPtr/*vtkIdType* */ idMap) {
	VTK.API_vtkUnstructuredGrid.ConvertFaceStreamPointIds(nfaces, faceStream, idMap);
}


}
};
