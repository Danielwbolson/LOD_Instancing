
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkCellIterator {

//       Method: void vtkCellIterator::InitTraversal()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellIterator_InitTraversal_0")] public static extern 
bool InitTraversal(IntPtr /*vtkCellIterator* */ obj);

//       Method: void vtkCellIterator::GoToNextCell()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellIterator_GoToNextCell_0")] public static extern 
bool GoToNextCell(IntPtr /*vtkCellIterator* */ obj);

//       Method: virtual bool vtkCellIterator::IsDoneWithTraversal()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellIterator_IsDoneWithTraversal_0")] public static extern 
bool IsDoneWithTraversal(IntPtr /*bool* */ ret, IntPtr /*vtkCellIterator* */ obj);

//       Method: int vtkCellIterator::GetCellType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellIterator_GetCellType_0")] public static extern 
bool GetCellType(IntPtr /*int* */ ret, IntPtr /*vtkCellIterator* */ obj);

//       Method: int vtkCellIterator::GetCellDimension()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellIterator_GetCellDimension_0")] public static extern 
bool GetCellDimension(IntPtr /*int* */ ret, IntPtr /*vtkCellIterator* */ obj);

//       Method: virtual vtkIdType vtkCellIterator::GetCellId()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellIterator_GetCellId_0")] public static extern 
bool GetCellId(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellIterator* */ obj);

//       Method: vtkIdList * vtkCellIterator::GetPointIds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellIterator_GetPointIds_0")] public static extern 
bool GetPointIds(IntPtr /*vtkIdList** */ ret, IntPtr /*vtkCellIterator* */ obj);

//       Method: vtkPoints * vtkCellIterator::GetPoints()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellIterator_GetPoints_0")] public static extern 
bool GetPoints(IntPtr /*vtkPoints** */ ret, IntPtr /*vtkCellIterator* */ obj);

//       Method: vtkIdList * vtkCellIterator::GetFaces()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellIterator_GetFaces_0")] public static extern 
bool GetFaces(IntPtr /*vtkIdList** */ ret, IntPtr /*vtkCellIterator* */ obj);

//       Method: void vtkCellIterator::GetCell(vtkGenericCell* cell)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellIterator_GetCell_0")] public static extern 
bool GetCell(IntPtr /*vtkCellIterator* */ obj, IntPtr/*vtkGenericCell* */ cell);

//       Method: vtkIdType vtkCellIterator::GetNumberOfPoints()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellIterator_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellIterator* */ obj);

//       Method: vtkIdType vtkCellIterator::GetNumberOfFaces()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCellIterator_GetNumberOfFaces_0")] public static extern 
bool GetNumberOfFaces(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkCellIterator* */ obj);

}
};
