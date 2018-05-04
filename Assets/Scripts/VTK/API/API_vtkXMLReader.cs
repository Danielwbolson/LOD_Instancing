
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkXMLReader {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ type);

// static vtkXMLReader* SafeDownCast(vtkObjectBase * o)
// static vtkXMLReader* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkXMLReader* NewInstance()
// vtkXMLReader *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// virtual void SetFileName(const char * _arg)
// virtual void SetFileName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetFileName_0")] public static extern 
bool SetFileName_0(IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetFileName()
// virtual char* GetFileName ()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetFileName_0")] public static extern 
bool GetFileName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// virtual void SetReadFromInputString(int _arg)
// virtual void SetReadFromInputString (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetReadFromInputString_0")] public static extern 
bool SetReadFromInputString_0(IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetReadFromInputString()
// virtual int GetReadFromInputString ()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetReadFromInputString_0")] public static extern 
bool GetReadFromInputString_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// virtual void ReadFromInputStringOn()
// virtual void ReadFromInputStringOn ()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_ReadFromInputStringOn_0")] public static extern 
bool ReadFromInputStringOn_0(IntPtr /*(vtkXMLReader*)*/ callingObject);

// virtual void ReadFromInputStringOff()
// virtual void ReadFromInputStringOff ()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_ReadFromInputStringOff_0")] public static extern 
bool ReadFromInputStringOff_0(IntPtr /*(vtkXMLReader*)*/ callingObject);

// virtual int CanReadFile(const char * name)
// virtual int CanReadFile(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_CanReadFile_0")] public static extern 
bool CanReadFile_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name);

// vtkDataSet* GetOutputAsDataSet()
// vtkDataSet* GetOutputAsDataSet()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetOutputAsDataSet_0")] public static extern 
bool GetOutputAsDataSet_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// vtkDataSet* GetOutputAsDataSet(int index)
// vtkDataSet* GetOutputAsDataSet(int index)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetOutputAsDataSet_1")] public static extern 
bool GetOutputAsDataSet_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ index);

// virtual vtkDataArraySelection* GetPointDataArraySelection()
// virtual vtkDataArraySelection *GetPointDataArraySelection ()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetPointDataArraySelection_0")] public static extern 
bool GetPointDataArraySelection_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// virtual vtkDataArraySelection* GetCellDataArraySelection()
// virtual vtkDataArraySelection *GetCellDataArraySelection ()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetCellDataArraySelection_0")] public static extern 
bool GetCellDataArraySelection_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// virtual vtkDataArraySelection* GetColumnArraySelection()
// virtual vtkDataArraySelection *GetColumnArraySelection ()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetColumnArraySelection_0")] public static extern 
bool GetColumnArraySelection_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// int GetNumberOfPointArrays()
// int GetNumberOfPointArrays()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetNumberOfPointArrays_0")] public static extern 
bool GetNumberOfPointArrays_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// int GetNumberOfCellArrays()
// int GetNumberOfCellArrays()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetNumberOfCellArrays_0")] public static extern 
bool GetNumberOfCellArrays_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// int GetNumberOfColumnArrays()
// int GetNumberOfColumnArrays()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetNumberOfColumnArrays_0")] public static extern 
bool GetNumberOfColumnArrays_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// char* GetPointArrayName(int index)
// const char* GetPointArrayName(int index)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetPointArrayName_0")] public static extern 
bool GetPointArrayName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ index);

// char* GetCellArrayName(int index)
// const char* GetCellArrayName(int index)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetCellArrayName_0")] public static extern 
bool GetCellArrayName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ index);

// char* GetColumnArrayName(int index)
// const char* GetColumnArrayName(int index)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetColumnArrayName_0")] public static extern 
bool GetColumnArrayName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ index);

// int GetPointArrayStatus(const char * name)
// int GetPointArrayStatus(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetPointArrayStatus_0")] public static extern 
bool GetPointArrayStatus_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name);

