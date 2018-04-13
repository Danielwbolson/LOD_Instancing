
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkPointSet {

//       Method: virtual const char * vtkPointSet::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkPointSet* */ obj);

//       Method: void vtkPointSet::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkPointSet* */ obj);

//       Method: void vtkPointSet::CopyStructure(vtkDataSet* pd)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_CopyStructure_0")] public static extern 
bool CopyStructure(IntPtr /*vtkPointSet* */ obj, IntPtr/*vtkDataSet* */ pd);

//       Method: vtkIdType vtkPointSet::GetNumberOfPoints()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPointSet* */ obj);

//       Method: void vtkPointSet::GetPoint(vtkIdType ptId, double x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_GetPoint_0")] public static extern 
bool GetPoint(IntPtr /*vtkPointSet* */ obj, long ptId, double[] /*3*/ x);

//       Method: vtkIdType vtkPointSet::FindPoint(double x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_FindPoint_0")] public static extern 
bool FindPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPointSet* */ obj, double[] /*3*/ x);

//       Method: vtkIdType vtkPointSet::FindPoint(double x, double y, double z)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_FindPoint_1")] public static extern 
bool FindPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPointSet* */ obj, double x, double y, double z);

//       Method: double * vtkPointSet::GetPoint(vtkIdType ptId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_GetPoint_1")] public static extern 
bool GetPoint(IntPtr /*double** */ ret, IntPtr /*vtkPointSet* */ obj, long ptId);

//       Method: vtkCellIterator * vtkPointSet::NewCellIterator()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_NewCellIterator_0")] public static extern 
bool NewCellIterator(IntPtr /*vtkCellIterator** */ ret, IntPtr /*vtkPointSet* */ obj);

//       Method: vtkMTimeType vtkPointSet::GetMTime()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_GetMTime_0")] public static extern 
bool GetMTime(IntPtr /*vtkMTimeType* */ ret, IntPtr /*vtkPointSet* */ obj);

//       Method: void vtkPointSet::ComputeBounds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_ComputeBounds_0")] public static extern 
bool ComputeBounds(IntPtr /*vtkPointSet* */ obj);

//       Method: void vtkPointSet::Squeeze()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_Squeeze_0")] public static extern 
bool Squeeze(IntPtr /*vtkPointSet* */ obj);

//       Method: virtual void vtkPointSet::SetPoints(vtkPoints* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_SetPoints_0")] public static extern 
bool SetPoints(IntPtr /*vtkPointSet* */ obj, IntPtr/*vtkPoints* */ ARG_0);

//       Method: void vtkPointSet::ShallowCopy(vtkDataObject* src)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_ShallowCopy_0")] public static extern 
bool ShallowCopy(IntPtr /*vtkPointSet* */ obj, IntPtr/*vtkDataObject* */ src);

//       Method: void vtkPointSet::DeepCopy(vtkDataObject* src)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkPointSet* */ obj, IntPtr/*vtkDataObject* */ src);

//       Method: void vtkPointSet::Register(vtkObjectBase* o)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_Register_0")] public static extern 
bool Register(IntPtr /*vtkPointSet* */ obj, IntPtr/*vtkObjectBase* */ o);

//       Method: void vtkPointSet::UnRegister(vtkObjectBase* o)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPointSet_UnRegister_0")] public static extern 
bool UnRegister(IntPtr /*vtkPointSet* */ obj, IntPtr/*vtkObjectBase* */ o);

//       Method: static vtkPointSet * vtkPointSet::GetData(vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkPointSet_GetData_0")] public static extern 
bool GetData(IntPtr /*vtkPointSet** */ ret, IntPtr/*vtkInformation* */ info);

//       Method: static vtkPointSet * vtkPointSet::GetData(vtkInformationVector* v, int i)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkPointSet_GetData_1")] public static extern 
bool GetData(IntPtr /*vtkPointSet** */ ret, IntPtr/*vtkInformationVector* */ v, int i);

}
};
