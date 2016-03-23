using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KerbalGenerator {
	public partial class Configurator : Form {
		private string configPath;

		public Configurator( string configPath ) {
			this.configPath = configPath;
			InitializeComponent( );
		}

		public Config LoadConfig( ) {
			Config cfg = new Config();
			XmlDocument doc = new XmlDocument();
			XmlTextReader rdr = new XmlTextReader(configPath + "\\config.xml");
			String line = "";

			Dictionary<string, string> confDict = new Dictionary<string, string>();
			while ( ( rdr.Read( ))) {
				if ( rdr.NodeType.Equals( XmlNodeType.Element ) ) { }
				string configName = rdr.Name;
				cfg.Name = configName;
				if ( rdr.Name.ToLower( ).Equals( "save" ) ) {
					if ( !confDict.ContainsKey( rdr.GetAttribute( "name" ) ) ) {
						confDict.Add( rdr.GetAttribute( "name" ), rdr.GetAttribute( "path" ) );
						cfg.SavePaths = confDict;
					}
				}
			}

			return cfg;
		}


		private void btn_create_config_Click( object sender, EventArgs e ) {
			string configName = txt_ConfigName.Text;
			string path = txt_kspPath.Text;
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

				if ( saves.Count == 0 ) {
					ShowPathError( "Sorry, No Valid Saves In That Directory", false );
				}
				//declare the XML document.
				XmlDocument config = new XmlDocument();
				config.CreateXmlDeclaration( "1.0", "", "" );
				//Root node - Program configuration.
				XmlNode root = config.CreateElement("configuration");
				//Child Node - Ksp Install
				XmlNode xmlKSP = config.CreateElement("ksp");

				XmlAttribute name = config.CreateAttribute("name");

				name.Value = txt_ConfigName.Text;
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
			this.Close( );
		}

		private List<string> EnumerateDirectory( string path ) {
			List<string> innerFiles = new List<string>();
			foreach ( string dir in Directory.EnumerateDirectories( path ) ) {
				innerFiles.Add( dir.Substring( dir.LastIndexOf( "\\" ) + 1 ) );
			}
			return innerFiles;
		}


		private void ShowPathError( string s, bool success ) {
			lbl_PathErr.ForeColor = success ? Color.Green : Color.Red;
			lbl_PathErr.Text = s;
		}

		private bool ValidateConfigName( string name ) {
			bool retval = true;
			//read in the xml file
			XmlDocument doc = new XmlDocument();
			doc.Load( configPath + "\\config.xml" );
			foreach ( XmlElement xe in doc ) {
				if ( xe.Name == "ksp" ) {
					foreach ( XmlAttribute xa in xe ) {
						if ( xa.Name == "name" ) {
							if ( xa.Value == name ) {
								retval = false;
							}
						}
					}
				}
			}
			return retval;
		}

		private bool ValidateFile( string filePath ) {
			return File.Exists( filePath );
		}
		private bool ValidatePath( string path ) {
			return Directory.Exists( path );
		}

		private void btn_Cancel_Click( object sender, EventArgs e ) {
			Application.Exit( );
		}



		private void txt_kspPath_TextChanged( object sender, EventArgs e ) {
			bool validPath = ValidatePath(txt_kspPath.Text);
			ShowPathError( validPath ? "Valid Path Found" : "Sorry, That Path Does Not Exist", validPath );
		}

		private void txt_ConfigName_TextChanged( object sender, EventArgs e ) {
		}
	}
}
