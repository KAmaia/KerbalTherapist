namespace KerbalTherapist {
	partial class ConfiguratorForm {
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
			this.groupBox1 = new System.Windows.Forms.GroupBox ( );
			this.btn_show_FolderDialog = new System.Windows.Forms.Button ( );
			this.lbl_PathErr = new System.Windows.Forms.Label ( );
			this.lbl_ConfigErr = new System.Windows.Forms.Label ( );
			this.btn_Cancel = new System.Windows.Forms.Button ( );
			this.btn_create_config = new System.Windows.Forms.Button ( );
			this.txt_kspPath = new System.Windows.Forms.TextBox ( );
			this.label3 = new System.Windows.Forms.Label ( );
			this.label2 = new System.Windows.Forms.Label ( );
			this.label1 = new System.Windows.Forms.Label ( );
			this.txt_ConfigName = new System.Windows.Forms.TextBox ( );
			this.fbd_SelectSavePath = new System.Windows.Forms.FolderBrowserDialog ( );
			this.label4 = new System.Windows.Forms.Label ( );
			this.groupBox1.SuspendLayout ( );
			this.SuspendLayout ( );
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add ( this.label4 );
			this.groupBox1.Controls.Add ( this.btn_show_FolderDialog );
			this.groupBox1.Controls.Add ( this.lbl_PathErr );
			this.groupBox1.Controls.Add ( this.lbl_ConfigErr );
			this.groupBox1.Controls.Add ( this.btn_Cancel );
			this.groupBox1.Controls.Add ( this.btn_create_config );
			this.groupBox1.Controls.Add ( this.txt_kspPath );
			this.groupBox1.Controls.Add ( this.label3 );
			this.groupBox1.Controls.Add ( this.label2 );
			this.groupBox1.Controls.Add ( this.label1 );
			this.groupBox1.Controls.Add ( this.txt_ConfigName );
			this.groupBox1.Location = new System.Drawing.Point ( 12, 12 );
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size ( 369, 217 );
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// btn_show_FolderDialog
			// 
			this.btn_show_FolderDialog.Location = new System.Drawing.Point ( 282, 105 );
			this.btn_show_FolderDialog.Name = "btn_show_FolderDialog";
			this.btn_show_FolderDialog.Size = new System.Drawing.Size ( 75, 23 );
			this.btn_show_FolderDialog.TabIndex = 9;
			this.btn_show_FolderDialog.Text = "Select Folder";
			this.btn_show_FolderDialog.UseVisualStyleBackColor = true;
			this.btn_show_FolderDialog.Click += new System.EventHandler ( this.btn_show_FolderDialog_Click );
			// 
			// lbl_PathErr
			// 
			this.lbl_PathErr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_PathErr.Location = new System.Drawing.Point ( 84, 129 );
			this.lbl_PathErr.Name = "lbl_PathErr";
			this.lbl_PathErr.Size = new System.Drawing.Size ( 273, 19 );
			this.lbl_PathErr.TabIndex = 8;
			this.lbl_PathErr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_ConfigErr
			// 
			this.lbl_ConfigErr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_ConfigErr.Location = new System.Drawing.Point ( 84, 64 );
			this.lbl_ConfigErr.Name = "lbl_ConfigErr";
			this.lbl_ConfigErr.Size = new System.Drawing.Size ( 273, 19 );
			this.lbl_ConfigErr.TabIndex = 7;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.AutoSize = true;
			this.btn_Cancel.Location = new System.Drawing.Point ( 266, 180 );
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size ( 91, 23 );
			this.btn_Cancel.TabIndex = 6;
			this.btn_Cancel.Text = "Ca&ncel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler ( this.btn_Cancel_Click );
			// 
			// btn_create_config
			// 
			this.btn_create_config.AutoSize = true;
			this.btn_create_config.Location = new System.Drawing.Point ( 276, 151 );
			this.btn_create_config.Name = "btn_create_config";
			this.btn_create_config.Size = new System.Drawing.Size ( 81, 23 );
			this.btn_create_config.TabIndex = 5;
			this.btn_create_config.Text = "&Create Config";
			this.btn_create_config.UseVisualStyleBackColor = true;
			this.btn_create_config.Click += new System.EventHandler ( this.btn_create_config_Click );
			// 
			// txt_kspPath
			// 
			this.txt_kspPath.Location = new System.Drawing.Point ( 84, 106 );
			this.txt_kspPath.Name = "txt_kspPath";
			this.txt_kspPath.ReadOnly = true;
			this.txt_kspPath.Size = new System.Drawing.Size ( 191, 20 );
			this.txt_kspPath.TabIndex = 4;
			this.txt_kspPath.TextChanged += new System.EventHandler ( this.txt_kspPath_TextChanged );
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point ( 26, 109 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size ( 56, 13 );
			this.label3.TabIndex = 3;
			this.label3.Text = "KSP Path:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point ( 84, 14 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 273, 20 );
			this.label2.TabIndex = 2;
			this.label2.Text = "Name Your Config";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point ( 11, 43 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 71, 13 );
			this.label1.TabIndex = 1;
			this.label1.Text = "Config Name:";
			// 
			// txt_ConfigName
			// 
			this.txt_ConfigName.Location = new System.Drawing.Point ( 84, 40 );
			this.txt_ConfigName.Name = "txt_ConfigName";
			this.txt_ConfigName.Size = new System.Drawing.Size ( 273, 20 );
			this.txt_ConfigName.TabIndex = 0;
			// 
			// fbd_SelectSavePath
			// 
			this.fbd_SelectSavePath.ShowNewFolderButton = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point ( 84, 83 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size ( 273, 20 );
			this.label4.TabIndex = 10;
			this.label4.Text = "Select Your Save Path";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ConfiguratorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 389, 236 );
			this.Controls.Add ( this.groupBox1 );
			this.Name = "ConfiguratorForm";
			this.Text = "ConfiguratorForm";
			this.groupBox1.ResumeLayout ( false );
			this.groupBox1.PerformLayout ( );
			this.ResumeLayout ( false );

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_PathErr;
		private System.Windows.Forms.Label lbl_ConfigErr;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_create_config;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_ConfigName;
		private System.Windows.Forms.Button btn_show_FolderDialog;
		private System.Windows.Forms.TextBox txt_kspPath;
		private System.Windows.Forms.FolderBrowserDialog fbd_SelectSavePath;
		private System.Windows.Forms.Label label4;
	}
}