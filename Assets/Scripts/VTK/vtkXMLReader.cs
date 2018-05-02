

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLReader : vtkAlgorithm {
		public vtkXMLReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLReader(IntPtr p) {return new vtkXMLReader(p);}
		public static implicit operator  IntPtr(vtkXMLReader o) {return o.GetPtr();}

// virtual int CanReadFile(const char * name)
// "virtual int CanReadFile(const char* name)"
public int CanReadFile(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLReader.CanReadFile_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// vtkDataSet* GetOutputAsDataSet()
// "vtkDataSet* GetOutputAsDataSet()"
public vtkDataSet GetOutputAsDataSet() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.GetOutputAsDataSet_0(returnPointer.GetPtr(), this);
	return (vtkDataSet)(IntPtr)returnPointer;
}


// vtkDataSet* GetOutputAsDataSet(int index)
// "vtkDataSet* GetOutputAsDataSet(int index)"
public vtkDataSet GetOutputAsDataSet(int /*(int)*/ index) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.GetOutputAsDataSet_1(returnPointer.GetPtr(), this, index);
	return (vtkDataSet)(IntPtr)returnPointer;
}


// int GetNumberOfPointArrays()
// "int GetNumberOfPointArrays()"
public int GetNumberOfPointArrays() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLReader.GetNumberOfPointArrays_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetNumberOfCellArrays()
// "int GetNumberOfCellArrays()"
public int GetNumberOfCellArrays() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLReader.GetNumberOfCellArrays_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetNumberOfColumnArrays()
// "int GetNumberOfColumnArrays()"
public int GetNumberOfColumnArrays() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLReader.GetNumberOfColumnArrays_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// char* GetPointArrayName(int index)
// "const char* GetPointArrayName(int index)"
public string GetPointArrayName(int /*(int)*/ index) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.GetPointArrayName_0(returnPointer.GetPtr(), this, index);
	return (string)returnPointer;
}


// char* GetCellArrayName(int index)
// "const char* GetCellArrayName(int index)"
public string GetCellArrayName(int /*(int)*/ index) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.GetCellArrayName_0(returnPointer.GetPtr(), this, index);
	return (string)returnPointer;
}


// char* GetColumnArrayName(int index)
// "const char* GetColumnArrayName(int index)"
public string GetColumnArrayName(int /*(int)*/ index) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.GetColumnArrayName_0(returnPointer.GetPtr(), this, index);
	return (string)returnPointer;
}


// int GetPointArrayStatus(const char * name)
// "int GetPointArrayStatus(const char* name)"
public int GetPointArrayStatus(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLReader.GetPointArrayStatus_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// int GetCellArrayStatus(const char * name)
// "int GetCellArrayStatus(const char* name)"
public int GetCellArrayStatus(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLReader.GetCellArrayStatus_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// void SetPointArrayStatus(const char * name, int status)
// "void SetPointArrayStatus(const char* name, int status)"
public void SetPointArrayStatus(string /*(char*)*/ name, int /*(int)*/ status) {
	VTK_API.API_vtkXMLReader.SetPointArrayStatus_0(this, name, status);
}


// void SetCellArrayStatus(const char * name, int status)
// "void SetCellArrayStatus(const char* name, int status)"
public void SetCellArrayStatus(string /*(char*)*/ name, int /*(int)*/ status) {
	VTK_API.API_vtkXMLReader.SetCellArrayStatus_0(this, name, status);
}


// int GetColumnArrayStatus(const char * name)
// "int GetColumnArrayStatus(const char* name)"
public int GetColumnArrayStatus(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLReader.GetColumnArrayStatus_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// void SetColumnArrayStatus(const char * name, int status)
// "void SetColumnArrayStatus(const char* name, int status)"
public void SetColumnArrayStatus(string /*(char*)*/ name, int /*(int)*/ status) {
	VTK_API.API_vtkXMLReader.SetColumnArrayStatus_0(this, name, status);
}


// vtkXMLDataParser* GetXMLParser()
// "vtkXMLDataParser* GetXMLParser()"
public vtkXMLDataParser GetXMLParser() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.GetXMLParser_0(returnPointer.GetPtr(), this);
	return (vtkXMLDataParser)(IntPtr)returnPointer;
}


// void SetReaderErrorObserver(vtkCommand * ARG_0)
// "void SetReaderErrorObserver(vtkCommand *)"
public void SetReaderErrorObserver(vtkCommand /*(vtkCommand*)*/ ARG_0) {
	VTK_API.API_vtkXMLReader.SetReaderErrorObserver_0(this, ARG_0);
}


// void SetParserErrorObserver(vtkCommand * ARG_0)
// "void SetParserErrorObserver(vtkCommand *)"
public void SetParserErrorObserver(vtkCommand /*(vtkCommand*)*/ ARG_0) {
	VTK_API.API_vtkXMLReader.SetParserErrorObserver_0(this, ARG_0);
}


}
};
