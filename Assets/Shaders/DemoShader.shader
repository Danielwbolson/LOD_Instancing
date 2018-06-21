Shader "Custom/DemoShader" {
    Properties{
        _MainTex("Albedo (RGB)", 2D) = "white" {}
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
        float map(float s, float a1, float a2, float b1, float b2)
        {
            return b1 + (s-a1)*(b2-b1)/(a2-a1);
        }

//////////////////////////////////////////////////
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

        struct ObjInfo {
            int meshIndex;
            int LODIndex;
            float4 position;
            float4 color;
            float scale;
            float3 direction;
        };

#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
        StructuredBuffer<ObjInfo> dataBuffer;
        StructuredBuffer<float4x4> matrixBuffer;
        float DummyForShadows;
#else
        float4 color;
#endif

        void setup() {
#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
            unity_ObjectToWorld = matrixBuffer[unity_InstanceID];
#endif
        }

        half _Glossiness;
        half _Metallic;
        fixed4 c;

        void surf(Input IN, inout SurfaceOutputStandard o) {
#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
            float4 col = dataBuffer[unity_InstanceID].color;
            c = tex2D(_MainTex, IN.uv_MainTex) * col;
#else
            c = tex2D(_MainTex, IN.uv_MainTex) * color;
#endif

            float4 worldSpace = float4(IN.worldPos,1);
            float4 modelSpace = mul(_DataBoundsMatrixInv,worldSpace);
            float3 textureSpace = (modelSpace.xyz+0.5);

            float val = 0;
			val = tex3D (_DataVolume0, textureSpace);
            val = map(val, _DataMin0.x, _DataMax0.x,0,1);
            c = float4(1,1,1,1)*tex2D(_MainTex,float2(val,0.5));

            o.Albedo = tex2D(_MainTex,float2(textureSpace.x,0.5));
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
