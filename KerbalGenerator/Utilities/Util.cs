using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalTherapist {
	class Util {
		private static Random rnd = new Random();
		public static float GetRandomFloat() {
			return (float) rnd.NextDouble( );
			
		} 
		public static string CapitalizeString(string str ) {
			//handle splitting the string if it has a space. 
			string[ ] tmp = str.Split(' ');
			string retVal = "";
			foreach ( string s in tmp ) {
				char[] c =s.ToCharArray();
				c[0] = char.ToUpper( c[0] );
				retVal = retVal + " " + new string( c );
			}
			return retVal.Trim( );
		}

		public static float GetRandomFloatInRange(float min, float max ) {
			float ret = (float) rnd.NextDouble();
			while(!(ret < max) && !(ret > min ) ) {
				ret = (float) rnd.NextDouble( );
			}
			return ret;
		}

		public static int GetRandomIntInRange( int min, int max ) {
			return rnd.Next( min, max );
		}
	}
}
