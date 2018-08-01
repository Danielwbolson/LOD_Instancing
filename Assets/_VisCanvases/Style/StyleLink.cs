using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
	public class StyleLink {
		[SerializeField]
		StyleSocket _source;
		[SerializeField]
		StyleSocket _destination;

		public StyleSocket GetSource() {
			return _source;
		} 

		public StyleSocket GetDestination() {
			return _destination;
		}

		public void SetSource(StyleSocket source) {
			_source = source;
		}

		public void SetDestination(StyleSocket destination) {
			_destination = destination;
		} 
		
	}
}

