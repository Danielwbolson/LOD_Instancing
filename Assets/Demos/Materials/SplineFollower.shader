Shader "Instanced/SplineFollower" 
{
	Properties{
		_MainTex("Albedo (RGB)", 2D) = "white" {}
		_MapTex("ColorMap", 2D) = "white" {}
		_NormTex("Normal",2D) = "white" {}
		_offset("Offset",float) = 0
		_CutoutThresh("Cutout Threshold", Range(0.0,1.0)) = 0.2


	}
		SubShader{
		//cull Off
        Tags {"Queue"="Cutout" "RenderType"="Cutout" }
		LOD 200
		        Blend SrcAlpha OneMinusSrcAlpha

		CGPROGRAM
		// Physically based Standard lighting model
#pragma surface surf Standard addshadow vertex:vert
#pragma multi_compile_instancing
#pragma instancing_options procedural:setup

		sampler2D _MainTex;
		sampler2D _NormTex;
		sampler2D _MapTex;
		float _CutoutThresh;

	struct Input {
		float2 uv_MainTex;
		float t;
		float data;
	};

#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
	//StructuredBuffer<float4> positionBuffer;
	StructuredBuffer<float3> _positions;
	StructuredBuffer<float3> _normals;
	StructuredBuffer<float> _data;
	StructuredBuffer<int> _offsets;
	StructuredBuffer<int> _indices;
	StructuredBuffer<int> _glyphID;
	StructuredBuffer<int> _lineID;
	StructuredBuffer<float> _lineLength;



#else
	float3 _positions[1];
	float3 _normals[1];
	float _data[1];
	int _offsets[1];
	int _indices[1];
	int _glyphID[1];
	int _lineID[1];
	int _lineLength[1];
#endif
	float _dataMin;
	float _dataMax;
	float4x4 _DataTransform;
	float _stepSize;
	int _numPositions;
	int _numLines;
	float _offset;
	float _meshHeight;
	int _Use3DGlyph;
	float _glyphScale = 1;
	float _glyphRadius = 1;

	float _glyphInflate=0;

	float _glyphSpacing = 0;
	float _glyphTwist = 0;
	float _glyphTextureScale = 1;

	void rotate2D(inout float2 v, float r)
	{
		float s, c;
		sincos(r, s, c);
		v = float2(v.x * c - v.y * s, v.x * s + v.y * c);
	}

	void setup()
	{

	}

	float map(float value, float min1, float max1, float min2, float max2) {
			// Convert the current value to a percentage
		// 0% - min1, 100% - max1
		float perc = (value - min1) / (max1 - min1);

		// Do the same operation backwards with min2 and max2
		return perc * (max2 - min2) + min2;
	}
	float getDataOnLine(int l, float t) {
		int indexListStart = _offsets[l];
		int indexListCount = _offsets[l+1]-_offsets[l];
		int lineLength = _lineLength[l];
		t = min(t, indexListCount-1);
		t = max(t,0);

		
		int seg = floor (t);
		int seg_b = seg+1;
		seg_b = min(indexListCount-1, seg_b);
		float seg_t = t-seg;
		int a = _indices[indexListStart+seg];
		int b = _indices[indexListStart+seg_b];
		float tween;
		float A = _data[a];
		float B = _data[b];
		tween = lerp(A,B,seg_t);
		return tween; 

	}

	float3 getPositionOnLine(int l, float t) {
		int indexListStart = _offsets[l];
		int indexListCount = _offsets[l+1]-_offsets[l];
		int lineLength = _lineLength[l];
		t = min(t, indexListCount-1);
		t = max(t,0);

		
				float3 tween;
		int seg = floor (t);
		int seg_b = seg+1;
		seg_b = min(indexListCount-1, seg_b);
		float seg_t = t-seg;
		int a = _indices[indexListStart+seg];
		int b = _indices[indexListStart+seg_b];

		float3 A = _positions[a];
		float3 B = _positions[b];
		tween = lerp(A,B,seg_t);
		return tween; 

	}

	float3 getNormalOnLine(int l, float t) {
		int indexListStart = _offsets[l];
		int indexListCount = _offsets[l+1]-_offsets[l];
		int lineLength = _lineLength[l];
		t = min(t, indexListCount-1);
		t = max(t,0);

		
				float3 tween;
		int seg = floor (t);
		int seg_b = seg+1;
		seg_b = min(indexListCount-1, seg_b);
		float seg_t = t-seg;
		int a = _indices[indexListStart+seg];
		int b = _indices[indexListStart+seg_b];

		float3 A = _normals[a];
		float3 B = _normals[b];
		tween = lerp(A,B,seg_t);
		return normalize(tween); 

	}



	 void  vert (inout appdata_full v, out Input o) {
	           UNITY_INITIALIZE_OUTPUT(Input,o);

	 	#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED

			float centerT;
			float3 original = v.vertex.xyz;
			v.vertex.xyz *= _glyphScale;
			float z = v.vertex.y;

			int id = unity_InstanceID;
			int lineID = _lineID[id];
			int glyphID = _glyphID[id];

			float line_length = _lineLength[lineID];

			//int line_segments = floor(line_length);
			int indexListStart = _offsets[lineID];
			int indexListCount = _offsets[lineID+1]-_offsets[lineID];
			float nGlyphs = line_length / _meshHeight;
			int numGlyphs = ceil(nGlyphs);;


			centerT = glyphID * _meshHeight*2/_stepSize;
			//centerT = glyphID *_meshHeight/_stepSize;
	 		//centerT = (unity_InstanceID  + _offset)*(_glyphScale+_glyphSpacing);


	 		float instT = centerT +z*1.0/_stepSize;

//			float _RotationSpeed = _glyphTwist*instT;
//			float sinX = sin ( _RotationSpeed  );
//			float cosX = cos ( _RotationSpeed  );
//			float sinY = sin ( _RotationSpeed  );
//			float2x2 rotationMatrix = float2x2( cosX, -sinX, sinY, cosX);          
//
//			v.vertex.xz = mul(rotationMatrix,v.vertex.xz); 
//			v.normal.xz = mul(rotationMatrix,v.normal.xz);


//	 		float3 pointA = getSplinePosition(unity_InstanceID+_offset);;
//	 		float3 pointB = getSplinePosition(unity_InstanceID+1+_offset);;
			v.vertex.y = 0;
	 		float3 N = normalize(getNormalOnLine(lineID,instT));
	 		float3 P = getPositionOnLine(lineID,instT);
	 		float3 AB = normalize(getPositionOnLine(lineID,instT+1) - getPositionOnLine(lineID,instT-1));
	 		float3 B = normalize(cross(N,AB));
	 		float3 T = normalize(cross(N,B));
	 		float3 ABVector = T;

	 		float3 i = float3(1,0,0);
	 		float3 j = float3(0,1,0);
	 		float3 k = float3(0,0,1);



			float3x3 transform;
			transform[0] = -B;
			transform[1] = T;
			transform[2] = N;
			transform = transpose(transform);


	 		v.vertex.xz *= 1*_glyphScale*_glyphRadius;

			v.vertex.xyz = mul(transform,v.vertex.xyz);
			v.normal.xyz = mul(transform,v.normal.xyz);

			v.vertex.xyz += P;
			v.vertex.xyz = mul(_DataTransform,v.vertex).xyz;

          	v.texcoord.y  = instT*pow(2,_glyphTextureScale);

          	         o.t = instT;

          	o.data = map(getDataOnLine(lineID,instT),_dataMin,_dataMax,0,1);

        #endif


      }
	void surf(Input IN, inout SurfaceOutputStandard o) 
	{

		if(_Use3DGlyph==0) {
			float4 col = 1.0f;

			float t = IN.t*0.1;

			fixed4 tex = tex2D(_MainTex, float2(t,IN.uv_MainTex.x)) * col;
			//tex = float4(t-(int)t,IN.uv_MainTex.x,0,1);
			col = tex2D(_MapTex,float2(IN.data,0.5));
			
			o.Albedo = col*tex;

						o.Normal.xyz = tex2D(_NormTex,IN.uv_MainTex.yx).xyz;
			o.Alpha = tex.r;
			clip(o.Alpha - _CutoutThresh);

		} else {
				o.Normal.xyz = tex2D(_NormTex,IN.uv_MainTex.yx).xyz;
						o.Albedo = tex2D(_MapTex,float2(IN.data,0.5));

		}

	}
	ENDCG
	}
		FallBack "Diffuse"
}
