//Copyright (C) 2016 Amaia Industries
//
//Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
//associated documentation files (the "Software"), to deal in the Software without restriction, 
//including without limitation the rights to use, copy, modify, merge, publish, and distribute 
//copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
//	Notice:
//	The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
//	Modifications:
//	Any modified version or derivative of this software must include a link to the original source code.  Distributing the original source code with the 
//	release of the modified version shall be construed to satisfy this clause.
//
//	Attribution:
//	Any modified version or derivative of this software must include attribution to the original author.  
//
//	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
//	INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
//	PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE Amaia Industries 
//	BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//	TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE 
//	USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//	Except as contained in this notice, the name of Amaia Industries shall not be used in advertising or 
//	otherwise to promote the sale, use or other dealings in this Software without prior written authorization from Amaia Industries.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConfigNodeParser;

namespace KerbalTherapist.Kerbals {
	class RosterParser {
		
		public RosterParser ( ) {
			//do nothing.
		}

		public static Roster GetRoster ( ConfigNode persistent ) {	
			ConfigNode rosterNode = persistent.GetNode ( "ROSTER" );
			Roster r = new Roster ( );
			foreach ( ConfigNode kerbalNode in rosterNode.GetNodes( "KERBAL" ) ) {
				List<KeyValuePair<string, string>> stats = new List<KeyValuePair<string, string>> ( );
				List<KeyValuePair<string, string>> careerLog = new List<KeyValuePair<string, string>> ( );
				List<KeyValuePair<string, string>> flightLog = new List<KeyValuePair<string, string>> ( );
				ConfigNode logs;
				foreach ( KeyValuePair<string, string> kvp in kerbalNode.values ) {
					stats.Add ( kvp );
				}

				logs = kerbalNode.GetNode ( "CAREER_LOG" );
				foreach ( KeyValuePair<string, string> kvp in logs.values ) {
					//ignore flight because we can get that back from flights.
					careerLog.Add ( kvp );

				}

				logs = kerbalNode.GetNode ( "FLIGHT_LOG" );
				foreach ( KeyValuePair<string, string> kvp in logs.values ) {
					flightLog.Add ( kvp );
				}
				r.AddKerbal ( new Kerbal ( stats, careerLog, flightLog ) );
			}
			return r;
		}

		public static void InsertRoster ( Roster roster, ConfigNode persistent ) {
			
			ConfigNode newRoster = new ConfigNode ( "ROSTER" );
			foreach ( Kerbal k in roster.getKerbals() ) {
				
				ConfigNode newKerbalNode = new ConfigNode ( "KERBAL" );
				foreach ( KeyValuePair<string, string> stat in k.Stats ) {
					newKerbalNode.AddValue ( stat.Key, stat.Value );
				}

				ConfigNode newCareerLogNode = new ConfigNode ( "CAREER_LOG" );
				foreach ( KeyValuePair<string, string> logEntry in k.CareerLog ) {
					newCareerLogNode.AddValue ( logEntry.Key, logEntry.Value );
				}
				ConfigNode newFlightLogNode = new ConfigNode ( "FLIGHT_LOG" );
				foreach ( KeyValuePair<string, string> logEntry in k.FlightLog ) {
					newFlightLogNode.AddValue ( logEntry.Key, logEntry.Value );
				}
				newKerbalNode.AddConfigNode ( newCareerLogNode );
				newKerbalNode.AddConfigNode ( newFlightLogNode );
				newRoster.AddConfigNode ( newKerbalNode );
			}
			ConfigNode oldRoster = persistent.GetNode ( "ROSTER" );

			oldRoster.ClearData ( );
			foreach ( ConfigNode kerbalNode in newRoster.GetNodes("KERBAL") ) {
				oldRoster.AddConfigNode ( kerbalNode );
			}
		}

	}
}
