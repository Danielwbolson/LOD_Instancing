using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class DataRenderer : MonoBehaviour
{


    void Update() {
        Material _material = _dataMaterial;
        _material.SetMatrix("_DataModelMatrix", GetLayer().GetDataObject().transform.localToWorldMatrix);
        _material.SetMatrix("_DataModelMatrixInv", GetLayer().GetDataObject().transform.worldToLocalMatrix);
        _material.SetMatrix("_DataBoundsMatrix", GetLayer().GetDataObject().GetBoundsMatrix());
        _material.SetMatrix("_DataBoundsMatrixInv", GetLayer().GetDataObject().GetBoundsMatrix().inverse);

        for(int v = 0; v < GetLayerRenderStrategy().GetVariableCount(); v++) {
            Vector4 min = GetLayerRenderStrategy().GetVariable(v).GetMinValue();
            Vector4 max = GetLayerRenderStrategy().GetVariable(v).GetMaxValue();
            _material.SetVector("_DataMin" + v, min);
            _material.SetVector("_DataMax" + v, max);
            _material.SetInt("_VariableStorage" + v, (int)GetLayerRenderStrategy().GetVariable(v).GetStorageType());
            _material.SetInt("_VariableType" + v, (int)GetLayerRenderStrategy().GetVariable(v).GetVariableType());

            if(GetLayerRenderStrategy().GetVariable(v).GetStorageType() == Variable.StorageType.TEXTURE) {
                Texture t = GetLayer().GetDataObject().GetImageDataTexture(GetLayer().GetLayerRenderStrategy().GetVariable(0).GetVariableIndex());
                _material.SetTexture("_DataVolume" + v, t);
            } else {
                
            }
        }
        //SetMaterialSource(_material);
        ApplyMaterial();
    }

    [SerializeField]
    LayerRenderStrategy _layerRenderStrategy;
    public void SetLayerRenderStrategy(LayerRenderStrategy renderStrategy) {
        _layerRenderStrategy = renderStrategy;
    }
    [SerializeField]
    Material _dataMaterial = null;
    
    public Material GetMaterial() {
        return _dataMaterial;
    }
    public virtual void ApplyMaterial() {
        
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
    public LayerRenderStrategy GetLayerRenderStrategy() {
        return _layerRenderStrategy;
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


    protected void LockTransform()
    {
        //Tools.hidden = true;
        transform.hideFlags = HideFlags.NotEditable | HideFlags.HideInInspector;
    }
    protected void UnlockTransform()
    {
        //Tools.hidden = false;
        transform.hideFlags = HideFlags.None;
    }

}