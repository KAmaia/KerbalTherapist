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

using KerbalTherapist.Kerbals;
using KerbalTherapist.Accumulators;
using KerbalTherapist.Logging;


namespace KerbalTherapist {
	public partial class frm_Krb_Gen : Form {
		private KerbalTherapist generator;

		private SpecificAccumulator specAccum;
		private RandomAccumulator randAccum;


		public frm_Krb_Gen ( ) {
			InitializeComponent ( );
			generator = new KerbalTherapist ( this );
			specAccum = new SpecificAccumulator ( );
			randAccum = new RandomAccumulator ( );

		}

		private void LockOutRandom ( ) {
			Logger.LogEvent ( "Locking Out Controls" );
			foreach ( Control c in pnl_rnd_gen.Controls ) {
				c.Enabled = false;
			}
		}

		/// <summary>
		/// Sets all controls except program options to active
		/// </summary>
		/// <param name="active"></param>
		internal void SetAllControls ( bool active ) {
			foreach ( Control c in Controls ) {
				if ( c.Name.ToLower ( ).Equals ( "pnl_po_options" ) ) {
					continue;
				}
				else {
					c.Enabled = active;
				}
			}


			//LockOutRandom( );
		}

		private void frm_Krb_Gen_Load ( object sender, EventArgs e ) {
			Text = "Kerbal Therapist-- "; //+ generator.Cfg.Name;
			cmb_AvailSaves.Items.AddRange ( generator.GetSaves ( ) );
			cmb_AvailSaves.SelectedIndex = 0;
			UpdateRandomDisplay ( );
			btn_spe_generate.Enabled = false;
		}

		#region Stats Panel

		internal void UpdateSaveStats ( string currentSavePath, Dictionary<string, int> countedKerbals ) {
			//Update Our Current Save Path
			lbl_currentSaveLocation.Text = currentSavePath;
			//Update Our Current Kerbal counts
			lbl_si_kerbcountdisp.Text = countedKerbals [ "Total" ].ToString ( );
			lbl_si_livingcountdisp.Text = countedKerbals [ "Living" ].ToString ( );
			lbl_si_deadcountdisp.Text = countedKerbals [ "Dead" ].ToString ( );
			lbl_si_pilotcountdisp.Text = countedKerbals [ "Pilot" ].ToString ( );
			lbl_si_engicountdisp.Text = countedKerbals [ "Engineer" ].ToString ( );
			lbl_si_scicountdisp.Text = countedKerbals [ "Scientist" ].ToString ( );
			lbl_si_gendermcountdisp.Text = countedKerbals [ "Male" ].ToString ( );
			lbl_si_genderfcountdisp.Text = countedKerbals [ "Female" ].ToString ( );
			lbl_si_badscountdisp.Text = countedKerbals [ "Badass" ].ToString ( );
			lbl_si_tourcountdisp.Text = countedKerbals [ "Tourist" ].ToString ( );
			lbl_si_hireddisp.Text = countedKerbals [ "Crew" ].ToString ( );
			lbl_si_applcntdisp.Text = countedKerbals [ "Applicant" ].ToString ( );
			lbl_si_assigneddisp.Text = countedKerbals [ "Assigned" ].ToString ( );
			lbl_si_availdisp.Text = countedKerbals [ "Available" ].ToString ( );
		}

		internal void UpdateKerbalList ( ) {
			cmb_kerb_list.Items.Clear ( );
			cmb_kerb_list.Items.AddRange ( generator.GetRosterNames ( ) );
			cmb_kerb_list.SelectedIndex = 0;
		}

		#endregion

		#region Available Saves Panel

		private void cmb_AvailSaves_SelectedIndexChanged ( object sender, EventArgs e ) {
			string saveName = cmb_AvailSaves.SelectedItem.ToString ( );
			generator.SelectSave ( saveName );
			generator.UpdateSaveStats ( );
			cmb_kerb_list.Items.Clear ( );
			cmb_kerb_list.Items.AddRange ( generator.GetRosterNames ( ) );
			cmb_kerb_list.SelectedIndex = 0;
			generator.SelectKerbal ( cmb_kerb_list.SelectedItem.ToString ( ) );
			generator.UpdateKerbalStats ( );
		}

		#endregion

		#region program options panel

