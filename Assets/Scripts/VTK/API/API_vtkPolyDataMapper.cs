
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPolyDataMapper {

// static vtkPolyDataMapper* New()
// static vtkPolyDataMapper *New()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPolyDataMapper*)*/ callingObject, string /*(char*)*/ type);

// static vtkPolyDataMapper* SafeDownCast(vtkObjectBase * o)
// static vtkPolyDataMapper* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPolyDataMapper* NewInstance()
// vtkPolyDataMapper *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPolyDataMapper*)*/ callingObject);

// virtual void RenderPiece(vtkRenderer * ren, vtkActor * act)
// virtual void RenderPiece(vtkRenderer *ren, vtkActor *act)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_RenderPiece_0")] public static extern 
bool RenderPiece_0(IntPtr /*(vtkPolyDataMapper*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ren, IntPtr /*(vtkActor*)*/ act);

// void Render(vtkRenderer * ren, vtkActor * act)
// void Render(vtkRenderer *ren, vtkActor *act)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkPolyDataMapper*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ren, IntPtr /*(vtkActor*)*/ act);

// void SetInputData(vtkPolyData * in)
// void SetInputData(vtkPolyData *in)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_SetInputData_0")] public static extern 
bool SetInputData_0(IntPtr /*(vtkPolyDataMapper*)*/ callingObject, IntPtr /*(vtkPolyData*)*/ in_var);

// vtkPolyData* GetInput()
// vtkPolyData *GetInput()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_GetInput_0")] public static extern 
bool GetInput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPolyDataMapper*)*/ callingObject);

// void Update(int port)
// void Update(int port)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_Update_0")] public static extern 
bool Update_0(IntPtr /*(vtkPolyDataMapper*)*/ callingObject, int /*(int)*/ port);

// void Update()
// void Update()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_Update_1")] public static extern 
bool Update_1(IntPtr /*(vtkPolyDataMapper*)*/ callingObject);

// virtual void SetPiece(int _arg)
// virtual void SetPiece (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_SetPiece_0")] public static extern 
bool SetPiece_0(IntPtr /*(vtkPolyDataMapper*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetPiece()
// virtual int GetPiece ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_GetPiece_0")] public static extern 
bool GetPiece_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPolyDataMapper*)*/ callingObject);

// virtual void SetNumberOfPieces(int _arg)
// virtual void SetNumberOfPieces (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_SetNumberOfPieces_0")] public static extern 
bool SetNumberOfPieces_0(IntPtr /*(vtkPolyDataMapper*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetNumberOfPieces()
// virtual int GetNumberOfPieces ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_GetNumberOfPieces_0")] public static extern 
bool GetNumberOfPieces_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPolyDataMapper*)*/ callingObject);

// virtual void SetNumberOfSubPieces(int _arg)
// virtual void SetNumberOfSubPieces (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_SetNumberOfSubPieces_0")] public static extern 
bool SetNumberOfSubPieces_0(IntPtr /*(vtkPolyDataMapper*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetNumberOfSubPieces()
// virtual int GetNumberOfSubPieces ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_GetNumberOfSubPieces_0")] public static extern 
bool GetNumberOfSubPieces_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPolyDataMapper*)*/ callingObject);

// virtual void SetGhostLevel(int _arg)
// virtual void SetGhostLevel (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_SetGhostLevel_0")] public static extern 
bool SetGhostLevel_0(IntPtr /*(vtkPolyDataMapper*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetGhostLevel()
// virtual int GetGhostLevel ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_GetGhostLevel_0")] public static extern 
bool GetGhostLevel_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPolyDataMapper*)*/ callingObject);

// double* GetBounds()
// double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPolyDataMapper*)*/ callingObject);

// void GetBounds(double bounds[6])
// void GetBounds(double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_GetBounds_1")] public static extern 
bool GetBounds_1(IntPtr /*(vtkPolyDataMapper*)*/ callingObject, double /*(double[6])*/ []bounds);

// void ShallowCopy(vtkAbstractMapper * m)
// void ShallowCopy(vtkAbstractMapper *m)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkPolyDataMapper*)*/ callingObject, IntPtr /*(vtkAbstractMapper*)*/ m);

// virtual void RemoveVertexAttributeMapping(const char * vertexAttributeName)
// virtual void RemoveVertexAttributeMapping(const char* vertexAttributeName)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_RemoveVertexAttributeMapping_0")] public static extern 
bool RemoveVertexAttributeMapping_0(IntPtr /*(vtkPolyDataMapper*)*/ callingObject, string /*(char*)*/ vertexAttributeName);

// virtual void RemoveAllVertexAttributeMappings()
// virtual void RemoveAllVertexAttributeMappings()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataMapper_RemoveAllVertexAttributeMappings_0")] public static extern 
bool RemoveAllVertexAttributeMappings_0(IntPtr /*(vtkPolyDataMapper*)*/ callingObject);

}
};
