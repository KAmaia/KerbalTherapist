using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KerbalGenerator.Forms;
using KerbalTherapist.Kerbals;

namespace KerbalTherapist.Forms {
	public partial class MainForm : Form {
		Form childForm;
		public MainForm( ) {
			InitializeComponent( );
		}

		private void MainForm_Load( object sender, EventArgs e ) {

		}

		private void CloseChildForm( ) {
			if ( !( childForm == null ) ) {
				childForm.Close( );
				childForm = null;
			}
		}

		private void button1_Click( object sender, EventArgs e ) {
			CreateAndDisplayChild( TherapistForm.KerbalKreator );
		}

		private void button6_Click( object sender, EventArgs e ) {
			CreateAndDisplayChild( TherapistForm.KerbalEditor );
		}

		private void btn_createroster_Click( object sender, EventArgs e ) {
			CreateAndDisplayChild( TherapistForm.RosterKreator );
		}

		private void CreateAndDisplayChild( TherapistForm chosenForm ) {
			CloseChildForm( );
			switch ( chosenForm ) {
				case TherapistForm.KerbalKreator:
					childForm = new KerbalKreationForm( );
					break;
				case TherapistForm.KerbalEditor:
					childForm = new KerbalEditorForm( new Roster( ) );
					break;
				case TherapistForm.RosterKreator:
					childForm = new RosterKreatorForm( new Roster( ) );
					break;
				default:
					break;
			}
			childForm.MdiParent = this;
			childForm.ControlBox = false;
			childForm.MinimizeBox = false;
			childForm.MaximizeBox = false;
			childForm.ShowIcon = false;
			childForm.Text = "";
			childForm.Dock = DockStyle.Fill;
			childForm.WindowState = FormWindowState.Normal;
			childForm.Show( );
		}



		private void btn_close_Click( object sender, EventArgs e ) {
			this.Close( );
		}
	}
}
