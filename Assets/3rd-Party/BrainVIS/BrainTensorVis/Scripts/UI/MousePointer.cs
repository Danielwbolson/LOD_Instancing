using UnityEngine;
using System.Collections;

public class MousePointer : MonoBehaviour {

	public string collidableLayerName = "TensorCube";

	public StylusWindow infoWindow;

	private LayerMask mask;
	private TensorVoxelCube prevHoveredVoxelCube = null;

	void Start() {
		this.mask = 1 << LayerMask.NameToLayer (this.collidableLayerName); // only check for collisions with the layer name.
	}

	// http://answers.unity3d.com/questions/416919/making-raycast-ignore-multiple-layers.html
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		RaycastHit hit;
		if (Physics.Raycast(ray.origin, ray.direction, out hit, 1000f, mask)) {
			// did hit something
			TensorVoxelCube voxel = hit.collider.gameObject.GetComponent<TensorVoxelCube>();
			this.infoWindow.UpdateValues(voxel);

			if (this.prevHoveredVoxelCube != null) {
				this.prevHoveredVoxelCube.SetHoverOver(false);
			}
			voxel.SetHoverOver(true);
			this.prevHoveredVoxelCube = voxel;
		} 
		else {
			if (this.prevHoveredVoxelCube != null) {
				this.prevHoveredVoxelCube.SetHoverOver(false);
			}
			this.prevHoveredVoxelCube = null;
		}
	}

	public void Disable() {
		if (this.prevHoveredVoxelCube != null) {
			this.prevHoveredVoxelCube.SetHoverOver(false);
		}
		this.prevHoveredVoxelCube = null;
	}
}
