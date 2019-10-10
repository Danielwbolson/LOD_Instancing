using UnityEngine;
using System.Collections;
//using zSpace.Core;

using MultimodalReg;

public class ModelManagerVive : MonoBehaviour
{
    public ModelAligner[] aligners;
    public GameObject[] models;
    public Light[] lights;

   // public ArrayOftextures heartTex;

    private Vector3[] initPoses;
    private Quaternion[] initRots;
    private Vector3[] initScales;

    void Start()
    {
        int currIdx = 0;
        for (int i = 0; i < this.models.Length; i++)
        {
            this.aligners[i].gameObject.SetActive(i == currIdx);
            this.models[i].SetActive(i == currIdx);
            this.lights[i].gameObject.SetActive(i == currIdx);
        }

        this.initPoses = new Vector3[this.models.Length];
        this.initRots = new Quaternion[this.models.Length];
        this.initScales = new Vector3[this.models.Length];

        for (int i = 0; i < this.models.Length; i++)
        {
            this.initPoses[i] = this.models[i].transform.position;
            this.initRots[i] = this.models[i].transform.rotation;
            this.initScales[i] = this.models[i].transform.localScale;
        }

     //   heartTex.Load();
    }

    public void ResetModels()
    {
        for (int i = 0; i < this.models.Length; i++)
        {
            this.models[i].transform.position = this.initPoses[i];
            this.models[i].transform.rotation = this.initRots[i];
            this.models[i].transform.localScale = this.initScales[i];
        }
    }

    public void SetVisibility(int idx)
    {
        for (int i = 0; i < this.models.Length; i++)
        {
            this.aligners[i].gameObject.SetActive(i == idx);
            this.models[i].SetActive(i == idx);
            this.lights[i].gameObject.SetActive(i == idx);
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
