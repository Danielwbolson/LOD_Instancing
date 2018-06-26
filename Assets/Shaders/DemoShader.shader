Shader "Custom/DemoShader" {
    Properties{
        _MainTex("Albedo (RGB)", 2D) = "white" {}
        _BumpMap("Bumpmap", 2D) = "bump" {}
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
        sampler2D _BumpMap;

        struct Input {
            float2 uv_MainTex;
            float2 uv_BumpMap;
        };

        struct ObjInfo {
            int meshIndex;
            int LODIndex;
            int matrixIndex;
            float4 position;
            float4 color;
            float3 scale;
            float3 direction;
        };

#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
        StructuredBuffer<ObjInfo> dataBuffer;
        StructuredBuffer<float4x4> matrixBuffer;
        float DummyForShadows;
#endif

        void setup() {
#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
            // Set the instance position to the stored positiosn in the matrix buffer
            // using the datas saved matrix position
            unity_ObjectToWorld = matrixBuffer[dataBuffer[unity_InstanceID].matrixIndex];
#endif
        }

        half _Glossiness;
        half _Metallic;
        fixed4 c;

        float4 color;
        int debug;
        int lodIndex;

        void surf(Input IN, inout SurfaceOutputStandard o) {
#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
            lodIndex = dataBuffer[unity_InstanceID].LODIndex;

            if (debug == 1) {
                if (lodIndex == 0)
                    color = float4(1, 0, 0, 1);
                else if (lodIndex == 1)
                    color = float4(0, 1, 0, 1);
                else if (lodIndex == 2)
                    color = float4(0, 0, 1, 1);
                else if (lodIndex == 3)
                    color = float4(0, 0, 0, 1);
                c = tex2D(_MainTex, IN.uv_MainTex) * color;
            }
            else {
                c = tex2D(_MainTex, IN.uv_MainTex);
            }
#else
            if (debug == 1) {
                c = tex2D(_MainTex, IN.uv_MainTex) * color;
            }
            else {
                c = tex2D(_MainTex, IN.uv_MainTex);
            }
#endif
            o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));

            o.Albedo = c.rgb;
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
