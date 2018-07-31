using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MeshLoader : MonoBehaviour {

    [SerializeField]
    string _objectFolder;
    //D:/Daniel Olson/Desktop/CL_Hiaku_disk1
    //C:/Users/Daniel/Desktop/Blossomp2

    [SerializeField]
    string _meshName;

    [SerializeField]
    Material _mat;

    [SerializeField]
    GameObject _loadedMesh;

    private bool _somethingLoaded;

    // Use this for initialization
    void Start () {
        _somethingLoaded = false;
    }

    private void Update() {
        if (_somethingLoaded) {
            for (int i = 0; i < 20; i++) {
                GameObject temp = Instantiate(_loadedMesh) as GameObject;
                temp.transform.position = new Vector3(
                    Random.Range(-10, 10),
                    Random.Range(-10, 10),
                    Random.Range(-10, 10));
            }
            _somethingLoaded = false;
        }
    }

    public void LoadMesh() {
        LOD[] lodRanges = new LOD[3];
        Texture2D[] bumpMaps = new Texture2D[3];

        float[] lodSize = new float[3] { 0.7f, 0.4f, 0.06f };

        // Load our LOD mesh and switch the ordering of the children
        GameObject lodObj = OBJLoader.LoadOBJFile(_objectFolder + "/" + _meshName + ".obj");
        ReverseChildren(ref lodObj);
        //GameObject highResObj = OBJLoader.LoadOBJFile(_objectFolder + "/" + _meshName + "_high_res.obj");

        // Load and save our bump maps
        for (int i = 0; i < 3; i++) {
            string filePath = _objectFolder + "/NormalMaps/LOD" + i + ".png";
            bumpMaps[i] = TextureLoader.LoadTexture(filePath);

            byte[] data = bumpMaps[i].EncodeToPNG();
            string normalMapsFilePath = Application.dataPath + "/Resources/Generated/" + _meshName + "/NormalMaps/";
            if (File.Exists(normalMapsFilePath)) {
                File.WriteAllBytes(normalMapsFilePath + "/LOD" + i + ".png", data);
            } else {
                Directory.CreateDirectory(normalMapsFilePath);
                File.WriteAllBytes(normalMapsFilePath + "/LOD" + i + ".png", data);
            }
        }

        // Set up and save our lod meshe
        for (int i = 0; i < 3; i++) {
            GameObject lod = lodObj.transform.GetChild(i).gameObject;
            lod.GetComponent<MeshRenderer>().material = _mat;
            lod.GetComponent<MeshRenderer>().material.SetTexture("_BumpMap", bumpMaps[i]);

            Renderer[] r = new Renderer[1];
            r[0] = lod.GetComponent<MeshRenderer>();

            lodRanges[i].renderers = r;
            lodRanges[i].screenRelativeTransitionHeight = lodSize[i];

            SaveMesh(Application.dataPath + "/Resources/Generated/" + _meshName + "/" + _meshName + "_LOD" + (i) + ".obj", lod.GetComponent<MeshFilter>().mesh);
        }

        lodObj.AddComponent<LODGroup>();
        LODGroup lodGroup = lodObj.GetComponent<LODGroup>();
        lodGroup.fadeMode = LODFadeMode.CrossFade;
        lodGroup.animateCrossFading = true;
        lodGroup.SetLODs(lodRanges);

        _loadedMesh = lodObj;
        _somethingLoaded = true;

        GameObject temp = GameObject.CreatePrimitive(PrimitiveType.Cube);
        temp.GetComponent<MeshFilter>().mesh = LoadMesh(Application.dataPath + "/Resources/Generated/" + _meshName + "_LOD3.obj");
        temp.GetComponent<MeshRenderer>().material = _mat;
    }

    public void SaveMesh(string filepath, Mesh mesh) {
        string path = Path.Combine(Application.persistentDataPath, filepath);
        byte[] bytes = B83.MeshTools.MeshSerializer.SerializeMesh(mesh);
        File.WriteAllBytes(path, bytes);
    }

    public Mesh LoadMesh(string filepath) {
        string path = Path.Combine(Application.persistentDataPath, filepath);
        if (File.Exists(path)) {
            byte[] bytes = File.ReadAllBytes(path);
            return B83.MeshTools.MeshSerializer.DeserializeMesh(bytes);
        }
        return null;
    }

    public void ReverseChildren(ref GameObject obj) {
        for (int i = 1; i < obj.transform.childCount; i++) {
            obj.transform.GetChild(0).SetSiblingIndex(obj.transform.childCount - i);
        }
    }
}
