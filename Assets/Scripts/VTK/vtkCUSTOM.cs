using System;
using UnityEngine;
using System.Runtime.InteropServices;

public class ReturnPointer
{
    protected IntPtr data_;

    public ReturnPointer(Type t, int count = 1) {
        data_ = Marshal.AllocHGlobal(Marshal.SizeOf(t)*count);
    }
    ~ReturnPointer() {
        Marshal.FreeHGlobal(data_);
    }
    public static implicit operator long (ReturnPointer p)
    {
        return Marshal.ReadInt64(p);
    }
    public static implicit operator string( ReturnPointer p)
    {
        return Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));;
    }

}

namespace VTK
{
	public partial class  vtkObject : vtkObjectBase {
        public static explicit operator  vtkObject(IntPtr p) {
            vtkObject o = new vtkObject();
            o.SetPtr(p);
            return o;
        }
		public static implicit operator IntPtr(vtkObject o) {
            return b.GetPtr();
        }

        protected void SetPtr(IntPtr d) {
			data_ = d;
		}
		private IntPtr data_;
		protected IntPtr GetPtr() {return data_;}

	}

    public class Link
    {
        ushort ncells;
        IntPtr cells;
    };
}

