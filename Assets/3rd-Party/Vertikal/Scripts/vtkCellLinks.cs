

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellLinks : vtkAbstractCellLinks {
		public vtkCellLinks(IntPtr p) : base(p) {}
		public static implicit operator  vtkCellLinks(IntPtr p) {return new vtkCellLinks(p);}
		public static implicit operator  IntPtr(vtkCellLinks o) {return o.GetPtr();}

}
};
