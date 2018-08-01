using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace SculptingVis
{
    [ExecuteInEditMode]
    public class StyleController : MonoBehaviour
    {


        public void Reset()
        {
            Debug.Log("Reseting");
            GetLinks().Clear();


            GetLayers().Clear();
            GetVariables().Clear();
            GetVisualElements().Clear();





            // _variables.Add(ScriptableObject.CreateInstance<StyleDataVariable>().Init());
            // _variables.Add(ScriptableObject.CreateInstance<StyleDataVariable>().Init());
            // _variables.Add(ScriptableObject.CreateInstance<StyleDataVariable>().Init());
            // _variables.Add(ScriptableObject.CreateInstance<StyleDataVariable>().Init());

        }


		[SerializeField] 
		List<StyleLayer> _layerTypes;

        [SerializeField]
        List<StyleModule> _visualElements;

        [SerializeField]
        List<StyleModule> _layers;

		[SerializeField]
		Style _style;


        [SerializeField]
        List<StyleModule> _variables;


        [SerializeField]
        List<StyleLink> _links;

        [SerializeField]
        Dictionary<string, StyleLink> _linksByDestination;

        [SerializeField]
        Dictionary<string, List<StyleLink>> _linksBySource;

        protected Dictionary<string, StyleLink> GetLinksByDestination()
        {
            if (_linksByDestination == null) _linksByDestination = new Dictionary<string, StyleLink>();
            return _linksByDestination;
        }
        protected  StyleLink GetLinkByDestination(StyleSocket destinationsocket)
        {
            if (_linksByDestination == null) _linksByDestination = new Dictionary<string, StyleLink>();
			if(_linksByDestination.ContainsKey(destinationsocket.GetUniqueIdentifier()))
				return _linksByDestination[destinationsocket.GetUniqueIdentifier()];
            return null;
        }
        protected Dictionary<string, List<StyleLink> > GetLinksBySource()
        {
            if (_linksBySource == null) _linksBySource = new Dictionary<string, List<StyleLink> >();
            return _linksBySource;
        }
		

        public List<StyleLink> GetLinks()
        {
            if (_links == null) _links = new List<StyleLink>();
            return _links;
        }

		public void RemoveLink(StyleLink link, bool removeFromIndex = false) {
			if (link != null){
				Debug.Log("Removing link: " + link.GetSource().GetUniqueIdentifier() + " -> " + link.GetDestination().GetUniqueIdentifier());
				link.GetDestination().ClearInput();
                GetLinks().Remove(link);
				if(link.GetDestination() != null)
            		GetLinksByDestination()[link.GetDestination().GetUniqueIdentifier()] = null;
				if(removeFromIndex)
				GetLinksBySource()[link.GetSource().GetUniqueIdentifier()].Remove(link);
			
				UpdateModuleLinks(link.GetDestination().GetModule());
			}
		}
        public void ClearSocket(StyleSocket socket)
        {
			if(socket.IsInput()) {
				StyleLink currentLink = null;
				if (GetLinksByDestination().ContainsKey(socket.GetUniqueIdentifier()))
					currentLink = GetLinkByDestination(socket);
				RemoveLink(currentLink);
				if(currentLink != null)currentLink.GetDestination().GetModule().UpdateModule();

			} 
			if(socket.IsOutput()) {
				StyleLink currentLink = null;


				foreach(StyleLink link in GetLinksBySource()[socket.GetUniqueIdentifier()]) {
					RemoveLink(link, false);
				}

				GetLinksBySource()[socket.GetUniqueIdentifier()].Clear();

			}


        }
        public void AddLink(StyleLink link)
        {

            ClearSocket(link.GetDestination());

            GetLinks().Add(link);
            GetLinksByDestination()[link.GetDestination().GetUniqueIdentifier()] = link;
			if(!GetLinksBySource().ContainsKey(link.GetSource().GetUniqueIdentifier()))
				GetLinksBySource()[link.GetSource().GetUniqueIdentifier()] = new List<StyleLink>();
			GetLinksBySource()[link.GetSource().GetUniqueIdentifier()].Add(link);

			link.GetDestination().SetInputObject(link.GetSource().GetOutput());

			link.GetDestination().GetModule().UpdateModule();
        }


        public List<StyleModule> GetVisualElements()
        {
            if (_visualElements == null) _visualElements = new List<StyleModule>();

            return _visualElements;
        }

		public Style GetStyle() {
			if(_style == null) _style = ScriptableObject.CreateInstance<Style>();
			return _style;
		}

        public List<StyleLayer> GetLayers()
        {
            return GetStyle().GetLayers();
        }

        public List<StyleModule> GetVariables()
        {
            if (_variables == null) _variables = new List<StyleModule>();

            return _variables;
        }
        // Use this for initialization
        void Start()
        {
            


        }

		public void UpdateModuleLinks(StyleModule module) {
			for(int i = 0; i < module.GetNumberOfSockets(); i++) {
				StyleSocket socket = module.GetSocket(i);
				StyleLink link;
				if((link = GetLinkByDestination(socket))!=null){
					if(!link.GetDestination().DoesAccept(link.GetSource())) {
						RemoveLink(link);
					}

				}
			}
		}

        // Update is called once per frame
        void Update()
        {

        }

        public void LoadData(string path)
        {
            Debug.Log("Loading " + path);
            string extention = (Path.GetExtension(path));
            if (extention == "")
            {
                {
                    DirectoryInfo info = new DirectoryInfo(path);
                    FileInfo[] fileInfo = info.GetFiles();
                    foreach (var file in fileInfo)
                        LoadData(file.FullName);
                }


                {
                    DirectoryInfo info = new DirectoryInfo(path);
                    DirectoryInfo[] fileInfo = info.GetDirectories();
                    foreach (var file in fileInfo)
                        LoadData(file.FullName);
                }
            }

			else if(true) {
				// Texture2D loadedImage = new Texture2D(1,1);
				// loadedImage.LoadImage(File.ReadAllBytes(path));
				//GetVisualElements().Add(ScriptableObject.CreateInstance<StyleColormap>().Init(loadedImage,Path.GetFileNameWithoutExtension(path)));
				VTKDataset vtkds = VTKDataset.CreateInstance<VTKDataset>();
				vtkds.Init(path,0,0);
				if(vtkds.LoadDataset()) {
					Debug.Log("Loaded a VTK file! " + path);
				}

				for(int i = 0; i < vtkds.GetVariables().Length; i++) {
					GetVariables().Add(ScriptableObject.CreateInstance<StyleDataVariable>().Init(vtkds.GetVariables()[i]));
				}
				
				if(vtkds.GetAnchor() != null)
					GetVariables().Add(ScriptableObject.CreateInstance<StyleDataVariable>().Init(vtkds.GetAnchor()));
			}
        }

        public void LoadVisualElements(string path)
        {
            string extention = (Path.GetExtension(path));
            if (extention == "")
            {
                {
                    DirectoryInfo info = new DirectoryInfo(path);
                    FileInfo[] fileInfo = info.GetFiles();
                    foreach (var file in fileInfo)
                        LoadVisualElements(file.FullName);
                }


                {
                    DirectoryInfo info = new DirectoryInfo(path);
                    DirectoryInfo[] fileInfo = info.GetDirectories();
                    foreach (var file in fileInfo)
                        LoadVisualElements(file.FullName);
                }
            }

			else {
                VisualElement result = VisualElement.LoadFile(path);

                if(result != null)
				    GetVisualElements().Add(ScriptableObject.CreateInstance<StyleVisualElement>().Init(result));
			}
        }

        public string[] GetFileFilters()
        {
            List<string> filters = new List<string>();

            filters.Add("*.xml");
            filters.Add("*.json");
            filters.Add("*.png");
            filters.Add("*.obj");

            return filters.ToArray();
        }


		 int _selectedLayerTypeIndex = 0;
		public void SetLayerTypeToCreate(int layerTypeIndex) {
			_selectedLayerTypeIndex = layerTypeIndex;
		}
		public int GetLayerTypeToCreate() {
			return _selectedLayerTypeIndex;
		}
		public string[] GetLayerTypes() {
			string [] types =  new string[_layerTypes.Count];
			for(int i =0; i < _layerTypes.Count;i++) {
				types[i] = _layerTypes[i].GetLabel();
			}
			return types;
		}

		public void CreateLayer() {
            //_layers.Add(ScriptableObject.CreateInstance<StyleTestLayer>().Init());
			_style.AddLayer(((StyleLayer)ScriptableObject.CreateInstance(_layerTypes[GetLayerTypeToCreate()].GetType().ToString())).CopyLayer(_layerTypes[GetLayerTypeToCreate()]));

		}


		[SerializeField] Canvas _CanvasPrefab;
		[SerializeField] List<Canvas> _canvases;

		public List<Canvas> GetCanvases() {
			if(_canvases == null) _canvases = new List<Canvas>();
			return _canvases;
		}
		public void AddCanvas() {
			Canvas c = Instantiate(_CanvasPrefab);
			c.SetStyle(_style);
		   	GetCanvases().Add(c);
		}

		public void RemoveCanvas(Canvas canvas) {
			GetCanvases().Remove(canvas);
			DestroyImmediate(canvas.gameObject);
		}

		public void RemoveModule(StyleModule module) {
			if(module is StyleVisualElement) {
				GetVisualElements().Remove(module);
			} else if(module is StyleLayer) {
				GetLayers().Remove((StyleLayer)module);
			} else if(module is StyleDataVariable) {
				GetVariables().Remove(module);
			}


			for(int i = 0; i < module.GetNumberOfSockets(); i++) {
				StyleSocket socket = module.GetSocket(i);
				ClearSocket(socket);
				
			}

		}

    }

}
