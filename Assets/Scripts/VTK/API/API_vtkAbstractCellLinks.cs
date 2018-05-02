
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAbstractCellLinks {

// virtual void BuildLinks(vtkDataSet * data)
// virtual void BuildLinks(vtkDataSet *data)
[DllImport("vtkplugin", EntryPoint="vtkAbstractCellLinks_BuildLinks_0")] public static extern 
bool BuildLinks_0(IntPtr /*(vtkAbstractCellLinks*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ data);

// static int GetIdType(vtkIdType maxPtId, vtkIdType maxCellId, vtkCellArray * ca)
// static int GetIdType(vtkIdType maxPtId, vtkIdType maxCellId, vtkCellArray *ca)
[DllImport("vtkplugin", EntryPoint="vtkAbstractCellLinks_GetIdType_0")] public static extern 
bool GetIdType_0(IntPtr /*(IntPtr*)*/ return_value, long /*(vtkIdType)*/ maxPtId, long /*(vtkIdType)*/ maxCellId, IntPtr /*(vtkCellArray*)*/ ca);

}
};
