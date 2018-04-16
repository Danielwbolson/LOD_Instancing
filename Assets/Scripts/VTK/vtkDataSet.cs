
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkDataSet : vtkDataObject {

//       Method: virtual const char * vtkDataSet::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkDataSet.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkDataSet::CopyStructure(vtkDataSet* ds)
// 
public void CopyStructure(vtkDataSet/*vtkDataSet* */ ds) {
	VTK.API_vtkDataSet.CopyStructure(obj, ds);
}


//       Method: virtual void vtkDataSet::CopyAttributes(vtkDataSet* ds)
// 
public void CopyAttributes(vtkDataSet/*vtkDataSet* */ ds) {
	VTK.API_vtkDataSet.CopyAttributes(obj, ds);
}


//       Method: virtual vtkIdType vtkDataSet::GetNumberOfPoints()
// 
public long GetNumberOfPoints() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetNumberOfPoints(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkDataSet::GetNumberOfCells()
// 
public long GetNumberOfCells() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetNumberOfCells(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual double * vtkDataSet::GetPoint(vtkIdType ptId)
// 
public double[] GetPoint(long ptId) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetPoint(p,obj, ptId);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkDataSet::GetPoint(vtkIdType id, double x[3])
// 
public void GetPoint(long id, double[] /*3*/ x) {
	VTK.API_vtkDataSet.GetPoint(obj, id, x);
}


//       Method: virtual vtkCellIterator * vtkDataSet::NewCellIterator()
// 
public vtkCellIterator NewCellIterator() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.NewCellIterator(p,obj);
	vtkCellIterator result = new vtkCellIterator();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkCell * vtkDataSet::GetCell(vtkIdType cellId)
// 
public vtkCell GetCell(long cellId) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetCell(p,obj, cellId);
	vtkCell result = new vtkCell();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkDataSet::GetCell(vtkIdType cellId, vtkGenericCell* cell)
// 
public void GetCell(long cellId, vtkGenericCell/*vtkGenericCell* */ cell) {
	VTK.API_vtkDataSet.GetCell(obj, cellId, cell);
}


//       Method: virtual void vtkDataSet::GetCellBounds(vtkIdType cellId, double bounds[6])
// 
public void GetCellBounds(long cellId, double[] /*6*/ bounds) {
	VTK.API_vtkDataSet.GetCellBounds(obj, cellId, bounds);
}


//       Method: virtual int vtkDataSet::GetCellType(vtkIdType cellId)
// 
public int GetCellType(long cellId) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetCellType(p,obj, cellId);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkDataSet::GetCellTypes(vtkCellTypes* types)
// 
public void GetCellTypes(vtkCellTypes/*vtkCellTypes* */ types) {
	VTK.API_vtkDataSet.GetCellTypes(obj, types);
}


//       Method: virtual void vtkDataSet::GetCellPoints(vtkIdType cellId, vtkIdList* ptIds)
// 
public void GetCellPoints(long cellId, vtkIdList/*vtkIdList* */ ptIds) {
	VTK.API_vtkDataSet.GetCellPoints(obj, cellId, ptIds);
}


//       Method: virtual void vtkDataSet::GetPointCells(vtkIdType ptId, vtkIdList* cellIds)
// 
public void GetPointCells(long ptId, vtkIdList/*vtkIdList* */ cellIds) {
	VTK.API_vtkDataSet.GetPointCells(obj, ptId, cellIds);
}


//       Method: virtual void vtkDataSet::GetCellNeighbors(vtkIdType cellId, vtkIdList* ptIds, vtkIdList* cellIds)
// 
public void GetCellNeighbors(long cellId, vtkIdList/*vtkIdList* */ ptIds, vtkIdList/*vtkIdList* */ cellIds) {
	VTK.API_vtkDataSet.GetCellNeighbors(obj, cellId, ptIds, cellIds);
}


//       Method: vtkIdType vtkDataSet::FindPoint(double x, double y, double z)
// 
public long FindPoint(double x, double y, double z) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.FindPoint(p,obj, x, y, z);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkDataSet::FindPoint(double x[3])
// 
public long FindPoint(double[] /*3*/ x) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.FindPoint(p,obj, x);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkMTimeType vtkDataSet::GetMTime()
// 
public ulong GetMTime() {
	int numElements = 1;
	ulong example = new ulong();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetMTime(p,obj);
	// UNSPECIFIED TYPE
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkCellData * vtkDataSet::GetCellData()
// 
public vtkCellData GetCellData() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetCellData(p,obj);
	vtkCellData result = new vtkCellData();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkPointData * vtkDataSet::GetPointData()
// 
public vtkPointData GetPointData() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetPointData(p,obj);
	vtkPointData result = new vtkPointData();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkDataSet::Squeeze()
// 
public void Squeeze() {
	VTK.API_vtkDataSet.Squeeze(obj);
}


//       Method: virtual void vtkDataSet::ComputeBounds()
// 
public void ComputeBounds() {
	VTK.API_vtkDataSet.ComputeBounds(obj);
}


//       Method: double * vtkDataSet::GetBounds()
// 
public double[] GetBounds() {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetBounds(p,obj);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSet::GetBounds(double bounds[6])
// 
public void GetBounds(double[] /*6*/ bounds) {
	VTK.API_vtkDataSet.GetBounds(obj, bounds);
}


//       Method: double * vtkDataSet::GetCenter()
// 
public double[] GetCenter() {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetCenter(p,obj);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSet::GetCenter(double center[3])
// 
public void GetCenter(double[] /*3*/ center) {
	VTK.API_vtkDataSet.GetCenter(obj, center);
}


//       Method: double vtkDataSet::GetLength()
// 
public double GetLength() {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetLength(p,obj);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSet::Initialize()
// 
public void Initialize() {
	VTK.API_vtkDataSet.Initialize(obj);
}


//       Method: virtual void vtkDataSet::GetScalarRange(double range[2])
// 
public void GetScalarRange(double[] /*2*/ range) {
	VTK.API_vtkDataSet.GetScalarRange(obj, range);
}


//       Method: double * vtkDataSet::GetScalarRange()
// 
public double[] GetScalarRange() {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetScalarRange(p,obj);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkDataSet::GetMaxCellSize()
// 
public int GetMaxCellSize() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetMaxCellSize(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSet::GetDataObjectType()
// 
public int GetDataObjectType() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetDataObjectType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSet::ShallowCopy(vtkDataObject* src)
// 
public void ShallowCopy(vtkDataObject/*vtkDataObject* */ src) {
	VTK.API_vtkDataSet.ShallowCopy(obj, src);
}


//       Method: void vtkDataSet::DeepCopy(vtkDataObject* src)
// 
public void DeepCopy(vtkDataObject/*vtkDataObject* */ src) {
	VTK.API_vtkDataSet.DeepCopy(obj, src);
}


//       Method: int vtkDataSet::CheckAttributes()
// 
public int CheckAttributes() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.CheckAttributes(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkDataSet::GenerateGhostArray(int zeroExt[6])
// 
public void GenerateGhostArray(int[] /*6*/ zeroExt) {
	VTK.API_vtkDataSet.GenerateGhostArray(obj, zeroExt);
}


//       Method: virtual void vtkDataSet::GenerateGhostArray(int zeroExt[6], bool cellOnly)
// 
public void GenerateGhostArray(int[] /*6*/ zeroExt, bool cellOnly) {
	VTK.API_vtkDataSet.GenerateGhostArray(obj, zeroExt, cellOnly);
}


//       Method: static vtkDataSet * vtkDataSet::GetData(vtkInformation* info)
// 
public static vtkDataSet GetData(vtkInformation/*vtkInformation* */ info) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetData(p, info);
	vtkDataSet result = new vtkDataSet();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkDataSet * vtkDataSet::GetData(vtkInformationVector* v, int i)
// 
public static vtkDataSet GetData(vtkInformationVector/*vtkInformationVector* */ v, int i) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetData(p, v, i);
	vtkDataSet result = new vtkDataSet();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkFieldData * vtkDataSet::GetAttributesAsFieldData(int type)
// 
public vtkFieldData GetAttributesAsFieldData(int type) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetAttributesAsFieldData(p,obj, type);
	vtkFieldData result = new vtkFieldData();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkDataSet::GetNumberOfElements(int type)
// 
public long GetNumberOfElements(int type) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetNumberOfElements(p,obj, type);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: bool vtkDataSet::HasAnyGhostCells()
// 
public bool HasAnyGhostCells() {
	int numElements = 1;
	bool example = new bool();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.HasAnyGhostCells(p,obj);
	bool result = Convert.ToBoolean(Marshal.ReadByte(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: bool vtkDataSet::HasAnyGhostPoints()
// 
public bool HasAnyGhostPoints() {
	int numElements = 1;
	bool example = new bool();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.HasAnyGhostPoints(p,obj);
	bool result = Convert.ToBoolean(Marshal.ReadByte(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual bool vtkDataSet::HasAnyBlankCells()
// 
public bool HasAnyBlankCells() {
	int numElements = 1;
	bool example = new bool();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.HasAnyBlankCells(p,obj);
	bool result = Convert.ToBoolean(Marshal.ReadByte(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual bool vtkDataSet::HasAnyBlankPoints()
// 
public bool HasAnyBlankPoints() {
	int numElements = 1;
	bool example = new bool();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.HasAnyBlankPoints(p,obj);
	bool result = Convert.ToBoolean(Marshal.ReadByte(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkUnsignedCharArray * vtkDataSet::GetPointGhostArray()
// 
public vtkUnsignedCharArray GetPointGhostArray() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetPointGhostArray(p,obj);
	vtkUnsignedCharArray result = new vtkUnsignedCharArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSet::UpdatePointGhostArrayCache()
// 
public void UpdatePointGhostArrayCache() {
	VTK.API_vtkDataSet.UpdatePointGhostArrayCache(obj);
}


//       Method: vtkUnsignedCharArray * vtkDataSet::AllocatePointGhostArray()
// 
public vtkUnsignedCharArray AllocatePointGhostArray() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.AllocatePointGhostArray(p,obj);
	vtkUnsignedCharArray result = new vtkUnsignedCharArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkUnsignedCharArray * vtkDataSet::GetCellGhostArray()
// 
public vtkUnsignedCharArray GetCellGhostArray() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.GetCellGhostArray(p,obj);
	vtkUnsignedCharArray result = new vtkUnsignedCharArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSet::UpdateCellGhostArrayCache()
// 
public void UpdateCellGhostArrayCache() {
	VTK.API_vtkDataSet.UpdateCellGhostArrayCache(obj);
}


//       Method: vtkUnsignedCharArray * vtkDataSet::AllocateCellGhostArray()
// 
public vtkUnsignedCharArray AllocateCellGhostArray() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSet.AllocateCellGhostArray(p,obj);
	vtkUnsignedCharArray result = new vtkUnsignedCharArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
