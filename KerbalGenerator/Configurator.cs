using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;

namespace KerbalGenerator {
	public partial class Configurator {
		private string configPath;
		private Config config;

		public Config Configuration { get { return config; } }
		public int SaveCount;

		public Configurator( string configPath ) {
			this.configPath = configPath;
		}

		public void LoadConfig( ) {
			Config cfg = new Config();
			XmlDocument doc = new XmlDocument();
			XmlTextReader rdr = new XmlTextReader(configPath + "\\config.xml");
			Dictionary<string, string> confDict = new Dictionary<string, string>();
			while ( ( rdr.Read( ) ) ) {
				if ( rdr.NodeType.Equals( XmlNodeType.Element ) ) { }
				string configName = rdr.Name;
				if ( rdr.Name.ToLower( ).Equals( "ksp" ) ) {
					configName = rdr.GetAttribute("name");
					
				}
				cfg.Name = configName;
				if ( rdr.Name.ToLower( ).Equals( "save" ) ) {
					if ( !confDict.ContainsKey( rdr.GetAttribute( "name" ) ) ) {
						confDict.Add( rdr.GetAttribute( "name" ), rdr.GetAttribute( "path" ) );
						cfg.KSPPath = rdr.GetAttribute( "path" ).Remove( rdr.GetAttribute( "path" ).LastIndexOf( "\\saves" ) );
						cfg.SavePaths = confDict;
					}
				}
			}
			config = cfg;
		}

		public void create_config( string _configName, string _path ) {
			string configName = _configName;
			string path = _path;
			List<string> saves = new List<string>();
			if ( !ValidatePath( configPath ) ) {
				Directory.CreateDirectory( configPath );
			}

			else {
				//get our save directory and enumerate it.
				path = path + "\\saves";
				saves = EnumerateDirectory( path );

				//Remove Scenarios && Training from Saves;
				saves.Remove( "scenarios" );
				saves.Remove( "training" );

				SaveCount = saves.Count;

				//declare the XML document.
				XmlDocument config = new XmlDocument();
				config.CreateXmlDeclaration( "1.0", "", "" );
				//Root node - Program configuration.
				XmlNode root = config.CreateElement("configuration");
				//Child Node - Ksp Install
				XmlNode xmlKSP = config.CreateElement("ksp");

				XmlAttribute name = config.CreateAttribute("name");

				name.Value = configName;
				xmlKSP.Attributes.Append( name );

				root.AppendChild( xmlKSP );
				config.AppendChild( root );
				//child nodes saves
				foreach ( string s in saves ) {
					string gutName = s.Replace(' ', '_');
					XmlNode xmlSave = config.CreateElement(gutName);
					XmlAttribute savePath = config.CreateAttribute("path");
					savePath.Value = path + "\\" + s;
					xmlSave.Attributes.Append( savePath );
					xmlKSP.AppendChild( xmlSave );
				}
				config.Save( configPath + "\\config.xml" );
			}
		}

		private List<string> EnumerateDirectory( string path ) {
			List<string> innerFiles = new List<string>();
			foreach ( string dir in Directory.EnumerateDirectories( path ) ) {
				innerFiles.Add( dir.Substring( dir.LastIndexOf( "\\" ) + 1 ) );
			}
			return innerFiles;
		}

		private bool ValidateConfigName( string name ) {
			string configPathFinal = configPath + "\\config.xml";
			bool isValid = false;
			if ( ValidateFile( configPathFinal ) ) {
				//read in the xml file
				XmlDocument doc = new XmlDocument();
				doc.Load( configPathFinal );
				foreach ( XmlElement xe in doc ) {
					if ( xe.Name == "ksp" ) {
						foreach ( XmlAttribute xa in xe ) {
							if ( xa.Name == "name" ) {
								isValid = !( xa.Value.ToLower( ) == name.ToLower( ) );
							}
						}
					}
				}
			}
			return isValid;
		}


		public bool ValidateFile( string filePath ) {
			return File.Exists( filePath );
		}
		public bool ValidatePath( string path ) {
			return Directory.Exists( path );
		}
	}
}
