

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLReader : vtkAlgorithm {
		public vtkXMLReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLReader(IntPtr p) {return new vtkXMLReader(p);}
		public static implicit operator  IntPtr(vtkXMLReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLReader.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkXMLReader.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkXMLReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkXMLReader)(IntPtr)returnPointer;
}


// vtkXMLReader* NewInstance()
// "vtkXMLReader *NewInstance()"
public vtkXMLReader NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkXMLReader)(IntPtr)returnPointer;
}


// virtual void SetFileName(const char * _arg)
// "virtual void SetFileName (const char* _arg)"
public void SetFileName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkXMLReader.SetFileName_0(this, _arg);
}


// virtual char* GetFileName()
// "virtual char* GetFileName ()"
public string GetFileName() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.GetFileName_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual void SetReadFromInputString(int _arg)
// "virtual void SetReadFromInputString (int _arg)"
public void SetReadFromInputString(int /*(int)*/ _arg) {
	VTK_API.API_vtkXMLReader.SetReadFromInputString_0(this, _arg);
}


// virtual int GetReadFromInputString()
// "virtual int GetReadFromInputString ()"
public int GetReadFromInputString() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLReader.GetReadFromInputString_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void ReadFromInputStringOn()
// "virtual void ReadFromInputStringOn ()"
public void ReadFromInputStringOn() {
	VTK_API.API_vtkXMLReader.ReadFromInputStringOn_0(this);
}


// virtual void ReadFromInputStringOff()
// "virtual void ReadFromInputStringOff ()"
public void ReadFromInputStringOff() {
	VTK_API.API_vtkXMLReader.ReadFromInputStringOff_0(this);
}


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


// virtual vtkDataArraySelection* GetPointDataArraySelection()
// "virtual vtkDataArraySelection *GetPointDataArraySelection ()"
public vtkDataArraySelection GetPointDataArraySelection() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.GetPointDataArraySelection_0(returnPointer.GetPtr(), this);
	return (vtkDataArraySelection)(IntPtr)returnPointer;
}


// virtual vtkDataArraySelection* GetCellDataArraySelection()
// "virtual vtkDataArraySelection *GetCellDataArraySelection ()"
public vtkDataArraySelection GetCellDataArraySelection() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.GetCellDataArraySelection_0(returnPointer.GetPtr(), this);
	return (vtkDataArraySelection)(IntPtr)returnPointer;
}


// virtual vtkDataArraySelection* GetColumnArraySelection()
// "virtual vtkDataArraySelection *GetColumnArraySelection ()"
public vtkDataArraySelection GetColumnArraySelection() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.GetColumnArraySelection_0(returnPointer.GetPtr(), this);
	return (vtkDataArraySelection)(IntPtr)returnPointer;
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


// virtual void SetTimeStep(int _arg)
// "virtual void SetTimeStep (int _arg)"
public void SetTimeStep(int /*(int)*/ _arg) {
	VTK_API.API_vtkXMLReader.SetTimeStep_0(this, _arg);
}


// virtual int GetTimeStep()
// "virtual int GetTimeStep ()"
public int GetTimeStep() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLReader.GetTimeStep_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetNumberOfTimeSteps()
// "virtual int GetNumberOfTimeSteps ()"
public int GetNumberOfTimeSteps() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkXMLReader.GetNumberOfTimeSteps_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int* GetTimeStepRange()
// "virtual int *GetTimeStepRange ()"
public IntPtr GetTimeStepRange() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.GetTimeStepRange_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetTimeStepRange(int & _arg1, int & _arg2)
// "virtual void GetTimeStepRange (int &_arg1, int &_arg2)"
public void GetTimeStepRange(IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2) {
	VTK_API.API_vtkXMLReader.GetTimeStepRange_1(this, _arg1, _arg2);
}


// virtual void GetTimeStepRange(int _arg[2])
// "virtual void GetTimeStepRange (int _arg[2])"
public void GetTimeStepRange(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkXMLReader.GetTimeStepRange_2(this, _arg);
}


// virtual void SetTimeStepRange(int _arg1, int _arg2)
// "virtual void SetTimeStepRange (int _arg1, int _arg2)"
public void SetTimeStepRange(int /*(int)*/ _arg1, int /*(int)*/ _arg2) {
	VTK_API.API_vtkXMLReader.SetTimeStepRange_0(this, _arg1, _arg2);
}


// void SetTimeStepRange(int _arg[2])
// "void SetTimeStepRange (int _arg[2])"
public void SetTimeStepRange(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkXMLReader.SetTimeStepRange_1(this, _arg);
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


// virtual vtkCommand* GetReaderErrorObserver()
// "virtual vtkCommand *GetReaderErrorObserver ()"
public vtkCommand GetReaderErrorObserver() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.GetReaderErrorObserver_0(returnPointer.GetPtr(), this);
	return (vtkCommand)(IntPtr)returnPointer;
}


// void SetParserErrorObserver(vtkCommand * ARG_0)
// "void SetParserErrorObserver(vtkCommand *)"
public void SetParserErrorObserver(vtkCommand /*(vtkCommand*)*/ ARG_0) {
	VTK_API.API_vtkXMLReader.SetParserErrorObserver_0(this, ARG_0);
}


// virtual vtkCommand* GetParserErrorObserver()
// "virtual vtkCommand *GetParserErrorObserver ()"
public vtkCommand GetParserErrorObserver() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkXMLReader.GetParserErrorObserver_0(returnPointer.GetPtr(), this);
	return (vtkCommand)(IntPtr)returnPointer;
}


}
};
