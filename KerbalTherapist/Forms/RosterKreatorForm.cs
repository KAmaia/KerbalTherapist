﻿using System;
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
	internal partial class RosterKreatorForm : Form {
		private Roster roster;
				
		internal RosterKreatorForm( Roster roster ) {
			InitializeComponent( );
			this.roster = roster;
		}
		
		private void btn_close_Click( object sender, EventArgs e ) {
			this.Close( );
		}
	}
}
