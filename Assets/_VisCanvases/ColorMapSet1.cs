using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class MeshSet : ScriptableObject {

	[SerializeField]
	List<Mesh> _meshes;

	[SerializeField]
	List<string> _names;

	public List<Mesh> GetMeshes() {
		return _meshes;
	}

	public List<string> GetMeshNames() {
		return _names;
	}
}