		private void btn_po_OpenCfgr_Click ( object sender, EventArgs e ) {
			Form cfgrform = generator.GetCfgrForm ( );
			cfgrform.Show ( );
		}

		private void btn_po_Save_Click ( object sender, EventArgs e ) {
			generator.Save ( cmb_AvailSaves.SelectedItem.ToString ( ) );
		}

		private void btn_po_exit_Click ( object sender, EventArgs e ) {
			Application.Exit ( );
		}

		#endregion

		#region kerbalinfopanel

		internal void UpdateKerbalStats ( Kerbal currentKerbal ) {

			lbl_ki_genderdisp.Text = currentKerbal.GetStat ( "gender" );
			lbl_ki_roledisp.Text = currentKerbal.GetStat ( "trait" );
			lbl_ki_statusdisp.Text = currentKerbal.GetStat ( "type" );
			lbl_ki_badsdisp.Text = currentKerbal.GetStat ( "badS" );
			lbl_ki_tourdisp.Text = currentKerbal.GetStat ( "tour" );
			lbl_ki_bravedisp.Text = currentKerbal.GetStat ( "brave" );
			lbl_ki_stupiddisp.Text = currentKerbal.GetStat ( "dumb" );
			lbl_ki_statedisp.Text = currentKerbal.GetStat ( "state" );

			foreach ( KeyValuePair<string, string> stat in currentKerbal.Stats ) {

				if ( stat.Key == "gender" ) {
					lbl_ki_genderdisp.Text = stat.Value;
				}
				if ( stat.Key == "trait" ) {
					lbl_ki_roledisp.Text = stat.Value;
				}
				if ( stat.Key == "type" ) {
					lbl_ki_statusdisp.Text = stat.Value;
				}
				if ( stat.Key == "badS" ) {
					lbl_ki_badsdisp.Text = stat.Value;
				}
				if ( stat.Key == "tour" ) {
					lbl_ki_tourdisp.Text = stat.Value;
				}
				if ( stat.Key == "brave" ) {
					lbl_ki_bravedisp.Text = stat.Value;
				}
				if ( stat.Key == "dumb" ) {
					lbl_ki_stupiddisp.Text = stat.Value;
				}
				if ( stat.Key == "state" ) {
					lbl_ki_statedisp.Text = stat.Value;
				}

			}
		}

		private void cmb_kerb_list_SelectedIndexChanged ( object sender, EventArgs e ) {
			generator.SelectKerbal ( cmb_kerb_list.SelectedItem.ToString ( ) );
		}

		#endregion

		#region Random Kerbal Generation

		private void btn_gen_List_Kerb_Click ( object sender, EventArgs e ) {
			
		}

		private void updateRatioDisplay ( float disp ) {
			disp = 1 - Math.Abs ( disp );
			if ( tbar_rnd_FtMRatio.Value == 0 && !chk_rnd_useRatio.Checked ) {
				lbl_rnd_mfRatio.Text = "1:1";
				//if the value == 0, stop the slider to give it a snappy feeling.
				//it's hacky, but it works.
				//TODO: find a better way to do this.
				tbar_rnd_FtMRatio.Enabled = false;
				tbar_rnd_FtMRatio.Enabled = true;
				tbar_rnd_FtMRatio.Select ( );
			}
			else if ( disp.Equals ( .50 ) || disp.Equals ( .25 ) ) {
				//Same As Above except for .25 and .5 and without setting our text to 1:1
				tbar_rnd_FtMRatio.Enabled = false;
				tbar_rnd_FtMRatio.Enabled = true;
				tbar_rnd_FtMRatio.Select ( );
			}

			if ( tbar_rnd_FtMRatio.Value > 0 ) {
				lbl_rnd_mfRatio.Text = disp + ":1";
			}
			else if ( tbar_rnd_FtMRatio.Value < 0 ) {
				lbl_rnd_mfRatio.Text = "1:" + Math.Abs ( disp );
			}
		}

