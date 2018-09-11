using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MultimodalReg
{
    // only works for up to two trackers.
    public class ModelAligner : MonoBehaviour
    {
        public SteamVR_TrackedObject[] trackers;
        public GameObject[] movingObjects;

        private Transform[] movingObjParents;
        private TrackerState[] prevStates;
        private AlignmentComputer aligner;


        void Start()
        {
            this.aligner = new AlignmentComputer();

            // create tracker state per tracker
            this.prevStates = new TrackerState[this.trackers.Length];
            for (int i = 0; i < this.prevStates.Length; i++)
            {
                this.prevStates[i] = new TrackerState();
            }

            // save parents of moving objects
            this.movingObjParents = new Transform[this.movingObjects.Length];
            for (int i = 0; i < this.movingObjects.Length; i++)
            {
                this.movingObjParents[i] = this.movingObjects[i].transform.parent;
            }
        }

        void Update()
        {
            Matrix4x4 m = this.GetTransformMatrix();

            // move moving objects
            foreach (GameObject obj in this.movingObjects)
            {
                Matrix4x4 newMatrix = m * obj.transform.localToWorldMatrix;
                // Unity does not allow set the pos, rot, scale via matrix
                obj.transform.position = newMatrix.GetColumn(3);
                obj.transform.rotation = Quaternion.LookRotation(newMatrix.GetColumn(2), newMatrix.GetColumn(1));
                Vector3 newGlobalScale = new Vector3(newMatrix.GetColumn(0).magnitude, newMatrix.GetColumn(1).magnitude, newMatrix.GetColumn(2).magnitude);
                Vector3 newLocalScale = new Vector3(obj.transform.localScale.x * (newGlobalScale.x / obj.transform.lossyScale.x),
                    obj.transform.localScale.y * (newGlobalScale.y / obj.transform.lossyScale.y),
                    obj.transform.localScale.z * (newGlobalScale.z / obj.transform.lossyScale.z));
                obj.transform.localScale = newLocalScale;
            }

            // update previous states for the next frame
            for (int i = 0; i < this.prevStates.Length; i++)
            {
                this.prevStates[i].pos = this.trackers[i].transform.position;
                this.prevStates[i].right = this.trackers[i].transform.right;
                this.prevStates[i].forward = this.trackers[i].transform.forward;
            }
        }


        private SteamVR_Controller.Device GetDevice(SteamVR_TrackedObject tracker)
        {
            int index = (int)tracker.index;

            return index == -1 ? null : SteamVR_Controller.Input((int)tracker.index);
        }


        private Matrix4x4 GetTransformMatrix()
        {
            Matrix4x4 m = Matrix4x4.identity;

            SteamVR_Controller.Device device0 = this.GetDevice(this.trackers[0]);
            if (device0 != null && device0.GetPress(SteamVR_Controller.ButtonMask.Trigger))
            {
                Vector3 src1, src2, src3, dst1, dst2, dst3;

                dst1 = this.trackers[0].transform.position;
                src1 = this.prevStates[0].pos;

                SteamVR_Controller.Device device1 = this.trackers.Length > 1 ? this.GetDevice(this.trackers[1]) : null;
                if (device1 != null && device1.GetPress(SteamVR_Controller.ButtonMask.Trigger))
                {
                    dst2 = this.trackers[1].transform.position;
                    src2 = this.prevStates[1].pos;

                    dst3 = dst1 + this.trackers[0].transform.forward.normalized;
                    src3 = src1 + this.prevStates[0].forward.normalized;
                }
                else
                {
                    dst2 = dst1 + this.trackers[0].transform.right.normalized;
                    src2 = src1 + this.prevStates[0].right.normalized;

                    dst3 = dst1 + this.trackers[0].transform.forward.normalized;
                    src3 = src1 + this.prevStates[0].forward.normalized;
                }

                m = this.aligner.Compute(src1, src2, src3, dst1, dst2, dst3);
            }

            return m;
        }


        private struct TrackerState
        {
            public Vector3 pos;
            public Vector3 right;
            public Vector3 forward;
        }
    }
}