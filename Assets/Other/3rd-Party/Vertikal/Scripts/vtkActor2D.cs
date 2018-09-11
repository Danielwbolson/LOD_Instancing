

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkActor2D : vtkProp {
		public vtkActor2D(IntPtr p) : base(p) {}
		public static implicit operator  vtkActor2D(IntPtr p) {return new vtkActor2D(p);}
		public static implicit operator  IntPtr(vtkActor2D o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkActor2D.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkActor2D.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkActor2D* SafeDownCast(vtkObjectBase * o)
// "static vtkActor2D* SafeDownCast(vtkObjectBase *o)"
public static vtkActor2D SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor2D.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkActor2D)(IntPtr)returnPointer;
}


// vtkActor2D* NewInstance()
// "vtkActor2D *NewInstance()"
public vtkActor2D NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor2D.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkActor2D)(IntPtr)returnPointer;
}


// static vtkActor2D* New()
// "static vtkActor2D* New()"
public static vtkActor2D New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor2D.New_0(returnPointer.GetPtr());
	return (vtkActor2D)(IntPtr)returnPointer;
}


// int RenderOverlay(vtkViewport * viewport)
// "int RenderOverlay(vtkViewport *viewport)"
public int RenderOverlay(vtkViewport /*(vtkViewport*)*/ viewport) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkActor2D.RenderOverlay_0(returnPointer.GetPtr(), this, viewport);
	return (int)returnPointer;
}


// int RenderOpaqueGeometry(vtkViewport * viewport)
// "int RenderOpaqueGeometry(vtkViewport *viewport)"
public int RenderOpaqueGeometry(vtkViewport /*(vtkViewport*)*/ viewport) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkActor2D.RenderOpaqueGeometry_0(returnPointer.GetPtr(), this, viewport);
	return (int)returnPointer;
}


// int RenderTranslucentPolygonalGeometry(vtkViewport * viewport)
// "int RenderTranslucentPolygonalGeometry(vtkViewport *viewport)"
public int RenderTranslucentPolygonalGeometry(vtkViewport /*(vtkViewport*)*/ viewport) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkActor2D.RenderTranslucentPolygonalGeometry_0(returnPointer.GetPtr(), this, viewport);
	return (int)returnPointer;
}


// int HasTranslucentPolygonalGeometry()
// "int HasTranslucentPolygonalGeometry()"
public int HasTranslucentPolygonalGeometry() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkActor2D.HasTranslucentPolygonalGeometry_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetMapper(vtkMapper2D * mapper)
// "virtual void SetMapper(vtkMapper2D *mapper)"
public void SetMapper(vtkMapper2D /*(vtkMapper2D*)*/ mapper) {
	VTK_API.API_vtkActor2D.SetMapper_0(this, mapper);
}


// virtual vtkMapper2D* GetMapper()
// "virtual vtkMapper2D *GetMapper ()"
public vtkMapper2D GetMapper() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor2D.GetMapper_0(returnPointer.GetPtr(), this);
	return (vtkMapper2D)(IntPtr)returnPointer;
}


// virtual void SetLayerNumber(int _arg)
// "virtual void SetLayerNumber (int _arg)"
public void SetLayerNumber(int /*(int)*/ _arg) {
	VTK_API.API_vtkActor2D.SetLayerNumber_0(this, _arg);
}


// virtual int GetLayerNumber()
// "virtual int GetLayerNumber ()"
public int GetLayerNumber() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkActor2D.GetLayerNumber_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkProperty2D* GetProperty()
// "vtkProperty2D* GetProperty()"
public vtkProperty2D GetProperty() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor2D.GetProperty_0(returnPointer.GetPtr(), this);
	return (vtkProperty2D)(IntPtr)returnPointer;
}


// virtual void SetProperty(vtkProperty2D * ARG_0)
// "virtual void SetProperty(vtkProperty2D*)"
public void SetProperty(vtkProperty2D /*(vtkProperty2D*)*/ ARG_0) {
	VTK_API.API_vtkActor2D.SetProperty_0(this, ARG_0);
}


