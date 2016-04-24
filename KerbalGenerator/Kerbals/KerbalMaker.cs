using KerbalGenerator.Accumulators;
using System.Collections.Generic;
using KerbalGenerator.NameGenerator;
using KerbalGenerator.Logging;
using System;

namespace KerbalGenerator {
	public class KerbalMaker {

		//we defualt to female, but since we have to toggle it before our first return, it starts as false.
		private static bool nextIsFemale = false;
		private static int malesCreated = 0;
		private static int femalesCreated = 0;
		private static int badassCreated = 0;
		private static int touristCreated = 0;

		#region KreateSpecificKerbal
		public static Kerbal KreateKerbal( SpecificAccumulator sa ) {
			Logger.LogEvent( "Generating A New Kerbal" );
			return new Kerbal( GenerateList( sa ) );
		}
		private static List<KeyValuePair<string, string>> GenerateList( SpecificAccumulator sa ) {
			List<KeyValuePair<string,string>> list = new List<KeyValuePair<string, string>>();
			list.Add( GenerateNamePair( sa ) );
			list.Add( GenerateGenderPair( sa ) );
			list.Add( GenerateTypePair( sa ) );
			list.Add( GenerateTraitPair( sa ) );
			list.Add( GenerateBravePair( sa ) );
			list.Add( GenerateDumbPair( sa ) );
			list.Add( GenerateBadsPair( sa ) );
			list.Add( GenerateTourPair( sa ) );
			list.Add( GenerateStatePair( ) );
			list.Add( GenerateToDPair( ) );
			list.Add( GenerateIdxPair( ) );
			return list;
		}
		private static KeyValuePair<string, string> GenerateNamePair( SpecificAccumulator sa ) {
			return new KeyValuePair<string, string>( "name", NameGenerator.NameGenerator.GenerateName( sa.Name, sa.RndName, sa.Female, sa.IsKerman ) );
		}
		private static KeyValuePair<string, string> GenerateGenderPair( SpecificAccumulator sa ) {
			string female = sa.Female ? "Female" : "Male";
			return new KeyValuePair<string, string>( "gender", female );
		}
		//for right now, all created kerbals are automagically hired.
		//TODO: allow kerbals to be applicants too!
		private static KeyValuePair<string, string> GenerateTypePair( SpecificAccumulator sa ) {
			return new KeyValuePair<string, string>( "type", "Crew" );
		}
		private static KeyValuePair<string, string> GenerateTraitPair( SpecificAccumulator sa ) {
			return new KeyValuePair<string, string>( "trait", sa.Trait );
		}
		private static KeyValuePair<string, string> GenerateBravePair( SpecificAccumulator sa ) {
			return CreateFloatPair( "brave", sa.RndBrave, sa.brave );
		}
		private static KeyValuePair<string, string> GenerateDumbPair( SpecificAccumulator sa ) {
			return CreateFloatPair( "dumb", sa.RndDumb, sa.dumb );
		}
		private static KeyValuePair<string, string> GenerateBadsPair( SpecificAccumulator sa ) {
			return new KeyValuePair<string, string>( "badS", sa.Badass.ToString( ) );
		}
		private static KeyValuePair<string, string> GenerateTourPair( SpecificAccumulator sa ) {
			return new KeyValuePair<string, string>( "tour", sa.Tourist.ToString( ) );
		}
		private static KeyValuePair<string, string> CreateFloatPair( string key, bool random, float value ) {
			float thinger = 0.0f;
			if ( random ) {
				thinger = Util.GetRandomFloat( );
			}
			else {
				thinger = (float) value / 100;
			}
			return new KeyValuePair<string, string>( key, thinger.ToString( ) );
		}
		#endregion

