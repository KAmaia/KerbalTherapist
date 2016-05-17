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
using System.Windows.Forms;

using KerbalTherapist.Logging;

namespace KerbalTherapist.Forms{
	public partial class ConfiguratorForm : Form {
		Configurator cfgr;
		private string KSPPath;
		bool firstRun;

		public ConfiguratorForm ( Configurator cfgr, bool firstRun ) {
			InitializeComponent ( );
			this.firstRun = firstRun;
			this.cfgr = cfgr;
		}

		private void btn_Cancel_Click ( object sender, EventArgs e ) {
			if ( firstRun ) {
				Environment.Exit ( 1 );
			}
			else {
				this.Close ( );
			}
		}

		private void btn_create_config_Click ( object sender, EventArgs e ) {
			Logger.LogEvent ( "Found Save Path.  Creating Configuration with Path: " + KSPPath );
			if ( cfgr.ValidatePath ( KSPPath ) ) {
				cfgr.CreateConfig ( txt_ConfigName.Text, KSPPath );
				this.Close ( );
			}
			else {
				DialogResult result = MessageBox.Show ( "Error! Invalid Path!  Try Again?", "Invalid Path", MessageBoxButtons.YesNo );
				if ( result == DialogResult.No ) {
					if ( firstRun ) {
						Application.Exit ( );
					}
					else {

					}
				}
			}
		}

		private void ShowPathError ( string s, bool success ) {
			lbl_PathErr.ForeColor = success ? Color.Green : Color.Red;
			lbl_PathErr.Text = s;
		}

		private void txt_kspPath_TextChanged ( object sender, EventArgs e ) {
			bool validPath = cfgr.ValidatePath ( txt_kspPath.Text );
			ShowPathError ( validPath ? "Invalid Path Found" : "Sorry, That Path Does Not Exist", validPath );
			if ( validPath ) {
				validPath = cfgr.countSavesInPath ( txt_kspPath.Text ) > 0;
				ShowPathError ( validPath ? "Valid Saves Found.  Click Create Config to Continue" : "Sorry, no Valid Saves in that directory", validPath );
			}
		}


		private void btn_show_FolderDialog_Click ( object sender, EventArgs e ) {
			DialogResult result = fbd_SelectSavePath.ShowDialog ( );
			if ( result == DialogResult.OK ) {
				KSPPath = fbd_SelectSavePath.SelectedPath;
				txt_kspPath.Text = KSPPath;
			}
		}

		private void ConfiguratorForm_Load( object sender, EventArgs e ) {

		}
	}
}
