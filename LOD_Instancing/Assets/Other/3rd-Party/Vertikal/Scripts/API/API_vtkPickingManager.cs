
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPickingManager {

// static vtkPickingManager* New()
// static vtkPickingManager *New()
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPickingManager*)*/ callingObject, string /*(char*)*/ type);

// static vtkPickingManager* SafeDownCast(vtkObjectBase * o)
// static vtkPickingManager* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPickingManager* NewInstance()
// vtkPickingManager *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPickingManager*)*/ callingObject);

// virtual void EnabledOn()
// virtual void EnabledOn ()
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_EnabledOn_0")] public static extern 
bool EnabledOn_0(IntPtr /*(vtkPickingManager*)*/ callingObject);

// virtual void EnabledOff()
// virtual void EnabledOff ()
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_EnabledOff_0")] public static extern 
bool EnabledOff_0(IntPtr /*(vtkPickingManager*)*/ callingObject);

// virtual void SetEnabled(bool _arg)
// virtual void SetEnabled (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_SetEnabled_0")] public static extern 
bool SetEnabled_0(IntPtr /*(vtkPickingManager*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetEnabled()
// virtual bool GetEnabled ()
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_GetEnabled_0")] public static extern 
bool GetEnabled_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPickingManager*)*/ callingObject);

// void SetOptimizeOnInteractorEvents(bool optimize)
// void SetOptimizeOnInteractorEvents(bool optimize)
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_SetOptimizeOnInteractorEvents_0")] public static extern 
bool SetOptimizeOnInteractorEvents_0(IntPtr /*(vtkPickingManager*)*/ callingObject, bool /*(bool)*/ optimize);

// virtual bool GetOptimizeOnInteractorEvents()
// virtual bool GetOptimizeOnInteractorEvents ()
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_GetOptimizeOnInteractorEvents_0")] public static extern 
bool GetOptimizeOnInteractorEvents_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPickingManager*)*/ callingObject);

// void SetInteractor(vtkRenderWindowInteractor * iren)
// void SetInteractor(vtkRenderWindowInteractor* iren)
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_SetInteractor_0")] public static extern 
bool SetInteractor_0(IntPtr /*(vtkPickingManager*)*/ callingObject, IntPtr /*(vtkRenderWindowInteractor*)*/ iren);

// virtual vtkRenderWindowInteractor* GetInteractor()
// virtual vtkRenderWindowInteractor* GetInteractor ()
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_GetInteractor_0")] public static extern 
bool GetInteractor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPickingManager*)*/ callingObject);

// void RemoveObject(vtkObject * object)
// void RemoveObject(vtkObject* object)
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_RemoveObject_0")] public static extern 
bool RemoveObject_0(IntPtr /*(vtkPickingManager*)*/ callingObject, IntPtr /*(vtkObject*)*/ obj);

// bool Pick(vtkAbstractPicker * picker, vtkObject * object)
// bool Pick(vtkAbstractPicker* picker, vtkObject* object)
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_Pick_0")] public static extern 
bool Pick_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPickingManager*)*/ callingObject, IntPtr /*(vtkAbstractPicker*)*/ picker, IntPtr /*(vtkObject*)*/ obj);

// bool Pick(vtkObject * object)
// bool Pick(vtkObject* object)
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_Pick_1")] public static extern 
bool Pick_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPickingManager*)*/ callingObject, IntPtr /*(vtkObject*)*/ obj);

// bool Pick(vtkAbstractPicker * picker)
// bool Pick(vtkAbstractPicker* picker)
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_Pick_2")] public static extern 
bool Pick_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPickingManager*)*/ callingObject, IntPtr /*(vtkAbstractPicker*)*/ picker);

// vtkAssemblyPath* GetAssemblyPath(double X, double Y, double Z, vtkAbstractPropPicker * picker, vtkRenderer * renderer, vtkObject * obj)
// vtkAssemblyPath* GetAssemblyPath(double X, double Y, double Z, vtkAbstractPropPicker* picker, vtkRenderer* renderer, vtkObject* obj)
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_GetAssemblyPath_0")] public static extern 
bool GetAssemblyPath_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPickingManager*)*/ callingObject, double /*(double)*/ X, double /*(double)*/ Y, double /*(double)*/ Z, IntPtr /*(vtkAbstractPropPicker*)*/ picker, IntPtr /*(vtkRenderer*)*/ renderer, IntPtr /*(vtkObject*)*/ obj);

// int GetNumberOfPickers()
// int GetNumberOfPickers()
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_GetNumberOfPickers_0")] public static extern 
bool GetNumberOfPickers_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPickingManager*)*/ callingObject);

// int GetNumberOfObjectsLinked(vtkAbstractPicker * picker)
// int GetNumberOfObjectsLinked(vtkAbstractPicker* picker)
[DllImport("vtkplugin", EntryPoint="vtkPickingManager_GetNumberOfObjectsLinked_0")] public static extern 
bool GetNumberOfObjectsLinked_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPickingManager*)*/ callingObject, IntPtr /*(vtkAbstractPicker*)*/ picker);

}
};
