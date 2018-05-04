
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkGenericCell {

// static vtkGenericCell* New()
// static vtkGenericCell *New()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject, string /*(char*)*/ type);

// static vtkGenericCell* SafeDownCast(vtkObjectBase * o)
// static vtkGenericCell* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkGenericCell* NewInstance()
// vtkGenericCell *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetPoints(vtkPoints * points)
// void SetPoints(vtkPoints *points)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetPoints_0")] public static extern 
bool SetPoints_0(IntPtr /*(vtkGenericCell*)*/ callingObject, IntPtr /*(vtkPoints*)*/ points);

// void SetPointIds(vtkIdList * pointIds)
// void SetPointIds(vtkIdList *pointIds)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetPointIds_0")] public static extern 
bool SetPointIds_0(IntPtr /*(vtkGenericCell*)*/ callingObject, IntPtr /*(vtkIdList*)*/ pointIds);

// void ShallowCopy(vtkCell * c)
// void ShallowCopy(vtkCell *c)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkGenericCell*)*/ callingObject, IntPtr /*(vtkCell*)*/ c);

// void DeepCopy(vtkCell * c)
// void DeepCopy(vtkCell *c)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkGenericCell*)*/ callingObject, IntPtr /*(vtkCell*)*/ c);

// int GetCellType()
// int GetCellType()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_GetCellType_0")] public static extern 
bool GetCellType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject);

// int GetCellDimension()
// int GetCellDimension()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_GetCellDimension_0")] public static extern 
bool GetCellDimension_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject);

// int IsLinear()
// int IsLinear()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_IsLinear_0")] public static extern 
bool IsLinear_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject);

// int RequiresInitialization()
// int RequiresInitialization()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_RequiresInitialization_0")] public static extern 
bool RequiresInitialization_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// int RequiresExplicitFaceRepresentation()
// int RequiresExplicitFaceRepresentation()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_RequiresExplicitFaceRepresentation_0")] public static extern 
bool RequiresExplicitFaceRepresentation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetFaces(vtkIdType * faces)
// void SetFaces(vtkIdType *faces)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetFaces_0")] public static extern 
bool SetFaces_0(IntPtr /*(vtkGenericCell*)*/ callingObject, IntPtr /*(vtkIdType*)*/ faces);

// vtkIdType* GetFaces()
// vtkIdType *GetFaces()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_GetFaces_0")] public static extern 
bool GetFaces_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject);

// int GetNumberOfEdges()
// int GetNumberOfEdges()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_GetNumberOfEdges_0")] public static extern 
bool GetNumberOfEdges_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject);

// int GetNumberOfFaces()
// int GetNumberOfFaces()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_GetNumberOfFaces_0")] public static extern 
bool GetNumberOfFaces_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject);

// vtkCell* GetEdge(int edgeId)
// vtkCell *GetEdge(int edgeId)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_GetEdge_0")] public static extern 
bool GetEdge_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject, int /*(int)*/ edgeId);

// vtkCell* GetFace(int faceId)
// vtkCell *GetFace(int faceId)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_GetFace_0")] public static extern 
bool GetFace_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject, int /*(int)*/ faceId);

// int CellBoundary(int subId, double pcoords[3], vtkIdList * pts)
// int CellBoundary(int subId, double pcoords[3], vtkIdList *pts)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_CellBoundary_0")] public static extern 
bool CellBoundary_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject, int /*(int)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(vtkIdList*)*/ pts);

// int EvaluatePosition(double x[3], double * closestPoint, int & subId, double pcoords[3], double & dist2, double * weights)
// int EvaluatePosition(double x[3], double* closestPoint, int& subId, double pcoords[3], double& dist2, double *weights)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_EvaluatePosition_0")] public static extern 
bool EvaluatePosition_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(double*)*/ closestPoint, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double&)*/ dist2, IntPtr /*(double*)*/ weights);

// void EvaluateLocation(int & subId, double pcoords[3], double x[3], double * weights)
// void EvaluateLocation(int& subId, double pcoords[3], double x[3], double *weights)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_EvaluateLocation_0")] public static extern 
bool EvaluateLocation_0(IntPtr /*(vtkGenericCell*)*/ callingObject, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, double /*(double[3])*/ []x, IntPtr /*(double*)*/ weights);

