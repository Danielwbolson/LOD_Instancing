using System.Collections;
using System.Collections.Generic;
using System.IO;
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
        LOD[] lodRanges = new LOD[3];
        Texture2D[] bumpMaps = new Texture2D[3];

        float[] lodSize = new float[3] { 0.7f, 0.4f, 0.06f };

        GameObject lodObj = OBJLoader.LoadOBJFile(_objectFolder + "/" + _meshName + ".obj");
        //GameObject highResObj = OBJLoader.LoadOBJFile(_objectFolder + "/" + _meshName + "_high_res.obj");

        for (int i = 0; i < 3; i++) {
            string filePath = _objectFolder + "/NormalMaps/LOD" + (i + 1) + ".png";
            bumpMaps[i] = TextureLoader.LoadTexture(filePath);
            //SetNormalMap(ref bumpMaps[i]);

            byte[] data = bumpMaps[i].EncodeToPNG();
            File.WriteAllBytes(Application.dataPath + "/Resources/GeneratedImages/LOD" + (i + 1) + ".png", data);
        }

        for (int i = 0; i < 3; i++) {
            GameObject lod = lodObj.transform.GetChild(i).gameObject;
            lod.GetComponent<MeshRenderer>().material = _mat;
            lod.GetComponent<MeshRenderer>().material.SetTexture("_BumpMap", bumpMaps[i]);

            Renderer[] r = new Renderer[1];
            r[0] = lod.GetComponent<MeshRenderer>();

            lodRanges[3 - 1 - i].renderers = r;
            lodRanges[3 - 1 - i].screenRelativeTransitionHeight = lodSize[3 - 1 - i];
        }

        lodObj.AddComponent<LODGroup>();
        LODGroup lodGroup = lodObj.GetComponent<LODGroup>();
        lodGroup.fadeMode = LODFadeMode.CrossFade;
        lodGroup.animateCrossFading = true;
        lodGroup.SetLODs(lodRanges);
    }

    public void SetNormalMap(ref Texture2D tex) {
        Color[] pixels = tex.GetPixels();
        for (int i = 0; i < pixels.Length; i++) {
            Color temp = pixels[i];
            temp.a = Mathf.Sqrt(temp.r) * 2 - 1;
            temp.a = temp.a * 0.5f + 0.54f;
            temp.g = Mathf.Sqrt(temp.g) * 2 - 1;
            temp.g = temp.g * 0.5f + 0.54f;
            temp.b = temp.g;
            temp.r = 1;

            pixels[i] = temp;
        }
        tex.SetPixels(pixels);
        tex.Apply(true);
    }
}
