using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRStyleMananger : MonoBehaviour {

    [SerializeField]
    GameObject _stylePanel;

    [SerializeField]
    Text label;

    [SerializeField]
    SculptingVis.StyleController _styleController;

    [SerializeField]
    [HideInInspector]
    List<SculptingVis.StyleLayer> _layers;

    [SerializeField]
    [HideInInspector]
    List<Text> _textLabels;

    private int _layerCount = -1;

    // Use this for initialization
    void Start() {
        _styleController = GetStyleController();
        _layers = _styleController.GetLayers();

        _stylePanel = FindObjectOfType<Canvas>().transform.Find("StylePanel").gameObject;
    }

    // Update is called once per frame
    void Update() {
        // if We have new layers
        if (_layerCount != _layers.Count) {
            DestroyChildren(_stylePanel.transform);
            RenewLayers(_stylePanel);
        }
    }

    static SculptingVis.StyleController GetStyleController() {
        return (SculptingVis.StyleController)FindObjectOfType(typeof(SculptingVis.StyleController));
    }

    public static void DestroyChildren(Transform transform) {
        for (int i = transform.childCount - 1; i >= 0; --i) {
            Destroy(transform.GetChild(i).gameObject);
        }
        transform.DetachChildren();
        transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }

    public void RenewLayers(GameObject s) {
        _textLabels = new List<Text>();
        Text styleLabel = Instantiate(label, s.transform);
        styleLabel.text = "Styles";
        Vector3 pos = new Vector3(0, -40, 0);
        foreach (var l in _layers) {
            Text newlabel = Instantiate(label, s.transform);
            newlabel.text = l.GetLabel();
            newlabel.transform.localPosition += pos;
            pos += new Vector3(0, -40, 0);
            s.GetComponent<RectTransform>().offsetMin += new Vector2(0, -40);
            _textLabels.Add(newlabel);
        }
        _layerCount = _layers.Count;
    }
}
