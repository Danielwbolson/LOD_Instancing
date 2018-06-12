﻿Shader "Custom/DemoShader" {
    Properties{
        _MainTex("Albedo (RGB)", 2D) = "white" {}
        _Glossiness("Smoothness", Range(0,1)) = 0.5
        _Metallic("Metallic", Range(0,1)) = 0.0
    }
    SubShader {
        Tags{ "RenderType" = "Opaque" }
        LOD 200

        Cull Back

        CGPROGRAM
        // Physically based Standard lighting model
#pragma surface surf Standard addshadow fullforwardshadows
#pragma multi_compile_instancing
#pragma instancing_options procedural:setup

        sampler2D _MainTex;

        struct Input {
            float2 uv_MainTex;
        };

        struct ObjInfo {
            int meshIndex;
            int LODIndex;
            int matrixIndex;
            float4 position;
            float4 color;
            float scale;
            float3 direction;
        };

#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
        StructuredBuffer<ObjInfo> dataBuffer;
        StructuredBuffer<float4x4> matrixBuffer;
        float DummyForShadows;
#else
        float4 color;
#endif

        void setup() {
#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
            unity_ObjectToWorld = matrixBuffer[dataBuffer[unity_InstanceID].matrixIndex];

            /*unity_ObjectToWorld = float4x4(
                1, 0, 0, 0, //50 * dataBuffer[unity_InstanceID].matrixIndex,
                0, 1, 0, 0, //50 * dataBuffer[unity_InstanceID].LODIndex,
                0, 0, 1, 0, //50 * dataBuffer[unity_InstanceID].meshIndex,
                0, 0, 0, 1);*/
#endif
        }

        half _Glossiness;
        half _Metallic;
        fixed4 c;

        void surf(Input IN, inout SurfaceOutputStandard o) {
#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
            float4 col = dataBuffer[unity_InstanceID].color;
            c = tex2D(_MainTex, IN.uv_MainTex) * col;
#else
            c = tex2D(_MainTex, IN.uv_MainTex) * color;
#endif
            o.Albedo = c.rgb;
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
