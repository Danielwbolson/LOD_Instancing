

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkHardwareSelector : vtkObject {
		public vtkHardwareSelector(IntPtr p) : base(p) {}
		public static implicit operator  vtkHardwareSelector(IntPtr p) {return new vtkHardwareSelector(p);}
		public static implicit operator  IntPtr(vtkHardwareSelector o) {return o.GetPtr();}

}
};
