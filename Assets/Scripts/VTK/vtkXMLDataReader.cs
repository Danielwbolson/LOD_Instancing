
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public class vtkXMLDataReader : vtkXMLReader {

//       Method: virtual const char * vtkXMLDataReader::GetClassName()
// 
	public static string GetClassName(vtkXMLDataReader obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkXMLDataReader.GetClassName(p,obj.GetPtr());
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkXMLDataReader::GetNumberOfPoints()
// 
public static long GetNumberOfPoints(IntPtr obj) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLDataReader.GetNumberOfPoints(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkXMLDataReader::GetNumberOfCells()
// 
public static long GetNumberOfCells(IntPtr obj) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLDataReader.GetNumberOfCells(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkXMLDataReader::CopyOutputInformation(vtkInformation* outInfo, int port)
// 
public static void CopyOutputInformation(IntPtr obj, IntPtr/*vtkInformation* */ outInfo, int port) {
	VTK.API_vtkXMLDataReader.CopyOutputInformation(obj, outInfo, port);
}


}
};
