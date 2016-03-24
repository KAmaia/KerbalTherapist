using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalGenerator {
	class KerbalMaker {
		KerbalPreviewWindow kpw;

		public Kerbal generateSpecific( string name, bool kerman, string gender,
									string trait, float brave, float dumb,
									bool badass, bool tourist ) {

			string bads = badass.ToString();
			string tour = tourist.ToString();
			if ( kerman ) {
				name += " Kerman";
			}

			Kerbal k = new Kerbal( name, gender, trait,
							"crew", brave.ToString( ),
							dumb.ToString( ), bads,
							tour, "Available", "0", "0" );
			return k;
		}

		public Kerbal generateSpecific(bool randomName, bool kerman, string gender,
									string trait, float brave, float dumb,
									bool badass, bool tourist ) {
			string name = "";
			bool female = gender.ToLower().Equals("female");
			string bads = badass.ToString();
			string tour = tourist.ToString();



			if ( randomName ) {
				if ( kerman ) {
					name += genFirst( female );
				}
				else {
					name += genFirstAndLast( female );
				}
			}

			Kerbal k = new Kerbal( name, gender, trait, "crew", brave.ToString( ), dumb.ToString( ), bads, tour, "Available", "0", "0" );
			return k;
		}

		private string genFirst( bool female ) {
			return female ? "Hurdy Durr Kerman" : "Derp Derp Kerman";
		}
		private string genFirstAndLast( bool female ) {
			if ( female ) {
				return "Hurdy Durr";
			}
			else {
				return "Derp Derp";
			}
		}
	}
}
