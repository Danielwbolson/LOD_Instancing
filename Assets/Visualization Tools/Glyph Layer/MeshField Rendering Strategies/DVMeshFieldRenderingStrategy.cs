using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DV
{
public class DVMeshFieldRenderingStrategy : MonoBehaviour {

	protected GameObject [] _meshes; 
	protected Material _material;
	protected Transform _parent;
 	protected DVSample[] _samples;

	public void SetSamples(DVSample[] samples) {
		_samples = samples;
	}
	public void SetParent(Transform parent) {
		_parent = parent;
	}

	public void SetMeshes(GameObject[] meshes) {
		_meshes = meshes;
	}
	

	public void SetMaterial(Material material) {
		_material = material;
	}

	public virtual void UpdateMeshData() {
		
	}
	public virtual void DrawMeshes() {

	}

}
}