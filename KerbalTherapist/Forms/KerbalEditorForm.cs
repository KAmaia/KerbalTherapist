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
using KerbalTherapist.Utilities;

namespace KerbalTherapist.Forms {
	public partial class KerbalEditorForm : Form {
		private Boolean editing;
		private Roster roster;
		Kerbal currentKerbal;

		private String[] Professions = {"Pilot", "Engineer", "Scientist"};
		private String[] States = {"Available", "Dead", "Crew"};

		public KerbalEditorForm( Roster roster ) {
			InitializeComponent( );
			this.editing = false;
			this.roster = roster;
			cmb_role.Items.AddRange( Professions );
			cmb_state.Items.AddRange( States );
			ToggleControls( );
		}

		private void btn_edit_click( object sender, EventArgs e ) {
			if ( editing ) {
				ToggleEditing( );
			}
			else {
				this.Close( );
			}
		}

		private void btn_editsave_Click( object sender, EventArgs e ) {
			ToggleEditing( );
		}
		/// <summary>
		/// Toggles edit mode on and off.
		/// </summary>
		private void ToggleEditing( ) {
			if ( !editing ) {
				btn_editsave.Text = "Save";
				btn_closeCancel.Text = "Cancel";

			}
			else if ( editing ) {
				btn_editsave.Text = "Edit";
				btn_closeCancel.Text = "Close";
			}
			editing = !editing;
			ToggleControls( );
		}
		/// <summary>
		/// Toggles the controls on and off for editing.
		/// </summary>
		private void ToggleControls( ) {
			//Toggle Radio Buttons.
			rd_female.Enabled = editing;
			rd_male.Enabled = editing;
			//Toggle checkboxes
			chk_alive.Enabled = editing;
			chk_bad.Enabled = editing;
			chk_tourist.Enabled = editing;
			//Toggle Combos
			cmb_flight.Enabled = editing;
			cmb_role.Enabled = editing;
			cmb_state.Enabled = editing;
			cmb_career.Enabled = editing;
			//Toggle Numerics
			nmc_brave.Enabled = editing;
			nmc_dumb.Enabled = editing;
		}

		
	}
}

