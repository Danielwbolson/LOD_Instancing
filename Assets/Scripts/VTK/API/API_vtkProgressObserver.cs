
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkProgressObserver {

// static vtkProgressObserver* New()
// static vtkProgressObserver *New()
[DllImport("vtkplugin", EntryPoint="vtkProgressObserver_New_0")] public static extern 
bool vtkProgressObserver_New_0(IntPtr /*(vtkProgressObserver**)*/ return_value);

// virtual void UpdateProgress(double amount)
// virtual void UpdateProgress(double amount)
[DllImport("vtkplugin", EntryPoint="vtkProgressObserver_UpdateProgress_0")] public static extern 
bool vtkProgressObserver_UpdateProgress_0(IntPtr /*(vtkProgressObserver*)*/ callingObject, double /*(double)*/ amount);

}
};
