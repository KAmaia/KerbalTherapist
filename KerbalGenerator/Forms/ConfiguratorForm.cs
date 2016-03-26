using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KerbalGenerator {
	public partial class ConfiguratorForm : Form {
		Configurator cfgr;
		public ConfiguratorForm(Configurator cfgr ) {
			InitializeComponent( );
			this.cfgr = cfgr;
		}

		private void btn_Cancel_Click( object sender, EventArgs e ) {
			Application.Exit( );
		}

		private void btn_create_config_Click( object sender, EventArgs e ) {
			cfgr.CreateConfig( txt_ConfigName.Text, txt_kspPath.Text );
			this.Close( );
		}




		private void ShowPathError( string s, bool success ) {
			lbl_PathErr.ForeColor = success ? Color.Green : Color.Red;
			lbl_PathErr.Text = s;
		}

		private void txt_kspPath_TextChanged( object sender, EventArgs e ) {
			bool validPath = cfgr.ValidatePath(txt_kspPath.Text);
			ShowPathError( validPath ? "Valid Path Found" : "Sorry, That Path Does Not Exist", validPath );
			if ( validPath ) {
				validPath = cfgr.countSavesInPath(txt_kspPath.Text) > 0;
				ShowPathError( validPath ? "Valid Saves Found.  Click Create Config to Continue" : "Sorry, no Valid Saves in that directory", validPath );
			}
		}

		private void txt_kspPath_TextChanged_1( object sender, EventArgs e ) {

		}
	}
}
