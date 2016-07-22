//Copyright (C) 2016 Amaia Industries
//
//Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
//associated documentation files (the "Software"), to deal in the Software without restriction, 
//including without limitation the rights to use, copy, modify, merge, publish, and distribute 
//copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
//	Notice:
//	The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
//	Modifications:
//	Any modified version or derivative of this software must include a link to the original source code.  Distributing the original source code with the 
//	release of the modified version shall be construed to satisfy this clause.
//
//	Attribution:
//	Any modified version or derivative of this software must include attribution to the original author.  
//
//	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
//	INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
//	PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE Amaia Industries 
//	BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//	TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE 
//	USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//	Except as contained in this notice, the name of Amaia Industries shall not be used in advertising or 
//	otherwise to promote the sale, use or other dealings in this Software without prior written authorization from Amaia Industries.

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
	public partial class RosterStatForm : ChildForm {
		private Bitmap flag;
		private KerbalKounter kounter;

		public RosterStatForm(Bitmap flag ) {
			InitializeComponent( );
			this.flag = flag;
			UpdateDisplay( );
		}

		internal void btn_close_Click( object sender, EventArgs e ) {
			this.Close( );
		}

		private void OnFormLoad( ) {
			UpdateDisplay( );
		}

		internal void UpdateDisplay( ) {
			kounter = new KerbalKounter( );
			Dictionary<string, int> counts = kounter.KountKerbals(roster);
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
			//assign flag
			img_saveFlag.Image = flag;
		}

		
	}
}
