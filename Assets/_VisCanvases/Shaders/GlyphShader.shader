Shader "Custom/GlyphShader" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
	}
	SubShader {
		Tags { "RenderType"="TransparentCutout" }
		LOD 200

		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows vertex:vert
		#pragma multi_compile_instancing
		#pragma instancing_options procedural:setup 
		#include "CanvasSupport.cginc"
		#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED

		#include "VariableSupport.cginc"

		#endif

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 4.0

		sampler2D _MainTex;

		struct Input {
			float2 uv_MainTex;
			float3 worldPos;
			float4 screenPos;
			float2 indices;
		};

		half _Glossiness;
		half _Metallic;
		fixed4 _Color;

		float _glyphScale = 1;
		sampler2D _ColorMap;
		// Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
		// See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
		// #pragma instancing_options assumeuniformscaling
		UNITY_INSTANCING_BUFFER_START(Props)
			// put more per-instance properties here
		UNITY_INSTANCING_BUFFER_END(Props)

		void setup () {

		}
		void vert(inout appdata_full v, out Input o) {

	        UNITY_INITIALIZE_OUTPUT(Input,o);
		#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED

		int pointIndex =_AnchorTopology[unity_InstanceID].y;
		int cellIndex =  _AnchorTopology[unity_InstanceID].x;
			v.vertex.xyz *= _glyphScale;

			if(_VariableAssigned_Anchor) {
				//float3 B = 
				if(VariableIsAssigned(2)){
					float3 T = normalize(GetData(2,cellIndex,pointIndex,float3(0,0,0)));
					float3 temp = normalize(cross(T,float3(1,0,0)));
					float3 N = cross(T,temp);
					float3 B = cross(T,N);
					float3x3 transform;
					transform[0] = -B;
					transform[1] = T;
					transform[2] = N;
					transform = transpose(transform);


					v.vertex.xyz = mul(transform, v.vertex.xyz);
					v.normal.xyz = mul(transform,v.normal.xyz);
				}

				v.vertex.xyz  += GetAnchorPosition(unity_InstanceID);
				v.vertex = mul(_CanvasInnerScene,v.vertex);
				v.normal = mul(_CanvasInnerScene,v.normal);
				o.indices = float2(cellIndex, pointIndex);

			}	
		#endif
		}


		void surf (Input IN, inout SurfaceOutputStandard o) {






			fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;


		#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED


			int pointIndex = floor(IN.indices.y +0.5);
			int cellIndex = floor(IN.indices.x + 0.5);

			float3 dataSpace = WorldToDataSpace(IN.worldPos);
			float3 dataVal = GetData(1,cellIndex,pointIndex,dataSpace);
			float3 normalizedDataVal = NormalizeData(1,dataVal);

			fixed4 col = tex2D(_ColorMap,float2(normalizedDataVal.x,0.5));
			c = col;

			float3 opacityVal = NormalizeData(3,GetData(3,cellIndex,pointIndex,dataSpace));
			if(VariableIsAssigned(3)) {
			
				StippleTransparency(IN.screenPos,_ScreenParams,opacityVal.x);

			}

		#endif



			// Albedo comes from a texture tinted by color
			o.Albedo = c.rgb;
			// Metallic and smoothness come from slider variables
			o.Metallic = _Metallic;
			o.Smoothness = _Glossiness;
			o.Alpha = c.a;


			o.Albedo = MarkBounds(IN.worldPos,c);
			//StippleCrop(IN.worldPos,IN.screenPos,_ScreenParams);

		}
		ENDCG
	}
	FallBack "Diffuse"
}
