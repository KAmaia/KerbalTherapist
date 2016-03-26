using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;

namespace KerbalGenerator {
	public class Configurator {
		private string configPath;
		private string configurationFilePath;
		private Config config;
		private ConfiguratorForm cfgrForm;

		public Config Configuration { get { return config; } }
		public int SaveCount;

		public Configurator( string configPath ) {
			this.configPath = configPath;
			configurationFilePath = Path.Combine( configPath, "config.xml" );
		}

		public void LoadConfig( ) {
			Config cfg = new Config();
		
			XmlDocument doc = new XmlDocument();
			XmlTextReader rdr = new XmlTextReader(configurationFilePath);
			Dictionary<string, string> confDict = new Dictionary<string, string>();
			while ( ( rdr.Read( ) ) ) {
				if ( rdr.NodeType.Equals( XmlNodeType.Element ) ) { }
				string configName = rdr.Name;
				if ( rdr.Name.ToLower( ).Equals( "ksp" ) ) {
					configName = rdr.GetAttribute( "name" );

				}
				cfg.Name = configName;
				if ( rdr.Name.ToLower( ).Equals( "save" ) ) {
					if ( !confDict.ContainsKey( rdr.GetAttribute( "name" ) ) ) {
						confDict.Add( rdr.GetAttribute( "name" ), rdr.GetAttribute( "path" ) );
						string kspPath = rdr.GetAttribute("path");
						cfg.KSPPath = rdr.GetAttribute( "path" ).Remove( rdr.GetAttribute( "path" ).LastIndexOf(Path.DirectorySeparatorChar + "saves") );
						cfg.SavePaths = confDict;
					}
				}
			}
			config = cfg;
		}

		internal void FirstRun( ) {
			cfgrForm = new ConfiguratorForm( this );
			cfgrForm.ShowDialog( );
		}

		internal void ShowForm( ) {
			cfgrForm.Show( );
		}

		/// <summary>
		/// Creates an XML Formatted configuration file.
		/// </summary>
		/// <param name="_configName">
		/// This text is passed in from ConfiguratorForm.lbl_configName.Text.
		/// it is not the name of the configuration file, but of the config within it.  
		/// this is to allow for multiple configurations to be managed in the future.
		/// </param>
		/// <param name="_kspPath">
		/// This is the path to your Kerbal Space Program Install.  It is passed in from ConfiguratorForm.
		/// </param>
		public void CreateConfig( string _configName, string _kspPath ) {
			string configName = _configName;
			string kspPath = _kspPath;
			List<string> saves = new List<string>();
			if ( !ValidatePath( configPath ) ) {
				Directory.CreateDirectory( configPath );
			}

			else {
				//append config.xml to path, so that way things are pretty...
				//get our save directory and enumerate it.
				kspPath = Path.Combine( kspPath,  "saves" );
				saves = EnumerateDirectory( kspPath );

				//Remove Scenarios && Training from Saves;
				saves.Remove( "scenarios" );
				saves.Remove( "training" );

				SaveCount = saves.Count;

				//declare the XML document.
				XmlDocument config = new XmlDocument();
				XmlDeclaration xmlDec = config.CreateXmlDeclaration( "1.0", "", "" );
				
				//Root node - Program configuration.
				XmlNode root = config.CreateElement("configuration");
				//Child Node - Ksp Install
				XmlNode xmlNodeKSP = config.CreateElement("ksp");
				XmlAttribute xmlAttrConfigName = config.CreateAttribute("name");

				//assign the name of our config to the attribute for ksp;
				//should be blah or hurdydurr for testing.
				xmlAttrConfigName.Value = configName;
				xmlNodeKSP.Attributes.Append( xmlAttrConfigName );

				//child nodes saves
				foreach ( string s in saves ) {
					//generate a save node to track where our ksp saves are.
					XmlNode xmlNodeKspSaveLocation = config.CreateElement("save");
					//create an attribute to track our ksp save name.
					XmlAttribute xmlKspSaveName = config.CreateAttribute("name");
					xmlKspSaveName.Value = s;

					//Combine s & persistent.sfs to append later on.
					string gutName = Path.Combine(s,"persistent.sfs");

					//create an attribute to track our save path.
					XmlAttribute savePath = config.CreateAttribute("path");
					savePath.Value = Path.Combine( kspPath, gutName );

					xmlNodeKspSaveLocation.Attributes.Append( xmlKspSaveName );
					xmlNodeKspSaveLocation.Attributes.Append( savePath );
					xmlNodeKSP.AppendChild( xmlNodeKspSaveLocation );
				}

				//append our nodes.  KspNode to root, root to config.
				root.AppendChild( xmlNodeKSP );
				config.AppendChild( root );
				config.InsertBefore( xmlDec, root );
				config.Save( configurationFilePath);
			}
		}

		public int countSavesInPath( string path ) {
			//first validate the path.
			if ( ValidatePath( path ) ) {
				List<string> saves = EnumerateDirectory(path);
				saves.Remove( "scenarios" );
				saves.Remove( "training" );
				return saves.Count;
			}
			else {
				return 0;
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
			bool isValid = false;
			if ( ValidateFile( configurationFilePath ) ) {
				//read in the xml file
				XmlDocument doc = new XmlDocument();
				doc.Load( configurationFilePath );
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
