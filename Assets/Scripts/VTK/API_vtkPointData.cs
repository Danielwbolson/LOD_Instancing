
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkPointData {

//       Method: static vtkPointData * vtkPointData::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkPointData_New_0")] public static extern 
bool New(IntPtr /*vtkPointData** */ ret);

//       Method: virtual const char * vtkPointData::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointData_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkPointData* */ obj);

//       Method: void vtkPointData::NullPoint(vtkIdType ptId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointData_NullPoint_0")] public static extern 
bool NullPoint(IntPtr /*vtkPointData* */ obj, long ptId);

}
};
