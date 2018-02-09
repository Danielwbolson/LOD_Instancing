using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

public class SliceMananger : MonoBehaviour
{
    public int xMax = 80;
    public int yMax = 96;
    public int zMax = 64;

    public float cylinderLength = 0.4f;
    public float zeppelinLength = 0.8f;

    public RangeMapper fRange = new RangeMapper(new Vector3(0f, 1f), new Vector2(0f, 1f));
    public RangeMapper rCylinderRange = new RangeMapper(new Vector3(0f, 20f), new Vector2(0.0f, 0.3f));
    public RangeMapper dPerpZeppelinRange = new RangeMapper(new Vector3(0f, 1f), new Vector2(0f, 1f));
    public RangeMapper faRange = new RangeMapper(new Vector3(0f, 1f), new Vector2(0f, 1f));

    [Space(10)]
    public GameObject baseVoxelCube;
    public GameObject container;
    public GameObject bgImageQuad;

    [Space(5)]
    public bool checkChildren = false;
    public Material cylinder1Mat;
    public Material cylinder2Mat;
    public Material zeppelinMat;

    private Texture2D bgTexture;

    void Start()
    {
        this.bgTexture = this.bgImageQuad.GetComponent<MeshRenderer>().material.mainTexture as Texture2D;

        { // color map 1
			byte[] bytes = File.ReadAllBytes(Application.streamingAssetsPath  + "/example_data/BrainVIS/BrainColorMaps/cylinder1.jpg");
            Texture2D texture = new Texture2D(512, 32);
            texture.LoadImage(bytes);
            this.cylinder1Mat.mainTexture = texture;
        }
        { // color map 2
			byte[] bytes = File.ReadAllBytes(Application.streamingAssetsPath  + "/example_data/BrainVIS/BrainColorMaps/cylinder2.jpg");
            Texture2D texture = new Texture2D(512, 32);
            texture.LoadImage(bytes);
            this.cylinder2Mat.mainTexture = texture;
        }
        { // color map 3
			byte[] bytes = File.ReadAllBytes(Application.streamingAssetsPath  + "/example_data/BrainVIS/BrainColorMaps/zeppelin.jpg");
            Texture2D texture = new Texture2D(512, 32);
            texture.LoadImage(bytes);
            this.zeppelinMat.mainTexture = texture;
        }

        // for testing
		this.OpenSlice(Application.streamingAssetsPath  + "/example_data/BrainVIS/BrainTensorData/Zep_cyl_cyl_32.txt");
    }

    public void OpenSlice(string filePath)
    {
        // 1) load data
        string[] lines = System.IO.File.ReadAllLines(filePath);
        // skip the first line, which is the header
        for (int l = 1; l < lines.Length; l++)
        {
            this.CreateVoxel(lines[l]);
        }

        //
        this.bgTexture.Apply();
    }

