using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class UILayerToggle : MonoBehaviour {

    private int _buttonID;
    private SculptingVis.StyleController _sc;
    private List<SculptingVis.StyleLayer> _layers;

    public void OnClick() {
        GameObject clickedButton = EventSystem.current.currentSelectedGameObject;
        _buttonID = clickedButton.GetComponent<LayerID>()._id;

        _sc = GetStyleController();
        _layers = _sc.GetLayers();
        _layers[_buttonID]._toggled = !_layers[_buttonID]._toggled;
    }

    static SculptingVis.StyleController GetStyleController() {
        return (SculptingVis.StyleController)FindObjectOfType(typeof(SculptingVis.StyleController));
    }
}
