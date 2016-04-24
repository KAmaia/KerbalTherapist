using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalGenerator.Accumulators {
	public class RandomAccumulator {
		//number of kerbals to create
		public int NumberToCreate { get; set; }

		//gendersettings;
		public decimal FtMRatio { get; set; }

		public bool useRatio { get; set; }
		public bool isKerman { get; set; }

		//ability scores
		public float MinStupid { get; set; }
		public float MaxStupid { get; set; }
		public float MinBrave { get; set; }
		public float MaxBrave { get; set; }
		public int MinNumberOfBadasses { get; set; }
		public int MaxNumberOfTourists { get; set; }

		//Profession Ratios
		public int Pilots{ get; set; }
		public int Engineers { get; set; }
		public int Scientists{ get; set; }

		public RandomAccumulator( ) {
			NumberToCreate = 1;
			FtMRatio = 0;
			useRatio = true; //needs to be true by default.
			MinStupid = 0.0f;
			MaxStupid = 0.0f;
			MinBrave = 0.0f;
			MaxBrave = 0.0f;
			MinNumberOfBadasses = 0;
			MaxNumberOfTourists = 0;

			Pilots = 0;
			Engineers = 0;
			Scientists = 0;
		}

		public RandomAccumulator Reset( ) {
			return new RandomAccumulator( );
		}
	}
}
