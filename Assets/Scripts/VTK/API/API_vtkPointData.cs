
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkPointData {

// static vtkPointData* New()
// static vtkPointData *New()
[DllImport("vtkplugin", EntryPoint="vtkPointData_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void NullPoint(vtkIdType ptId)
// void NullPoint(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkPointData_NullPoint_0")] public static extern 
bool NullPoint_0(IntPtr /*(vtkPointData*)*/ callingObject, long /*(vtkIdType)*/ ptId);

}
};