    public void Clear()
    {
        foreach (Transform child in this.container.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    public void SetThirdGlyphOpacity(float v)
    {
        Color c = this.zeppelinMat.GetColor("_Color");
        this.zeppelinMat.SetColor("_Color", new Color(c.r, c.g, c.b, v));
    }

    public void SetFirstGlyphVisibility(bool v)
    {
        this.SetGlyphVisibility(0, v);
    }

    public void SetSecondGlyphVisibility(bool v)
    {
        this.SetGlyphVisibility(1, v);
    }

    public void SetThirdGlyphVisibility(bool v)
    {
        this.SetGlyphVisibility(2, v);
    }

    public void SetBackgroundImageVisibility(bool v)
    {
        this.bgImageQuad.SetActive(v);
    }

    private void SetGlyphVisibility(int idx, bool v)
    {
        foreach (Transform child in this.container.transform)
        {
            TensorVoxelCube voxel = child.GetComponent<TensorVoxelCube>();
            if (voxel != null)
            {
                voxel.SetGlyphVisibility(idx, v);
            }
        }
    }

    private void CreateVoxel(string line)
    {
        string[] values = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        int x = (int)(float.Parse(values[0], CultureInfo.InvariantCulture)) - 1;
        int y = (int)(float.Parse(values[1], CultureInfo.InvariantCulture)) - 1;
        int z = (int)(float.Parse(values[2], CultureInfo.InvariantCulture)) - 1;

        float fa = float.Parse(values[3], CultureInfo.InvariantCulture);
        { // color the pixel on the background image
            float c = faRange.ToVisRange(fa);
            this.bgTexture.SetPixel(x, z, new Color(c, c, c));
        }

        // data for the first glyph
        int beginAt = 4;
        float f1 = float.Parse(values[beginAt], CultureInfo.InvariantCulture);
        Vector3 n1 = new Vector3(float.Parse(values[beginAt + 1], CultureInfo.InvariantCulture), float.Parse(values[beginAt + 2], CultureInfo.InvariantCulture), float.Parse(values[beginAt + 3], CultureInfo.InvariantCulture));
        float r1 = float.Parse(values[beginAt + 4], CultureInfo.InvariantCulture);
        // data for the second glyph
        beginAt = 9;
        float f2 = float.Parse(values[beginAt], CultureInfo.InvariantCulture);
        Vector3 n2 = new Vector3(float.Parse(values[beginAt + 1], CultureInfo.InvariantCulture), float.Parse(values[beginAt + 2], CultureInfo.InvariantCulture), float.Parse(values[beginAt + 3], CultureInfo.InvariantCulture));
        float r2 = float.Parse(values[beginAt + 4], CultureInfo.InvariantCulture);
        // data for the third glyph
        beginAt = 14;
        float f3 = float.Parse(values[beginAt], CultureInfo.InvariantCulture);
        Vector3 n3 = new Vector3(float.Parse(values[beginAt + 1], CultureInfo.InvariantCulture), float.Parse(values[beginAt + 2], CultureInfo.InvariantCulture), float.Parse(values[beginAt + 3], CultureInfo.InvariantCulture));
        float d_perp = float.Parse(values[beginAt + 4], CultureInfo.InvariantCulture);

        // skip the empty values
        if ((f1 <= 0f && r1 <= 0f) && (f2 <= 0f && r2 <= 0f) && (f3 <= 0f && d_perp <= 0f))
        {
            return;
        }

        // create a voxel
        TensorVoxelCube voxel = GameObject.Instantiate(this.baseVoxelCube).GetComponent<TensorVoxelCube>();
        voxel.Initialize(x, y, z);
        voxel.transform.localPosition = new Vector3((float)x - (float)(xMax / 2f), (float)0.0, (float)z - (float)(zMax / 2f));
        voxel.gameObject.name = x + "-" + y + "-" + z;
        voxel.transform.SetParent(this.container.transform, false);
        voxel.gameObject.SetActive(true);

        // update scalar value
        voxel.s = fa;

        // first glyph
        if (voxel.innerGlyphs.Length > 0)
        {
            TensorInnerGlyph glyph = voxel.innerGlyphs[0];
            glyph.Initialize(f1, n1, r1);
            {
                glyph.transform.localRotation = Quaternion.FromToRotation(new Vector3(0, 1, 0), glyph.n);
                float w = this.rCylinderRange.ToVisRange(glyph.r);
                glyph.transform.localScale = new Vector3(w, cylinderLength, w);

                // update the UVs of the mesh and its material
                Material mat = this.cylinder1Mat;
                this.SetUV(glyph.GetComponent<MeshFilter>(), glyph.f);
                this.SetMaterial(glyph.GetComponent<MeshRenderer>(), mat);
                // update the UVs of the mesh of the children and their material
                if (this.checkChildren)
                {
                    foreach (Transform child in glyph.transform)
                    {
                        this.SetUV(child.GetComponent<MeshFilter>(), glyph.f);
                        this.SetMaterial(child.GetComponent<MeshRenderer>(), mat);
                        if (child.childCount > 0)
                        {
                            foreach (Transform childChild in child)
                            {
                                this.SetUV(childChild.GetComponent<MeshFilter>(), glyph.f);
                                this.SetMaterial(childChild.GetComponent<MeshRenderer>(), mat);
                            }
                        }
                    }
                }
            }
        }

        // second glyph
        if (voxel.innerGlyphs.Length > 1)
        {
            TensorInnerGlyph glyph = voxel.innerGlyphs[1];
            glyph.Initialize(f2, n2, r2);
            {
                glyph.transform.localRotation = Quaternion.FromToRotation(new Vector3(0, 1, 0), glyph.n);
                float w = this.rCylinderRange.ToVisRange(glyph.r);
                glyph.transform.localScale = new Vector3(w, cylinderLength, w);

                // update the UVs of the mesh and its material
                Material mat = this.cylinder2Mat;
                this.SetUV(glyph.GetComponent<MeshFilter>(), glyph.f);
                this.SetMaterial(glyph.GetComponent<MeshRenderer>(), mat);
                // update the UVs of the mesh of the children and their material
                if (this.checkChildren)
                {
                    foreach (Transform child in glyph.transform)
                    {
                        this.SetUV(child.GetComponent<MeshFilter>(), glyph.f);
                        this.SetMaterial(child.GetComponent<MeshRenderer>(), mat);
                        if (child.childCount > 0)
                        {
                            foreach (Transform childChild in child)
                            {
                                this.SetUV(childChild.GetComponent<MeshFilter>(), glyph.f);
                                this.SetMaterial(childChild.GetComponent<MeshRenderer>(), mat);
                            }
                        }
                    }
                }
            }
        }

        // third glyph
        if (voxel.innerGlyphs.Length > 2)
        {
            TensorInnerGlyph glyph = voxel.innerGlyphs[2];
            glyph.Initialize(f3, n3, d_perp);
            {
                glyph.transform.localRotation = Quaternion.FromToRotation(new Vector3(0, 1, 0), glyph.n);
                float w = this.dPerpZeppelinRange.ToVisRange(glyph.r) * this.zeppelinLength;
                glyph.transform.localScale = new Vector3(w, this.zeppelinLength, w);

                // update the UVs of the mesh and its material
                Material mat = this.zeppelinMat;
                this.SetUV(glyph.GetComponent<MeshFilter>(), glyph.f);
                this.SetMaterial(glyph.GetComponent<MeshRenderer>(), mat);
                // update the UVs of the mesh of the children and their material
                if (this.checkChildren)
                {
                    foreach (Transform child in glyph.transform)
                    {
                        this.SetUV(child.GetComponent<MeshFilter>(), glyph.f);
                        this.SetMaterial(child.GetComponent<MeshRenderer>(), mat);
                        if (child.childCount > 0)
                        {
                            foreach (Transform childChild in child)
                            {
                                this.SetUV(childChild.GetComponent<MeshFilter>(), glyph.f);
                                this.SetMaterial(childChild.GetComponent<MeshRenderer>(), mat);
                            }
                        }
                    }
                }
            }
        }
    }

    // update the UVs of the mesh based on the f value.
    private void SetUV(MeshFilter meshFilter, float fValue)
    {
        if (meshFilter == null)
        {
            return;
        }
        Mesh mesh = meshFilter.mesh;
        if (mesh == null)
        {
            return;
        }

        Vector2[] uvs = mesh.uv;
        if (mesh.vertexCount != uvs.Length)
        {
            uvs = new Vector2[mesh.vertexCount];
        }
        float v = this.fRange.ToVisRange(fValue);
        for (int i = 0; i < uvs.Length; i++)
        {
            uvs[i].x = v;
            uvs[i].y = 0;
        }
        mesh.uv = uvs;
    }

    private void SetMaterial(MeshRenderer meshRenderer, Material mat)
    {
        if (meshRenderer == null)
        {
            return;
        }
        meshRenderer.material = mat;
    }

    [Serializable]
    public class RangeMapper
    {
        public Vector2 dataValueRange;
        public Vector2 visValueRange;

        public RangeMapper(Vector2 dataValueRange, Vector2 visValueRange)
        {
            this.dataValueRange = dataValueRange;
            this.visValueRange = visValueRange;
        }

        // http://forum.unity3d.com/threads/re-map-a-number-from-one-range-to-another.119437/
        public float ToVisRange(float dataValue)
        {
            return visValueRange.x + (dataValue - dataValueRange.x) * (visValueRange.y - visValueRange.x) / (dataValueRange.y - dataValueRange.x);
        }
    }
}
