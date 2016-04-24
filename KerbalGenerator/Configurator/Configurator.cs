using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using ConfigNodeParser;
using KerbalTherapist.Logging;

namespace KerbalTherapist {
	public class Configurator {
		private string configPath;
		private string configurationFilePath;
		private Config configuration;
		private ConfiguratorForm cfgrForm;

		public Config Configuration { get { return configuration; } }

		public int SaveCount;

		public Configurator ( string configPath ) {
			this.configPath = configPath;
			configuration = new Config ( );
			configurationFilePath = Path.Combine ( configPath, "config.cfg" );
			Logger.LogEvent ( "Configurator Initialized." );
			Logger.LogNewLine ( "Config Path: " + configPath );
			Logger.LogNewLine ( "ConfigFile: " + configurationFilePath );
		}

		public void LoadConfig ( ) {
			Logger.LogEvent ( "Loading Configuration:" );
			try {
				Logger.LogNewLine ( "Creating new Config Object" );
				Config cfg = new Config ( );
				ConfigNode cnConfig = ConfigNode.Load ( configurationFilePath ).GetNode ( "Kerbal_Therapist_Configuration" );
				cnConfig = cnConfig.GetNode ( "KSP_Install" );
				Logger.LogEvent ( cnConfig.name );
				cfg.Name = cnConfig.GetValue ( "name" );
				cfg.KSPPath = cnConfig.GetValue ( "kspPath" );
				foreach ( ConfigNode cNode in cnConfig.GetNodes("ksp_save") ) {
					cfg.SavePaths.Add ( cNode.GetValue ( "name" ), cNode.GetValue ( "path" ) );
				}

				configuration = cfg;
				Logger.LogNewLine ( "Configuration Loaded Successfully!" );
			}
			catch ( Exception e ) {
				Logger.LogError ( e, this );
			}
		}


		internal void FirstRun ( ) {
			cfgrForm = new ConfiguratorForm ( this, true );
			cfgrForm.ShowDialog ( );
		}

		internal void ShowForm ( ) {
			cfgrForm.Show ( );
		}

		public void CreateConfig ( string _configName, string _kspPath ) {
			string configName = _configName;
			string kspPath = _kspPath;
			List<string> saves = new List<string> ( );
			if ( !ValidatePath ( configPath ) ) {
				Logger.LogEvent ( "Config Path Not Found, Creating!" );
				Directory.CreateDirectory ( configPath );
				Logger.LogEvent ( "Checking..." );
				if ( ValidatePath ( configPath ) ) {
					Logger.LogNewLine ( "Success!" );
					Logger.LogEvent ( "Checking FilePath: " + configurationFilePath );
					if ( !ValidateFile ( configurationFilePath ) ) {
						Logger.LogNewLine ( "File Does Not Exist." );
					}
					else {
						Logger.LogNewLine ( "File Exists as of Line 99: Configurator.CreateConfig()" );
					}
				}
				else {
					Logger.LogNewLine ( "Failure Occured on Line 103 of Configurator" );
				}
			}

			Logger.LogEvent ( "ConfigPath successfully Validated or Created." );
			Logger.LogNewLine ( "Creating New Config From Scratch" );
			//get our save directory and enumerate it.
			string savePath = Path.Combine ( kspPath, "saves" );
			saves = EnumerateDirectory ( savePath );
			Logger.LogNewLine ( "Created Saves from: " + kspPath );

			foreach ( string s in saves ) {
				Logger.LogEvent ( "Save: " + s + " found" );
			}

			//Remove Scenarios && Training from Saves;
			saves.Remove ( Path.Combine ( savePath, "scenarios" ) );
			saves.Remove ( Path.Combine ( savePath, "training" ) );
			Logger.LogNewLine ( "Removed Scenarios and Training" );

			SaveCount = saves.Count;
			Logger.LogNewLine ( saves.Count.ToString ( ) + " Saves Loaded" );


			//Declare the confignode document
			ConfigNode cnConfig = new ConfigNode ( );
			//declare the root node
			ConfigNode rootNode = new ConfigNode ( );
			//Root Node - Kerbal Therapist Configuration.
			rootNode.name = "Kerbal_Therapist_Configuration";

			//ChildNode - Ksp Install
			ConfigNode installNode = new ConfigNode ( "KSP_Install" );
			installNode.AddValue ( "name", configName );
			installNode.AddValue ( "kspPath", kspPath );

			//child nodes saves
			foreach ( string s in saves ) {
				//generate a save node to track where our ksp saves are.
				ConfigNode saveNode = new ConfigNode ( "ksp_save" );
				string saveName = s.Remove ( 0, s.LastIndexOf ( Path.DirectorySeparatorChar ) + 1 );
				Logger.LogEvent ( "Save Name = " + saveName );
				saveNode.AddValue ( "name", saveName );
				string gutName = Path.Combine ( s, "persistent.sfs" );
				saveNode.AddValue ( "path", Path.Combine ( kspPath, gutName ) );

				installNode.AddConfigNode ( saveNode );
				Logger.LogNewLine ( "Created New Save: " + s );
				Logger.LogNewLine ( "From File: " + gutName );
			}
			rootNode.AddConfigNode ( installNode );
			cnConfig.AddConfigNode ( rootNode );
			cnConfig.Save ( configurationFilePath );
			/*
			//append our nodes.  KspNode to root, root to config.
			root.AppendChild ( xmlNodeKSP );
			xmlConfiguration.AppendChild ( root );
			xmlConfiguration.InsertBefore ( xmlDec, root );
			xmlConfiguration.Save ( configurationFilePath );
			*/
			Logger.LogEvent ( "Configuration Creation Complete!" );
		}



		public int countSavesInPath ( string path ) {
			//first validate the path.
			if ( ValidatePath ( path ) ) {
				List<string> saves = EnumerateDirectory ( path );
				saves.Remove ( "scenarios" );
				saves.Remove ( "training" );
				return saves.Count;
			}
			else {
				return 0;
			}
		}

		private List<string> EnumerateDirectory ( string path ) {
			List<string> innerFiles = new List<string> ( );
			foreach ( string dir in Directory.EnumerateDirectories( path ) ) {
				innerFiles.Add ( dir.Substring ( dir.LastIndexOf ( "\\" ) + 1 ) );
			}
			return innerFiles;
		}

		private bool ValidateConfigName ( string name ) {
			bool isValid = false;
			if ( ValidateFile ( configurationFilePath ) ) {
				//read in the xml file
				XmlDocument doc = new XmlDocument ( );
				doc.Load ( configurationFilePath );
				foreach ( XmlElement xe in doc ) {
					if ( xe.Name == "ksp" ) {
						foreach ( XmlAttribute xa in xe ) {
							if ( xa.Name == "name" ) {
								isValid = !( xa.Value.ToLower ( ) == name.ToLower ( ) );
							}
						}
					}
				}
			}
			return isValid;
		}


		public bool ValidateFile ( string filePath ) {
			return File.Exists ( filePath );
		}

		public bool ValidatePath ( string path ) {
			return Directory.Exists ( path );
		}
	}
}
