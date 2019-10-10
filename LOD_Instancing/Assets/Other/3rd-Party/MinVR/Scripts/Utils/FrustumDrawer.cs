using UnityEngine;
using System.Collections;

/** Shows frustum(s) of a camera. Need this when you are using a custum projection matrix.
 * Also need this when you are using a custum world to camera matrix.
 * Unity3D Editor shows a frustum with thin grey lines. 
 * However, this is not updated once you start using a custom projection matrix.
 * 
 * For a VR camera...
 * If target eye is "Left", draw one frustum for the left eye.
 * If target eye is "Right", draw one frustum for the right eye.
 * If target eye is "Both", draw two frustums for the both eyes.
 *
 * For a non-VR camera..
 * draw one fruction for one eye.
 *
 * This code only updates in an Editor mode.
 */

[ExecuteInEditMode, RequireComponent(typeof(Camera))]
public class FrustumDrawer : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        this.cam = gameObject.GetComponent<Camera>();
    }

#if UNITY_EDITOR
    void Update()
    {
        // Draw actual camera frustum(s)
        if (this.cam.stereoTargetEye == StereoTargetEyeMask.Both || this.cam.stereoTargetEye == StereoTargetEyeMask.Left)
        {
            Matrix4x4 worldToProjectionMatrix = this.cam.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left) * this.cam.GetStereoViewMatrix(Camera.StereoscopicEye.Left);
            this.DrawFrustum(worldToProjectionMatrix);
        }
        if (this.cam.stereoTargetEye == StereoTargetEyeMask.Both || this.cam.stereoTargetEye == StereoTargetEyeMask.Right)
        {
            Matrix4x4 worldToProjectionMatrix = this.cam.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right) * this.cam.GetStereoViewMatrix(Camera.StereoscopicEye.Right);
            this.DrawFrustum(worldToProjectionMatrix);
        }
    }
#endif

    // draw lines that form a frustum
    // http://forum.unity3d.com/threads/off-axis-projection-with-unity.192409/
    private void DrawFrustum(Matrix4x4 worldToProjectionMatrix)
    {
        Plane[] camPlanes = GeometryUtility.CalculateFrustumPlanes(worldToProjectionMatrix); // get planes from matrix

        // camPlanes 0->5: left, right, down, up, near, far
        Plane temp = camPlanes[1];
        camPlanes[1] = camPlanes[2];
        camPlanes[2] = temp; //swap [1] and [2] so the order is better for the loop
                             // now camPlanes 0->5: left, down, right, up, near, far

        Vector3[] nearCorners = new Vector3[4]; // Approx'd nearplane corners
        Vector3[] farCorners = new Vector3[4]; // Approx'd farplane corners

        for (int i = 0; i < 4; i++)
        {
            nearCorners[i] = ThreePlaneIntersection(camPlanes[4], camPlanes[i], camPlanes[(i + 1) % 4]); // near corners on the created projection matrix
            farCorners[i] = ThreePlaneIntersection(camPlanes[5], camPlanes[i], camPlanes[(i + 1) % 4]); // far corners on the created projection matrix
        }

        for (int i = 0; i < 4; i++)
        {
            Debug.DrawLine(nearCorners[i], nearCorners[(i + 1) % 4], Color.red, Time.deltaTime, false); // near corners on the created projection matrix
            Debug.DrawLine(farCorners[i], farCorners[(i + 1) % 4], Color.blue, Time.deltaTime, false); // far corners on the created projection matrix
            Debug.DrawLine(nearCorners[i], farCorners[i], Color.white, Time.deltaTime, false); // sides of the created projection matrix
        }
    }

    // get the intersection point of 3 planes
    private Vector3 ThreePlaneIntersection(Plane p1, Plane p2, Plane p3)
    {
        return ((-p1.distance * Vector3.Cross(p2.normal, p3.normal)) +
        (-p2.distance * Vector3.Cross(p3.normal, p1.normal)) +
        (-p3.distance * Vector3.Cross(p1.normal, p2.normal))) /
        (Vector3.Dot(p1.normal, Vector3.Cross(p2.normal, p3.normal)));
    }
}
