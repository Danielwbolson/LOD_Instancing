
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkImageData {

// static vtkImageData* New()
// static vtkImageData *New()
[DllImport("vtkplugin", EntryPoint="vtkImageData_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkImageData_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkImageData_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, string /*(char*)*/ type);

// static vtkImageData* SafeDownCast(vtkObjectBase * o)
// static vtkImageData* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkImageData_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkImageData* NewInstance()
// vtkImageData *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkImageData_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// void CopyStructure(vtkDataSet * ds)
// void CopyStructure(vtkDataSet *ds)
[DllImport("vtkplugin", EntryPoint="vtkImageData_CopyStructure_0")] public static extern 
bool CopyStructure_0(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ ds);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// vtkIdType GetNumberOfCells()
// vtkIdType GetNumberOfCells()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetNumberOfCells_0")] public static extern 
bool GetNumberOfCells_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// double* GetPoint(vtkIdType ptId)
// double *GetPoint(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetPoint_0")] public static extern 
bool GetPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// void GetPoint(vtkIdType id, double x[3])
// void GetPoint(vtkIdType id, double x[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetPoint_1")] public static extern 
bool GetPoint_1(IntPtr /*(vtkImageData*)*/ callingObject, long /*(vtkIdType)*/ id, double /*(double[3])*/ []x);

// vtkCell* GetCell(vtkIdType cellId)
// vtkCell *GetCell(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetCell_0")] public static extern 
bool GetCell_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// vtkCell* GetCell(int i, int j, int k)
// vtkCell *GetCell(int i, int j, int k)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetCell_1")] public static extern 
bool GetCell_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k);

// void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// void GetCell(vtkIdType cellId, vtkGenericCell *cell)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetCell_2")] public static extern 
bool GetCell_2(IntPtr /*(vtkImageData*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkGenericCell*)*/ cell);

// void GetCellBounds(vtkIdType cellId, double bounds[6])
// void GetCellBounds(vtkIdType cellId, double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetCellBounds_0")] public static extern 
bool GetCellBounds_0(IntPtr /*(vtkImageData*)*/ callingObject, long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds);

// virtual vtkIdType FindPoint(double x, double y, double z)
// virtual vtkIdType FindPoint(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkImageData_FindPoint_0")] public static extern 
bool FindPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// vtkIdType FindPoint(double x[3])
// vtkIdType FindPoint(double x[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_FindPoint_1")] public static extern 
bool FindPoint_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, double /*(double[3])*/ []x);

// vtkIdType FindCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// vtkIdType FindCell( double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)
[DllImport("vtkplugin", EntryPoint="vtkImageData_FindCell_0")] public static extern 
bool FindCell_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights);

// vtkIdType FindCell(double x[3], vtkCell * cell, vtkGenericCell * gencell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// vtkIdType FindCell( double x[3], vtkCell *cell, vtkGenericCell *gencell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)
[DllImport("vtkplugin", EntryPoint="vtkImageData_FindCell_1")] public static extern 
bool FindCell_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(vtkCell*)*/ cell, IntPtr /*(vtkGenericCell*)*/ gencell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights);

// vtkCell* FindAndGetCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// vtkCell *FindAndGetCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)
[DllImport("vtkplugin", EntryPoint="vtkImageData_FindAndGetCell_0")] public static extern 
bool FindAndGetCell_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights);

// int GetCellType(vtkIdType cellId)
// int GetCellType(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetCellType_0")] public static extern 
bool GetCellType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetCellPoints_0")] public static extern 
bool GetCellPoints_0(IntPtr /*(vtkImageData*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdList*)*/ ptIds);

// void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetPointCells_0")] public static extern 
bool GetPointCells_0(IntPtr /*(vtkImageData*)*/ callingObject, long /*(vtkIdType)*/ ptId, IntPtr /*(vtkIdList*)*/ cellIds);

// void ComputeBounds()
// void ComputeBounds()
[DllImport("vtkplugin", EntryPoint="vtkImageData_ComputeBounds_0")] public static extern 
bool ComputeBounds_0(IntPtr /*(vtkImageData*)*/ callingObject);

// int GetMaxCellSize()
// int GetMaxCellSize()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetMaxCellSize_0")] public static extern 
bool GetMaxCellSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkImageData_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkImageData*)*/ callingObject);

