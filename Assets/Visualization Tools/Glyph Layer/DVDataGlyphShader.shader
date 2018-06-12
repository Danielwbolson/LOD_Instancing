Shader "Custom/DataSliceShader" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
		_ArrayID("Which Array to use?", Range(0,6)) = 0
		_UseDirection("Use Direction", Range(0,1)) = 1
		_DirectionArray("Array for Directions", Range(0,6)) = 1
		_UseMask("Use Mask", Range(0,1)) = 1
		_MaskArray("Array for Mask", Range(0,6)) = 0
		_UseColor("Use Color", Range(0,1)) = 1
		_ColorArray("Array for Color", Range(0,6)) = 4
		_UseTransparency("Use Transparency", Range(0,1)) = 1
		_TransparencyArray("Array for Transparency", Range(0,6)) = 5


	}
	SubShader {
        Tags {"Queue"="Transparent" "RenderType"="Transparent" }
        LOD 100

        ZWrite Off
        Blend SrcAlpha OneMinusSrcAlpha

        Cull Back
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows vertex:vert

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0
       float _DataMin[1000];
        float _DataMax[1000];


		int _UseDirection;
		int _DirectionArray;
		int _UseMask;
		int _MaskArray;
		int _UseColor;
		int _ColorArray;
		int _UseTransparency;
		int _TransparencyArray;

        sampler3D _DataVolume0;
		sampler3D _DataVolume1;
		sampler3D _DataVolume2;
		sampler3D _DataVolume3;
		sampler3D _DataVolume4;
		sampler3D _DataVolume5;
		sampler3D _DataVolume6;

		float4 GetVariableVector(int variable, float3 uvw) {
			switch(variable) {
				case 0: 
					return tex3Dlod (_DataVolume0, float4(uvw,0));
				case 1:
					return tex3Dlod (_DataVolume1, float4(uvw,0));
				case 2:
					return tex3Dlod (_DataVolume2, float4(uvw,0));
				case 3:
					return tex3Dlod (_DataVolume3, float4(uvw,0));
				case 4:
					return tex3Dlod (_DataVolume4, float4(uvw,0));
				case 5:
					return tex3Dlod (_DataVolume5, float4(uvw,0));
				case 6:
					return tex3Dlod (_DataVolume6, float4(uvw,0));
				default:
					return float4(0,0,0,0);
				}
		}
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
            float4 modelSpace = mul(mul(_DataBoundsMatrixInv,_DataModelMatrixInv),worldSpace);
            float3 textureSpace = (modelSpace.xyz+0.5);
            o.dataPos = textureSpace;
            float3 direction = normalize(GetVariableVector(_DirectionArray,textureSpace).rgb);

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
            
            // float4 worldSpace = float4(IN.worldPos,1);
            // float4 modelSpace = mul(mul(_DataBoundsMatrixInv,_DataModelMatrixInv),worldSpace);
            float3 textureSpace = IN.dataPos;//(modelSpace.xyz+0.5);

			if(_UseMask) {
				float V1 = GetVariableVector(_MaskArray,textureSpace);
				if(V1 <0.1) discard;
			}

			fixed4 c = float4(1,1,1,1);
			if(_UseColor) {
				float val = GetVariableVector(_ColorArray,textureSpace).r;
           	 	val = map(val, _DataMin[_ColorArray], _DataMax[_ColorArray],0,1);
            	c = tex2D(_MainTex,float2(val,0.5));
			} 


            c.a = 1;
			if(_UseTransparency) {
				float val = GetVariableVector(_TransparencyArray,textureSpace).r;
           	 	val = map(val, _DataMin[_TransparencyArray], _DataMax[_TransparencyArray],0,1);
            	c.a = val;
			} 

            //c.rgb = (textureSpace.xyz);
            if(textureSpace.r > 1 || textureSpace.r < 0  || textureSpace.g >1 || textureSpace.g < 0 || textureSpace.b > 1 || textureSpace.b < 0) 
                ;//discard;
			o.Albedo = float3(c.x,c.y,c.z);
			// Metallic and smoothness come from slider variables
			o.Metallic = _Metallic;
			o.Smoothness = _Glossiness;
			o.Alpha = 0.5;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
