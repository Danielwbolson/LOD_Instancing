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


#endif