		/// <summary>
		/// Updates the random accumulator.  One method to rule *ALL* The random controls!
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void UpdateRandomAccumulator ( object sender, EventArgs e ) {
			//Dear Future Me: You are a genius.  You made this work.  Despite overwhelming odds, you are victorious!
			//Be proud future me, when you look upon this method in total confusion, since you probably forgot 
			//*exactly how* it works 10 minutes after closing this class.

			Control control = sender as Control;
			if ( control is TrackBar ) {
				TrackBar tbar = control as TrackBar;
				string controlName = control.Name.Remove ( 0, 9 );
				//okay limiting our MinBads/MaxTourists here.
				if ( controlName.Equals ( "MinNumberOfBadasses" ) || controlName.Equals ( "MaxNumberOfTourists" ) ) {
					if ( tbar.Value >= randAccum.NumberToCreate ) {
						tbar.Value = randAccum.NumberToCreate;
					}
				}
				foreach ( var prop in randAccum.GetType( ).GetProperties( ) ) {
					if ( controlName == prop.Name ) {
						if ( prop.PropertyType == typeof(float) ) {
							prop.SetValue ( randAccum, (float) tbar.Value / 100 );
						}
						else if ( prop.PropertyType == typeof(int) ) {
							prop.SetValue ( randAccum, tbar.Value );
						}
						else {
							Logger.LogEvent ( prop.PropertyType.ToString ( ) );
						}
					}
				}
				tbar_rnd_MaxNumberOfTourists.Maximum = randAccum.NumberToCreate;
				tbar_rnd_MinNumberOfBadasses.Maximum = randAccum.NumberToCreate;
				if ( tbar_rnd_MaxNumberOfTourists.Value > randAccum.NumberToCreate ) {
					tbar_rnd_MaxNumberOfTourists.Value = randAccum.NumberToCreate;
				}
				if ( tbar_rnd_MinNumberOfBadasses.Value > randAccum.NumberToCreate ) {
					tbar_rnd_MinNumberOfBadasses.Value = randAccum.NumberToCreate;
				}
			}

			if ( control is CheckBox ) {
				CheckBox cbox = control as CheckBox;
				string controlName = cbox.Name.Remove ( 0, 8 );
				//because use Ratio is notted, we have to set it by hand.  
				//The For loop is left incase we add any more checkboxes.
				if ( controlName.Equals ( "useRatio" ) ) {
					tbar_rnd_FtMRatio.Enabled = !cbox.Checked;
					randAccum.useRatio = !cbox.Checked;
				}
				else {
					foreach ( var prop in randAccum.GetType( ).GetProperties( ) ) {
						if ( controlName == prop.Name ) {
							if ( prop.PropertyType == typeof(bool) ) {
								prop.SetValue ( randAccum, cbox.Checked );
							}
						}
					}
				}
			}
			randAccum.NumberToCreate = randAccum.Pilots + randAccum.Engineers + randAccum.Scientists;
			UpdateRandomDisplay ( );
		}

		private void UpdateRandomDisplay ( ) {
			randAccum.NumberToCreate = randAccum.Pilots + randAccum.Engineers + randAccum.Scientists;
			lbl_rnd_maxpilotsdisp.Text = randAccum.Pilots.ToString ( );
			lbl_rnd_maxengidisp.Text = randAccum.Engineers.ToString ( );
			lbl_rnd_maxscidisp.Text = randAccum.Scientists.ToString ( );
			lbl_rnd_TotalKerbs.Text = randAccum.NumberToCreate.ToString ( );
			lbl_rnd_minStupidDisp.Text = randAccum.MinStupid.ToString ( );
			lbl_rnd_maxstupiddisp.Text = randAccum.MaxStupid.ToString ( );
			lbl_rnd_maxbravedisp.Text = randAccum.MaxBrave.ToString ( );
			lbl_rnd_minbravedisp.Text = randAccum.MinBrave.ToString ( );
			lbl_rnd_minbadsdisp.Text = randAccum.MinNumberOfBadasses.ToString ( );
			lbl_rnd_maxtourdisp.Text = randAccum.MaxNumberOfTourists.ToString ( );
			updateRatioDisplay ( randAccum.FtMRatio );
		}

		private void btn_rnd_reset_Click ( object sender, EventArgs e ) {
			randAccum = randAccum.Reset ( );

			tbar_rnd_Pilots.Value = 0;
			tbar_rnd_Scientists.Value = 0;
			tbar_rnd_Engineers.Value = 0;
			chk_rnd_isKerman.Checked = false;
			tbar_rnd_FtMRatio.Value = 0;
			chk_rnd_useRatio.Checked = false;
			tbar_rnd_MaxBrave.Value = 0;
			tbar_rnd_MaxStupid.Value = 0;
			tbar_rnd_MinBrave.Value = 0;
			tbar_rnd_MinStupid.Value = 0;
			tbar_rnd_MinNumberOfBadasses.Value = 0;
			tbar_rnd_MaxNumberOfTourists.Value = 0;

			UpdateRandomDisplay ( );
		}

