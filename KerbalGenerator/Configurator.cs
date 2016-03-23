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
			doc.Load( configPath + "\\config.xml" );
			
			return new Config( );
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
				//Child Attrib. - Name of the Kerbal Space Program Save.
				XmlAttribute xmlKSPName = config.CreateAttribute("name");
				//append the root node
				config.AppendChild( root );
				//Append the Child Node to the Root.
				root.AppendChild( xmlKSP );
				//Set our name from the configurator window.
				xmlKSPName.Value = txt_ConfigName.Text;
				//append that attrib. to the XMLKSP node
				xmlKSP.Attributes.Append( xmlKSPName );

				//Generate Our Save Paths.

				foreach ( string s in saves ) {
					string gutName = s.Replace(' ', '_');
					XmlNode xmlSave = config.CreateElement("save");
					XmlAttribute xmlSaveNameAttrib = config.CreateAttribute("name");
					XmlAttribute savePath = config.CreateAttribute("path");
					xmlSaveNameAttrib.Value = gutName;
					savePath.Value = path + "\\" + s + "\\persistent.sfs";
					xmlSave.Attributes.Append( xmlSaveNameAttrib );
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
