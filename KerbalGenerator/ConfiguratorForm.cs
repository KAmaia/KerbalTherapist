using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerbalGenerator {
	public partial class ConfiguratorForm : Form {
		Configurator cfgr;
		public ConfiguratorForm(ref Configurator cfgr ) {
			InitializeComponent( );
			this.cfgr = cfgr;
		}

		private void btn_Cancel_Click( object sender, EventArgs e ) {

		}

		private void btn_create_config_Click( object sender, EventArgs e ) {
			if ( cfgr.SaveCount == 0 ) {
				ShowPathError( "Sorry, No Valid Saves In That Directory", false );
			}
		}



		private void ShowPathError( string s, bool success ) {
			lbl_PathErr.ForeColor = success ? Color.Green : Color.Red;
			lbl_PathErr.Text = s;
		}

		private void txt_kspPath_TextChanged( object sender, EventArgs e ) {
			bool validPath = cfgr.ValidatePath(txt_kspPath.Text);
			ShowPathError( validPath ? "Valid Path Found" : "Sorry, That Path Does Not Exist", validPath );
		}

	}
}
