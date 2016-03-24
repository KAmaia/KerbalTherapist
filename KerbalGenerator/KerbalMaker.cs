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
									string bads, string tour ) {
			Kerbal k;

			if ( kerman ) {
				name += " Kerman";
			}
			k = new Kerbal( name, gender, trait, "crew", brave.ToString(), dumb.ToString(), bads, tour, "Available", "0", "0" );
			showPreviewWindow( k );
			return k;
		}

		private void showPreviewWindow( Kerbal k ) {
			kpw = new KerbalPreviewWindow( k );
			kpw.Show( );
		}

		public Kerbal generateSpecific( bool randomName, bool kerman, string gender, 
									string trait, float brave, float dumb, 
									string bads, string tour) {
			Kerbal k;
			string name = "";
			bool female = gender.ToLower().Equals("female");
			if ( randomName ) {
				if ( kerman ) {
					name += genFirst( female );
				}
				else {
					name += genFirstAndLast( female );
				}
			}

			k= new Kerbal( name, gender, trait, "crew", brave.ToString(), dumb.ToString(), bads, tour, "Available", "0", "0" );
			showPreviewWindow( k );
			return k;
		}

		private string genFirst( bool female ) {
			if ( female ) {
				return "Hurdy Durr Kerman";
			}
			else {
				return "Derp Derp Kerman";
			}
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
