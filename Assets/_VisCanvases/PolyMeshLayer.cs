using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


namespace SculptingVis {
[CreateAssetMenu()]
public class PolyMeshLayer : Layer {
	[SerializeField]
	string _dataPath = "example_data/VTK/contour.vtp";

	[SerializeField, HideInInspector]
	VTK.vtkPolyData _dataset;

	[SerializeField]
	Mesh _polyMesh;

	[SerializeField]
	Material _polyMeshMaterial;

	public override bool HasBounds() {
		return _dataset != null;
	}
	public override Bounds GetBounds() {
		return _dataset.GetBounds();
	}

	public override void DrawLayer(Canvas canvas) {
		if(_dataset== null ) {
			var reader = VTK.vtkXMLPolyDataReader.New();
			reader.SetFileName(Application.streamingAssetsPath +"/"+  _dataPath);
			reader.Update();
			_dataset = VTK.vtkPolyData.SafeDownCast(reader.GetOutputAsDataSet());
			
			Mesh mesh = new Mesh();
			Debug.Log(_dataset.GetPoints().GetNumberOfPoints());
			Vector3[] points = new Vector3[_dataset.GetPoints().GetNumberOfPoints()];

			int[] tris = new int[_dataset.GetNumberOfCells()*3];

			for(int i = 0; i < points.Length; i++) {
				points[i] = _dataset.GetPoints().GetPoint(i);
			}


			for(int i = 0; i < _dataset.GetNumberOfCells(); i++) {
				tris[i*3 + 0] = (int)_dataset.GetCell(i).GetPointId(0);
				tris[i*3 + 1] = (int)_dataset.GetCell(i).GetPointId(1);
				tris[i*3 + 2] = (int)_dataset.GetCell(i).GetPointId(2);

			}

			mesh.vertices = points;
			mesh.triangles = tris;
			mesh.RecalculateNormals();
			_polyMesh = mesh;
			// unsafe{
			// 	System.IntPtr v = _dataset.GetPoints().GetVoidPointer(0);
			// 	Marshal.Copy()
			// }
		}

		Graphics.DrawMesh(_polyMesh,canvas.GetInnerSceneTransformMatrix()*Matrix4x4.TRS(GetBounds().center, Quaternion.identity, new Vector3(1,1,1)),GetCanvasMaterial(canvas,_polyMeshMaterial),0);
	}
}
}

