
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkObserverMediator {

// static vtkObserverMediator* New()
// static vtkObserverMediator *New()
[DllImport("vtkplugin", EntryPoint="vtkObserverMediator_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkObserverMediator_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkObserverMediator_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObserverMediator*)*/ callingObject, string /*(char*)*/ type);

// static vtkObserverMediator* SafeDownCast(vtkObjectBase * o)
// static vtkObserverMediator* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkObserverMediator_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkObserverMediator* NewInstance()
// vtkObserverMediator *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkObserverMediator_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObserverMediator*)*/ callingObject);

// void SetInteractor(vtkRenderWindowInteractor * iren)
// void SetInteractor(vtkRenderWindowInteractor* iren)
[DllImport("vtkplugin", EntryPoint="vtkObserverMediator_SetInteractor_0")] public static extern 
bool SetInteractor_0(IntPtr /*(vtkObserverMediator*)*/ callingObject, IntPtr /*(vtkRenderWindowInteractor*)*/ iren);

// virtual vtkRenderWindowInteractor* GetInteractor()
// virtual vtkRenderWindowInteractor *GetInteractor ()
[DllImport("vtkplugin", EntryPoint="vtkObserverMediator_GetInteractor_0")] public static extern 
bool GetInteractor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObserverMediator*)*/ callingObject);

// int RequestCursorShape(vtkInteractorObserver * ARG_0, int cursorShape)
// int RequestCursorShape(vtkInteractorObserver*, int cursorShape)
[DllImport("vtkplugin", EntryPoint="vtkObserverMediator_RequestCursorShape_0")] public static extern 
bool RequestCursorShape_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObserverMediator*)*/ callingObject, IntPtr /*(vtkInteractorObserver*)*/ ARG_0, int /*(int)*/ cursorShape);

// void RemoveAllCursorShapeRequests(vtkInteractorObserver * ARG_0)
// void RemoveAllCursorShapeRequests(vtkInteractorObserver*)
[DllImport("vtkplugin", EntryPoint="vtkObserverMediator_RemoveAllCursorShapeRequests_0")] public static extern 
bool RemoveAllCursorShapeRequests_0(IntPtr /*(vtkObserverMediator*)*/ callingObject, IntPtr /*(vtkInteractorObserver*)*/ ARG_0);

}
};
