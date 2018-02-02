using UnityEngine;

public static class Matrix4x4Extensions {
	
	// Assumes m is a rigid body transformation matrix with no scaling.
	/*public static Quaternion GetRotation(this Matrix4x4 m) {
		// http://answers.unity3d.com/questions/11363/converting-matrix4x4-to-quaternion-vector3.html
		return Quaternion.LookRotation(m.GetColumn(2), m.GetColumn(1));
	}*/

	public static Vector3 GetTranslation(this Matrix4x4 m) {
		return m.GetColumn(3);
	}
	
}
