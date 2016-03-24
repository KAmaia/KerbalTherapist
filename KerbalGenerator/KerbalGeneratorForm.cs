using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace KerbalGenerator {
	public partial class frm_Krb_Gen : Form {
		private KerbalGenerator generator;

		public frm_Krb_Gen( ) {
			InitializeComponent( );
			generator = new KerbalGenerator( this );
		}

		public void SetAllControls( bool active ) {
			foreach ( Control c in Controls ) {
				if ( c.Name.ToLower( ).Equals( "pnl_po_options" ) ) {
					continue;
				}
				else {
					c.Enabled = active;
				}
			}
		}

		private void frm_Krb_Gen_Load( object sender, EventArgs e ) {
			Text = "Kerbal Generator -- " + generator.Cfg.Name;
			cmb_AvailSaves.Items.AddRange( generator.GetSaves( ) );
			cmb_AvailSaves.SelectedIndex = 0;
		}

		#region Stats Panel
		private void displaySaveStats( ) {
			lbl_si_badscountdisp.Text = generator.GetKerbalCounts( "badasskerbals" );
			lbl_si_tourcountdisp.Text = generator.GetKerbalCounts( "touristkerbals" );
			lbl_si_kerbcountdisp.Text = generator.GetKerbalCounts( "totalkerbals" );
			lbl_si_livingcountdisp.Text = generator.GetKerbalCounts( "livingkerbals" );
			lbl_si_deadcountdisp.Text = generator.GetKerbalCounts( "deadkerbals" );
			lbl_si_genderfcountdisp.Text = generator.GetKerbalCounts( "femalekerbals" );
			lbl_si_gendermcountdisp.Text = generator.GetKerbalCounts( "malekerbals" );
			lbl_si_engicountdisp.Text = generator.GetKerbalCounts( "engineerkerbals" );
			lbl_si_scicountdisp.Text = generator.GetKerbalCounts( "scientistkerbals" );
			lbl_si_pilotcountdisp.Text = generator.GetKerbalCounts( "pilotkerbals" );
		}

		private void DisplayKerbalStats( Kerbal k ) {
			lbl_ki_genderdisp.Text = k.Gender;
			lbl_ki_roledisp.Text = k.Type;
			lbl_ki_badsdisp.Text = k.Bads;
			lbl_ki_tourdisp.Text = k.Tour;
			lbl_ki_bravedisp.Text = k.Brave;
			lbl_ki_stupiddisp.Text = k.Dumb;
			lbl_ki_statusdisp.Text = k.Trait;
			lbl_ki_statedisp.Text = k.State;
			lbl_ki_flightcountdisp.Text = k.Flights;
		}
		#endregion

		#region Available Saves Panel
		private void cmb_AvailSaves_SelectedIndexChanged( object sender, EventArgs e ) {
			string path = cmb_AvailSaves.SelectedItem.ToString();
			Debug.WriteLine( "==" + generator.Cfg.SavePaths[path] );
			generator.ParseKerbals( path );
			lbl_currentSaveLocation.Text = generator.Cfg.SavePaths[path];
			cmb_kerb_list.Items.Clear( );
			cmb_kerb_list.Items.AddRange( generator.Rstr.GetNames( ).ToArray( ) );
			cmb_kerb_list.SelectedIndex = 0;
			displaySaveStats( );
		}

		#endregion

		#region program options panel

		private void btn_po_OpenCfgr_Click( object sender, EventArgs e ) {
			Form cfgrform = generator.GetCfgrForm();
			cfgrform.Show( );
		}

		private void btn_po_exit_Click( object sender, EventArgs e ) {
			Application.Exit( );
		}
		#endregion

		#region kerbalinfopanel
		private void cmb_kerb_list_SelectedIndexChanged( object sender, EventArgs e ) {
			string selectedKerbal = cmb_kerb_list.SelectedItem.ToString();
			Kerbal k = generator.Rstr.GetKerbal(selectedKerbal);
			DisplayKerbalStats( k );
		}

		#endregion

		#region Random Kerbal Generation
		private void btn_gen_List_Kerb_Click( object sender, EventArgs e ) {

		}
		#endregion

		#region Specific Kerbal Generation
		private void btn_spe_reset_Click( object sender, EventArgs e ) {
			txt_spe_kerbname.Text = "";

			rd_spe_genderfemale.Checked = true;
			rd_spe_pilot.Checked = true;

			chk_spe_badass.Checked = false;
			chk_spe_tourist.Checked = false;

			tbar_spe_brave.Value = 0;
			tbar_spe_stupid.Value = 0;

			btn_spe_generate.Enabled = false;

			lbl_spe_stupiddisp.Text = "0";
			lbl_spe_bravedisp.Text = "0";

			chk_spe_rndBrave.Checked = false;
			chk_spe_rndStupid.Checked = false;

		}

		private void tbar_spe_stupid_Scroll( object sender, EventArgs e ) {
			lbl_spe_stupiddisp.Text = tbar_spe_stupid.Value.ToString( );
		}

		private void tbar_spe_brave_Scroll( object sender, EventArgs e ) {
			lbl_spe_bravedisp.Text = tbar_spe_brave.Value.ToString( );
		}

		private void chk_spe_lastNameKerman_CheckedChanged( object sender, EventArgs e ) {
			txt_spe_kerbname.MaxLength = chk_spe_lastNameKerman.Checked ? 11 : 18;
		}

		private void txt_spe_kerbname_TextChanged( object sender, EventArgs e ) {
			//Disable the generate button if our name is blank.
			if ( !chk_spe_rndName.Checked ) {
				btn_spe_generate.Enabled = !( txt_spe_kerbname.Text == "" );
			}
		}
		private void chk_spe_rndName_CheckedChanged( object sender, EventArgs e ) {
			txt_spe_kerbname.Text = "";
			txt_spe_kerbname.Enabled = !chk_spe_rndName.Checked;
			btn_spe_generate.Enabled = true;
		}
		private void btn_spe_generate_Click( object sender, EventArgs e ) {
			Random rnd = new Random();
			//Get all frickin' values.  (There has to be an easier way)
			string name, gender, trait;
			float brave, dumb;
			bool genName = chk_spe_rndName.Checked;
			bool isKerman = chk_spe_lastNameKerman.Checked;
			bool badass = chk_spe_badass.Checked;
			bool tourist = chk_spe_tourist.Checked;

			bool rndDumb = chk_spe_rndStupid.Checked;
			bool rndBrave = chk_spe_rndBrave.Checked;

			gender = rd_spe_genderfemale.Checked ? "female" : "male";
			trait = DetermineSpecificTrait( );
			if ( rndBrave ) {
				brave = Util.getRandFloat( );

			}
			else {
				brave = ( (float) tbar_spe_brave.Value / 100 );
			}
			if ( rndDumb ) {
				dumb = Util.getRandFloat( );
			}
			else {
				dumb = ( (float) tbar_spe_stupid.Value / 100 );
			}
			if ( !genName ) {
				name = txt_spe_kerbname.Text;
				generator.KreateKerbal( name, isKerman, gender, trait, brave, dumb, badass, tourist );
			}
			else {
				generator.KreateKerbal( genName, isKerman, gender, trait, brave, dumb, badass, tourist );
			}
			cmb_kerb_list.Items.Clear( );
			cmb_kerb_list.Items.AddRange( generator.Rstr.GetNames( ).ToArray( ) );
			cmb_kerb_list.SelectedIndex = 0;
		}

		private string DetermineSpecificTrait( ) {
			if ( rd_spe_pilot.Checked ) {
				return "pilot";
			}
			else if ( rd_spe_engi.Checked ) {
				return "engineer";
			}
			else if ( rd_spe_sci.Checked ) {
				return "scientist";
			}
			else {
				return "pilot";

			}
		}

		#endregion

		private void chk_spe_rndBrave_CheckedChanged( object sender, EventArgs e ) {
			if ( chk_spe_rndBrave.Checked ) {
				tbar_spe_brave.Value = 0;
				lbl_spe_bravedisp.Text = "";
			}
			tbar_spe_brave.Enabled = !chk_spe_rndBrave.Checked;
		}

		private void chk_spe_rndStupid_CheckedChanged( object sender, EventArgs e ) {
			if ( chk_spe_rndStupid.Checked ) {
				tbar_spe_stupid.Value = 0;
				lbl_spe_stupiddisp.Text = "";
			}
			tbar_spe_stupid.Enabled = !chk_spe_rndStupid.Checked;
		}
	}

}