// int GetCellArrayStatus(const char * name)
// int GetCellArrayStatus(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetCellArrayStatus_0")] public static extern 
bool GetCellArrayStatus_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name);

// void SetPointArrayStatus(const char * name, int status)
// void SetPointArrayStatus(const char* name, int status)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetPointArrayStatus_0")] public static extern 
bool SetPointArrayStatus_0(IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ status);

// void SetCellArrayStatus(const char * name, int status)
// void SetCellArrayStatus(const char* name, int status)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetCellArrayStatus_0")] public static extern 
bool SetCellArrayStatus_0(IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ status);

// int GetColumnArrayStatus(const char * name)
// int GetColumnArrayStatus(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetColumnArrayStatus_0")] public static extern 
bool GetColumnArrayStatus_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name);

// void SetColumnArrayStatus(const char * name, int status)
// void SetColumnArrayStatus(const char* name, int status)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetColumnArrayStatus_0")] public static extern 
bool SetColumnArrayStatus_0(IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ status);

// virtual void SetTimeStep(int _arg)
// virtual void SetTimeStep (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetTimeStep_0")] public static extern 
bool SetTimeStep_0(IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetTimeStep()
// virtual int GetTimeStep ()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetTimeStep_0")] public static extern 
bool GetTimeStep_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// virtual int GetNumberOfTimeSteps()
// virtual int GetNumberOfTimeSteps ()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetNumberOfTimeSteps_0")] public static extern 
bool GetNumberOfTimeSteps_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// virtual int* GetTimeStepRange()
// virtual int *GetTimeStepRange ()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetTimeStepRange_0")] public static extern 
bool GetTimeStepRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// virtual void GetTimeStepRange(int & _arg1, int & _arg2)
// virtual void GetTimeStepRange (int &_arg1, int &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetTimeStepRange_1")] public static extern 
bool GetTimeStepRange_1(IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2);

// virtual void GetTimeStepRange(int _arg[2])
// virtual void GetTimeStepRange (int _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetTimeStepRange_2")] public static extern 
bool GetTimeStepRange_2(IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int[2])*/ []_arg);

// virtual void SetTimeStepRange(int _arg1, int _arg2)
// virtual void SetTimeStepRange (int _arg1, int _arg2)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetTimeStepRange_0")] public static extern 
bool SetTimeStepRange_0(IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int)*/ _arg1, int /*(int)*/ _arg2);

// void SetTimeStepRange(int _arg[2])
// void SetTimeStepRange (int _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetTimeStepRange_1")] public static extern 
bool SetTimeStepRange_1(IntPtr /*(vtkXMLReader*)*/ callingObject, int /*(int[2])*/ []_arg);

// vtkXMLDataParser* GetXMLParser()
// vtkXMLDataParser* GetXMLParser()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetXMLParser_0")] public static extern 
bool GetXMLParser_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// void SetReaderErrorObserver(vtkCommand * ARG_0)
// void SetReaderErrorObserver(vtkCommand *)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetReaderErrorObserver_0")] public static extern 
bool SetReaderErrorObserver_0(IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(vtkCommand*)*/ ARG_0);

// virtual vtkCommand* GetReaderErrorObserver()
// virtual vtkCommand *GetReaderErrorObserver ()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetReaderErrorObserver_0")] public static extern 
bool GetReaderErrorObserver_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

// void SetParserErrorObserver(vtkCommand * ARG_0)
// void SetParserErrorObserver(vtkCommand *)
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_SetParserErrorObserver_0")] public static extern 
bool SetParserErrorObserver_0(IntPtr /*(vtkXMLReader*)*/ callingObject, IntPtr /*(vtkCommand*)*/ ARG_0);

// virtual vtkCommand* GetParserErrorObserver()
// virtual vtkCommand *GetParserErrorObserver ()
[DllImport("vtkplugin", EntryPoint="vtkXMLReader_GetParserErrorObserver_0")] public static extern 
bool GetParserErrorObserver_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkXMLReader*)*/ callingObject);

}
};
