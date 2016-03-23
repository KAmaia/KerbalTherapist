using System;
using System.Diagnostics;
using System.IO;

namespace KerbalGenerator {
	internal class KerbalParser {
		public KerbalParser() {
		}

		internal void Parse( string persistent ) {
			StreamReader rdr = new StreamReader(persistent);
			string line ="";
			string something = "";
		
			while ((line = rdr.ReadLine( ) ) != null ) {
				Debug.WriteLine( line );
			}
			
		}
	}
}