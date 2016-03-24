using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalGenerator {
	class Util {
		private static Random rnd = new Random();
		public static float getRandFloat() {
			return (float) rnd.NextDouble( );
		} 
	}
}
