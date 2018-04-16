using System;


namespace VTK
{
	public partial class  vtkObject : vtkObjectBase {
		protected void SetPtr(IntPtr d) {
			data_ = d;
		}
		private IntPtr data_;
		protected IntPtr GetPtr() {return data_;}
	}
}

