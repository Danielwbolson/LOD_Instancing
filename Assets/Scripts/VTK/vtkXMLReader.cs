

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLReader : vtkAlgorithm {

// virtual int CanReadFile(const char * name)
// "virtual int CanReadFile(const char* name)"
public new int CanReadFile(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLReader.CanReadFile_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// vtkDataSet* GetOutputAsDataSet()
// "vtkDataSet* GetOutputAsDataSet()"
public new vtkDataSet GetOutputAsDataSet() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLReader.GetOutputAsDataSet_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkDataSet* GetOutputAsDataSet(int index)
// "vtkDataSet* GetOutputAsDataSet(int index)"
public new vtkDataSet GetOutputAsDataSet(int /*(int)*/ index) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLReader.GetOutputAsDataSet_1(this, returnPointer, index);
	return Ptr.deref(returnPointer);
}


// int GetNumberOfPointArrays()
// "int GetNumberOfPointArrays()"
public new int GetNumberOfPointArrays() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLReader.GetNumberOfPointArrays_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetNumberOfCellArrays()
// "int GetNumberOfCellArrays()"
public new int GetNumberOfCellArrays() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLReader.GetNumberOfCellArrays_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetNumberOfColumnArrays()
// "int GetNumberOfColumnArrays()"
public new int GetNumberOfColumnArrays() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLReader.GetNumberOfColumnArrays_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// char* GetPointArrayName(int index)
// "const char* GetPointArrayName(int index)"
public new char GetPointArrayName(int /*(int)*/ index) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkXMLReader.GetPointArrayName_0(this, returnPointer, index);
	return Ptr.deref(returnPointer);
}


// char* GetCellArrayName(int index)
// "const char* GetCellArrayName(int index)"
public new char GetCellArrayName(int /*(int)*/ index) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkXMLReader.GetCellArrayName_0(this, returnPointer, index);
	return Ptr.deref(returnPointer);
}


// char* GetColumnArrayName(int index)
// "const char* GetColumnArrayName(int index)"
public new char GetColumnArrayName(int /*(int)*/ index) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkXMLReader.GetColumnArrayName_0(this, returnPointer, index);
	return Ptr.deref(returnPointer);
}


// int GetPointArrayStatus(const char * name)
// "int GetPointArrayStatus(const char* name)"
public new int GetPointArrayStatus(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLReader.GetPointArrayStatus_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// int GetCellArrayStatus(const char * name)
// "int GetCellArrayStatus(const char* name)"
public new int GetCellArrayStatus(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLReader.GetCellArrayStatus_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// void SetPointArrayStatus(const char * name, int status)
// "void SetPointArrayStatus(const char* name, int status)"
public new void SetPointArrayStatus(char /*(char*)*/ []name, int /*(int)*/ status) {
	API_vtkXMLReader.SetPointArrayStatus_0(this, name, status);
}


// void SetCellArrayStatus(const char * name, int status)
// "void SetCellArrayStatus(const char* name, int status)"
public new void SetCellArrayStatus(char /*(char*)*/ []name, int /*(int)*/ status) {
	API_vtkXMLReader.SetCellArrayStatus_0(this, name, status);
}


// int GetColumnArrayStatus(const char * name)
// "int GetColumnArrayStatus(const char* name)"
public new int GetColumnArrayStatus(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkXMLReader.GetColumnArrayStatus_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// void SetColumnArrayStatus(const char * name, int status)
// "void SetColumnArrayStatus(const char* name, int status)"
public new void SetColumnArrayStatus(char /*(char*)*/ []name, int /*(int)*/ status) {
	API_vtkXMLReader.SetColumnArrayStatus_0(this, name, status);
}


// vtkXMLDataParser* GetXMLParser()
// "vtkXMLDataParser* GetXMLParser()"
public new vtkXMLDataParser GetXMLParser() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkXMLReader.GetXMLParser_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetReaderErrorObserver(vtkCommand * ARG_0)
// "void SetReaderErrorObserver(vtkCommand *)"
public new void SetReaderErrorObserver(vtkCommand /*(vtkCommand*)*/ ARG_0) {
	API_vtkXMLReader.SetReaderErrorObserver_0(this, ARG_0);
}


// void SetParserErrorObserver(vtkCommand * ARG_0)
// "void SetParserErrorObserver(vtkCommand *)"
public new void SetParserErrorObserver(vtkCommand /*(vtkCommand*)*/ ARG_0) {
	API_vtkXMLReader.SetParserErrorObserver_0(this, ARG_0);
}


}
};
