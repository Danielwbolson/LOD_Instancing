using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshLoader : MonoBehaviour {

    [SerializeField]
    string _objectFolder;
     
    [SerializeField]
    string _meshName;

    [SerializeField]
    Material _mat;

    // Use this for initialization
    void Start () {

    }

    public void LoadMesh() {
        LOD[] lodRanges = new LOD[4];
        Texture[] bumpMaps = new Texture[3];

        float[] lodSize = new float[4] { 0.7f, 0.4f, 0.15f, 0.06f };

        GameObject lodObj = OBJLoader.LoadOBJFile(_objectFolder + "/" + _meshName + ".obj");
        GameObject highResObj = OBJLoader.LoadOBJFile(_objectFolder + "/" + _meshName + "_high_res.obj");

        for (int i = 0; i < 3; i++) {
            string filePath = _objectFolder + "/NormalMaps/LOD" + (3 - i) + ".png";
            bumpMaps[i] = TextureLoader.LoadTexture(filePath, true);
        }

        for (int i = 0; i < 4; i++) {
            GameObject lod = lodObj.transform.GetChild(i).gameObject;
            lod.GetComponent<MeshRenderer>().material = _mat;

            if (i < 3) {
                lod.GetComponent<MeshRenderer>().material.SetTexture("_BumpMap", bumpMaps[i]);
            }

            Renderer[] r = new Renderer[1];
            r[0] = lod.GetComponent<MeshRenderer>();

            lodRanges[4 - 1 - i].renderers = r;
            lodRanges[4 - 1 - i].screenRelativeTransitionHeight = lodSize[4 - 1 - i];
        }

        lodObj.AddComponent<LODGroup>();
        LODGroup lodGroup = lodObj.GetComponent<LODGroup>();
        lodGroup.fadeMode = LODFadeMode.CrossFade;
        lodGroup.animateCrossFading = true;
        lodGroup.SetLODs(lodRanges);
    }
    
}
