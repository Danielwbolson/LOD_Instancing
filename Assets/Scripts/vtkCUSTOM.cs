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


        return (VTK.vtkObject)(IntPtr)p;

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

        public bool IsVoid() {
            return data_ == IntPtr.Zero;
        }

        public override string ToString()
        {
            if(GetPtr() == IntPtr.Zero) {
                return "Null VTK Object";
            } else {
                return GetClassName() + " object at address " + GetPtr().ToString();
            }
             
        }
    }




    public partial class vtkDataSet {
        public Bounds GetBounds() {
            double[] b = new double[6];
            GetBounds(b);
            Bounds result = new Bounds();
            result.SetMinMax(new Vector3((float)b[0], (float)b[2], (float)b[4]), new Vector3((float)b[1], (float)b[3], (float)b[5]));
            return result;
        }

        public Bounds GetCellBounds(long cellId)
        {
            double[] b = new double[6];
            GetCellBounds(cellId,b);
            Bounds result = new Bounds();
            result.SetMinMax(new Vector3((float)b[0], (float)b[2], (float)b[4]), new Vector3((float)b[1], (float)b[3], (float)b[5]));
            return result;
        }

    }

    public partial class vtkPoints {

        public Vector3 GetPoint(long pointId)
        {
            double[] p = new double[3];
            GetPoint_1(pointId,p);
            return new Vector3((float)p[0], (float)p[1], (float)p[2]);
        }
    }

    public partial class vtkDataSet {

        public Vector3 GetPoint(long pointId)
        {
            double[] p = new double[3];
            GetPoint_1(pointId,p);
            return new Vector3((float)p[0], (float)p[1], (float)p[2]);
        }
    }
}



