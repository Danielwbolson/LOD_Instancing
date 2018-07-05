// Upgrade NOTE: replaced '_World2Object' with 'unity_WorldToObject'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Unlit/VolumeCube"
{
	Properties
	{
		_TransferColor("Color Transfer Function",2D) = "white" {}
		_TransferAlpha("Alpha Transfer Function",2D) = "white" {}
		_XSlice("X Slicing Amount",Float) = 0 
		_ZSlice("Z Slicing Amount",Float) = 0 
		

	}
	SubShader
	{
		Tags { "RenderType"="Transparent" "Queue" = "Transparent" } 
		LOD 100

		Pass
		{
			ZWrite Off
			Cull Back
			ZTest Always
						Blend SrcAlpha OneMinusSrcAlpha

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog

			#include "UnityCG.cginc"
			float4x4 _ViewProjectInverse;

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
			    float2 uv : TEXCOORD0;
			    float3 modelDirection : TEXCOORD1;
			    float4 screenPosition : TEXCOORD2;
			    float4 vertex : SV_POSITION;
			    float3 modelSpaceCameraPos :TEXCOORD3;
			    float4 modelPosition : TEXCOORD4;


			};

			sampler2D _CameraDepthTexture;
			sampler3D _VolumeTexture;
			sampler2D _TransferColor;
			sampler2D _TransferAlpha;
			float4 _VolumeDimensions;
			float _XSlice;
			float _ZSlice;
			v2f vert (appdata v)
			{
			    v2f o;

			    // Subtract camera position from vertex position in world
			    // to get a ray pointing from the camera to this vertex.
			    o.modelSpaceCameraPos = mul(unity_WorldToObject,float4(_WorldSpaceCameraPos,1)).xyz;

			    o.modelDirection = v.vertex.xyz - o.modelSpaceCameraPos;

			    // Typical boilerplate.
			    o.vertex = UnityObjectToClipPos(v.vertex);
			    o.uv = v.uv;

			    // Save the clip space position so we can use it later.
			    // (There are more efficient ways to do this in SM 3.0+, 
			    // but here I'm aiming for the simplest version I can.
			    // Optimized versions welcome in additional answers!)
			    o.screenPosition = ComputeScreenPos(o.vertex);
			    o.modelPosition = v.vertex;

			    // Done.
			    return o;
			}

			float2  intersect(float3 orig, float3 invdir, int3 sign) {
				float3 bounds[2] = {{-0.5,-0.5,-0.5},{0.5,0.5,0.5}};	
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

//			float2 depths() {
//
//				return float2(frontDepth, backDepth);
//
//			}
			fixed4 frag (v2f i) : SV_Target
			{
			    // Compute projective scaling factor...
			    float perspectiveDivide = 1.0f / i.screenPosition.w;

			    // Scale our view ray to unit depth.
			    float3 direction = i.modelDirection * perspectiveDivide;

			    			    // Calculate our UV within the screen (for reading depth buffer)
			    float2 screenUV = (i.screenPosition.xy * perspectiveDivide);// * 0.5f + 0.5f;

			    // Read depth, linearizing into worldspace units.    
			    float obstacleDepth = LinearEyeDepth(UNITY_SAMPLE_DEPTH(tex2D(_CameraDepthTexture, screenUV)));

			   	float2 minmax = intersect(i.modelSpaceCameraPos,1.0/direction,int3(direction.x<0?1:0, direction.y<0?1:0, direction.z<0?1:0));

			    float backDepth = minmax.y;
			   	float frontDepth = minmax.x;
			   	if(minmax.x < _ProjectionParams.y)
			    	frontDepth = _ProjectionParams.y;
			   	if(obstacleDepth < frontDepth)
			   		discard;
			   	if(obstacleDepth < backDepth)
			   		backDepth = obstacleDepth;

			   	//return float4(abs(backDepth-frontDepth),0,0 ,1);
			   	float3 backCoord = direction * backDepth + i.modelSpaceCameraPos;
			   	float3 frontCoord = direction * frontDepth + i.modelSpaceCameraPos;
			   	backCoord = backCoord+0.5;
			   	frontCoord = frontCoord+0.5;
			   	//return float4(frontDepth/15,0,0,1);


				float3 dir = normalize(direction);

                float sum = 0;
                float3 uvw = float3(0,0,0);

                float stepLength = 0.5;
                int stepCount = 100;
                float3 dist = backCoord - frontCoord;
                float len = length(dist);

                float fract = len/stepLength;
                float m = 0;
                float4 dst = 0;
                fixed4 col = float4(0,0,0,1);
                //return col;
                float percent = 0;
                float3 p;
                for (float progress = 0; progress < stepCount; progress += 1) {
                	percent = progress/stepCount;
                	p = frontCoord + percent * dist;
                	
                	uvw = p;

                	float3 dimensionScale = _VolumeDimensions.xyz/128.0;
                	float3 transformeduvw = uvw.xyz*dimensionScale;
                	if(uvw.x < _XSlice || uvw.z < _ZSlice)
                		continue;
                	float4 V = tex3D(_VolumeTexture,transformeduvw);
                	float a = V.w;

                	if ( a < 0.001)
                		continue;
    

                	float4 src = 0;
                		        	        


	        		float4 T = tex2D(_TransferColor,a);
					float A = tex2D(_TransferAlpha,a).r;

	        		float3 gradient = (V.xyz-0.5)*2;

	        		float3 norm = normalize(gradient);

	        		float lightAmount = clamp(0.4+clamp(dot(norm,_WorldSpaceLightPos0),0,1),0,1);

	        		float alpha = A;
	        		float3 c = T.xyz;
	        		src.a = clamp(alpha,0,1);
	        		src.rgb = clamp(c*lightAmount*src.a,0,1);
	        		dst = (1.0f - dst.a) * src + dst;
	        		if (dst.a > 1)
	        			break;

                }

                col.a = clamp(dst.a,0,1);

                col.rgb = dst.rgb/dst.a;
                col.rgb = clamp(col.rgb,0,1);

				//return float4(frontCoord,1);
				return float4(col);
			}
			ENDCG
		}
	}
}
