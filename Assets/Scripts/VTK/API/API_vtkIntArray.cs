
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkIntArray {

// static vtkIntArray* New()
// static vtkIntArray* New()
[DllImport("vtkplugin", EntryPoint="vtkIntArray_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkIntArray* FastDownCast(vtkAbstractArray * source)
// static vtkIntArray* FastDownCast(vtkAbstractArray *source)
[DllImport("vtkplugin", EntryPoint="vtkIntArray_FastDownCast_0")] public static extern 
bool FastDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ source);

// static int GetDataTypeValueMin()
// static int GetDataTypeValueMin()
[DllImport("vtkplugin", EntryPoint="vtkIntArray_GetDataTypeValueMin_0")] public static extern 
bool GetDataTypeValueMin_0(IntPtr /*(IntPtr*)*/ return_value);

// static int GetDataTypeValueMax()
// static int GetDataTypeValueMax()
[DllImport("vtkplugin", EntryPoint="vtkIntArray_GetDataTypeValueMax_0")] public static extern 
bool GetDataTypeValueMax_0(IntPtr /*(IntPtr*)*/ return_value);

}
};
