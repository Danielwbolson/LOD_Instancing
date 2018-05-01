
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkXMLUnstructuredDataReader {

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject);

// vtkIdType GetNumberOfCells()
// vtkIdType GetNumberOfCells()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_GetNumberOfCells_0")] public static extern 
bool GetNumberOfCells_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject);

// virtual vtkIdType GetNumberOfPieces()
// virtual vtkIdType GetNumberOfPieces()
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_GetNumberOfPieces_0")] public static extern 
bool GetNumberOfPieces_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject);

// void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
// void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
[DllImport("vtkplugin", EntryPoint="vtkXMLUnstructuredDataReader_SetupUpdateExtent_0")] public static extern 
bool SetupUpdateExtent_0(IntPtr /*(vtkXMLUnstructuredDataReader*)*/ callingObject, int /*(int)*/ piece, int /*(int)*/ numberOfPieces, int /*(int)*/ ghostLevel);

}
};
