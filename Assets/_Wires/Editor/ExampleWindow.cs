using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
public class ExampleWindow : EditorWindow {

	Color color;


	List<Draggable> _draggables;

	[MenuItem("Window/Colorizer")]
	public static void ShowWindow ()
	{
		var window = GetWindow<ExampleWindow>("Colorizer");
		window._draggables = new List<Draggable>();
		window._draggables.Add(new Draggable());

	}


	class Draggable {
		Vector2Int position;
		public void Draw() {
        	EditorGUI.DrawRect(new Rect(10, 10, 160, 60), new Color(0.5f, 0.5f, 0.85f));
        	EditorGUI.DrawRect(new Rect(20, 20, 140, 40), new Color(0.9f, 0.9f, 0.9f));
        	EditorGUIUtility.AddCursorRect(new Rect(20, 20, 140, 40), MouseCursor.Zoom);
		}
	}
	void OnGUI ()
	{
		GUILayout.Label("Color the selected objects!", EditorStyles.boldLabel);

		color = EditorGUILayout.ColorField("Color", color);

		if (GUILayout.Button("COLORIZE!"))
		{
			Colorize();
		}

		foreach(Draggable d in _draggables) {
			d.Draw();
		}
	}

	void Colorize ()
	{
		foreach (GameObject obj in Selection.gameObjects)
		{
			Renderer renderer = obj.GetComponent<Renderer>();
			if (renderer != null)
			{
				renderer.sharedMaterial.color = color;
			}
		}
	}

}