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
		private Config config;

		public Configurator( string configPath ) {
			this.configPath = configPath;
			InitializeComponent( );
		}

		public Config LoadConfig( ) {
			Config cfg = new Config();

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
						//check to make sure that there actually non-stock saves in the directory
						if ( saves.Count == 0 ) {
							lbl_PathErr.ForeColor = Color.Red;
							lbl_PathErr.Text = "Sorry, there are no valid saves in that directory.  Try A Different Directory.";
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
								tmp = path + "\\" + s;
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
			}
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

		private bool ValidatePath( string path ) {
			return Directory.Exists( path );
		}

		private void btn_Cancel_Click( object sender, EventArgs e ) {
			Application.Exit( );
		}



		private void txt_kspPath_TextChanged( object sender, EventArgs e ) {
			if ( !ValidatePath( txt_kspPath.Text ) ) {
				lbl_PathErr.ForeColor = Color.Red;
				lbl_PathErr.Text = "Sorry, That Path Does Not Exist.";
			}
			else if ( ValidatePath( txt_kspPath.Text ) ) {
				lbl_PathErr.ForeColor = Color.Green;
				lbl_PathErr.Text = "Valid Path Found!";
			}
		}

		private void txt_ConfigName_TextChanged( object sender, EventArgs e ) {
			if ( ValidateConfigName( txt_ConfigName.Text ) ) {
				lbl_ConfigErr.ForeColor = Color.Green;
				lbl_ConfigErr.Text = "That Config Name Is Valid";
			}
			else if ( !ValidateConfigName( txt_ConfigName.Text )){
				lbl_ConfigErr.ForeColor = Color.Red;
				lbl_ConfigErr.Text = "Name is in use.  Please Try again";
			}
		}
	}
}
