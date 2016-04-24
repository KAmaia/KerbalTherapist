using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConfigNodeParser;

namespace KerbalTherapist.Kerbals {
	class RosterParser {
		
		public RosterParser( ) {
			//do nothing.
		}

		public static Roster GetRoster( ConfigNode persistent ) {	
			ConfigNode rosterNode = persistent.GetNode("ROSTER");
			Roster r = new Roster();
			foreach ( ConfigNode kerbalNode in rosterNode.GetNodes( "KERBAL" ) ) {
				List<KeyValuePair<string, string>> stats = new List<KeyValuePair<string, string>>( );
				List<KeyValuePair<string, string>> careerLog = new List<KeyValuePair<string, string>>();
				List<KeyValuePair<string, string>> flightLog = new List<KeyValuePair<string, string>>();
				ConfigNode logs;
				foreach(KeyValuePair<string, string> kvp in kerbalNode.values ) {
					stats.Add( kvp );
				}

				logs = kerbalNode.GetNode( "CAREER_LOG" );
				foreach ( KeyValuePair<string, string> kvp in logs.values ) {
					//ignore flight because we can get that back from flights.
					careerLog.Add( kvp );

				}

				logs = kerbalNode.GetNode( "FLIGHT_LOG" );
				foreach ( KeyValuePair<string, string> kvp in logs.values ) {
					flightLog.Add( kvp );
				}
				r.AddKerbal( new Kerbal(stats, careerLog, flightLog ));
			}
			return r;
		}

		public static void InsertRoster(Roster roster, ConfigNode persistent ) {
			
			ConfigNode newRoster = new ConfigNode("ROSTER");
			foreach(Kerbal k in roster.getKerbals() ) {
				
				ConfigNode newKerbalNode = new ConfigNode("KERBAL");
				foreach(KeyValuePair<string, string> stat in k.Stats ) {
					newKerbalNode.AddValue( stat.Key, stat.Value );
				}

				ConfigNode newCareerLogNode = new ConfigNode("CAREER_LOG");
				foreach(KeyValuePair<string, string> logEntry in k.CareerLog ) {
					newCareerLogNode.AddValue( logEntry.Key, logEntry.Value );
				}
				ConfigNode newFlightLogNode = new ConfigNode("FLIGHT_LOG");
				foreach (KeyValuePair<string, string> logEntry in k.FlightLog ) {
					newFlightLogNode.AddValue( logEntry.Key, logEntry.Value );
				}
				newKerbalNode.AddConfigNode( newCareerLogNode );
				newKerbalNode.AddConfigNode( newFlightLogNode );
				newRoster.AddConfigNode( newKerbalNode );
			}
			ConfigNode oldRoster = persistent.GetNode( "ROSTER" );

			oldRoster.ClearData( );
			foreach(ConfigNode kerbalNode in newRoster.GetNodes("KERBAL") ) {
				oldRoster.AddConfigNode( kerbalNode );
			}
		}

	}
}
