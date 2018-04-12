using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
	public class vtkDataSet : vtkDataObject
	{
		public static Bounds GetBounds(IntPtr /*vtkDataSet* */ obj) {
			double[] d = new double[6];
			VTK.API_vtkDataSet.GetBounds (obj, d);
			float[] f = Array.ConvertAll(d, x => (float)x);

			Vector3 mm = new Vector3 ((float)(f [0]), (float)(f [2]), (float)(f [4]));
			Vector3 MM = new Vector3 ((float)(f [1]), (float)(f [3]), (float)(f [5]));

			Vector3 center = (mm + MM) / 2;
			Vector3 size = MM - mm;

			return new Bounds(center, size);
		}



		public static string GetClassName(IntPtr /*vtkDataSet* */ obj) {
			IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
			VTK.API_vtkDataSet.GetClassName ( p,obj);;
			string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
			Marshal.FreeHGlobal (p);
			return result;
		}


		public static long GetNumberOfPoints(IntPtr obj) {
			int numElements = 1;
			long example = new long();
			IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
			VTK.API_vtkDataSet.GetNumberOfPoints(p,obj);
			long result = Convert.ToInt64(Marshal.ReadInt64(p));
			Marshal.FreeHGlobal (p);
			return result;
		}


		//       Method: virtual vtkIdType vtkDataSet::GetNumberOfCells()
		// 
		public static long GetNumberOfCells(IntPtr obj) {
			int numElements = 1;
			long example = new long();
			IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
			VTK.API_vtkDataSet.GetNumberOfCells(p,obj);
			long result = Convert.ToInt64(Marshal.ReadInt64(p));
			Marshal.FreeHGlobal (p);
			return result;
		}

		//       Method: virtual double * vtkDataSet::GetPoint(vtkIdType ptId)
		// 
		public static Vector3 GetPoint(IntPtr obj, long ptId) {
			int numElements = 3;
			double[] x = new double[numElements];
			VTK.API_vtkDataSet.GetPoint(obj, ptId, x);
			return new Vector3((float)x[0],(float)x[1],(float)x[2]);
		}

		//       Method: virtual vtkCell * vtkDataSet::GetCell(vtkIdType cellId)
		// 
		public static IntPtr GetCell(IntPtr obj, long cellId) {
			int numElements = 1;
			IntPtr example = new IntPtr();
			IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
			VTK.API_vtkDataSet.GetCell(p,obj, cellId);
			IntPtr result = p;
			Marshal.FreeHGlobal (p);
			return result;
		}


		//       Method: vtkPointData * vtkDataSet::GetPointData()
		// 
		public static IntPtr GetPointData(IntPtr obj) {
			int numElements = 1;
			IntPtr example = new IntPtr();
			IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
			VTK.API_vtkDataSet.GetPointData(p,obj);
			IntPtr result = p;
			Marshal.FreeHGlobal (p);
			return result;
		}

		//       Method: vtkCellData * vtkDataSet::GetCellData()
		// 
		public static IntPtr GetCellData(IntPtr obj) {
			int numElements = 1;
			IntPtr example = new IntPtr();
			IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
			VTK.API_vtkDataSet.GetCellData(p,obj);
			IntPtr result = p;
			Marshal.FreeHGlobal (p);
			return result;
		}


	}

}