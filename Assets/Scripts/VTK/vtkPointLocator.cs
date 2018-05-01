

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPointLocator : vtkIncrementalPointLocator {
		public vtkPointLocator(IntPtr p) : base(p) {}
		public static implicit operator  vtkPointLocator(IntPtr p) {return new vtkPointLocator(p);}
		public static implicit operator  IntPtr(vtkPointLocator o) {return o.GetPtr();}

// static vtkPointLocator* New()
// "static vtkPointLocator *New()"
public static vtkPointLocator New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkPointLocator.New_0(returnPointer.GetPtr());
	return (vtkPointLocator)(IntPtr)returnPointer;
}


// vtkIdType FindClosestPoint(const double x[3])
// "vtkIdType FindClosestPoint(const double x[3])"
public long FindClosestPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkPointLocator.FindClosestPoint_0(returnPointer.GetPtr(), this, x);
	return (long)returnPointer;
}


// vtkIdType FindClosestPointWithinRadius(double radius, const double x[3], double & dist2)
// "vtkIdType FindClosestPointWithinRadius( double radius, const double x[3], double& dist2)"
public long FindClosestPointWithinRadius(double /*(double)*/ radius, double /*(double[3])*/ []x, IntPtr /*(double&)*/ dist2) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkPointLocator.FindClosestPointWithinRadius_0(returnPointer.GetPtr(), this, radius, x, dist2);
	return (long)returnPointer;
}


// virtual vtkIdType FindClosestPointWithinRadius(double radius, const double x[3], double inputDataLength, double & dist2)
// "virtual vtkIdType FindClosestPointWithinRadius( double radius, const double x[3], double inputDataLength, double& dist2)"
public long FindClosestPointWithinRadius(double /*(double)*/ radius, double /*(double[3])*/ []x, double /*(double)*/ inputDataLength, IntPtr /*(double&)*/ dist2) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkPointLocator.FindClosestPointWithinRadius_1(returnPointer.GetPtr(), this, radius, x, inputDataLength, dist2);
	return (long)returnPointer;
}


// int InitPointInsertion(vtkPoints * newPts, const double bounds[6])
// "int InitPointInsertion(vtkPoints *newPts, const double bounds[6])"
public int InitPointInsertion(vtkPoints /*(vtkPoints*)*/ newPts, double /*(double[6])*/ []bounds) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkPointLocator.InitPointInsertion_0(returnPointer.GetPtr(), this, newPts, bounds);
	return (int)returnPointer;
}


// int InitPointInsertion(vtkPoints * newPts, const double bounds[6], vtkIdType estSize)
// "int InitPointInsertion(vtkPoints *newPts, const double bounds[6], vtkIdType estSize)"
public int InitPointInsertion(vtkPoints /*(vtkPoints*)*/ newPts, double /*(double[6])*/ []bounds, long /*(vtkIdType)*/ estSize) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkPointLocator.InitPointInsertion_1(returnPointer.GetPtr(), this, newPts, bounds, estSize);
	return (int)returnPointer;
}


// void InsertPoint(vtkIdType ptId, const double x[3])
// "void InsertPoint(vtkIdType ptId, const double x[3])"
public void InsertPoint(long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []x) {
	API_vtkPointLocator.InsertPoint_0(this, ptId, x);
}


// vtkIdType InsertNextPoint(const double x[3])
// "vtkIdType InsertNextPoint(const double x[3])"
public long InsertNextPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkPointLocator.InsertNextPoint_0(returnPointer.GetPtr(), this, x);
	return (long)returnPointer;
}


// vtkIdType IsInsertedPoint(double x, double y, double z)
// "vtkIdType IsInsertedPoint(double x, double y, double z)"
public long IsInsertedPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkPointLocator.IsInsertedPoint_0(returnPointer.GetPtr(), this, x, y, z);
	return (long)returnPointer;
}


