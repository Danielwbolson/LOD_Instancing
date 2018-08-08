using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis
{
    [CreateAssetMenu()]
    public class StyleCustomPointVariable : StyleCustomVariable
    {

        public override void UpdateModule()
        {
            if(_sourceVariableSocket.GetInput() == null) return;
            if(_pointDataset == null) {
                _pointDataset = PointDataset.CreateInstance<PointDataset>();
                _pointDataset.Init(_sourceVariableSocket.GetInput(), (IntRange)_sampleCount.GetInput(), 0, 0);
                _pointDataset.LoadDataset();
                _variable = _pointDataset.GetAnchor();
                _generatedVariableSocket.SetSourceObject(_variable);
                _derivableVariableSocket.SetSourceObject(_variable);
            }

            Datastream stream = _pointDataset.GetAnchor().GetStream(null,0,0);

            DatastreamChannel ch = stream.GetRootChannel();
            if(ch is PointAnchorDatastreamChannel) {
                int seed = (IntRange)_sampleSeed.GetInput();
                UnityEngine.Random.seed = (seed);
                Bounds b = _sourceVariableSocket.GetInput().GetBounds();
                List<Vector3> vs = new List<Vector3>();
                for(int i = 0; i < (IntRange)_sampleCount.GetInput(); i++) {
                    Vector3 v = new Vector3(UnityEngine.Random.Range(b.min.x,b.max.x),UnityEngine.Random.Range(b.min.y,b.max.y),UnityEngine.Random.Range(b.min.z,b.max.z)); 
                    vs.Add(v);
                }
                ((PointAnchorDatastreamChannel)ch).SetPoints(vs);
            }
            Debug.Log("Has " + stream.GetNumberOfElements());
            base.UpdateModule();

        }

        [SerializeField]
        public PointDataset _pointDataset;

        [SerializeField]
        public VariableSocket _sourceVariableSocket;

        [SerializeField]
        public StyleTypeSocket<IntRange> _sampleSeed;

        [SerializeField]
        public StyleTypeSocket<IntRange> _sampleCount;

        [SerializeField]
        public StyleSocket _generatedVariableSocket;
        [SerializeField]
        public StyleSocket _derivableVariableSocket;


        public StyleCustomPointVariable Init()
        {

            _variable = null;
            _generatedVariableSocket = (new StyleSocket()).Init("", this, false, true, _variable);

            AddSocket(_generatedVariableSocket);
            _derivableVariableSocket = (new StyleSocket()).Init("Hook for deriving", this, false, true, _variable);
            AddSocket(_generatedVariableSocket);


            _sourceVariableSocket = new VariableSocket();
            _sourceVariableSocket.Init("Domain", this);
            AddSocket(_sourceVariableSocket);

            _sampleCount = (new StyleTypeSocket<IntRange>()).Init("Number of samples", this);
            _sampleCount.SetDefaultInputObject((new IntRange(1, 1000)));
            AddSocket(_sampleCount);


            _sampleSeed = (new StyleTypeSocket<IntRange>()).Init("SampleSeed", this);
            _sampleSeed.SetDefaultInputObject((new IntRange(1, 10)));
            AddSocket(_sampleSeed);

            return this;
        }


        public override string GetLabel()
        {
            // if(_generatedVariableSocket.GetOutput() != null && ((Variable)_generatedVariableSocket.GetOutput())!=null)
            // Debug.Log("Custom Output:" + ((Variable)_generatedVariableSocket.GetOutput()).GetStream(null,0,0).GetNumberOfElements());
            return "Uniform Points";
        }

        public override bool IsValid()
        {
            if(_sourceVariableSocket.GetInput() != null)
                return true;
            return false;
        }

        public override StyleVariable CopyVariable(StyleVariable toCopy)
        {
            if (toCopy != null && toCopy is StyleCustomPointVariable)
            {
                _sampleCount = ((StyleCustomPointVariable)toCopy)._sampleCount;

            }
            return Init();
        }


    }
}

