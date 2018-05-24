﻿Shader "Custom/DataSliceShader" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
        _DataMin("Min Value",Range(-20,20)) = 0.0
        _DataMax("Max Value",Range(-20,20)) = 1.0

	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
        Cull Off
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows vertex:vert

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0
        float _DataMin;
        float _DataMax;
        sampler3D _DataVolume;
        sampler3D _DataVolume2;

        float4x4 _ModelMatrix;
        float4x4 _ModelMatrixInv;
		sampler2D _MainTex;
        
        float3 _Dimensions;
		struct Input {
			float2 uv_MainTex;
            float3 worldPos;
            float3 dataPos;

		};

		half _Glossiness;
		half _Metallic;
		fixed4 _Color;

        float map(float s, float a1, float a2, float b1, float b2)
        {
            return b1 + (s-a1)*(b2-b1)/(a2-a1);
        }

        void vert (inout appdata_full v,out Input o) {
                UNITY_INITIALIZE_OUTPUT(Input,o);

            float4 worldSpace = mul(unity_ObjectToWorld,float4(0,0,0,1));
            float4 modelSpace = mul(_ModelMatrixInv,worldSpace);
            float3 textureSpace = (modelSpace.xyz+0.5);
            o.dataPos = textureSpace;
            float3 direction = tex3Dlod (_DataVolume, float4(textureSpace,0)).rgb;

            float3 i = float3(1,0,0);
            float3 j = float3(0,1,0);
            float3 k = float3(0,0,1);

            float3 B =normalize(cross(direction,j));

            float3x3 transform;
            transform[0] = B;
            transform[1] = direction;
            transform[2] = cross(direction,B);
            transform = transpose(transform);
            v.vertex.xyz = mul(transform,v.vertex.xyz);
            v.normal.xyz = mul(transform,v.normal.xyz);

         }

		// Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
		// See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
		// #pragma instancing_options assumeuniformscaling
		UNITY_INSTANCING_BUFFER_START(Props)
			// put more per-instance properties here
		UNITY_INSTANCING_BUFFER_END(Props)

		void surf (Input IN, inout SurfaceOutputStandard o) {
			// Albedo comes from a texture tinted by color
            float4 worldSpace = float4(IN.worldPos,1);
            float4 modelSpace = mul(_ModelMatrixInv,worldSpace);
            float3 textureSpace = (modelSpace.xyz+0.5);
			float val = tex3D (_DataVolume, textureSpace);
            val = map(val, _DataMin, _DataMax,0,1);
            if (val > 1 || val < 0 ) discard;
            fixed4 c = float4(1,1,1,1)*tex2D(_MainTex,float2(val,0.5));
            c.a = 1;
            //c.rgb = (textureSpace.xyz);
            if(textureSpace.r > 1 || textureSpace.r < 0  || textureSpace.g >1 || textureSpace.g < 0 || textureSpace.b > 1 || textureSpace.b < 0) 
                discard;
			o.Albedo = float3(c.x,c.y,c.z);
			// Metallic and smoothness come from slider variables
			o.Metallic = _Metallic;
			o.Smoothness = _Glossiness;
			o.Alpha = c.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
