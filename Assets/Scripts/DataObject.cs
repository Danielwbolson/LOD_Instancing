using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataObject : MonoBehaviour
{
	public Data data = null;
	public float scaleFactor = 1;
	public bool shouldNormalize = true;

	LineRenderer boundingBox;

	void Start ()
	{
		gameObject.GetComponent<LineRenderer> ().enabled = false;
	
	}

	protected void updateBounds ()
	{
			
		Vector3[] corners = new Vector3[8];
		corners [0] = new Vector3 (-1, 1, -1);
		corners [1] = new Vector3 (1, 1, -1);
		corners [2] = new Vector3 (-1, -1, -1);
		corners [3] = new Vector3 (1, -1, -1); 
	
	
		corners [4] = new Vector3 (-1, 1, 1);
		corners [5] = new Vector3 (1, 1, 1);
		corners [6] = new Vector3 (-1, -1, 1);
		corners [7] = new Vector3 (1, -1, 1);
	
		Vector3[] linePositions = new Vector3[16];
		Vector3 data_center = data.getBoundingCenter ();
		Vector3 data_size = data.getBoundingSize ();

		linePositions [0] = (data_center + Vector3.Scale (data_size, corners [0]) * 0.5f);
		linePositions [1] = (data_center + Vector3.Scale (data_size, corners [2]) * 0.5f);
		linePositions [2] = (data_center + Vector3.Scale (data_size, corners [3]) * 0.5f);
		linePositions [3] = (data_center + Vector3.Scale (data_size, corners [1]) * 0.5f);
		linePositions [4] = (data_center + Vector3.Scale (data_size, corners [0]) * 0.5f);
		linePositions [5] = (data_center + Vector3.Scale (data_size, corners [4]) * 0.5f);
		linePositions [6] = (data_center + Vector3.Scale (data_size, corners [5]) * 0.5f);
		linePositions [7] = (data_center + Vector3.Scale (data_size, corners [1]) * 0.5f);
		linePositions [8] = (data_center + Vector3.Scale (data_size, corners [3]) * 0.5f);
		linePositions [9] = (data_center + Vector3.Scale (data_size, corners [7]) * 0.5f);
		linePositions [10] = (data_center + Vector3.Scale (data_size, corners [5]) * 0.5f);
		linePositions [11] = (data_center + Vector3.Scale (data_size, corners [4]) * 0.5f);
		linePositions [12] = (data_center + Vector3.Scale (data_size, corners [6]) * 0.5f);
		linePositions [13] = (data_center + Vector3.Scale (data_size, corners [2]) * 0.5f);
		linePositions [14] = (data_center + Vector3.Scale (data_size, corners [6]) * 0.5f);
		linePositions [15] = (data_center + Vector3.Scale (data_size, corners [7]) * 0.5f);
		boundingBox = gameObject.GetComponent<LineRenderer> ();
		boundingBox.positionCount = linePositions.Count ();
		boundingBox.SetPositions (linePositions);
		boundingBox.enabled = true;
	
	}

	private float t = 1.0f;

	void Update ()
	{
		if (data == null)
			return;
		
		Vector3 data_center = data.getBoundingCenter ();
		Vector3 data_size = data.getBoundingSize ();

		scaleFactor = 1f;
		if (!shouldNormalize) {
			t -= 0.5f * Time.deltaTime;
		} else {
			t += 0.5f * Time.deltaTime;
		}
		t = Mathf.Clamp (t, 0f, 1f);
		unsafe {
			if (data.Valid ()) {
		
				float[] sizes = { data_size.x, data_size.y, data_size.z };
				float extremum = sizes.Max ();
				scaleFactor = Mathf.SmoothStep (1f, 1f / extremum, t);
	
			}
		}
	
	
		gameObject.transform.localPosition = -data_center * scaleFactor;
	
		gameObject.transform.localScale = new Vector3 (scaleFactor, scaleFactor, scaleFactor);

		updateBounds ();
		//gameObject.transform
	
	}

	public void setShouldNormalize (bool n)
	{
		shouldNormalize = n;
	
	}
}
