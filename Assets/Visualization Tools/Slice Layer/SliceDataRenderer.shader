Shader "Custom/SliceDataRenderer" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
		_ArrayID("Which Array to use?", Range(0,6)) = 0

	}

	SubShader {
        Tags { "RenderType"="Opaque"  }    
		//Tags { "Queue"="Transparent" "RenderType"="Transparent" }
		LOD 200
        //Blend SrcAlpha OneMinusSrcAlpha
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows //alpha

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

///////////////////////////////////////////////////
// DATA RENDERER BOILER PLATE


		float3 _DataImageDimensions;
		
        float4 _DataMin0;
		float4 _DataMin1;

        float4 _DataMax0;
        float4 _DataMax1;


        int _VariableType0;
        int _VariableType1;

		

// DATA VOLUMES
		sampler3D _DataVolume0;
		sampler3D _DataVolume1;

// DATA BUFFERS

	#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
		StructuredBuffer<float4> _DataBuffer0;
		StructuredBuffer<float4> _DataBuffer1;
	#else
		float4 _DataBuffer0[1];
		float4 _DataBuffer1[1];
	#endif



	#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
		StructuredBuffer<int> _DataIndexBuffer0;
		StructuredBuffer<int> _DataIndexBuffer1;
	#else
		int _DataIndexBuffer0[1];
		int _DataIndexBuffer1[1];
	#endif



        float4x4 _DataModelMatrix;
        float4x4 _DataModelMatrixInv;
        float4x4 _DataBoundsMatrix;
        float4x4 _DataBoundsMatrixInv;
		
// END BOILER PLATE
///////////////////////////////////////////////////


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
            float4 modelSpace = mul(_DataBoundsMatrixInv,worldSpace);
            float3 textureSpace = (modelSpace.xyz+0.5);
			float val = 0;


			val = tex3D (_DataVolume0, textureSpace);
		

            val = map(val, _DataMin0.x, _DataMax0.x,0,1);
            fixed4 c = float4(1,1,1,1)*tex2D(_MainTex,float2(val,0.5));
			//c = float4(textureSpace,1);
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
	FallBack "Diffuse"SubShader {
        Tags { "RenderType"="Opaque"  }    
		//Tags { "Queue"="Transparent" "RenderType"="Transparent" }
		LOD 200
        //Blend SrcAlpha OneMinusSrcAlpha
        ZWrite Off
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows //alpha

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

///////////////////////////////////////////////////
// DATA RENDERER BOILER PLATE


		float3 _DataImageDimensions;
		
        float4 _DataMin0;
		float4 _DataMin1;

        float4 _DataMax0;
        float4 _DataMax1;


        int _VariableType0;
        int _VariableType1;

		

// DATA VOLUMES
		sampler3D _DataVolume0;
		sampler3D _DataVolume1;

// DATA BUFFERS

	#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
		StructuredBuffer<float4> _DataBuffer0;
		StructuredBuffer<float4> _DataBuffer1;
	#else
		float4 _DataBuffer0[1];
		float4 _DataBuffer1[1];
	#endif



	#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
		StructuredBuffer<int> _DataIndexBuffer0;
		StructuredBuffer<int> _DataIndexBuffer1;
	#else
		int _DataIndexBuffer0[1];
		int _DataIndexBuffer1[1];
	#endif



        float4x4 _DataModelMatrix;
        float4x4 _DataModelMatrixInv;
        float4x4 _DataBoundsMatrix;
        float4x4 _DataBoundsMatrixInv;
		
// END BOILER PLATE
///////////////////////////////////////////////////


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
            float4 modelSpace = mul(_DataBoundsMatrixInv,worldSpace);
            float3 textureSpace = (modelSpace.xyz+0.5);
			float val = 0;


			val = tex3D (_DataVolume0, textureSpace);
		

            val = map(val, _DataMin0.x, _DataMax0.x,0,1);
            fixed4 c = float4(1,1,1,1)*tex2D(_MainTex,float2(val,0.5));
			//c = float4(textureSpace,1);
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


	SubShader {
        Tags { "LightMode" = "ShadowCaster"  }    
		//Tags { "Queue"="Transparent" "RenderType"="Transparent" }
		LOD 200
        //Blend SrcAlpha OneMinusSrcAlpha
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows //alpha

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

///////////////////////////////////////////////////
// DATA RENDERER BOILER PLATE


		float3 _DataImageDimensions;
		
        float4 _DataMin0;
		float4 _DataMin1;

        float4 _DataMax0;
        float4 _DataMax1;


        int _VariableType0;
        int _VariableType1;

		

// DATA VOLUMES
		sampler3D _DataVolume0;
		sampler3D _DataVolume1;

// DATA BUFFERS

	#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
		StructuredBuffer<float4> _DataBuffer0;
		StructuredBuffer<float4> _DataBuffer1;
	#else
		float4 _DataBuffer0[1];
		float4 _DataBuffer1[1];
	#endif



	#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
		StructuredBuffer<int> _DataIndexBuffer0;
		StructuredBuffer<int> _DataIndexBuffer1;
	#else
		int _DataIndexBuffer0[1];
		int _DataIndexBuffer1[1];
	#endif



        float4x4 _DataModelMatrix;
        float4x4 _DataModelMatrixInv;
        float4x4 _DataBoundsMatrix;
        float4x4 _DataBoundsMatrixInv;
		
// END BOILER PLATE
///////////////////////////////////////////////////


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
            float4 modelSpace = mul(_DataBoundsMatrixInv,worldSpace);
            float3 textureSpace = (modelSpace.xyz+0.5);
			float val = 0;


			val = tex3D (_DataVolume0, textureSpace);
		

            val = map(val, _DataMin0.x, _DataMax0.x,0,1);
            fixed4 c = float4(1,1,1,1)*tex2D(_MainTex,float2(val,0.5));
			//c = float4(textureSpace,1);
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
