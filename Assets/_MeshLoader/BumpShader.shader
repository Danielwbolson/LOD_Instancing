Shader "Custom/BumpShader" {
    Properties {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _BumpMap("Normal Map", 2D) = "bump" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0

        _Slider("Slider",Range(0,1)) = 0.5
    }
    SubShader {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;
        sampler2D _BumpMap;

        struct Input {
            float2 uv_MainTex;
            float2 uv_BumpMap;
        };

        half _Glossiness;
        half _Metallic;
        fixed4 _Color;
        float _Slider;


        float map(float value, float min1, float max1, float min2, float max2)
        {
            // Convert the current value to a percentage
            // 0% - min1, 100% - max1
            float perc = (value - min1) / (max1 - min1);

            // Do the same operation backwards with min2 and max2
            return  perc * (max2 - min2) + min2;
        }


        void surf (Input IN, inout SurfaceOutputStandard o) {
            // Albedo comes from a texture tinted by color
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;

            float4 map1 = tex2D(_MainTex, IN.uv_MainTex);
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
            float4 map2 = tex2D(_BumpMap, IN.uv_BumpMap);

            float3 tex = UnpackNormal(map1);
            float3 bump = UnpackNormal(map2);

            o.Albedo = _Color.rgb;
            float3 oldNormal = o.Normal;
            if (IN.uv_MainTex.x < _Slider) {
                o.Normal = tex;
            }
            else {
                o.Normal = bump;
            }
            //o.Normal = float3(0, 0, 1);

           // o.Normal = normalize(o.Normal);

            // Metallic and smoothness come from slider variables
            //o.Albedo = (o.Normal.rgb); // length(o.Normal) < 0.95 ? 1 : 0;
            //o.Normal = oldNormal;
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = _Color.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
