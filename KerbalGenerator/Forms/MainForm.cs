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
	public partial class MainForm : Form {
		Form childForm;
		public MainForm( ) {
			InitializeComponent( );
		}

		

		private void MainForm_Load( object sender, EventArgs e ) {

		}

		private void closeChildForm( ) {
			if(!(childForm == null )) {
				childForm.Close( );
				childForm = null;
			}
		}

		private void button1_Click( object sender, EventArgs e ) {
			closeChildForm( );
			childForm = new KerbalKreationForm( );
			childForm.MdiParent = this;
			childForm.WindowState = FormWindowState.Maximized;
			childForm.Show( );
		}

		private void button6_Click( object sender, EventArgs e ) {
			closeChildForm( );
			childForm = new KerbalEditorForm( new Kerbals.Roster( ));
			childForm.MdiParent = this;
			childForm.WindowState = FormWindowState.Maximized;
			childForm.Show( );
		}
	}
}
