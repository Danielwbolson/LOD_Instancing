using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRStyleMananger : MonoBehaviour {

    [SerializeField]
    GameObject _stylePanel;

    [SerializeField]
    Button label;

    [SerializeField]
    SculptingVis.StyleController _styleController;

    [SerializeField]
    [HideInInspector]
    List<SculptingVis.StyleLayer> _layers;

    [SerializeField]
    [HideInInspector]
    List<Button> _textLabels;

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

    // Refresh our shown layers
    public void RenewLayers(GameObject s) {
        // Create our header label
        _textLabels = new List<Button>();
        Button styleLabel = Instantiate(label, s.transform);
        styleLabel.transform.GetChild(0).GetComponent<Text>().text = "Styles";
        Vector3 pos = new Vector3(0, -40, 0);

        for (int i = 0; i < _layers.Count; i++) {
            // Create new layer button
            var l = _layers[i];
            Button newlabel = Instantiate(label, s.transform);

            // Set an id for future reference
            newlabel.GetComponent<LayerID>()._id = i;

            // Set text and position
            newlabel.transform.GetChild(0).GetComponent<Text>().text = l.GetLabel();
            newlabel.transform.localPosition += pos;
            pos += new Vector3(0, -40, 0);
            s.GetComponent<RectTransform>().offsetMin += new Vector2(0, -40);
            _textLabels.Add(newlabel);
        }
        _layerCount = _layers.Count;
    }
}
