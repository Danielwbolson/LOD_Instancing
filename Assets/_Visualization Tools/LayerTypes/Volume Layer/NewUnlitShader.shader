Shader "Unlit/VolumeDataRenderer"
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

			sampler2D _MainTex;
			float4 _MainTex_ST;
			
			sampler2D _CameraDepthTexture;
			sampler3D _VolumeTexture;
			sampler2D _TransferColor;
			sampler2D _TransferAlpha;
			float4 _VolumeDimensions;
			float _XSlice;
			float _ZSlice;



///////////////////////////////////////////////////
// DATA RENDERER BOILER PLATE


		float3 _DataImageDimensions;
		
        float4 _DataMin0;
		float4 _DataMin1;

        float4 _DataMax0;
        float4 _DataMax1;


        int _VariableType0;
        int _VariableType1;

		

// DATA VOLUMES
		sampler3D _DataVolume0;
		sampler3D _DataVolume1;

// DATA BUFFERS

	#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
		StructuredBuffer<float4> _DataBuffer0;
		StructuredBuffer<float4> _DataBuffer1;
	#else
		float4 _DataBuffer0[1];
		float4 _DataBuffer1[1];
	#endif



	#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
		StructuredBuffer<int> _DataIndexBuffer0;
		StructuredBuffer<int> _DataIndexBuffer1;
	#else
		int _DataIndexBuffer0[1];
		int _DataIndexBuffer1[1];
	#endif



        float4x4 _DataModelMatrix;
        float4x4 _DataModelMatrixInv;
        float4x4 _DataBoundsMatrix;
        float4x4 _DataBoundsMatrixInv;
		
// END BOILER PLATE
///////////////////////////////////////////////////



        float map(float s, float a1, float a2, float b1, float b2)
        {
            return b1 + (s-a1)*(b2-b1)/(a2-a1);
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

				float3 dir = normalize(direction);

                float3 uvw = float3(0,0,0);

                int stepCount = 100;
                float3 dist = backCoord - frontCoord;
                float len = length(dist);

				float4 test = float4(0,0,0,1);
                float4 dst = 0;
                fixed4 col = float4(0,0,0,1);
                //return col;
                float percent = 0;

				for (float progress = 0; progress < stepCount; progress += 1) {
					test.xyz = backCoord;

					percent = progress/stepCount;
                	uvw = frontCoord + percent * dist;
                	float4 V = tex3D(_DataVolume0,uvw);
					test.rgb = V.rgb;
					float a = map(V.x, _DataMin0.x, _DataMax0.x,0,1);

                	if ( a < 0.001)
                		continue;

					float4 T = tex2D(_TransferColor,a);
					float A = tex2D(_TransferAlpha,a).r;

					float4 src = 0;
	        		float alpha = A;

						float3 c = T.xyz;
	        		src.a = clamp(alpha,0,1);
	        		src.rgb = clamp(c*src.a,0,1);
	        		dst = (1.0f - dst.a) * src + dst;


					test = dst;
					

	        		// if (dst.a > 1)
	        		// 	break;

				}
     			col.a = clamp(dst.a,0,1);

                col.rgb = dst.rgb/dst.a;
                col.rgb = clamp(col.rgb,0,1);

				return float4(col);
				
			}
			ENDCG
		}
	}
}
