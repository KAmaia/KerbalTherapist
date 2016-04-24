using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalTherapist.Kerbals {
	class KerbalKounter {
		static Dictionary<string, int> counted;

		public KerbalKounter( ) {
			counted = new Dictionary<string, int>( );
			counted.Add( "Total", 0 );
			counted.Add( "Living", 0 );
			counted.Add( "Dead", 0 );
			counted.Add( "Pilot", 0 );
			counted.Add( "Engineer", 0 );
			counted.Add( "Scientist", 0 );
			counted.Add( "Male", 0 );
			counted.Add( "Female", 0 );
			counted.Add( "Badass", 0 );
			counted.Add( "Tourist", 0 );
			counted.Add( "Applicant", 0 );
			counted.Add( "Crew", 0 );
			counted.Add( "Assigned", 0 );
			counted.Add( "Available", 0 );
		}

		public Dictionary<string, int> KountKerbals( Roster roster ) {
			foreach ( Kerbal k in roster.getKerbals( ) ) {
				counted["Total"]++;
				foreach ( KeyValuePair<string, string> stat in k.Stats ) {
					
					if ( stat.Key == "State" ) {
						if ( !( stat.Value == "Dead" ) ) {
							counted["Living"]++;
						}
					}
					else if ( counted.ContainsKey( stat.Value ) ) {
						counted[stat.Value]++;
					}
					else if ( stat.Key == "badS" ) {
						if ( stat.Value == "True" ) {
							counted["Badass"]++;
						}
					}
					else if ( stat.Key == "tour" ) {
						if ( stat.Value == "True" ) {
							counted["Tourist"]++;
						}
					}
					

				}
			}

			return counted;
		}
	}
}
