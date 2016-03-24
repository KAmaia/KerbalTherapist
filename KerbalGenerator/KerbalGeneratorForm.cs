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
		private readonly string configPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Badwater\\KerbalGen";

		private Config config;

		private Configurator configurator;
		private Kerbalmaker km;
		private Dictionary<string, Kerbal>roster;



		public frm_Krb_Gen( ) {
			InitializeComponent( );
			configurator = new Configurator( configPath );
			if ( FirstRun( ) ) {
				//lock all controls except configurator button.
				ConfiguratorForm cfgrForm = new ConfiguratorForm(ref configurator);
				cfgrForm.ShowDialog( );
				setAllControls( false );
			}
			setAllControls( true );
			configurator.LoadConfig( );
			config = configurator.Configuration;
		}

		private void setAllControls( bool active ) {
			foreach ( Control c in Controls ) {
				if ( c.Name.ToLower( ).Equals( "pnl_po_options" ) ) {
					continue;
				}
				else {
					c.Enabled = active;
				}
			}
		}

		private void parseKerbals( ) {
			cmb_kerb_list.Items.Clear( );
			KerbalParser parseTheKerbals = new KerbalParser();
			string persistent = cmb_AvailSaves.SelectedItem.ToString();
			parseTheKerbals.Parse( config.SavePaths[persistent] );
			roster = parseTheKerbals.Roster;
			cmb_kerb_list.Items.AddRange( roster.Keys.ToArray( ) );
			cmb_kerb_list.SelectedIndex = 0;

		}

		private bool FirstRun( ) {
			Debug.WriteLine( Path.Combine( configPath, "config.xml" ) );
			string path = Path.Combine(configPath, "config.xml");
			bool retval = !File.Exists(path);
			return retval;
		}


		private void displaySaveStats( ) {
			Dictionary<string, int> tmp = countKerbals();
			lbl_si_badscountdisp.Text = tmp["badasskerbals"].ToString( );
			lbl_si_tourcountdisp.Text = tmp["touristkerbals"].ToString( );
			lbl_si_kerbcountdisp.Text = tmp["totalkerbals"].ToString( );
			lbl_si_livingcountdisp.Text = tmp["livingkerbals"].ToString( );
			lbl_si_deadcountdisp.Text = tmp["deadkerbals"].ToString( );
			lbl_si_genderfcountdisp.Text = tmp["femalekerbals"].ToString( );
			lbl_si_gendermcountdisp.Text = tmp["malekerbals"].ToString( );
			lbl_si_engicountdisp.Text = tmp["engineerkerbals"].ToString( );
			lbl_si_scicountdisp.Text = tmp["scientistkerbals"].ToString( );
			lbl_si_pilotcountdisp.Text = tmp["pilotkerbals"].ToString( );


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

		private Dictionary<string, int> countKerbals( ) {
			Dictionary<string, int>saveStatsDict = new Dictionary<string, int>();
			saveStatsDict.Add( "totalkerbals", 0 );
			saveStatsDict.Add( "malekerbals", 0 );
			saveStatsDict.Add( "femalekerbals", 0 );
			saveStatsDict.Add( "livingkerbals", 0 );
			saveStatsDict.Add( "deadkerbals", 0 );
			saveStatsDict.Add( "touristkerbals", 0 );
			saveStatsDict.Add( "engineerkerbals", 0 );
			saveStatsDict.Add( "scientistkerbals", 0 );
			saveStatsDict.Add( "pilotkerbals", 0 );
			saveStatsDict.Add( "badasskerbals", 0 );

			foreach ( string s in roster.Keys ) {
				saveStatsDict["totalkerbals"] += 1;
				if ( roster[s].Gender.ToLower( ).Equals( "male" ) ) {
					saveStatsDict["malekerbals"] += 1;
				}
				if ( roster[s].Gender.ToLower( ).Equals( "female" ) ) {
					saveStatsDict["femalekerbals"] += 1;
				}
				if ( ( roster[s].State.ToLower( ).Equals( "available" ) ) || roster[s].State.ToLower( ).Equals( "assigned" ) ) {
					saveStatsDict["livingkerbals"] += 1;
				}
				if ( roster[s].State.ToLower( ).Equals( "dead" ) ) {
					saveStatsDict["deadkerbals"] += 1;
				}
				if ( roster[s].Trait.ToLower( ).Equals( "engineer" ) ) {
					saveStatsDict["engineerkerbals"] += 1;
				}
				if ( roster[s].Trait.ToLower( ).Equals( "pilot" ) ) {
					saveStatsDict["pilotkerbals"] += 1;
				}
				if ( roster[s].Trait.ToLower( ).Equals( "scientist" ) ) {
					saveStatsDict["scientistkerbals"] += 1;
				}
				if ( roster[s].Tour.ToLower( ).Equals( "true" ) ) {
					saveStatsDict["touristkerbals"] += 1;
				}
				if ( roster[s].Bads.ToLower( ).Equals( "true" ) ) {
					saveStatsDict["badasskerbals"] += 1;
				}
			}
			return saveStatsDict;
		}



		private void btn_gen_List_Kerb_Click( object sender, EventArgs e ) {

		}


		private void frm_Krb_Gen_Load( object sender, EventArgs e ) {

			this.Text = "Kerbal Generator -- " + config.Name;
			cmb_AvailSaves.Items.AddRange( config.SavePaths.Keys.ToArray( ) );
			cmb_AvailSaves.SelectedIndex = 0;
			parseKerbals( );
		}

		#region Available Saves Panel
		private void cmb_AvailSaves_SelectedIndexChanged( object sender, EventArgs e ) {

			string path = cmb_AvailSaves.SelectedItem.ToString();
			Debug.WriteLine( path );
			string debug = config.SavePaths[path];
			Debug.WriteLine( "+++" + debug );
			Debug.WriteLine( "==" + config.SavePaths[path] );
			lbl_currentSaveLocation.Text = config.SavePaths[path];
			parseKerbals( );
			displaySaveStats( );
		}

		#endregion







		#region program options panel

		private void btn_po_OpenCfgr_Click( object sender, EventArgs e ) {
			Form cfgrform = new ConfiguratorForm(ref configurator);
			cfgrform.Show( );
		}

		private void btn_po_exit_Click( object sender, EventArgs e ) {
			Application.Exit( );
		}
		#endregion

		#region kerbalinfopanel
		private void cmb_kerb_list_SelectedIndexChanged( object sender, EventArgs e ) {
			string selectedKerbal = cmb_kerb_list.SelectedItem.ToString();
			Kerbal k = roster[selectedKerbal];
			DisplayKerbalStats( k );
		}

		#endregion

		#region Random Kerbal Generation

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
			km = new Kerbalmaker( );
			//Get all frickin' values.  (There has to be an easier way)
			string name, gender, trait,  badass, tourist;
			float brave, dumb;
			bool genName = chk_spe_rndName.Checked;
			bool isKerman = chk_spe_lastNameKerman.Checked;

			gender = rd_spe_genderfemale.Checked ? "female" : "male";
			trait = DetermineSpecificTrait( );
			brave = ( (float) tbar_spe_brave.Value / 100 );
			dumb = ( (float) tbar_spe_stupid.Value / 100 );
			badass = chk_spe_badass.Checked.ToString( ).ToLower( );
			tourist = chk_spe_tourist.Checked.ToString( ).ToLower( );

			Kerbal k;
			if ( chk_spe_rndName.Checked ) {
				km.generateSpecific( true, isKerman, gender, trait, brave, dumb, badass, tourist );
			}
			else {
				name = txt_spe_kerbname.Text;
				if (isKerman) {
					if(ValidateKerbal( name + " Kerman" ) ) {
						km.generateSpecific( name, isKerman, gender, trait, brave, dumb, badass, tourist );
					}
					else {
						MessageBox.Show( "Error: Kerbal: " + name +" Already Exists In The Roster!");
					}
				}
				else {
					if ( ValidateKerbal( name ) ) {
						km.generateSpecific( name, isKerman, gender, trait, brave, dumb, badass, tourist );
					}
					else {
						MessageBox.Show( "Error! Kerbal: " + name + " Already Exists In The Roster!" );
					}
				}
			}
		}
		private bool ValidateKerbal(string name ) {
			return !roster.ContainsKey( name );
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

			#endregion


		}

		private void checkBox1_CheckedChanged( object sender, EventArgs e ) {

		}
	}

}



