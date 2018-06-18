using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class DataRenderer : MonoBehaviour
{

    LayerRenderStrategy _layerRenderStrategy;
    public void SetLayerRenderStrategy(LayerRenderStrategy renderStrategy) {
        _layerRenderStrategy = renderStrategy;
    }
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

    // public void SetLayer(Layer layer) {
    //     _layer = layer;
    // }

    public Layer GetLayer() {
        if(_layerRenderStrategy == null) return null;
        return _layerRenderStrategy.GetLayer();
    }


    bool destroying = false;
    bool destroyed = false;
    public void Destroy() {
        if(!destroying) {
            destroying = true;
            if(GetLayer() != null)
                GetLayer().Destroy();
            if(!destroyed) {
                if(Application.isEditor)
                    DestroyImmediate(this.gameObject);
                else
                    Destroy(this.gameObject);
            }
               
        }
     
        
    }

    void OnDestroy() {
        destroyed = true;
        Destroy();
    }
}