using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace KerbalGenerator {
	public class Config {
		public Dictionary<string, string> SavePaths { get; set; }
		public string KSPPath { get; set; }
		public string Name { get; set; }
	}
}
