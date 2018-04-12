
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkCell {

//       Method: virtual const char * vtkCell::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkCell* */ obj);

//       Method: void vtkCell::Initialize(int npts, vtkIdType* pts, vtkPoints* p)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkCell* */ obj, int npts, IntPtr/*vtkIdType* */ pts, IntPtr/*vtkPoints* */ p);

//       Method: void vtkCell::Initialize(int npts, vtkPoints* p)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_Initialize_1")] public static extern 
bool Initialize(IntPtr /*vtkCell* */ obj, int npts, IntPtr/*vtkPoints* */ p);

//       Method: virtual void vtkCell::ShallowCopy(vtkCell* c)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_ShallowCopy_0")] public static extern 
bool ShallowCopy(IntPtr /*vtkCell* */ obj, IntPtr/*vtkCell* */ c);

//       Method: virtual void vtkCell::DeepCopy(vtkCell* c)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkCell* */ obj, IntPtr/*vtkCell* */ c);

//       Method: virtual int vtkCell::GetCellType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetCellType_0")] public static extern 
bool GetCellType(IntPtr /*int* */ ret, IntPtr /*vtkCell* */ obj);

//       Method: virtual int vtkCell::GetCellDimension()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetCellDimension_0")] public static extern 
bool GetCellDimension(IntPtr /*int* */ ret, IntPtr /*vtkCell* */ obj);

//       Method: virtual int vtkCell::IsLinear()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_IsLinear_0")] public static extern 
bool IsLinear(IntPtr /*int* */ ret, IntPtr /*vtkCell* */ obj);

//       Method: virtual int vtkCell::RequiresInitialization()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_RequiresInitialization_0")] public static extern 
bool RequiresInitialization(IntPtr /*int* */ ret, IntPtr /*vtkCell* */ obj);

//       Method: virtual void vtkCell::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_Initialize_2")] public static extern 
bool Initialize(IntPtr /*vtkCell* */ obj);

//       Method: virtual int vtkCell::IsExplicitCell()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_IsExplicitCell_0")] public static extern 
bool IsExplicitCell(IntPtr /*int* */ ret, IntPtr /*vtkCell* */ obj);

//       Method: virtual int vtkCell::RequiresExplicitFaceRepresentation()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_RequiresExplicitFaceRepresentation_0")] public static extern 
bool RequiresExplicitFaceRepresentation(IntPtr /*int* */ ret, IntPtr /*vtkCell* */ obj);

//       Method: virtual vtkIdType * vtkCell::GetFaces()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetFaces_0")] public static extern 
bool GetFaces(IntPtr /*vtkIdType** */ ret, IntPtr /*vtkCell* */ obj);

//       Method: vtkPoints * vtkCell::GetPoints()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetPoints_0")] public static extern 
bool GetPoints(IntPtr /*vtkPoints** */ ret, IntPtr /*vtkCell* */ obj);

//       Method: vtkIdType vtkCell::GetNumberOfPoints()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCell* */ obj);

//       Method: virtual int vtkCell::GetNumberOfEdges()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetNumberOfEdges_0")] public static extern 
bool GetNumberOfEdges(IntPtr /*int* */ ret, IntPtr /*vtkCell* */ obj);

//       Method: virtual int vtkCell::GetNumberOfFaces()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetNumberOfFaces_0")] public static extern 
bool GetNumberOfFaces(IntPtr /*int* */ ret, IntPtr /*vtkCell* */ obj);

//       Method: vtkIdList * vtkCell::GetPointIds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetPointIds_0")] public static extern 
bool GetPointIds(IntPtr /*vtkIdList** */ ret, IntPtr /*vtkCell* */ obj);

//       Method: vtkIdType vtkCell::GetPointId(int ptId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetPointId_0")] public static extern 
bool GetPointId(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCell* */ obj, int ptId);

//       Method: virtual vtkCell * vtkCell::GetEdge(int edgeId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetEdge_0")] public static extern 
bool GetEdge(IntPtr /*vtkCell** */ ret, IntPtr /*vtkCell* */ obj, int edgeId);

//       Method: virtual vtkCell * vtkCell::GetFace(int faceId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetFace_0")] public static extern 
bool GetFace(IntPtr /*vtkCell** */ ret, IntPtr /*vtkCell* */ obj, int faceId);

//       Method: virtual int vtkCell::CellBoundary(int subId, double pcoords[3], vtkIdList* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_CellBoundary_0")] public static extern 
bool CellBoundary(IntPtr /*int* */ ret, IntPtr /*vtkCell* */ obj, int subId, double[] /*3*/ pcoords, IntPtr/*vtkIdList* */ pts);

//       Method: virtual void vtkCell::Contour(double value, vtkDataArray* cellScalars, vtkIncrementalPointLocator* locator, vtkCellArray* verts, vtkCellArray* lines, vtkCellArray* polys, vtkPointData* inPd, vtkPointData* outPd, vtkCellData* inCd, vtkIdType cellId, vtkCellData* outCd)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_Contour_0")] public static extern 
bool Contour(IntPtr /*vtkCell* */ obj, double value, IntPtr/*vtkDataArray* */ cellScalars, IntPtr/*vtkIncrementalPointLocator* */ locator, IntPtr/*vtkCellArray* */ verts, IntPtr/*vtkCellArray* */ lines, IntPtr/*vtkCellArray* */ polys, IntPtr/*vtkPointData* */ inPd, IntPtr/*vtkPointData* */ outPd, IntPtr/*vtkCellData* */ inCd, long cellId, IntPtr/*vtkCellData* */ outCd);

//       Method: virtual void vtkCell::Clip(double value, vtkDataArray* cellScalars, vtkIncrementalPointLocator* locator, vtkCellArray* connectivity, vtkPointData* inPd, vtkPointData* outPd, vtkCellData* inCd, vtkIdType cellId, vtkCellData* outCd, int insideOut)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_Clip_0")] public static extern 
bool Clip(IntPtr /*vtkCell* */ obj, double value, IntPtr/*vtkDataArray* */ cellScalars, IntPtr/*vtkIncrementalPointLocator* */ locator, IntPtr/*vtkCellArray* */ connectivity, IntPtr/*vtkPointData* */ inPd, IntPtr/*vtkPointData* */ outPd, IntPtr/*vtkCellData* */ inCd, long cellId, IntPtr/*vtkCellData* */ outCd, int insideOut);

//       Method: virtual int vtkCell::Triangulate(int index, vtkIdList* ptIds, vtkPoints* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_Triangulate_0")] public static extern 
bool Triangulate(IntPtr /*int* */ ret, IntPtr /*vtkCell* */ obj, int index, IntPtr/*vtkIdList* */ ptIds, IntPtr/*vtkPoints* */ pts);

//       Method: virtual void vtkCell::Derivatives(int subId, double pcoords[3], double* values, int dim, double* derivs)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_Derivatives_0")] public static extern 
bool Derivatives(IntPtr /*vtkCell* */ obj, int subId, double[] /*3*/ pcoords, IntPtr/*double* */ values, int dim, IntPtr/*double* */ derivs);

//       Method: void vtkCell::GetBounds(double bounds[6])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetBounds_0")] public static extern 
bool GetBounds(IntPtr /*vtkCell* */ obj, double[] /*6*/ bounds);

//       Method: double * vtkCell::GetBounds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetBounds_1")] public static extern 
bool GetBounds(IntPtr /*double** */ ret, IntPtr /*vtkCell* */ obj);

//       Method: double vtkCell::GetLength2()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetLength2_0")] public static extern 
bool GetLength2(IntPtr /*double* */ ret, IntPtr /*vtkCell* */ obj);

//       Method: virtual int vtkCell::GetParametricCenter(double pcoords[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetParametricCenter_0")] public static extern 
bool GetParametricCenter(IntPtr /*int* */ ret, IntPtr /*vtkCell* */ obj, double[] /*3*/ pcoords);

//       Method: virtual double vtkCell::GetParametricDistance(double pcoords[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetParametricDistance_0")] public static extern 
bool GetParametricDistance(IntPtr /*double* */ ret, IntPtr /*vtkCell* */ obj, double[] /*3*/ pcoords);

//       Method: virtual int vtkCell::IsPrimaryCell()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_IsPrimaryCell_0")] public static extern 
bool IsPrimaryCell(IntPtr /*int* */ ret, IntPtr /*vtkCell* */ obj);

//       Method: virtual double * vtkCell::GetParametricCoords()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCell_GetParametricCoords_0")] public static extern 
bool GetParametricCoords(IntPtr /*double** */ ret, IntPtr /*vtkCell* */ obj);

}
};
