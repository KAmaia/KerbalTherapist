using System;
using System.IO;

namespace KerbalGenerator {
	internal class KerbalParser {
		private Parserdisplay form;
		public KerbalParser() {
			//form = new Parserdisplay( );
		}

		internal void Parse( string persistent ) {
			StreamReader rdr = new StreamReader(persistent);
			string line ="";
			string something = "";
		
			while ((line = rdr.ReadLine( ) ) != null ) {
				Console.Write( line );
			}
			
		}
	}
}