// vtkIdType IsInsertedPoint(const double x[3])
// "vtkIdType IsInsertedPoint(const double x[3])"
public long IsInsertedPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkPointLocator.IsInsertedPoint_1(returnPointer.GetPtr(), this, x);
	return (long)returnPointer;
}


// int InsertUniquePoint(const double x[3], vtkIdType & ptId)
// "int InsertUniquePoint(const double x[3], vtkIdType &ptId)"
public int InsertUniquePoint(double /*(double[3])*/ []x, IntPtr /*(vtkIdType&)*/ ptId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkPointLocator.InsertUniquePoint_0(returnPointer.GetPtr(), this, x, ptId);
	return (int)returnPointer;
}


// vtkIdType FindClosestInsertedPoint(const double x[3])
// "vtkIdType FindClosestInsertedPoint(const double x[3])"
public long FindClosestInsertedPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkPointLocator.FindClosestInsertedPoint_0(returnPointer.GetPtr(), this, x);
	return (long)returnPointer;
}


// void FindClosestNPoints(int N, const double x[3], vtkIdList * result)
// "void FindClosestNPoints(int N, const double x[3], vtkIdList *result)"
public void FindClosestNPoints(int /*(int)*/ N, double /*(double[3])*/ []x, vtkIdList /*(vtkIdList*)*/ result) {
	API_vtkPointLocator.FindClosestNPoints_0(this, N, x, result);
}


// virtual void FindDistributedPoints(int N, const double x[3], vtkIdList * result, int M)
// "virtual void FindDistributedPoints(int N, const double x[3], vtkIdList *result, int M)"
public void FindDistributedPoints(int /*(int)*/ N, double /*(double[3])*/ []x, vtkIdList /*(vtkIdList*)*/ result, int /*(int)*/ M) {
	API_vtkPointLocator.FindDistributedPoints_0(this, N, x, result, M);
}


// virtual void FindDistributedPoints(int N, double x, double y, double z, vtkIdList * result, int M)
// "virtual void FindDistributedPoints(int N, double x, double y, double z, vtkIdList *result, int M)"
public void FindDistributedPoints(int /*(int)*/ N, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, vtkIdList /*(vtkIdList*)*/ result, int /*(int)*/ M) {
	API_vtkPointLocator.FindDistributedPoints_1(this, N, x, y, z, result, M);
}


// void FindPointsWithinRadius(double R, const double x[3], vtkIdList * result)
// "void FindPointsWithinRadius(double R, const double x[3], vtkIdList *result)"
public void FindPointsWithinRadius(double /*(double)*/ R, double /*(double[3])*/ []x, vtkIdList /*(vtkIdList*)*/ result) {
	API_vtkPointLocator.FindPointsWithinRadius_0(this, R, x, result);
}


// virtual vtkIdList* GetPointsInBucket(const double x[3], int ijk[3])
// "virtual vtkIdList *GetPointsInBucket(const double x[3], int ijk[3])"
public vtkIdList GetPointsInBucket(double /*(double[3])*/ []x, int /*(int[3])*/ []ijk) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkPointLocator.GetPointsInBucket_0(returnPointer.GetPtr(), this, x, ijk);
	return (vtkIdList)(IntPtr)returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	API_vtkPointLocator.Initialize_0(this);
}


// void FreeSearchStructure()
// "void FreeSearchStructure()"
public void FreeSearchStructure() {
	API_vtkPointLocator.FreeSearchStructure_0(this);
}


// void BuildLocator()
// "void BuildLocator()"
public void BuildLocator() {
	API_vtkPointLocator.BuildLocator_0(this);
}


// void GenerateRepresentation(int level, vtkPolyData * pd)
// "void GenerateRepresentation(int level, vtkPolyData *pd)"
public void GenerateRepresentation(int /*(int)*/ level, vtkPolyData /*(vtkPolyData*)*/ pd) {
	API_vtkPointLocator.GenerateRepresentation_0(this, level, pd);
}


}
};
