using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace KerbalGenerator {
	internal class KerbalParser {


		private Dictionary<string, Kerbal> roster;


		public KerbalParser( ) {
		}

		public void Parse( string savepath ) {
			StreamReader rdr = new StreamReader(savepath);
			string line ="";
			//read down, throwing away everything until we hit "roster"
			bool inRoster = false;
			while ( ( line = rdr.ReadLine( ) ) != null ) {
				//okay roster is found, so next we need to....
				//create a new Dictionary<string, Kerbal>
				//check for the word Kerbal
				//kreate new kerbal
				//parse in important values.
				//done
				string s = line;
				
				if ( s.Trim().Equals( "ROSTER" ) ) {
					roster = new Dictionary<string, Kerbal>( );
					inRoster = true;
				}
				//going to have to find a better way to do this.
				//to handle KerbalStats
				if ( s.Trim( ).ToLower( ).Equals( "kerbalext" ) ) {
					inRoster = false;
				}

				if ( inRoster ) {

					Debug.WriteLine( s );
				}
			}
		}
	}

}
