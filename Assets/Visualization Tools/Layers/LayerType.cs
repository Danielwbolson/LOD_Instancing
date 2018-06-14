using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;


[CreateAssetMenu()]
public class LayerTypeSet : ScriptableObject {
	
	public List<LayerType> layerTypes;

}

[Serializable]
public abstract class Strategy {
	Layer _layer;
	public Layer GetLayer() {
		return _layer;
	}
	public Strategy(Layer layer) {
		_layer = layer;
	}
	public virtual void Destroy() { isDestroyed = true;}
	private bool isDestroyed = false;
	 ~Strategy() {
		//if(!isDestroyed)
		//	Destroy();
	}
	public abstract void RenderGUI();

}
public abstract class StrategyFactory<T> : ScriptableObject {
	private Layer _layer;

	public abstract T Create(Layer layer);
	public void SetLayer(Layer l) {
		_layer = l;
	}

}
public abstract class LayerDataStrategy : Strategy {
	public LayerDataStrategy(Layer layer) : base(layer) {}
	public virtual VTK.vtkDataSet GetDataset() {return IntPtr.Zero;}
	public abstract Bounds GetBounds();
	public virtual DV.DVDataObject GetDataObject() {return null;}
}

public class PlaceholderLayerDataStrategy : LayerDataStrategy {
	public PlaceholderLayerDataStrategy(Layer layer) : base(layer) {}
	public override Bounds GetBounds() {
		return new Bounds(new Vector3(0,0,0), new Vector3(1,1,1));
	}
	public override void RenderGUI() {
		GUILayout.BeginVertical();
		GUILayout.BeginHorizontal();
		GUILayout.Label("This layer type does not have any data settings.");
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
	}


}

public class Image3DLayerDataStrategy : LayerDataStrategy {
	public Image3DLayerDataStrategy(Layer layer, Database database) : base(layer) {
		
		_database = database;
	}
	public override VTK.vtkDataSet GetDataset() {return _dataSet;}
	public override DV.DVDataObject GetDataObject() {return _dataObject;}
	[SerializeField]
	Database	_database;
	DV.DVDataObject _dataObject;
	
	List<VTK.vtkDataSet> GetDatasets() {
		List<VTK.vtkDataSet> datasets = new List<VTK.vtkDataSet>();

		for(int i = 0; i < _database.GetDatasetCount(); i++) {
			if(_database._datasets[i].IsA("vtkImageData"))
				datasets.Add(_database._datasets[i]);
		}

		return datasets;
	}
	VTK.vtkDataSet _dataSet = IntPtr.Zero;
	string _datasetName = "";

	void SetDataset(int index) {
		_dataSet = _database._datasets[index];
		_datasetName = _database._datasetNames[index];
		_dataObject = _database._dataObjects[index];
		GetLayer().GetData().SetDataSet(_dataSet);
		
	}

	public override Bounds GetBounds() {
		if(!_dataSet.IsVoid())
			return _dataSet.GetBounds();
		else 
			return new Bounds(new Vector3(0,0,0), new Vector3(1,1,1));
	}
	public override void RenderGUI() {
		GUILayout.BeginVertical();
		GUILayout.BeginHorizontal();
		List<VTK.vtkDataSet> datasets = GetDatasets();
		if(datasets.Count == 0) {
			GUILayout.Label("No image datasets available.");
		} else {
			string[] options = new string[datasets.Count];

			for(int i  = 0; i < datasets.Count; i++) {
				options[i] = _database._datasetNames[i];
			}
			int selected = 0;
			int s = 0;
			foreach (string x in options)
			{
				if (x.Equals (_datasetName))
				{
					selected = s; 
				}
				s++;
			}
			int s2 = selected;
			selected = EditorGUILayout.Popup("Choose dataset:", selected, options);
			if(selected != s2 || (_dataSet.IsVoid() && options.Length > 0) ){
				Debug.Log(s2 + " " + selected.ToString());
				SetDataset(selected);

			} 
		}
	  

		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
	}

}


public abstract class LayerDataStrategyFactory : StrategyFactory<LayerDataStrategy> {}




public abstract class LayerRenderStrategy : Strategy {
	public LayerRenderStrategy(Layer layer): base(layer) {}
}

public class PlaceholderLayerRenderStrategy  : LayerRenderStrategy {
	public PlaceholderLayerRenderStrategy(Layer layer): base(layer) {}

	public override void RenderGUI() {
		GUILayout.BeginVertical();
		GUILayout.BeginHorizontal();
		GUILayout.Label("This layer type does not have any render settings.");
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
	}

}

public class SliceLayerRenderStrategy  : LayerRenderStrategy {

	public SliceLayerRenderStrategy(Layer layer, GameObject slicePrefab): base(layer) {
		_slicePrefab = slicePrefab;
		_slice = UnityEngine.Object.Instantiate(_slicePrefab);
		_slice.GetComponent<DV.DVDataSliceLayer>()._layer = layer;

		}
	public override void Destroy(){
		base.Destroy();
		UnityEngine.Object.DestroyImmediate(_slice);

	}

