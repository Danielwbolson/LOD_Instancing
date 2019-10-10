
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkRegularPolygonSource {

// static vtkRegularPolygonSource* New()
// static vtkRegularPolygonSource *New()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRegularPolygonSource*)*/ callingObject, string /*(char*)*/ type);

// static vtkRegularPolygonSource* SafeDownCast(vtkObjectBase * o)
// static vtkRegularPolygonSource* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkRegularPolygonSource* NewInstance()
// vtkRegularPolygonSource *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

// virtual void SetNumberOfSides(int _arg)
// virtual void SetNumberOfSides (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_SetNumberOfSides_0")] public static extern 
bool SetNumberOfSides_0(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetNumberOfSidesMinValue()
// virtual int GetNumberOfSidesMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GetNumberOfSidesMinValue_0")] public static extern 
bool GetNumberOfSidesMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

// virtual int GetNumberOfSidesMaxValue()
// virtual int GetNumberOfSidesMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GetNumberOfSidesMaxValue_0")] public static extern 
bool GetNumberOfSidesMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

// virtual int GetNumberOfSides()
// virtual int GetNumberOfSides ()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GetNumberOfSides_0")] public static extern 
bool GetNumberOfSides_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

// virtual void SetCenter(double _arg1, double _arg2, double _arg3)
// virtual void SetCenter (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_SetCenter_0")] public static extern 
bool SetCenter_0(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetCenter(double _arg[3])
// virtual void SetCenter (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_SetCenter_1")] public static extern 
bool SetCenter_1(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetCenter()
// virtual double *GetCenter ()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GetCenter_0")] public static extern 
bool GetCenter_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

// virtual void GetCenter(double data[3])
// virtual void GetCenter (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GetCenter_1")] public static extern 
bool GetCenter_1(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject, double /*(double[3])*/ []data);

// virtual void SetNormal(double _arg1, double _arg2, double _arg3)
// virtual void SetNormal (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_SetNormal_0")] public static extern 
bool SetNormal_0(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetNormal(double _arg[3])
// virtual void SetNormal (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_SetNormal_1")] public static extern 
bool SetNormal_1(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetNormal()
// virtual double *GetNormal ()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GetNormal_0")] public static extern 
bool GetNormal_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

// virtual void GetNormal(double data[3])
// virtual void GetNormal (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GetNormal_1")] public static extern 
bool GetNormal_1(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject, double /*(double[3])*/ []data);

// virtual void SetRadius(double _arg)
// virtual void SetRadius (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_SetRadius_0")] public static extern 
bool SetRadius_0(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetRadius()
// virtual double GetRadius ()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GetRadius_0")] public static extern 
bool GetRadius_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

// virtual void SetGeneratePolygon(int _arg)
// virtual void SetGeneratePolygon (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_SetGeneratePolygon_0")] public static extern 
bool SetGeneratePolygon_0(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetGeneratePolygon()
// virtual int GetGeneratePolygon ()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GetGeneratePolygon_0")] public static extern 
bool GetGeneratePolygon_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

// virtual void GeneratePolygonOn()
// virtual void GeneratePolygonOn ()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GeneratePolygonOn_0")] public static extern 
bool GeneratePolygonOn_0(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

// virtual void GeneratePolygonOff()
// virtual void GeneratePolygonOff ()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GeneratePolygonOff_0")] public static extern 
bool GeneratePolygonOff_0(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

// virtual void SetGeneratePolyline(int _arg)
// virtual void SetGeneratePolyline (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_SetGeneratePolyline_0")] public static extern 
bool SetGeneratePolyline_0(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetGeneratePolyline()
// virtual int GetGeneratePolyline ()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GetGeneratePolyline_0")] public static extern 
bool GetGeneratePolyline_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

// virtual void GeneratePolylineOn()
// virtual void GeneratePolylineOn ()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GeneratePolylineOn_0")] public static extern 
bool GeneratePolylineOn_0(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

// virtual void GeneratePolylineOff()
// virtual void GeneratePolylineOff ()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GeneratePolylineOff_0")] public static extern 
bool GeneratePolylineOff_0(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

// virtual void SetOutputPointsPrecision(int _arg)
// virtual void SetOutputPointsPrecision (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_SetOutputPointsPrecision_0")] public static extern 
bool SetOutputPointsPrecision_0(IntPtr /*(vtkRegularPolygonSource*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetOutputPointsPrecision()
// virtual int GetOutputPointsPrecision ()
[DllImport("vtkplugin", EntryPoint="vtkRegularPolygonSource_GetOutputPointsPrecision_0")] public static extern 
bool GetOutputPointsPrecision_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRegularPolygonSource*)*/ callingObject);

}
};
