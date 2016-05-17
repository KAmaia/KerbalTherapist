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

using KerbalTherapist.Accumulators;
using System.Diagnostics;
using KerbalTherapist.Logging;
using KerbalTherapist.Kerbals;

namespace KerbalTherapist.Forms {

	internal partial class KerbalKreationForm : Form {

		private SpecificAccumulator specAccum;
		private Roster roster;

		internal KerbalKreationForm( Roster roster ) {
			InitializeComponent( );
			specAccum = new SpecificAccumulator( );
			this.roster = roster;
			UpdateDisplay( );
		}

		private void KKF_Load( object sender, EventArgs e ) {
			Logger.LogEvent( "Launching KerbalKreation" );
		}
		//Another method using reflection to fill in the accumulator.
		//Thank god.
		private void AccumulateValues( object sender, EventArgs e ) {
			Control control = sender as Control;
			string controlName = "";
			if ( control is TrackBar ) {
				TrackBar tbar = control as TrackBar;
				controlName = tbar.Name.Remove( 0, 5 );
				Debug.WriteLine( controlName );
				foreach ( var prop in specAccum.GetType( ).GetProperties( ) ) {
					if ( controlName == prop.Name ) {
						prop.SetValue( specAccum, (float) tbar.Value / 100 );
						Logger.LogNewLine( "Setting: " + prop.Name + " to: " + (float) tbar.Value / 100 + " in Specific Accumulator" );
					}
				}
			}
			if ( control is CheckBox ) {
				CheckBox chk = control as CheckBox;
				controlName = control.Name.Remove( 0, 4 );
				foreach ( var prop in specAccum.GetType( ).GetProperties( ) ) {
					if ( controlName == prop.Name ) {
						prop.SetValue( specAccum, chk.Checked );
						Logger.LogNewLine( "Setting: " + prop.Name + " to: " + chk.Checked + " in Specific Accumulator" );
					}
				}
			}
			if ( control is RadioButton ) {
				RadioButton rd = control as RadioButton;
				controlName = rd.Name.Remove( 0, 3 );
				if ( controlName == "male" || controlName == "female" ) {
					specAccum.Female = rd_female.Checked;
				}
				else {
					if ( ( controlName == "Engineer" || controlName == "Scientist" || controlName == "Pilot" ) && rd.Checked ) {
						var prop = specAccum.GetType().GetProperty("Trait");
						prop.SetValue( specAccum, controlName );
						Logger.LogNewLine( "Setting: " + prop.Name + " to: " + controlName + " in Specific Accumulator" );
					}
				}

			}
			UpdateDisplay( );
		}

		private void UpdateDisplay( ) {
			txt_CourageDisp.Text = specAccum.Brave.ToString( );
			txt_StupidDisp.Text = specAccum.Dumb.ToString( );
		}

		private void btn_spe_reset_Click( object sender, EventArgs e ) {
			specAccum = specAccum.Reset( );
		}

		private void button3_Click( object sender, EventArgs e ) {
			Logger.LogEvent( "Closing KerbalKreation" );
			this.Close( );
		}

		private void chk_RandName_CheckedChanged( object sender, EventArgs e ) {
			txt_Name.Text = "";
			txt_Name.Enabled = !chk_RandName.Checked;
		}

		private void chk_IsKerman_CheckedChanged( object sender, EventArgs e ) {
			txt_Name.MaxLength = chk_IsKerman.Checked ? 11 : 18;
			if ( txt_Name.Text.Length > txt_Name.MaxLength ) {
				txt_Name.Text = txt_Name.Text.Remove( txt_Name.MaxLength );
			}
		}

		private void chk_RandBrave_CheckedChanged( object sender, EventArgs e ) {
			tbar_Brave.Enabled = !chk_RandBrave.Checked;
		}

		private void chk_RandDumb_CheckedChanged( object sender, EventArgs e ) {
			tbar_Dumb.Enabled = !chk_RandDumb.Checked;
		}
	}
}
