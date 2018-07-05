#ifndef CANVASSUPPORT_INCLUDED
#define CANVASSUPPORT_INCLUDED


float4x4 _InverseCanvas;
float3 _CanvasBoundsCenter;
float3 _CanvasBoundsExtent;
float3 _CanvasBoundsExtentThreshold;
float3 _CanvasBoundsThreshold;
float4 _CropColor;
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

int OnBounds(float3 extents, float3 threshold, float3 position) {
    int3 b = int3(0,0,0);
    if(abs(position.x - extents.x) < threshold.x) 
        b.x = 1;
    if(abs(position.y - extents.y) < threshold.y) 
        b.y = 1;
    if(abs(position.z - extents.z) < threshold.z) 
        b.z = 1;
    if(abs(position.x - -extents.x) < threshold.x) 
        b.x = 1;
    if(abs(position.y - -extents.y) < threshold.y) 
        b.y = 1;
    if(abs(position.z - -extents.z) < threshold.z) 
        b.z = 1;

    if( (b.x || b.y || b.z) && OutOfBounds(extents,threshold,position) <= 0.0001)
        return 1 ;   
    return 0;
}


#define MARKBOUNDS if(OnBounds(_CanvasBoundsExtent,_CanvasBoundsThreshold,mul(_InverseCanvas,float4(IN.worldPos.x,IN.worldPos.y,IN.worldPos.z,1))) == 1) o.Albedo = blend(o.Albedo,color.rgb,color.a);

#define STIPPLE_CROP STIPPLE_TRANSPARENCY(1-OutOfBounds(_CanvasBoundsExtent,_CanvasBoundsExtentThreshold,mul(_InverseCanvas,float4(IN.worldPos.x,IN.worldPos.y,IN.worldPos.z,1))))
#define STIPPLE_TRANSPARENCY(transparency) StippleTransparency(IN, transparency)
void StippleTransparency(Input IN, half _Transparency) {
    float4x4 thresholdMatrix =
    {  1.0 / 17.0,  9.0 / 17.0,  3.0 / 17.0, 11.0 / 17.0,
      13.0 / 17.0,  5.0 / 17.0, 15.0 / 17.0,  7.0 / 17.0,
       4.0 / 17.0, 12.0 / 17.0,  2.0 / 17.0, 10.0 / 17.0,
      16.0 / 17.0,  8.0 / 17.0, 14.0 / 17.0,  6.0 / 17.0
    };
    float4x4 _RowAccess = { 1,0,0,0, 0,1,0,0, 0,0,1,0, 0,0,0,1 };
    float2 pos = IN.screenPos.xy / IN.screenPos.w;
    pos *= _ScreenParams.xy; // pixel position
    clip(_Transparency - thresholdMatrix[fmod(pos.x, 4)] * _RowAccess[fmod(pos.y, 4)]);
}

#define ALPHA_CROP(canvasPosition) ALPHA_TRANSPARENCY(OutOfBounds(_CanvasBoundsExtent,_CanvasBoundsExtentThreshold,canvasPosition))
#define ALPHA_TRANSPARENCY(transparency) o.Alpha = transparency;

#endif
