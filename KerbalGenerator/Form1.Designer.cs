namespace KerbalGenerator {
	partial class frm_Krb_Gen {
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_view_Kerbals = new System.Windows.Forms.Button();
			this.btn_exit = new System.Windows.Forms.Button();
			this.btn_gen_List_Kerb = new System.Windows.Forms.Button();
			this.btn_gen_One_Kerb = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.btn_view_Kerbals);
			this.groupBox1.Controls.Add(this.btn_exit);
			this.groupBox1.Controls.Add(this.btn_gen_List_Kerb);
			this.groupBox1.Controls.Add(this.btn_gen_One_Kerb);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(259, 236);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// btn_view_Kerbals
			// 
			this.btn_view_Kerbals.AutoSize = true;
			this.btn_view_Kerbals.Location = new System.Drawing.Point(60, 120);
			this.btn_view_Kerbals.Name = "btn_view_Kerbals";
			this.btn_view_Kerbals.Size = new System.Drawing.Size(138, 23);
			this.btn_view_Kerbals.TabIndex = 7;
			this.btn_view_Kerbals.Text = "View Current Kerbals";
			this.btn_view_Kerbals.UseVisualStyleBackColor = true;
			this.btn_view_Kerbals.Click += new System.EventHandler(this.btn_view_Kerbals_Click);
			// 
			// btn_exit
			// 
			this.btn_exit.Location = new System.Drawing.Point(92, 146);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(75, 23);
			this.btn_exit.TabIndex = 6;
			this.btn_exit.Text = "Exit";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// btn_gen_List_Kerb
			// 
			this.btn_gen_List_Kerb.AutoSize = true;
			this.btn_gen_List_Kerb.Location = new System.Drawing.Point(60, 94);
			this.btn_gen_List_Kerb.Name = "btn_gen_List_Kerb";
			this.btn_gen_List_Kerb.Size = new System.Drawing.Size(138, 23);
			this.btn_gen_List_Kerb.TabIndex = 5;
			this.btn_gen_List_Kerb.Text = "Generate Multiple Kerbals";
			this.btn_gen_List_Kerb.UseVisualStyleBackColor = true;
			// 
			// btn_gen_One_Kerb
			// 
			this.btn_gen_One_Kerb.AccessibleDescription = "Generate a single Kerbal";
			this.btn_gen_One_Kerb.AutoSize = true;
			this.btn_gen_One_Kerb.Location = new System.Drawing.Point(57, 68);
			this.btn_gen_One_Kerb.Name = "btn_gen_One_Kerb";
			this.btn_gen_One_Kerb.Size = new System.Drawing.Size(144, 23);
			this.btn_gen_One_Kerb.TabIndex = 4;
			this.btn_gen_One_Kerb.Text = "Generate a Specific Kerbal";
			this.btn_gen_One_Kerb.UseVisualStyleBackColor = true;
			// 
			// frm_Krb_Gen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.groupBox1);
			this.Name = "frm_Krb_Gen";
			this.Text = "Kerbal Generator";
			this.Load += new System.EventHandler(this.frm_Krb_Gen_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_view_Kerbals;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.Button btn_gen_List_Kerb;
		private System.Windows.Forms.Button btn_gen_One_Kerb;
	}
}

