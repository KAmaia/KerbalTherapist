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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KerbalTherapist.Logging;

namespace KerbalTherapist.Kerbals {
	class KerbalKounter {
		static Dictionary<string, int> counted;

		public KerbalKounter( ) {
			Logger.LogEvent( "Creating New Kounter" );
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
			Logger.LogEvent( "Counting!" );
			foreach ( Kerbal k in roster.getKerbals( ) ) {
				counted["Total"]++;
				foreach ( KeyValuePair<string, string> stat in k.Stats ) {
					if ( stat.Key == "state" ) {
						if ( ( stat.Value == "Dead" ) ) {
							counted["Dead"]++;
						}
						else {
							counted["Living"]++;
							counted[stat.Value]++;
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
