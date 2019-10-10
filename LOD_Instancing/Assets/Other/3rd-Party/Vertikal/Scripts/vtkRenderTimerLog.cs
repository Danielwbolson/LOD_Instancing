

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkRenderTimerLog : vtkObject {
		public vtkRenderTimerLog(IntPtr p) : base(p) {}
		public static implicit operator  vtkRenderTimerLog(IntPtr p) {return new vtkRenderTimerLog(p);}
		public static implicit operator  IntPtr(vtkRenderTimerLog o) {return o.GetPtr();}

}
};
