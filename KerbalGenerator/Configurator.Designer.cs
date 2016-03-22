namespace KerbalGenerator {
	partial class Configurator {
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
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_create_config = new System.Windows.Forms.Button();
			this.txt_kspPath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_ConfigName = new System.Windows.Forms.TextBox();
			this.dlg_SelectInstall = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_Cancel);
			this.groupBox1.Controls.Add(this.btn_create_config);
			this.groupBox1.Controls.Add(this.txt_kspPath);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt_ConfigName);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(259, 142);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.AutoSize = true;
			this.btn_Cancel.Location = new System.Drawing.Point(161, 113);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(91, 23);
			this.btn_Cancel.TabIndex = 6;
			this.btn_Cancel.Text = "Cancel and E&xit";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_create_config
			// 
			this.btn_create_config.AutoSize = true;
			this.btn_create_config.Location = new System.Drawing.Point(172, 82);
			this.btn_create_config.Name = "btn_create_config";
			this.btn_create_config.Size = new System.Drawing.Size(81, 23);
			this.btn_create_config.TabIndex = 5;
			this.btn_create_config.Text = "&Create Config";
			this.btn_create_config.UseVisualStyleBackColor = true;
			this.btn_create_config.Click += new System.EventHandler(this.btn_create_config_Click);
			// 
			// txt_kspPath
			// 
			this.txt_kspPath.Location = new System.Drawing.Point(79, 56);
			this.txt_kspPath.Name = "txt_kspPath";
			this.txt_kspPath.Size = new System.Drawing.Size(173, 20);
			this.txt_kspPath.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "KSP Path:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(9, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(243, 17);
			this.label2.TabIndex = 2;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Config Name:";
			// 
			// txt_ConfigName
			// 
			this.txt_ConfigName.Location = new System.Drawing.Point(79, 19);
			this.txt_ConfigName.Name = "txt_ConfigName";
			this.txt_ConfigName.Size = new System.Drawing.Size(174, 20);
			this.txt_ConfigName.TabIndex = 0;
			// 
			// dlg_SelectInstall
			// 
			this.dlg_SelectInstall.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.dlg_SelectInstall.ShowNewFolderButton = false;
			// 
			// Configurator
			// 
			this.AcceptButton = this.btn_create_config;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 175);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Configurator";
			this.Text = "Configurator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_ConfigName;
		private System.Windows.Forms.TextBox txt_kspPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FolderBrowserDialog dlg_SelectInstall;
		private System.Windows.Forms.Button btn_create_config;
		private System.Windows.Forms.Button btn_Cancel;
	}
}