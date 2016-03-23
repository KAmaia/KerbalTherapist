namespace KerbalGenerator {
	/// <summary>
	/// Data class to hold kerbal information
	/// </summary>
	public class Kerbal {

		public string Name { get; set; }
		public string Gender { get; set; }
		public string Trait { get; set; }
		public string Type { get; set; }
		public string Brave { get; set; }
		public string Dumb { get; set; }
		public string Bads { get; set; }
		public string Tour { get; set; }
		public string State { get; set; }
		public string Flights { get; set; }

		public Kerbal( ) {
			}

		private string capitalizeStrings( string str ) {
			//handle splitting the string if it has a space. 
			string[ ] tmp = str.Split(' ');
			string retVal = "";
			foreach ( string s in tmp ) {
				char[] c =s.ToCharArray();
				c[0] = char.ToUpper( c[0] );
				retVal = retVal +" " + new string( c );
			}
			return retVal.TrimStart(' ');
		}

	}
}