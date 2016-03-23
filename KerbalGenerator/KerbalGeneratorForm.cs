using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerbalGenerator {
	public partial class frm_Krb_Gen : Form {
		private readonly string configPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Badwater\\KerbalGen";
		private string kspInstallPath;

		private Configurator configurator;



		private List<Kerbal> currentKerbals;

		private Config cfg;

		public frm_Krb_Gen(  ) {
			InitializeComponent( );
			//load our config manager.
			configurator = new Configurator( configPath );

		}

		private bool firstRun( ) {
			return !File.Exists( configPath + "\\config.xml" );
		}


		private void btn_gen_One_Kerb_Click( object sender, EventArgs e ) {

		}
		private void btn_gen_List_Kerb_Click( object sender, EventArgs e ) {

		}
		private void btn_exit_Click( object sender, EventArgs e ) {
			Application.Exit( );
		}
		private void btn_view_Kerbals_Click( object sender, EventArgs e ) {
			
			
		}
		private void frm_Krb_Gen_Load( object sender, EventArgs e ) {
		}

		private void cmb_AvailSaves_SelectedIndexChanged( object sender, EventArgs e ) {

		}

		private void btn_gen_List_Kerb_Click_1( object sender, EventArgs e ) {

		}

		private void label3_Click( object sender, EventArgs e ) {

		}

		private void label19_Click( object sender, EventArgs e ) {

		}

		private void label22_Click( object sender, EventArgs e ) {

		}

		private void label23_Click( object sender, EventArgs e ) {

		}

		private void trackBar8_Scroll( object sender, EventArgs e ) {

		}

		private void btn_exit_Click_1( object sender, EventArgs e ) {
			Application.Exit( );
		}

		private void groupBox6_Enter( object sender, EventArgs e ) {

		}

		private void lbl_si_kerbals_Click( object sender, EventArgs e ) {

		}

		private void label31_Click( object sender, EventArgs e ) {

		}

		private void groupBox1_Enter( object sender, EventArgs e ) {

		}
	}
}
