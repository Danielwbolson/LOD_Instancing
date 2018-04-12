// Upgrade NOTE: replaced 'UNITY_INSTANCE_ID' with 'UNITY_VERTEX_INPUT_INSTANCE_ID'

Shader "Instanced/GlyphShader" 
{
	Properties{
		_MainTex("Albedo (RGB)", 2D) = "white" {}
		_MainTex2("Albedo (RGB)", 2D) = "black" {}
		_MainTex3("Albedo (RGB)", 2D) = "blue" {}

		_NormTex("Normal",2D) = "white" {}
		_offset("Offset",float) = 0
		_glyphScale("GlyphScale",float) = 0.01
		_glyphLength("Glyph Length",float) = 1
		_glyphType("Glyph Type",int) = 1
	}
		SubShader{
		Tags{ "RenderType" = "Cutout" }
		LOD 200
		Blend SrcAlpha OneMinusSrcAlpha
		cull Front


		CGPROGRAM
			// Physically based Standard lighting model
#pragma surface surf Standard addshadow vertex:vert
#pragma multi_compile_instancing
#pragma instancing_options procedural:setup


		sampler2D _MainTex;
		sampler2D _MainTex2;
		sampler2D _MainTex3;
		sampler3D _dataVolume;
		sampler3D _dataVolume2;

		float3 volumeDimensions;
				float _glyphScale;
				float _glyphLength;
				int _glyphType;
		sampler2D _NormTex;
		float4x4 _DataTransform;
	struct Input {
		float2 uv_MainTex;
		float2 uv_MainTex2;
		float2 uv_MainTex3;
		float3 volumePosition;
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


	 void vert (inout appdata_full v, out Input o) {
	 	UNITY_SETUP_INSTANCE_ID(v);
	 	UNITY_INITIALIZE_OUTPUT(Input,o);

	 	#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
//	 		v.vertex.xyz*=0.05;
//	 		v.vertex.xyz += mul(_DataTransform,positionBuffer[unity_InstanceID]).xyz;

	 		o.volumePosition = positionBuffer[unity_InstanceID]/volumeDimensions;

			float4 volCoord = float4(o.volumePosition.x,o.volumePosition.y, o.volumePosition.z,0);
	 		//

	 		float3 direction = normalize(tex3Dlod(_dataVolume,volCoord).xyz);
	 		float3 direction2 = normalize(tex3Dlod(_dataVolume2,volCoord).xyz);

	 		if(_glyphType == 1)
	 			direction = direction2;

	 		float3 i = float3(1,0,0);
	 		float3 j = float3(0,1,0);
	 		float3 k = float3(0,0,1);

	 		float3 B =normalize(cross(direction,j));

//
			v.vertex.y *= _glyphLength;
			float3x3 transform;
			transform[0] = B;
			transform[1] = direction;
			transform[2] = cross(direction,B);
			transform = transpose(transform);
//
//
			v.vertex.xyz = mul(transform,v.vertex.xyz);
			v.normal.xyz = mul(transform,v.normal.xyz);
//
			float3 glyphPosition = mul(_DataTransform,positionBuffer[unity_InstanceID]).xyz;
			v.vertex.xyz*=_glyphScale;
	 		v.vertex.xyz += glyphPosition;

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

		fixed4 ct = tex2D(_MainTex, IN.uv_MainTex.yx) * col;
		fixed4 c = col;
		if(_glyphType==1)
		c = ct;

//		if(id%3 == 0)
//			c = tex2D(_MainTex, IN.uv_MainTex.yx) * col;
//		else if(id%3 == 1)
//			c = tex2D(_MainTex2, IN.uv_MainTex2.yx) * col;
//		else if(id%3 == 2)
//			c = tex2D(_MainTex3, IN.uv_MainTex3.yx) * col;
	 		float3 direction = tex3D(_dataVolume,IN.volumePosition).xyz;

		o.Albedo = c;
		//o.Normal.xyz = tex2D(_NormTex,IN.uv_MainTex.yx).xyz;
		c.a = length(direction);

		if(c.a <0.8)
			discard;
		if(c.r <0.2)
			discard;
		o.Alpha = length(direction);
	}
	ENDCG
	}
		FallBack "Diffuse"
}
