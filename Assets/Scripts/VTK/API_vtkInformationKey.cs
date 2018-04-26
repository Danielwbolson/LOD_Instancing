
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationKey {

//       Method: const char * vtkInformationKey::GetName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationKey_GetName_0")] public static extern 
bool GetName(IntPtr /*const char** */ ret, IntPtr /*vtkInformationKey* */ obj);

//       Method: const char * vtkInformationKey::GetLocation()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationKey_GetLocation_0")] public static extern 
bool GetLocation(IntPtr /*const char** */ ret, IntPtr /*vtkInformationKey* */ obj);

//  Constructor: vtkInformationKey::vtkInformationKey(const char* name, const char* location)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationKey_vtkInformationKey_0")] public static extern 
bool vtkInformationKey(IntPtr /*vtkInformationKey* */ obj, string/*const char* */ name, string/*const char* */ location);

//       Method: virtual void vtkInformationKey::ShallowCopy(vtkInformation* from, vtkInformation* to)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationKey_ShallowCopy_0")] public static extern 
bool ShallowCopy(IntPtr /*vtkInformationKey* */ obj, IntPtr/*vtkInformation* */ from, IntPtr/*vtkInformation* */ to);

//       Method: virtual void vtkInformationKey::DeepCopy(vtkInformation* from, vtkInformation* to)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationKey_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkInformationKey* */ obj, IntPtr/*vtkInformation* */ from, IntPtr/*vtkInformation* */ to);

//       Method: virtual int vtkInformationKey::Has(vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationKey_Has_0")] public static extern 
bool Has(IntPtr /*int* */ ret, IntPtr /*vtkInformationKey* */ obj, IntPtr/*vtkInformation* */ info);

//       Method: virtual void vtkInformationKey::Remove(vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationKey_Remove_0")] public static extern 
bool Remove(IntPtr /*vtkInformationKey* */ obj, IntPtr/*vtkInformation* */ info);

//       Method: virtual void vtkInformationKey::Report(vtkInformation* info, vtkGarbageCollector* collector)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationKey_Report_0")] public static extern 
bool Report(IntPtr /*vtkInformationKey* */ obj, IntPtr/*vtkInformation* */ info, IntPtr/*vtkGarbageCollector* */ collector);

}
};
