
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAbstractPointLocator {

// virtual vtkIdType FindClosestPoint(const double x[3])
// virtual vtkIdType FindClosestPoint(const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractPointLocator_FindClosestPoint_0")] public static extern 
bool FindClosestPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractPointLocator*)*/ callingObject, double /*(double[3])*/ []x);

// vtkIdType FindClosestPoint(double x, double y, double z)
// vtkIdType FindClosestPoint(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPointLocator_FindClosestPoint_1")] public static extern 
bool FindClosestPoint_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractPointLocator*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// virtual vtkIdType FindClosestPointWithinRadius(double radius, const double x[3], double & dist2)
// virtual vtkIdType FindClosestPointWithinRadius( double radius, const double x[3], double& dist2)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPointLocator_FindClosestPointWithinRadius_0")] public static extern 
bool FindClosestPointWithinRadius_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractPointLocator*)*/ callingObject, double /*(double)*/ radius, double /*(double[3])*/ []x, IntPtr /*(double&)*/ dist2);

// virtual void FindClosestNPoints(int N, const double x[3], vtkIdList * result)
// virtual void FindClosestNPoints( int N, const double x[3], vtkIdList *result)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPointLocator_FindClosestNPoints_0")] public static extern 
bool FindClosestNPoints_0(IntPtr /*(vtkAbstractPointLocator*)*/ callingObject, int /*(int)*/ N, double /*(double[3])*/ []x, IntPtr /*(vtkIdList*)*/ result);

// void FindClosestNPoints(int N, double x, double y, double z, vtkIdList * result)
// void FindClosestNPoints(int N, double x, double y, double z, vtkIdList *result)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPointLocator_FindClosestNPoints_1")] public static extern 
bool FindClosestNPoints_1(IntPtr /*(vtkAbstractPointLocator*)*/ callingObject, int /*(int)*/ N, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, IntPtr /*(vtkIdList*)*/ result);

// virtual void FindPointsWithinRadius(double R, const double x[3], vtkIdList * result)
// virtual void FindPointsWithinRadius(double R, const double x[3], vtkIdList *result)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPointLocator_FindPointsWithinRadius_0")] public static extern 
bool FindPointsWithinRadius_0(IntPtr /*(vtkAbstractPointLocator*)*/ callingObject, double /*(double)*/ R, double /*(double[3])*/ []x, IntPtr /*(vtkIdList*)*/ result);

// void FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList * result)
// void FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList *result)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPointLocator_FindPointsWithinRadius_1")] public static extern 
bool FindPointsWithinRadius_1(IntPtr /*(vtkAbstractPointLocator*)*/ callingObject, double /*(double)*/ R, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, IntPtr /*(vtkIdList*)*/ result);

// virtual double* GetBounds()
// virtual double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPointLocator_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPointLocator*)*/ callingObject);

// virtual void GetBounds(double * ARG_0)
// virtual void GetBounds(double*)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPointLocator_GetBounds_1")] public static extern 
bool GetBounds_1(IntPtr /*(vtkAbstractPointLocator*)*/ callingObject, IntPtr /*(double*)*/ ARG_0);

}
};
