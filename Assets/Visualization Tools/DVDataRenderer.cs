using UnityEngine;
using System.Collections;

public class DVDataRenderer : MonoBehaviour
{
    public DVDataObject _dataObject = null;
    private DVDataObject _cachedDataObject = null;
    private bool _needsUpdate = false;

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


    protected void RequestUpdate()
    {
        _needsUpdate = true;
    }

    private void _refreshDataSet()
    {
        // Call the virtual Refresh method
        RefreshDataSet();


        _cachedDataObject = _dataObject;
        _needsUpdate = false;
    }

    virtual protected void RefreshDataSet() {}


    virtual protected void UpdateDataRenderer(){}

	// Use this for initialization
	void Start() {}

	// Update is called once per frame
	void Update()
	{
        if (!_dataObject)
            return;

        if (_cachedDataObject != _dataObject)
            RequestUpdate();

        if (_needsUpdate)
            _refreshDataSet();
        

        UpdateDataRenderer();
	}
}
