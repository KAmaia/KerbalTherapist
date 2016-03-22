using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
		private XmlTextWriter xmlw;

		public Configurator( string configPath ) {
			this.configPath = configPath;
			InitializeComponent( );
		}


		private void btn_create_config_Click( object sender, EventArgs e ) {
			string configName = txt_ConfigName.Text;
			string path = txt_kspPath.Text;

			List<string> saves = new List<string>();

			if ( !Directory.Exists( configPath ) ) {
				Directory.CreateDirectory( configPath );
			}

			if ( !Directory.Exists( path ) ) {
				MessageBox.Show( "Sorry, That Path Does Not Exist.", "KSP Not Found There!" );
		
			}

			else {
				path = path + "\\saves";
				foreach ( string dir in Directory.EnumerateDirectories( path ) ) {
					string tmp = dir.Substring( dir.LastIndexOf( "\\" ) + 1 );
					//if the directory name equals scenarios or training
					//ignore the directory.
					if ( tmp.ToLower( ).Equals( "scenarios" ) || tmp.ToLower( ).Equals( "training" ) ) {
						continue;
					}
					else {
						saves.Add( tmp );
					}
				}
				//check to make sure that there actually non-stock saves in the directory
				if ( saves.Count == 0 ) {
					MessageBox.Show( "Sorry, there are no non-stock saves in that directory.  Try A Different Directory.",
						"No Saves Detected!" );
				}
				//otherwise create the configuration file for the specified KSP install.
				else {
					//declare the XML document.
					XmlDocument config = new XmlDocument();
					config.CreateXmlDeclaration( "1.0", "", "" );
					//Root node - Program configuration.
					XmlNode root = config.CreateElement("configuration");
					config.AppendChild( root );

					//Child Node - Ksp Install
					XmlNode ksp = config.CreateElement("ksp");
					XmlAttribute name = config.CreateAttribute("name");
					name.Value = txt_ConfigName.Text;
					ksp.Attributes.Append( name );
					root.AppendChild( ksp );

					//child nodes saves
					foreach ( string s in saves ) {
						string tmp = path + "\\"+s;
						string gutName = s.Replace(' ', '_');
						XmlNode save = config.CreateElement(gutName);
						XmlAttribute savePath = config.CreateAttribute("path");
						savePath.Value = tmp;
						save.Attributes.Append( savePath );
						ksp.AppendChild( save );
					}
					config.Save( configPath + "\\config.xml" );
				}


				this.Close( );
			}
		}

		private void btn_Cancel_Click( object sender, EventArgs e ) {
			Application.Exit( );
		}
	}
}