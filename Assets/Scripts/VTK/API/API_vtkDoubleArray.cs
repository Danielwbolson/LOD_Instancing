
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkDoubleArray {

// static vtkDoubleArray* New()
// static vtkDoubleArray* New()
[DllImport("vtkplugin", EntryPoint="vtkDoubleArray_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkDoubleArray* FastDownCast(vtkAbstractArray * source)
// static vtkDoubleArray* FastDownCast(vtkAbstractArray *source)
[DllImport("vtkplugin", EntryPoint="vtkDoubleArray_FastDownCast_0")] public static extern 
bool FastDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ source);

// static double GetDataTypeValueMin()
// static double GetDataTypeValueMin()
[DllImport("vtkplugin", EntryPoint="vtkDoubleArray_GetDataTypeValueMin_0")] public static extern 
bool GetDataTypeValueMin_0(IntPtr /*(IntPtr*)*/ return_value);

// static double GetDataTypeValueMax()
// static double GetDataTypeValueMax()
[DllImport("vtkplugin", EntryPoint="vtkDoubleArray_GetDataTypeValueMax_0")] public static extern 
bool GetDataTypeValueMax_0(IntPtr /*(IntPtr*)*/ return_value);

}
};
