using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerbalGenerator {
	public partial class Parserdisplay : Form {
		public Parserdisplay( ) {
			InitializeComponent( );
		}
		public void UpdateLabel(string s ) {
			lbl_data.Text = s;
		}
	}
}
