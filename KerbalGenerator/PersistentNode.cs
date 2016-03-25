using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalGenerator {
	class PersistentNode {
		List<PersistentNode> nodes;
		string name;
		private string v;

		public string Name { get; internal set; }

		public PersistentNode() {
			this.name = name;

		}

		public PersistentNode( string v ) {
			this.v = v;
		}

		internal void AddValue( string pairKey, string pairValue ) {
			throw new NotImplementedException( );
		}
	}
}
