using KerbalTherapist.Accumulators;
using System.Collections.Generic;
using KerbalTherapist.Names;
using KerbalTherapist.Logging;
using System;
using System.Diagnostics;

namespace KerbalTherapist.Kerbals {
	public class KerbalMaker {

		//we defualt to female, but since we have to toggle it before our first return, it starts as false.
		private  bool nextIsFemale = false;
		private  int malesCreated = 0;
		private  int femalesCreated = 0;
		private  int badassCreated = 0;
		private  int touristCreated = 0;
		private int pilotsCreated = 0;
		private int engineersCreated = 0;
		private int scientistsCreated = 0;

		private NameGenerator ng = new NameGenerator ( );

		#region KreateSpecificKerbal

		public Kerbal KreateKerbal ( SpecificAccumulator sa ) {
			Logger.LogEvent ( "Generating A New Kerbal" );
			return new Kerbal ( GenerateList ( sa ) );
		}

		private List<KeyValuePair<string, string>> GenerateList ( SpecificAccumulator sa ) {
			List<KeyValuePair<string,string>> list = new List<KeyValuePair<string, string>> ( );
			list.Add ( GenerateNamePair ( sa ) );
			list.Add ( GenerateGenderPair ( sa ) );
			list.Add ( GenerateTypePair ( sa ) );
			list.Add ( GenerateTraitPair ( sa ) );
			list.Add ( GenerateBravePair ( sa ) );
			list.Add ( GenerateDumbPair ( sa ) );
			list.Add ( GenerateBadsPair ( sa ) );
			list.Add ( GenerateTourPair ( sa ) );
			list.Add ( GenerateStatePair ( ) );
			list.Add ( GenerateToDPair ( ) );
			list.Add ( GenerateIdxPair ( ) );
			return list;
		}

		#endregion

		#region KreateRandomRoster

		public Roster KreateRoster ( RandomAccumulator ra, Roster currentRoster ) {
			SpecificAccumulator sa;
			Roster returnRoster = new Roster ( );
			Logger.LogEvent ( "Generating a new Roster" );
			for ( int i = 0; i < ra.NumberToCreate; i++ ) {
				sa = RandomToSpecificAccumulator ( ra );
				Kerbal k = KreateKerbal ( sa );
				//validate our kerbal
				if ( !currentRoster.ValidateKerbal ( k ) ) {
					i--;
				}
				else {
					//if the kerbal is valid, increment our counts, 
					//and add the kerbal.
					incrementCounts ( sa );
					returnRoster.AddKerbal ( k );
				}
			}
			//reset our temp values below.

			return returnRoster;
		}

		private void incrementCounts ( SpecificAccumulator sa ) {
			switch ( sa.Female ) {
			case true:
				femalesCreated++;
				break;
			case false:
				malesCreated++;
				break;
			}
			switch ( sa.Trait ) {
			case "Pilot":
				pilotsCreated++;
				break;
			case "Engineer":
				engineersCreated++;
				break;
			case "Scientist":
				scientistsCreated++;
				break;
			}
			if ( sa.Badass ) {
				badassCreated++;
			}
			if ( sa.Tourist ) {
				touristCreated++;
			}
		}

		private SpecificAccumulator RandomToSpecificAccumulator ( RandomAccumulator ra ) {
			SpecificAccumulator sa = new SpecificAccumulator ( );
			//get our gender first, so that we can generate a gender appropriate name;
			sa.Female = PickRandomAccumGender ( ra );
			//always true.  I forgot, we pick our names during Kerbal Generation.
			sa.RndName = true;
			//just copy isKerman from RA to SA.
			sa.IsKerman = ra.isKerman;
			//assign our traits;
			sa.Trait = assignTrait ( ra );
			//generate our stupid and brave values;
			sa.brave = Util.GetRandomFloatInRange ( ra.MinBrave, ra.MaxBrave );
			sa.dumb = Util.GetRandomFloatInRange ( ra.MinStupid, ra.MaxStupid );
			//just some counting variables.

			//TODO: Move This
			if ( badassCreated < ra.MinNumberOfBadasses ) {
				sa.Badass = true;

			}
			else {
				//Each kerbal has a 50/50 shot of being badass.
				if ( Util.GetRandomFloat ( ) > .5f ) {
					sa.Badass = true;

				}
				else {
					sa.Badass = false;
				}
			}
			if ( touristCreated < ra.MaxNumberOfTourists ) {
				//Each Kerbal has a ~5% chance of being a tourist.
				if ( Util.GetRandomFloat ( ) > .95f ) {
					sa.Tourist = true;
				}
				else {
					sa.Tourist = false;
				}
			}
			return sa;
		}