// virtual vtkCoordinate* GetPositionCoordinate()
// "virtual vtkCoordinate *GetPositionCoordinate ()"
public vtkCoordinate GetPositionCoordinate() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor2D.GetPositionCoordinate_0(returnPointer.GetPtr(), this);
	return (vtkCoordinate)(IntPtr)returnPointer;
}


// virtual void SetPosition(double x[2])
// "virtual void SetPosition(double x[2])"
public void SetPosition(double /*(double[2])*/ []x) {
	VTK_API.API_vtkActor2D.SetPosition_0(this, x);
}


// virtual void SetPosition(double x, double y)
// "virtual void SetPosition(double x, double y)"
public void SetPosition(double /*(double)*/ x, double /*(double)*/ y) {
	VTK_API.API_vtkActor2D.SetPosition_1(this, x, y);
}


// virtual double* GetPosition()
// "virtual double *GetPosition()"
public IntPtr GetPosition() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor2D.GetPosition_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void SetDisplayPosition(int ARG_0, int ARG_1)
// "void SetDisplayPosition(int,int)"
public void SetDisplayPosition(int /*(int)*/ ARG_0, int /*(int)*/ ARG_1) {
	VTK_API.API_vtkActor2D.SetDisplayPosition_0(this, ARG_0, ARG_1);
}


// virtual vtkCoordinate* GetPosition2Coordinate()
// "virtual vtkCoordinate *GetPosition2Coordinate ()"
public vtkCoordinate GetPosition2Coordinate() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor2D.GetPosition2Coordinate_0(returnPointer.GetPtr(), this);
	return (vtkCoordinate)(IntPtr)returnPointer;
}


// virtual void SetPosition2(double x[2])
// "virtual void SetPosition2(double x[2])"
public void SetPosition2(double /*(double[2])*/ []x) {
	VTK_API.API_vtkActor2D.SetPosition2_0(this, x);
}


// virtual void SetPosition2(double x, double y)
// "virtual void SetPosition2(double x, double y)"
public void SetPosition2(double /*(double)*/ x, double /*(double)*/ y) {
	VTK_API.API_vtkActor2D.SetPosition2_1(this, x, y);
}


// virtual double* GetPosition2()
// "virtual double *GetPosition2()"
public IntPtr GetPosition2() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor2D.GetPosition2_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void SetWidth(double w)
// "void SetWidth(double w)"
public void SetWidth(double /*(double)*/ w) {
	VTK_API.API_vtkActor2D.SetWidth_0(this, w);
}


// double GetWidth()
// "double GetWidth()"
public double GetWidth() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkActor2D.GetWidth_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// void SetHeight(double h)
// "void SetHeight(double h)"
public void SetHeight(double /*(double)*/ h) {
	VTK_API.API_vtkActor2D.SetHeight_0(this, h);
}


// double GetHeight()
// "double GetHeight()"
public double GetHeight() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkActor2D.GetHeight_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkActor2D.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void GetActors2D(vtkPropCollection * pc)
// "void GetActors2D(vtkPropCollection *pc)"
public void GetActors2D(vtkPropCollection /*(vtkPropCollection*)*/ pc) {
	VTK_API.API_vtkActor2D.GetActors2D_0(this, pc);
}


// void ShallowCopy(vtkProp * prop)
// "void ShallowCopy(vtkProp *prop)"
public void ShallowCopy(vtkProp /*(vtkProp*)*/ prop) {
	VTK_API.API_vtkActor2D.ShallowCopy_0(this, prop);
}


// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkActor2D.ReleaseGraphicsResources_0(this, ARG_0);
}


// virtual vtkCoordinate* GetActualPositionCoordinate()
// "virtual vtkCoordinate *GetActualPositionCoordinate(void)"
public vtkCoordinate GetActualPositionCoordinate() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor2D.GetActualPositionCoordinate_0(returnPointer.GetPtr(), this);
	return (vtkCoordinate)(IntPtr)returnPointer;
}


// virtual vtkCoordinate* GetActualPosition2Coordinate()
// "virtual vtkCoordinate *GetActualPosition2Coordinate(void)"
public vtkCoordinate GetActualPosition2Coordinate() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor2D.GetActualPosition2Coordinate_0(returnPointer.GetPtr(), this);
	return (vtkCoordinate)(IntPtr)returnPointer;
}


}
};
