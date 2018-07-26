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
        List<StyleModule> _visualElements;

        [SerializeField]
        List<StyleModule> _layers;

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
			if (link){
                GetLinks().Remove(link);
				if(link.GetDestination())
            		GetLinksByDestination()[link.GetDestination().GetUniqueIdentifier()] = null;
				if(removeFromIndex)
				GetLinksBySource()[link.GetSource().GetUniqueIdentifier()].Remove(link);
			}
		}
        public void ClearSocket(StyleSocket socket)
        {
			if(socket.IsInput()) {
				StyleLink currentLink = null;
				if (GetLinksByDestination().ContainsKey(socket.GetUniqueIdentifier()))
					currentLink = GetLinksByDestination()[socket.GetUniqueIdentifier()];
				RemoveLink(currentLink);
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

        }

        public List<StyleModule> GetVisualElements()
        {
            if (_visualElements == null) _visualElements = new List<StyleModule>();

            return _visualElements;
        }

        public List<StyleModule> GetLayers()
        {
            if (_layers == null) _layers = new List<StyleModule>();

            return _layers;
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
            Debug.Log("Loading " + path);
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

			else if(extention == ".png") {
				Texture2D loadedImage = new Texture2D(1,1);
				loadedImage.LoadImage(File.ReadAllBytes(path));
				GetVisualElements().Add(ScriptableObject.CreateInstance<StyleColormap>().Init(loadedImage,Path.GetFileNameWithoutExtension(path)));
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
			string [] types =  {"Path Layer", "Point Layer"};
			return types;
		}

		public void CreateLayer() {
            _layers.Add(ScriptableObject.CreateInstance<StyleTestLayer>().Init());

		}


		[SerializeField] Canvas _CanvasPrefab;
		[SerializeField] List<Canvas> _canvases;

		public List<Canvas> GetCanvases() {
			if(_canvases == null) _canvases = new List<Canvas>();
			return _canvases;
		}
		public void AddCanvas() {
		   GetCanvases().Add(Instantiate(_CanvasPrefab));
		}

		public void RemoveCanvas(Canvas canvas) {
			GetCanvases().Remove(canvas);
			Destroy(canvas.gameObject);
		}

		public void RemoveModule(StyleModule module) {
			if(module is StyleVisualElement) {
				GetVisualElements().Remove(module);
			} else if(module is StyleLayer) {
				GetLayers().Remove(module);
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
