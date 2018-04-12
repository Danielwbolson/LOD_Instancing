
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkPolyLine {

//       Method: static vtkPolyLine * vtkPolyLine::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkPolyLine_New_0")] public static extern 
bool New(IntPtr /*vtkPolyLine** */ ret);

//       Method: static int vtkPolyLine::GenerateSlidingNormals(vtkPoints* ARG_0, vtkCellArray* ARG_1, vtkDataArray* ARG_2)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkPolyLine_GenerateSlidingNormals_0")] public static extern 
bool GenerateSlidingNormals(IntPtr /*int* */ ret, IntPtr/*vtkPoints* */ ARG_0, IntPtr/*vtkCellArray* */ ARG_1, IntPtr/*vtkDataArray* */ ARG_2);

//       Method: static int vtkPolyLine::GenerateSlidingNormals(vtkPoints* ARG_0, vtkCellArray* ARG_1, vtkDataArray* ARG_2, double* firstNormal)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkPolyLine_GenerateSlidingNormals_1")] public static extern 
bool GenerateSlidingNormals(IntPtr /*int* */ ret, IntPtr/*vtkPoints* */ ARG_0, IntPtr/*vtkCellArray* */ ARG_1, IntPtr/*vtkDataArray* */ ARG_2, IntPtr/*double* */ firstNormal);

//       Method: int vtkPolyLine::GetCellType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyLine_GetCellType_0")] public static extern 
bool GetCellType(IntPtr /*int* */ ret, IntPtr /*vtkPolyLine* */ obj);

//       Method: int vtkPolyLine::GetCellDimension()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyLine_GetCellDimension_0")] public static extern 
bool GetCellDimension(IntPtr /*int* */ ret, IntPtr /*vtkPolyLine* */ obj);

//       Method: int vtkPolyLine::GetNumberOfEdges()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyLine_GetNumberOfEdges_0")] public static extern 
bool GetNumberOfEdges(IntPtr /*int* */ ret, IntPtr /*vtkPolyLine* */ obj);

//       Method: int vtkPolyLine::GetNumberOfFaces()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyLine_GetNumberOfFaces_0")] public static extern 
bool GetNumberOfFaces(IntPtr /*int* */ ret, IntPtr /*vtkPolyLine* */ obj);

//       Method: int vtkPolyLine::CellBoundary(int subId, double pcoords[3], vtkIdList* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyLine_CellBoundary_0")] public static extern 
bool CellBoundary(IntPtr /*int* */ ret, IntPtr /*vtkPolyLine* */ obj, int subId, double[] /*3*/ pcoords, IntPtr/*vtkIdList* */ pts);

//       Method: void vtkPolyLine::Contour(double value, vtkDataArray* cellScalars, vtkIncrementalPointLocator* locator, vtkCellArray* verts, vtkCellArray* lines, vtkCellArray* polys, vtkPointData* inPd, vtkPointData* outPd, vtkCellData* inCd, vtkIdType cellId, vtkCellData* outCd)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyLine_Contour_0")] public static extern 
bool Contour(IntPtr /*vtkPolyLine* */ obj, double value, IntPtr/*vtkDataArray* */ cellScalars, IntPtr/*vtkIncrementalPointLocator* */ locator, IntPtr/*vtkCellArray* */ verts, IntPtr/*vtkCellArray* */ lines, IntPtr/*vtkCellArray* */ polys, IntPtr/*vtkPointData* */ inPd, IntPtr/*vtkPointData* */ outPd, IntPtr/*vtkCellData* */ inCd, int cellId, IntPtr/*vtkCellData* */ outCd);

//       Method: void vtkPolyLine::Clip(double value, vtkDataArray* cellScalars, vtkIncrementalPointLocator* locator, vtkCellArray* lines, vtkPointData* inPd, vtkPointData* outPd, vtkCellData* inCd, vtkIdType cellId, vtkCellData* outCd, int insideOut)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyLine_Clip_0")] public static extern 
bool Clip(IntPtr /*vtkPolyLine* */ obj, double value, IntPtr/*vtkDataArray* */ cellScalars, IntPtr/*vtkIncrementalPointLocator* */ locator, IntPtr/*vtkCellArray* */ lines, IntPtr/*vtkPointData* */ inPd, IntPtr/*vtkPointData* */ outPd, IntPtr/*vtkCellData* */ inCd, int cellId, IntPtr/*vtkCellData* */ outCd, int insideOut);

//       Method: int vtkPolyLine::Triangulate(int index, vtkIdList* ptIds, vtkPoints* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyLine_Triangulate_0")] public static extern 
bool Triangulate(IntPtr /*int* */ ret, IntPtr /*vtkPolyLine* */ obj, int index, IntPtr/*vtkIdList* */ ptIds, IntPtr/*vtkPoints* */ pts);

//       Method: void vtkPolyLine::Derivatives(int subId, double pcoords[3], double* values, int dim, double* derivs)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyLine_Derivatives_0")] public static extern 
bool Derivatives(IntPtr /*vtkPolyLine* */ obj, int subId, double[] /*3*/ pcoords, IntPtr/*double* */ values, int dim, IntPtr/*double* */ derivs);

//       Method: int vtkPolyLine::IsPrimaryCell()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyLine_IsPrimaryCell_0")] public static extern 
bool IsPrimaryCell(IntPtr /*int* */ ret, IntPtr /*vtkPolyLine* */ obj);

//       Method: int vtkPolyLine::GetParametricCenter(double pcoords[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyLine_GetParametricCenter_0")] public static extern 
bool GetParametricCenter(IntPtr /*int* */ ret, IntPtr /*vtkPolyLine* */ obj, double[] /*3*/ pcoords);

}
};
