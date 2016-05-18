namespace KerbalTherapist.Forms {
	partial class MainForm {
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_exit = new System.Windows.Forms.Button();
			this.btn_cfgmgr = new System.Windows.Forms.Button();
			this.btn_stats = new System.Windows.Forms.Button();
			this.cmb_SaveSelector = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_createKerb = new System.Windows.Forms.Button();
			this.btn_viewedit = new System.Windows.Forms.Button();
			this.btn_createroster = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 811);
			this.panel1.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 811);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.btn_exit, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.btn_cfgmgr, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.btn_stats, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.cmb_SaveSelector, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btn_createKerb, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.btn_viewedit, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.btn_createroster, 0, 4);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 273);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 8;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 264);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// btn_exit
			// 
			this.btn_exit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_exit.Location = new System.Drawing.Point(3, 234);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(188, 27);
			this.btn_exit.TabIndex = 7;
			this.btn_exit.Text = "E&xit";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// btn_cfgmgr
			// 
			this.btn_cfgmgr.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_cfgmgr.Location = new System.Drawing.Point(3, 201);
			this.btn_cfgmgr.Name = "btn_cfgmgr";
			this.btn_cfgmgr.Size = new System.Drawing.Size(188, 27);
			this.btn_cfgmgr.TabIndex = 6;
			this.btn_cfgmgr.Text = "Configuration &Manager";
			this.btn_cfgmgr.UseVisualStyleBackColor = true;
			this.btn_cfgmgr.Click += new System.EventHandler(this.btn_cfgmgr_Click);
			// 
			// btn_stats
			// 
			this.btn_stats.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_stats.Location = new System.Drawing.Point(3, 168);
			this.btn_stats.Name = "btn_stats";
			this.btn_stats.Size = new System.Drawing.Size(188, 27);
			this.btn_stats.TabIndex = 5;
			this.btn_stats.Text = "Roster &Stats";
			this.btn_stats.UseVisualStyleBackColor = true;
			this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
			// 
			// cmb_SaveSelector
			// 
			this.cmb_SaveSelector.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmb_SaveSelector.FormattingEnabled = true;
			this.cmb_SaveSelector.Location = new System.Drawing.Point(3, 36);
			this.cmb_SaveSelector.Name = "cmb_SaveSelector";
			this.cmb_SaveSelector.Size = new System.Drawing.Size(188, 21);
			this.cmb_SaveSelector.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 33);
			this.label1.TabIndex = 1;
			this.label1.Text = "Select A Save Below";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_createKerb
			// 
			this.btn_createKerb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_createKerb.Location = new System.Drawing.Point(3, 69);
			this.btn_createKerb.Name = "btn_createKerb";
			this.btn_createKerb.Size = new System.Drawing.Size(188, 27);
			this.btn_createKerb.TabIndex = 2;
			this.btn_createKerb.Text = "&Create Kerbal";
			this.btn_createKerb.UseVisualStyleBackColor = true;
			this.btn_createKerb.Click += new System.EventHandler(this.btn_createKerb_Click);
			// 
			// btn_viewedit
			// 
			this.btn_viewedit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_viewedit.Location = new System.Drawing.Point(3, 102);
			this.btn_viewedit.Name = "btn_viewedit";
			this.btn_viewedit.Size = new System.Drawing.Size(188, 27);
			this.btn_viewedit.TabIndex = 3;
			this.btn_viewedit.Text = "&View or Edit A Kerbal";
			this.btn_viewedit.UseVisualStyleBackColor = true;
			this.btn_viewedit.Click += new System.EventHandler(this.btn_viewedit_Click);
			// 
			// btn_createroster
			// 
			this.btn_createroster.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_createroster.Location = new System.Drawing.Point(3, 135);
			this.btn_createroster.Name = "btn_createroster";
			this.btn_createroster.Size = new System.Drawing.Size(188, 27);
			this.btn_createroster.TabIndex = 4;
			this.btn_createroster.Text = "Create &Random Roster";
			this.btn_createroster.UseVisualStyleBackColor = true;
			this.btn_createroster.Click += new System.EventHandler(this.btn_createroster_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 811);
			this.Controls.Add(this.panel1);
			this.IsMdiContainer = true;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.Button btn_cfgmgr;
		private System.Windows.Forms.Button btn_stats;
		private System.Windows.Forms.ComboBox cmb_SaveSelector;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_createKerb;
		private System.Windows.Forms.Button btn_viewedit;
		private System.Windows.Forms.Button btn_createroster;
	}
}