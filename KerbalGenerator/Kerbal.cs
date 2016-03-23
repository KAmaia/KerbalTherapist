using System.Diagnostics;

namespace KerbalGenerator {
	/// <summary>
	/// Data class to hold kerbal information
	/// </summary>
	public class Kerbal {

		public string Name { get; set; } //Who the fuck am I again?!
		public string Gender { get; set; } // Yes Please?
		public string Trait { get; set; } //Pilot/Engineer/Scientist
		public string Type { get; set; } //Crew/Applicant
		public string Brave { get; set; } //how brave am I?
		public string Dumb { get; set; } //how fucking dumb am I?
		public string Bads { get; set; } //is this kerbal a badass
		public string Tour { get; set; } //is this kerbal a tourist?
		public string State { get; set; } //is alive or dead
		public string ToD { get; set; }
		public string Flights { get; set; }

		public Kerbal(string name, string gender, string trait, string type, string brave, string dumb, string bads, string tour, string state,  string tod, string flights ) {
			Name = name;
			Gender = gender;
			Trait = trait;
			Type = type;
			Brave = brave;
			Dumb = dumb;
			Bads = bads;
			Tour = tour;
			State = state;
			ToD = tod;
			Flights = flights;
			printValues( );
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
		private void printValues( ) {
			string printables = "Name = " + Name + "\n" +
							"Gender = " + Gender + "\n" +
							"Trait = " + Trait +  "\n" +
							"Type =" + Type +  "\n" +
							"Brave = " + Brave +  "\n" +
							"Dumb = " + Dumb +  "\n" +
							"BadAss = " +Bads +  "\n" +
							"Tour = " + Tour +  "\n" +
							"State = " + State +  "\n" +
							"ToD = " + ToD +  "\n" +
							"Flights = " + Flights +  "\n";
			Debug.WriteLine( printables );
		}

	}
}