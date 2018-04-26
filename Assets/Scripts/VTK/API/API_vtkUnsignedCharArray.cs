
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkUnsignedCharArray {

// static vtkUnsignedCharArray* New()
// static vtkUnsignedCharArray* New()
[DllImport("vtkplugin", EntryPoint="vtkUnsignedCharArray_New_0")] public static extern 
bool vtkUnsignedCharArray_New_0(IntPtr /*(vtkUnsignedCharArray**)*/ return_value);

// static vtkUnsignedCharArray* FastDownCast(vtkAbstractArray * source)
// static vtkUnsignedCharArray* FastDownCast(vtkAbstractArray *source)
[DllImport("vtkplugin", EntryPoint="vtkUnsignedCharArray_FastDownCast_0")] public static extern 
bool vtkUnsignedCharArray_FastDownCast_0(IntPtr /*(vtkUnsignedCharArray**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ source);

// static char GetDataTypeValueMin()
// static unsigned char GetDataTypeValueMin()
[DllImport("vtkplugin", EntryPoint="vtkUnsignedCharArray_GetDataTypeValueMin_0")] public static extern 
bool vtkUnsignedCharArray_GetDataTypeValueMin_0(IntPtr /*(char*)*/ return_value);

// static char GetDataTypeValueMax()
// static unsigned char GetDataTypeValueMax()
[DllImport("vtkplugin", EntryPoint="vtkUnsignedCharArray_GetDataTypeValueMax_0")] public static extern 
bool vtkUnsignedCharArray_GetDataTypeValueMax_0(IntPtr /*(char*)*/ return_value);

}
};