		private bool PickRandomAccumGender ( RandomAccumulator ra ) {
			if ( ra.useRatio ) {
				//create a temporary ratio that we check against.
				float ratio = (float) Math.Abs ( ra.FtMRatio );
				//don't worry about it here.
				if ( ra.FtMRatio == 1 || ra.FtMRatio == -1 ) {
					//either all males or all females
					return ra.FtMRatio.Equals ( -1 );
				}
				//or here.
				else if ( ra.FtMRatio == 0 ) {
					//if ratio is 0, just toggle female back and forth until all kerbals are created.
					//toggle nextIsFemale before we can return.
					nextIsFemale = !nextIsFemale;
					return nextIsFemale;
				}
				//if ratio is negative, we need to create more females than males.
				else if ( ra.FtMRatio < 0 ) {
					//create more females
					float f = (float) femalesCreated / (float) ra.NumberToCreate;
					return  f <= ratio;
				}
				//else we need to create more males than females.
				else if ( ra.FtMRatio > 0 ) {
					//create more males.
					float m = (float) malesCreated / (float) ra.NumberToCreate;
					return m >= ratio;
				}
				//else default to female;
				else {
					return true;
				}
			}
			//else we're not using a ratio, so randomize things
			else {
				//create two random floats
				float one = Util.GetRandomFloat ( );
				float two = Util.GetRandomFloat ( );
				return one > two;
			}
			
		}

		string assignTrait ( RandomAccumulator ra ) {
			if ( pilotsCreated < ra.Pilots ) {
				return "Pilot";
			}
			if ( engineersCreated < ra.Engineers ) {
				return "Engineer";
			}
			if ( scientistsCreated < ra.Scientists ) {
				return "Scientist";
			}
			return "Pilot";
		}

		#endregion

		#region Used For Both

		private KeyValuePair<string, string> GenerateStatePair ( ) {
			return new KeyValuePair<string, string> ( "state", "Available" );
		}

		private KeyValuePair<string, string> GenerateToDPair ( ) {
			return new KeyValuePair<string, string> ( "ToD", "0" );
		}

		private KeyValuePair<string, string> GenerateIdxPair ( ) {
			return new KeyValuePair<string, string> ( "idx", "0" );
		}

		private KeyValuePair<string, string> GenerateNamePair ( SpecificAccumulator sa ) {
			return new KeyValuePair<string, string> ( "name", ng.GenerateName ( sa.Name, sa.RndName, sa.Female, sa.IsKerman ) );
		}

		private KeyValuePair<string, string> GenerateGenderPair ( SpecificAccumulator sa ) {
			string female = sa.Female ? "Female" : "Male";
			return new KeyValuePair<string, string> ( "gender", female );
		}
		//for right now, all created kerbals are automagically hired.
		//TODO: allow kerbals to be applicants too!
		private KeyValuePair<string, string> GenerateTypePair ( SpecificAccumulator sa ) {
			float picker = Util.GetRandomFloat ( );
			if ( picker > .31f ) {
				return new KeyValuePair<string, string> ( "type", "Crew" );
			}
			return new KeyValuePair<string, string> ( "type", "Applicant" );
		}

		private KeyValuePair<string, string> GenerateTraitPair ( SpecificAccumulator sa ) {
			return new KeyValuePair<string, string> ( "trait", sa.Trait );
		}

		private KeyValuePair<string, string> GenerateBravePair ( SpecificAccumulator sa ) {
			return CreateFloatPair ( "brave", sa.RndBrave, sa.brave );
		}

		private KeyValuePair<string, string> GenerateDumbPair ( SpecificAccumulator sa ) {
			return CreateFloatPair ( "dumb", sa.RndDumb, sa.dumb );
		}

		private KeyValuePair<string, string> GenerateBadsPair ( SpecificAccumulator sa ) {
			return new KeyValuePair<string, string> ( "badS", sa.Badass.ToString ( ) );
		}

		private KeyValuePair<string, string> GenerateTourPair ( SpecificAccumulator sa ) {
			return new KeyValuePair<string, string> ( "tour", sa.Tourist.ToString ( ) );
		}

		private KeyValuePair<string, string> CreateFloatPair ( string key, bool random, float value ) {
			float floatForPair = 0.0f;
			if ( random ) {
				floatForPair = Util.GetRandomFloat ( );
			}
			else {
				floatForPair = (float) value / 100;
			}
			return new KeyValuePair<string, string> ( key, floatForPair.ToString ( ) );
		}

		#endregion
	}
}