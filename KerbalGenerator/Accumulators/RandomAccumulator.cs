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

		//ability scores
		public float MinStupid { get; set; }
		public float MaxStupid { get; set; }
		public float MinBrave { get; set; }
		public float MaxBrave { get; set; }
		public int MinNumberOfBadasses { get; set; }
		public int MaxNumberOfTourist { get; set; }

		//Profession Ratios
		public float ProfessionRatioPilotRate { get; set; }
		public float ProfessionRatioEngiRate { get; set; }
		public float ProfessionRatioSciRate { get; set; }

		public RandomAccumulator( ) {
			NumberToCreate = 1;
			FtMRatio = 0;
			useRatio = false;
			MinStupid = 0.0f;
			MaxStupid = 0.0f;
			MinBrave = 0.0f;
			MaxBrave = 0.0f;
			MinNumberOfBadasses = 0;
			MaxNumberOfTourist = 0;
		}

		public RandomAccumulator Reset( ) {
			return new RandomAccumulator( );
		}
	}
}
