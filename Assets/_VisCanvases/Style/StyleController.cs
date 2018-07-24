using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis{
	[ExecuteInEditMode]
	public class StyleController : MonoBehaviour {


		public void Reset() {
			Debug.Log("Reseting");
			GetLinks().Clear();
						
			
			GetLayers().Clear();
			GetVariables().Clear();
			GetVisualElements().Clear();


			
			for(int i = 0; i < 20; i++) {
				StyleModule module = ScriptableObject.CreateInstance<StyleModule>();
				module.AddSocket();
				GetVisualElements().Add(module);


			}


			for(int i = 0; i < 5; i++) {
				StyleModule module = new StyleModule();
				module.AddSocket();
				module.AddSocket();
				module.AddSocket();
				module.AddSocket();

				_layers.Add(module);
				
			}

		}

		[SerializeField]
		List<StyleModule> _visualElements;
		
		[SerializeField]
		List<StyleModule> _layers;

		[SerializeField]
		List<StyleModule> _variables;


		[SerializeField]
		List<StyleLink> _links;



		public List<StyleLink> GetLinks() {
			if(_links == null) _links = new List<StyleLink>();
			return _links;
		}
		public void AddLink(StyleLink link) {
			GetLinks().Add(link);
		} 

		public List<StyleModule> GetVisualElements() {
			if(_visualElements == null) _visualElements = new List<StyleModule>();

			return _visualElements;
		}

		public List<StyleModule> GetLayers() {
			if(_layers == null) _layers = new List<StyleModule>();

			return _layers;
		}

		public List<StyleModule> GetVariables() {
			if(_variables == null) _variables = new List<StyleModule>();

			return _layers;
		}
		// Use this for initialization
		void Start () {


			
		}
		
		// Update is called once per frame
		void Update () {
			
		}
	}

}