// virtual void SetDimensions(int i, int j, int k)
// virtual void SetDimensions(int i, int j, int k)
[DllImport("vtkplugin", EntryPoint="vtkImageData_SetDimensions_0")] public static extern 
bool SetDimensions_0(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k);

// virtual void SetDimensions(const int dims[3])
// virtual void SetDimensions(const int dims[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_SetDimensions_1")] public static extern 
bool SetDimensions_1(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int[3])*/ []dims);

// virtual int* GetDimensions()
// virtual int *GetDimensions()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetDimensions_0")] public static extern 
bool GetDimensions_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// virtual void GetDimensions(int dims[3])
// virtual void GetDimensions(int dims[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetDimensions_1")] public static extern 
bool GetDimensions_1(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int[3])*/ []dims);

// virtual int ComputeStructuredCoordinates(const double x[3], int ijk[3], double pcoords[3])
// virtual int ComputeStructuredCoordinates( const double x[3], int ijk[3], double pcoords[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_ComputeStructuredCoordinates_0")] public static extern 
bool ComputeStructuredCoordinates_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, double /*(double[3])*/ []x, int /*(int[3])*/ []ijk, double /*(double[3])*/ []pcoords);

// static int ComputeStructuredCoordinates(const double x[3], int ijk[3], double pcoords[3], const int * extent, const double * spacing, const double * origin, const double * bounds)
// static int ComputeStructuredCoordinates( const double x[3], int ijk[3], double pcoords[3], const int* extent, const double* spacing, const double* origin, const double* bounds)
[DllImport("vtkplugin", EntryPoint="vtkImageData_ComputeStructuredCoordinates_1")] public static extern 
bool ComputeStructuredCoordinates_1(IntPtr /*(IntPtr*)*/ return_value, double /*(double[3])*/ []x, int /*(int[3])*/ []ijk, double /*(double[3])*/ []pcoords, IntPtr /*(int*)*/ extent, IntPtr /*(double*)*/ spacing, IntPtr /*(double*)*/ origin, IntPtr /*(double*)*/ bounds);

// virtual void GetVoxelGradient(int i, int j, int k, vtkDataArray * s, vtkDataArray * g)
// virtual void GetVoxelGradient( int i,int j,int k, vtkDataArray *s, vtkDataArray *g)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetVoxelGradient_0")] public static extern 
bool GetVoxelGradient_0(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k, IntPtr /*(vtkDataArray*)*/ s, IntPtr /*(vtkDataArray*)*/ g);

// virtual void GetPointGradient(int i, int j, int k, vtkDataArray * s, double g[3])
// virtual void GetPointGradient( int i, int j, int k, vtkDataArray *s, double g[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetPointGradient_0")] public static extern 
bool GetPointGradient_0(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k, IntPtr /*(vtkDataArray*)*/ s, double /*(double[3])*/ []g);

// virtual int GetDataDimension()
// virtual int GetDataDimension()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetDataDimension_0")] public static extern 
bool GetDataDimension_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// virtual vtkIdType ComputePointId(int ijk[3])
// virtual vtkIdType ComputePointId(int ijk[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_ComputePointId_0")] public static extern 
bool ComputePointId_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, int /*(int[3])*/ []ijk);

// virtual vtkIdType ComputeCellId(int ijk[3])
// virtual vtkIdType ComputeCellId(int ijk[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_ComputeCellId_0")] public static extern 
bool ComputeCellId_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, int /*(int[3])*/ []ijk);

// virtual void SetAxisUpdateExtent(int axis, int min, int max, const int * updateExtent, int * axisUpdateExtent)
// virtual void SetAxisUpdateExtent(int axis, int min, int max, const int* updateExtent, int* axisUpdateExtent)
[DllImport("vtkplugin", EntryPoint="vtkImageData_SetAxisUpdateExtent_0")] public static extern 
bool SetAxisUpdateExtent_0(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int)*/ axis, int /*(int)*/ min, int /*(int)*/ max, IntPtr /*(int*)*/ updateExtent, IntPtr /*(int*)*/ axisUpdateExtent);

// virtual void GetAxisUpdateExtent(int axis, int & min, int & max, const int * updateExtent)
// virtual void GetAxisUpdateExtent(int axis, int &min, int &max, const int* updateExtent)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetAxisUpdateExtent_0")] public static extern 
bool GetAxisUpdateExtent_0(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int)*/ axis, IntPtr /*(int&)*/ min, IntPtr /*(int&)*/ max, IntPtr /*(int*)*/ updateExtent);

