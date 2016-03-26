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
	public partial class KerbalPreviewWindow : Form {
		public KerbalPreviewWindow( Kerbal k ) {
			InitializeComponent( );
			txt_preview.Text = FormatKerbalText( k );
		}

		private void btn_preview_close_Click( object sender, EventArgs e ) {
			this.Close( );
		}

		private string FormatKerbalText( Kerbal k ) {
			string formattedText = "";
			string newLineIndent = Environment.NewLine +"\t";
			foreach ( KeyValuePair<string, string> stat in k.Stats ) {
				if ( stat.Key == "name" ) {
					formattedText += stat.Key + " : " + stat.Value;
				}
				else formattedText += newLineIndent + stat.Key + " : " + stat.Value;
			}
			return formattedText;
		}

		private void btn_yes_Click( object sender, EventArgs e ) {
			this.Close( );
		}
	}
}
