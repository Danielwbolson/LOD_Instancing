﻿Shader "Custom/GlyphShader" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_BumpMap ("Albedo (RGB)", 2D) = "bump" {}

		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
	}
	SubShader {
		Tags { "RenderType"="TransparentCutout"}
		LOD 200
		Cull Off
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows vertex:vert addshadow
		#pragma multi_compile_instancing
		#pragma instancing_options procedural:setup 
		#include "UnityCG.cginc"
		#include "CanvasSupport.cginc"
	
		#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
		#include "VariableSupport.cginc"


		#endif

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 4.0

		sampler2D _MainTex;
		sampler2D _AlphaTex;

		sampler2D _BumpMap;

		struct Input {
			float2 uv_MainTex;
			float3 worldPos;
			float4 screenPos;
			float2 indices;
		};

		half _Glossiness;
		half _Metallic;
		fixed4 _Color;
		int _useMesh;
		int _useThumbnail;
		int _faceCamera = 1;

		float _glyphScale = 1;
		float _OpacityMultiplier;
		float _opacityThreshold;
		sampler2D _ColorMap;
		// Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
		// See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
		// #pragma instancing_options assumeuniformscaling
		UNITY_INSTANCING_BUFFER_START(Props)
			// put more per-instance properties here
		UNITY_INSTANCING_BUFFER_END(Props)


			float4x4 inverse(float4x4 input)
		{
#define minor(a,b,c) determinant(float3x3(input.a, input.b, input.c))
			//determinant(float3x3(input._22_23_23, input._32_33_34, input._42_43_44))

			float4x4 cofactors = float4x4(
				minor(_22_23_24, _32_33_34, _42_43_44),
				-minor(_21_23_24, _31_33_34, _41_43_44),
				minor(_21_22_24, _31_32_34, _41_42_44),
				-minor(_21_22_23, _31_32_33, _41_42_43),

				-minor(_12_13_14, _32_33_34, _42_43_44),
				minor(_11_13_14, _31_33_34, _41_43_44),
				-minor(_11_12_14, _31_32_34, _41_42_44),
				minor(_11_12_13, _31_32_33, _41_42_43),

				minor(_12_13_14, _22_23_24, _42_43_44),
				-minor(_11_13_14, _21_23_24, _41_43_44),
				minor(_11_12_14, _21_22_24, _41_42_44),
				-minor(_11_12_13, _21_22_23, _41_42_43),

				-minor(_12_13_14, _22_23_24, _32_33_34),
				minor(_11_13_14, _21_23_24, _31_33_34),
				-minor(_11_12_14, _21_22_24, _31_32_34),
				minor(_11_12_13, _21_22_23, _31_32_33)
				);
#undef minor
			return transpose(cofactors) / determinant(input);
		}
		void setup () {

		}
		void vert(inout appdata_full v, out Input o) {

	        UNITY_INITIALIZE_OUTPUT(Input,o);
			
		#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED

		int pointIndex =unity_InstanceID;//_AnchorTopology[unity_InstanceID].y;
		int cellIndex =  _AnchorTopology[unity_InstanceID].x;

			v.vertex.xyz *= _glyphScale;

			if( VariableIsAssigned(0)) {
				//float3 B = 
				float3 tangent = float3(0,1,0);
				float3 normal = float3(0,0,1);

				if (_faceCamera) {
					tangent = UNITY_MATRIX_V[1];
					normal = UNITY_MATRIX_V[2]; //normalize(_WorldSpaceCameraPos- mul(_CanvasInnerScene, GetAnchorPosition(pointIndex)).xyz);
				}
				if( VariableIsAssigned(2)){
					tangent = normalize(GetData(2, cellIndex, pointIndex, GetAnchorPosition(pointIndex)));

					if (_faceCamera) {
						tangent.xyz = mul(_CanvasInnerScene, tangent.xyz);
						tangent = normalize(tangent);
					}
					float3 temp = normalize(cross(tangent, normal));
					normal= cross(tangent,-temp);
					
					
				}
				float4x4 transform = float4x4(1,0,0,0, 0,1,0,0, 0,0,1,0, 0,0,0,1);

				float3 bitangent = cross(tangent,-normal);
				transform[0].xyz = bitangent;
				transform[1].xyz = tangent;
				transform[2].xyz = normal;
				transform[3].w = 1;
				transform = transpose(transform);

				if (!_faceCamera) {
					v.vertex.xyz = mul(transform, v.vertex);
					v.normal = normalize(mul(transpose(inverse(transform)),v.normal));
					v.tangent = normalize(mul(transpose(inverse(transform)), v.tangent));
					v.vertex.xyz  += GetAnchorPosition(pointIndex);
					v.vertex.xyz = mul(_CanvasInnerScene, v.vertex);
					v.normal = normalize(mul(transpose(inverse(_CanvasInnerScene)), v.normal));
					v.tangent = normalize(mul(transpose(inverse(_CanvasInnerScene)), v.tangent));

				}
				else {

					v.vertex.xyz = mul(transform, v.vertex);
					v.normal = normalize(mul(transpose(inverse(transform)), v.normal));
					v.tangent = normalize(mul(transpose(inverse(transform)), v.tangent));

					v.vertex.xyz *= length(mul(_CanvasInnerScene, float4(0, 0, 0, 1)) - mul(_CanvasInnerScene, float4(1, 0, 0, 1)));

					v.vertex.xyz += mul(_CanvasInnerScene, float4(0,0,0,1)) + mul(_CanvasInnerScene, GetAnchorPosition(pointIndex));


				}
				 //v.vertex.xyz = mul(transform, v.vertex.xyz);
				 //v.normal.xyz = mul(transform,v.normal.xyz);

				// v.vertex.x *=0.2;


				//v.vertex.x += pointIndex;
				//v.vertex.xyz  += GetAnchorPosition(pointIndex);
				//v.vertex.x=0;
				//v.vertex.xyz +=  mul(_CanvasInnerScene, GetAnchorPosition(pointIndex));
				//v.normal = mul(_CanvasInnerScene,v.normal);
				//v.tangent = mul(_CanvasInnerScene, v.tangent);

				o.indices = float2(cellIndex, pointIndex);

			}	
		#endif
		}


		void surf (Input IN, inout SurfaceOutputStandard o) {


			// Converting to Normal map image
            float4 map1 = tex2D(_BumpMap, IN.uv_MainTex);
            map1.a = sqrt(map1.r) * 2 - 1;
            map1.a = map1.a * 0.5 + 0.54;
            map1.g = sqrt(map1.g) * 2 - 1;
            map1.g = map1.g * 0.5 + 0.54;
            map1.b = map1.g;
            map1.r = 1; 

			fixed4 c = fixed4(0,1,0,1);
			// Albedo comes from a texture tinted by color
			o.Normal = UnpackNormal(map1);

			o.Albedo = c.rgb;
			// Metallic and smoothness come from slider variables
			o.Metallic = _Metallic;
			o.Smoothness = _Glossiness;
			o.Alpha = c.a;

			c = _Color;
			//return;
			if(_useMesh==0){
				if(_useThumbnail ==1)
			 		c *= tex2D (_MainTex, IN.uv_MainTex);
				c.a = tex2D (_AlphaTex, IN.uv_MainTex);
			}

		#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED


			int pointIndex = floor(IN.indices.y +0.5);
			int cellIndex = floor(IN.indices.x + 0.5);

			float3 dataSpace = WorldToDataSpace(IN.worldPos);
			float3 dataVal = GetData(1,cellIndex,pointIndex,dataSpace);
			float3 normalizedDataVal = NormalizeData(1,dataVal);

			fixed4 col = tex2D(_ColorMap,float2(normalizedDataVal.x,0.5));
			c *= col;

			float3 opacityVal = NormalizeData(3,GetData(3,cellIndex,pointIndex,dataSpace));
			if(VariableIsAssigned(3)) {
			
				StippleTransparency(IN.screenPos,_ScreenParams,opacityVal.x > _opacityThreshold);

			}

		#endif



			// Albedo comes from a texture tinted by color
			o.Albedo = c.rgb;
			// Metallic and smoothness come from slider variables
			o.Metallic = _Metallic;
			o.Smoothness = _Glossiness;
			o.Alpha = c.a;


			o.Albedo = MarkBounds(IN.worldPos,c);
			StippleTransparency(IN.screenPos,_ScreenParams,o.Alpha*_OpacityMultiplier);
			//StippleCrop(IN.worldPos,IN.screenPos,_ScreenParams);

					#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED

			//o.Albedo.rgb = normalize(GetData(2, cellIndex, pointIndex, GetAnchorPosition(pointIndex)));
			#endif
		}
		ENDCG
	}
	FallBack "Diffuse"



	
}
