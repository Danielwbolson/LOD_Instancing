
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkGeometryFilter {

// static vtkGeometryFilter* New()
// static vtkGeometryFilter *New()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject, string /*(char*)*/ type);

// static vtkGeometryFilter* SafeDownCast(vtkObjectBase * o)
// static vtkGeometryFilter* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkGeometryFilter* NewInstance()
// vtkGeometryFilter *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void SetPointClipping(int _arg)
// virtual void SetPointClipping (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_SetPointClipping_0")] public static extern 
bool SetPointClipping_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetPointClipping()
// virtual int GetPointClipping ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetPointClipping_0")] public static extern 
bool GetPointClipping_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void PointClippingOn()
// virtual void PointClippingOn ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_PointClippingOn_0")] public static extern 
bool PointClippingOn_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void PointClippingOff()
// virtual void PointClippingOff ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_PointClippingOff_0")] public static extern 
bool PointClippingOff_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void SetCellClipping(int _arg)
// virtual void SetCellClipping (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_SetCellClipping_0")] public static extern 
bool SetCellClipping_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetCellClipping()
// virtual int GetCellClipping ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetCellClipping_0")] public static extern 
bool GetCellClipping_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void CellClippingOn()
// virtual void CellClippingOn ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_CellClippingOn_0")] public static extern 
bool CellClippingOn_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void CellClippingOff()
// virtual void CellClippingOff ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_CellClippingOff_0")] public static extern 
bool CellClippingOff_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void SetExtentClipping(int _arg)
// virtual void SetExtentClipping (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_SetExtentClipping_0")] public static extern 
bool SetExtentClipping_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetExtentClipping()
// virtual int GetExtentClipping ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetExtentClipping_0")] public static extern 
bool GetExtentClipping_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void ExtentClippingOn()
// virtual void ExtentClippingOn ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_ExtentClippingOn_0")] public static extern 
bool ExtentClippingOn_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void ExtentClippingOff()
// virtual void ExtentClippingOff ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_ExtentClippingOff_0")] public static extern 
bool ExtentClippingOff_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void SetPointMinimum(vtkIdType _arg)
// virtual void SetPointMinimum (vtkIdType _arg)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_SetPointMinimum_0")] public static extern 
bool SetPointMinimum_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject, long /*(vtkIdType)*/ _arg);

// virtual vtkIdType GetPointMinimumMinValue()
// virtual vtkIdType GetPointMinimumMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetPointMinimumMinValue_0")] public static extern 
bool GetPointMinimumMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual vtkIdType GetPointMinimumMaxValue()
// virtual vtkIdType GetPointMinimumMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetPointMinimumMaxValue_0")] public static extern 
bool GetPointMinimumMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual vtkIdType GetPointMinimum()
// virtual vtkIdType GetPointMinimum ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetPointMinimum_0")] public static extern 
bool GetPointMinimum_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void SetPointMaximum(vtkIdType _arg)
// virtual void SetPointMaximum (vtkIdType _arg)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_SetPointMaximum_0")] public static extern 
bool SetPointMaximum_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject, long /*(vtkIdType)*/ _arg);

// virtual vtkIdType GetPointMaximumMinValue()
// virtual vtkIdType GetPointMaximumMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetPointMaximumMinValue_0")] public static extern 
bool GetPointMaximumMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual vtkIdType GetPointMaximumMaxValue()
// virtual vtkIdType GetPointMaximumMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetPointMaximumMaxValue_0")] public static extern 
bool GetPointMaximumMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual vtkIdType GetPointMaximum()
// virtual vtkIdType GetPointMaximum ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetPointMaximum_0")] public static extern 
bool GetPointMaximum_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void SetCellMinimum(vtkIdType _arg)
// virtual void SetCellMinimum (vtkIdType _arg)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_SetCellMinimum_0")] public static extern 
bool SetCellMinimum_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject, long /*(vtkIdType)*/ _arg);

// virtual vtkIdType GetCellMinimumMinValue()
// virtual vtkIdType GetCellMinimumMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetCellMinimumMinValue_0")] public static extern 
bool GetCellMinimumMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual vtkIdType GetCellMinimumMaxValue()
// virtual vtkIdType GetCellMinimumMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetCellMinimumMaxValue_0")] public static extern 
bool GetCellMinimumMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual vtkIdType GetCellMinimum()
// virtual vtkIdType GetCellMinimum ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetCellMinimum_0")] public static extern 
bool GetCellMinimum_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void SetCellMaximum(vtkIdType _arg)
// virtual void SetCellMaximum (vtkIdType _arg)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_SetCellMaximum_0")] public static extern 
bool SetCellMaximum_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject, long /*(vtkIdType)*/ _arg);

// virtual vtkIdType GetCellMaximumMinValue()
// virtual vtkIdType GetCellMaximumMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetCellMaximumMinValue_0")] public static extern 
bool GetCellMaximumMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual vtkIdType GetCellMaximumMaxValue()
// virtual vtkIdType GetCellMaximumMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetCellMaximumMaxValue_0")] public static extern 
bool GetCellMaximumMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual vtkIdType GetCellMaximum()
// virtual vtkIdType GetCellMaximum ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetCellMaximum_0")] public static extern 
bool GetCellMaximum_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
// void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_SetExtent_0")] public static extern 
bool SetExtent_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject, double /*(double)*/ xMin, double /*(double)*/ xMax, double /*(double)*/ yMin, double /*(double)*/ yMax, double /*(double)*/ zMin, double /*(double)*/ zMax);

// void SetExtent(double extent[6])
// void SetExtent(double extent[6])
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_SetExtent_1")] public static extern 
bool SetExtent_1(IntPtr /*(vtkGeometryFilter*)*/ callingObject, double /*(double[6])*/ []extent);

// double* GetExtent()
// double *GetExtent()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetExtent_0")] public static extern 
bool GetExtent_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void SetMerging(int _arg)
// virtual void SetMerging (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_SetMerging_0")] public static extern 
bool SetMerging_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetMerging()
// virtual int GetMerging ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetMerging_0")] public static extern 
bool GetMerging_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void MergingOn()
// virtual void MergingOn ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_MergingOn_0")] public static extern 
bool MergingOn_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// virtual void MergingOff()
// virtual void MergingOff ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_MergingOff_0")] public static extern 
bool MergingOff_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// void SetLocator(vtkIncrementalPointLocator * locator)
// void SetLocator(vtkIncrementalPointLocator *locator)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_SetLocator_0")] public static extern 
bool SetLocator_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject, IntPtr /*(vtkIncrementalPointLocator*)*/ locator);

// virtual vtkIncrementalPointLocator* GetLocator()
// virtual vtkIncrementalPointLocator *GetLocator ()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetLocator_0")] public static extern 
bool GetLocator_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// void CreateDefaultLocator()
// void CreateDefaultLocator()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_CreateDefaultLocator_0")] public static extern 
bool CreateDefaultLocator_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

// void SetOutputPointsPrecision(int precision)
// void SetOutputPointsPrecision(int precision)
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_SetOutputPointsPrecision_0")] public static extern 
bool SetOutputPointsPrecision_0(IntPtr /*(vtkGeometryFilter*)*/ callingObject, int /*(int)*/ precision);

// int GetOutputPointsPrecision()
// int GetOutputPointsPrecision()
[DllImport("vtkplugin", EntryPoint="vtkGeometryFilter_GetOutputPointsPrecision_0")] public static extern 
bool GetOutputPointsPrecision_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGeometryFilter*)*/ callingObject);

}
};
