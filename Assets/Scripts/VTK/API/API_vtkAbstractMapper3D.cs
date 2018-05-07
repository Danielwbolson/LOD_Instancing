
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAbstractMapper3D {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper3D_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper3D_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractMapper3D*)*/ callingObject, string /*(char*)*/ type);

// static vtkAbstractMapper3D* SafeDownCast(vtkObjectBase * o)
// static vtkAbstractMapper3D* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper3D_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAbstractMapper3D* NewInstance()
// vtkAbstractMapper3D *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper3D_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractMapper3D*)*/ callingObject);

// virtual double* GetBounds()
// virtual double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper3D_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractMapper3D*)*/ callingObject);

// virtual void GetBounds(double bounds[6])
// virtual void GetBounds(double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper3D_GetBounds_1")] public static extern 
bool GetBounds_1(IntPtr /*(vtkAbstractMapper3D*)*/ callingObject, double /*(double[6])*/ []bounds);

// double* GetCenter()
// double *GetCenter()
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper3D_GetCenter_0")] public static extern 
bool GetCenter_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractMapper3D*)*/ callingObject);

// void GetCenter(double center[3])
// void GetCenter(double center[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper3D_GetCenter_1")] public static extern 
bool GetCenter_1(IntPtr /*(vtkAbstractMapper3D*)*/ callingObject, double /*(double[3])*/ []center);

// double GetLength()
// double GetLength()
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper3D_GetLength_0")] public static extern 
bool GetLength_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractMapper3D*)*/ callingObject);

// virtual int IsARayCastMapper()
// virtual int IsARayCastMapper()
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper3D_IsARayCastMapper_0")] public static extern 
bool IsARayCastMapper_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractMapper3D*)*/ callingObject);

// virtual int IsARenderIntoImageMapper()
// virtual int IsARenderIntoImageMapper()
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper3D_IsARenderIntoImageMapper_0")] public static extern 
bool IsARenderIntoImageMapper_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractMapper3D*)*/ callingObject);

// void GetClippingPlaneInDataCoords(vtkMatrix4x4 * propMatrix, int i, double planeEquation[4])
// void GetClippingPlaneInDataCoords( vtkMatrix4x4 *propMatrix, int i, double planeEquation[4])
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper3D_GetClippingPlaneInDataCoords_0")] public static extern 
bool GetClippingPlaneInDataCoords_0(IntPtr /*(vtkAbstractMapper3D*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ propMatrix, int /*(int)*/ i, double /*(double[4])*/ []planeEquation);

}
};
