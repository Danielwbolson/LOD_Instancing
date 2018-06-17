using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;


[System.Serializable]
public abstract class LayerDataStrategy : Strategy {
	public LayerDataStrategy(Layer layer) : base(layer) {}
	public abstract Bounds GetBounds();
	public virtual DataObject GetDataObject() {return null;}
	public virtual DataObject [] GetDataObjects() {return null;}

}