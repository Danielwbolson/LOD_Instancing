using UnityEngine;
using System.Collections;

namespace MinVR
{
	/** Defines a screen with four corner points in a local space.
	 * Contains functions to transform them into a world space.
	 * 
	 * Important: our off-axis projection script assumes that a projection screen is a rectangle. 
	 */ 
	[ExecuteInEditMode]
	public class VRProjectionScreen : MonoBehaviour
	{

		[System.Serializable]
		public class ScreenCorners
		{
			public Vector3 topLeft = new Vector3 (-4f, 4f, 4f);
			public Vector3 topRight = new Vector3 (4f, 4f, 4f);
			public Vector3 bottomRight = new Vector3 (4f, -4f, 4f);
			public Vector3 bottomLeft = new Vector3 (-4f, -4f, 4f);
		}

		[Tooltip ("Displays a boundary of this screen in Editor.")]
		public bool displayInEditor = true;
		[Tooltip ("Inital local positions of the four corners of this screen. They should form a rectangle!")]
		public ScreenCorners initLocalCorners;

		private ScreenCorners worldSpaceCorners;

		void Start ()
		{
			worldSpaceCorners = new ScreenCorners ();

			// check if the corners forms a rectangle
			if (!this.IsRectangle (this.initLocalCorners)) {
				Debug.LogWarning ("the projection screen is not a rectangle.");
			}
		}

		void Update ()
		{
			#if UNITY_EDITOR
				// to show the warning in the [ExecuteInEditMode]
				// check if the corners forms a rectangle
				if (!this.IsRectangle (this.initLocalCorners)) {
					Debug.LogWarning ("the projection screen is not a rectangle.");
				}
			#endif

			this.worldSpaceCorners.topLeft = this.transform.TransformPoint (this.initLocalCorners.topLeft);
			this.worldSpaceCorners.topRight = this.transform.TransformPoint (this.initLocalCorners.topRight);
			this.worldSpaceCorners.bottomRight = this.transform.TransformPoint (this.initLocalCorners.bottomRight);
			this.worldSpaceCorners.bottomLeft = this.transform.TransformPoint (this.initLocalCorners.bottomLeft);

			if (this.displayInEditor) {
				Color c = Color.green;
				Debug.DrawLine (this.worldSpaceCorners.topLeft, this.worldSpaceCorners.topRight, c);
				Debug.DrawLine (this.worldSpaceCorners.topRight, this.worldSpaceCorners.bottomRight, c);
				Debug.DrawLine (this.worldSpaceCorners.bottomRight, this.worldSpaceCorners.bottomLeft, c);
				Debug.DrawLine (this.worldSpaceCorners.bottomLeft, this.worldSpaceCorners.topLeft, c);
			}
		}

		/// <summary>
		/// Gets the top left corner in world space. 
		/// </summary>
		/// <returns>The top left corner.</returns>
		public Vector3 GetTopLeftCorner ()
		{
			return this.worldSpaceCorners.topLeft;
		}

		/// <summary>
		/// Gets the top right corner in world space. 
		/// </summary>
		/// <returns>The top right corner.</returns>
		public Vector3 GetTopRightCorner ()
		{
			return this.worldSpaceCorners.topRight;
		}

		/// <summary>
		/// Gets the bottom right corner in world space. 
		/// </summary>
		/// <returns>The bottom right corner.</returns>
		public Vector3 GetBottomRightCorner ()
		{
			return this.worldSpaceCorners.bottomRight;
		}

		/// <summary>
		/// Gets the bottom left corner in world space. 
		/// </summary>
		/// <returns>The bottom left corner.</returns>
		public Vector3 GetBottomLeftCorner ()
		{
			return this.worldSpaceCorners.bottomLeft;
		}

		private bool IsRectangle (ScreenCorners corners)
		{
			// checking if right angles
			// from a top left corner
			if (Vector3.Dot (this.initLocalCorners.topRight - this.initLocalCorners.topLeft, this.initLocalCorners.bottomLeft - this.initLocalCorners.topLeft) != 0.0f) {
				return false;
			}
			// from a top right corner
			if (Vector3.Dot (this.initLocalCorners.topLeft - this.initLocalCorners.topRight, this.initLocalCorners.bottomRight - this.initLocalCorners.topRight) != 0.0f) {
				return false;
			}
			// from a bottom right corner
			if (Vector3.Dot (this.initLocalCorners.topRight - this.initLocalCorners.bottomRight, this.initLocalCorners.bottomLeft - this.initLocalCorners.bottomRight) != 0.0f) {
				return false;
			}
			// from a bottom left corner
			if (Vector3.Dot (this.initLocalCorners.topLeft - this.initLocalCorners.bottomLeft, this.initLocalCorners.bottomRight - this.initLocalCorners.bottomLeft) != 0.0f) {
				return false;
			}

			// no need to check the distances; checking the right angles confirms that. 
			return true;
		}
	}
}