using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KerbalGenerator {
	public class Config {
		public Dictionary<string, Kerbal> Kerbals { get; set; }
		public string KspPath { get; set; }
		public string name { get; set; }
	}
}
