using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlyphEmitter : MonoBehaviour {

    public GameObject _tree;

    int maxGlyphs = 100;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < maxGlyphs; i++) {
            GameObject myGlyph = Instantiate(_tree) as GameObject;

            myGlyph.transform.position = new Vector3(
                Random.Range(-20, 20),
                Random.Range(-20, 20),
                Random.Range(-20, 20));

            myGlyph.transform.localScale = new Vector3(
                Random.Range(0.05f, 0.2f),
                Random.Range(0.05f, 0.2f),
                Random.Range(0.05f, 0.2f));

            myGlyph.transform.parent = gameObject.transform;
        }
    }
    
    // Update is called once per frame
    void Update () {
        
    }
}
