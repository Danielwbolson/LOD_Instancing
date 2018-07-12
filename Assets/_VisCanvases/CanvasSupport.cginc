#ifndef CANVASSUPPORT_INCLUDED
#define CANVASSUPPORT_INCLUDED


float4x4 _InverseCanvas;
float4x4 _InverseCanvasInnerScene;
float4x4 _CanvasInnerScene;
float3 _CanvasBoundsCenter;
float3 _CanvasBoundsExtent;
float3 _CanvasBoundsExtentThreshold;
float3 _CanvasBoundsThreshold;
float4 _CropColor;

half4 Lerp(half4 colorA, half4 colorB, float tween) {
    return colorA*(1-tween) + colorB * tween; 
}
half4 mix(half4 colorA, half4 colorB) {
    //return half4(0, colorA.a, 0, 1);//(colorA*(1-colorB.a)+colorB*colorB.a)*0.5;
    //return half4()
    //return half4(colorA.rgb*(1-colorB.a)*colorA.a + colorB * colorB.a * colorA.a,colorA.a);
    return half4((colorA.rgb*colorA.a+colorB.rgb*colorB.a),colorA.a+colorB.a);
}
float map(float value, float min1, float max1, float min2, float max2)
{
    // Convert the current value to a percentage
    // 0% - min1, 100% - max1
    float perc = (value - min1) / (max1 - min1);

    // Do the same operation backwards with min2 and max2
    return  perc * (max2 - min2) + min2;
}



float OutOfBounds(float3 extents, float3 threshold, float3 position) {
    float3 oob;
    if(position.x > extents.x) 
        oob.x = map(position.x - extents.x, 0,threshold.x, 0, 1);
    if(position.y > extents.y) 
        oob.y = map(position.y - extents.y, 0,threshold.y, 0, 1);
    if(position.z > extents.z) 
        oob.z = map(position.z - extents.z, 0,threshold.z, 0, 1);      

    if(position.x < -extents.x) 
        oob.x = map( (-extents.x) - position.x, 0,threshold.x, 0, 1);
    if(position.y < -extents.y) 
        oob.y = map( (-extents.y) - position.y, 0,threshold.y, 0, 1);
    if(position.z < -extents.z) 
        oob.z = map( (-extents.z) - position.z, 0,threshold.z, 0, 1);   

    return max(oob.x,max(oob.y, oob.z));
}

float OnBounds(float3 extents, float3 threshold, float3 position) {
    float3 b = int3(0,0,0);
    if(abs(position.x - extents.x) < threshold.x) 
        b.x = map(abs(position.x - extents.x), 0, threshold.x,1,0);
    if(abs(position.y - extents.y) < threshold.y) 
        b.y = map(abs(position.y - extents.y), 0, threshold.y,1,0);
    if(abs(position.z - extents.z) < threshold.z) 
        b.z = map(abs(position.z - extents.z), 0, threshold.z,1,0);
    if(abs(position.x - -extents.x) < threshold.x) 
        b.x = map(abs(position.x - -extents.x), 0, threshold.x,1,0);
    if(abs(position.y - -extents.y) < threshold.y) 
        b.y = map(abs(position.y - -extents.y), 0, threshold.y,1,0);
    if(abs(position.z - -extents.z) < threshold.z) 
        b.z = map(abs(position.z - -extents.z), 0, threshold.z,1,0);

    if( (b.x > 0 || b.y > 0 || b.z > 0) && OutOfBounds(extents,threshold,position) <= max(threshold.x,max(threshold.z,threshold.y)))
        return clamp(max(b.x,max(b.z,b.y)),0,1) ;   
    return 0;
}


// #define MARKBOUNDS(worldPos);

// #define STIPPLE_CROP(worldPos,screenPos,screenParams) STIPPLE_TRANSPARENCY(screenPos, screenParams,1-OutOfBounds(_CanvasBoundsExtent,_CanvasBoundsExtentThreshold,mul(_InverseCanvas,float4(worldPos.x,worldPos.y,worldPos.z,1))))
// #define STIPPLE_TRANSPARENCY(screenPos, screenParams,transparency) 

fixed4 MarkBounds(float3 worldPos, fixed4 currentColor) {
    half4 result = currentColor; 
    float onBounds = 5.0*OnBounds(_CanvasBoundsExtent,_CanvasBoundsThreshold,mul(_InverseCanvas,float4(worldPos.x,worldPos.y,worldPos.z,1))); 
    if(onBounds > 0) 
    {
        result = Lerp(currentColor,half4(_CropColor.r, _CropColor.g,_CropColor.b, 0), _CropColor.a*onBounds);
    }
    return result;
}
void StippleTransparency(float4 screenPos, float4 screenParams, half transparency) {
    float4x4 thresholdMatrix =
    {  1.0 / 17.0,  9.0 / 17.0,  3.0 / 17.0, 11.0 / 17.0,
      13.0 / 17.0,  5.0 / 17.0, 15.0 / 17.0,  7.0 / 17.0,
       4.0 / 17.0, 12.0 / 17.0,  2.0 / 17.0, 10.0 / 17.0,
      16.0 / 17.0,  8.0 / 17.0, 14.0 / 17.0,  6.0 / 17.0
    };
    float4x4 _RowAccess = { 1,0,0,0, 0,1,0,0, 0,0,1,0, 0,0,0,1 };
    float2 pos = screenPos.xy / screenPos.w;
    pos *= screenParams.xy; // pixel position
    clip(transparency - thresholdMatrix[fmod(pos.x, 4)] * _RowAccess[fmod(pos.y, 4)]);
}

void StippleCrop(float3 worldPos,float4 screenPos, float4 screenParams) {
    half t = 1-OutOfBounds(_CanvasBoundsExtent,_CanvasBoundsExtentThreshold,mul(_InverseCanvas,float4(worldPos.x,worldPos.y,worldPos.z,1)));
    StippleTransparency(screenPos,screenParams, t);
}

#define ALPHA_CROP(canvasPosition) ALPHA_TRANSPARENCY(OutOfBounds(_CanvasBoundsExtent,_CanvasBoundsExtentThreshold,canvasPosition))
#define ALPHA_TRANSPARENCY(transparency) o.Alpha = transparency;

#endif
