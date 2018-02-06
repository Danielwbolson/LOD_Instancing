Shader "Instanced/InstancedShader" 
{
	Properties{
		_MainTex("Albedo (RGB)", 2D) = "white" {}
		_NormTex("Normal",2D) = "white" {}
		_offset("Offset",float) = 0
	}
		SubShader{
		Tags{ "RenderType" = "Opaque" }
		LOD 200

		CGPROGRAM
		// Physically based Standard lighting model
#pragma surface surf Standard addshadow vertex:vert
#pragma multi_compile_instancing
#pragma instancing_options procedural:setup

		sampler2D _MainTex;
		sampler2D _NormTex;
		float4x4 _DataTransform;
	struct Input {
		float2 uv_MainTex;
	};

#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
	//StructuredBuffer<float4> positionBuffer;
	StructuredBuffer<float4> positionBuffer;
#else
	float4 _positions[1];
#endif
	int _numPositions;


	void rotate2D(inout float2 v, float r)
	{
		float s, c;
		sincos(r, s, c);
		v = float2(v.x * c - v.y * s, v.x * s + v.y * c);
	}

	void setup()
	{

	}

	 void vert (inout appdata_full v) {
	 	#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
	 		v.vertex.xyz*=0.05;
	 		v.vertex.xyz += mul(_DataTransform,positionBuffer[unity_InstanceID]).xyz;

        #endif

        			//v.vertex.x+10;

      }

	void surf(Input IN, inout SurfaceOutputStandard o) 
	{
		float4 col = 1.0f;


		col = float4(1, 1, 1, 1);

		fixed4 c = tex2D(_MainTex, IN.uv_MainTex.yx) * col;
		o.Albedo = c;
		//o.Normal.xyz = tex2D(_NormTex,IN.uv_MainTex.yx).xyz;
		o.Alpha = 1;
	}
	ENDCG
	}
		FallBack "Diffuse"
}
