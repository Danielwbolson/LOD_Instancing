Shader "Unlit/VolumeShader"
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
			Cull Front
			ZTest Always
						Blend SrcAlpha OneMinusSrcAlpha

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog
			
			#include "UnityCG.cginc"
			#include "CanvasSupport.cginc"
			#include "VariableSupport.cginc"

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
			float _OpacityMultiplier;



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



    

			
			sampler2D _ColorMap;

			sampler2D _OpacityMap;


			v2f vert (appdata v)
			{
			  v2f o;

			    // Subtract camera position from vertex position in world
			    // to get a ray pointing from the camera to this vertex.
			    o.modelSpaceCameraPos = mul(unity_WorldToObject,float4(_WorldSpaceCameraPos,1)).xyz;
				//o.modelSpaceCameraPos = WorldToDataSpace(_WorldSpaceCameraPos);

			    o.modelDirection = v.vertex.xyz - o.modelSpaceCameraPos;
				//o.modelDirection =  WorldToDataSpace(mul(unity_ObjectToWorld,float4(v.vertex.xyz,1))) - o.modelSpaceCameraPos;
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


    			float3 bounds[2] = {{-0.5,-0.5,-0.5},{0.5,0.5,0.5}};
				//bounds[0] = GetVariableBoundsMin(1);
				//bounds[1] = GetVariableBoundsMax(1);

			   	float2 minmax = intersect(i.modelSpaceCameraPos,1.0/direction,int3(direction.x<0?1:0, direction.y<0?1:0, direction.z<0?1:0),bounds);

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
                fixed4 col = float4(0,1,0,1);
				col.rgb = len;

                //return col;
                float percent = 0;
				float traveled = 0;
				for (float progress = 0; progress < stepCount; progress += 1) {
					// test.xyz = backCoord;
				traveled = progress  * 0.01f;

					//percent = progress/stepCount;
                	uvw = frontCoord + traveled * normalize(dist);
                	float4 V = tex3D(_DataVolume0,uvw);
					V.rgb = NormalizeData(1,GetVariable3DTextureSample(1,uvw));
					float a = V.x;//map(V.x, _DataMin0.x, _DataMax0.x,0,1);

                	if (traveled > len ||  a < 0.001 || (uvw.x < 0 || uvw.x > 1 || uvw.y < 0 || uvw.y > 1 || uvw.z < 0 || uvw.z > 1) )
                		continue;

					float4 T = tex2D(_ColorMap,float2(a,0.5));
					float A = tex2D(_OpacityMap,a).r*_OpacityMultiplier;

					float4 src = 0;
	        		float alpha = A;

						float3 c = T.xyz;
     					src.a = clamp(alpha,0,1);
	        			src.rgb = clamp(c*src.a,0,1);
	        			dst = (1.0f - dst.a) * src + dst;
					

	   

					
					

	        		// if (dst.a > 1)
	        		// 	break;

				}
     			col.a = clamp(dst.a,0,1);

                col.rgb = dst.rgb/dst.a;
                col.rgb = clamp(col.rgb,0,1);
				//return float4(TextureToDataSpace(1,frontCoord),1);
				return float4(col);
				
			}
			ENDCG
		}
	}
}