// virtual void SetExtent(int extent[6])
// virtual void SetExtent(int extent[6])
[DllImport("vtkplugin", EntryPoint="vtkImageData_SetExtent_0")] public static extern 
bool SetExtent_0(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int[6])*/ []extent);

// virtual void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
// virtual void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
[DllImport("vtkplugin", EntryPoint="vtkImageData_SetExtent_1")] public static extern 
bool SetExtent_1(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int)*/ x1, int /*(int)*/ x2, int /*(int)*/ y1, int /*(int)*/ y2, int /*(int)*/ z1, int /*(int)*/ z2);

// virtual int* GetExtent()
// virtual int *GetExtent ()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetExtent_0")] public static extern 
bool GetExtent_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// virtual void GetExtent(int & _arg1, int & _arg2, int & _arg3, int & _arg4, int & _arg5, int & _arg6)
// virtual void GetExtent (int &_arg1, int &_arg2, int &_arg3, int &_arg4, int &_arg5, int &_arg6)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetExtent_1")] public static extern 
bool GetExtent_1(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2, IntPtr /*(int&)*/ _arg3, IntPtr /*(int&)*/ _arg4, IntPtr /*(int&)*/ _arg5, IntPtr /*(int&)*/ _arg6);

// virtual void GetExtent(int _arg[6])
// virtual void GetExtent (int _arg[6])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetExtent_2")] public static extern 
bool GetExtent_2(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int[6])*/ []_arg);

// virtual double GetScalarTypeMin()
// virtual double GetScalarTypeMin()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetScalarTypeMin_0")] public static extern 
bool GetScalarTypeMin_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// virtual double GetScalarTypeMax()
// virtual double GetScalarTypeMax()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetScalarTypeMax_0")] public static extern 
bool GetScalarTypeMax_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// virtual int GetScalarSize()
// virtual int GetScalarSize()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetScalarSize_0")] public static extern 
bool GetScalarSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// virtual vtkIdType* GetIncrements()
// virtual vtkIdType *GetIncrements()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetIncrements_0")] public static extern 
bool GetIncrements_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// virtual void GetIncrements(vtkIdType & incX, vtkIdType & incY, vtkIdType & incZ)
// virtual void GetIncrements(vtkIdType &incX, vtkIdType &incY, vtkIdType &incZ)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetIncrements_1")] public static extern 
bool GetIncrements_1(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(vtkIdType&)*/ incX, IntPtr /*(vtkIdType&)*/ incY, IntPtr /*(vtkIdType&)*/ incZ);

// virtual void GetIncrements(vtkIdType inc[3])
// virtual void GetIncrements(vtkIdType inc[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetIncrements_2")] public static extern 
bool GetIncrements_2(IntPtr /*(vtkImageData*)*/ callingObject, long /*(vtkIdType[3])*/ []inc);

// virtual vtkIdType* GetIncrements(vtkDataArray * scalars)
// virtual vtkIdType *GetIncrements(vtkDataArray *scalars)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetIncrements_3")] public static extern 
bool GetIncrements_3(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ scalars);

// virtual void GetIncrements(vtkDataArray * scalars, vtkIdType & incX, vtkIdType & incY, vtkIdType & incZ)
// virtual void GetIncrements(vtkDataArray *scalars, vtkIdType &incX, vtkIdType &incY, vtkIdType &incZ)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetIncrements_4")] public static extern 
bool GetIncrements_4(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ scalars, IntPtr /*(vtkIdType&)*/ incX, IntPtr /*(vtkIdType&)*/ incY, IntPtr /*(vtkIdType&)*/ incZ);

// virtual void GetIncrements(vtkDataArray * scalars, vtkIdType inc[3])
// virtual void GetIncrements(vtkDataArray *scalars, vtkIdType inc[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetIncrements_5")] public static extern 
bool GetIncrements_5(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ scalars, long /*(vtkIdType[3])*/ []inc);

// virtual void GetContinuousIncrements(int extent[6], vtkIdType & incX, vtkIdType & incY, vtkIdType & incZ)
// virtual void GetContinuousIncrements( int extent[6], vtkIdType &incX, vtkIdType &incY, vtkIdType &incZ)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetContinuousIncrements_0")] public static extern 
bool GetContinuousIncrements_0(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int[6])*/ []extent, IntPtr /*(vtkIdType&)*/ incX, IntPtr /*(vtkIdType&)*/ incY, IntPtr /*(vtkIdType&)*/ incZ);

