using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DVMeshFieldRenderingStrategy : MonoBehaviour {
	
	GameObject [] _meshes; 
	Material _material;

	void SetMeshes(GameObject[] meshes) {
		_meshes = meshes;
	}
	

	void SetMaterial(Material material) {
		_material = material;
	}

	public virtual void UpdateMeshData() {
		
	}
	public virtual void DrawMeshes() {

	}

}
