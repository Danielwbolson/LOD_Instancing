
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkGenericCell {

//       Method: static vtkGenericCell * vtkGenericCell::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkGenericCell_New_0")] public static extern 
bool New(IntPtr /*vtkGenericCell** */ ret);

//       Method: virtual const char * vtkGenericCell::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetPoints(vtkPoints* points)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetPoints_0")] public static extern 
bool SetPoints(IntPtr /*vtkGenericCell* */ obj, IntPtr/*vtkPoints* */ points);

//       Method: void vtkGenericCell::SetPointIds(vtkIdList* pointIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetPointIds_0")] public static extern 
bool SetPointIds(IntPtr /*vtkGenericCell* */ obj, IntPtr/*vtkIdList* */ pointIds);

//       Method: void vtkGenericCell::ShallowCopy(vtkCell* c)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_ShallowCopy_0")] public static extern 
bool ShallowCopy(IntPtr /*vtkGenericCell* */ obj, IntPtr/*vtkCell* */ c);

//       Method: void vtkGenericCell::DeepCopy(vtkCell* c)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkGenericCell* */ obj, IntPtr/*vtkCell* */ c);

//       Method: int vtkGenericCell::GetCellType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_GetCellType_0")] public static extern 
bool GetCellType(IntPtr /*int* */ ret, IntPtr /*vtkGenericCell* */ obj);

//       Method: int vtkGenericCell::GetCellDimension()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_GetCellDimension_0")] public static extern 
bool GetCellDimension(IntPtr /*int* */ ret, IntPtr /*vtkGenericCell* */ obj);

//       Method: int vtkGenericCell::IsLinear()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_IsLinear_0")] public static extern 
bool IsLinear(IntPtr /*int* */ ret, IntPtr /*vtkGenericCell* */ obj);

//       Method: int vtkGenericCell::RequiresInitialization()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_RequiresInitialization_0")] public static extern 
bool RequiresInitialization(IntPtr /*int* */ ret, IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkGenericCell* */ obj);

//       Method: int vtkGenericCell::RequiresExplicitFaceRepresentation()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_RequiresExplicitFaceRepresentation_0")] public static extern 
bool RequiresExplicitFaceRepresentation(IntPtr /*int* */ ret, IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetFaces(vtkIdType* faces)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetFaces_0")] public static extern 
bool SetFaces(IntPtr /*vtkGenericCell* */ obj, IntPtr/*vtkIdType* */ faces);

//       Method: vtkIdType * vtkGenericCell::GetFaces()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_GetFaces_0")] public static extern 
bool GetFaces(IntPtr /*vtkIdType** */ ret, IntPtr /*vtkGenericCell* */ obj);

//       Method: int vtkGenericCell::GetNumberOfEdges()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_GetNumberOfEdges_0")] public static extern 
bool GetNumberOfEdges(IntPtr /*int* */ ret, IntPtr /*vtkGenericCell* */ obj);

//       Method: int vtkGenericCell::GetNumberOfFaces()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_GetNumberOfFaces_0")] public static extern 
bool GetNumberOfFaces(IntPtr /*int* */ ret, IntPtr /*vtkGenericCell* */ obj);

//       Method: vtkCell * vtkGenericCell::GetEdge(int edgeId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_GetEdge_0")] public static extern 
bool GetEdge(IntPtr /*vtkCell** */ ret, IntPtr /*vtkGenericCell* */ obj, int edgeId);

//       Method: vtkCell * vtkGenericCell::GetFace(int faceId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_GetFace_0")] public static extern 
bool GetFace(IntPtr /*vtkCell** */ ret, IntPtr /*vtkGenericCell* */ obj, int faceId);

//       Method: int vtkGenericCell::CellBoundary(int subId, double pcoords[3], vtkIdList* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_CellBoundary_0")] public static extern 
bool CellBoundary(IntPtr /*int* */ ret, IntPtr /*vtkGenericCell* */ obj, int subId, double[] /*3*/ pcoords, IntPtr/*vtkIdList* */ pts);

//       Method: void vtkGenericCell::Contour(double value, vtkDataArray* cellScalars, vtkIncrementalPointLocator* locator, vtkCellArray* verts, vtkCellArray* lines, vtkCellArray* polys, vtkPointData* inPd, vtkPointData* outPd, vtkCellData* inCd, vtkIdType cellId, vtkCellData* outCd)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_Contour_0")] public static extern 
bool Contour(IntPtr /*vtkGenericCell* */ obj, double value, IntPtr/*vtkDataArray* */ cellScalars, IntPtr/*vtkIncrementalPointLocator* */ locator, IntPtr/*vtkCellArray* */ verts, IntPtr/*vtkCellArray* */ lines, IntPtr/*vtkCellArray* */ polys, IntPtr/*vtkPointData* */ inPd, IntPtr/*vtkPointData* */ outPd, IntPtr/*vtkCellData* */ inCd, long cellId, IntPtr/*vtkCellData* */ outCd);

//       Method: void vtkGenericCell::Clip(double value, vtkDataArray* cellScalars, vtkIncrementalPointLocator* locator, vtkCellArray* connectivity, vtkPointData* inPd, vtkPointData* outPd, vtkCellData* inCd, vtkIdType cellId, vtkCellData* outCd, int insideOut)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_Clip_0")] public static extern 
bool Clip(IntPtr /*vtkGenericCell* */ obj, double value, IntPtr/*vtkDataArray* */ cellScalars, IntPtr/*vtkIncrementalPointLocator* */ locator, IntPtr/*vtkCellArray* */ connectivity, IntPtr/*vtkPointData* */ inPd, IntPtr/*vtkPointData* */ outPd, IntPtr/*vtkCellData* */ inCd, long cellId, IntPtr/*vtkCellData* */ outCd, int insideOut);

//       Method: int vtkGenericCell::Triangulate(int index, vtkIdList* ptIds, vtkPoints* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_Triangulate_0")] public static extern 
bool Triangulate(IntPtr /*int* */ ret, IntPtr /*vtkGenericCell* */ obj, int index, IntPtr/*vtkIdList* */ ptIds, IntPtr/*vtkPoints* */ pts);

//       Method: void vtkGenericCell::Derivatives(int subId, double pcoords[3], double* values, int dim, double* derivs)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_Derivatives_0")] public static extern 
bool Derivatives(IntPtr /*vtkGenericCell* */ obj, int subId, double[] /*3*/ pcoords, IntPtr/*double* */ values, int dim, IntPtr/*double* */ derivs);

//       Method: int vtkGenericCell::GetParametricCenter(double pcoords[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_GetParametricCenter_0")] public static extern 
bool GetParametricCenter(IntPtr /*int* */ ret, IntPtr /*vtkGenericCell* */ obj, double[] /*3*/ pcoords);

//       Method: double * vtkGenericCell::GetParametricCoords()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_GetParametricCoords_0")] public static extern 
bool GetParametricCoords(IntPtr /*double** */ ret, IntPtr /*vtkGenericCell* */ obj);

//       Method: int vtkGenericCell::IsPrimaryCell()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_IsPrimaryCell_0")] public static extern 
bool IsPrimaryCell(IntPtr /*int* */ ret, IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::InterpolateFunctions(double pcoords[3], double* weights)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_InterpolateFunctions_0")] public static extern 
bool InterpolateFunctions(IntPtr /*vtkGenericCell* */ obj, double[] /*3*/ pcoords, IntPtr/*double* */ weights);

//       Method: void vtkGenericCell::InterpolateDerivs(double pcoords[3], double* derivs)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_InterpolateDerivs_0")] public static extern 
bool InterpolateDerivs(IntPtr /*vtkGenericCell* */ obj, double[] /*3*/ pcoords, IntPtr/*double* */ derivs);

//       Method: void vtkGenericCell::SetCellType(int cellType)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellType_0")] public static extern 
bool SetCellType(IntPtr /*vtkGenericCell* */ obj, int cellType);

//       Method: void vtkGenericCell::SetCellTypeToEmptyCell()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToEmptyCell_0")] public static extern 
bool SetCellTypeToEmptyCell(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToVertex()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToVertex_0")] public static extern 
bool SetCellTypeToVertex(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToPolyVertex()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToPolyVertex_0")] public static extern 
bool SetCellTypeToPolyVertex(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToLine()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToLine_0")] public static extern 
bool SetCellTypeToLine(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToPolyLine()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToPolyLine_0")] public static extern 
bool SetCellTypeToPolyLine(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToTriangle()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToTriangle_0")] public static extern 
bool SetCellTypeToTriangle(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToTriangleStrip()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToTriangleStrip_0")] public static extern 
bool SetCellTypeToTriangleStrip(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToPolygon()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToPolygon_0")] public static extern 
bool SetCellTypeToPolygon(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToPixel()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToPixel_0")] public static extern 
bool SetCellTypeToPixel(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToQuad()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToQuad_0")] public static extern 
bool SetCellTypeToQuad(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToTetra()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToTetra_0")] public static extern 
bool SetCellTypeToTetra(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToVoxel()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToVoxel_0")] public static extern 
bool SetCellTypeToVoxel(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToHexahedron()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToHexahedron_0")] public static extern 
bool SetCellTypeToHexahedron(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToWedge()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToWedge_0")] public static extern 
bool SetCellTypeToWedge(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToPyramid()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToPyramid_0")] public static extern 
bool SetCellTypeToPyramid(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToPentagonalPrism()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToPentagonalPrism_0")] public static extern 
bool SetCellTypeToPentagonalPrism(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToHexagonalPrism()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToHexagonalPrism_0")] public static extern 
bool SetCellTypeToHexagonalPrism(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToPolyhedron()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToPolyhedron_0")] public static extern 
bool SetCellTypeToPolyhedron(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToConvexPointSet()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToConvexPointSet_0")] public static extern 
bool SetCellTypeToConvexPointSet(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToQuadraticEdge()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToQuadraticEdge_0")] public static extern 
bool SetCellTypeToQuadraticEdge(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToCubicLine()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToCubicLine_0")] public static extern 
bool SetCellTypeToCubicLine(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToQuadraticTriangle()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToQuadraticTriangle_0")] public static extern 
bool SetCellTypeToQuadraticTriangle(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToBiQuadraticTriangle()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToBiQuadraticTriangle_0")] public static extern 
bool SetCellTypeToBiQuadraticTriangle(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToQuadraticQuad()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToQuadraticQuad_0")] public static extern 
bool SetCellTypeToQuadraticQuad(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToQuadraticPolygon()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToQuadraticPolygon_0")] public static extern 
bool SetCellTypeToQuadraticPolygon(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToQuadraticTetra()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToQuadraticTetra_0")] public static extern 
bool SetCellTypeToQuadraticTetra(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToQuadraticHexahedron()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToQuadraticHexahedron_0")] public static extern 
bool SetCellTypeToQuadraticHexahedron(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToQuadraticWedge()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToQuadraticWedge_0")] public static extern 
bool SetCellTypeToQuadraticWedge(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToQuadraticPyramid()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToQuadraticPyramid_0")] public static extern 
bool SetCellTypeToQuadraticPyramid(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToQuadraticLinearQuad()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToQuadraticLinearQuad_0")] public static extern 
bool SetCellTypeToQuadraticLinearQuad(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToBiQuadraticQuad()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToBiQuadraticQuad_0")] public static extern 
bool SetCellTypeToBiQuadraticQuad(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToQuadraticLinearWedge()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToQuadraticLinearWedge_0")] public static extern 
bool SetCellTypeToQuadraticLinearWedge(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToBiQuadraticQuadraticWedge()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToBiQuadraticQuadraticWedge_0")] public static extern 
bool SetCellTypeToBiQuadraticQuadraticWedge(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToTriQuadraticHexahedron()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToTriQuadraticHexahedron_0")] public static extern 
bool SetCellTypeToTriQuadraticHexahedron(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToBiQuadraticQuadraticHexahedron()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToBiQuadraticQuadraticHexahedron_0")] public static extern 
bool SetCellTypeToBiQuadraticQuadraticHexahedron(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToLagrangeTriangle()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToLagrangeTriangle_0")] public static extern 
bool SetCellTypeToLagrangeTriangle(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToLagrangeTetra()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToLagrangeTetra_0")] public static extern 
bool SetCellTypeToLagrangeTetra(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToLagrangeCurve()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToLagrangeCurve_0")] public static extern 
bool SetCellTypeToLagrangeCurve(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToLagrangeQuadrilateral()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToLagrangeQuadrilateral_0")] public static extern 
bool SetCellTypeToLagrangeQuadrilateral(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToLagrangeHexahedron()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToLagrangeHexahedron_0")] public static extern 
bool SetCellTypeToLagrangeHexahedron(IntPtr /*vtkGenericCell* */ obj);

//       Method: void vtkGenericCell::SetCellTypeToLagrangeWedge()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_SetCellTypeToLagrangeWedge_0")] public static extern 
bool SetCellTypeToLagrangeWedge(IntPtr /*vtkGenericCell* */ obj);

//       Method: static vtkCell * vtkGenericCell::InstantiateCell(int cellType)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkGenericCell_InstantiateCell_0")] public static extern 
bool InstantiateCell(IntPtr /*vtkCell** */ ret, int cellType);

//       Method: vtkCell * vtkGenericCell::GetRepresentativeCell()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkGenericCell_GetRepresentativeCell_0")] public static extern 
bool GetRepresentativeCell(IntPtr /*vtkCell** */ ret, IntPtr /*vtkGenericCell* */ obj);

}
};
