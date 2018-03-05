using UnityEngine;
using System.Collections;

namespace MinVR
{
    /** From eye and screen positions, computes a projection matrix and a world-to-camera matrix (i.e. a view matrix) for a camera.
	 * Important: our off-axis projection script assumes that a projection screen is a rectangle. 
	 * 
	 * https://en.wikibooks.org/wiki/Cg_Programming/Unity/Projection_for_Virtual_Reality
	 * https://github.com/MinVR/MinVR/blob/master/MVRCore/source/CameraOffAxis.cpp
	 * http://csc.lsu.edu/~kooima/articles/genperspective/ 
	 */
    [ExecuteInEditMode, RequireComponent(typeof(Camera))]
    public class VROffAxisProjectionCamera : MonoBehaviour
    {
        public VRProjectionScreen projectionScreen;
        public enum ProjectionType { Perspective, Parallel };
        public ProjectionType projectionType;

        private Camera cam;

        void Start()
        {
            this.cam = this.GetComponent<Camera>();
        }

        void LateUpdate()
        {
            // screen corners in world space
            Vector3 bl = this.projectionScreen.GetBottomLeftCorner();
            Vector3 br = this.projectionScreen.GetBottomRightCorner();
            Vector3 tl = this.projectionScreen.GetTopLeftCorner();
            Vector3 tr = this.projectionScreen.GetTopRightCorner();

            Vector3 vr; // right axis of screen
            Vector3 vu; // up axis of screen
            Vector3 vn; // normal vector of screen

            vr = br - bl;
            vu = tl - bl;
            vr.Normalize();
            vu.Normalize();
            vn = -Vector3.Cross(vr, vu); // we need the minus sign because Unity uses a left-handed coordinate system
            vn.Normalize();
            
            // set matrices: projection and view matrices
            //// for left eye...
            if (this.cam.stereoTargetEye == StereoTargetEyeMask.Both || this.cam.stereoTargetEye == StereoTargetEyeMask.Left)
            {
                Vector3 pe = getLeftEyePosition(); // eye position
                this.cam.SetStereoProjectionMatrix(Camera.StereoscopicEye.Left, this.GetStereoProjectionMatrix(pe, vr, vu, vn));
                this.cam.SetStereoViewMatrix(Camera.StereoscopicEye.Left, this.GetStereoViewMatrix(pe, vr, vu, vn));
            }
            //// for right eye...
            if (this.cam.stereoTargetEye == StereoTargetEyeMask.Both || this.cam.stereoTargetEye == StereoTargetEyeMask.Right)
            {
                Vector3 pe = getRightEyePosition(); // eye position
                this.cam.SetStereoProjectionMatrix(Camera.StereoscopicEye.Right, this.GetStereoProjectionMatrix(pe, vr, vu, vn));
                this.cam.SetStereoViewMatrix(Camera.StereoscopicEye.Right, this.GetStereoViewMatrix(pe, vr, vu, vn));
            }

            // The original paper puts everything into the projection  matrix (i.e. sets it to p * rm * tm and the other 
            // matrix to the identity), but this doesn't appear to work with Unity's shadow maps.
            // https://en.wikibooks.org/wiki/Cg_Programming/Unity/Projection_for_Virtual_Reality
            // talks about Unity using camera's rotation and its fov for view culling
            // they provide an implmentation to adjust them according to the above computations. 
            // we have not implemented this here: seems to work fine for now and VR Tracker Listener might be rotating the camera. 
        }

        // Vector3 pe; // eye position
        // Vector3 vr; // right axis of screen
        // Vector3 vu; // up axis of screen
        // Vector3 vn; // normal vector of screen
        private Matrix4x4 GetStereoViewMatrix(Vector3 pe, Vector3 vr, Vector3 vu, Vector3 vn)
        {
            // rotation matrix;
            Matrix4x4 rm = Matrix4x4.identity;
            rm[0, 0] = vr.x;
            rm[0, 1] = vr.y;
            rm[0, 2] = vr.z;
            rm[0, 3] = 0.0f;

            rm[1, 0] = vu.x;
            rm[1, 1] = vu.y;
            rm[1, 2] = vu.z;
            rm[1, 3] = 0.0f;

            rm[2, 0] = vn.x;
            rm[2, 1] = vn.y;
            rm[2, 2] = vn.z;
            rm[2, 3] = 0.0f;

            rm[3, 0] = 0.0f;
            rm[3, 1] = 0.0f;
            rm[3, 2] = 0.0f;
            rm[3, 3] = 1.0f;

            // translation matrix;
            Matrix4x4 tm = Matrix4x4.identity;
            tm[0, 0] = 1.0f;
            tm[0, 1] = 0.0f;
            tm[0, 2] = 0.0f;
            tm[0, 3] = -pe.x;

            tm[1, 0] = 0.0f;
            tm[1, 1] = 1.0f;
            tm[1, 2] = 0.0f;
            tm[1, 3] = -pe.y;

            tm[2, 0] = 0.0f;
            tm[2, 1] = 0.0f;
            tm[2, 2] = 1.0f;
            tm[2, 3] = -pe.z;

            tm[3, 0] = 0.0f;
            tm[3, 1] = 0.0f;
            tm[3, 2] = 0.0f;
            tm[3, 3] = 1.0f;

            // view matrix;
            return rm * tm;
        }

