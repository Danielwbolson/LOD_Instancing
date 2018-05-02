
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
