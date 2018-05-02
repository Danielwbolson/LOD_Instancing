

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkProgressObserver : vtkObject {
		public vtkProgressObserver(IntPtr p) : base(p) {}
		public static implicit operator  vtkProgressObserver(IntPtr p) {return new vtkProgressObserver(p);}
		public static implicit operator  IntPtr(vtkProgressObserver o) {return o.GetPtr();}

// static vtkProgressObserver* New()
// "static vtkProgressObserver *New()"
public static vtkProgressObserver New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkProgressObserver.New_0(returnPointer.GetPtr());
	return (vtkProgressObserver)(IntPtr)returnPointer;
}


// virtual void UpdateProgress(double amount)
// "virtual void UpdateProgress(double amount)"
public void UpdateProgress(double /*(double)*/ amount) {
	VTK_API.API_vtkProgressObserver.UpdateProgress_0(this, amount);
}


}
};
