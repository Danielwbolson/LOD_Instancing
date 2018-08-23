using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Goal:
 * We want to add in Slicing/cutting planes, similar to what we had in the old Layer system, 
 * except that instead of the slice being the layer itself, the VisController will manage a list 
 * of "slices" that all the canvases will have access to (this means that the slices are positioned 
 * relative to one of the canvases' inner data transforms, and if you place the slicing plane in the 
 * middle of that transform, the slice will effectively be available in the middle of all the canvas 
 * data spaces).
 * 
 * Then when we create layers, the layer will have the option to take advantage of any number of those slicing planes.
 * The anatomy of a slicing plane:
 * 1. a center position
 * 2. an "up" vector" 
 * 3. a normal vector
 * 4. a width & height
 * These may be used to draw a flat slice out of a volume data set,
 * or they may be used to limit which glyphs we're rendering (so that we're only looking at a "slice" of a glyph field),
 * or they may be used to "cut off" or crop a volume rendering.
 * 
 * I see the steps being
 * 1. make a simple data structure for these slicing planes, 
 * 2. add a dynamic list of these in the StyleController,
 * 3. determine some interface for positioning and orienting these (feel free to do something simple for now like have 
 * them driven by game objects that are defined relative to the scene origin or even relative to the innerSceneTransform 
 * of one of the canvases). 
 * 4. Find a way to create/delete the planes through the window.
 * 
 * Visible in all canvases.
 * We’ll want some sort of data structure we can send to the shaders so we can handle these planes
 * 
 * 
 * FIRST STEP: 
 * Maybe a good test is to add a slice to the glyph preview layer
 * And discard all the fragments that fall on one side of it.
 * 
 * 
 * CURRENT WORK (Daniel):
 * Right now there are issues with adding a plane to the GUI in the bottom. There are too many GuiLayout features
 * being pushed, compared to those popped. I am not sure how to fix that. There are also some design issues. Right now, 
 * everything is convoluted. There are too many dependencies and connections between classes. A Plane should only be
 * connected to a layer and to the style. However, we could also go the approach of making the plane a global widget, not
 * tied to the style at all. Either way, whatever we have now needs to be redesigned.
 * 
 * There is also right now some confusion, at least for me, between using a StylePlane and being able to send information
 * to the shader through the a ComputeBuffer. That requires a struct, but we have a class. So right now, we have some
 * redundant/confusing structure in having both a StylePlane class and a Plane struct. There are a couple ways we could
 * head towards fixes for that: Use a predefined length array in the shader, not using a computebuffer (limits dynamicism)
 * or, if we do abstract the Plane away from the style and stylecontroller, we could find different design options there.
 */

namespace SculptingVis {

    public struct Plane {
        public Vector3 _center;
        public Vector3 _normal;
    }

    public class StylePlane : StyleModule {

        [HideInInspector]
        public Vector3 _center, _normal;

        public static implicit operator Plane(StylePlane p) {
            Plane newP = new Plane {
                _center = p._center,
                _normal = p._normal
            };
            return newP;
        }
    }
}
