using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KerbalTherapist.Kerbals;

namespace KerbalTherapist.Forms {
	public partial class KerbalEditorForm : Form {
		private Roster roster;
		public KerbalEditorForm(Roster roster ) {
			InitializeComponent( );
			this.roster = roster;
		}
		
		private void groupBox15_Enter( object sender, EventArgs e ) {

		}

		private void KerbalCreationForm_Load( object sender, EventArgs e ) {

		}

		private void button3_Click( object sender, EventArgs e ) {
			this.Close( );
		}

		private void tableLayoutPanel1_Paint( object sender, PaintEventArgs e ) {

		}
	}
}
