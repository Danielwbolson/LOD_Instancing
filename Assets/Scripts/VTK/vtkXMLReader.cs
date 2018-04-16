
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public class vtkXMLReader : vtkAlgorithm {

//       Method: virtual const char * vtkXMLReader::GetClassName()
// 
public static string GetClassName(IntPtr obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkXMLReader.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkXMLReader::CanReadFile(const char* name)
// 
public int CanReadFile(string/*const char* */ name) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLReader.CanReadFile(p,GetPtr(), name);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataSet * vtkXMLReader::GetOutputAsDataSet()
// 
public static IntPtr GetOutputAsDataSet(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLReader.GetOutputAsDataSet(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataSet * vtkXMLReader::GetOutputAsDataSet(int index)
// 
public static IntPtr GetOutputAsDataSet(IntPtr obj, int index) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLReader.GetOutputAsDataSet(p,obj, index);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkXMLReader::GetNumberOfPointArrays()
// 
public static int GetNumberOfPointArrays(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLReader.GetNumberOfPointArrays(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkXMLReader::GetNumberOfCellArrays()
// 
public static int GetNumberOfCellArrays(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLReader.GetNumberOfCellArrays(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkXMLReader::GetNumberOfColumnArrays()
// 
public static int GetNumberOfColumnArrays(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLReader.GetNumberOfColumnArrays(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkXMLReader::GetPointArrayStatus(const char* name)
// 
public static int GetPointArrayStatus(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLReader.GetPointArrayStatus(p,obj, name);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkXMLReader::GetCellArrayStatus(const char* name)
// 
public static int GetCellArrayStatus(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLReader.GetCellArrayStatus(p,obj, name);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkXMLReader::SetPointArrayStatus(const char* name, int status)
// 
public static void SetPointArrayStatus(IntPtr obj, string/*const char* */ name, int status) {
	VTK.API_vtkXMLReader.SetPointArrayStatus(obj, name, status);
}


//       Method: void vtkXMLReader::SetCellArrayStatus(const char* name, int status)
// 
public static void SetCellArrayStatus(IntPtr obj, string/*const char* */ name, int status) {
	VTK.API_vtkXMLReader.SetCellArrayStatus(obj, name, status);
}


//       Method: int vtkXMLReader::GetColumnArrayStatus(const char* name)
// 
public static int GetColumnArrayStatus(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLReader.GetColumnArrayStatus(p,obj, name);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkXMLReader::SetColumnArrayStatus(const char* name, int status)
// 
public static void SetColumnArrayStatus(IntPtr obj, string/*const char* */ name, int status) {
	VTK.API_vtkXMLReader.SetColumnArrayStatus(obj, name, status);
}


////       Method: int vtkXMLReader::vtkNotUsed(port ))
//// 
//public static int vtkNotUsed(IntPtr obj, port )) {
//	int numElements = 1;
//	int example = new int();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkXMLReader.vtkNotUsed(p,obj, ));
//	int result = Convert.ToInt32(Marshal.ReadInt32(p));
//	Marshal.FreeHGlobal (p);
//	return result;
//}


//       Method: vtkXMLDataParser * vtkXMLReader::GetXMLParser()
// 
public static IntPtr GetXMLParser(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLReader.GetXMLParser(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkXMLReader::ProcessRequest(vtkInformation* request, vtkInformationVector** inputVector, vtkInformationVector* outputVector)
// 
public static int ProcessRequest(IntPtr obj, IntPtr/*vtkInformation* */ request, IntPtr/*vtkInformationVector** */ inputVector, IntPtr/*vtkInformationVector* */ outputVector) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkXMLReader.ProcessRequest(p,obj, request, inputVector, outputVector);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkXMLReader::SetReaderErrorObserver(vtkCommand* ARG_0)
// 
public static void SetReaderErrorObserver(IntPtr obj, IntPtr/*vtkCommand* */ ARG_0) {
	VTK.API_vtkXMLReader.SetReaderErrorObserver(obj, ARG_0);
}


//       Method: void vtkXMLReader::SetParserErrorObserver(vtkCommand* ARG_0)
// 
public static void SetParserErrorObserver(IntPtr obj, IntPtr/*vtkCommand* */ ARG_0) {
	VTK.API_vtkXMLReader.SetParserErrorObserver(obj, ARG_0);
}


}
};
