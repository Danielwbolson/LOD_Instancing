
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkCell {

// void Initialize(int npts, vtkIdType * pts, vtkPoints * p)
// void Initialize(int npts, vtkIdType *pts, vtkPoints *p)
[DllImport("vtkplugin", EntryPoint="vtkCell_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkCell*)*/ callingObject, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts, IntPtr /*(vtkPoints*)*/ p);

// void Initialize(int npts, vtkPoints * p)
// void Initialize(int npts, vtkPoints *p)
[DllImport("vtkplugin", EntryPoint="vtkCell_Initialize_1")] public static extern 
bool Initialize_1(IntPtr /*(vtkCell*)*/ callingObject, int /*(int)*/ npts, IntPtr /*(vtkPoints*)*/ p);

// virtual void ShallowCopy(vtkCell * c)
// virtual void ShallowCopy(vtkCell *c)
[DllImport("vtkplugin", EntryPoint="vtkCell_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkCell*)*/ callingObject, IntPtr /*(vtkCell*)*/ c);

// virtual void DeepCopy(vtkCell * c)
// virtual void DeepCopy(vtkCell *c)
[DllImport("vtkplugin", EntryPoint="vtkCell_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkCell*)*/ callingObject, IntPtr /*(vtkCell*)*/ c);

// virtual int GetCellType()
// virtual int GetCellType()
[DllImport("vtkplugin", EntryPoint="vtkCell_GetCellType_0")] public static extern 
bool GetCellType_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// virtual int GetCellDimension()
// virtual int GetCellDimension()
[DllImport("vtkplugin", EntryPoint="vtkCell_GetCellDimension_0")] public static extern 
bool GetCellDimension_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// virtual int IsLinear()
// virtual int IsLinear()
[DllImport("vtkplugin", EntryPoint="vtkCell_IsLinear_0")] public static extern 
bool IsLinear_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// virtual int RequiresInitialization()
// virtual int RequiresInitialization()
[DllImport("vtkplugin", EntryPoint="vtkCell_RequiresInitialization_0")] public static extern 
bool RequiresInitialization_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// virtual void Initialize()
// virtual void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkCell_Initialize_2")] public static extern 
bool Initialize_2(IntPtr /*(vtkCell*)*/ callingObject);

// virtual int IsExplicitCell()
// virtual int IsExplicitCell()
[DllImport("vtkplugin", EntryPoint="vtkCell_IsExplicitCell_0")] public static extern 
bool IsExplicitCell_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// virtual int RequiresExplicitFaceRepresentation()
// virtual int RequiresExplicitFaceRepresentation()
[DllImport("vtkplugin", EntryPoint="vtkCell_RequiresExplicitFaceRepresentation_0")] public static extern 
bool RequiresExplicitFaceRepresentation_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// virtual vtkIdType* GetFaces()
// virtual vtkIdType *GetFaces()
[DllImport("vtkplugin", EntryPoint="vtkCell_GetFaces_0")] public static extern 
bool GetFaces_0(IntPtr /*(vtkIdType**)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// vtkPoints* GetPoints()
// vtkPoints *GetPoints()
[DllImport("vtkplugin", EntryPoint="vtkCell_GetPoints_0")] public static extern 
bool GetPoints_0(IntPtr /*(vtkPoints**)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkCell_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// virtual int GetNumberOfEdges()
// virtual int GetNumberOfEdges()
[DllImport("vtkplugin", EntryPoint="vtkCell_GetNumberOfEdges_0")] public static extern 
bool GetNumberOfEdges_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// virtual int GetNumberOfFaces()
// virtual int GetNumberOfFaces()
[DllImport("vtkplugin", EntryPoint="vtkCell_GetNumberOfFaces_0")] public static extern 
bool GetNumberOfFaces_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// vtkIdList* GetPointIds()
// vtkIdList *GetPointIds()
[DllImport("vtkplugin", EntryPoint="vtkCell_GetPointIds_0")] public static extern 
bool GetPointIds_0(IntPtr /*(vtkIdList**)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// vtkIdType GetPointId(int ptId)
// vtkIdType GetPointId(int ptId)
[DllImport("vtkplugin", EntryPoint="vtkCell_GetPointId_0")] public static extern 
bool GetPointId_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject, int /*(int)*/ ptId);

// virtual vtkCell* GetEdge(int edgeId)
// virtual vtkCell *GetEdge(int edgeId)
[DllImport("vtkplugin", EntryPoint="vtkCell_GetEdge_0")] public static extern 
bool GetEdge_0(IntPtr /*(vtkCell**)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject, int /*(int)*/ edgeId);

// virtual vtkCell* GetFace(int faceId)
// virtual vtkCell *GetFace(int faceId)
[DllImport("vtkplugin", EntryPoint="vtkCell_GetFace_0")] public static extern 
bool GetFace_0(IntPtr /*(vtkCell**)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject, int /*(int)*/ faceId);

// virtual int CellBoundary(int subId, double pcoords[3], vtkIdList * pts)
// virtual int CellBoundary(int subId, double pcoords[3], vtkIdList *pts)
[DllImport("vtkplugin", EntryPoint="vtkCell_CellBoundary_0")] public static extern 
bool CellBoundary_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject, int /*(int)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(vtkIdList*)*/ pts);

// virtual int EvaluatePosition(double x[3], double * closestPoint, int & subId, double pcoords[3], double & dist2, double * weights)
// virtual int EvaluatePosition(double x[3], double* closestPoint, int& subId, double pcoords[3], double& dist2, double *weights)
[DllImport("vtkplugin", EntryPoint="vtkCell_EvaluatePosition_0")] public static extern 
bool EvaluatePosition_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(double*)*/ closestPoint, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double&)*/ dist2, IntPtr /*(double*)*/ weights);

// virtual void EvaluateLocation(int & subId, double pcoords[3], double x[3], double * weights)
// virtual void EvaluateLocation(int& subId, double pcoords[3], double x[3], double *weights)
[DllImport("vtkplugin", EntryPoint="vtkCell_EvaluateLocation_0")] public static extern 
bool EvaluateLocation_0(IntPtr /*(vtkCell*)*/ callingObject, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, double /*(double[3])*/ []x, IntPtr /*(double*)*/ weights);

// virtual void Contour(double value, vtkDataArray * cellScalars, vtkIncrementalPointLocator * locator, vtkCellArray * verts, vtkCellArray * lines, vtkCellArray * polys, vtkPointData * inPd, vtkPointData * outPd, vtkCellData * inCd, vtkIdType cellId, vtkCellData * outCd)
// virtual void Contour(double value, vtkDataArray *cellScalars, vtkIncrementalPointLocator *locator, vtkCellArray *verts, vtkCellArray *lines, vtkCellArray *polys, vtkPointData *inPd, vtkPointData *outPd, vtkCellData *inCd, vtkIdType cellId, vtkCellData *outCd)
[DllImport("vtkplugin", EntryPoint="vtkCell_Contour_0")] public static extern 
bool Contour_0(IntPtr /*(vtkCell*)*/ callingObject, double /*(double)*/ value, IntPtr /*(vtkDataArray*)*/ cellScalars, IntPtr /*(vtkIncrementalPointLocator*)*/ locator, IntPtr /*(vtkCellArray*)*/ verts, IntPtr /*(vtkCellArray*)*/ lines, IntPtr /*(vtkCellArray*)*/ polys, IntPtr /*(vtkPointData*)*/ inPd, IntPtr /*(vtkPointData*)*/ outPd, IntPtr /*(vtkCellData*)*/ inCd, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkCellData*)*/ outCd);

// virtual void Clip(double value, vtkDataArray * cellScalars, vtkIncrementalPointLocator * locator, vtkCellArray * connectivity, vtkPointData * inPd, vtkPointData * outPd, vtkCellData * inCd, vtkIdType cellId, vtkCellData * outCd, int insideOut)
// virtual void Clip(double value, vtkDataArray *cellScalars, vtkIncrementalPointLocator *locator, vtkCellArray *connectivity, vtkPointData *inPd, vtkPointData *outPd, vtkCellData *inCd, vtkIdType cellId, vtkCellData *outCd, int insideOut)
[DllImport("vtkplugin", EntryPoint="vtkCell_Clip_0")] public static extern 
bool Clip_0(IntPtr /*(vtkCell*)*/ callingObject, double /*(double)*/ value, IntPtr /*(vtkDataArray*)*/ cellScalars, IntPtr /*(vtkIncrementalPointLocator*)*/ locator, IntPtr /*(vtkCellArray*)*/ connectivity, IntPtr /*(vtkPointData*)*/ inPd, IntPtr /*(vtkPointData*)*/ outPd, IntPtr /*(vtkCellData*)*/ inCd, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkCellData*)*/ outCd, int /*(int)*/ insideOut);

// virtual int IntersectWithLine(double p1[3], double p2[3], double tol, double & t, double x[3], double pcoords[3], int & subId)
// virtual int IntersectWithLine(double p1[3], double p2[3], double tol, double& t, double x[3], double pcoords[3], int& subId)
[DllImport("vtkplugin", EntryPoint="vtkCell_IntersectWithLine_0")] public static extern 
bool IntersectWithLine_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject, double /*(double[3])*/ []p1, double /*(double[3])*/ []p2, double /*(double)*/ tol, IntPtr /*(double&)*/ t, double /*(double[3])*/ []x, double /*(double[3])*/ []pcoords, IntPtr /*(int&)*/ subId);

// virtual int Triangulate(int index, vtkIdList * ptIds, vtkPoints * pts)
// virtual int Triangulate(int index, vtkIdList *ptIds, vtkPoints *pts)
[DllImport("vtkplugin", EntryPoint="vtkCell_Triangulate_0")] public static extern 
bool Triangulate_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject, int /*(int)*/ index, IntPtr /*(vtkIdList*)*/ ptIds, IntPtr /*(vtkPoints*)*/ pts);

