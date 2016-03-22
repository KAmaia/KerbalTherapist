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
	public partial class frm_Kerb_Info : Form {
		//private List<Kerbal> kerbList;
		private Dictionary<string, Kerbal>kerbList = new Dictionary<string, Kerbal>();

		public frm_Kerb_Info( List<Kerbal> incKerbList ) {
			InitializeComponent( );
			foreach(Kerbal k in incKerbList ) {
				kerbList.Add( k.Name, k );
				cmb_kerb_list.Items.Add( k.Name );
			}
		

		}

		private void frm_Kerb_Info_Load( object sender, EventArgs e ) {
			
			cmb_kerb_list.SelectedIndex = 0;
			populateLabels( );
		}

		private void populateLabels( ) {
			Kerbal k = kerbList[(string) cmb_kerb_list.SelectedItem];
			gb_stats.Text = "Stats For: " + k.Name;
			lbl_gender.Text = k.Gender;
			lbl_status.Text = k.Type;
			lbl_role.Text = k.Trait;
			lbl_state.Text = k.State;
			lbl_BadAss.Text = k.Bads;
			lbl_tourist.Text = k.Tour;
			lbl_stupidity.Text = k.Dumb;
			lbl_bravery.Text = k.Brave;
			lbl_flights.Text = k.Flights;
			
		}

		private void label16_Click( object sender, EventArgs e ) {

		}

		private void label7_Click( object sender, EventArgs e ) {

		}

		private void cmb_kerb_list_SelectedIndexChanged( object sender, EventArgs e ) {
			populateLabels( );
		}

		private void btn_close_Click( object sender, EventArgs e ) {
			this.Close( );
		}
	}
}
