﻿using KerbalTherapist;
using KerbalTherapist.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerbalTherapist.Forms {
	internal partial class MainForm : Form {
		private Form currentChild;
		private Therapist therapist;
		
		internal MainForm( Therapist therapist ) {
			InitializeComponent( );
			this.therapist = therapist;
		}
		
		private void CreateAndDisplayChild( TherapistFormType chosenForm ) {
			ClosecurrentChild( );
			switch ( chosenForm ) {
				case TherapistFormType.KerbalKreator:
					currentChild = new KerbalKreationForm(therapist.Rstr );
					break;
				case TherapistFormType.KerbalEditor:
					currentChild = new KerbalEditorForm( therapist.Rstr );
					break;
				case TherapistFormType.RosterKreator:
					currentChild = new RosterKreatorForm( therapist.Rstr );
					break;
				case TherapistFormType.SaveStatForm:
					currentChild = new SaveStatForm( );
					break;
				default:
					break;
			}
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

		private void ClosecurrentChild( ) {
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
	}
}
