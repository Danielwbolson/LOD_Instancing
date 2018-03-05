// Upgrade NOTE: replaced 'UNITY_INSTANCE_ID' with 'UNITY_VERTEX_INPUT_INSTANCE_ID'

Shader "Instanced/BillboardInstancedShader" 
{
	Properties{
		_MainTex("Albedo (RGB)", 2D) = "white" {}
		_MainTex2("Albedo (RGB)", 2D) = "black" {}
		_MainTex3("Albedo (RGB)", 2D) = "blue" {}

		_NormTex("Normal",2D) = "white" {}
		_offset("Offset",float) = 0
	}
		SubShader{
		Tags{ "RenderType" = "Cutout" }
		LOD 200

				CGPROGRAM
		// Physically based Standard lighting model
#pragma surface surf Standard addshadow vertex:vert
#pragma multi_compile_instancing
#pragma instancing_options procedural:setup

		sampler2D _MainTex;
		sampler2D _MainTex2;
		sampler2D _MainTex3;

		sampler2D _NormTex;
		float4x4 _DataTransform;
	struct Input {
		float2 uv_MainTex;
		float2 uv_MainTex2;
		float2 uv_MainTex3;
		UNITY_VERTEX_INPUT_INSTANCE_ID
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
	 	UNITY_SETUP_INSTANCE_ID(v);

	 	#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
//	 		v.vertex.xyz*=0.05;
//	 		v.vertex.xyz += mul(_DataTransform,positionBuffer[unity_InstanceID]).xyz;

			float3 glyphPosition = mul(_DataTransform,positionBuffer[unity_InstanceID]).xyz;
			v.vertex.xyz*=0.05;
//	 		v.vertex.xyz += glyphPosition;
	 		//v.vertex.xyz = mul(UNITY_MATRIX_MV, float4(0.0, 0.0, 0.0, 1.0)) + float4(v.vertex.x, v.vertex.y, 0.0, 0.0);

	 		  // get the camera basis vectors
			  float3 forward = -normalize(UNITY_MATRIX_V._m20_m21_m22);
			  float3 up = float3(0, 1, 0); //normalize(UNITY_MATRIX_V._m10_m11_m12);
			  float3 right = normalize(UNITY_MATRIX_V._m00_m01_m02);
			  
			  // rotate to face camera
			  float4x4 rotationMatrix = float4x4(right,   0,
			                                     up,      0,
			                                     forward, 0,
			                                     0, 0, 0, 1);
			  float r = ((unity_InstanceID+243)%100)*0.01f*2.0f*3.1415f;
			  float4x4 rotationMatrix2 = float4x4(	cos(r),-sin(r),0,0,
			  										sin(r),cos(r),0,0,
			  										0,0,1,0,
			  										0,0,0,1);

			  //float offset = _Object2World._m22 / 2;
			  float offset = 0;
			  v.vertex = mul(mul(v.vertex + float4(0, offset, 0, 0), rotationMatrix2), rotationMatrix) + float4(0, -offset, 0, 0);

			  v.vertex.xyz += glyphPosition;

			  v.color.r = ((unity_InstanceID+243)%100)*0.01f;
			  v.normal = mul(v.normal, rotationMatrix);


        #endif

        			//v.vertex.x+10;

      }

	void surf(Input IN, inout SurfaceOutputStandard o) 
	{

	    UNITY_SETUP_INSTANCE_ID (IN);

		float4 col = 1.0f;


		col = float4(1, 1, 1, 1);
		int id = 0;//unity_InstanceID;//UNITY_INSTANCE_ID
//        #ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
//		id = unity_InstanceID;
//		#endif

		fixed4 c = float4(1, 1, 1, 1);
		if(id%3 == 0)
			c = tex2D(_MainTex, IN.uv_MainTex.yx) * col;
		else if(id%3 == 1)
			c = tex2D(_MainTex2, IN.uv_MainTex2.yx) * col;
		else if(id%3 == 2)
			c = tex2D(_MainTex3, IN.uv_MainTex3.yx) * col;

		o.Albedo = c;
		//o.Normal.xyz = tex2D(_NormTex,IN.uv_MainTex.yx).xyz;
		if(c.a <0.8)
			discard;
		o.Alpha = c.a;
	}
	ENDCG
	}
		FallBack "Diffuse"
}
