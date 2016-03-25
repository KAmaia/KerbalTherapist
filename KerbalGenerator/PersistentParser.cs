using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace KerbalGenerator {
	class PersistentParser {
		private StreamReader rdr;
		public PersistentParser(string persistPath ) {
			
		}
		public void Parse(string persistPath ) {
			int currentlevel = 0;
			string line ="";
			string prevLine="";

			string blockName = "";
			StringBuilder passData = null;

			PersistentNode returnNode = new PersistentNode();
			rdr = new StreamReader( persistPath );
			while ((line = rdr.ReadLine())!=null ) {
				prevLine = line;
				string trimmedLine = TrimLine(line);
				//Check for { this represents the start of a new block
				//set block to PrevLine.  

				//start of new block
				if ( trimmedLine.Equals( "{" ) ) {
					currentlevel++;
					//if we're one level in, create a new block.
					if ( currentlevel == 1 ) {
						passData = new StringBuilder( );
						continue;
					}
				}
				//At the end of a node, 
				if ( trimmedLine.Equals( "}" ) ) {
					currentlevel--;
					if(currentlevel == 0 ) {
						//at the end of a block.
						PersistentNode newNode = new PersistentNode(passData.ToString());
						newNode.Name = blockName;
						blockName = null;
						passData = null;
						continue;

					}
				}
				if(currentlevel == 0 ) {
					//we're now reading data.
					if ( trimmedLine.Contains( "=" ) ) {
						string[] trimmedAndSplit = TrimAndSplit( trimmedLine );
						string pairKey = trimmedAndSplit[0];
						string pairValue = trimmedAndSplit[1];
						returnNode.AddValue( pairKey, pairValue );
					}
				}
				else {
					passData.Append( trimmedLine );
				}
			}
		}
		private string[] TrimAndSplit(string line ) {
			string[] trimmedLine = line.Split('=');
			for(int i = 0; i < trimmedLine.Length - 1; i++ ) {
				trimmedLine[i] = trimmedLine[i].Trim( );
			}
			return trimmedLine;
		}
		private string TrimLine(string line ) {
			return line.Trim( );
		}
	}
}
