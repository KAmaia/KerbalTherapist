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

using System.Diagnostics;
using System.Collections.Generic;
using System;

using KerbalTherapist.Logging;

namespace KerbalTherapist.Kerbals {
	/// <summary>
	/// Data class to hold kerbal information
	/// </summary>
	public class Kerbal {
		public List<KeyValuePair<string, string>> Stats { get; set; }

		public List<KeyValuePair<string, string>> CareerLog { get; set; }

		public List<KeyValuePair<string, string>> FlightLog { get; set; }

		//For Kerbals that already exist in the game.
		public Kerbal ( List<KeyValuePair<string, string>> stats, List<KeyValuePair<string, string>> careerLog, List<KeyValuePair<string, string>> flightLog ) {
			Stats = stats;

			CareerLog = careerLog;
			FlightLog = flightLog;

			Logger.LogEvent ( "Read New Kerbal Created With Stats: " );
			LogStats ( Stats );
			LogStats ( CareerLog );
			LogStats ( FlightLog );

			
		}

		//For Kerbals that we're creating.
		public Kerbal ( List<KeyValuePair<string, string>> stats ) {
			Stats = stats;

			Logger.LogEvent ( "Read New Kerbal Created With Stats: " );
			LogStats ( Stats );
			CareerLog = new List<KeyValuePair<string, string>> ( );
			FlightLog = new List<KeyValuePair<string, string>> ( );
			CareerLog.Add ( new KeyValuePair<string, string> ( "flight", "0" ) );
			FlightLog.Add ( new KeyValuePair<string, string> ( "flight", "0" ) );
		}

		//Fucking Stupid, But I'll do it.
		public string GetName ( ) {
			foreach ( KeyValuePair<string, string> stat in Stats ) {
				if ( stat.Key == "name" ) {
					return stat.Value;
				}
			}
			//should never happen.
			return null;
		}

		internal string GetStat ( string v ) {
			foreach ( KeyValuePair<string, string> stat in Stats ) {
				if ( stat.Key == v ) {
					return stat.Value;
				}
			}
			return null;
		}

		private void LogStats ( List<KeyValuePair<string, string>> stats ) {
			foreach ( KeyValuePair<string, string> kvp in stats ) {
				Logger.LogNewLine ( kvp.Key + ":" + kvp.Value );
			}
		}
	}
}