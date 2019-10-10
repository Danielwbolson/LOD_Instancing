
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInteractorObserver {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInteractorObserver*)*/ callingObject, string /*(char*)*/ type);

// static vtkInteractorObserver* SafeDownCast(vtkObjectBase * o)
// static vtkInteractorObserver* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInteractorObserver* NewInstance()
// vtkInteractorObserver *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual void SetEnabled(int ARG_0)
// virtual void SetEnabled(int)
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_SetEnabled_0")] public static extern 
bool SetEnabled_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject, int /*(int)*/ ARG_0);

// int GetEnabled()
// int GetEnabled()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_GetEnabled_0")] public static extern 
bool GetEnabled_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// void EnabledOn()
// void EnabledOn()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_EnabledOn_0")] public static extern 
bool EnabledOn_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// void EnabledOff()
// void EnabledOff()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_EnabledOff_0")] public static extern 
bool EnabledOff_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// void On()
// void On()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_On_0")] public static extern 
bool On_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// void Off()
// void Off()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_Off_0")] public static extern 
bool Off_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual void SetInteractor(vtkRenderWindowInteractor * iren)
// virtual void SetInteractor(vtkRenderWindowInteractor* iren)
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_SetInteractor_0")] public static extern 
bool SetInteractor_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject, IntPtr /*(vtkRenderWindowInteractor*)*/ iren);

// virtual vtkRenderWindowInteractor* GetInteractor()
// virtual vtkRenderWindowInteractor *GetInteractor ()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_GetInteractor_0")] public static extern 
bool GetInteractor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual void SetPriority(float _arg)
// virtual void SetPriority (float _arg)
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_SetPriority_0")] public static extern 
bool SetPriority_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject, float /*(float)*/ _arg);

// virtual float GetPriorityMinValue()
// virtual float GetPriorityMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_GetPriorityMinValue_0")] public static extern 
bool GetPriorityMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual float GetPriorityMaxValue()
// virtual float GetPriorityMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_GetPriorityMaxValue_0")] public static extern 
bool GetPriorityMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual float GetPriority()
// virtual float GetPriority ()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_GetPriority_0")] public static extern 
bool GetPriority_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual void PickingManagedOn()
// virtual void PickingManagedOn ()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_PickingManagedOn_0")] public static extern 
bool PickingManagedOn_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual void PickingManagedOff()
// virtual void PickingManagedOff ()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_PickingManagedOff_0")] public static extern 
bool PickingManagedOff_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual void SetPickingManaged(bool _arg)
// virtual void SetPickingManaged (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_SetPickingManaged_0")] public static extern 
bool SetPickingManaged_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetPickingManaged()
// virtual bool GetPickingManaged ()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_GetPickingManaged_0")] public static extern 
bool GetPickingManaged_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual void SetKeyPressActivation(int _arg)
// virtual void SetKeyPressActivation (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_SetKeyPressActivation_0")] public static extern 
bool SetKeyPressActivation_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetKeyPressActivation()
// virtual int GetKeyPressActivation ()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_GetKeyPressActivation_0")] public static extern 
bool GetKeyPressActivation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual void KeyPressActivationOn()
// virtual void KeyPressActivationOn ()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_KeyPressActivationOn_0")] public static extern 
bool KeyPressActivationOn_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual void KeyPressActivationOff()
// virtual void KeyPressActivationOff ()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_KeyPressActivationOff_0")] public static extern 
bool KeyPressActivationOff_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual void SetKeyPressActivationValue(char _arg)
// virtual void SetKeyPressActivationValue (char _arg)
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_SetKeyPressActivationValue_0")] public static extern 
bool SetKeyPressActivationValue_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject, char /*(char)*/ _arg);

// virtual char GetKeyPressActivationValue()
// virtual char GetKeyPressActivationValue ()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_GetKeyPressActivationValue_0")] public static extern 
bool GetKeyPressActivationValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual vtkRenderer* GetDefaultRenderer()
// virtual vtkRenderer *GetDefaultRenderer ()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_GetDefaultRenderer_0")] public static extern 
bool GetDefaultRenderer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual void SetDefaultRenderer(vtkRenderer * ARG_0)
// virtual void SetDefaultRenderer(vtkRenderer*)
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_SetDefaultRenderer_0")] public static extern 
bool SetDefaultRenderer_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ARG_0);

// virtual vtkRenderer* GetCurrentRenderer()
// virtual vtkRenderer *GetCurrentRenderer ()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_GetCurrentRenderer_0")] public static extern 
bool GetCurrentRenderer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// virtual void SetCurrentRenderer(vtkRenderer * ARG_0)
// virtual void SetCurrentRenderer(vtkRenderer*)
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_SetCurrentRenderer_0")] public static extern 
bool SetCurrentRenderer_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ARG_0);

// virtual void OnChar()
// virtual void OnChar()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_OnChar_0")] public static extern 
bool OnChar_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject);

// static void ComputeDisplayToWorld(vtkRenderer * ren, double x, double y, double z, double worldPt[4])
// static void ComputeDisplayToWorld(vtkRenderer *ren, double x, double y, double z, double worldPt[4])
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_ComputeDisplayToWorld_0")] public static extern 
bool ComputeDisplayToWorld_0(IntPtr /*(vtkRenderer*)*/ ren, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, double /*(double[4])*/ []worldPt);

// static void ComputeWorldToDisplay(vtkRenderer * ren, double x, double y, double z, double displayPt[3])
// static void ComputeWorldToDisplay(vtkRenderer *ren, double x, double y, double z, double displayPt[3])
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_ComputeWorldToDisplay_0")] public static extern 
bool ComputeWorldToDisplay_0(IntPtr /*(vtkRenderer*)*/ ren, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, double /*(double[3])*/ []displayPt);

// void ReleaseFocus()
// void ReleaseFocus()
[DllImport("vtkplugin", EntryPoint="vtkInteractorObserver_ReleaseFocus_0")] public static extern 
bool ReleaseFocus_0(IntPtr /*(vtkInteractorObserver*)*/ callingObject);

}
};
