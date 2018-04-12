
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public class vtkDataSetAttributes : vtkFieldData {

//       Method: static vtkDataSetAttributes * vtkDataSetAttributes::New()
// 
public static IntPtr New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.New(p);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkDataSetAttributes::GetClassName()
// 
public static string GetClassName(IntPtr obj) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkDataSetAttributes.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSetAttributes::Initialize()
// 
public static void Initialize(IntPtr obj) {
	VTK.API_vtkDataSetAttributes.Initialize(obj);
}


//       Method: virtual void vtkDataSetAttributes::Update()
// 
public static void Update(IntPtr obj) {
	VTK.API_vtkDataSetAttributes.Update(obj);
}


//       Method: void vtkDataSetAttributes::DeepCopy(vtkFieldData* pd)
// 
public static void DeepCopy(IntPtr obj, IntPtr/*vtkFieldData* */ pd) {
	VTK.API_vtkDataSetAttributes.DeepCopy(obj, pd);
}


//       Method: void vtkDataSetAttributes::ShallowCopy(vtkFieldData* pd)
// 
public static void ShallowCopy(IntPtr obj, IntPtr/*vtkFieldData* */ pd) {
	VTK.API_vtkDataSetAttributes.ShallowCopy(obj, pd);
}


//       Method: int vtkDataSetAttributes::SetScalars(vtkDataArray* da)
// 
public static int SetScalars(IntPtr obj, IntPtr/*vtkDataArray* */ da) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetScalars(p,obj, da);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetActiveScalars(const char* name)
// 
public static int SetActiveScalars(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetActiveScalars(p,obj, name);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkDataSetAttributes::GetScalars()
// 
public static IntPtr GetScalars(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetScalars(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetVectors(vtkDataArray* da)
// 
public static int SetVectors(IntPtr obj, IntPtr/*vtkDataArray* */ da) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetVectors(p,obj, da);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetActiveVectors(const char* name)
// 
public static int SetActiveVectors(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetActiveVectors(p,obj, name);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkDataSetAttributes::GetVectors()
// 
public static IntPtr GetVectors(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetVectors(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetNormals(vtkDataArray* da)
// 
public static int SetNormals(IntPtr obj, IntPtr/*vtkDataArray* */ da) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetNormals(p,obj, da);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetActiveNormals(const char* name)
// 
public static int SetActiveNormals(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetActiveNormals(p,obj, name);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkDataSetAttributes::GetNormals()
// 
public static IntPtr GetNormals(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetNormals(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetTCoords(vtkDataArray* da)
// 
public static int SetTCoords(IntPtr obj, IntPtr/*vtkDataArray* */ da) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetTCoords(p,obj, da);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetActiveTCoords(const char* name)
// 
public static int SetActiveTCoords(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetActiveTCoords(p,obj, name);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkDataSetAttributes::GetTCoords()
// 
public static IntPtr GetTCoords(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetTCoords(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetTensors(vtkDataArray* da)
// 
public static int SetTensors(IntPtr obj, IntPtr/*vtkDataArray* */ da) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetTensors(p,obj, da);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetActiveTensors(const char* name)
// 
public static int SetActiveTensors(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetActiveTensors(p,obj, name);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkDataSetAttributes::GetTensors()
// 
public static IntPtr GetTensors(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetTensors(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetGlobalIds(vtkDataArray* da)
// 
public static int SetGlobalIds(IntPtr obj, IntPtr/*vtkDataArray* */ da) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetGlobalIds(p,obj, da);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetActiveGlobalIds(const char* name)
// 
public static int SetActiveGlobalIds(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetActiveGlobalIds(p,obj, name);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkDataSetAttributes::GetGlobalIds()
// 
public static IntPtr GetGlobalIds(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetGlobalIds(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetPedigreeIds(vtkAbstractArray* da)
// 
public static int SetPedigreeIds(IntPtr obj, IntPtr/*vtkAbstractArray* */ da) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetPedigreeIds(p,obj, da);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetActivePedigreeIds(const char* name)
// 
public static int SetActivePedigreeIds(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetActivePedigreeIds(p,obj, name);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkAbstractArray * vtkDataSetAttributes::GetPedigreeIds()
// 
public static IntPtr GetPedigreeIds(IntPtr obj) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetPedigreeIds(p,obj);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkDataSetAttributes::GetScalars(const char* name)
// 
public static IntPtr GetScalars(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetScalars(p,obj, name);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkDataSetAttributes::GetVectors(const char* name)
// 
public static IntPtr GetVectors(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetVectors(p,obj, name);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkDataSetAttributes::GetNormals(const char* name)
// 
public static IntPtr GetNormals(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetNormals(p,obj, name);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkDataSetAttributes::GetTCoords(const char* name)
// 
public static IntPtr GetTCoords(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetTCoords(p,obj, name);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkDataSetAttributes::GetTensors(const char* name)
// 
public static IntPtr GetTensors(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetTensors(p,obj, name);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkDataSetAttributes::GetGlobalIds(const char* name)
// 
public static IntPtr GetGlobalIds(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetGlobalIds(p,obj, name);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkAbstractArray * vtkDataSetAttributes::GetPedigreeIds(const char* name)
// 
public static IntPtr GetPedigreeIds(IntPtr obj, string/*const char* */ name) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetPedigreeIds(p,obj, name);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetActiveAttribute(const char* name, int attributeType)
// 
public static int SetActiveAttribute(IntPtr obj, string/*const char* */ name, int attributeType) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetActiveAttribute(p,obj, name, attributeType);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetActiveAttribute(int index, int attributeType)
// 
public static int SetActiveAttribute(IntPtr obj, int index, int attributeType) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetActiveAttribute(p,obj, index, attributeType);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSetAttributes::GetAttributeIndices(int* indexArray)
// 
public static void GetAttributeIndices(IntPtr obj, IntPtr/*int* */ indexArray) {
	VTK.API_vtkDataSetAttributes.GetAttributeIndices(obj, indexArray);
}


//       Method: int vtkDataSetAttributes::IsArrayAnAttribute(int idx)
// 
public static int IsArrayAnAttribute(IntPtr obj, int idx) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.IsArrayAnAttribute(p,obj, idx);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataSetAttributes::SetAttribute(vtkAbstractArray* aa, int attributeType)
// 
public static int SetAttribute(IntPtr obj, IntPtr/*vtkAbstractArray* */ aa, int attributeType) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.SetAttribute(p,obj, aa, attributeType);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkDataArray * vtkDataSetAttributes::GetAttribute(int attributeType)
// 
public static IntPtr GetAttribute(IntPtr obj, int attributeType) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetAttribute(p,obj, attributeType);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkAbstractArray * vtkDataSetAttributes::GetAbstractAttribute(int attributeType)
// 
public static IntPtr GetAbstractAttribute(IntPtr obj, int attributeType) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetAbstractAttribute(p,obj, attributeType);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSetAttributes::RemoveArray(int index)
// 
public static void RemoveArray(IntPtr obj, int index) {
	VTK.API_vtkDataSetAttributes.RemoveArray(obj, index);
}


//       Method: void vtkDataSetAttributes::SetCopyScalars(int i)
// 
public static void SetCopyScalars(IntPtr obj, int i) {
	VTK.API_vtkDataSetAttributes.SetCopyScalars(obj, i);
}


//       Method: int vtkDataSetAttributes::GetCopyScalars()
// 
public static int GetCopyScalars(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetCopyScalars(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSetAttributes::SetCopyVectors(int i)
// 
public static void SetCopyVectors(IntPtr obj, int i) {
	VTK.API_vtkDataSetAttributes.SetCopyVectors(obj, i);
}


//       Method: int vtkDataSetAttributes::GetCopyVectors()
// 
public static int GetCopyVectors(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetCopyVectors(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSetAttributes::SetCopyNormals(int i)
// 
public static void SetCopyNormals(IntPtr obj, int i) {
	VTK.API_vtkDataSetAttributes.SetCopyNormals(obj, i);
}


//       Method: int vtkDataSetAttributes::GetCopyNormals()
// 
public static int GetCopyNormals(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetCopyNormals(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSetAttributes::SetCopyTCoords(int i)
// 
public static void SetCopyTCoords(IntPtr obj, int i) {
	VTK.API_vtkDataSetAttributes.SetCopyTCoords(obj, i);
}


//       Method: int vtkDataSetAttributes::GetCopyTCoords()
// 
public static int GetCopyTCoords(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetCopyTCoords(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSetAttributes::SetCopyTensors(int i)
// 
public static void SetCopyTensors(IntPtr obj, int i) {
	VTK.API_vtkDataSetAttributes.SetCopyTensors(obj, i);
}


//       Method: int vtkDataSetAttributes::GetCopyTensors()
// 
public static int GetCopyTensors(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetCopyTensors(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSetAttributes::SetCopyGlobalIds(int i)
// 
public static void SetCopyGlobalIds(IntPtr obj, int i) {
	VTK.API_vtkDataSetAttributes.SetCopyGlobalIds(obj, i);
}


//       Method: int vtkDataSetAttributes::GetCopyGlobalIds()
// 
public static int GetCopyGlobalIds(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetCopyGlobalIds(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSetAttributes::SetCopyPedigreeIds(int i)
// 
public static void SetCopyPedigreeIds(IntPtr obj, int i) {
	VTK.API_vtkDataSetAttributes.SetCopyPedigreeIds(obj, i);
}


//       Method: int vtkDataSetAttributes::GetCopyPedigreeIds()
// 
public static int GetCopyPedigreeIds(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataSetAttributes.GetCopyPedigreeIds(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataSetAttributes::CopyAllOn()
// 
public static void CopyAllOn(IntPtr obj) {
	VTK.API_vtkDataSetAttributes.CopyAllOn(obj);
}


//       Method: void vtkDataSetAttributes::CopyAllOff()
// 
public static void CopyAllOff(IntPtr obj) {
	VTK.API_vtkDataSetAttributes.CopyAllOff(obj);
}


//       Method: void vtkDataSetAttributes::PassData(vtkFieldData* fd)
// 
public static void PassData(IntPtr obj, IntPtr/*vtkFieldData* */ fd) {
	VTK.API_vtkDataSetAttributes.PassData(obj, fd);
}


//       Method: void vtkDataSetAttributes::CopyAllocate(vtkDataSetAttributes* pd, vtkIdType sze)
// 
public static void CopyAllocate(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ pd, long sze) {
	VTK.API_vtkDataSetAttributes.CopyAllocate(obj, pd, sze);
}


//       Method: void vtkDataSetAttributes::CopyAllocate(vtkDataSetAttributes* pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)
// 
public static void CopyAllocate(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ pd, long sze, long ext, int shallowCopyArrays) {
	VTK.API_vtkDataSetAttributes.CopyAllocate(obj, pd, sze, ext, shallowCopyArrays);
}


//       Method: void vtkDataSetAttributes::SetupForCopy(vtkDataSetAttributes* pd)
// 
public static void SetupForCopy(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ pd) {
	VTK.API_vtkDataSetAttributes.SetupForCopy(obj, pd);
}


//       Method: void vtkDataSetAttributes::CopyStructuredData(vtkDataSetAttributes* inDsa, const int* inExt, const int* outExt)
// 
public static void CopyStructuredData(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ inDsa, IntPtr/*const int* */ inExt, IntPtr/*const int* */ outExt) {
	VTK.API_vtkDataSetAttributes.CopyStructuredData(obj, inDsa, inExt, outExt);
}


//       Method: void vtkDataSetAttributes::CopyData(vtkDataSetAttributes* fromPd, vtkIdType fromId, vtkIdType toId)
// 
public static void CopyData(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ fromPd, long fromId, long toId) {
	VTK.API_vtkDataSetAttributes.CopyData(obj, fromPd, fromId, toId);
}


//       Method: void vtkDataSetAttributes::CopyData(vtkDataSetAttributes* fromPd, vtkIdList* fromIds, vtkIdList* toIds)
// 
public static void CopyData(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ fromPd, IntPtr/*vtkIdList* */ fromIds, IntPtr/*vtkIdList* */ toIds) {
	VTK.API_vtkDataSetAttributes.CopyData(obj, fromPd, fromIds, toIds);
}


//       Method: void vtkDataSetAttributes::CopyData(vtkDataSetAttributes* fromPd, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
// 
public static void CopyData(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ fromPd, long dstStart, long n, long srcStart) {
	VTK.API_vtkDataSetAttributes.CopyData(obj, fromPd, dstStart, n, srcStart);
}


//       Method: void vtkDataSetAttributes::CopyTuple(vtkAbstractArray* fromData, vtkAbstractArray* toData, vtkIdType fromId, vtkIdType toId)
// 
public static void CopyTuple(IntPtr obj, IntPtr/*vtkAbstractArray* */ fromData, IntPtr/*vtkAbstractArray* */ toData, long fromId, long toId) {
	VTK.API_vtkDataSetAttributes.CopyTuple(obj, fromData, toData, fromId, toId);
}


//       Method: void vtkDataSetAttributes::CopyTuples(vtkAbstractArray* fromData, vtkAbstractArray* toData, vtkIdList* fromIds, vtkIdList* toIds)
// 
public static void CopyTuples(IntPtr obj, IntPtr/*vtkAbstractArray* */ fromData, IntPtr/*vtkAbstractArray* */ toData, IntPtr/*vtkIdList* */ fromIds, IntPtr/*vtkIdList* */ toIds) {
	VTK.API_vtkDataSetAttributes.CopyTuples(obj, fromData, toData, fromIds, toIds);
}


//       Method: void vtkDataSetAttributes::CopyTuples(vtkAbstractArray* fromData, vtkAbstractArray* toData, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
// 
public static void CopyTuples(IntPtr obj, IntPtr/*vtkAbstractArray* */ fromData, IntPtr/*vtkAbstractArray* */ toData, long dstStart, long n, long srcStart) {
	VTK.API_vtkDataSetAttributes.CopyTuples(obj, fromData, toData, dstStart, n, srcStart);
}


//       Method: void vtkDataSetAttributes::InterpolateAllocate(vtkDataSetAttributes* pd, vtkIdType sze)
// 
public static void InterpolateAllocate(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ pd, long sze) {
	VTK.API_vtkDataSetAttributes.InterpolateAllocate(obj, pd, sze);
}


//       Method: void vtkDataSetAttributes::InterpolateAllocate(vtkDataSetAttributes* pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)
// 
public static void InterpolateAllocate(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ pd, long sze, long ext, int shallowCopyArrays) {
	VTK.API_vtkDataSetAttributes.InterpolateAllocate(obj, pd, sze, ext, shallowCopyArrays);
}


//       Method: void vtkDataSetAttributes::InterpolatePoint(vtkDataSetAttributes* fromPd, vtkIdType toId, vtkIdList* ids, double* weights)
// 
public static void InterpolatePoint(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ fromPd, long toId, IntPtr/*vtkIdList* */ ids, IntPtr/*double* */ weights) {
	VTK.API_vtkDataSetAttributes.InterpolatePoint(obj, fromPd, toId, ids, weights);
}


//       Method: void vtkDataSetAttributes::InterpolateEdge(vtkDataSetAttributes* fromPd, vtkIdType toId, vtkIdType p1, vtkIdType p2, double t)
// 
public static void InterpolateEdge(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ fromPd, long toId, long p1, long p2, double t) {
	VTK.API_vtkDataSetAttributes.InterpolateEdge(obj, fromPd, toId, p1, p2, t);
}


//       Method: void vtkDataSetAttributes::InterpolateTime(vtkDataSetAttributes* from1, vtkDataSetAttributes* from2, vtkIdType id, double t)
// 
public static void InterpolateTime(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ from1, IntPtr/*vtkDataSetAttributes* */ from2, long id, double t) {
	VTK.API_vtkDataSetAttributes.InterpolateTime(obj, from1, from2, id, t);
}


//       Method: void vtkDataSetAttributes::CopyAllocate(vtkIdType sze)
// 
public static void CopyAllocate(IntPtr obj, long sze) {
	VTK.API_vtkDataSetAttributes.CopyAllocate(obj, sze);
}


//       Method: void vtkDataSetAttributes::CopyData(vtkDataSetAttributes* dsa, int idx, vtkIdType fromId, vtkIdType toId)
// 
public static void CopyData(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ dsa, int idx, long fromId, long toId) {
	VTK.API_vtkDataSetAttributes.CopyData(obj, dsa, idx, fromId, toId);
}


//       Method: void vtkDataSetAttributes::CopyData(vtkDataSetAttributes* dsa, int idx, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
// 
public static void CopyData(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ dsa, int idx, long dstStart, long n, long srcStart) {
	VTK.API_vtkDataSetAttributes.CopyData(obj, dsa, idx, dstStart, n, srcStart);
}


//       Method: void vtkDataSetAttributes::InterpolateAllocate(vtkIdType sze)
// 
public static void InterpolateAllocate(IntPtr obj, long sze) {
	VTK.API_vtkDataSetAttributes.InterpolateAllocate(obj, sze);
}


//       Method: void vtkDataSetAttributes::InterpolatePoint(vtkDataSetAttributes* fromPd, int idx, vtkIdType toId, vtkIdList* ids, double* weights)
// 
public static void InterpolatePoint(IntPtr obj, IntPtr/*vtkDataSetAttributes* */ fromPd, int idx, long toId, IntPtr/*vtkIdList* */ ids, IntPtr/*double* */ weights) {
	VTK.API_vtkDataSetAttributes.InterpolatePoint(obj, fromPd, idx, toId, ids, weights);
}


}
};