// void Contour(double value, vtkDataArray * cellScalars, vtkIncrementalPointLocator * locator, vtkCellArray * verts, vtkCellArray * lines, vtkCellArray * polys, vtkPointData * inPd, vtkPointData * outPd, vtkCellData * inCd, vtkIdType cellId, vtkCellData * outCd)
// void Contour(double value, vtkDataArray *cellScalars, vtkIncrementalPointLocator *locator, vtkCellArray *verts, vtkCellArray *lines, vtkCellArray *polys, vtkPointData *inPd, vtkPointData *outPd, vtkCellData *inCd, vtkIdType cellId, vtkCellData *outCd)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_Contour_0")] public static extern 
bool Contour_0(IntPtr /*(vtkGenericCell*)*/ callingObject, double /*(double)*/ value, IntPtr /*(vtkDataArray*)*/ cellScalars, IntPtr /*(vtkIncrementalPointLocator*)*/ locator, IntPtr /*(vtkCellArray*)*/ verts, IntPtr /*(vtkCellArray*)*/ lines, IntPtr /*(vtkCellArray*)*/ polys, IntPtr /*(vtkPointData*)*/ inPd, IntPtr /*(vtkPointData*)*/ outPd, IntPtr /*(vtkCellData*)*/ inCd, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkCellData*)*/ outCd);

// void Clip(double value, vtkDataArray * cellScalars, vtkIncrementalPointLocator * locator, vtkCellArray * connectivity, vtkPointData * inPd, vtkPointData * outPd, vtkCellData * inCd, vtkIdType cellId, vtkCellData * outCd, int insideOut)
// void Clip(double value, vtkDataArray *cellScalars, vtkIncrementalPointLocator *locator, vtkCellArray *connectivity, vtkPointData *inPd, vtkPointData *outPd, vtkCellData *inCd, vtkIdType cellId, vtkCellData *outCd, int insideOut)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_Clip_0")] public static extern 
bool Clip_0(IntPtr /*(vtkGenericCell*)*/ callingObject, double /*(double)*/ value, IntPtr /*(vtkDataArray*)*/ cellScalars, IntPtr /*(vtkIncrementalPointLocator*)*/ locator, IntPtr /*(vtkCellArray*)*/ connectivity, IntPtr /*(vtkPointData*)*/ inPd, IntPtr /*(vtkPointData*)*/ outPd, IntPtr /*(vtkCellData*)*/ inCd, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkCellData*)*/ outCd, int /*(int)*/ insideOut);

// int IntersectWithLine(double p1[3], double p2[3], double tol, double & t, double x[3], double pcoords[3], int & subId)
// int IntersectWithLine(double p1[3], double p2[3], double tol, double& t, double x[3], double pcoords[3], int& subId)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_IntersectWithLine_0")] public static extern 
bool IntersectWithLine_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject, double /*(double[3])*/ []p1, double /*(double[3])*/ []p2, double /*(double)*/ tol, IntPtr /*(double&)*/ t, double /*(double[3])*/ []x, double /*(double[3])*/ []pcoords, IntPtr /*(int&)*/ subId);

// int Triangulate(int index, vtkIdList * ptIds, vtkPoints * pts)
// int Triangulate(int index, vtkIdList *ptIds, vtkPoints *pts)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_Triangulate_0")] public static extern 
bool Triangulate_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject, int /*(int)*/ index, IntPtr /*(vtkIdList*)*/ ptIds, IntPtr /*(vtkPoints*)*/ pts);

// void Derivatives(int subId, double pcoords[3], double * values, int dim, double * derivs)
// void Derivatives(int subId, double pcoords[3], double *values, int dim, double *derivs)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_Derivatives_0")] public static extern 
bool Derivatives_0(IntPtr /*(vtkGenericCell*)*/ callingObject, int /*(int)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ values, int /*(int)*/ dim, IntPtr /*(double*)*/ derivs);

// int GetParametricCenter(double pcoords[3])
// int GetParametricCenter(double pcoords[3])
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_GetParametricCenter_0")] public static extern 
bool GetParametricCenter_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject, double /*(double[3])*/ []pcoords);

// double* GetParametricCoords()
// double *GetParametricCoords()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_GetParametricCoords_0")] public static extern 
bool GetParametricCoords_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject);

// int IsPrimaryCell()
// int IsPrimaryCell()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_IsPrimaryCell_0")] public static extern 
bool IsPrimaryCell_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject);

