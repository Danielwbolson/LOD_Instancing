
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkCellData {

// static vtkCellData* New()
// static vtkCellData *New()
[DllImport("vtkplugin", EntryPoint="vtkCellData_New_0")] public static extern 
bool New_0(IntPtr /*(vtkCellData**)*/ return_value);

}
};
