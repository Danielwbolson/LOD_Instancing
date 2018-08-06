using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis
{
    public class StyleCustomVariable : StyleVariable
    {

        public StyleCustomVariable Init()
        {
            return this;
        }


        public override string GetLabel()
        {
            return "Custom Variable";
        }



      
    }
}

