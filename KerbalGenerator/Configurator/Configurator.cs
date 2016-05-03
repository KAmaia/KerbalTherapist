//Copyright (C) 2016 Amaia Industries
//
//Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
//associated documentation files (the "Software"), to deal in the Software without restriction, 
//including without limitation the rights to use, copy, modify, merge, publish, and distribute 
//copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
//	Notice:
//	The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
//	Modifications:
//	Any modified version or derivative of this software must include a link to the original source code.  Distributing the original source code with the 
//	release of the modified version shall be construed to satisfy this clause.
//
//	Attribution:
//	Any modified version or derivative of this software must include attribution to the original author.  
//
//	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
//	INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
//	PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE Amaia Industries 
//	BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//	TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE 
//	USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//	Except as contained in this notice, the name of Amaia Industries shall not be used in advertising or 
//	otherwise to promote the sale, use or other dealings in this Software without prior written authorization from Amaia Industries.

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
				foreach ( ConfigNode cNode in cnConfig.GetNodes( "ksp_save" ) ) {
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
			Logger.LogNewLine ( "Created Saves from: " + savePath );

			foreach ( string s in saves ) {
				Logger.LogEvent ( "Save: " + s + " found" );
			}

			//Remove Scenarios && Training from Saves;
			saves.Remove ( "scenarios" );
			saves.Remove ( "training" );

			Logger.LogEvent ( "Removing Scenarios And Training" );
			foreach ( string s in saves ) {
				Logger.LogNewLine ( "======" + s + "Removed!" );
			}

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
				saveNode.AddValue ( "path", Path.Combine ( savePath, gutName ) );
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
