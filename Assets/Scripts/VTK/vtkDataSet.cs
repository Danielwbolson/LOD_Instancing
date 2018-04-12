using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{


	public class vtkObjectBase
	{
		public static bool IsTypeOf(string name) {
			int numElements = 1;
			object example = new bool();
			IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);			
			VTK.API_vtkObjectBase.IsTypeOf( p, name);
			bool result = Convert.ToBoolean(Marshal.ReadByte(p));
			Marshal.FreeHGlobal(p);
			return result;
		}

		public static bool IsA(IntPtr /*vtkDataSet* */ obj, string name) {
			IntPtr b =  Marshal.AllocHGlobal(Marshal.SizeOf(new bool()));
			VTK.API_vtkObjectBase.IsA ( b,obj, name);
			bool result = Convert.ToBoolean(Marshal.ReadByte(b));
			Marshal.FreeHGlobal(b);
			return result;
		}
	}

	public class vtkDataObject : vtkObjectBase
	{

	}

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

		public static  int GetNumberOfPoints(IntPtr obj) {
			int numElements = 1;
			int example = new int();
			IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
			VTK.API_vtkDataSet.GetNumberOfPoints (obj, p);
			int result = Convert.ToInt32(Marshal.ReadInt32);
			Marshal.FreeHGlobal (p);
			return result;
		}


	}


	class vtkObject : vtkObjectBase {

	}

	class vtkFieldData : vtkObject {

	}

	class vtkDataSetAttributes : vtkFieldData {

	}

	class vtkCellData : vtkDataSetAttributes {

	}

	class vtkPointData : vtkDataSetAttributes {

	}
}