using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalGenerator {
	class Roster {
		Dictionary<string, Kerbal>kerbals;
		public Roster( ) {
			kerbals = new Dictionary<string, Kerbal>( );
		}

		public bool ValidateKerbal(string name ) {
			foreach ( Kerbal k in kerbals.Values ) {
				if ( k.Name.ToLower( ).Equals( name.ToLower() ) ) {
					return false;
				}
			}
			return true;
		}

		public bool ValidateKerbal(Kerbal k ) {
			foreach (string kerb in kerbals.Keys ) {
				if ( kerb.ToLower( ).Equals( k.Name.ToLower( ) )){
					return false;
				}
			}
			return true;
		}

		public void AddKerbal(Kerbal k ) {
			if ( kerbals.Keys.Contains( k.Name )){
				kerbals.Remove( k.Name );
			}
			kerbals.Add( k.Name, k );
		}

		public List<string> GetNames( ) {
			return kerbals.Keys.ToList();
		}

		public Dictionary<string, int> GetCounts( ) {
			Dictionary<string, int>saveStatsDict = new Dictionary<string, int>();
			saveStatsDict.Add( "totalkerbals", 0 );
			saveStatsDict.Add( "malekerbals", 0 );
			saveStatsDict.Add( "femalekerbals", 0 );
			saveStatsDict.Add( "livingkerbals", 0 );
			saveStatsDict.Add( "deadkerbals", 0 );
			saveStatsDict.Add( "touristkerbals", 0 );
			saveStatsDict.Add( "engineerkerbals", 0 );
			saveStatsDict.Add( "scientistkerbals", 0 );
			saveStatsDict.Add( "pilotkerbals", 0 );
			saveStatsDict.Add( "badasskerbals", 0 );

			foreach ( string s in kerbals.Keys ) {
				saveStatsDict["totalkerbals"] += 1;
				if ( kerbals[s].Gender.ToLower( ).Equals( "male" ) ) {
					saveStatsDict["malekerbals"] += 1;
				}
				if ( kerbals[s].Gender.ToLower( ).Equals( "female" ) ) {
					saveStatsDict["femalekerbals"] += 1;
				}
				if ( ( kerbals[s].State.ToLower( ).Equals( "available" ) ) 
					|| kerbals[s].State.ToLower( ).Equals( "assigned" ) ) {
					saveStatsDict["livingkerbals"] += 1;
				}
				if ( kerbals[s].State.ToLower( ).Equals( "dead" ) ) {
					saveStatsDict["deadkerbals"] += 1;
				}
				if ( kerbals[s].Trait.ToLower( ).Equals( "engineer" ) ) {
					saveStatsDict["engineerkerbals"] += 1;
				}
				if ( kerbals[s].Trait.ToLower( ).Equals( "pilot" ) ) {
					saveStatsDict["pilotkerbals"] += 1;
				}
				if ( kerbals[s].Trait.ToLower( ).Equals( "scientist" ) ) {
					saveStatsDict["scientistkerbals"] += 1;
				}
				if ( kerbals[s].Tour.ToLower( ).Equals( "true" ) ) {
					saveStatsDict["touristkerbals"] += 1;
				}
				if ( kerbals[s].Bads.ToLower( ).Equals( "true" ) ) {
					saveStatsDict["badasskerbals"] += 1;
				}
			}
			return saveStatsDict;
		}

		public Kerbal GetKerbal( string selectedKerbal ) {
			return kerbals[selectedKerbal];
		}
	}
}
