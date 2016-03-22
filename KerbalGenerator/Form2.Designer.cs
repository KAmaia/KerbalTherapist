namespace KerbalGenerator {
	partial class frm_Kerb_Info {
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
			this.cmb_kerb_list = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_close = new System.Windows.Forms.Button();
			this.gb_stats = new System.Windows.Forms.GroupBox();
			this.lbl_flights = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lbl_state = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbl_stupidity = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lbl_bravery = new System.Windows.Forms.Label();
			this.lbl_tourist = new System.Windows.Forms.Label();
			this.lbl_BadAss = new System.Windows.Forms.Label();
			this.lbl_status = new System.Windows.Forms.Label();
			this.lbl_role = new System.Windows.Forms.Label();
			this.lbl_gender = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.gb_stats.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmb_kerb_list
			// 
			this.cmb_kerb_list.FormattingEnabled = true;
			this.cmb_kerb_list.Location = new System.Drawing.Point(132, 19);
			this.cmb_kerb_list.Name = "cmb_kerb_list";
			this.cmb_kerb_list.Size = new System.Drawing.Size(199, 21);
			this.cmb_kerb_list.TabIndex = 0;
			this.cmb_kerb_list.SelectedIndexChanged += new System.EventHandler(this.cmb_kerb_list_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_close);
			this.groupBox1.Controls.Add(this.gb_stats);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmb_kerb_list);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(337, 218);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// btn_close
			// 
			this.btn_close.Location = new System.Drawing.Point(256, 184);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(75, 23);
			this.btn_close.TabIndex = 2;
			this.btn_close.Text = "Close";
			this.btn_close.UseVisualStyleBackColor = true;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// gb_stats
			// 
			this.gb_stats.Controls.Add(this.lbl_flights);
			this.gb_stats.Controls.Add(this.label6);
			this.gb_stats.Controls.Add(this.lbl_state);
			this.gb_stats.Controls.Add(this.label7);
			this.gb_stats.Controls.Add(this.lbl_stupidity);
			this.gb_stats.Controls.Add(this.label8);
			this.gb_stats.Controls.Add(this.lbl_bravery);
			this.gb_stats.Controls.Add(this.lbl_tourist);
			this.gb_stats.Controls.Add(this.lbl_BadAss);
			this.gb_stats.Controls.Add(this.lbl_status);
			this.gb_stats.Controls.Add(this.lbl_role);
			this.gb_stats.Controls.Add(this.lbl_gender);
			this.gb_stats.Controls.Add(this.label10);
			this.gb_stats.Controls.Add(this.label9);
			this.gb_stats.Controls.Add(this.label5);
			this.gb_stats.Controls.Add(this.label4);
			this.gb_stats.Controls.Add(this.label3);
			this.gb_stats.Controls.Add(this.label2);
			this.gb_stats.Location = new System.Drawing.Point(8, 47);
			this.gb_stats.Name = "gb_stats";
			this.gb_stats.Size = new System.Drawing.Size(323, 131);
			this.gb_stats.TabIndex = 2;
			this.gb_stats.TabStop = false;
			this.gb_stats.Text = "Stats for: ";
			// 
			// lbl_flights
			// 
			this.lbl_flights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_flights.Location = new System.Drawing.Point(254, 80);
			this.lbl_flights.Name = "lbl_flights";
			this.lbl_flights.Size = new System.Drawing.Size(63, 23);
			this.lbl_flights.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(198, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Stupidity";
			// 
			// lbl_state
			// 
			this.lbl_state.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_state.Location = new System.Drawing.Point(254, 59);
			this.lbl_state.Name = "lbl_state";
			this.lbl_state.Size = new System.Drawing.Size(63, 23);
			this.lbl_state.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(211, 85);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Flights";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// lbl_stupidity
			// 
			this.lbl_stupidity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_stupidity.Location = new System.Drawing.Point(254, 35);
			this.lbl_stupidity.Name = "lbl_stupidity";
			this.lbl_stupidity.Size = new System.Drawing.Size(63, 23);
			this.lbl_stupidity.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(213, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "State";
			// 
			// lbl_bravery
			// 
			this.lbl_bravery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_bravery.Location = new System.Drawing.Point(254, 15);
			this.lbl_bravery.Name = "lbl_bravery";
			this.lbl_bravery.Size = new System.Drawing.Size(63, 23);
			this.lbl_bravery.TabIndex = 14;
			this.lbl_bravery.Click += new System.EventHandler(this.label16_Click);
			// 
			// lbl_tourist
			// 
			this.lbl_tourist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_tourist.Location = new System.Drawing.Point(74, 104);
			this.lbl_tourist.Name = "lbl_tourist";
			this.lbl_tourist.Size = new System.Drawing.Size(63, 23);
			this.lbl_tourist.TabIndex = 13;
			// 
			// lbl_BadAss
			// 
			this.lbl_BadAss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_BadAss.Location = new System.Drawing.Point(74, 80);
			this.lbl_BadAss.Name = "lbl_BadAss";
			this.lbl_BadAss.Size = new System.Drawing.Size(63, 23);
			this.lbl_BadAss.TabIndex = 12;
			// 
			// lbl_status
			// 
			this.lbl_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_status.Location = new System.Drawing.Point(74, 59);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(63, 23);
			this.lbl_status.TabIndex = 11;
			// 
			// lbl_role
			// 
			this.lbl_role.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_role.Location = new System.Drawing.Point(74, 35);
			this.lbl_role.Name = "lbl_role";
			this.lbl_role.Size = new System.Drawing.Size(63, 23);
			this.lbl_role.TabIndex = 10;
			// 
			// lbl_gender
			// 
			this.lbl_gender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_gender.Location = new System.Drawing.Point(74, 15);
			this.lbl_gender.Name = "lbl_gender";
			this.lbl_gender.Size = new System.Drawing.Size(63, 23);
			this.lbl_gender.TabIndex = 9;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 85);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(43, 13);
			this.label10.TabIndex = 8;
			this.label10.Text = "BadAss";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 109);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(39, 13);
			this.label9.TabIndex = 7;
			this.label9.Text = "Tourist";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(202, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Bravery";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Status";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Role";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Gender";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Select A Kerbal";
			// 
			// frm_Kerb_Info
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 242);
			this.Controls.Add(this.groupBox1);
			this.Name = "frm_Kerb_Info";
			this.Text = "Kerbal Info";
			this.Load += new System.EventHandler(this.frm_Kerb_Info_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gb_stats.ResumeLayout(false);
			this.gb_stats.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cmb_kerb_list;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gb_stats;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lbl_bravery;
		private System.Windows.Forms.Label lbl_tourist;
		private System.Windows.Forms.Label lbl_BadAss;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Label lbl_role;
		private System.Windows.Forms.Label lbl_gender;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lbl_flights;
		private System.Windows.Forms.Label lbl_state;
		private System.Windows.Forms.Label lbl_stupidity;
		private System.Windows.Forms.Button btn_close;
	}
}