        // Vector3 pe; // eye position
        // Vector3 vr; // right axis of screen
        // Vector3 vu; // up axis of screen
        // Vector3 vn; // normal vector of screen
        private Matrix4x4 GetStereoProjectionMatrix(Vector3 pe, Vector3 vr, Vector3 vu, Vector3 vn)
        {
            float n = this.cam.nearClipPlane;
            float f = this.cam.farClipPlane;

            // screen corners in world space
            Vector3 bl = this.projectionScreen.GetBottomLeftCorner();
            Vector3 br = this.projectionScreen.GetBottomRightCorner();
            Vector3 tl = this.projectionScreen.GetTopLeftCorner();
            Vector3 tr = this.projectionScreen.GetTopRightCorner();

            float l; // distance to left screen edge
            float r; // distance to right screen edge
            float b; // distance to bottom screen edge
            float t; // distance to top screen edge
            float d; // distance from eye to screen 
            
            //
            Vector3 vbl; // from pe to bl
            Vector3 vbr; // from pe to br
            Vector3 vtl; // from pe to tl
            if (this.projectionType == ProjectionType.Perspective)
            {
                vbl = bl - pe;
                vbr = br - pe;
                vtl = tl - pe;

                d = -Vector3.Dot(vbl, vn);
                l = Vector3.Dot(vr, vbl) * n / d;
                r = Vector3.Dot(vr, vbr) * n / d;
                b = Vector3.Dot(vu, vbl) * n / d;
                t = Vector3.Dot(vu, vtl) * n / d;
            }
            else { // parallel projection
                float halfWidth = (br - bl).magnitude / 2.0f;
                float halfHeight = (tl - bl).magnitude / 2.0f;

                l = -halfWidth;
                r = halfWidth;
                b = -halfHeight;
                t = halfHeight;
            }

            // projection matrix 
            Matrix4x4 p = Matrix4x4.identity;
            if (this.projectionType == ProjectionType.Perspective)
            {
                p[0, 0] = 2.0f * n / (r - l);
                p[0, 1] = 0.0f;
                p[0, 2] = (r + l) / (r - l);
                p[0, 3] = 0.0f;

                p[1, 0] = 0.0f;
                p[1, 1] = 2.0f * n / (t - b);
                p[1, 2] = (t + b) / (t - b);
                p[1, 3] = 0.0f;

                p[2, 0] = 0.0f;
                p[2, 1] = 0.0f;
                p[2, 2] = (f + n) / (n - f);
                p[2, 3] = 2.0f * f * n / (n - f);

                p[3, 0] = 0.0f;
                p[3, 1] = 0.0f;
                p[3, 2] = -1.0f;
                p[3, 3] = 0.0f;
            }
            else { // parallel projection
                p = Matrix4x4.Ortho(l, r, b, t, n, f);

                // compute a sheering matrix for off-axis parallel proejction
                Vector3 center = (tl + tr + br + bl) / 4.0f; // center of the screen
                Vector3 vc = pe - center; // from eye to the center

                Vector3 vcOnVrVnPlane = vc - (Vector3.Dot(vc, vu) * vu);
                Vector3 vcOnVuVnPlane = vc - (Vector3.Dot(vc, vr) * vr);

                float theta = Vector3.Angle(vr, vcOnVrVnPlane) * Mathf.Deg2Rad;
                float phi = Vector3.Angle(vu, vcOnVuVnPlane) * Mathf.Deg2Rad;

                Matrix4x4 h = Matrix4x4.identity; // a sheering matrix
                h[0, 2] = -1f / Mathf.Tan(theta);
                h[1, 2] = -1f / Mathf.Tan(phi);
                p *= h;
            }

            return p;
        }

        Vector3 getLeftEyePosition()
        {
            // offset to the left by 1/2 the interocular distance
            Vector3 offset = this.transform.TransformVector(new Vector3(-this.cam.stereoSeparation / 2f, 0f, 0f));
            return this.transform.position + offset;
        }

        Vector3 getRightEyePosition()
        {
            // offset to the right by 1/2 the interocular distance
            Vector3 offset = transform.TransformVector(new Vector3(this.cam.stereoSeparation / 2f, 0f, 0f));
            return this.transform.position + offset;
        }
    }
}