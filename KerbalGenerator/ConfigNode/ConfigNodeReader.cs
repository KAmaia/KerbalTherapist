/*
 * All ConfigNode Related Code is thanks to: darklight in #kspmodders on the esper.net IRC network.  
 * This source code is public domain'd, and any section of ConfigNode related code found in this project,
 * with this header is released freely into the public domain with no regard to any other license applied to this
 * project.  
 */

using KerbalTherapist.Logging;
using System;
using System.IO;
using System.Text;

namespace ConfigNodeParser {
	public class ConfigNodeReader {
		public static ConfigNode StringToConfigNode( string inputString ) {
			ConfigNode node = null;
			using ( StringReader sr = new StringReader( inputString ) ) {
				node = BuildConfigNode( sr, null );
			}
			return node;
		}

		public static ConfigNode BuildConfigNode( StringReader sr, string name ) {
			ConfigNode node = new ConfigNode();
			node.name = name;
			string previousLine = null;
			string currentLine = null;
			while ( ( currentLine = sr.ReadLine( ) ) != null ) {
				string trimmedLine = currentLine.TrimStart();
				if ( trimmedLine == "{" ) {
					node.AddConfigNode( BuildConfigNode( sr, previousLine ) );
				}
				if ( trimmedLine == "}" ) {
					return node;
				}
				if ( trimmedLine.Contains( " = " ) ) {
					string pairKey = trimmedLine.Substring(0, trimmedLine.IndexOf(" = "));
					string pairValue = trimmedLine.Substring(trimmedLine.IndexOf(" = ") + 3);
					node.AddValue( pairKey, pairValue );
				}
				previousLine = trimmedLine;
			}
			return node;
		}

		public static ConfigNode FileToConfigNode( string inputFile ) {
			string configNodeText = File.ReadAllText(inputFile);
			return StringToConfigNode( configNodeText );

		}
	}
}

