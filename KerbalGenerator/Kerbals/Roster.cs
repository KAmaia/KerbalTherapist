using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalGenerator {
	class Roster {
		private Dictionary<string, Kerbal>kerbals;
		public Roster( ) {
			kerbals = new Dictionary<string, Kerbal>( );
		}

		public bool ValidateKerbal(string name ) {
			foreach ( Kerbal k in kerbals.Values ) {
				if ( k.GetName().ToLower( ).Equals( name.ToLower() ) ) {
					return false;
				}
			}
			return true;
		}

		public bool ValidateKerbal(Kerbal k ) {
			foreach (string kerb in kerbals.Keys ) {
				if ( kerb.ToLower( ).Equals( k.GetName().ToLower( ) )){
					return false;
				}
			}
			return true;
		}

		public void AddKerbal( Kerbal k ) {
			//make sure K doesn't exist in roster
			if ( !( kerbals.ContainsKey( k.GetName( ) ) )){
				kerbals.Add( k.GetName(), k );
			}
			//if it does, delete it, then add it again.
			else {
				kerbals.Remove( k.GetName( ) );
				kerbals.Add( k.GetName( ), k );
			}
		}
		

		public List<string> GetNames( ) {
			return kerbals.Keys.ToList();
		}
		
		public List<Kerbal> getKerbals( ) {
			return kerbals.Values.ToList();
		}

		public Kerbal GetKerbal(int index ) {
			return kerbals.ElementAt( index ).Value;
		}
		
		public Kerbal GetKerbal( string selectedKerbal ) {
			return kerbals[selectedKerbal];
		}
	}
}
