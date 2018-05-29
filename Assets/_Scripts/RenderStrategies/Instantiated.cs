using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiated : RenderStrategy {

    private List<GameObject> _gameObjects;

    public Instantiated(GameObject p, GameObject o, Material mat, List<Vector3> poses, int total) : 
        base(p, o, mat, poses, total) {
        _gameObjects = new List<GameObject>();
        _objMat.enableInstancing = false;

        for (int i = 0; i < TOTALOBJECTS; i++) {
            // Instantiate object and set parent
            GameObject temp_obj = GameObject.Instantiate(_obj) as GameObject;
            temp_obj.transform.parent = _parent.transform;
            _gameObjects.Add(temp_obj);

            // Set our materials for each LOD mesh
            MeshRenderer[] _MeshArray = temp_obj.GetComponentsInChildren<MeshRenderer>();
            Material[] _tempMatArray = new Material[_MeshArray.Length];
            for (int j = 0; j < _tempMatArray.Length; j++) {
                _tempMatArray[j] = _MeshArray[j].material;
            }

            // Get and set our colors for each LOD mesh
            Vector4[] color = new Vector4[_MeshArray.Length];
            for (int j = 0; j < color.Length; j++) {
                color[j] = new Vector4(
                    Mathf.Clamp(0 + j * (1f / (color.Length - 1)), 0, 1),
                    Mathf.Clamp(1 - j * (1f / (color.Length - 1)), 0, 1),
                    0,
                    1);
                _tempMatArray[j].SetVector("color", color[j]);
            }

            // Set our position based on what was passed in
            temp_obj.transform.position = _objPositions[i];

            // Set our random scale
            float xScale = Random.Range(0.01f, 0.15f);
            float yScale = Random.Range(0.01f, 0.15f);
            float zScale = Random.Range(0.01f, 0.15f);
            temp_obj.transform.localScale = new Vector3(xScale, yScale, zScale);
        }
    }

    public override void UpdateObjects() {
        RotatePositions();
    }

    public void RotatePositions() {
        for (int i = 0; i < TOTALOBJECTS; i++) {
            float rotation = _gameObjects[i].transform.localScale.magnitude * _gameObjects[i].transform.localScale.magnitude * Time.deltaTime * 100;
            _objPositions[i] = Quaternion.AngleAxis(rotation, Vector3.up) * _objPositions[i];
            _gameObjects[i].transform.position = _objPositions[i];
        }
    }

    public override void Destroy() {
        foreach (GameObject g in _gameObjects) {
            GameObject.Destroy(g);
        }
    }
}
