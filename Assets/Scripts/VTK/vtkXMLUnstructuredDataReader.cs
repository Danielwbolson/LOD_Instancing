
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public class vtkXMLUnstructuredDataReader : vtkXMLDataReader {

//       Method: virtual const char * vtkXMLUnstructuredDataReader::GetClassName()
// 
public static string GetClassName(IntPtr obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkXMLUnstructuredDataReader.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkXMLUnstructuredDataReader::GetNumberOfPoints()
// 
public static long GetNumberOfPoints(IntPtr obj) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLUnstructuredDataReader.GetNumberOfPoints(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkXMLUnstructuredDataReader::GetNumberOfCells()
// 
public static long GetNumberOfCells(IntPtr obj) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLUnstructuredDataReader.GetNumberOfCells(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkXMLUnstructuredDataReader::GetNumberOfPieces()
// 
public static long GetNumberOfPieces(IntPtr obj) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLUnstructuredDataReader.GetNumberOfPieces(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkXMLUnstructuredDataReader::SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
// 
public static void SetupUpdateExtent(IntPtr obj, int piece, int numberOfPieces, int ghostLevel) {
	VTK.API_vtkXMLUnstructuredDataReader.SetupUpdateExtent(obj, piece, numberOfPieces, ghostLevel);
}


//       Method: void vtkXMLUnstructuredDataReader::CopyOutputInformation(vtkInformation* outInfo, int port)
// 
public static void CopyOutputInformation(IntPtr obj, IntPtr/*vtkInformation* */ outInfo, int port) {
	VTK.API_vtkXMLUnstructuredDataReader.CopyOutputInformation(obj, outInfo, port);
}


}
};
