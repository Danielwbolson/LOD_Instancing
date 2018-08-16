Shader "Custom/BumpShader" {
    Properties{
        _Color("Color", Color) = (1,1,1,1)
        _MainTex("Albedo (RGB)", 2D) = "white" {}
        _BumpMap("Normal Map", 2D) = "bump" {}
        _Glossiness("Smoothness", Range(0,1)) = 0.5
        _Metallic("Metallic", Range(0,1)) = 0.0

        _Slider("Slider",Range(0,1)) = 0.5
        _normalVec("Plane Normal", Vector) = (2, 0, 0)
    }
        SubShader{
               Tags { "RenderType" = "TransparentCutout" }
               LOD 200
               Cull Off
               CGPROGRAM
            // Physically based Standard lighting model, and enable shadows on all light types
            #pragma surface surf Standard fullforwardshadows vertex:vert addshadow
            #pragma multi_compile_instancing

            // Use shader model 3.0 target, to get nicer looking lighting
            #pragma target 3.0

#include "CanvasSupport.cginc"
#include "VariableSupport.cginc"

            struct Plane {
                float3 _center;
                float3 _normal;
            };

            sampler2D _MainTex;
            sampler2D _BumpMap;

            struct Input {
                float2 uv_MainTex;
                float2 uv_BumpMap;
                float3 worldPos;
            };

            half _Glossiness;
            half _Metallic;
            fixed4 _Color;
            float _Slider;
            int _TransformVertices;
            int _TransformTangents;
            int _TransformNormals;
            float4x4 _GlyphTransform;
            float4x4 _GlyphTransformInverse;

        #if defined(SHADER_API_D3D11) || defined(SHADER_API_METAL)
            StructuredBuffer<Plane> _Planes;
            int planesSize;
        #endif

            void vert(inout appdata_full v, out Input o) {

                UNITY_INITIALIZE_OUTPUT(Input,o);

                #ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED

                #endif

                if (_TransformVertices)
                    v.vertex.xyz = mul(_GlyphTransform,float4(v.vertex.xyz,1));

                if (_TransformNormals)
                    v.normal.xyz = mul(transpose(_GlyphTransformInverse),float4(v.normal.xyz,0));
                if (_TransformTangents)
                    v.tangent.xyz = mul(transpose(_GlyphTransformInverse),float4(v.tangent.xyz,0));

            }

            void surf(Input IN, inout SurfaceOutputStandard o) {

            #if defined(SHADER_API_D3D11) || defined(SHADER_API_METAL)
                    for (int i = 0; i < planesSize; i++) {
                        float3 dataNorm = _Planes[i]._normal;
                        float3 A_dataPos = _Planes[i]._center;
                        float3 B_vertPos = WorldToDataSpace(IN.worldPos);

                        float3 AB = B_vertPos - A_dataPos;
                        bool inFront = (dot(AB, dataNorm) > 0);

                        if (inFront) {
                            discard;
                        }
                    }
            #endif

                    // Albedo comes from a texture tinted by color
                    fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;

                    // Converting to Normal map image
                    float4 map1 = tex2D(_BumpMap, IN.uv_BumpMap);
                    map1.a = sqrt(map1.r) * 2 - 1;
                    map1.a = map1.a * 0.5 + 0.54;
                    map1.g = sqrt(map1.g) * 2 - 1;
                    map1.g = map1.g * 0.5 + 0.54;
                    map1.b = map1.g;
                    map1.r = 1;

                    // The texture with the bump map applied has:
                    // g = b
                    // r = 1
                    // a is not just opacity
                    //float4 map2 = tex2D(_BumpMap, IN.uv_BumpMap);

                    //float3 bump = UnpackNormal(map2);

                    //o.Albedo = _Color.rgb;
                    //if (IN.uv_MainTex.x < _Slider) {
                    //    o.Normal = tex;
                    //}
                    //else {
                    //    o.Normal = bump;
                    //}'

                    o.Normal = UnpackNormal(map1);

                    //clip(-dataSpace.x);
                    //clip(-(abs(dataSpace.x) - 0.1));

                    o.Albedo.rgb = c.rgb;
                    //o.Albedo.rgb = float3(1, 0, 0);
                    o.Metallic = _Metallic;
                    o.Smoothness = _Glossiness;
                    o.Alpha = _Color.a;
            }
            ENDCG
        }
        FallBack "Diffuse"
}
