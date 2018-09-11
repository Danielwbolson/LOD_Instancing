using UnityEngine;
using System;


namespace MinVR {

	// Converts VRCoreTypes used by VRDataIndex to types used by Unity
	public class VRConvert {
		
		public static Matrix4x4 ToMatrix4x4(double[] d) {
			Matrix4x4 m = new Matrix4x4();
			m[0,0] = (float)d[0];  m[0,1] = (float)d[4];  m[0,2] = (float)d[8];  m[0,3] = (float)d[12]; 
			m[1,0] = (float)d[1];  m[1,1] = (float)d[5];  m[1,2] = (float)d[9];  m[1,3] = (float)d[13];
			m[2,0] = (float)d[2];  m[2,1] = (float)d[6];  m[2,2] = (float)d[10]; m[2,3] = (float)d[14];
			m[3,0] = (float)d[3];  m[3,1] = (float)d[7];  m[3,2] = (float)d[11]; m[3,3] = (float)d[15];
			return m;
		}

		public static Vector3 ToVector3(double[] d) {
			return new Vector3((float)d[0], (float)d[1], (float)d[2]);
		}
		
		public static double[] ToDoubleArray(Matrix4x4 m) {
			double[] d = new double[16];
			d[0] = m[0,0];  d[4] = m[0,1];  d[8] = m[0,2];  d[12] = m[0,3]; 
			d[1] = m[1,0];  d[5] = m[1,1];  d[9] = m[1,2];  d[13] = m[1,3];
			d[2] = m[2,0];  d[6] = m[2,1];  d[10] = m[2,2]; d[14] = m[2,3];
			d[3] = m[3,0];  d[7] = m[3,1];  d[11] = m[3,2]; d[15] = m[3,3];
			return d;
		}

		public static double[] ToDoubleArray(Vector3 v) {
			double[] d = new double[3];
			d[0] = v.x;
			d[1] = v.y;
			d[2] = v.z;
			return d;
		}

	}

} // namespace MinVR
