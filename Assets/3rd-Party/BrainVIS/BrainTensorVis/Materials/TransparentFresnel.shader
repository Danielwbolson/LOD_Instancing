// http://answers.unity3d.com/questions/739141/transparent-fresnel-shader-sometimes-obscuring-obj.html
Shader "Custom/TransparentTextureFresnel"
{
	Properties
	{
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_InnerColorOffset ("Inner Color Offset", Vector) = (1.0, 1.0, 1.0, 1.0)
	   	_RimPower ("Rim Power", Range(0.5,8.0)) = 3.0
	}
	SubShader
	{
		Tags { "Queue" = "Transparent" }

		Cull Back
		Blend One One
		ZWrite Off

		CGPROGRAM
		#pragma surface surf Lambert

		struct Input
		{
			float2 uv_MainTex : TEXCOORD0;
			float3 viewDir;
		};

		sampler2D _MainTex;
		float4 _InnerColorOffset;
		float _RimPower;

		void surf (Input IN, inout SurfaceOutput o)
		{
			fixed4 texcol = tex2D(_MainTex, IN.uv_MainTex);
		   	o.Albedo = texcol.rgb + _InnerColorOffset.xyz;
		   	half rim = 1.0 - saturate(dot (normalize(IN.viewDir), o.Normal));
		   	o.Emission = texcol.rgb * pow (rim, _RimPower);
		}
		ENDCG
	}
	Fallback "Diffuse"
}