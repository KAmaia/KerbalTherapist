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

namespace KerbalGenerator.Forms {
	public partial class RosterKreatorForm : Form {
		private Roster roster;

		
		public RosterKreatorForm( Roster roster ) {
			InitializeComponent( );
			this.roster = roster;
		}

		private void RosterKreatorForm_Load( object sender, EventArgs e ) {

		}


		private void btn_close_Click( object sender, EventArgs e ) {
			this.Close( );
		}
	}
}
