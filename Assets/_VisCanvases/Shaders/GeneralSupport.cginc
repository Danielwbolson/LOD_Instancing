#ifndef GENERALSUPPORT_INCLUDED
#define GENERALSUPPORT_INCLUDED

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


float2  intersect(float3 orig, float3 invdir, int3 sign, float3 bounds[2]) {
	
    float tmin, tmax, tymin, tymax, tzmin, tzmax;
    tmin = (bounds[sign[0]].x - orig.x) * invdir.x; 
    tmax = (bounds[1-sign[0]].x - orig.x) * invdir.x; 
    tymin = (bounds[sign[1]].y - orig.y) * invdir.y; 
    tymax = (bounds[1-sign[1]].y - orig.y) * invdir.y; 

    //return sign;
    if ((tmin > tymax) || (tymin > tmax)) 
        return float2(0,0);; 
    if (tymin > tmin) 
        tmin = tymin; 
    if (tymax < tmax) 
        tmax = tymax; 

    tzmin = (bounds[sign[2]].z - orig.z) * invdir.z; 
    tzmax = (bounds[1-sign[2]].z - orig.z) * invdir.z; 

    if ((tmin > tzmax) || (tzmin > tmax)) 
        return float2(0,0); 
    if (tzmin > tmin) 
        tmin = tzmin; 
    if (tzmax < tmax) 
        tmax = tzmax; 

    return float2(tmin,tmax);
}


#endif
