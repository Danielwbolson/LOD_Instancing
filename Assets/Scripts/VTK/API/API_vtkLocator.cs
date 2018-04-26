
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkLocator {

// virtual void SetDataSet(vtkDataSet * ARG_0)
// virtual void SetDataSet(vtkDataSet*)
[DllImport("vtkplugin", EntryPoint="vtkLocator_SetDataSet_0")] public static extern 
bool vtkLocator_SetDataSet_0(IntPtr /*(vtkLocator*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ ARG_0);

// virtual void Update()
// virtual void Update()
[DllImport("vtkplugin", EntryPoint="vtkLocator_Update_0")] public static extern 
bool vtkLocator_Update_0(IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void Initialize()
// virtual void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkLocator_Initialize_0")] public static extern 
bool vtkLocator_Initialize_0(IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void BuildLocator()
// virtual void BuildLocator()
[DllImport("vtkplugin", EntryPoint="vtkLocator_BuildLocator_0")] public static extern 
bool vtkLocator_BuildLocator_0(IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void FreeSearchStructure()
// virtual void FreeSearchStructure()
[DllImport("vtkplugin", EntryPoint="vtkLocator_FreeSearchStructure_0")] public static extern 
bool vtkLocator_FreeSearchStructure_0(IntPtr /*(vtkLocator*)*/ callingObject);

// virtual void GenerateRepresentation(int level, vtkPolyData * pd)
// virtual void GenerateRepresentation(int level, vtkPolyData *pd)
[DllImport("vtkplugin", EntryPoint="vtkLocator_GenerateRepresentation_0")] public static extern 
bool vtkLocator_GenerateRepresentation_0(IntPtr /*(vtkLocator*)*/ callingObject, int /*(int)*/ level, IntPtr /*(vtkPolyData*)*/ pd);

// void Register(vtkObjectBase * o)
// void Register(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkLocator_Register_0")] public static extern 
bool vtkLocator_Register_0(IntPtr /*(vtkLocator*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkLocator_UnRegister_0")] public static extern 
bool vtkLocator_UnRegister_0(IntPtr /*(vtkLocator*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

}
};
