Shader "Custom/DataSliceShader" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
		_ArrayID("Which Array to use?", Range(0,6)) = 0

	}
	SubShader {
        Tags { "RenderType"="Opaque" }    
		//Tags { "Queue"="Transparent" "RenderType"="Transparent" }
		LOD 200
        //Blend SrcAlpha OneMinusSrcAlpha
        //ZWrite Off
		CGPROGRAM
// Upgrade NOTE: excluded shader from DX11, OpenGL ES 2.0 because it uses unsized arrays
#pragma exclude_renderers d3d11 gles
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows //alpha

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0
        float _DataMin[1000];
        float _DataMax[1000];
        sampler3D _DataVolume0;
		sampler3D _DataVolume1;
		sampler3D _DataVolume2;
		sampler3D _DataVolume3;
		sampler3D _DataVolume4;
		sampler3D _DataVolume5;
		sampler3D _DataVolume6;
		int _ArrayID;
        float4x4 _DataModelMatrix;
        float4x4 _DataModelMatrixInv;
        float4x4 _DataBoundsMatrix;
        float4x4 _DataBoundsMatrixInv;
		float3 _DataImageDimensions;

		sampler2D _MainTex;
        
		struct Input {
			float2 uv_MainTex;
            float3 worldPos;

		};

		half _Glossiness;
		half _Metallic;
		fixed4 _Color;

        float map(float s, float a1, float a2, float b1, float b2)
        {
            return b1 + (s-a1)*(b2-b1)/(a2-a1);
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
            float4 modelSpace = mul(mul(_DataBoundsMatrixInv,_DataModelMatrixInv),worldSpace);
            float3 textureSpace = (modelSpace.xyz+0.5);
			float val = 0;

			int arrayId = _ArrayID;
			if(arrayId == 0) {
				val = tex3D (_DataVolume0, textureSpace);
			} else if(arrayId == 1) {
				val = tex3D (_DataVolume1, textureSpace);
			} else if(arrayId == 2) {
				val = tex3D (_DataVolume2, textureSpace);
			} else if(arrayId == 3) {
				val = tex3D (_DataVolume3, textureSpace);
			} else if(arrayId == 4) {
				val = tex3D (_DataVolume4, textureSpace);
			} else if(arrayId == 5) {
				val = tex3D (_DataVolume5, textureSpace);
			} else if(arrayId == 6) {
				val = tex3D (_DataVolume6, textureSpace);
			}
			

            val = map(val, _DataMin[arrayId], _DataMax[arrayId],0,1);
            fixed4 c = float4(1,1,1,1)*tex2D(_MainTex,float2(val,0.5));
			//c = float4(1,1,1,1)*val;
            c.a = 1;
            //c.rgb = (textureSpace.xyz);
            if(textureSpace.r > 1 || textureSpace.r < 0  || textureSpace.g >1 || textureSpace.g < 0 || textureSpace.b > 1 || textureSpace.b < 0) 
                discard;
			o.Albedo = float3(c.x,c.y,c.z);
			// Metallic and smoothness come from slider variables
			o.Metallic = _Metallic;
			o.Smoothness = _Glossiness;

			o.Alpha = c.a;
            if (val > 1 || val <= 0 ) discard;

		}
		ENDCG
	}
	FallBack "Diffuse"
}