// void InterpolateFunctions(double pcoords[3], double * weights)
// void InterpolateFunctions(double pcoords[3], double *weights)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_InterpolateFunctions_0")] public static extern 
bool InterpolateFunctions_0(IntPtr /*(vtkGenericCell*)*/ callingObject, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights);

// void InterpolateDerivs(double pcoords[3], double * derivs)
// void InterpolateDerivs(double pcoords[3], double *derivs)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_InterpolateDerivs_0")] public static extern 
bool InterpolateDerivs_0(IntPtr /*(vtkGenericCell*)*/ callingObject, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ derivs);

// void SetCellType(int cellType)
// void SetCellType(int cellType)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellType_0")] public static extern 
bool SetCellType_0(IntPtr /*(vtkGenericCell*)*/ callingObject, int /*(int)*/ cellType);

// void SetCellTypeToEmptyCell()
// void SetCellTypeToEmptyCell()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToEmptyCell_0")] public static extern 
bool SetCellTypeToEmptyCell_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToVertex()
// void SetCellTypeToVertex()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToVertex_0")] public static extern 
bool SetCellTypeToVertex_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToPolyVertex()
// void SetCellTypeToPolyVertex()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToPolyVertex_0")] public static extern 
bool SetCellTypeToPolyVertex_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToLine()
// void SetCellTypeToLine()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToLine_0")] public static extern 
bool SetCellTypeToLine_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToPolyLine()
// void SetCellTypeToPolyLine()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToPolyLine_0")] public static extern 
bool SetCellTypeToPolyLine_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToTriangle()
// void SetCellTypeToTriangle()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToTriangle_0")] public static extern 
bool SetCellTypeToTriangle_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToTriangleStrip()
// void SetCellTypeToTriangleStrip()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToTriangleStrip_0")] public static extern 
bool SetCellTypeToTriangleStrip_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToPolygon()
// void SetCellTypeToPolygon()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToPolygon_0")] public static extern 
bool SetCellTypeToPolygon_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToPixel()
// void SetCellTypeToPixel()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToPixel_0")] public static extern 
bool SetCellTypeToPixel_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToQuad()
// void SetCellTypeToQuad()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToQuad_0")] public static extern 
bool SetCellTypeToQuad_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToTetra()
// void SetCellTypeToTetra()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToTetra_0")] public static extern 
bool SetCellTypeToTetra_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToVoxel()
// void SetCellTypeToVoxel()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToVoxel_0")] public static extern 
bool SetCellTypeToVoxel_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToHexahedron()
// void SetCellTypeToHexahedron()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToHexahedron_0")] public static extern 
bool SetCellTypeToHexahedron_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToWedge()
// void SetCellTypeToWedge()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToWedge_0")] public static extern 
bool SetCellTypeToWedge_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToPyramid()
// void SetCellTypeToPyramid()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToPyramid_0")] public static extern 
bool SetCellTypeToPyramid_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToPentagonalPrism()
// void SetCellTypeToPentagonalPrism()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToPentagonalPrism_0")] public static extern 
bool SetCellTypeToPentagonalPrism_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToHexagonalPrism()
// void SetCellTypeToHexagonalPrism()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToHexagonalPrism_0")] public static extern 
bool SetCellTypeToHexagonalPrism_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToPolyhedron()
// void SetCellTypeToPolyhedron()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToPolyhedron_0")] public static extern 
bool SetCellTypeToPolyhedron_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToConvexPointSet()
// void SetCellTypeToConvexPointSet()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToConvexPointSet_0")] public static extern 
bool SetCellTypeToConvexPointSet_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToQuadraticEdge()
// void SetCellTypeToQuadraticEdge()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToQuadraticEdge_0")] public static extern 
bool SetCellTypeToQuadraticEdge_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToCubicLine()
// void SetCellTypeToCubicLine()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToCubicLine_0")] public static extern 
bool SetCellTypeToCubicLine_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToQuadraticTriangle()
// void SetCellTypeToQuadraticTriangle()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToQuadraticTriangle_0")] public static extern 
bool SetCellTypeToQuadraticTriangle_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToBiQuadraticTriangle()
// void SetCellTypeToBiQuadraticTriangle()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToBiQuadraticTriangle_0")] public static extern 
bool SetCellTypeToBiQuadraticTriangle_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToQuadraticQuad()
// void SetCellTypeToQuadraticQuad()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToQuadraticQuad_0")] public static extern 
bool SetCellTypeToQuadraticQuad_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToQuadraticPolygon()
// void SetCellTypeToQuadraticPolygon()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToQuadraticPolygon_0")] public static extern 
bool SetCellTypeToQuadraticPolygon_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToQuadraticTetra()
// void SetCellTypeToQuadraticTetra()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToQuadraticTetra_0")] public static extern 
bool SetCellTypeToQuadraticTetra_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToQuadraticHexahedron()
// void SetCellTypeToQuadraticHexahedron()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToQuadraticHexahedron_0")] public static extern 
bool SetCellTypeToQuadraticHexahedron_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToQuadraticWedge()
// void SetCellTypeToQuadraticWedge()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToQuadraticWedge_0")] public static extern 
bool SetCellTypeToQuadraticWedge_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToQuadraticPyramid()
// void SetCellTypeToQuadraticPyramid()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToQuadraticPyramid_0")] public static extern 
bool SetCellTypeToQuadraticPyramid_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToQuadraticLinearQuad()
// void SetCellTypeToQuadraticLinearQuad()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToQuadraticLinearQuad_0")] public static extern 
bool SetCellTypeToQuadraticLinearQuad_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToBiQuadraticQuad()
// void SetCellTypeToBiQuadraticQuad()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToBiQuadraticQuad_0")] public static extern 
bool SetCellTypeToBiQuadraticQuad_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToQuadraticLinearWedge()
// void SetCellTypeToQuadraticLinearWedge()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToQuadraticLinearWedge_0")] public static extern 
bool SetCellTypeToQuadraticLinearWedge_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToBiQuadraticQuadraticWedge()
// void SetCellTypeToBiQuadraticQuadraticWedge()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToBiQuadraticQuadraticWedge_0")] public static extern 
bool SetCellTypeToBiQuadraticQuadraticWedge_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToTriQuadraticHexahedron()
// void SetCellTypeToTriQuadraticHexahedron()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToTriQuadraticHexahedron_0")] public static extern 
bool SetCellTypeToTriQuadraticHexahedron_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToBiQuadraticQuadraticHexahedron()
// void SetCellTypeToBiQuadraticQuadraticHexahedron()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToBiQuadraticQuadraticHexahedron_0")] public static extern 
bool SetCellTypeToBiQuadraticQuadraticHexahedron_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToLagrangeTriangle()
// void SetCellTypeToLagrangeTriangle()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToLagrangeTriangle_0")] public static extern 
bool SetCellTypeToLagrangeTriangle_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToLagrangeTetra()
// void SetCellTypeToLagrangeTetra()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToLagrangeTetra_0")] public static extern 
bool SetCellTypeToLagrangeTetra_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToLagrangeCurve()
// void SetCellTypeToLagrangeCurve()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToLagrangeCurve_0")] public static extern 
bool SetCellTypeToLagrangeCurve_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToLagrangeQuadrilateral()
// void SetCellTypeToLagrangeQuadrilateral()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToLagrangeQuadrilateral_0")] public static extern 
bool SetCellTypeToLagrangeQuadrilateral_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToLagrangeHexahedron()
// void SetCellTypeToLagrangeHexahedron()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToLagrangeHexahedron_0")] public static extern 
bool SetCellTypeToLagrangeHexahedron_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// void SetCellTypeToLagrangeWedge()
// void SetCellTypeToLagrangeWedge()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_SetCellTypeToLagrangeWedge_0")] public static extern 
bool SetCellTypeToLagrangeWedge_0(IntPtr /*(vtkGenericCell*)*/ callingObject);

// static vtkCell* InstantiateCell(int cellType)
// static vtkCell* InstantiateCell(int cellType)
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_InstantiateCell_0")] public static extern 
bool InstantiateCell_0(IntPtr /*(IntPtr**)*/ return_value, int /*(int)*/ cellType);

// vtkCell* GetRepresentativeCell()
// vtkCell* GetRepresentativeCell()
[DllImport("vtkplugin", EntryPoint="vtkGenericCell_GetRepresentativeCell_0")] public static extern 
bool GetRepresentativeCell_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkGenericCell*)*/ callingObject);

}
};
