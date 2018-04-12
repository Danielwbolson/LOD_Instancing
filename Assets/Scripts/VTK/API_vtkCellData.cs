
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkCellData {

//       Method: static vtkCellData * vtkCellData::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkCellData_New_0")] public static extern 
bool New(IntPtr /*vtkCellData** */ ret);

//       Method: virtual const char * vtkCellData::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellData_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkCellData* */ obj);

}
};
