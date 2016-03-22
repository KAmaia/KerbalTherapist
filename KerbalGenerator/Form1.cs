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
		private string kspPath;
		private string[] savePaths;
		private string configPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Badwater\\KerbalGen\\config";
		private List<Kerbal> currentKerbals;


		public frm_Krb_Gen( ) {
			InitializeComponent( );
		}

		

		private void btn_gen_One_Kerb_Click( object sender, EventArgs e ) {

		}

		private void btn_gen_List_Kerb_Click( object sender, EventArgs e ) {

		}

		private void btn_exit_Click( object sender, EventArgs e ) {
			Application.Exit( );
		}

		private void btn_view_Kerbals_Click( object sender, EventArgs e ) {
			frm_Kerb_Info kerbInfos = new frm_Kerb_Info(currentKerbals);
			kerbInfos.Show( );
		}

		private void frm_Krb_Gen_Load( object sender, EventArgs e ) {
			if ( hasRun() ) {
				//create Config
			}
			else {
				loadConfig( );
			}

			currentKerbals = new List<Kerbal>( );
			currentKerbals.Add( new Kerbal( "derp derp", "male", "pilot", "Applicant", "1.0", "1.0", "Yes", "Yes", "Available", "0" ) );
			currentKerbals.Add( new Kerbal( "Hurdy Durr", "female", "pilot", "crew", "1.0", "1.0", "Yes", "Yes", "Available", "0" ) );
		}

		private void loadConfig( ) {
			//load our configuration info.
		}

		private void CreateConfig( ) {

		}

		private bool hasRun( ) {
			bool thingimajobber;
			if( File.Exists( configPath ) ) {
				return false;
			}
			else {
				CreateConfig( );
			}
			return true;
		}

	}
}
