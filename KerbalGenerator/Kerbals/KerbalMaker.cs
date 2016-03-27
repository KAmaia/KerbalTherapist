using KerbalGenerator.Accumulators;
using System.Collections.Generic;
using KerbalGenerator.NameGenerator;
using KerbalGenerator.Logging;
namespace KerbalGenerator {
	public class KerbalMaker {

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
				thinger = Util.GetRandFloat( );
			}
			else {
				thinger = (float) value / 100;
			}
			return new KeyValuePair<string, string>( key, thinger.ToString( ) );
		}

		private static KeyValuePair<string, string> GenerateStatePair( ) {
			return new KeyValuePair<string, string>( "state", "Available" );
		}
		private static KeyValuePair<string, string> GenerateToDPair( ) {
			return new KeyValuePair<string, string>( "ToD", "0" );
		}
		private static KeyValuePair<string, string> GenerateIdxPair( ) {
			return new KeyValuePair<string, string>( "idx", "0" );
		}
	}
}