		#region KreateRandomRoster
		public static Roster KreateRoster( RandomAccumulator ra, Roster currentRoster ) {
			SpecificAccumulator sa;
			Roster returnRoster = new Roster();
			Logger.LogEvent( "Generating a new Roster" );
			for ( int i = 0; i < ra.NumberToCreate; i++ ) {
				sa = RandomToSpecificAccumulator( ra );
				Kerbal k = KreateKerbal(sa);
				//validate our kerbal
				if ( !currentRoster.ValidateKerbal( k ) ) {
					i--;
				}
				else {
					//if the kerbal is valid, increment our counts, 
					//and add the kerbal.
					incrementCounts( sa );
					returnRoster.AddKerbal( k );
				}
			}
			//reset our temp values below.
			nextIsFemale = false;
			malesCreated = 0;
			femalesCreated = 0;
			badassCreated = 0;
			touristCreated = 0;
			return returnRoster;
		}

		private static void incrementCounts( SpecificAccumulator sa ) {
			switch ( sa.Female ) {
				case true:
					femalesCreated++;
					break;
				case false:
					malesCreated++;
					break;
			}
			if ( sa.Badass ) {
				badassCreated++;
			}
			if ( sa.Tourist ) {
				touristCreated++;
			}
		}

		private static SpecificAccumulator RandomToSpecificAccumulator( RandomAccumulator ra ) {
			SpecificAccumulator sa = new SpecificAccumulator();
			//get our gender first, so that we can generate a gender appropriate name;
			sa.Female = PickRandomAccumGender( ra );
			//always true.  I forgot, we pick our names during Kerbal Generation.
			sa.RndName = true;
			//just copy isKerman from RA to SA.
			sa.IsKerman = ra.isKerman;
			//generate our stupid and brave values;
			sa.brave = Util.GetRandomFloatInRange( ra.MinBrave, ra.MaxBrave );
			sa.dumb = Util.GetRandomFloatInRange( ra.MinStupid, ra.MaxStupid );
			//just some counting variables.

			//TODO: Move This
			if ( badassCreated < ra.MinNumberOfBadasses ) {
				sa.Badass = true;
				
			}
			else {
				//Each kerbal has a 50/50 shot of being badass.
				if ( Util.GetRandomFloat( ) > .5f ) {
					sa.Badass = true;
					
				}
				else {
					sa.Badass = false;
				}
			}
			if ( touristCreated < ra.MaxNumberOfTourists ) {
				//Each Kerbal has a ~5% chance of being a tourist.
				if ( Util.GetRandomFloat( ) > .95f ) {
					sa.Tourist = true;
				}
				else {
					sa.Tourist = false;
				}
			}
			return sa;
		}


		private static bool PickRandomAccumGender( RandomAccumulator ra ) {
			if ( ra.useRatio ) {
				if ( ra.FtMRatio.Equals( 1 ) || ra.FtMRatio.Equals( -1 ) ) {
					//either all males or all females
					return ra.FtMRatio.Equals( -1 );
				}
				else {
					//if ratio is 0, just toggle female back and forth until all kerbals are created.
					if ( ra.FtMRatio.Equals( 0.0d ) ) {
						//toggle nextIsFemale before we can return.
						nextIsFemale = !nextIsFemale;
						return nextIsFemale;
					}
					//if ratio is negative, we need to create more females than males.
					else if ( ra.FtMRatio < 0 ) {
						//create more females
						decimal ratio =(decimal) femalesCreated / ra.NumberToCreate;
						return !( femalesCreated / ra.NumberToCreate >= ( Math.Abs( ra.FtMRatio ) ) );

					}
					//else we need to create more males than females.
					else if ( ra.FtMRatio > 0 ) {
						//create more males.
						return malesCreated / ra.NumberToCreate >= Math.Abs( ra.FtMRatio );
					}
					//else, default to female.
					else {
						return true;
					}
				}
			}
			else {
				return Util.GetRandomFloat( ) > .5f;
			}
		}
		#endregion

		#region Used For Both
		private static KeyValuePair<string, string> GenerateStatePair( ) {
			return new KeyValuePair<string, string>( "state", "Available" );
		}
		private static KeyValuePair<string, string> GenerateToDPair( ) {
			return new KeyValuePair<string, string>( "ToD", "0" );
		}
		private static KeyValuePair<string, string> GenerateIdxPair( ) {
			return new KeyValuePair<string, string>( "idx", "0" );
		}

		#endregion
	}
}