// virtual void GetContinuousIncrements(vtkDataArray * scalars, int extent[6], vtkIdType & incX, vtkIdType & incY, vtkIdType & incZ)
// virtual void GetContinuousIncrements(vtkDataArray *scalars, int extent[6], vtkIdType &incX, vtkIdType &incY, vtkIdType &incZ)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetContinuousIncrements_1")] public static extern 
bool GetContinuousIncrements_1(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ scalars, int /*(int[6])*/ []extent, IntPtr /*(vtkIdType&)*/ incX, IntPtr /*(vtkIdType&)*/ incY, IntPtr /*(vtkIdType&)*/ incZ);

// virtual void* GetScalarPointerForExtent(int extent[6])
// virtual void *GetScalarPointerForExtent(int extent[6])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetScalarPointerForExtent_0")] public static extern 
bool GetScalarPointerForExtent_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, int /*(int[6])*/ []extent);

// virtual void* GetScalarPointer(int coordinates[3])
// virtual void *GetScalarPointer(int coordinates[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetScalarPointer_0")] public static extern 
bool GetScalarPointer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, int /*(int[3])*/ []coordinates);

// virtual void* GetScalarPointer(int x, int y, int z)
// virtual void *GetScalarPointer(int x, int y, int z)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetScalarPointer_1")] public static extern 
bool GetScalarPointer_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ z);

// virtual void* GetScalarPointer()
// virtual void *GetScalarPointer()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetScalarPointer_2")] public static extern 
bool GetScalarPointer_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// virtual float GetScalarComponentAsFloat(int x, int y, int z, int component)
// virtual float GetScalarComponentAsFloat(int x, int y, int z, int component)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetScalarComponentAsFloat_0")] public static extern 
bool GetScalarComponentAsFloat_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ z, int /*(int)*/ component);

// virtual void SetScalarComponentFromFloat(int x, int y, int z, int component, float v)
// virtual void SetScalarComponentFromFloat( int x, int y, int z, int component, float v)
[DllImport("vtkplugin", EntryPoint="vtkImageData_SetScalarComponentFromFloat_0")] public static extern 
bool SetScalarComponentFromFloat_0(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ z, int /*(int)*/ component, float /*(float)*/ v);

// virtual double GetScalarComponentAsDouble(int x, int y, int z, int component)
// virtual double GetScalarComponentAsDouble(int x, int y, int z, int component)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetScalarComponentAsDouble_0")] public static extern 
bool GetScalarComponentAsDouble_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ z, int /*(int)*/ component);

// virtual void SetScalarComponentFromDouble(int x, int y, int z, int component, double v)
// virtual void SetScalarComponentFromDouble( int x, int y, int z, int component, double v)
[DllImport("vtkplugin", EntryPoint="vtkImageData_SetScalarComponentFromDouble_0")] public static extern 
bool SetScalarComponentFromDouble_0(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ z, int /*(int)*/ component, double /*(double)*/ v);

// virtual void AllocateScalars(int dataType, int numComponents)
// virtual void AllocateScalars(int dataType, int numComponents)
[DllImport("vtkplugin", EntryPoint="vtkImageData_AllocateScalars_0")] public static extern 
bool AllocateScalars_0(IntPtr /*(vtkImageData*)*/ callingObject, int /*(int)*/ dataType, int /*(int)*/ numComponents);

// virtual void CopyAndCastFrom(vtkImageData * inData, int extent[6])
// virtual void CopyAndCastFrom(vtkImageData *inData, int extent[6])
[DllImport("vtkplugin", EntryPoint="vtkImageData_CopyAndCastFrom_0")] public static extern 
bool CopyAndCastFrom_0(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(vtkImageData*)*/ inData, int /*(int[6])*/ []extent);

// virtual void CopyAndCastFrom(vtkImageData * inData, int x0, int x1, int y0, int y1, int z0, int z1)
// virtual void CopyAndCastFrom(vtkImageData *inData, int x0, int x1, int y0, int y1, int z0, int z1)
[DllImport("vtkplugin", EntryPoint="vtkImageData_CopyAndCastFrom_1")] public static extern 
bool CopyAndCastFrom_1(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(vtkImageData*)*/ inData, int /*(int)*/ x0, int /*(int)*/ x1, int /*(int)*/ y0, int /*(int)*/ y1, int /*(int)*/ z0, int /*(int)*/ z1);

