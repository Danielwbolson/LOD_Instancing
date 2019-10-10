
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAbstractPicker {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractPicker*)*/ callingObject, string /*(char*)*/ type);

// static vtkAbstractPicker* SafeDownCast(vtkObjectBase * o)
// static vtkAbstractPicker* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAbstractPicker* NewInstance()
// vtkAbstractPicker *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPicker*)*/ callingObject);

// virtual vtkRenderer* GetRenderer()
// virtual vtkRenderer *GetRenderer ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_GetRenderer_0")] public static extern 
bool GetRenderer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPicker*)*/ callingObject);

// virtual double* GetSelectionPoint()
// virtual double *GetSelectionPoint ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_GetSelectionPoint_0")] public static extern 
bool GetSelectionPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPicker*)*/ callingObject);

// virtual void GetSelectionPoint(double data[3])
// virtual void GetSelectionPoint (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_GetSelectionPoint_1")] public static extern 
bool GetSelectionPoint_1(IntPtr /*(vtkAbstractPicker*)*/ callingObject, double /*(double[3])*/ []data);

// virtual double* GetPickPosition()
// virtual double *GetPickPosition ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_GetPickPosition_0")] public static extern 
bool GetPickPosition_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPicker*)*/ callingObject);

// virtual void GetPickPosition(double data[3])
// virtual void GetPickPosition (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_GetPickPosition_1")] public static extern 
bool GetPickPosition_1(IntPtr /*(vtkAbstractPicker*)*/ callingObject, double /*(double[3])*/ []data);

// virtual int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer * renderer)
// virtual int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer *renderer)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_Pick_0")] public static extern 
bool Pick_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractPicker*)*/ callingObject, double /*(double)*/ selectionX, double /*(double)*/ selectionY, double /*(double)*/ selectionZ, IntPtr /*(vtkRenderer*)*/ renderer);

// int Pick(double selectionPt[3], vtkRenderer * ren)
// int Pick(double selectionPt[3], vtkRenderer *ren)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_Pick_1")] public static extern 
bool Pick_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractPicker*)*/ callingObject, double /*(double[3])*/ []selectionPt, IntPtr /*(vtkRenderer*)*/ ren);

// virtual int Pick3DPoint(double ARG_0[3], vtkRenderer * ARG_1)
// virtual int Pick3DPoint(double [3], vtkRenderer * )
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_Pick3DPoint_0")] public static extern 
bool Pick3DPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractPicker*)*/ callingObject, double /*(double[3])*/ []ARG_0, IntPtr /*(vtkRenderer*)*/ ARG_1);

// virtual int Pick3DRay(double ARG_0[3], double ARG_1[4], vtkRenderer * ARG_2)
// virtual int Pick3DRay(double [3], double [4], vtkRenderer * )
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_Pick3DRay_0")] public static extern 
bool Pick3DRay_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractPicker*)*/ callingObject, double /*(double[3])*/ []ARG_0, double /*(double[4])*/ []ARG_1, IntPtr /*(vtkRenderer*)*/ ARG_2);

// virtual void SetPickFromList(int _arg)
// virtual void SetPickFromList (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_SetPickFromList_0")] public static extern 
bool SetPickFromList_0(IntPtr /*(vtkAbstractPicker*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetPickFromList()
// virtual int GetPickFromList ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_GetPickFromList_0")] public static extern 
bool GetPickFromList_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractPicker*)*/ callingObject);

// virtual void PickFromListOn()
// virtual void PickFromListOn ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_PickFromListOn_0")] public static extern 
bool PickFromListOn_0(IntPtr /*(vtkAbstractPicker*)*/ callingObject);

// virtual void PickFromListOff()
// virtual void PickFromListOff ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_PickFromListOff_0")] public static extern 
bool PickFromListOff_0(IntPtr /*(vtkAbstractPicker*)*/ callingObject);

// void InitializePickList()
// void InitializePickList()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_InitializePickList_0")] public static extern 
bool InitializePickList_0(IntPtr /*(vtkAbstractPicker*)*/ callingObject);

// void AddPickList(vtkProp * ARG_0)
// void AddPickList(vtkProp *)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_AddPickList_0")] public static extern 
bool AddPickList_0(IntPtr /*(vtkAbstractPicker*)*/ callingObject, IntPtr /*(vtkProp*)*/ ARG_0);

// void DeletePickList(vtkProp * ARG_0)
// void DeletePickList(vtkProp *)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_DeletePickList_0")] public static extern 
bool DeletePickList_0(IntPtr /*(vtkAbstractPicker*)*/ callingObject, IntPtr /*(vtkProp*)*/ ARG_0);

// vtkPropCollection* GetPickList()
// vtkPropCollection *GetPickList()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPicker_GetPickList_0")] public static extern 
bool GetPickList_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPicker*)*/ callingObject);

}
};
