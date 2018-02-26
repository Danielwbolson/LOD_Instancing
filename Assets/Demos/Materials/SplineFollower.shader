Shader "Instanced/SplineFollower" 
{
	Properties{
		_MainTex("Albedo (RGB)", 2D) = "white" {}
		_NormTex("Normal",2D) = "white" {}
		_offset("Offset",float) = 0

	}
		SubShader{
		cull Off
		Tags{ "RenderType" = "Opaque" }
		LOD 200

		CGPROGRAM
		// Physically based Standard lighting model
#pragma surface surf Standard addshadow vertex:vert
#pragma multi_compile_instancing
#pragma instancing_options procedural:setup

		sampler2D _MainTex;
		sampler2D _NormTex;

	struct Input {
		float2 uv_MainTex;
	};

#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
	//StructuredBuffer<float4> positionBuffer;
	StructuredBuffer<float3> _positions;
	StructuredBuffer<float3> _normals;
	StructuredBuffer<int> _offsets;
	StructuredBuffer<int> _indices;
	StructuredBuffer<int> _glyphID;
	StructuredBuffer<int> _lineID;
	StructuredBuffer<float> _lineLength;



#else
	float3 _positions[1];
	float3 _normals[1];
	int _offsets[1];
	int _indices[1];
	int _glyphID[1];
	int _lineID[1];
	int _lineLength[1];
#endif

	float4x4 _DataTransform;
	float _stepSize;
	int _numPositions;
	int _numLines;
	float _offset;
	float _meshHeight;

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
	float3 GetCatmullRomPosition(float t, float3 p0, float3 p1, float3 p2, float3 p3)
	{
		
		//The coefficients of the cubic polynomial (except the 0.5f * which I added later for performance)
		float3 a = 2 * p1;
		float3 b = p2 - p0;
		float3 c = 2 * p0 - 5 * p1 + 4 * p2 - p3;
		float3 d = -p0 + 3 * p1 - 3 * p2 + p3;

		//The cubic polynomial: a + b * t + c * t^2 + d * t^3
		float3 pos = 0.5 * (a + (b * t) + (c * t * t) + (d * t * t * t));

		return pos;
	}

	float3 GetCatmullRomDerivative(float t, float3 p0, float3 p1, float3 p2, float3 p3)
	{
		//The coefficients of the cubic polynomial (except the 0.5f * which I added later for performance)
		float3 a = 2 * p1;
		float3 b = p2 - p0;
		float3 c = 2 * p0 - 5 * p1 + 4 * p2 - p3;
		float3 d = -p0 + 3 * p1 - 3 * p2 + p3;

		//The cubic polynomial: a + b * t + c * t^2 + d * t^3
		float3 der = 0.5 * b + t*(c+1.5*d*t);


		return der;
	}



	int4 getSegmentIndices(int seg) {
		int4 result;
		int index0 = seg==0? 0 : seg - 1;
		int index1 = seg;
		int index2 = seg + 1;
		int index3 = seg + 2 <= _numPositions - 1? seg + 2: seg + 1;

		result.x = index0;
		result.y = index1;
		result.z = index2;
		result.w = index3;

		return result;
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

	float3 getSplinePosition(float t) {
		float3 tween;
		int seg = floor (t);
		float seg_t = t-seg;
		float3 A = _positions[seg];
		float3 B = _positions[seg+1];
		tween = lerp(A,B,seg_t);
		return tween; 
//		int seg = floor (t);
//
//		float seg_t = t - seg;
//		if (seg > _numPositions - 2) {
//			seg = _numPositions - 2;
//			seg_t = 1;
//		} 
//		if(seg < 0) {
//			seg = 0;
//			seg_t = 0;
//		}
//
//		int4 index = getSegmentIndices (seg);
//		float3 p0 = _positions[index.x];
//		float3 p1 = _positions[index.y];
//		float3 p2 = _positions[index.z];
//		float3 p3 = _positions[index.w];
//
//		return (GetCatmullRomPosition (seg_t, p0.xyz, p1.xyz, p2.xyz, p3.xyz));
	}

	float3 getSplineDerivative(float t) {
		int seg = floor (t);

		float seg_t = t - seg;
		if (seg > _numPositions - 2) {
			seg = _numPositions - 2 ;
			seg_t = 1;
		}
		if(seg < 0) {
			seg = 0;
			seg_t = 0;
		}
		int4 index = getSegmentIndices (seg);
		float3 p0 = _positions[index.x];
		float3 p1 = _positions[index.y];
		float3 p2 = _positions[index.z];
		float3 p3 = _positions[index.w];
		return (GetCatmullRomDerivative (seg_t, p0.xyz, p1.xyz, p2.xyz, p3.xyz));
	}


	float4x4 rotationAroundAxis(float3 u, float a){
		float4x4 transform;
		float c = cos(a);
		float s = sin(a);
		float nc = 1-c;

		transform[0] = float4(c+u.x*u.x*nc,u.x*u.y*nc-u.z*s,u.x*u.z*nc+u.y*s,0);
		transform[1] = float4(u.y*u.x*nc+u.z*s,c+u.y*u.y*nc,u.y*u.z*nc-u.x*s,0);
		transform[2] = float4(u.z*u.x*nc-u.y*s,u.z*u.y*nc+u.x*s,c+u.z*u.z*nc,0);
		transform[3] = float4(0,0,0,1);
		return (transform);

	}

	float3x3 referenceFrameTransform(float3 i1, float3 j1, float3 k1, float3 i2, float3 j2, float3 k2){

//		transform[0] = float3(dot(i1,i2), dot(j1,i2),dot(k1,i2));
//		transform[1] = float3(dot(i1,j2), dot(j1,j2),dot(k1,j2));
//		transform[2] = float3(dot(i1,k2), dot(j1,k2),dot(k1,k2));
		float3x3 transform;
		transform[0] = i2;
		transform[1] = j2;
		transform[2] = k2;
		return (transform);


	}


	 void vert (inout appdata_full v) {
	 	#ifdef UNITY_PROCEDURAL_INSTANCING_ENABLED
//	 		 v.vertex.xyz += _positions[unity_InstanceID];
//	 		           	v.vertex.xyz = mul(_DataTransform,v.vertex).xyz;
//
//
//	 		 return;


			//v.vertex.xyz += _positions[unity_InstanceID*100];
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
			//centerT = glyphID*0.9 /(line_length / _meshHeight-1)	 *indexListCount;
			centerT = glyphID* indexListCount*1.0/(nGlyphs) ;
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

          	          	        	return;

          	v.texcoord.y  = instT*pow(2,_glyphTextureScale);
        #endif


      }
	void surf(Input IN, inout SurfaceOutputStandard o) 
	{
		float4 col = 1.0f;


		col = float4(1, 1, 1, 1);

		fixed4 c = tex2D(_MainTex, IN.uv_MainTex.yx) * col;
		o.Albedo = c;
		o.Normal.xyz = tex2D(_NormTex,IN.uv_MainTex.yx).xyz;
		o.Alpha = c.a;
	}
	ENDCG
	}
		FallBack "Diffuse"
}