	GameObject _slicePrefab;
	GameObject _slice;
	string selectedArray; 
	
	void SetArray(int array) {
		_slice.GetComponent<DV.DVDataSliceLayer>()._arrayId = array;
	}
	public override void RenderGUI() {
		GUILayout.BeginVertical();
		GUILayout.BeginHorizontal();
			VTK.vtkDataSet ds = GetLayer().GetLayerDataStrategy().GetDataset();
			VTK.vtkPointData pd = ds.GetPointData();
			int numArrays = pd.GetNumberOfArrays();
			
			string[] options = new string[numArrays];

			for(int i  = 0; i < numArrays; i++) {
				options[i] = pd.GetArrayName(i);
			}
			int selected = 0;
			int s = 0;
			foreach (string x in options)
			{
				if (x.Equals (selectedArray))
				{
					selected = s; 
				}
				s++;
			}
			int s2 = selected;
			selected = EditorGUILayout.Popup("Choose variable:", selected, options);
			if(selected != s2){
				Debug.Log(s2 + " " + selected.ToString());
				SetArray(selected);
					selectedArray =  options[selected];
			} 


		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.Label("You'll need to pick a colormap");
		GUILayout.EndHorizontal();

		GUILayout.EndVertical();
	}

}

[CreateAssetMenu()]
public class Image3DLayerDataStrategyFactory : LayerDataStrategyFactory {
	[SerializeField]
	Database _database;
	public override LayerDataStrategy Create(Layer layer) {
		return new Image3DLayerDataStrategy(layer, _database);
	}
}

[CreateAssetMenu()]
public class SliceLayerRenderStrategyFactory : LayerRenderStrategyFactory {
	[SerializeField]
	GameObject _slicePrefab;
	
	public override LayerRenderStrategy Create(Layer layer) {
		return new SliceLayerRenderStrategy(layer, _slicePrefab);
	}
}


public abstract class LayerRenderStrategyFactory : StrategyFactory<LayerRenderStrategy>  {}

[CreateAssetMenu()]
public class PlaceholderLayerRenderStrategyFactory : LayerRenderStrategyFactory  {
		public override LayerRenderStrategy Create(Layer layer) {
		return new PlaceholderLayerRenderStrategy(layer);
	}
}

[CreateAssetMenu()]
public class PlaceholderLayerDataStrategyFactory : LayerDataStrategyFactory {
	public override LayerDataStrategy Create(Layer layer) {
		return new PlaceholderLayerDataStrategy(layer);
	}
}




[CreateAssetMenu()]
public class LayerType : ScriptableObject {
	[SerializeField]
	private string _name;

	public string GetName() {return _name;}
	[SerializeField]
	private LayerDataStrategyFactory _dataStrategyFactory;

	public LayerDataStrategy CreateDataStrategy(Layer layer) {
		return _dataStrategyFactory != null ? _dataStrategyFactory.Create(layer) : null;
	}
	[SerializeField]
	private LayerRenderStrategyFactory _renderStrategyFactory;
	public LayerRenderStrategy CreateRenderStrategy(Layer layer) {
		return _renderStrategyFactory != null ? _renderStrategyFactory.Create(layer) : null;
	}
}

[Serializable]
public class Layer {

		DV.DVDataObject _dataObject = null;
	
	public DV.DVDataObject GetData() {
		if(_dataObject == null) {
			_dataObject = _layerDataStrategy.GetDataObject();
		}	
		return _dataObject;
	}
	public LayerRenderStrategy GetLayerRenderStrategy() {
		return _layerRenderStrategy;
	}
	public LayerDataStrategy GetLayerDataStrategy() {
		return _layerDataStrategy;
	}
	public Layer(LayerManager layerManager) {
		_layerManager = layerManager;
	}
	private LayerManager _layerManager;
	private LayerType _type;

	private LayerRenderStrategy _layerRenderStrategy;
	private LayerDataStrategy _layerDataStrategy;
	

	public void SetLayerType(LayerType type) {
		_type = type;
		_layerRenderStrategy = type.CreateRenderStrategy(this);
		_layerDataStrategy = type.CreateDataStrategy(this);
	}
	public string GetLayerTypeName() {return _type != null ? _type.GetName() : "No type specified"; }


	public void RenderGUI() {
		EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
		if(_layerDataStrategy!=null) _layerDataStrategy.RenderGUI();
		EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
		if(_layerRenderStrategy!=null)_layerRenderStrategy.RenderGUI();

    }

	public void Destroy() {
		Debug.Log("Removing layer " + this );
		_layerDataStrategy.Destroy();
		_layerRenderStrategy.Destroy();
	}


	 ~Layer()
    {
        Destroy();
    }
}