
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK {

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


 	public class vtkObject : vtkObjectBase {

 	}

 };