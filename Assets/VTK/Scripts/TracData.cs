using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Text;
using System;
using System.Linq;


public class TracData : Data {

	unsafe public void* handle = null;



	private class Header {
		public string id_string;
		public Vector3Int dim;
		public Vector3 voxel_size;
		public Vector3 origin;
		public short n_scalars;
		public List<string> scalar_name;
		public short n_properties;
		public List<string> property_name;
		public Matrix4x4 vox_to_ras;
		//		public //Reserved;
		public char[] voxel_order;
		public float[] image_orientation_patient;
		public bool invert_x;
		public bool invert_y;
		public bool invert_z;
		public bool swap_xy;
		public bool swap_yz;
		public bool swap_zx;
		public int n_count;
		public int version;
		public int hdr_size;

		public Header(System.IO.BinaryReader file){
			scalar_name = new List<string>();
			property_name = new List<string>();
			voxel_order = new char[4];

			id_string = new string(file.ReadChars(6));
			dim = new Vector3Int(file.ReadInt16(),file.ReadInt16(),file.ReadInt16());
			voxel_size = new Vector3(file.ReadSingle(),file.ReadSingle(), file.ReadSingle());
			origin = new Vector3(file.ReadSingle(),file.ReadSingle(), file.ReadSingle());
			n_scalars = file.ReadInt16();
			for(int i = 0; i < 10; i++)
			{
				string scalarName = new string(file.ReadChars(20));
				if (i < n_scalars){
					scalar_name.Add(scalarName);

				}
			}

			n_properties = file.ReadInt16();

			for(int i = 0; i < 10; i++) {
				string propertyName = new string(file.ReadChars(20));
				if (i < n_properties){
					property_name.Add( propertyName);

				}
			}
			vox_to_ras = new Matrix4x4(
				new Vector4(file.ReadSingle(),file.ReadSingle(), file.ReadSingle(),file.ReadSingle()),
				new Vector4(file.ReadSingle(),file.ReadSingle(), file.ReadSingle(),file.ReadSingle()),
				new Vector4(file.ReadSingle(),file.ReadSingle(), file.ReadSingle(),file.ReadSingle()),
				new Vector4(file.ReadSingle(),file.ReadSingle(), file.ReadSingle(),file.ReadSingle())
			);
			file.ReadChars(444);
			voxel_order = file.ReadChars(4);
			file.ReadChars(4);
			image_orientation_patient = new float[6];
			file.ReadChars(2);
			image_orientation_patient[0] = file.ReadSingle();
			image_orientation_patient[1] = file.ReadSingle();
			image_orientation_patient[2] = file.ReadSingle();
			image_orientation_patient[3] = file.ReadSingle();
			image_orientation_patient[4] = file.ReadSingle();
			image_orientation_patient[5] = file.ReadSingle();

			invert_x = file.ReadBoolean();
			invert_y = file.ReadBoolean();
			invert_z = file.ReadBoolean();
			swap_xy = file.ReadBoolean();
			swap_yz = file.ReadBoolean();
			swap_zx = file.ReadBoolean();
			n_count = file.ReadInt32();
			version = file.ReadInt32();
			hdr_size = file.ReadInt32();
		}

	}

	private class TrackPoint {
		public Vector3 vertex;
		public float[] scalars;
		public TrackPoint(int n_scalars) {
			scalars = new float[n_scalars];
		}
	}

	private  class Track {
		public List<TrackPoint> points;
		public float[] properties;
		public Track( int n_properties) {
			properties = new float[n_properties];
			points = new List<TrackPoint>();
		}
	}


	List<Vector3> vertices;
	ComputeBuffer buff;

