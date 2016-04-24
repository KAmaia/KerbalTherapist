using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using KerbalTherapist.Kerbals;

namespace KerbalTherapist {
	partial class KerbalPreviewWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose ( );
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( ) {
			this.panel1 = new System.Windows.Forms.Panel ( );
			this.txt_preview = new System.Windows.Forms.TextBox ( );
			this.btn_no = new System.Windows.Forms.Button ( );
			this.btn_yes = new System.Windows.Forms.Button ( );
			this.label1 = new System.Windows.Forms.Label ( );
			this.panel1.SuspendLayout ( );
			this.SuspendLayout ( );
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add ( this.txt_preview );
			this.panel1.Location = new System.Drawing.Point ( 5, 14 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size ( 274, 232 );
			this.panel1.TabIndex = 0;
			// 
			// txt_preview
			// 
			this.txt_preview.Location = new System.Drawing.Point ( 3, 5 );
			this.txt_preview.Multiline = true;
			this.txt_preview.Name = "txt_preview";
			this.txt_preview.ReadOnly = true;
			this.txt_preview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_preview.Size = new System.Drawing.Size ( 265, 224 );
			this.txt_preview.TabIndex = 0;
			this.txt_preview.TextChanged += new System.EventHandler ( this.txt_preview_TextChanged );
			// 
			// btn_no
			// 
			this.btn_no.DialogResult = System.Windows.Forms.DialogResult.No;
			this.btn_no.Location = new System.Drawing.Point ( 205, 252 );
			this.btn_no.Name = "btn_no";
			this.btn_no.Size = new System.Drawing.Size ( 73, 26 );
			this.btn_no.TabIndex = 1;
			this.btn_no.Text = "No";
			this.btn_no.UseVisualStyleBackColor = true;
			this.btn_no.Click += new System.EventHandler ( this.btn_preview_close_Click );
			// 
			// btn_yes
			// 
			this.btn_yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.btn_yes.Location = new System.Drawing.Point ( 126, 252 );
			this.btn_yes.Name = "btn_yes";
			this.btn_yes.Size = new System.Drawing.Size ( 73, 26 );
			this.btn_yes.TabIndex = 2;
			this.btn_yes.Text = "Yes";
			this.btn_yes.UseVisualStyleBackColor = true;
			this.btn_yes.Click += new System.EventHandler ( this.btn_yes_Click );
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point ( 9, 254 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 106, 23 );
			this.label1.TabIndex = 3;
			this.label1.Text = "Accept This Kerbal?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// KerbalPreviewWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 284, 284 );
			this.Controls.Add ( this.label1 );
			this.Controls.Add ( this.btn_yes );
			this.Controls.Add ( this.btn_no );
			this.Controls.Add ( this.panel1 );
			this.Name = "KerbalPreviewWindow";
			this.Text = "Kerbal Preview Window";
			this.panel1.ResumeLayout ( false );
			this.panel1.PerformLayout ( );
			this.ResumeLayout ( false );

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txt_preview;
		private System.Windows.Forms.Button btn_no;
		private System.Windows.Forms.Button btn_yes;
		private Label label1;
		private Roster r;


	}
}