// void Crop(const int * updateExtent)
// void Crop(const int* updateExtent)
[DllImport("vtkplugin", EntryPoint="vtkImageData_Crop_0")] public static extern 
bool Crop_0(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(int*)*/ updateExtent);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetActualMemorySize_0")] public static extern 
bool GetActualMemorySize_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// virtual void SetSpacing(double _arg1, double _arg2, double _arg3)
// virtual void SetSpacing (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkImageData_SetSpacing_0")] public static extern 
bool SetSpacing_0(IntPtr /*(vtkImageData*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetSpacing(double _arg[3])
// virtual void SetSpacing (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_SetSpacing_1")] public static extern 
bool SetSpacing_1(IntPtr /*(vtkImageData*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetSpacing()
// virtual double *GetSpacing ()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetSpacing_0")] public static extern 
bool GetSpacing_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// virtual void GetSpacing(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetSpacing (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetSpacing_1")] public static extern 
bool GetSpacing_1(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetSpacing(double _arg[3])
// virtual void GetSpacing (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetSpacing_2")] public static extern 
bool GetSpacing_2(IntPtr /*(vtkImageData*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
// virtual void SetOrigin (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkImageData_SetOrigin_0")] public static extern 
bool SetOrigin_0(IntPtr /*(vtkImageData*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetOrigin(double _arg[3])
// virtual void SetOrigin (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_SetOrigin_1")] public static extern 
bool SetOrigin_1(IntPtr /*(vtkImageData*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetOrigin()
// virtual double *GetOrigin ()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetOrigin_0")] public static extern 
bool GetOrigin_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// virtual void GetOrigin(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetOrigin (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetOrigin_1")] public static extern 
bool GetOrigin_1(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetOrigin(double _arg[3])
// virtual void GetOrigin (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetOrigin_2")] public static extern 
bool GetOrigin_2(IntPtr /*(vtkImageData*)*/ callingObject, double /*(double[3])*/ []_arg);

// int GetScalarType()
// int GetScalarType()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetScalarType_0")] public static extern 
bool GetScalarType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// char* GetScalarTypeAsString()
// const char* GetScalarTypeAsString()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetScalarTypeAsString_0")] public static extern 
bool GetScalarTypeAsString_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// int GetNumberOfScalarComponents()
// int GetNumberOfScalarComponents()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetNumberOfScalarComponents_0")] public static extern 
bool GetNumberOfScalarComponents_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

// void PrepareForNewData()
// void PrepareForNewData()
[DllImport("vtkplugin", EntryPoint="vtkImageData_PrepareForNewData_0")] public static extern 
bool PrepareForNewData_0(IntPtr /*(vtkImageData*)*/ callingObject);

// void ShallowCopy(vtkDataObject * src)
// void ShallowCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkImageData_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkImageData_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void* GetArrayPointerForExtent(vtkDataArray * array, int extent[6])
// void *GetArrayPointerForExtent(vtkDataArray* array, int extent[6])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetArrayPointerForExtent_0")] public static extern 
bool GetArrayPointerForExtent_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ array, int /*(int[6])*/ []extent);

// void* GetArrayPointer(vtkDataArray * array, int coordinates[3])
// void *GetArrayPointer(vtkDataArray* array, int coordinates[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetArrayPointer_0")] public static extern 
bool GetArrayPointer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ array, int /*(int[3])*/ []coordinates);

// void GetArrayIncrements(vtkDataArray * array, vtkIdType increments[3])
// void GetArrayIncrements(vtkDataArray *array, vtkIdType increments[3])
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetArrayIncrements_0")] public static extern 
bool GetArrayIncrements_0(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ array, long /*(vtkIdType[3])*/ []increments);

// void ComputeInternalExtent(int * intExt, int * tgtExt, int * bnds)
// void ComputeInternalExtent(int *intExt, int *tgtExt, int *bnds)
[DllImport("vtkplugin", EntryPoint="vtkImageData_ComputeInternalExtent_0")] public static extern 
bool ComputeInternalExtent_0(IntPtr /*(vtkImageData*)*/ callingObject, IntPtr /*(int*)*/ intExt, IntPtr /*(int*)*/ tgtExt, IntPtr /*(int*)*/ bnds);

// int GetExtentType()
// int GetExtentType()
[DllImport("vtkplugin", EntryPoint="vtkImageData_GetExtentType_0")] public static extern 
bool GetExtentType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImageData*)*/ callingObject);

}
};
