using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
    public class StyleSlice : StyleModule {

        [HideInInspector]
        public bool _toggled = true;

        [HideInInspector]
        public Vector3 _centerPos, _up, _normal;

        [HideInInspector]
        public float _width, _height;

        public StyleSlice Init() {
            return this;
        }


        public override string GetStyle() {
            return "Layer";
        }

        public virtual void DrawStyle(Canvas canvas) {

        }

        public virtual StyleSlice CopySlice(StyleSlice toCopy) {
            return this;
        }

    }
}