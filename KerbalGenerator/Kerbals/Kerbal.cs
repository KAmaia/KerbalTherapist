using System.Diagnostics;
using System.Collections.Generic;
using System;

namespace KerbalGenerator {
	/// <summary>
	/// Data class to hold kerbal information
	/// </summary>
	public class Kerbal {
public List<KeyValuePair<string, string>> Stats { get; set; }

		public List<KeyValuePair<string, string>> CareerLog { get; set; }
		public List<KeyValuePair<string, string>> FlightLog { get; set; }

		//For Kerbals that already exist in the game.
		public Kerbal( List<KeyValuePair<string, string>> stats,
			List<KeyValuePair<string,string>> careerLog, 
			List<KeyValuePair<string, string>> flightLog) {
			Stats = stats;
			CareerLog = careerLog;
			FlightLog = flightLog;
		}

		//For Kerbals that we're creating.
		public Kerbal( List<KeyValuePair<string, string>> stats ) {
			Stats = stats;
			CareerLog = new List<KeyValuePair<string, string>>( );
			FlightLog = new List<KeyValuePair<string, string>>( );
          }

		//Fucking Stupid, But I'll do it.
		public string GetName( ) {
			foreach(KeyValuePair<string, string> stat in Stats ) {
				if(stat.Key == "name" ) {
					return stat.Value;
				}
			}
			//should never happen.
			return null;
		}

		internal string GetStat( string v ) {
			foreach(KeyValuePair<string,string> stat in Stats ) {
				if(stat.Key == v ) {
					return stat.Value;
				}
			}
			return null;
		}
	}
}