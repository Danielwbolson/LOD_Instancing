using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MultimodalReg
{
    public class AlignmentComputer
    {
        public AlignmentComputer()
        {

        }

        public Matrix4x4 Compute(Vector3 src1, Vector3 src2, Vector3 src3,
                                  Vector3 dst1, Vector3 dst2, Vector3 dst3)
        {
            Matrix4x4 srcCF = this.CreateCoordinateFrameMatrix(src1, src2, src3);
            Matrix4x4 dstCF = this.CreateCoordinateFrameMatrix(dst1, dst2, dst3);

            float scale = (dst2 - dst1).magnitude / (src2 - src1).magnitude;
            Matrix4x4 scaleM = Matrix4x4.Scale(new Vector3(scale, scale, scale));

            Matrix4x4 transDst1M = Matrix4x4.identity;
            transDst1M.SetColumn(3, new Vector4(dst1.x, dst1.y, dst1.z, 1));

            Matrix4x4 transMinusDst1M = Matrix4x4.identity;
            transMinusDst1M.SetColumn(3, new Vector4(-dst1.x, -dst1.y, -dst1.z, 1));

            return transDst1M * scaleM * transMinusDst1M * dstCF * srcCF.inverse;
        }

        // create a coordinate frame from three points (pt1 is the origin).
        private Matrix4x4 CreateCoordinateFrameMatrix(Vector3 pt1, Vector3 pt2, Vector3 pt3)
        {
            // compute axes
            Vector3 srcX = (pt2 - pt1);
            srcX.Normalize();
            Vector3 srcY = (pt3 - pt1);
            srcY.Normalize();
            Vector3 srcZ = Vector3.Cross(srcX, srcY);
            srcZ.Normalize();
            srcY = Vector3.Cross(srcZ, srcX);
            srcY.Normalize();

            // represent them in a matrix form
            Matrix4x4 cf = new Matrix4x4();
            cf.SetColumn(0, new Vector4(srcX.x, srcX.y, srcX.z, 0));
            cf.SetColumn(1, new Vector4(srcY.x, srcY.y, srcY.z, 0));
            cf.SetColumn(2, new Vector4(srcZ.x, srcZ.y, srcZ.z, 0));
            cf.SetColumn(3, new Vector4(pt1.x, pt1.y, pt1.z, 1));

            return cf;
        }

    }
}