using UnityEngine;
using System.Collections;

public class StylusPointer : MonoBehaviour {
	public string collidableLayerName = "TensorCube";

	public StylusWindow infoWindow;
	public Vector3 windowOffset;

	public LineRenderer line;
	public Color hitColor;

	private LayerMask mask;
	private TensorVoxelCube prevHoveredVoxelCube = null;

	void Start() {
		this.mask = 1 << LayerMask.NameToLayer (this.collidableLayerName); // only check for collisions with the layer name.
	}

	// http://answers.unity3d.com/questions/416919/making-raycast-ignore-multiple-layers.html
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast(this.transform.position, this.transform.forward, out hit, mask)) {
			// did hit something
			Vector3 localPt = this.transform.InverseTransformPoint(hit.point);
			line.SetPosition(1, localPt);
			// for the shader we are using, we need to directly change the color of the shader, not through line render color picker.
			line.enabled = true;
			line.material.color = this.hitColor;
			//line.SetColors(this.hitColor, this.hitColor);

			TensorVoxelCube voxel = hit.collider.gameObject.GetComponent<TensorVoxelCube>();
			this.infoWindow.UpdateValues(voxel);
			this.infoWindow.transform.position = hit.point + (hit.normal * 0.05f) + windowOffset;

			if (this.prevHoveredVoxelCube != null) {
				this.prevHoveredVoxelCube.SetHoverOver(false);
			}
			voxel.SetHoverOver(true);
			this.prevHoveredVoxelCube = voxel;
		} 
		else {
			// for the shader we are using, we need to directly change the color of the shader, not through line render color picker.
			line.enabled = false;
			//line.SetColors(this.defaultColor, this.defaultColor);

			if (this.prevHoveredVoxelCube != null) {
				this.prevHoveredVoxelCube.SetHoverOver(false);
			}
			this.prevHoveredVoxelCube = null;
		}
	}
}
