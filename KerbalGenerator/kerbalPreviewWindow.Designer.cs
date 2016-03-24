namespace KerbalGenerator {
	partial class KerbalPreviewWindow {
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_preview_close = new System.Windows.Forms.Button();
			this.txt_preview = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.txt_preview);
			this.panel1.Location = new System.Drawing.Point(5, 14);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(274, 232);
			this.panel1.TabIndex = 0;
			// 
			// btn_preview_close
			// 
			this.btn_preview_close.Location = new System.Drawing.Point(5, 252);
			this.btn_preview_close.Name = "btn_preview_close";
			this.btn_preview_close.Size = new System.Drawing.Size(273, 26);
			this.btn_preview_close.TabIndex = 1;
			this.btn_preview_close.Text = "Close";
			this.btn_preview_close.UseVisualStyleBackColor = true;
			this.btn_preview_close.Click += new System.EventHandler(this.btn_preview_close_Click);
			// 
			// txt_preview
			// 
			this.txt_preview.Location = new System.Drawing.Point(3, 5);
			this.txt_preview.Multiline = true;
			this.txt_preview.Name = "txt_preview";
			this.txt_preview.ReadOnly = true;
			this.txt_preview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_preview.Size = new System.Drawing.Size(265, 224);
			this.txt_preview.TabIndex = 0;
			// 
			// kerbalPreviewWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 284);
			this.Controls.Add(this.btn_preview_close);
			this.Controls.Add(this.panel1);
			this.Name = "kerbalPreviewWindow";
			this.Text = "Kerbal Preview Window";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txt_preview;
		private System.Windows.Forms.Button btn_preview_close;
	}
}