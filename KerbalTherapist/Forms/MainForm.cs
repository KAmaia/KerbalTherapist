
using KerbalTherapist;
using KerbalTherapist.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerbalTherapist.Forms {
	internal partial class MainForm : Form {
		private ChildForm currentChild;
		private Therapist therapist;

		internal MainForm( Therapist therapist ) {
			InitializeComponent( );
			this.therapist = therapist;
		}

		private void OnFormLoad( object sender, EventArgs e ) {
			//Clear cmb_saveselector.  Just in case.
			cmb_SaveSelector.Items.Clear( );
			//Add the saves from therapist.
			cmb_SaveSelector.Items.AddRange( therapist.GetSaves( ) );
			cmb_SaveSelector.SelectedIndex = 0;
		}

		private void CreateAndDisplayChild( TherapistFormType chosenForm ) {
			CloseCurrentChild( );
			switch ( chosenForm ) {
				case TherapistFormType.KerbalKreator:
					currentChild = new KerbalKreationForm( therapist.Rstr );
					break;
				case TherapistFormType.KerbalEditor:
					currentChild = new KerbalEditorForm( );
					break;
				case TherapistFormType.RosterKreator:
					currentChild = new RosterKreatorForm( );
					break;
				case TherapistFormType.SaveStatForm:
					currentChild = new RosterStatForm( therapist.GetFlag( ) );
					break;
				default:
					currentChild = new DefaultForm( );
					break;
			}
			currentChild.Rstr = therapist.Rstr;
			currentChild.MdiParent = this;
			currentChild.ControlBox = false;
			currentChild.MinimizeBox = false;
			currentChild.MaximizeBox = false;
			currentChild.ShowIcon = false;
			currentChild.Text = "";
			currentChild.Dock = DockStyle.Fill;
			currentChild.WindowState = FormWindowState.Normal;
			currentChild.Show( );
		}

		private void CloseCurrentChild( ) {
			if ( !( currentChild == null ) ) {
				currentChild.Close( );
				currentChild = null;
			}
		}

		private void btn_viewedit_Click( object sender, EventArgs e ) {
			CreateAndDisplayChild( TherapistFormType.KerbalEditor );
		}

		private void btn_createKerb_Click( object sender, EventArgs e ) {
			CreateAndDisplayChild( TherapistFormType.KerbalKreator );
		}

		private void btn_createroster_Click( object sender, EventArgs e ) {
			CreateAndDisplayChild( TherapistFormType.RosterKreator );
		}

		private void btn_stats_Click( object sender, EventArgs e ) {
			CreateAndDisplayChild( TherapistFormType.SaveStatForm );
		}

		private void btn_cfgmgr_Click( object sender, EventArgs e ) {
			CreateAndDisplayChild( TherapistFormType.Configurator );
		}

		private void btn_exit_Click( object sender, EventArgs e ) {
			this.Close( );
		}

		private void cmb_SaveSelector_SelectedIndexChanged( object sender, EventArgs e ) {
			//we'll fix this in a minute
			if ( currentChild is RosterStatForm ) {

			}
			therapist.SelectSave( cmb_SaveSelector.SelectedItem.ToString() );
		}
	}
}