	private Header H;
	public void LoadData()
	{
		print ("Loading " + Application.streamingAssetsPath + "/" + filename);


		char[] test = new char[7];

		System.IO.BinaryReader file = new System.IO.BinaryReader (System.IO.File.Open(Application.streamingAssetsPath + "/" + filename, System.IO.FileMode.Open));

		 H = new Header (file);

		Debug.Log (H.id_string);
		Debug.Log (H.n_properties);
		Debug.Log (H.property_name[0]);
		Debug.Log ((H.hdr_size));


		//Vector3 mm = new Vector3 ((float)(bbox [0]), (float)(bbox [2]), (float)(bbox [4]));
		//Vector3 MM = new Vector3 ((float)(bbox [1]), (float)(bbox [3]), (float)(bbox [5]));
		//
		//Vector3 center = (mm + MM) / 2;
		//Vector3 size = MM - mm;


		data_size.x = H.dim.x*H.voxel_size.x;
		data_size.y = H.dim.y*H.voxel_size.y;
		data_size.z = H.dim.z*H.voxel_size.z;
		data_center = H.origin+data_size/2;
		//data_center = new Vector3 (0, 0, 0);

		updateBounds ();
		List<Track> tracks = new List<Track> ();
		for(int i = 0; i < 10 /*H.n_count*/; i++){
			int points = file.ReadInt32 ();
			Track T = new Track (H.n_properties);

			for (int p = 0; p < points; p++) {
				TrackPoint P = new TrackPoint (H.n_scalars);

				Vector3 vertex = new Vector3 (file.ReadSingle (), file.ReadSingle (), file.ReadSingle ());
				P.vertex = vertex;

				for (int s = 0; s < H.n_scalars; s++) {
					P.scalars [s] = file.ReadSingle ();
				}

				T.points.Add(P);
			}
			for (int p = 0; p < H.n_properties; p++) {
				T.properties[p] = file.ReadSingle ();
			}
			tracks.Add (T);


		}
		vertices = new List<Vector3>();

		ComputeBuffer buff = new ComputeBuffer (tracks [0].points.Count, sizeof(float)*3);

		Vector3[] buffData = new Vector3[tracks [0].points.Count];

		int index = 0;
		for (int t = 0; t < 10/*tracks.Count*/; t+=1) {
			Debug.Log ("Track " + t + " has " + tracks [t].points.Count + " points:");
			int pointstep = 5;
			for(int p = 0; p < tracks[t].points.Count; p+=pointstep){
				vertices.Add (tracks [t].points [p].vertex);
				//Debug.Log("  " + tracks[t].points[p].vertex);
				//buffData[p] = tracks[t].points[p].vertex;
//
//				if (p >= pointstep) {
//
//					Vector3 p1 = tracks [t].points [p - pointstep].vertex;
//					Vector3 p2 = tracks [t].points [p].vertex;
//					Vector3 pv = (p2 - p1).normalized;
//					Vector3 CU = Vector3.Cross (pv, Vector3.up).normalized;
//					Vector3 C1 = Vector3.Cross (pv, CU).normalized;
//					Vector3 C2 = Vector3.Slerp (-C1, CU, 2.0f / 3.0f).normalized;
//					Vector3 C3 = Vector3.Slerp (-C1, -CU, 2.0f / 3.0f).normalized;
//
//
//
//					C1 *= 0.1f;
//					C2 *= 0.1f;
//					C3 *= 0.1f;
//
//					vertices.Add (p1 + C1);//0
//					vertices.Add (p1 + C2);//1
//					vertices.Add (p1 + C3);//2
//
//
//					//					vertices.Add (p2+C1);//3
//					//						vertices.Add (p2+C2);//4
//					//					vertices.Add (p2+C3);//5
//
//					triangles.Add (index + 1);
//					triangles.Add (index + 2);
//					triangles.Add (index - 2);
//
//					triangles.Add (index + 2);
//					triangles.Add (index - 1);
//					triangles.Add (index - 2);
//					//
//					triangles.Add (index + 2);
//					triangles.Add (index + 0);
//					triangles.Add (index - 1);
//					//
//					triangles.Add (index + 0);
//					triangles.Add (index - 3);
//					triangles.Add (index - 1);
//
//
//					triangles.Add (index + 0);
//					triangles.Add (index + 1);
//					triangles.Add (index - 3);
//
//					triangles.Add (index + 1);
//					triangles.Add (index - 2);
//					triangles.Add (index - 3);
//
//					//
//					index += 3;

				//} else {
//					Vector3 p1 = tracks [t].points [p + pointstep].vertex;
//					Vector3 p2 = tracks [t].points [p].vertex;
//					Vector3 pv = (p2 - p1).normalized;
//					Vector3 CU = Vector3.Cross (pv, Vector3.up).normalized;
//					Vector3 C1 = Vector3.Cross (pv, CU).normalized;
//					Vector3 C2 = Vector3.Slerp (-C1, CU, 2.0f / 3.0f).normalized;
//					Vector3 C3 = Vector3.Slerp (-C1, -CU, 2.0f / 3.0f).normalized;
//
//					C1 *= 0.1f;
//					C2 *= 0.1f;
//					C3 *= 0.1f;
//
//
//
//					vertices.Add (p1 + C1);//0
//					vertices.Add (p1 + C2);//1
//					vertices.Add (p1 + C3);//2
//
//					index += 3;

//				}
//				if (index > 60000)
//					break;

			}
		}
		is_valid = true;

	}

	void OnDrawGizmos() {
		if (!is_valid)
			return;
		foreach (Vector3 V in vertices) {
			//print (V);
			//print(data_center);
			Gizmos.matrix = transform.localToWorldMatrix;
			Gizmos.color = Color.blue;
			Gizmos.DrawCube (V, new Vector3 (1f, 1f, 1f));
		}
	}



}
