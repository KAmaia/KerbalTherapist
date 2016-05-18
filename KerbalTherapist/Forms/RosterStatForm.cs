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
	public partial class RosterStatForm : Form {
		private Bitmap flag;
		private Roster rstr;
		private KerbalKounter kounter;

		public RosterStatForm( Roster rstr, Bitmap flag ) {
			InitializeComponent( );
			this.rstr = rstr;
			this.flag = flag;
			UpdateDisplay( );
		}

		private void OnFormLoad( ) {
			UpdateDisplay( );
		}

		internal void UpdateDisplay( ) {
			kounter = new KerbalKounter( );
			Dictionary<string, int> counts = kounter.KountKerbals(rstr);
			//Total, Living, Dead.
			lbl_rostCountdisp.Text = counts["Total"].ToString( );
			lbl_livingdisp.Text = counts["Living"].ToString( );
			lbl_deaddisp.Text = counts["Dead"].ToString( );
			//Pilots, Engis, Scientists.
			lbl_pilotsdisp.Text = counts["Pilot"].ToString( );
			lbl_engdisp.Text = counts["Engineer"].ToString( );
			lbl_scientistsdisp.Text = counts["Scientist"].ToString( );
			//Female, Male
			lbl_FemaleDisp.Text = counts["Female"].ToString( );
			lbl_MaleDisp.Text = counts["Male"].ToString( );
			//Badass, Tourist
			lbl_BadsDisp.Text = counts["Badass"].ToString( );
			lbl_TouristDisp.Text = counts["Tourist"].ToString( );
			//Crew, Applicant
			lbl_appDisp.Text = counts["Applicant"].ToString( );
			lbl_HiredDisp.Text = counts["Crew"].ToString( );
			//Asssigned, Available
			lbl_AssignDisp.Text = counts["Assigned"].ToString( );
			lbl_AvailDisp.Text = counts["Available"].ToString( );

		}

		private void btn_close_Click( object sender, EventArgs e ) {
			this.Close( );
		}
	}
}
