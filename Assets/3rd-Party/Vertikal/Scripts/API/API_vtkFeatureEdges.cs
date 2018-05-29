
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkFeatureEdges {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFeatureEdges*)*/ callingObject, string /*(char*)*/ type);

// static vtkFeatureEdges* SafeDownCast(vtkObjectBase * o)
// static vtkFeatureEdges* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkFeatureEdges* NewInstance()
// vtkFeatureEdges *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// static vtkFeatureEdges* New()
// static vtkFeatureEdges *New()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual void SetBoundaryEdges(int _arg)
// virtual void SetBoundaryEdges (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_SetBoundaryEdges_0")] public static extern 
bool SetBoundaryEdges_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetBoundaryEdges()
// virtual int GetBoundaryEdges ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_GetBoundaryEdges_0")] public static extern 
bool GetBoundaryEdges_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void BoundaryEdgesOn()
// virtual void BoundaryEdgesOn ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_BoundaryEdgesOn_0")] public static extern 
bool BoundaryEdgesOn_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void BoundaryEdgesOff()
// virtual void BoundaryEdgesOff ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_BoundaryEdgesOff_0")] public static extern 
bool BoundaryEdgesOff_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void SetFeatureEdges(int _arg)
// virtual void SetFeatureEdges (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_SetFeatureEdges_0")] public static extern 
bool SetFeatureEdges_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetFeatureEdges()
// virtual int GetFeatureEdges ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_GetFeatureEdges_0")] public static extern 
bool GetFeatureEdges_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void FeatureEdgesOn()
// virtual void FeatureEdgesOn ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_FeatureEdgesOn_0")] public static extern 
bool FeatureEdgesOn_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void FeatureEdgesOff()
// virtual void FeatureEdgesOff ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_FeatureEdgesOff_0")] public static extern 
bool FeatureEdgesOff_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void SetFeatureAngle(double _arg)
// virtual void SetFeatureAngle (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_SetFeatureAngle_0")] public static extern 
bool SetFeatureAngle_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetFeatureAngleMinValue()
// virtual double GetFeatureAngleMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_GetFeatureAngleMinValue_0")] public static extern 
bool GetFeatureAngleMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual double GetFeatureAngleMaxValue()
// virtual double GetFeatureAngleMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_GetFeatureAngleMaxValue_0")] public static extern 
bool GetFeatureAngleMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual double GetFeatureAngle()
// virtual double GetFeatureAngle ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_GetFeatureAngle_0")] public static extern 
bool GetFeatureAngle_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void SetNonManifoldEdges(int _arg)
// virtual void SetNonManifoldEdges (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_SetNonManifoldEdges_0")] public static extern 
bool SetNonManifoldEdges_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetNonManifoldEdges()
// virtual int GetNonManifoldEdges ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_GetNonManifoldEdges_0")] public static extern 
bool GetNonManifoldEdges_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void NonManifoldEdgesOn()
// virtual void NonManifoldEdgesOn ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_NonManifoldEdgesOn_0")] public static extern 
bool NonManifoldEdgesOn_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void NonManifoldEdgesOff()
// virtual void NonManifoldEdgesOff ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_NonManifoldEdgesOff_0")] public static extern 
bool NonManifoldEdgesOff_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void SetManifoldEdges(int _arg)
// virtual void SetManifoldEdges (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_SetManifoldEdges_0")] public static extern 
bool SetManifoldEdges_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetManifoldEdges()
// virtual int GetManifoldEdges ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_GetManifoldEdges_0")] public static extern 
bool GetManifoldEdges_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void ManifoldEdgesOn()
// virtual void ManifoldEdgesOn ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_ManifoldEdgesOn_0")] public static extern 
bool ManifoldEdgesOn_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void ManifoldEdgesOff()
// virtual void ManifoldEdgesOff ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_ManifoldEdgesOff_0")] public static extern 
bool ManifoldEdgesOff_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void SetColoring(int _arg)
// virtual void SetColoring (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_SetColoring_0")] public static extern 
bool SetColoring_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetColoring()
// virtual int GetColoring ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_GetColoring_0")] public static extern 
bool GetColoring_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void ColoringOn()
// virtual void ColoringOn ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_ColoringOn_0")] public static extern 
bool ColoringOn_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void ColoringOff()
// virtual void ColoringOff ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_ColoringOff_0")] public static extern 
bool ColoringOff_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// void SetLocator(vtkIncrementalPointLocator * locator)
// void SetLocator(vtkIncrementalPointLocator *locator)
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_SetLocator_0")] public static extern 
bool SetLocator_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject, IntPtr /*(vtkIncrementalPointLocator*)*/ locator);

// virtual vtkIncrementalPointLocator* GetLocator()
// virtual vtkIncrementalPointLocator *GetLocator ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_GetLocator_0")] public static extern 
bool GetLocator_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// void CreateDefaultLocator()
// void CreateDefaultLocator()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_CreateDefaultLocator_0")] public static extern 
bool CreateDefaultLocator_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFeatureEdges*)*/ callingObject);

// virtual void SetOutputPointsPrecision(int _arg)
// virtual void SetOutputPointsPrecision (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_SetOutputPointsPrecision_0")] public static extern 
bool SetOutputPointsPrecision_0(IntPtr /*(vtkFeatureEdges*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetOutputPointsPrecision()
// virtual int GetOutputPointsPrecision ()
[DllImport("vtkplugin", EntryPoint="vtkFeatureEdges_GetOutputPointsPrecision_0")] public static extern 
bool GetOutputPointsPrecision_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFeatureEdges*)*/ callingObject);

}
};
