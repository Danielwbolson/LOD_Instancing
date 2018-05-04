
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAlgorithmOutput {

// static vtkAlgorithmOutput* New()
// static vtkAlgorithmOutput *New()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithmOutput_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithmOutput_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithmOutput_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithmOutput*)*/ callingObject, string /*(char*)*/ type);

// static vtkAlgorithmOutput* SafeDownCast(vtkObjectBase * o)
// static vtkAlgorithmOutput* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithmOutput_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAlgorithmOutput* NewInstance()
// vtkAlgorithmOutput *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithmOutput_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithmOutput*)*/ callingObject);

// void SetIndex(int index)
// void SetIndex(int index)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithmOutput_SetIndex_0")] public static extern 
bool SetIndex_0(IntPtr /*(vtkAlgorithmOutput*)*/ callingObject, int /*(int)*/ index);

// int GetIndex()
// int GetIndex()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithmOutput_GetIndex_0")] public static extern 
bool GetIndex_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAlgorithmOutput*)*/ callingObject);

// vtkAlgorithm* GetProducer()
// vtkAlgorithm* GetProducer()
[DllImport("vtkplugin", EntryPoint="vtkAlgorithmOutput_GetProducer_0")] public static extern 
bool GetProducer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAlgorithmOutput*)*/ callingObject);

// void SetProducer(vtkAlgorithm * producer)
// void SetProducer(vtkAlgorithm* producer)
[DllImport("vtkplugin", EntryPoint="vtkAlgorithmOutput_SetProducer_0")] public static extern 
bool SetProducer_0(IntPtr /*(vtkAlgorithmOutput*)*/ callingObject, IntPtr /*(vtkAlgorithm*)*/ producer);

}
};
