using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalTherapist.Accumulators {
	public class SpecificAccumulator {
		public string Name { get; set; }
		public bool IsKerman { get; set; }
		public bool RndName { get; set; }
		public bool Female { get; set; }
		public string Type { get; set; }
		public string Trait { get; set; }
		public bool Badass { get; set; }
		public bool Tourist { get; set; }
		public float brave { get; set; }
		public float dumb { get; set; }
		public bool RndBrave { get; set; }
		public bool RndDumb { get; set; }

		public SpecificAccumulator( ) {
			//set default values.
			Name = "";
			IsKerman = false;
			RndName = false;
			Female = true;
			Type = "";
			Trait = "";
			Badass = false;
			Tourist = false;
			brave = 0f;
			dumb = 0f;
			RndBrave = false;
			RndDumb = false;

		}

		public SpecificAccumulator Reset( ) {
			//just in case
			//throw this out and send back a clean, brand new accumulator.
			return new SpecificAccumulator( );
		}
	}
}
