
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkIncrementalPointLocator {

//       Method: virtual const char * vtkIncrementalPointLocator::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIncrementalPointLocator_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkIncrementalPointLocator* */ obj);

//       Method: virtual vtkIdType vtkIncrementalPointLocator::FindClosestInsertedPoint(const double x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIncrementalPointLocator_FindClosestInsertedPoint_0")] public static extern 
bool FindClosestInsertedPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkIncrementalPointLocator* */ obj, double[] /*3*/ x);

//       Method: virtual int vtkIncrementalPointLocator::InitPointInsertion(vtkPoints* newPts, const double bounds[6])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIncrementalPointLocator_InitPointInsertion_0")] public static extern 
bool InitPointInsertion(IntPtr /*int* */ ret, IntPtr /*vtkIncrementalPointLocator* */ obj, IntPtr/*vtkPoints* */ newPts, double[] /*6*/ bounds);

//       Method: virtual int vtkIncrementalPointLocator::InitPointInsertion(vtkPoints* newPts, const double bounds[6], vtkIdType estSize)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIncrementalPointLocator_InitPointInsertion_1")] public static extern 
bool InitPointInsertion(IntPtr /*int* */ ret, IntPtr /*vtkIncrementalPointLocator* */ obj, IntPtr/*vtkPoints* */ newPts, double[] /*6*/ bounds, long estSize);

//       Method: virtual vtkIdType vtkIncrementalPointLocator::IsInsertedPoint(double x, double y, double z)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIncrementalPointLocator_IsInsertedPoint_0")] public static extern 
bool IsInsertedPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkIncrementalPointLocator* */ obj, double x, double y, double z);

//       Method: virtual vtkIdType vtkIncrementalPointLocator::IsInsertedPoint(const double x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIncrementalPointLocator_IsInsertedPoint_1")] public static extern 
bool IsInsertedPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkIncrementalPointLocator* */ obj, double[] /*3*/ x);

//       Method: virtual void vtkIncrementalPointLocator::InsertPoint(vtkIdType ptId, const double x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIncrementalPointLocator_InsertPoint_0")] public static extern 
bool InsertPoint(IntPtr /*vtkIncrementalPointLocator* */ obj, long ptId, double[] /*3*/ x);

//       Method: virtual vtkIdType vtkIncrementalPointLocator::InsertNextPoint(const double x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkIncrementalPointLocator_InsertNextPoint_0")] public static extern 
bool InsertNextPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkIncrementalPointLocator* */ obj, double[] /*3*/ x);

}
};
