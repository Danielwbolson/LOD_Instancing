Shader "Custom/DemoShader" {
    Properties{
        _MainTex("Albedo (RGB)", 2D) = "white" {}
        _Glossiness("Smoothness", Range(0,1)) = 0.5
        _Metallic("Metallic", Range(0,1)) = 0.0
    }
    SubShader {
        Tags{ "RenderType" = "Opaque" }
        LOD 600

        Cull Back

        CGPROGRAM
        // Physically based Standard lighting model
#pragma surface surf Standard addshadow fullforwardshadows
#pragma multi_compile_instancing LOD0 LOD1 LOD2 LOD3
#pragma instancing_options procedural:setup

        sampler2D _MainTex;

        struct Input {
            float2 uv_MainTex;
        };

        struct ObjInfo {
            float4 position;
            float4 color;
            float4 scale;
        };

#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
        StructuredBuffer<ObjInfo> LOD0Buffer;
        StructuredBuffer<ObjInfo> LOD1Buffer;
        StructuredBuffer<ObjInfo> LOD2Buffer;
        StructuredBuffer<ObjInfo> LOD3Buffer;
#else
        float4 color;
#endif

        // Emitter matrix
        float4x4 modelMatrix;
        float4 pos;

        void setup() {
#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
# ifdef LOD0
            pos = LOD0Buffer[unity_InstnceID].position;
            unity_ObjectToWorld._11_21_31_41 = float4(pos.w, 0, 0, 0) *
                LOD0Buffer[unity_InstanceID].scale[0];
            unity_ObjectToWorld._12_22_32_42 = float4(0, pos.w, 0, 0) *
                LOD0Buffer[unity_InstanceID].scale[1];
            unity_ObjectToWorld._13_23_33_43 = float4(0, 0, pos.w, 0) *
                LOD0Buffer[unity_InstanceID].scale[2];
# endif
# ifdef LOD1
            pos = LOD1Buffer[unity_InstnceID].position;
            unity_ObjectToWorld._11_21_31_41 = float4(pos.w, 0, 0, 0) *
                LOD1Buffer[unity_InstanceID].scale[0];
            unity_ObjectToWorld._12_22_32_42 = float4(0, pos.w, 0, 0) *
                LOD1Buffer[unity_InstanceID].scale[1];
            unity_ObjectToWorld._13_23_33_43 = float4(0, 0, pos.w, 0) *
                LOD1Buffer[unity_InstanceID].scale[2];
# endif
# ifdef LOD2
            pos = LOD2Buffer[unity_InstnceID].position;
            unity_ObjectToWorld._11_21_31_41 = float4(pos.w, 0, 0, 0) *
                LOD2Buffer[unity_InstanceID].scale[0];
            unity_ObjectToWorld._12_22_32_42 = float4(0, pos.w, 0, 0) *
                LOD2Buffer[unity_InstanceID].scale[1];
            unity_ObjectToWorld._13_23_33_43 = float4(0, 0, pos.w, 0) *
                LOD2Buffer[unity_InstanceID].scale[2];
# endif
# ifdef LOD3
            pos = LOD3Buffer[unity_InstnceID].position;
            unity_ObjectToWorld._11_21_31_41 = float4(pos.w, 0, 0, 0) *
                LOD3Buffer[unity_InstanceID].scale[0];
            unity_ObjectToWorld._12_22_32_42 = float4(0, pos.w, 0, 0) *
                LOD3Buffer[unity_InstanceID].scale[1];
            unity_ObjectToWorld._13_23_33_43 = float4(0, 0, pos.w, 0) *
                LOD3Buffer[unity_InstanceID].scale[2];
# endif

            unity_ObjectToWorld._14_24_34_44 = float4(pos.xyz, 1);
            unity_ObjectToWorld = mul(modelMatrix, unity_ObjectToWorld);

            unity_WorldToObject = unity_ObjectToWorld;
            unity_WorldToObject._14_24_34 *= -1;
            unity_WorldToObject._11_22_33 = 1.0f / unity_WorldToObject._11_22_33;
#endif
        }

        half _Glossiness;
        half _Metallic;

        void surf(Input IN, inout SurfaceOutputStandard o) {
#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
            float4 col = dataBuffer[unity_InstanceID].color;
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * col;
#else
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * color;
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
