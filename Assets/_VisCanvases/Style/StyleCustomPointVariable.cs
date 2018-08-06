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
            base.UpdateModule();
            _pointDataset = PointDataset.CreateInstance<PointDataset>();
            _pointDataset.Init(_sourceVariable.GetInput(), (IntRange)_sampleCount.GetInput(), 0, 0);
            _pointDataset.LoadDataset();

            _variable = _pointDataset.GetAnchor();
            _generatedVariableSocket.SetSourceObject(_variable);
            _derivableVariableSocket.SetSourceObject(_variable);
        }

        [SerializeField]
        public PointDataset _pointDataset;

        [SerializeField]
        public VariableSocket _sourceVariable;

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


            _sourceVariable = new VariableSocket();
            _sourceVariable.Init("Domain", this);
            _sourceVariable.RequireScalar();
            AddSocket(_sourceVariable);

            _sampleCount = (new StyleTypeSocket<IntRange>()).Init("Number of samples", this);
            _sampleCount.SetDefaultInputObject((new IntRange(1, 1000)));
            AddSocket(_sampleCount);

            return this;
        }


        public override string GetLabel()
        {
            return "Uniform Points";
        }

        public override bool IsValid()
        {
            if(_sourceVariable.GetInput() != null)
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

