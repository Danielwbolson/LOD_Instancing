
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkXMLImageDataReader {

// static vtkXMLImageDataReader* New()
// static vtkXMLImageDataReader *New()
[DllImport("vtkplugin", EntryPoint="vtkXMLImageDataReader_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// vtkImageData* GetOutput()
// vtkImageData *GetOutput()
[DllImport("vtkplugin", EntryPoint="vtkXMLImageDataReader_GetOutput_0")] public static extern 
bool GetOutput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLImageDataReader*)*/ callingObject);

// vtkImageData* GetOutput(int idx)
// vtkImageData *GetOutput(int idx)
[DllImport("vtkplugin", EntryPoint="vtkXMLImageDataReader_GetOutput_1")] public static extern 
bool GetOutput_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLImageDataReader*)*/ callingObject, int /*(int)*/ idx);

}
};
