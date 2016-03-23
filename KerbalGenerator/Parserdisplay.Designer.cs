namespace KerbalGenerator {
	partial class Parserdisplay {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( ) {
			this.lbl_data = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_data
			// 
			this.lbl_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_data.Location = new System.Drawing.Point(12, 9);
			this.lbl_data.Name = "lbl_data";
			this.lbl_data.Size = new System.Drawing.Size(594, 515);
			this.lbl_data.TabIndex = 0;
			// 
			// parserdisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 533);
			this.Controls.Add(this.lbl_data);
			this.Name = "parserdisplay";
			this.Text = "parserdisplay";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbl_data;
	}
}