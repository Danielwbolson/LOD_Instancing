
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkAbstractPointLocator {

//       Method: virtual const char * vtkAbstractPointLocator::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractPointLocator_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkAbstractPointLocator* */ obj);

//       Method: virtual vtkIdType vtkAbstractPointLocator::FindClosestPoint(const double x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractPointLocator_FindClosestPoint_0")] public static extern 
bool FindClosestPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkAbstractPointLocator* */ obj, double[] /*3*/ x);

//       Method: vtkIdType vtkAbstractPointLocator::FindClosestPoint(double x, double y, double z)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractPointLocator_FindClosestPoint_1")] public static extern 
bool FindClosestPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkAbstractPointLocator* */ obj, double x, double y, double z);

//       Method: virtual void vtkAbstractPointLocator::FindClosestNPoints(int N, const double x[3], vtkIdList* result)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractPointLocator_FindClosestNPoints_0")] public static extern 
bool FindClosestNPoints(IntPtr /*vtkAbstractPointLocator* */ obj, int N, double[] /*3*/ x, IntPtr/*vtkIdList* */ result);

//       Method: void vtkAbstractPointLocator::FindClosestNPoints(int N, double x, double y, double z, vtkIdList* result)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractPointLocator_FindClosestNPoints_1")] public static extern 
bool FindClosestNPoints(IntPtr /*vtkAbstractPointLocator* */ obj, int N, double x, double y, double z, IntPtr/*vtkIdList* */ result);

//       Method: virtual void vtkAbstractPointLocator::FindPointsWithinRadius(double R, const double x[3], vtkIdList* result)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractPointLocator_FindPointsWithinRadius_0")] public static extern 
bool FindPointsWithinRadius(IntPtr /*vtkAbstractPointLocator* */ obj, double R, double[] /*3*/ x, IntPtr/*vtkIdList* */ result);

//       Method: void vtkAbstractPointLocator::FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList* result)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractPointLocator_FindPointsWithinRadius_1")] public static extern 
bool FindPointsWithinRadius(IntPtr /*vtkAbstractPointLocator* */ obj, double R, double x, double y, double z, IntPtr/*vtkIdList* */ result);

//       Method: virtual double * vtkAbstractPointLocator::GetBounds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractPointLocator_GetBounds_0")] public static extern 
bool GetBounds(IntPtr /*double** */ ret, IntPtr /*vtkAbstractPointLocator* */ obj);

}
};
