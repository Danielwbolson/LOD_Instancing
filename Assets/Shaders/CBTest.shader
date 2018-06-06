Shader "Custom/CBTest" {
    Properties{
        _MainTex("Albedo (RGB)", 2D) = "white" {}
    _Glossiness("Smoothness", Range(0,1)) = 0.5
        _Metallic("Metallic", Range(0,1)) = 0.0
    }
        SubShader{
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
        float4 position;
        float4 color;
        float4 scale;
    };

#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
    StructuredBuffer<ObjInfo> dataBuffer;
    StructuredBuffer<float4x4> matrixBuffer;
    StructuredBuffer<float4x4> inverseMatrixBuffer;
#else
    float4 color;
#endif

    void setup() {
#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
        //float4 pos = dataBuffer[unity_InstanceID].position;
        //unity_ObjectToWorld._11_21_31_41 = float4(pos.w, 0, 0, 0) *
        //    dataBuffer[unity_InstanceID].scale[0];
        //unity_ObjectToWorld._12_22_32_42 = float4(0, pos.w, 0, 0) *
        //    dataBuffer[unity_InstanceID].scale[1];
        //unity_ObjectToWorld._13_23_33_43 = float4(0, 0, pos.w, 0) *
        //    dataBuffer[unity_InstanceID].scale[2];

        //unity_ObjectToWorld._14_24_34_44 = float4(pos.xyz, 1);
        //// unity_ObjectToWorld = mul(modelMatrix, unity_ObjectToWorld);

        //unity_WorldToObject = unity_ObjectToWorld;
        //unity_WorldToObject._14_24_34 *= -1;
        //unity_WorldToObject._11_22_33 = 1.0f / unity_WorldToObject._11_22_33;
        unity_ObjectToWorld = matrixBuffer[unity_InstanceID];
        unity_WorldToObject = inverseMatrixBuffer[unity_InstanceID];
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
