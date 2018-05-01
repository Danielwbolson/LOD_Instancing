

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkProgressObserver : vtkObject {

// static vtkProgressObserver* New()
// "static vtkProgressObserver *New()"
public new static vtkProgressObserver New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkProgressObserver.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void UpdateProgress(double amount)
// "virtual void UpdateProgress(double amount)"
public new void UpdateProgress(double /*(double)*/ amount) {
	API_vtkProgressObserver.UpdateProgress_0(this, amount);
}


}
};