// virtual void Derivatives(int subId, double pcoords[3], double * values, int dim, double * derivs)
// virtual void Derivatives(int subId, double pcoords[3], double *values, int dim, double *derivs)
[DllImport("vtkplugin", EntryPoint="vtkCell_Derivatives_0")] public static extern 
bool Derivatives_0(IntPtr /*(vtkCell*)*/ callingObject, int /*(int)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ values, int /*(int)*/ dim, IntPtr /*(double*)*/ derivs);

// void GetBounds(double bounds[6])
// void GetBounds(double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkCell_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(vtkCell*)*/ callingObject, double /*(double[6])*/ []bounds);

// double* GetBounds()
// double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkCell_GetBounds_1")] public static extern 
bool GetBounds_1(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// double GetLength2()
// double GetLength2()
[DllImport("vtkplugin", EntryPoint="vtkCell_GetLength2_0")] public static extern 
bool GetLength2_0(IntPtr /*(double*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// virtual int GetParametricCenter(double pcoords[3])
// virtual int GetParametricCenter(double pcoords[3])
[DllImport("vtkplugin", EntryPoint="vtkCell_GetParametricCenter_0")] public static extern 
bool GetParametricCenter_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject, double /*(double[3])*/ []pcoords);

// virtual double GetParametricDistance(double pcoords[3])
// virtual double GetParametricDistance(double pcoords[3])
[DllImport("vtkplugin", EntryPoint="vtkCell_GetParametricDistance_0")] public static extern 
bool GetParametricDistance_0(IntPtr /*(double*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject, double /*(double[3])*/ []pcoords);

// virtual int IsPrimaryCell()
// virtual int IsPrimaryCell()
[DllImport("vtkplugin", EntryPoint="vtkCell_IsPrimaryCell_0")] public static extern 
bool IsPrimaryCell_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

// virtual double* GetParametricCoords()
// virtual double *GetParametricCoords()
[DllImport("vtkplugin", EntryPoint="vtkCell_GetParametricCoords_0")] public static extern 
bool GetParametricCoords_0(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkCell*)*/ callingObject);

}
};
