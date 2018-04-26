
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkLocator {

//       Method: virtual const char * vtkLocator::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLocator_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkLocator* */ obj);

//       Method: virtual void vtkLocator::Update()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLocator_Update_0")] public static extern 
bool Update(IntPtr /*vtkLocator* */ obj);

//       Method: virtual void vtkLocator::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLocator_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkLocator* */ obj);

//       Method: virtual void vtkLocator::BuildLocator()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLocator_BuildLocator_0")] public static extern 
bool BuildLocator(IntPtr /*vtkLocator* */ obj);

//       Method: virtual void vtkLocator::FreeSearchStructure()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLocator_FreeSearchStructure_0")] public static extern 
bool FreeSearchStructure(IntPtr /*vtkLocator* */ obj);

//       Method: virtual void vtkLocator::GenerateRepresentation(int level, vtkPolyData* pd)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLocator_GenerateRepresentation_0")] public static extern 
bool GenerateRepresentation(IntPtr /*vtkLocator* */ obj, int level, IntPtr/*vtkPolyData* */ pd);

//       Method: void vtkLocator::Register(vtkObjectBase* o)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLocator_Register_0")] public static extern 
bool Register(IntPtr /*vtkLocator* */ obj, IntPtr/*vtkObjectBase* */ o);

//       Method: void vtkLocator::UnRegister(vtkObjectBase* o)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLocator_UnRegister_0")] public static extern 
bool UnRegister(IntPtr /*vtkLocator* */ obj, IntPtr/*vtkObjectBase* */ o);

}
};
