
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkLocator {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkLocator_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkLocator_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLocator*)*/ callingObject, string /*(char*)*/ type);

// static vtkLocator* SafeDownCast(vtkObjectBase * o)
// static vtkLocator* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkLocator_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkLocator* NewInstance()
// vtkLocator *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkLocator_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void SetDataSet(vtkDataSet * ARG_0)
// virtual void SetDataSet(vtkDataSet*)
[DllImport("vtkplugin", EntryPoint="vtkLocator_SetDataSet_0")] public static extern 
bool SetDataSet_0(IntPtr /*(vtkLocator*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ ARG_0);

// virtual vtkDataSet* GetDataSet()
// virtual vtkDataSet *GetDataSet ()
[DllImport("vtkplugin", EntryPoint="vtkLocator_GetDataSet_0")] public static extern 
bool GetDataSet_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void SetMaxLevel(int _arg)
// virtual void SetMaxLevel (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkLocator_SetMaxLevel_0")] public static extern 
bool SetMaxLevel_0(IntPtr /*(vtkLocator*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetMaxLevelMinValue()
// virtual int GetMaxLevelMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkLocator_GetMaxLevelMinValue_0")] public static extern 
bool GetMaxLevelMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLocator*)*/ callingObject);

// virtual int GetMaxLevelMaxValue()
// virtual int GetMaxLevelMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkLocator_GetMaxLevelMaxValue_0")] public static extern 
bool GetMaxLevelMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLocator*)*/ callingObject);

// virtual int GetMaxLevel()
// virtual int GetMaxLevel ()
[DllImport("vtkplugin", EntryPoint="vtkLocator_GetMaxLevel_0")] public static extern 
bool GetMaxLevel_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLocator*)*/ callingObject);

// virtual int GetLevel()
// virtual int GetLevel ()
[DllImport("vtkplugin", EntryPoint="vtkLocator_GetLevel_0")] public static extern 
bool GetLevel_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void SetAutomatic(int _arg)
// virtual void SetAutomatic (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkLocator_SetAutomatic_0")] public static extern 
bool SetAutomatic_0(IntPtr /*(vtkLocator*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetAutomatic()
// virtual int GetAutomatic ()
[DllImport("vtkplugin", EntryPoint="vtkLocator_GetAutomatic_0")] public static extern 
bool GetAutomatic_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void AutomaticOn()
// virtual void AutomaticOn ()
[DllImport("vtkplugin", EntryPoint="vtkLocator_AutomaticOn_0")] public static extern 
bool AutomaticOn_0(IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void AutomaticOff()
// virtual void AutomaticOff ()
[DllImport("vtkplugin", EntryPoint="vtkLocator_AutomaticOff_0")] public static extern 
bool AutomaticOff_0(IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void SetTolerance(double _arg)
// virtual void SetTolerance (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkLocator_SetTolerance_0")] public static extern 
bool SetTolerance_0(IntPtr /*(vtkLocator*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetToleranceMinValue()
// virtual double GetToleranceMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkLocator_GetToleranceMinValue_0")] public static extern 
bool GetToleranceMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLocator*)*/ callingObject);

// virtual double GetToleranceMaxValue()
// virtual double GetToleranceMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkLocator_GetToleranceMaxValue_0")] public static extern 
bool GetToleranceMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLocator*)*/ callingObject);

// virtual double GetTolerance()
// virtual double GetTolerance ()
[DllImport("vtkplugin", EntryPoint="vtkLocator_GetTolerance_0")] public static extern 
bool GetTolerance_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void Update()
// virtual void Update()
[DllImport("vtkplugin", EntryPoint="vtkLocator_Update_0")] public static extern 
bool Update_0(IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void Initialize()
// virtual void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkLocator_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void BuildLocator()
// virtual void BuildLocator()
[DllImport("vtkplugin", EntryPoint="vtkLocator_BuildLocator_0")] public static extern 
bool BuildLocator_0(IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void FreeSearchStructure()
// virtual void FreeSearchStructure()
[DllImport("vtkplugin", EntryPoint="vtkLocator_FreeSearchStructure_0")] public static extern 
bool FreeSearchStructure_0(IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void GenerateRepresentation(int level, vtkPolyData * pd)
// virtual void GenerateRepresentation(int level, vtkPolyData *pd)
[DllImport("vtkplugin", EntryPoint="vtkLocator_GenerateRepresentation_0")] public static extern 
bool GenerateRepresentation_0(IntPtr /*(vtkLocator*)*/ callingObject, int /*(int)*/ level, IntPtr /*(vtkPolyData*)*/ pd);

// virtual vtkMTimeType GetBuildTime()
// virtual vtkMTimeType GetBuildTime ()
[DllImport("vtkplugin", EntryPoint="vtkLocator_GetBuildTime_0")] public static extern 
bool GetBuildTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLocator*)*/ callingObject);

// void Register(vtkObjectBase * o)
// void Register(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkLocator_Register_0")] public static extern 
bool Register_0(IntPtr /*(vtkLocator*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkLocator_UnRegister_0")] public static extern 
bool UnRegister_0(IntPtr /*(vtkLocator*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

}
};
