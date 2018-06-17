using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class DataRenderer : MonoBehaviour
{

    [SerializeField]
    Layer _layer;

    [SerializeField]
    Material _dataMaterial = null;
    
    public Material GetMaterial() {
        return _dataMaterial;
    }
    public void SetMaterialSource(Material material) {
        if(_dataMaterial != null) 
            if(Application.isEditor) 
                DestroyImmediate(_dataMaterial);
            else
                Destroy(_dataMaterial);

        _dataMaterial = Instantiate(material);
        
    }

    public virtual void RefreshData() {
        
    }

    public void SetLayer(Layer layer) {
        _layer = layer;
    }

    public Layer GetLayer() {
        return _layer;
    }


    public void Destroy() {
        if(Application.isEditor)
            DestroyImmediate(this);
        else
            Destroy(this);
    }
}