		#endregion

		#region Specific Kerbal Generation

		//todo: create an UpdateSpecificAccumulator method.
		private void btn_spe_reset_Click ( object sender, EventArgs e ) {
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

			specAccum = specAccum.Reset ( );
		}

		private void tbar_spe_stupid_Scroll ( object sender, EventArgs e ) {
			lbl_spe_stupiddisp.Text = tbar_spe_stupid.Value.ToString ( );
			specAccum.dumb = tbar_spe_stupid.Value;
		}

		private void tbar_spe_brave_Scroll ( object sender, EventArgs e ) {
			lbl_spe_bravedisp.Text = tbar_spe_brave.Value.ToString ( );
			specAccum.brave = tbar_spe_brave.Value;
		}

		private void chk_spe_lastNameKerman_CheckedChanged ( object sender, EventArgs e ) {
			txt_spe_kerbname.MaxLength = chk_spe_lastNameKerman.Checked ? 11 : 18;
			specAccum.IsKerman = chk_spe_lastNameKerman.Checked;
		}

		private void txt_spe_kerbname_TextChanged ( object sender, EventArgs e ) {
			//Disable the generate button if our name is blank.
			if ( !chk_spe_rndName.Checked ) {
				btn_spe_generate.Enabled = !( txt_spe_kerbname.Text == "" );
			}
			specAccum.Name = txt_spe_kerbname.Text;
		}

		private void chk_spe_rndName_CheckedChanged ( object sender, EventArgs e ) {
			txt_spe_kerbname.Text = "";
			txt_spe_kerbname.Enabled = !chk_spe_rndName.Checked;
			specAccum.RndName = chk_spe_rndName.Checked;
			btn_spe_generate.Enabled = true;
		}

		private void btn_spe_generate_Click ( object sender, EventArgs e ) {
			DetermineTrait ( );
			generator.KreateKerbal ( specAccum );
		}

		private void chk_spe_rndBrave_CheckedChanged ( object sender, EventArgs e ) {
			if ( chk_spe_rndBrave.Checked ) {
				tbar_spe_brave.Value = 0;
				lbl_spe_bravedisp.Text = "";
				specAccum.RndBrave = chk_spe_rndBrave.Checked;
			}
			tbar_spe_brave.Enabled = !chk_spe_rndBrave.Checked;
		}

		private void chk_spe_rndStupid_CheckedChanged ( object sender, EventArgs e ) {
			if ( chk_spe_rndStupid.Checked ) {
				tbar_spe_stupid.Value = 0;
				lbl_spe_stupiddisp.Text = "";
				specAccum.RndDumb = chk_spe_rndStupid.Checked;
			}
			tbar_spe_stupid.Enabled = !chk_spe_rndStupid.Checked;
		}

		private void DetermineTrait ( ) {
			if ( rd_spe_pilot.Checked ) {
				specAccum.Trait = "Pilot";
			}
			if ( rd_spe_sci.Checked ) {
				specAccum.Trait = "Scientist";
			}
			if ( rd_spe_engi.Checked ) {
				specAccum.Trait = "Engineer";
			}
		}

		private void chk_spe_badass_CheckedChanged ( object sender, EventArgs e ) {
			specAccum.Badass = chk_spe_badass.Checked;
		}

		private void chk_spe_tourist_CheckedChanged ( object sender, EventArgs e ) {
			specAccum.Tourist = chk_spe_tourist.Checked;
		}

		private void rd_spe_gendermale_CheckedChanged ( object sender, EventArgs e ) {
			if ( rd_spe_gendermale.Checked ) {
				specAccum.Female = false;
			}
		}

		private void rd_spe_genderfemale_CheckedChanged ( object sender, EventArgs e ) {
			if ( rd_spe_genderfemale.Checked ) {
				specAccum.Female = true;
			}
		}

		#endregion

		private void btn_rnd_gen_Kerb_Click ( object sender, EventArgs e ) {
			generator.KreateRoster ( randAccum );
		}
	}

}



