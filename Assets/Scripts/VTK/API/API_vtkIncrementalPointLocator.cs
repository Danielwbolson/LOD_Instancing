
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkIncrementalPointLocator {

// virtual vtkIdType FindClosestInsertedPoint(const double x[3])
// virtual vtkIdType FindClosestInsertedPoint( const double x[3] )
[DllImport("vtkplugin", EntryPoint="vtkIncrementalPointLocator_FindClosestInsertedPoint_0")] public static extern 
bool vtkIncrementalPointLocator_FindClosestInsertedPoint_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkIncrementalPointLocator*)*/ callingObject, double /*(double[3])*/ []x);

// virtual int InitPointInsertion(vtkPoints * newPts, const double bounds[6])
// virtual int InitPointInsertion( vtkPoints * newPts, const double bounds[6] )
[DllImport("vtkplugin", EntryPoint="vtkIncrementalPointLocator_InitPointInsertion_0")] public static extern 
bool vtkIncrementalPointLocator_InitPointInsertion_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkIncrementalPointLocator*)*/ callingObject, IntPtr /*(vtkPoints*)*/ newPts, double /*(double[6])*/ []bounds);

// virtual int InitPointInsertion(vtkPoints * newPts, const double bounds[6], vtkIdType estSize)
// virtual int InitPointInsertion( vtkPoints * newPts, const double bounds[6], vtkIdType estSize )
[DllImport("vtkplugin", EntryPoint="vtkIncrementalPointLocator_InitPointInsertion_1")] public static extern 
bool vtkIncrementalPointLocator_InitPointInsertion_1(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkIncrementalPointLocator*)*/ callingObject, IntPtr /*(vtkPoints*)*/ newPts, double /*(double[6])*/ []bounds, long /*(vtkIdType)*/ estSize);

// virtual vtkIdType IsInsertedPoint(double x, double y, double z)
// virtual vtkIdType IsInsertedPoint( double x, double y, double z )
[DllImport("vtkplugin", EntryPoint="vtkIncrementalPointLocator_IsInsertedPoint_0")] public static extern 
bool vtkIncrementalPointLocator_IsInsertedPoint_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkIncrementalPointLocator*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// virtual vtkIdType IsInsertedPoint(const double x[3])
// virtual vtkIdType IsInsertedPoint( const double x[3] )
[DllImport("vtkplugin", EntryPoint="vtkIncrementalPointLocator_IsInsertedPoint_1")] public static extern 
bool vtkIncrementalPointLocator_IsInsertedPoint_1(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkIncrementalPointLocator*)*/ callingObject, double /*(double[3])*/ []x);

// virtual int InsertUniquePoint(const double x[3], vtkIdType & ptId)
// virtual int InsertUniquePoint( const double x[3], vtkIdType & ptId )
[DllImport("vtkplugin", EntryPoint="vtkIncrementalPointLocator_InsertUniquePoint_0")] public static extern 
bool vtkIncrementalPointLocator_InsertUniquePoint_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkIncrementalPointLocator*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(vtkIdType&)*/ ptId);

// virtual void InsertPoint(vtkIdType ptId, const double x[3])
// virtual void InsertPoint( vtkIdType ptId, const double x[3] )
[DllImport("vtkplugin", EntryPoint="vtkIncrementalPointLocator_InsertPoint_0")] public static extern 
bool vtkIncrementalPointLocator_InsertPoint_0(IntPtr /*(vtkIncrementalPointLocator*)*/ callingObject, long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []x);

// virtual vtkIdType InsertNextPoint(const double x[3])
// virtual vtkIdType InsertNextPoint( const double x[3] )
[DllImport("vtkplugin", EntryPoint="vtkIncrementalPointLocator_InsertNextPoint_0")] public static extern 
bool vtkIncrementalPointLocator_InsertNextPoint_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkIncrementalPointLocator*)*/ callingObject, double /*(double[3])*/ []x);

}
};
