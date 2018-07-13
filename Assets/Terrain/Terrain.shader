Shader "Custom/Terrain" {
    Properties {
        _ColorMap ("Color Map", 2D) = "color" {}
        _HeightMap ("Height Map", 2D) = "height" {}
    }
    SubShader {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _ColorMap;
        sampler2D _HeightMap;

        struct Input {
            float2 uv_HeightMap; 
        };

        void surf (Input IN, inout SurfaceOutputStandard o) {
            // Albedo comes from a texture tinted by color
            float2 uv = IN.uv_HeightMap;
            float2 flip_uv = float2(uv.x, 1 - uv.y);

            fixed4 height = tex2D(_HeightMap, flip_uv); // height.xyzw
            height *= 4.0;
            float h = height.r;
            
            if (h <= 0) { h = 0.001; }
            if (h >= 1) { h = 0.999; }

            fixed4 c = tex2D(_ColorMap, float2(0, h));

            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
