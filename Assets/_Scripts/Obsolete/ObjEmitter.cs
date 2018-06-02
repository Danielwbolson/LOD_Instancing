using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjEmitter : MonoBehaviour {

    public GameObject _obj;
    public int _width, _height;

    private List<GameObject> _gameObjects;

    public int MAXSIZE;

    // Use this for initialization
    void Start () {
        _gameObjects = new List<GameObject>();
        Material _objMat = _obj.GetComponent<MeshRenderer>().sharedMaterial;
        _objMat.enableInstancing = false;

        for (int i = 0; i < MAXSIZE; i++) {
            Vector3 new_pos = new Vector3(Random.Range(-_width, _width), Random.Range(-_height, _height), 0);
            GameObject temp_obj = Instantiate(_obj, new_pos, Quaternion.identity) as GameObject;
            temp_obj.transform.parent = transform;
            temp_obj.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            _gameObjects.Add(temp_obj);

            Material mat = temp_obj.GetComponent<MeshRenderer>().material;

            Vector4 color = new Vector4(
                Random.Range(0.0f, 1.0f),
                Random.Range(0.0f, 1.0f),
                Random.Range(0.0f, 1.0f),
                1);
            mat.SetVector("color", color);

            float angle = Random.Range(0.0f, Mathf.PI * 2.0f);
            float distance = Random.Range(10.0f, 50.0f);
            float height = Random.Range(-2.0f, 2.0f);
            float size = Random.Range(0.05f, 0.25f);
            Vector4 position = new Vector4(Mathf.Sin(angle) * distance, height, Mathf.Cos(angle) * distance, size);

            temp_obj.transform.position = new Vector3(position[0], position[1], position[2]);
          
            float xScale = Random.Range(0.01f, 0.15f);
            float yScale = Random.Range(0.01f, 0.15f);
            float zScale = Random.Range(0.01f, 0.15f);

            temp_obj.transform.localScale = new Vector3(xScale, yScale, zScale);

        }
    }

    private void Update() {
        for (int i = 0; i < _gameObjects.Count; i++) {
            float rotation = _gameObjects[i].transform.localScale.magnitude * _gameObjects[i].transform.localScale.magnitude * Time.deltaTime * 100;
            _gameObjects[i].transform.RotateAround(Vector3.zero, Vector3.up, rotation);
        }
    }
}
