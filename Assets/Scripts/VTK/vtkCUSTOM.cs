using System;
using UnityEngine;
using System.Runtime.InteropServices;

public class ReturnPointer
{
    protected IntPtr data_;

    public ReturnPointer(object t, int count = 1) {
        data_ = Marshal.AllocHGlobal(Marshal.SizeOf(t)*count);
    }
    ~ReturnPointer() {
        Marshal.FreeHGlobal(data_);
    }
    public IntPtr GetPtr() {
        return data_;
    }
    public static implicit operator IntPtr(ReturnPointer p)
    {
        IntPtr result;
        unsafe { result = new IntPtr(*(void**)p.data_.ToPointer()); }
        return result;
    }

    public static implicit operator int(ReturnPointer p)
    {
        return Marshal.ReadInt32(p.data_);
    }

    public static implicit operator long (ReturnPointer p)
    {
        return Marshal.ReadInt64(p.data_);
    }
    public static implicit operator ulong(ReturnPointer p)
    {
        return (ulong)Marshal.ReadInt64(p.data_);
    }
    public static implicit operator string( ReturnPointer p)
    {
        return Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p.data_));;
    }

    public static implicit operator bool(ReturnPointer p)
    {
        return Marshal.ReadByte(p.data_) == (byte)1; ;
    }
    public static implicit operator char(ReturnPointer p)
    {
        return (char)Marshal.ReadByte(p.data_) ;
    }
    public static implicit operator double(ReturnPointer p)
    {
        double v = 0;
        if (p.data_ != IntPtr.Zero)
        {
            byte[] ba = new byte[sizeof(double)];

            for (int i = 0; i < ba.Length; i++)
                ba[i] = Marshal.ReadByte(p.data_, i);
            v = BitConverter.ToDouble(ba, 0);
           
        }

        return v;
    }
    public static implicit operator float(ReturnPointer p)
    {
        float v = 0;
        if (p.data_ != IntPtr.Zero)
        {
            byte[] ba = new byte[sizeof(float)];

            for (int i = 0; i < ba.Length; i++)
                ba[i] = Marshal.ReadByte(p.data_, i);
            v = BitConverter.ToSingle(ba, 0);

        }

        return v;
    }
    public static implicit operator VTK.vtkObject( ReturnPointer p)
    {
        IntPtr result;
        unsafe {result = new IntPtr(*(void**)p.data_.ToPointer()); }
        return (VTK.vtkObject)result;

    }

}

namespace VTK
{
	public partial class  vtkObject : vtkObjectBase {

	}

    public class Link
    {
        ushort ncells;
        IntPtr cells;
    };

    public partial class vtkObjectBase
    {

        public vtkObjectBase(IntPtr p) { SetPtr(p); }
        protected void SetPtr(IntPtr d)
        {
            data_ = d;
        }
        private IntPtr data_;
        public IntPtr GetPtr() { return data_; }

    }

    public partial class vtkXMLDataReader {
        // virtual int CanReadFile(const char * name)
        // virtual int CanReadFile(const char* name)
        [DllImport("vtkplugin", EntryPoint = "vtkXMLReader_SetFileName_0")]
        protected static extern
        bool SetFileName_0(IntPtr /*(vtkXMLReader*)*/ callingObject, string /*(char*)*/ name);


        public void SetFileName(string fileName) {
            SetFileName_0(GetPtr(), fileName);
        }
    }
}



