using System;
using System.Collections.Generic;

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
			System.Windows.Forms.GroupBox gb_po_options;
			System.Windows.Forms.Panel panel3;
			this.btn_po_Save = new System.Windows.Forms.Button();
			this.btn_po_OpenCfgr = new System.Windows.Forms.Button();
			this.btn_po_exit = new System.Windows.Forms.Button();
			this.lbl_saveSelect = new System.Windows.Forms.Label();
			this.cmb_AvailSaves = new System.Windows.Forms.ComboBox();
			this.btn_rnd_gen_Kerb = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lbl_CurrentSaveDir = new System.Windows.Forms.Label();
			this.label59 = new System.Windows.Forms.Label();
			this.lbl_kspInstalDir = new System.Windows.Forms.Label();
			this.label57 = new System.Windows.Forms.Label();
			this.lbl_currentSaveLocation = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.dmn_rnd_MaxKerbals = new System.Windows.Forms.DomainUpDown();
			this.lbl_rnd_MaxKerbs = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.lbl_rnd_maxpilots = new System.Windows.Forms.Label();
			this.lbl_rnd_engi = new System.Windows.Forms.Label();
			this.chk_rnd_locktour = new System.Windows.Forms.CheckBox();
			this.lbl_rnd_maxtour = new System.Windows.Forms.Label();
			this.chk_rnd_lockpilots = new System.Windows.Forms.CheckBox();
			this.lbl_rnd_maxsci = new System.Windows.Forms.Label();
			this.chk_rnd_lockengi = new System.Windows.Forms.CheckBox();
			this.chk_rnd_locksci = new System.Windows.Forms.CheckBox();
			this.tbar_rnd_maxtour = new System.Windows.Forms.TrackBar();
			this.lbl_rnd_maxtourdisp = new System.Windows.Forms.Label();
			this.tbar_rnd_maxsci = new System.Windows.Forms.TrackBar();
			this.tbar_rnd_maxengi = new System.Windows.Forms.TrackBar();
			this.tbar_rnd_maxpilots = new System.Windows.Forms.TrackBar();
			this.tbar_rnd_maxpilotsdisp = new System.Windows.Forms.Label();
			this.tbar_rnd_maxscidisp = new System.Windows.Forms.Label();
			this.lbl_rnd_maxengidisp = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.lbl_rnd_maxbadsdisp = new System.Windows.Forms.Label();
			this.lbl_rnd_maxbads = new System.Windows.Forms.Label();
			this.tbar_rnd_maxbads = new System.Windows.Forms.TrackBar();
			this.lbl_rnd_minbadsdisp = new System.Windows.Forms.Label();
			this.lbl_rnd_minbads = new System.Windows.Forms.Label();
			this.tbar_rnd_minbads = new System.Windows.Forms.TrackBar();
			this.lbl_rnd_maxbravedisp = new System.Windows.Forms.Label();
			this.lbl_rnd_minbravedisp = new System.Windows.Forms.Label();
			this.lbl_rnd_maxstupiddisp = new System.Windows.Forms.Label();
			this.lbl_rnd_minStupidDisp = new System.Windows.Forms.Label();
			this.lbl_rnd_minstupid = new System.Windows.Forms.Label();
			this.lbl_rnd_maxbrave = new System.Windows.Forms.Label();
			this.tbar_rnd_maxbrave = new System.Windows.Forms.TrackBar();
			this.tbar_rnd_minStupidity = new System.Windows.Forms.TrackBar();
			this.lbl_rnd_maxstupid = new System.Windows.Forms.Label();
			this.tbar_rnd_maxstupid = new System.Windows.Forms.TrackBar();
			this.lbl_rnd_minbrave = new System.Windows.Forms.Label();
			this.tbr_rnd_minbrave = new System.Windows.Forms.TrackBar();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lbl_rnd_mfRatio = new System.Windows.Forms.Label();
			this.chk_rnd_allFemale = new System.Windows.Forms.CheckBox();
			this.chk_rnd_allMale = new System.Windows.Forms.CheckBox();
			this.tbar_rnd_MaleToFemale = new System.Windows.Forms.TrackBar();
			this.lbl_rnd_genderSettings = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_rnd_reset = new System.Windows.Forms.Button();
			this.pnl_spe_gen = new System.Windows.Forms.Panel();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.btn_spe_reset = new System.Windows.Forms.Button();
			this.btn_spe_generate = new System.Windows.Forms.Button();
			this.gb_spe_gen = new System.Windows.Forms.GroupBox();
			this.chk_spe_rndName = new System.Windows.Forms.CheckBox();
			this.chk_spe_lastNameKerman = new System.Windows.Forms.CheckBox();
			this.groupBox14 = new System.Windows.Forms.GroupBox();
			this.chk_spe_rndStupid = new System.Windows.Forms.CheckBox();
			this.chk_spe_rndBrave = new System.Windows.Forms.CheckBox();
			this.lbl_spe_stupid = new System.Windows.Forms.Label();
			this.lbl_spe_stupiddisp = new System.Windows.Forms.Label();
			this.tbar_spe_stupid = new System.Windows.Forms.TrackBar();
			this.lbl_spe_brave = new System.Windows.Forms.Label();
			this.lbl_spe_bravedisp = new System.Windows.Forms.Label();
			this.tbar_spe_brave = new System.Windows.Forms.TrackBar();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.chk_spe_tourist = new System.Windows.Forms.CheckBox();
			this.chk_spe_badass = new System.Windows.Forms.CheckBox();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.rd_spe_sci = new System.Windows.Forms.RadioButton();
			this.rd_spe_engi = new System.Windows.Forms.RadioButton();
			this.rd_spe_pilot = new System.Windows.Forms.RadioButton();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.rd_spe_genderfemale = new System.Windows.Forms.RadioButton();
			this.rd_spe_gendermale = new System.Windows.Forms.RadioButton();
			this.txt_spe_kerbname = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.groupBox16 = new System.Windows.Forms.GroupBox();
			this.groupBox20 = new System.Windows.Forms.GroupBox();
			this.lbl_si_badscount = new System.Windows.Forms.Label();
			this.lbl_si_tourcountdisp = new System.Windows.Forms.Label();
			this.lbl_si_tourcount = new System.Windows.Forms.Label();
			this.lbl_si_badscountdisp = new System.Windows.Forms.Label();
			this.groupBox19 = new System.Windows.Forms.GroupBox();
			this.lbl_si_scicountdisp = new System.Windows.Forms.Label();
			this.lbl_si_pilotcount = new System.Windows.Forms.Label();
			this.lbl_si_pilotcountdisp = new System.Windows.Forms.Label();
			this.lbl_si_scicount = new System.Windows.Forms.Label();
			this.lbl_si_engicount = new System.Windows.Forms.Label();
			this.lbl_si_engicountdisp = new System.Windows.Forms.Label();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.lbl_si_livingcount = new System.Windows.Forms.Label();
			this.lbl_si_kerbcountdisp = new System.Windows.Forms.Label();
			this.lbl_si_deadcountdisp = new System.Windows.Forms.Label();
			this.lbl_si_deadcount = new System.Windows.Forms.Label();
			this.lbl_si_kerbcount = new System.Windows.Forms.Label();
			this.lbl_si_livingcountdisp = new System.Windows.Forms.Label();
			this.groupBox17 = new System.Windows.Forms.GroupBox();
			this.lbl_si_gendermcount = new System.Windows.Forms.Label();
			this.lbl_si_genderfcountdisp = new System.Windows.Forms.Label();
			this.lbl_si_genderfcount = new System.Windows.Forms.Label();
			this.lbl_si_gendermcountdisp = new System.Windows.Forms.Label();
			this.groupBox15 = new System.Windows.Forms.GroupBox();
			this.gb_ki_stats = new System.Windows.Forms.GroupBox();
			this.lbl_ki_flightcountdisp = new System.Windows.Forms.Label();
			this.lbl_ki_stupid = new System.Windows.Forms.Label();
			this.lbl_ki_statedisp = new System.Windows.Forms.Label();
			this.lbl_ki_flightcount = new System.Windows.Forms.Label();
			this.lbl_ki_stupiddisp = new System.Windows.Forms.Label();
			this.lbl_ki_state = new System.Windows.Forms.Label();
			this.lbl_ki_bravedisp = new System.Windows.Forms.Label();
			this.lbl_ki_tourdisp = new System.Windows.Forms.Label();
			this.lbl_ki_badsdisp = new System.Windows.Forms.Label();
			this.lbl_ki_statusdisp = new System.Windows.Forms.Label();
			this.lbl_ki_roledisp = new System.Windows.Forms.Label();
			this.lbl_ki_genderdisp = new System.Windows.Forms.Label();
			this.lbl_ki_bads = new System.Windows.Forms.Label();
			this.lbl_ki_tour = new System.Windows.Forms.Label();
			this.lbl_ki_brave = new System.Windows.Forms.Label();
			this.lbl_ki_status = new System.Windows.Forms.Label();
			this.lbl_ki_role = new System.Windows.Forms.Label();
			this.lbl_ki_gender = new System.Windows.Forms.Label();
			this.cmb_ki_selectKerb = new System.Windows.Forms.Label();
			this.cmb_kerb_list = new System.Windows.Forms.ComboBox();
			this.pnl_po_options = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.grp_save_flag = new System.Windows.Forms.GroupBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gb_si_CrewBkdwn = new System.Windows.Forms.GroupBox();
			this.lbl_si_hired = new System.Windows.Forms.Label();
			this.lbl_si_applcntdisp = new System.Windows.Forms.Label();
			this.lbl_si_applicants = new System.Windows.Forms.Label();
			this.lbl_si_hireddisp = new System.Windows.Forms.Label();
			this.gb_si_statusBkdwn = new System.Windows.Forms.GroupBox();
			this.lbl_si_assigned = new System.Windows.Forms.Label();
			this.lbl_si_availdisp = new System.Windows.Forms.Label();
			this.lbl_si_assigneddisp = new System.Windows.Forms.Label();
			this.lbl_si_avail = new System.Windows.Forms.Label();
			gb_po_options = new System.Windows.Forms.GroupBox();
			panel3 = new System.Windows.Forms.Panel();
			gb_po_options.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxtour)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxsci)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxengi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxpilots)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxbads)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_minbads)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxbrave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_minStupidity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxstupid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbr_rnd_minbrave)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_MaleToFemale)).BeginInit();
			this.panel1.SuspendLayout();
			this.pnl_spe_gen.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.gb_spe_gen.SuspendLayout();
			this.groupBox14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbar_spe_stupid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_spe_brave)).BeginInit();
			this.groupBox13.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.groupBox11.SuspendLayout();
			panel3.SuspendLayout();
			this.groupBox16.SuspendLayout();
			this.groupBox20.SuspendLayout();
			this.groupBox19.SuspendLayout();
			this.groupBox18.SuspendLayout();
			this.groupBox17.SuspendLayout();
			this.groupBox15.SuspendLayout();
			this.gb_ki_stats.SuspendLayout();
			this.pnl_po_options.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.gb_si_CrewBkdwn.SuspendLayout();
			this.gb_si_statusBkdwn.SuspendLayout();
			this.SuspendLayout();
			// 
			// gb_po_options
			// 
			gb_po_options.AutoSize = true;
			gb_po_options.Controls.Add(this.btn_po_exit);
			gb_po_options.Controls.Add(this.btn_po_Save);
			gb_po_options.Controls.Add(this.btn_po_OpenCfgr);
			gb_po_options.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			gb_po_options.Location = new System.Drawing.Point(3, 3);
			gb_po_options.Name = "gb_po_options";
			gb_po_options.Size = new System.Drawing.Size(685, 88);
			gb_po_options.TabIndex = 5;
			gb_po_options.TabStop = false;
			gb_po_options.Text = "Program Options";
			// 
			// btn_po_Save
			// 
			this.btn_po_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_po_Save.Location = new System.Drawing.Point(261, 29);
			this.btn_po_Save.Name = "btn_po_Save";
			this.btn_po_Save.Size = new System.Drawing.Size(161, 23);
			this.btn_po_Save.TabIndex = 8;
			this.btn_po_Save.Text = "Save";
			this.btn_po_Save.UseVisualStyleBackColor = true;
			this.btn_po_Save.Click += new System.EventHandler(this.btn_po_Save_Click);
			// 
			// btn_po_OpenCfgr
			// 
			this.btn_po_OpenCfgr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_po_OpenCfgr.Location = new System.Drawing.Point(90, 29);
			this.btn_po_OpenCfgr.Name = "btn_po_OpenCfgr";
			this.btn_po_OpenCfgr.Size = new System.Drawing.Size(161, 23);
			this.btn_po_OpenCfgr.TabIndex = 7;
			this.btn_po_OpenCfgr.Text = "Open Configuration Manager";
			this.btn_po_OpenCfgr.UseVisualStyleBackColor = true;
			this.btn_po_OpenCfgr.Click += new System.EventHandler(this.btn_po_OpenCfgr_Click);
			// 
			// btn_po_exit
			// 
			this.btn_po_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_po_exit.Location = new System.Drawing.Point(433, 29);
			this.btn_po_exit.Name = "btn_po_exit";
			this.btn_po_exit.Size = new System.Drawing.Size(161, 23);
			this.btn_po_exit.TabIndex = 6;
			this.btn_po_exit.Text = "Exit";
			this.btn_po_exit.UseVisualStyleBackColor = true;
			this.btn_po_exit.Click += new System.EventHandler(this.btn_po_exit_Click);
			// 
			// lbl_saveSelect
			// 
			this.lbl_saveSelect.AutoSize = true;
			this.lbl_saveSelect.Location = new System.Drawing.Point(319, 22);
			this.lbl_saveSelect.Name = "lbl_saveSelect";
			this.lbl_saveSelect.Size = new System.Drawing.Size(110, 13);
			this.lbl_saveSelect.TabIndex = 9;
			this.lbl_saveSelect.Text = "Please Select A Save";
			// 
			// cmb_AvailSaves
			// 
			this.cmb_AvailSaves.FormattingEnabled = true;
			this.cmb_AvailSaves.Location = new System.Drawing.Point(3, 19);
			this.cmb_AvailSaves.Name = "cmb_AvailSaves";
			this.cmb_AvailSaves.Size = new System.Drawing.Size(314, 21);
			this.cmb_AvailSaves.TabIndex = 8;
			this.cmb_AvailSaves.SelectedIndexChanged += new System.EventHandler(this.cmb_AvailSaves_SelectedIndexChanged);
			// 
			// btn_rnd_gen_Kerb
			// 
			this.btn_rnd_gen_Kerb.AutoSize = true;
			this.btn_rnd_gen_Kerb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_rnd_gen_Kerb.Location = new System.Drawing.Point(7, 706);
			this.btn_rnd_gen_Kerb.Name = "btn_rnd_gen_Kerb";
			this.btn_rnd_gen_Kerb.Size = new System.Drawing.Size(138, 23);
			this.btn_rnd_gen_Kerb.TabIndex = 5;
			this.btn_rnd_gen_Kerb.Text = "Generate Kerbals";
			this.btn_rnd_gen_Kerb.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox2.Controls.Add(this.lbl_CurrentSaveDir);
			this.groupBox2.Controls.Add(this.label59);
			this.groupBox2.Controls.Add(this.lbl_kspInstalDir);
			this.groupBox2.Controls.Add(this.label57);
			this.groupBox2.Controls.Add(this.lbl_currentSaveLocation);
			this.groupBox2.Controls.Add(this.lbl_saveSelect);
			this.groupBox2.Controls.Add(this.cmb_AvailSaves);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1025, 77);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Save Selection";
			// 
			// lbl_CurrentSaveDir
			// 
			this.lbl_CurrentSaveDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_CurrentSaveDir.Location = new System.Drawing.Point(3, 43);
			this.lbl_CurrentSaveDir.Name = "lbl_CurrentSaveDir";
			this.lbl_CurrentSaveDir.Size = new System.Drawing.Size(314, 19);
			this.lbl_CurrentSaveDir.TabIndex = 14;
			// 
			// label59
			// 
			this.label59.AutoSize = true;
			this.label59.Location = new System.Drawing.Point(424, 44);
			this.label59.Name = "label59";
			this.label59.Size = new System.Drawing.Size(114, 13);
			this.label59.TabIndex = 13;
			this.label59.Text = "Current Save Directory";
			// 
			// lbl_kspInstalDir
			// 
			this.lbl_kspInstalDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_kspInstalDir.Location = new System.Drawing.Point(544, 16);
			this.lbl_kspInstalDir.Name = "lbl_kspInstalDir";
			this.lbl_kspInstalDir.Size = new System.Drawing.Size(471, 19);
			this.lbl_kspInstalDir.TabIndex = 12;
			// 
			// label57
			// 
			this.label57.AutoSize = true;
			this.label57.Location = new System.Drawing.Point(435, 17);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(103, 13);
			this.label57.TabIndex = 11;
			this.label57.Text = "KSP Install Directory";
			// 
			// lbl_currentSaveLocation
			// 
			this.lbl_currentSaveLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_currentSaveLocation.Location = new System.Drawing.Point(544, 43);
			this.lbl_currentSaveLocation.Name = "lbl_currentSaveLocation";
			this.lbl_currentSaveLocation.Size = new System.Drawing.Size(471, 19);
			this.lbl_currentSaveLocation.TabIndex = 10;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.groupBox7);
			this.groupBox3.Controls.Add(this.groupBox6);
			this.groupBox3.Controls.Add(this.groupBox5);
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Location = new System.Drawing.Point(3, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(317, 697);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Generate Multiple Random Kerbals";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.dmn_rnd_MaxKerbals);
			this.groupBox7.Controls.Add(this.lbl_rnd_MaxKerbs);
			this.groupBox7.Location = new System.Drawing.Point(7, 23);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(294, 49);
			this.groupBox7.TabIndex = 3;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Number Of Kerbals to Generate";
			// 
			// dmn_rnd_MaxKerbals
			// 
			this.dmn_rnd_MaxKerbals.Location = new System.Drawing.Point(240, 19);
			this.dmn_rnd_MaxKerbals.Name = "dmn_rnd_MaxKerbals";
			this.dmn_rnd_MaxKerbals.Size = new System.Drawing.Size(49, 20);
			this.dmn_rnd_MaxKerbals.TabIndex = 2;
			this.dmn_rnd_MaxKerbals.Text = "1";
			this.dmn_rnd_MaxKerbals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbl_rnd_MaxKerbs
			// 
			this.lbl_rnd_MaxKerbs.AutoSize = true;
			this.lbl_rnd_MaxKerbs.Location = new System.Drawing.Point(19, 22);
			this.lbl_rnd_MaxKerbs.Name = "lbl_rnd_MaxKerbs";
			this.lbl_rnd_MaxKerbs.Size = new System.Drawing.Size(199, 13);
			this.lbl_rnd_MaxKerbs.TabIndex = 1;
			this.lbl_rnd_MaxKerbs.Text = "Number Of Kerbals To Create (Max :  50)";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.groupBox8);
			this.groupBox6.Controls.Add(this.tbar_rnd_maxtour);
			this.groupBox6.Controls.Add(this.lbl_rnd_maxtourdisp);
			this.groupBox6.Controls.Add(this.tbar_rnd_maxsci);
			this.groupBox6.Controls.Add(this.tbar_rnd_maxengi);
			this.groupBox6.Controls.Add(this.tbar_rnd_maxpilots);
			this.groupBox6.Controls.Add(this.tbar_rnd_maxpilotsdisp);
			this.groupBox6.Controls.Add(this.tbar_rnd_maxscidisp);
			this.groupBox6.Controls.Add(this.lbl_rnd_maxengidisp);
			this.groupBox6.Location = new System.Drawing.Point(7, 465);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(295, 217);
			this.groupBox6.TabIndex = 2;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Professions";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.lbl_rnd_maxpilots);
			this.groupBox8.Controls.Add(this.lbl_rnd_engi);
			this.groupBox8.Controls.Add(this.chk_rnd_locktour);
			this.groupBox8.Controls.Add(this.lbl_rnd_maxtour);
			this.groupBox8.Controls.Add(this.chk_rnd_lockpilots);
			this.groupBox8.Controls.Add(this.lbl_rnd_maxsci);
			this.groupBox8.Controls.Add(this.chk_rnd_lockengi);
			this.groupBox8.Controls.Add(this.chk_rnd_locksci);
			this.groupBox8.Location = new System.Drawing.Point(6, 15);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(111, 192);
			this.groupBox8.TabIndex = 20;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Lock";
			// 
			// lbl_rnd_maxpilots
			// 
			this.lbl_rnd_maxpilots.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl_rnd_maxpilots.Location = new System.Drawing.Point(9, 15);
			this.lbl_rnd_maxpilots.Name = "lbl_rnd_maxpilots";
			this.lbl_rnd_maxpilots.Size = new System.Drawing.Size(45, 22);
			this.lbl_rnd_maxpilots.TabIndex = 9;
			this.lbl_rnd_maxpilots.Text = "Pilot";
			this.lbl_rnd_maxpilots.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_rnd_engi
			// 
			this.lbl_rnd_engi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl_rnd_engi.Location = new System.Drawing.Point(3, 60);
			this.lbl_rnd_engi.Name = "lbl_rnd_engi";
			this.lbl_rnd_engi.Size = new System.Drawing.Size(51, 22);
			this.lbl_rnd_engi.TabIndex = 10;
			this.lbl_rnd_engi.Text = "Engineers";
			this.lbl_rnd_engi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chk_rnd_locktour
			// 
			this.chk_rnd_locktour.AutoSize = true;
			this.chk_rnd_locktour.Location = new System.Drawing.Point(60, 150);
			this.chk_rnd_locktour.Name = "chk_rnd_locktour";
			this.chk_rnd_locktour.Size = new System.Drawing.Size(50, 17);
			this.chk_rnd_locktour.TabIndex = 23;
			this.chk_rnd_locktour.Text = "Lock";
			this.chk_rnd_locktour.UseVisualStyleBackColor = true;
			// 
			// lbl_rnd_maxtour
			// 
			this.lbl_rnd_maxtour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl_rnd_maxtour.Location = new System.Drawing.Point(9, 150);
			this.lbl_rnd_maxtour.Name = "lbl_rnd_maxtour";
			this.lbl_rnd_maxtour.Size = new System.Drawing.Size(45, 22);
			this.lbl_rnd_maxtour.TabIndex = 18;
			this.lbl_rnd_maxtour.Text = "Tourist";
			this.lbl_rnd_maxtour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chk_rnd_lockpilots
			// 
			this.chk_rnd_lockpilots.AutoSize = true;
			this.chk_rnd_lockpilots.Location = new System.Drawing.Point(60, 15);
			this.chk_rnd_lockpilots.Name = "chk_rnd_lockpilots";
			this.chk_rnd_lockpilots.Size = new System.Drawing.Size(50, 17);
			this.chk_rnd_lockpilots.TabIndex = 20;
			this.chk_rnd_lockpilots.Text = "Lock";
			this.chk_rnd_lockpilots.UseVisualStyleBackColor = true;
			// 
			// lbl_rnd_maxsci
			// 
			this.lbl_rnd_maxsci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl_rnd_maxsci.Location = new System.Drawing.Point(3, 105);
			this.lbl_rnd_maxsci.Name = "lbl_rnd_maxsci";
			this.lbl_rnd_maxsci.Size = new System.Drawing.Size(51, 22);
			this.lbl_rnd_maxsci.TabIndex = 12;
			this.lbl_rnd_maxsci.Text = "Scientist";
			this.lbl_rnd_maxsci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chk_rnd_lockengi
			// 
			this.chk_rnd_lockengi.AutoSize = true;
			this.chk_rnd_lockengi.Location = new System.Drawing.Point(60, 60);
			this.chk_rnd_lockengi.Name = "chk_rnd_lockengi";
			this.chk_rnd_lockengi.Size = new System.Drawing.Size(50, 17);
			this.chk_rnd_lockengi.TabIndex = 21;
			this.chk_rnd_lockengi.Text = "Lock";
			this.chk_rnd_lockengi.UseVisualStyleBackColor = true;
			// 
			// chk_rnd_locksci
			// 
			this.chk_rnd_locksci.AutoSize = true;
			this.chk_rnd_locksci.Location = new System.Drawing.Point(60, 105);
			this.chk_rnd_locksci.Name = "chk_rnd_locksci";
			this.chk_rnd_locksci.Size = new System.Drawing.Size(50, 17);
			this.chk_rnd_locksci.TabIndex = 22;
			this.chk_rnd_locksci.Text = "Lock";
			this.chk_rnd_locksci.UseVisualStyleBackColor = true;
			// 
			// tbar_rnd_maxtour
			// 
			this.tbar_rnd_maxtour.Location = new System.Drawing.Point(123, 162);
			this.tbar_rnd_maxtour.Name = "tbar_rnd_maxtour";
			this.tbar_rnd_maxtour.Size = new System.Drawing.Size(104, 45);
			this.tbar_rnd_maxtour.TabIndex = 17;
			// 
			// lbl_rnd_maxtourdisp
			// 
			this.lbl_rnd_maxtourdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_rnd_maxtourdisp.Location = new System.Drawing.Point(237, 162);
			this.lbl_rnd_maxtourdisp.Name = "lbl_rnd_maxtourdisp";
			this.lbl_rnd_maxtourdisp.Size = new System.Drawing.Size(52, 30);
			this.lbl_rnd_maxtourdisp.TabIndex = 19;
			// 
			// tbar_rnd_maxsci
			// 
			this.tbar_rnd_maxsci.Location = new System.Drawing.Point(123, 120);
			this.tbar_rnd_maxsci.Name = "tbar_rnd_maxsci";
			this.tbar_rnd_maxsci.Size = new System.Drawing.Size(104, 45);
			this.tbar_rnd_maxsci.TabIndex = 11;
			// 
			// tbar_rnd_maxengi
			// 
			this.tbar_rnd_maxengi.Location = new System.Drawing.Point(123, 73);
			this.tbar_rnd_maxengi.Name = "tbar_rnd_maxengi";
			this.tbar_rnd_maxengi.Size = new System.Drawing.Size(104, 45);
			this.tbar_rnd_maxengi.TabIndex = 8;
			// 
			// tbar_rnd_maxpilots
			// 
			this.tbar_rnd_maxpilots.Location = new System.Drawing.Point(123, 26);
			this.tbar_rnd_maxpilots.Name = "tbar_rnd_maxpilots";
			this.tbar_rnd_maxpilots.Size = new System.Drawing.Size(104, 45);
			this.tbar_rnd_maxpilots.TabIndex = 8;
			// 
			// tbar_rnd_maxpilotsdisp
			// 
			this.tbar_rnd_maxpilotsdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tbar_rnd_maxpilotsdisp.Location = new System.Drawing.Point(237, 26);
			this.tbar_rnd_maxpilotsdisp.Name = "tbar_rnd_maxpilotsdisp";
			this.tbar_rnd_maxpilotsdisp.Size = new System.Drawing.Size(52, 30);
			this.tbar_rnd_maxpilotsdisp.TabIndex = 11;
			// 
			// tbar_rnd_maxscidisp
			// 
			this.tbar_rnd_maxscidisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tbar_rnd_maxscidisp.Location = new System.Drawing.Point(237, 120);
			this.tbar_rnd_maxscidisp.Name = "tbar_rnd_maxscidisp";
			this.tbar_rnd_maxscidisp.Size = new System.Drawing.Size(52, 30);
			this.tbar_rnd_maxscidisp.TabIndex = 16;
			// 
			// lbl_rnd_maxengidisp
			// 
			this.lbl_rnd_maxengidisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_rnd_maxengidisp.Location = new System.Drawing.Point(237, 73);
			this.lbl_rnd_maxengidisp.Name = "lbl_rnd_maxengidisp";
			this.lbl_rnd_maxengidisp.Size = new System.Drawing.Size(52, 30);
			this.lbl_rnd_maxengidisp.TabIndex = 15;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.lbl_rnd_maxbadsdisp);
			this.groupBox5.Controls.Add(this.lbl_rnd_maxbads);
			this.groupBox5.Controls.Add(this.tbar_rnd_maxbads);
			this.groupBox5.Controls.Add(this.lbl_rnd_minbadsdisp);
			this.groupBox5.Controls.Add(this.lbl_rnd_minbads);
			this.groupBox5.Controls.Add(this.tbar_rnd_minbads);
			this.groupBox5.Controls.Add(this.lbl_rnd_maxbravedisp);
			this.groupBox5.Controls.Add(this.lbl_rnd_minbravedisp);
			this.groupBox5.Controls.Add(this.lbl_rnd_maxstupiddisp);
			this.groupBox5.Controls.Add(this.lbl_rnd_minStupidDisp);
			this.groupBox5.Controls.Add(this.lbl_rnd_minstupid);
			this.groupBox5.Controls.Add(this.lbl_rnd_maxbrave);
			this.groupBox5.Controls.Add(this.tbar_rnd_maxbrave);
			this.groupBox5.Controls.Add(this.tbar_rnd_minStupidity);
			this.groupBox5.Controls.Add(this.lbl_rnd_maxstupid);
			this.groupBox5.Controls.Add(this.tbar_rnd_maxstupid);
			this.groupBox5.Controls.Add(this.lbl_rnd_minbrave);
			this.groupBox5.Controls.Add(this.tbr_rnd_minbrave);
			this.groupBox5.Location = new System.Drawing.Point(7, 152);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(295, 301);
			this.groupBox5.TabIndex = 1;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Ability Scores";
			// 
			// lbl_rnd_maxbadsdisp
			// 
			this.lbl_rnd_maxbadsdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_rnd_maxbadsdisp.Location = new System.Drawing.Point(237, 253);
			this.lbl_rnd_maxbadsdisp.Name = "lbl_rnd_maxbadsdisp";
			this.lbl_rnd_maxbadsdisp.Size = new System.Drawing.Size(52, 30);
			this.lbl_rnd_maxbadsdisp.TabIndex = 23;
			// 
			// lbl_rnd_maxbads
			// 
			this.lbl_rnd_maxbads.AutoSize = true;
			this.lbl_rnd_maxbads.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl_rnd_maxbads.Location = new System.Drawing.Point(6, 253);
			this.lbl_rnd_maxbads.Name = "lbl_rnd_maxbads";
			this.lbl_rnd_maxbads.Size = new System.Drawing.Size(100, 13);
			this.lbl_rnd_maxbads.TabIndex = 22;
			this.lbl_rnd_maxbads.Text = "Maximum Badasses";
			this.lbl_rnd_maxbads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbar_rnd_maxbads
			// 
			this.tbar_rnd_maxbads.Location = new System.Drawing.Point(123, 253);
			this.tbar_rnd_maxbads.Name = "tbar_rnd_maxbads";
			this.tbar_rnd_maxbads.Size = new System.Drawing.Size(104, 45);
			this.tbar_rnd_maxbads.TabIndex = 21;
			// 
			// lbl_rnd_minbadsdisp
			// 
			this.lbl_rnd_minbadsdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_rnd_minbadsdisp.Location = new System.Drawing.Point(237, 207);
			this.lbl_rnd_minbadsdisp.Name = "lbl_rnd_minbadsdisp";
			this.lbl_rnd_minbadsdisp.Size = new System.Drawing.Size(52, 30);
			this.lbl_rnd_minbadsdisp.TabIndex = 20;
			// 
			// lbl_rnd_minbads
			// 
			this.lbl_rnd_minbads.AutoSize = true;
			this.lbl_rnd_minbads.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl_rnd_minbads.Location = new System.Drawing.Point(9, 207);
			this.lbl_rnd_minbads.Name = "lbl_rnd_minbads";
			this.lbl_rnd_minbads.Size = new System.Drawing.Size(97, 13);
			this.lbl_rnd_minbads.TabIndex = 19;
			this.lbl_rnd_minbads.Text = "Minimum Badasses";
			this.lbl_rnd_minbads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbar_rnd_minbads
			// 
			this.tbar_rnd_minbads.Location = new System.Drawing.Point(123, 207);
			this.tbar_rnd_minbads.Name = "tbar_rnd_minbads";
			this.tbar_rnd_minbads.Size = new System.Drawing.Size(104, 45);
			this.tbar_rnd_minbads.TabIndex = 18;
			// 
			// lbl_rnd_maxbravedisp
			// 
			this.lbl_rnd_maxbravedisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_rnd_maxbravedisp.Location = new System.Drawing.Point(237, 160);
			this.lbl_rnd_maxbravedisp.Name = "lbl_rnd_maxbravedisp";
			this.lbl_rnd_maxbravedisp.Size = new System.Drawing.Size(52, 30);
			this.lbl_rnd_maxbravedisp.TabIndex = 17;
			// 
			// lbl_rnd_minbravedisp
			// 
			this.lbl_rnd_minbravedisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_rnd_minbravedisp.Location = new System.Drawing.Point(237, 113);
			this.lbl_rnd_minbravedisp.Name = "lbl_rnd_minbravedisp";
			this.lbl_rnd_minbravedisp.Size = new System.Drawing.Size(52, 30);
			this.lbl_rnd_minbravedisp.TabIndex = 16;
			// 
			// lbl_rnd_maxstupiddisp
			// 
			this.lbl_rnd_maxstupiddisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_rnd_maxstupiddisp.Location = new System.Drawing.Point(237, 66);
			this.lbl_rnd_maxstupiddisp.Name = "lbl_rnd_maxstupiddisp";
			this.lbl_rnd_maxstupiddisp.Size = new System.Drawing.Size(52, 30);
			this.lbl_rnd_maxstupiddisp.TabIndex = 15;
			// 
			// lbl_rnd_minStupidDisp
			// 
			this.lbl_rnd_minStupidDisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_rnd_minStupidDisp.Location = new System.Drawing.Point(237, 19);
			this.lbl_rnd_minStupidDisp.Name = "lbl_rnd_minStupidDisp";
			this.lbl_rnd_minStupidDisp.Size = new System.Drawing.Size(52, 30);
			this.lbl_rnd_minStupidDisp.TabIndex = 11;
			// 
			// lbl_rnd_minstupid
			// 
			this.lbl_rnd_minstupid.AutoSize = true;
			this.lbl_rnd_minstupid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl_rnd_minstupid.Location = new System.Drawing.Point(15, 19);
			this.lbl_rnd_minstupid.Name = "lbl_rnd_minstupid";
			this.lbl_rnd_minstupid.Size = new System.Drawing.Size(91, 13);
			this.lbl_rnd_minstupid.TabIndex = 9;
			this.lbl_rnd_minstupid.Text = "Minimum Stupidity";
			this.lbl_rnd_minstupid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_rnd_maxbrave
			// 
			this.lbl_rnd_maxbrave.AutoSize = true;
			this.lbl_rnd_maxbrave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl_rnd_maxbrave.Location = new System.Drawing.Point(16, 160);
			this.lbl_rnd_maxbrave.Name = "lbl_rnd_maxbrave";
			this.lbl_rnd_maxbrave.Size = new System.Drawing.Size(90, 13);
			this.lbl_rnd_maxbrave.TabIndex = 14;
			this.lbl_rnd_maxbrave.Text = "Maximum Bravery";
			this.lbl_rnd_maxbrave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbar_rnd_maxbrave
			// 
			this.tbar_rnd_maxbrave.Location = new System.Drawing.Point(123, 160);
			this.tbar_rnd_maxbrave.Name = "tbar_rnd_maxbrave";
			this.tbar_rnd_maxbrave.Size = new System.Drawing.Size(104, 45);
			this.tbar_rnd_maxbrave.TabIndex = 13;
			// 
			// tbar_rnd_minStupidity
			// 
			this.tbar_rnd_minStupidity.Location = new System.Drawing.Point(123, 19);
			this.tbar_rnd_minStupidity.Name = "tbar_rnd_minStupidity";
			this.tbar_rnd_minStupidity.Size = new System.Drawing.Size(104, 45);
			this.tbar_rnd_minStupidity.TabIndex = 8;
			// 
			// lbl_rnd_maxstupid
			// 
			this.lbl_rnd_maxstupid.AutoSize = true;
			this.lbl_rnd_maxstupid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl_rnd_maxstupid.Location = new System.Drawing.Point(12, 66);
			this.lbl_rnd_maxstupid.Name = "lbl_rnd_maxstupid";
			this.lbl_rnd_maxstupid.Size = new System.Drawing.Size(94, 13);
			this.lbl_rnd_maxstupid.TabIndex = 10;
			this.lbl_rnd_maxstupid.Text = "Maximum Stupidity";
			this.lbl_rnd_maxstupid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbar_rnd_maxstupid
			// 
			this.tbar_rnd_maxstupid.Location = new System.Drawing.Point(123, 66);
			this.tbar_rnd_maxstupid.Name = "tbar_rnd_maxstupid";
			this.tbar_rnd_maxstupid.Size = new System.Drawing.Size(104, 45);
			this.tbar_rnd_maxstupid.TabIndex = 8;
			// 
			// lbl_rnd_minbrave
			// 
			this.lbl_rnd_minbrave.AutoSize = true;
			this.lbl_rnd_minbrave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl_rnd_minbrave.Location = new System.Drawing.Point(19, 113);
			this.lbl_rnd_minbrave.Name = "lbl_rnd_minbrave";
			this.lbl_rnd_minbrave.Size = new System.Drawing.Size(87, 13);
			this.lbl_rnd_minbrave.TabIndex = 12;
			this.lbl_rnd_minbrave.Text = "Minimum Bravery";
			this.lbl_rnd_minbrave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbr_rnd_minbrave
			// 
			this.tbr_rnd_minbrave.Location = new System.Drawing.Point(123, 113);
			this.tbr_rnd_minbrave.Name = "tbr_rnd_minbrave";
			this.tbr_rnd_minbrave.Size = new System.Drawing.Size(104, 45);
			this.tbr_rnd_minbrave.TabIndex = 11;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lbl_rnd_mfRatio);
			this.groupBox4.Controls.Add(this.chk_rnd_allFemale);
			this.groupBox4.Controls.Add(this.chk_rnd_allMale);
			this.groupBox4.Controls.Add(this.tbar_rnd_MaleToFemale);
			this.groupBox4.Controls.Add(this.lbl_rnd_genderSettings);
			this.groupBox4.Location = new System.Drawing.Point(7, 78);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(295, 67);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Gender Settings";
			// 
			// lbl_rnd_mfRatio
			// 
			this.lbl_rnd_mfRatio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_rnd_mfRatio.Location = new System.Drawing.Point(239, 16);
			this.lbl_rnd_mfRatio.Name = "lbl_rnd_mfRatio";
			this.lbl_rnd_mfRatio.Size = new System.Drawing.Size(52, 30);
			this.lbl_rnd_mfRatio.TabIndex = 10;
			// 
			// chk_rnd_allFemale
			// 
			this.chk_rnd_allFemale.AutoSize = true;
			this.chk_rnd_allFemale.Location = new System.Drawing.Point(159, 44);
			this.chk_rnd_allFemale.Name = "chk_rnd_allFemale";
			this.chk_rnd_allFemale.Size = new System.Drawing.Size(74, 17);
			this.chk_rnd_allFemale.TabIndex = 9;
			this.chk_rnd_allFemale.Text = "All Female";
			this.chk_rnd_allFemale.UseVisualStyleBackColor = true;
			// 
			// chk_rnd_allMale
			// 
			this.chk_rnd_allMale.AutoSize = true;
			this.chk_rnd_allMale.Location = new System.Drawing.Point(6, 44);
			this.chk_rnd_allMale.Name = "chk_rnd_allMale";
			this.chk_rnd_allMale.Size = new System.Drawing.Size(63, 17);
			this.chk_rnd_allMale.TabIndex = 8;
			this.chk_rnd_allMale.Text = "All Male";
			this.chk_rnd_allMale.UseVisualStyleBackColor = true;
			// 
			// tbar_rnd_MaleToFemale
			// 
			this.tbar_rnd_MaleToFemale.Location = new System.Drawing.Point(123, 16);
			this.tbar_rnd_MaleToFemale.Name = "tbar_rnd_MaleToFemale";
			this.tbar_rnd_MaleToFemale.Size = new System.Drawing.Size(110, 45);
			this.tbar_rnd_MaleToFemale.TabIndex = 6;
			// 
			// lbl_rnd_genderSettings
			// 
			this.lbl_rnd_genderSettings.AutoSize = true;
			this.lbl_rnd_genderSettings.Location = new System.Drawing.Point(6, 16);
			this.lbl_rnd_genderSettings.Name = "lbl_rnd_genderSettings";
			this.lbl_rnd_genderSettings.Size = new System.Drawing.Size(111, 13);
			this.lbl_rnd_genderSettings.TabIndex = 7;
			this.lbl_rnd_genderSettings.Text = "Male To Female Ratio";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.btn_rnd_reset);
			this.panel1.Controls.Add(this.btn_rnd_gen_Kerb);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Location = new System.Drawing.Point(6, 120);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(330, 740);
			this.panel1.TabIndex = 7;
			// 
			// btn_rnd_reset
			// 
			this.btn_rnd_reset.AutoSize = true;
			this.btn_rnd_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_rnd_reset.Location = new System.Drawing.Point(182, 706);
			this.btn_rnd_reset.Name = "btn_rnd_reset";
			this.btn_rnd_reset.Size = new System.Drawing.Size(138, 23);
			this.btn_rnd_reset.TabIndex = 7;
			this.btn_rnd_reset.Text = "Reset";
			this.btn_rnd_reset.UseVisualStyleBackColor = true;
			// 
			// pnl_spe_gen
			// 
			this.pnl_spe_gen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnl_spe_gen.Controls.Add(this.groupBox9);
			this.pnl_spe_gen.Location = new System.Drawing.Point(342, 120);
			this.pnl_spe_gen.Name = "pnl_spe_gen";
			this.pnl_spe_gen.Size = new System.Drawing.Size(348, 379);
			this.pnl_spe_gen.TabIndex = 8;
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.btn_spe_reset);
			this.groupBox9.Controls.Add(this.btn_spe_generate);
			this.groupBox9.Controls.Add(this.gb_spe_gen);
			this.groupBox9.Location = new System.Drawing.Point(8, 3);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(329, 357);
			this.groupBox9.TabIndex = 0;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Generate A Specific Kerbal";
			// 
			// btn_spe_reset
			// 
			this.btn_spe_reset.AutoSize = true;
			this.btn_spe_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_spe_reset.Location = new System.Drawing.Point(178, 319);
			this.btn_spe_reset.Name = "btn_spe_reset";
			this.btn_spe_reset.Size = new System.Drawing.Size(138, 23);
			this.btn_spe_reset.TabIndex = 8;
			this.btn_spe_reset.Text = "Reset";
			this.btn_spe_reset.UseVisualStyleBackColor = true;
			this.btn_spe_reset.Click += new System.EventHandler(this.btn_spe_reset_Click);
			// 
			// btn_spe_generate
			// 
			this.btn_spe_generate.AutoSize = true;
			this.btn_spe_generate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_spe_generate.Location = new System.Drawing.Point(11, 319);
			this.btn_spe_generate.Name = "btn_spe_generate";
			this.btn_spe_generate.Size = new System.Drawing.Size(138, 23);
			this.btn_spe_generate.TabIndex = 8;
			this.btn_spe_generate.Text = "Generate";
			this.btn_spe_generate.UseVisualStyleBackColor = true;
			this.btn_spe_generate.Click += new System.EventHandler(this.btn_spe_generate_Click);
			// 
			// gb_spe_gen
			// 
			this.gb_spe_gen.Controls.Add(this.chk_spe_rndName);
			this.gb_spe_gen.Controls.Add(this.chk_spe_lastNameKerman);
			this.gb_spe_gen.Controls.Add(this.groupBox14);
			this.gb_spe_gen.Controls.Add(this.groupBox13);
			this.gb_spe_gen.Controls.Add(this.groupBox12);
			this.gb_spe_gen.Controls.Add(this.groupBox11);
			this.gb_spe_gen.Controls.Add(this.txt_spe_kerbname);
			this.gb_spe_gen.Controls.Add(this.label28);
			this.gb_spe_gen.Location = new System.Drawing.Point(11, 19);
			this.gb_spe_gen.Name = "gb_spe_gen";
			this.gb_spe_gen.Size = new System.Drawing.Size(305, 294);
			this.gb_spe_gen.TabIndex = 0;
			this.gb_spe_gen.TabStop = false;
			this.gb_spe_gen.Text = "Basic Info";
			// 
			// chk_spe_rndName
			// 
			this.chk_spe_rndName.AutoSize = true;
			this.chk_spe_rndName.Location = new System.Drawing.Point(9, 44);
			this.chk_spe_rndName.Name = "chk_spe_rndName";
			this.chk_spe_rndName.Size = new System.Drawing.Size(97, 17);
			this.chk_spe_rndName.TabIndex = 6;
			this.chk_spe_rndName.Text = "Random Name";
			this.chk_spe_rndName.UseVisualStyleBackColor = true;
			this.chk_spe_rndName.CheckedChanged += new System.EventHandler(this.chk_spe_rndName_CheckedChanged);
			// 
			// chk_spe_lastNameKerman
			// 
			this.chk_spe_lastNameKerman.AutoSize = true;
			this.chk_spe_lastNameKerman.Location = new System.Drawing.Point(136, 44);
			this.chk_spe_lastNameKerman.Name = "chk_spe_lastNameKerman";
			this.chk_spe_lastNameKerman.Size = new System.Drawing.Size(156, 17);
			this.chk_spe_lastNameKerman.TabIndex = 5;
			this.chk_spe_lastNameKerman.Text = "Use Kerman For Last Name";
			this.chk_spe_lastNameKerman.UseVisualStyleBackColor = true;
			this.chk_spe_lastNameKerman.CheckedChanged += new System.EventHandler(this.chk_spe_lastNameKerman_CheckedChanged);
			// 
			// groupBox14
			// 
			this.groupBox14.Controls.Add(this.chk_spe_rndStupid);
			this.groupBox14.Controls.Add(this.chk_spe_rndBrave);
			this.groupBox14.Controls.Add(this.lbl_spe_stupid);
			this.groupBox14.Controls.Add(this.lbl_spe_stupiddisp);
			this.groupBox14.Controls.Add(this.tbar_spe_stupid);
			this.groupBox14.Controls.Add(this.lbl_spe_brave);
			this.groupBox14.Controls.Add(this.lbl_spe_bravedisp);
			this.groupBox14.Controls.Add(this.tbar_spe_brave);
			this.groupBox14.Location = new System.Drawing.Point(15, 171);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Size = new System.Drawing.Size(277, 107);
			this.groupBox14.TabIndex = 4;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "Ability Scores";
			// 
			// chk_spe_rndStupid
			// 
			this.chk_spe_rndStupid.AutoSize = true;
			this.chk_spe_rndStupid.Location = new System.Drawing.Point(205, 60);
			this.chk_spe_rndStupid.Name = "chk_spe_rndStupid";
			this.chk_spe_rndStupid.Size = new System.Drawing.Size(66, 17);
			this.chk_spe_rndStupid.TabIndex = 31;
			this.chk_spe_rndStupid.Text = "Random";
			this.chk_spe_rndStupid.UseVisualStyleBackColor = true;
			this.chk_spe_rndStupid.CheckedChanged += new System.EventHandler(this.chk_spe_rndStupid_CheckedChanged);
			// 
			// chk_spe_rndBrave
			// 
			this.chk_spe_rndBrave.AutoSize = true;
			this.chk_spe_rndBrave.Location = new System.Drawing.Point(205, 21);
			this.chk_spe_rndBrave.Name = "chk_spe_rndBrave";
			this.chk_spe_rndBrave.Size = new System.Drawing.Size(66, 17);
			this.chk_spe_rndBrave.TabIndex = 30;
			this.chk_spe_rndBrave.Text = "Random";
			this.chk_spe_rndBrave.UseVisualStyleBackColor = true;
			this.chk_spe_rndBrave.CheckedChanged += new System.EventHandler(this.chk_spe_rndBrave_CheckedChanged);
			// 
			// lbl_spe_stupid
			// 
			this.lbl_spe_stupid.AutoSize = true;
			this.lbl_spe_stupid.Location = new System.Drawing.Point(5, 60);
			this.lbl_spe_stupid.Name = "lbl_spe_stupid";
			this.lbl_spe_stupid.Size = new System.Drawing.Size(47, 13);
			this.lbl_spe_stupid.TabIndex = 28;
			this.lbl_spe_stupid.Text = "Stupidity";
			this.lbl_spe_stupid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_spe_stupiddisp
			// 
			this.lbl_spe_stupiddisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_spe_stupiddisp.Location = new System.Drawing.Point(158, 59);
			this.lbl_spe_stupiddisp.Name = "lbl_spe_stupiddisp";
			this.lbl_spe_stupiddisp.Size = new System.Drawing.Size(41, 30);
			this.lbl_spe_stupiddisp.TabIndex = 29;
			// 
			// tbar_spe_stupid
			// 
			this.tbar_spe_stupid.Location = new System.Drawing.Point(58, 56);
			this.tbar_spe_stupid.Maximum = 100;
			this.tbar_spe_stupid.Name = "tbar_spe_stupid";
			this.tbar_spe_stupid.Size = new System.Drawing.Size(104, 45);
			this.tbar_spe_stupid.TabIndex = 27;
			this.tbar_spe_stupid.Scroll += new System.EventHandler(this.tbar_spe_stupid_Scroll);
			// 
			// lbl_spe_brave
			// 
			this.lbl_spe_brave.AutoSize = true;
			this.lbl_spe_brave.Location = new System.Drawing.Point(9, 21);
			this.lbl_spe_brave.Name = "lbl_spe_brave";
			this.lbl_spe_brave.Size = new System.Drawing.Size(43, 13);
			this.lbl_spe_brave.TabIndex = 25;
			this.lbl_spe_brave.Text = "Bravery";
			this.lbl_spe_brave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_spe_bravedisp
			// 
			this.lbl_spe_bravedisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_spe_bravedisp.Location = new System.Drawing.Point(158, 15);
			this.lbl_spe_bravedisp.Name = "lbl_spe_bravedisp";
			this.lbl_spe_bravedisp.Size = new System.Drawing.Size(41, 30);
			this.lbl_spe_bravedisp.TabIndex = 26;
			// 
			// tbar_spe_brave
			// 
			this.tbar_spe_brave.Location = new System.Drawing.Point(58, 15);
			this.tbar_spe_brave.Maximum = 100;
			this.tbar_spe_brave.Name = "tbar_spe_brave";
			this.tbar_spe_brave.Size = new System.Drawing.Size(104, 45);
			this.tbar_spe_brave.TabIndex = 24;
			this.tbar_spe_brave.Scroll += new System.EventHandler(this.tbar_spe_brave_Scroll);
			// 
			// groupBox13
			// 
			this.groupBox13.Controls.Add(this.chk_spe_tourist);
			this.groupBox13.Controls.Add(this.chk_spe_badass);
			this.groupBox13.Location = new System.Drawing.Point(155, 69);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(134, 45);
			this.groupBox13.TabIndex = 3;
			this.groupBox13.TabStop = false;
			this.groupBox13.Text = "Badass";
			// 
			// chk_spe_tourist
			// 
			this.chk_spe_tourist.AutoSize = true;
			this.chk_spe_tourist.Location = new System.Drawing.Point(70, 18);
			this.chk_spe_tourist.Name = "chk_spe_tourist";
			this.chk_spe_tourist.Size = new System.Drawing.Size(58, 17);
			this.chk_spe_tourist.TabIndex = 5;
			this.chk_spe_tourist.Text = "Tourist";
			this.chk_spe_tourist.UseVisualStyleBackColor = true;
			// 
			// chk_spe_badass
			// 
			this.chk_spe_badass.AutoSize = true;
			this.chk_spe_badass.Location = new System.Drawing.Point(6, 18);
			this.chk_spe_badass.Name = "chk_spe_badass";
			this.chk_spe_badass.Size = new System.Drawing.Size(61, 17);
			this.chk_spe_badass.TabIndex = 4;
			this.chk_spe_badass.Text = "Badass";
			this.chk_spe_badass.UseVisualStyleBackColor = true;
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.rd_spe_sci);
			this.groupBox12.Controls.Add(this.rd_spe_engi);
			this.groupBox12.Controls.Add(this.rd_spe_pilot);
			this.groupBox12.Location = new System.Drawing.Point(15, 120);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(274, 45);
			this.groupBox12.TabIndex = 3;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Profession";
			// 
			// rd_spe_sci
			// 
			this.rd_spe_sci.AutoSize = true;
			this.rd_spe_sci.Location = new System.Drawing.Point(203, 19);
			this.rd_spe_sci.Name = "rd_spe_sci";
			this.rd_spe_sci.Size = new System.Drawing.Size(65, 17);
			this.rd_spe_sci.TabIndex = 2;
			this.rd_spe_sci.Text = "Scientist";
			this.rd_spe_sci.UseVisualStyleBackColor = true;
			// 
			// rd_spe_engi
			// 
			this.rd_spe_engi.AutoSize = true;
			this.rd_spe_engi.Location = new System.Drawing.Point(105, 19);
			this.rd_spe_engi.Name = "rd_spe_engi";
			this.rd_spe_engi.Size = new System.Drawing.Size(67, 17);
			this.rd_spe_engi.TabIndex = 1;
			this.rd_spe_engi.Text = "Engineer";
			this.rd_spe_engi.UseVisualStyleBackColor = true;
			// 
			// rd_spe_pilot
			// 
			this.rd_spe_pilot.AutoSize = true;
			this.rd_spe_pilot.Checked = true;
			this.rd_spe_pilot.Location = new System.Drawing.Point(6, 19);
			this.rd_spe_pilot.Name = "rd_spe_pilot";
			this.rd_spe_pilot.Size = new System.Drawing.Size(45, 17);
			this.rd_spe_pilot.TabIndex = 0;
			this.rd_spe_pilot.TabStop = true;
			this.rd_spe_pilot.Text = "Pilot";
			this.rd_spe_pilot.UseVisualStyleBackColor = true;
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.rd_spe_genderfemale);
			this.groupBox11.Controls.Add(this.rd_spe_gendermale);
			this.groupBox11.Location = new System.Drawing.Point(15, 69);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(134, 45);
			this.groupBox11.TabIndex = 2;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Gender";
			// 
			// rd_spe_genderfemale
			// 
			this.rd_spe_genderfemale.AutoSize = true;
			this.rd_spe_genderfemale.Checked = true;
			this.rd_spe_genderfemale.Location = new System.Drawing.Point(69, 19);
			this.rd_spe_genderfemale.Name = "rd_spe_genderfemale";
			this.rd_spe_genderfemale.Size = new System.Drawing.Size(59, 17);
			this.rd_spe_genderfemale.TabIndex = 1;
			this.rd_spe_genderfemale.TabStop = true;
			this.rd_spe_genderfemale.Text = "Female";
			this.rd_spe_genderfemale.UseVisualStyleBackColor = true;
			// 
			// rd_spe_gendermale
			// 
			this.rd_spe_gendermale.AutoSize = true;
			this.rd_spe_gendermale.Location = new System.Drawing.Point(6, 19);
			this.rd_spe_gendermale.Name = "rd_spe_gendermale";
			this.rd_spe_gendermale.Size = new System.Drawing.Size(48, 17);
			this.rd_spe_gendermale.TabIndex = 0;
			this.rd_spe_gendermale.Text = "Male";
			this.rd_spe_gendermale.UseVisualStyleBackColor = true;
			// 
			// txt_spe_kerbname
			// 
			this.txt_spe_kerbname.Location = new System.Drawing.Point(47, 18);
			this.txt_spe_kerbname.MaxLength = 18;
			this.txt_spe_kerbname.Name = "txt_spe_kerbname";
			this.txt_spe_kerbname.Size = new System.Drawing.Size(252, 20);
			this.txt_spe_kerbname.TabIndex = 1;
			this.txt_spe_kerbname.TextChanged += new System.EventHandler(this.txt_spe_kerbname_TextChanged);
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(6, 21);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(35, 13);
			this.label28.TabIndex = 0;
			this.label28.Text = "Name";
			// 
			// panel3
			// 
			panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			panel3.Controls.Add(this.groupBox16);
			panel3.Controls.Add(this.groupBox15);
			panel3.Location = new System.Drawing.Point(696, 120);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(346, 636);
			panel3.TabIndex = 9;
			// 
			// groupBox16
			// 
			this.groupBox16.Controls.Add(this.gb_si_statusBkdwn);
			this.groupBox16.Controls.Add(this.gb_si_CrewBkdwn);
			this.groupBox16.Controls.Add(this.groupBox20);
			this.groupBox16.Controls.Add(this.groupBox19);
			this.groupBox16.Controls.Add(this.groupBox18);
			this.groupBox16.Controls.Add(this.groupBox17);
			this.groupBox16.Location = new System.Drawing.Point(6, 3);
			this.groupBox16.Name = "groupBox16";
			this.groupBox16.Size = new System.Drawing.Size(328, 357);
			this.groupBox16.TabIndex = 3;
			this.groupBox16.TabStop = false;
			this.groupBox16.Text = "Save Info";
			// 
			// groupBox20
			// 
			this.groupBox20.Controls.Add(this.lbl_si_badscount);
			this.groupBox20.Controls.Add(this.lbl_si_tourcountdisp);
			this.groupBox20.Controls.Add(this.lbl_si_tourcount);
			this.groupBox20.Controls.Add(this.lbl_si_badscountdisp);
			this.groupBox20.Location = new System.Drawing.Point(161, 164);
			this.groupBox20.Name = "groupBox20";
			this.groupBox20.Size = new System.Drawing.Size(149, 79);
			this.groupBox20.TabIndex = 21;
			this.groupBox20.TabStop = false;
			this.groupBox20.Text = "Trait Breakdown";
			// 
			// lbl_si_badscount
			// 
			this.lbl_si_badscount.Location = new System.Drawing.Point(6, 23);
			this.lbl_si_badscount.Name = "lbl_si_badscount";
			this.lbl_si_badscount.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_badscount.TabIndex = 10;
			this.lbl_si_badscount.Text = "Badass";
			this.lbl_si_badscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_si_tourcountdisp
			// 
			this.lbl_si_tourcountdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_tourcountdisp.Location = new System.Drawing.Point(74, 46);
			this.lbl_si_tourcountdisp.Name = "lbl_si_tourcountdisp";
			this.lbl_si_tourcountdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_tourcountdisp.TabIndex = 11;
			// 
			// lbl_si_tourcount
			// 
			this.lbl_si_tourcount.Location = new System.Drawing.Point(6, 51);
			this.lbl_si_tourcount.Name = "lbl_si_tourcount";
			this.lbl_si_tourcount.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_tourcount.TabIndex = 10;
			this.lbl_si_tourcount.Text = "Tourist";
			this.lbl_si_tourcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_si_badscountdisp
			// 
			this.lbl_si_badscountdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_badscountdisp.Location = new System.Drawing.Point(74, 18);
			this.lbl_si_badscountdisp.Name = "lbl_si_badscountdisp";
			this.lbl_si_badscountdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_badscountdisp.TabIndex = 11;
			// 
			// groupBox19
			// 
			this.groupBox19.Controls.Add(this.lbl_si_scicountdisp);
			this.groupBox19.Controls.Add(this.lbl_si_pilotcount);
			this.groupBox19.Controls.Add(this.lbl_si_pilotcountdisp);
			this.groupBox19.Controls.Add(this.lbl_si_scicount);
			this.groupBox19.Controls.Add(this.lbl_si_engicount);
			this.groupBox19.Controls.Add(this.lbl_si_engicountdisp);
			this.groupBox19.Location = new System.Drawing.Point(161, 19);
			this.groupBox19.Name = "groupBox19";
			this.groupBox19.Size = new System.Drawing.Size(149, 139);
			this.groupBox19.TabIndex = 22;
			this.groupBox19.TabStop = false;
			this.groupBox19.Text = "Profession Breakdown";
			// 
			// lbl_si_scicountdisp
			// 
			this.lbl_si_scicountdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_scicountdisp.Location = new System.Drawing.Point(74, 87);
			this.lbl_si_scicountdisp.Name = "lbl_si_scicountdisp";
			this.lbl_si_scicountdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_scicountdisp.TabIndex = 11;
			// 
			// lbl_si_pilotcount
			// 
			this.lbl_si_pilotcount.Location = new System.Drawing.Point(6, 21);
			this.lbl_si_pilotcount.Name = "lbl_si_pilotcount";
			this.lbl_si_pilotcount.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_pilotcount.TabIndex = 10;
			this.lbl_si_pilotcount.Text = "Pilots";
			this.lbl_si_pilotcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_si_pilotcountdisp
			// 
			this.lbl_si_pilotcountdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_pilotcountdisp.Location = new System.Drawing.Point(74, 16);
			this.lbl_si_pilotcountdisp.Name = "lbl_si_pilotcountdisp";
			this.lbl_si_pilotcountdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_pilotcountdisp.TabIndex = 11;
			// 
			// lbl_si_scicount
			// 
			this.lbl_si_scicount.Location = new System.Drawing.Point(6, 92);
			this.lbl_si_scicount.Name = "lbl_si_scicount";
			this.lbl_si_scicount.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_scicount.TabIndex = 10;
			this.lbl_si_scicount.Text = "Scientists";
			this.lbl_si_scicount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_si_engicount
			// 
			this.lbl_si_engicount.Location = new System.Drawing.Point(6, 59);
			this.lbl_si_engicount.Name = "lbl_si_engicount";
			this.lbl_si_engicount.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_engicount.TabIndex = 20;
			this.lbl_si_engicount.Text = "Engineers";
			this.lbl_si_engicount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_si_engicountdisp
			// 
			this.lbl_si_engicountdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_engicountdisp.Location = new System.Drawing.Point(74, 54);
			this.lbl_si_engicountdisp.Name = "lbl_si_engicountdisp";
			this.lbl_si_engicountdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_engicountdisp.TabIndex = 21;
			// 
			// groupBox18
			// 
			this.groupBox18.Controls.Add(this.lbl_si_livingcount);
			this.groupBox18.Controls.Add(this.lbl_si_kerbcountdisp);
			this.groupBox18.Controls.Add(this.lbl_si_deadcountdisp);
			this.groupBox18.Controls.Add(this.lbl_si_deadcount);
			this.groupBox18.Controls.Add(this.lbl_si_kerbcount);
			this.groupBox18.Controls.Add(this.lbl_si_livingcountdisp);
			this.groupBox18.Location = new System.Drawing.Point(6, 19);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(149, 139);
			this.groupBox18.TabIndex = 21;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "General Info";
			// 
			// lbl_si_livingcount
			// 
			this.lbl_si_livingcount.Location = new System.Drawing.Point(6, 59);
			this.lbl_si_livingcount.Name = "lbl_si_livingcount";
			this.lbl_si_livingcount.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_livingcount.TabIndex = 10;
			this.lbl_si_livingcount.Text = "Living";
			this.lbl_si_livingcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_si_kerbcountdisp
			// 
			this.lbl_si_kerbcountdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_kerbcountdisp.Location = new System.Drawing.Point(74, 16);
			this.lbl_si_kerbcountdisp.Name = "lbl_si_kerbcountdisp";
			this.lbl_si_kerbcountdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_kerbcountdisp.TabIndex = 19;
			// 
			// lbl_si_deadcountdisp
			// 
			this.lbl_si_deadcountdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_deadcountdisp.Location = new System.Drawing.Point(74, 87);
			this.lbl_si_deadcountdisp.Name = "lbl_si_deadcountdisp";
			this.lbl_si_deadcountdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_deadcountdisp.TabIndex = 11;
			// 
			// lbl_si_deadcount
			// 
			this.lbl_si_deadcount.Location = new System.Drawing.Point(6, 92);
			this.lbl_si_deadcount.Name = "lbl_si_deadcount";
			this.lbl_si_deadcount.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_deadcount.TabIndex = 10;
			this.lbl_si_deadcount.Text = "Dead";
			this.lbl_si_deadcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_si_kerbcount
			// 
			this.lbl_si_kerbcount.Location = new System.Drawing.Point(6, 21);
			this.lbl_si_kerbcount.Name = "lbl_si_kerbcount";
			this.lbl_si_kerbcount.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_kerbcount.TabIndex = 18;
			this.lbl_si_kerbcount.Text = "Kerbals";
			this.lbl_si_kerbcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_si_livingcountdisp
			// 
			this.lbl_si_livingcountdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_livingcountdisp.Location = new System.Drawing.Point(74, 54);
			this.lbl_si_livingcountdisp.Name = "lbl_si_livingcountdisp";
			this.lbl_si_livingcountdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_livingcountdisp.TabIndex = 11;
			// 
			// groupBox17
			// 
			this.groupBox17.Controls.Add(this.lbl_si_gendermcount);
			this.groupBox17.Controls.Add(this.lbl_si_genderfcountdisp);
			this.groupBox17.Controls.Add(this.lbl_si_genderfcount);
			this.groupBox17.Controls.Add(this.lbl_si_gendermcountdisp);
			this.groupBox17.Location = new System.Drawing.Point(6, 164);
			this.groupBox17.Name = "groupBox17";
			this.groupBox17.Size = new System.Drawing.Size(149, 79);
			this.groupBox17.TabIndex = 20;
			this.groupBox17.TabStop = false;
			this.groupBox17.Text = "Gender Breakdown";
			// 
			// lbl_si_gendermcount
			// 
			this.lbl_si_gendermcount.Location = new System.Drawing.Point(6, 23);
			this.lbl_si_gendermcount.Name = "lbl_si_gendermcount";
			this.lbl_si_gendermcount.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_gendermcount.TabIndex = 10;
			this.lbl_si_gendermcount.Text = "Males";
			this.lbl_si_gendermcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_si_genderfcountdisp
			// 
			this.lbl_si_genderfcountdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_genderfcountdisp.Location = new System.Drawing.Point(74, 46);
			this.lbl_si_genderfcountdisp.Name = "lbl_si_genderfcountdisp";
			this.lbl_si_genderfcountdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_genderfcountdisp.TabIndex = 11;
			// 
			// lbl_si_genderfcount
			// 
			this.lbl_si_genderfcount.Location = new System.Drawing.Point(6, 51);
			this.lbl_si_genderfcount.Name = "lbl_si_genderfcount";
			this.lbl_si_genderfcount.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_genderfcount.TabIndex = 10;
			this.lbl_si_genderfcount.Text = "Females";
			this.lbl_si_genderfcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_si_gendermcountdisp
			// 
			this.lbl_si_gendermcountdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_gendermcountdisp.Location = new System.Drawing.Point(74, 18);
			this.lbl_si_gendermcountdisp.Name = "lbl_si_gendermcountdisp";
			this.lbl_si_gendermcountdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_gendermcountdisp.TabIndex = 11;
			// 
			// groupBox15
			// 
			this.groupBox15.Controls.Add(this.gb_ki_stats);
			this.groupBox15.Controls.Add(this.cmb_ki_selectKerb);
			this.groupBox15.Controls.Add(this.cmb_kerb_list);
			this.groupBox15.Location = new System.Drawing.Point(6, 374);
			this.groupBox15.Name = "groupBox15";
			this.groupBox15.Size = new System.Drawing.Size(337, 186);
			this.groupBox15.TabIndex = 2;
			this.groupBox15.TabStop = false;
			this.groupBox15.Text = "View Kerbal Info";
			// 
			// gb_ki_stats
			// 
			this.gb_ki_stats.Controls.Add(this.lbl_ki_flightcountdisp);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_stupid);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_statedisp);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_flightcount);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_stupiddisp);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_state);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_bravedisp);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_tourdisp);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_badsdisp);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_statusdisp);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_roledisp);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_genderdisp);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_bads);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_tour);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_brave);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_status);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_role);
			this.gb_ki_stats.Controls.Add(this.lbl_ki_gender);
			this.gb_ki_stats.Location = new System.Drawing.Point(8, 47);
			this.gb_ki_stats.Name = "gb_ki_stats";
			this.gb_ki_stats.Size = new System.Drawing.Size(323, 131);
			this.gb_ki_stats.TabIndex = 2;
			this.gb_ki_stats.TabStop = false;
			this.gb_ki_stats.Text = "Stats for: ";
			// 
			// lbl_ki_flightcountdisp
			// 
			this.lbl_ki_flightcountdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_ki_flightcountdisp.Location = new System.Drawing.Point(254, 80);
			this.lbl_ki_flightcountdisp.Name = "lbl_ki_flightcountdisp";
			this.lbl_ki_flightcountdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_ki_flightcountdisp.TabIndex = 17;
			// 
			// lbl_ki_stupid
			// 
			this.lbl_ki_stupid.AutoSize = true;
			this.lbl_ki_stupid.Location = new System.Drawing.Point(201, 40);
			this.lbl_ki_stupid.Name = "lbl_ki_stupid";
			this.lbl_ki_stupid.Size = new System.Drawing.Size(47, 13);
			this.lbl_ki_stupid.TabIndex = 4;
			this.lbl_ki_stupid.Text = "Stupidity";
			this.lbl_ki_stupid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_ki_statedisp
			// 
			this.lbl_ki_statedisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_ki_statedisp.Location = new System.Drawing.Point(254, 59);
			this.lbl_ki_statedisp.Name = "lbl_ki_statedisp";
			this.lbl_ki_statedisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_ki_statedisp.TabIndex = 16;
			// 
			// lbl_ki_flightcount
			// 
			this.lbl_ki_flightcount.AutoSize = true;
			this.lbl_ki_flightcount.Location = new System.Drawing.Point(211, 85);
			this.lbl_ki_flightcount.Name = "lbl_ki_flightcount";
			this.lbl_ki_flightcount.Size = new System.Drawing.Size(37, 13);
			this.lbl_ki_flightcount.TabIndex = 5;
			this.lbl_ki_flightcount.Text = "Flights";
			this.lbl_ki_flightcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_ki_stupiddisp
			// 
			this.lbl_ki_stupiddisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_ki_stupiddisp.Location = new System.Drawing.Point(254, 35);
			this.lbl_ki_stupiddisp.Name = "lbl_ki_stupiddisp";
			this.lbl_ki_stupiddisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_ki_stupiddisp.TabIndex = 15;
			// 
			// lbl_ki_state
			// 
			this.lbl_ki_state.AutoSize = true;
			this.lbl_ki_state.Location = new System.Drawing.Point(216, 64);
			this.lbl_ki_state.Name = "lbl_ki_state";
			this.lbl_ki_state.Size = new System.Drawing.Size(32, 13);
			this.lbl_ki_state.TabIndex = 6;
			this.lbl_ki_state.Text = "State";
			this.lbl_ki_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_ki_bravedisp
			// 
			this.lbl_ki_bravedisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_ki_bravedisp.Location = new System.Drawing.Point(254, 15);
			this.lbl_ki_bravedisp.Name = "lbl_ki_bravedisp";
			this.lbl_ki_bravedisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_ki_bravedisp.TabIndex = 14;
			// 
			// lbl_ki_tourdisp
			// 
			this.lbl_ki_tourdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_ki_tourdisp.Location = new System.Drawing.Point(74, 104);
			this.lbl_ki_tourdisp.Name = "lbl_ki_tourdisp";
			this.lbl_ki_tourdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_ki_tourdisp.TabIndex = 13;
			// 
			// lbl_ki_badsdisp
			// 
			this.lbl_ki_badsdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_ki_badsdisp.Location = new System.Drawing.Point(74, 80);
			this.lbl_ki_badsdisp.Name = "lbl_ki_badsdisp";
			this.lbl_ki_badsdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_ki_badsdisp.TabIndex = 12;
			// 
			// lbl_ki_statusdisp
			// 
			this.lbl_ki_statusdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_ki_statusdisp.Location = new System.Drawing.Point(74, 59);
			this.lbl_ki_statusdisp.Name = "lbl_ki_statusdisp";
			this.lbl_ki_statusdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_ki_statusdisp.TabIndex = 11;
			// 
			// lbl_ki_roledisp
			// 
			this.lbl_ki_roledisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_ki_roledisp.Location = new System.Drawing.Point(74, 35);
			this.lbl_ki_roledisp.Name = "lbl_ki_roledisp";
			this.lbl_ki_roledisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_ki_roledisp.TabIndex = 10;
			// 
			// lbl_ki_genderdisp
			// 
			this.lbl_ki_genderdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_ki_genderdisp.Location = new System.Drawing.Point(74, 15);
			this.lbl_ki_genderdisp.Name = "lbl_ki_genderdisp";
			this.lbl_ki_genderdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_ki_genderdisp.TabIndex = 9;
			// 
			// lbl_ki_bads
			// 
			this.lbl_ki_bads.AutoSize = true;
			this.lbl_ki_bads.Location = new System.Drawing.Point(25, 85);
			this.lbl_ki_bads.Name = "lbl_ki_bads";
			this.lbl_ki_bads.Size = new System.Drawing.Size(43, 13);
			this.lbl_ki_bads.TabIndex = 8;
			this.lbl_ki_bads.Text = "BadAss";
			this.lbl_ki_bads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_ki_tour
			// 
			this.lbl_ki_tour.AutoSize = true;
			this.lbl_ki_tour.Location = new System.Drawing.Point(29, 109);
			this.lbl_ki_tour.Name = "lbl_ki_tour";
			this.lbl_ki_tour.Size = new System.Drawing.Size(39, 13);
			this.lbl_ki_tour.TabIndex = 7;
			this.lbl_ki_tour.Text = "Tourist";
			this.lbl_ki_tour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_ki_brave
			// 
			this.lbl_ki_brave.AutoSize = true;
			this.lbl_ki_brave.Location = new System.Drawing.Point(205, 17);
			this.lbl_ki_brave.Name = "lbl_ki_brave";
			this.lbl_ki_brave.Size = new System.Drawing.Size(43, 13);
			this.lbl_ki_brave.TabIndex = 3;
			this.lbl_ki_brave.Text = "Bravery";
			this.lbl_ki_brave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_ki_status
			// 
			this.lbl_ki_status.AutoSize = true;
			this.lbl_ki_status.Location = new System.Drawing.Point(31, 64);
			this.lbl_ki_status.Name = "lbl_ki_status";
			this.lbl_ki_status.Size = new System.Drawing.Size(37, 13);
			this.lbl_ki_status.TabIndex = 2;
			this.lbl_ki_status.Text = "Status";
			this.lbl_ki_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_ki_role
			// 
			this.lbl_ki_role.AutoSize = true;
			this.lbl_ki_role.Location = new System.Drawing.Point(39, 40);
			this.lbl_ki_role.Name = "lbl_ki_role";
			this.lbl_ki_role.Size = new System.Drawing.Size(29, 13);
			this.lbl_ki_role.TabIndex = 1;
			this.lbl_ki_role.Text = "Role";
			this.lbl_ki_role.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_ki_gender
			// 
			this.lbl_ki_gender.Location = new System.Drawing.Point(6, 20);
			this.lbl_ki_gender.Name = "lbl_ki_gender";
			this.lbl_ki_gender.Size = new System.Drawing.Size(62, 13);
			this.lbl_ki_gender.TabIndex = 0;
			this.lbl_ki_gender.Text = "Gender";
			this.lbl_ki_gender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmb_ki_selectKerb
			// 
			this.cmb_ki_selectKerb.AutoSize = true;
			this.cmb_ki_selectKerb.Location = new System.Drawing.Point(6, 22);
			this.cmb_ki_selectKerb.Name = "cmb_ki_selectKerb";
			this.cmb_ki_selectKerb.Size = new System.Drawing.Size(80, 13);
			this.cmb_ki_selectKerb.TabIndex = 1;
			this.cmb_ki_selectKerb.Text = "Select A Kerbal";
			// 
			// cmb_kerb_list
			// 
			this.cmb_kerb_list.FormattingEnabled = true;
			this.cmb_kerb_list.Location = new System.Drawing.Point(92, 19);
			this.cmb_kerb_list.Name = "cmb_kerb_list";
			this.cmb_kerb_list.Size = new System.Drawing.Size(239, 21);
			this.cmb_kerb_list.TabIndex = 0;
			this.cmb_kerb_list.SelectedIndexChanged += new System.EventHandler(this.cmb_kerb_list_SelectedIndexChanged);
			// 
			// pnl_po_options
			// 
			this.pnl_po_options.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnl_po_options.Controls.Add(gb_po_options);
			this.pnl_po_options.Location = new System.Drawing.Point(342, 762);
			this.pnl_po_options.Name = "pnl_po_options";
			this.pnl_po_options.Size = new System.Drawing.Size(700, 98);
			this.pnl_po_options.TabIndex = 10;
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel5.Controls.Add(this.grp_save_flag);
			this.panel5.Location = new System.Drawing.Point(342, 510);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(347, 246);
			this.panel5.TabIndex = 11;
			// 
			// grp_save_flag
			// 
			this.grp_save_flag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.grp_save_flag.Location = new System.Drawing.Point(3, 2);
			this.grp_save_flag.Name = "grp_save_flag";
			this.grp_save_flag.Size = new System.Drawing.Size(334, 237);
			this.grp_save_flag.TabIndex = 5;
			this.grp_save_flag.TabStop = false;
			this.grp_save_flag.Text = "Save Flag";
			// 
			// panel6
			// 
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel6.Controls.Add(this.groupBox2);
			this.panel6.Location = new System.Drawing.Point(6, 27);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(1036, 87);
			this.panel6.TabIndex = 12;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1054, 23);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
			this.fileToolStripMenuItem.Text = "File";
			this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(89, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// gb_si_CrewBkdwn
			// 
			this.gb_si_CrewBkdwn.Controls.Add(this.lbl_si_hired);
			this.gb_si_CrewBkdwn.Controls.Add(this.lbl_si_applcntdisp);
			this.gb_si_CrewBkdwn.Controls.Add(this.lbl_si_hireddisp);
			this.gb_si_CrewBkdwn.Controls.Add(this.lbl_si_applicants);
			this.gb_si_CrewBkdwn.Location = new System.Drawing.Point(6, 247);
			this.gb_si_CrewBkdwn.Name = "gb_si_CrewBkdwn";
			this.gb_si_CrewBkdwn.Size = new System.Drawing.Size(149, 94);
			this.gb_si_CrewBkdwn.TabIndex = 23;
			this.gb_si_CrewBkdwn.TabStop = false;
			this.gb_si_CrewBkdwn.Text = "Crew BreakDown";
			// 
			// lbl_si_hired
			// 
			this.lbl_si_hired.Location = new System.Drawing.Point(5, 31);
			this.lbl_si_hired.Name = "lbl_si_hired";
			this.lbl_si_hired.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_hired.TabIndex = 12;
			this.lbl_si_hired.Text = "Hired";
			this.lbl_si_hired.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_si_applcntdisp
			// 
			this.lbl_si_applcntdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_applcntdisp.Location = new System.Drawing.Point(73, 54);
			this.lbl_si_applcntdisp.Name = "lbl_si_applcntdisp";
			this.lbl_si_applcntdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_applcntdisp.TabIndex = 14;
			// 
			// lbl_si_applicants
			// 
			this.lbl_si_applicants.Location = new System.Drawing.Point(5, 59);
			this.lbl_si_applicants.Name = "lbl_si_applicants";
			this.lbl_si_applicants.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_applicants.TabIndex = 13;
			this.lbl_si_applicants.Text = "Applicants";
			this.lbl_si_applicants.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_si_hireddisp
			// 
			this.lbl_si_hireddisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_hireddisp.Location = new System.Drawing.Point(73, 26);
			this.lbl_si_hireddisp.Name = "lbl_si_hireddisp";
			this.lbl_si_hireddisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_hireddisp.TabIndex = 15;
			// 
			// gb_si_statusBkdwn
			// 
			this.gb_si_statusBkdwn.Controls.Add(this.lbl_si_assigned);
			this.gb_si_statusBkdwn.Controls.Add(this.lbl_si_availdisp);
			this.gb_si_statusBkdwn.Controls.Add(this.lbl_si_assigneddisp);
			this.gb_si_statusBkdwn.Controls.Add(this.lbl_si_avail);
			this.gb_si_statusBkdwn.Location = new System.Drawing.Point(161, 247);
			this.gb_si_statusBkdwn.Name = "gb_si_statusBkdwn";
			this.gb_si_statusBkdwn.Size = new System.Drawing.Size(149, 94);
			this.gb_si_statusBkdwn.TabIndex = 24;
			this.gb_si_statusBkdwn.TabStop = false;
			this.gb_si_statusBkdwn.Text = "Status BreakDown";
			// 
			// lbl_si_assigned
			// 
			this.lbl_si_assigned.Location = new System.Drawing.Point(5, 31);
			this.lbl_si_assigned.Name = "lbl_si_assigned";
			this.lbl_si_assigned.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_assigned.TabIndex = 12;
			this.lbl_si_assigned.Text = "Assigned";
			this.lbl_si_assigned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_si_availdisp
			// 
			this.lbl_si_availdisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_availdisp.Location = new System.Drawing.Point(73, 54);
			this.lbl_si_availdisp.Name = "lbl_si_availdisp";
			this.lbl_si_availdisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_availdisp.TabIndex = 14;
			// 
			// lbl_si_assigneddisp
			// 
			this.lbl_si_assigneddisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_si_assigneddisp.Location = new System.Drawing.Point(73, 26);
			this.lbl_si_assigneddisp.Name = "lbl_si_assigneddisp";
			this.lbl_si_assigneddisp.Size = new System.Drawing.Size(63, 23);
			this.lbl_si_assigneddisp.TabIndex = 15;
			// 
			// lbl_si_avail
			// 
			this.lbl_si_avail.Location = new System.Drawing.Point(5, 59);
			this.lbl_si_avail.Name = "lbl_si_avail";
			this.lbl_si_avail.Size = new System.Drawing.Size(62, 13);
			this.lbl_si_avail.TabIndex = 13;
			this.lbl_si_avail.Text = "Available";
			this.lbl_si_avail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frm_Krb_Gen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1054, 926);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.pnl_po_options);
			this.Controls.Add(this.panel5);
			this.Controls.Add(panel3);
			this.Controls.Add(this.pnl_spe_gen);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "frm_Krb_Gen";
			this.Text = "Kerbal Generator";
			this.Load += new System.EventHandler(this.frm_Krb_Gen_Load);
			gb_po_options.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxtour)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxsci)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxengi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxpilots)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxbads)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_minbads)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxbrave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_minStupidity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_maxstupid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbr_rnd_minbrave)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbar_rnd_MaleToFemale)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnl_spe_gen.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.gb_spe_gen.ResumeLayout(false);
			this.gb_spe_gen.PerformLayout();
			this.groupBox14.ResumeLayout(false);
			this.groupBox14.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbar_spe_stupid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbar_spe_brave)).EndInit();
			this.groupBox13.ResumeLayout(false);
			this.groupBox13.PerformLayout();
			this.groupBox12.ResumeLayout(false);
			this.groupBox12.PerformLayout();
			this.groupBox11.ResumeLayout(false);
			this.groupBox11.PerformLayout();
			panel3.ResumeLayout(false);
			this.groupBox16.ResumeLayout(false);
			this.groupBox20.ResumeLayout(false);
			this.groupBox19.ResumeLayout(false);
			this.groupBox18.ResumeLayout(false);
			this.groupBox17.ResumeLayout(false);
			this.groupBox15.ResumeLayout(false);
			this.groupBox15.PerformLayout();
			this.gb_ki_stats.ResumeLayout(false);
			this.gb_ki_stats.PerformLayout();
			this.pnl_po_options.ResumeLayout(false);
			this.pnl_po_options.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.gb_si_CrewBkdwn.ResumeLayout(false);
			this.gb_si_statusBkdwn.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		



		#endregion
		private System.Windows.Forms.Button btn_rnd_gen_Kerb;
		private System.Windows.Forms.Label lbl_saveSelect;
		private System.Windows.Forms.ComboBox cmb_AvailSaves;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lbl_currentSaveLocation;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lbl_rnd_maxstupid;
		private System.Windows.Forms.Label lbl_rnd_minstupid;
		private System.Windows.Forms.TrackBar tbar_rnd_maxstupid;
		private System.Windows.Forms.TrackBar tbar_rnd_minStupidity;
		private System.Windows.Forms.Label lbl_rnd_genderSettings;
		private System.Windows.Forms.TrackBar tbar_rnd_MaleToFemale;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Label lbl_rnd_MaxKerbs;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label lbl_rnd_maxpilots;
		private System.Windows.Forms.TrackBar tbar_rnd_maxsci;
		private System.Windows.Forms.Label lbl_rnd_maxsci;
		private System.Windows.Forms.TrackBar tbar_rnd_maxengi;
		private System.Windows.Forms.Label lbl_rnd_engi;
		private System.Windows.Forms.TrackBar tbar_rnd_maxpilots;
		private System.Windows.Forms.Label tbar_rnd_maxpilotsdisp;
		private System.Windows.Forms.Label tbar_rnd_maxscidisp;
		private System.Windows.Forms.Label lbl_rnd_maxengidisp;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label lbl_rnd_maxbadsdisp;
		private System.Windows.Forms.Label lbl_rnd_maxbads;
		private System.Windows.Forms.TrackBar tbar_rnd_maxbads;
		private System.Windows.Forms.Label lbl_rnd_minbadsdisp;
		private System.Windows.Forms.Label lbl_rnd_minbads;
		private System.Windows.Forms.TrackBar tbar_rnd_minbads;
		private System.Windows.Forms.Label lbl_rnd_maxbravedisp;
		private System.Windows.Forms.Label lbl_rnd_minbravedisp;
		private System.Windows.Forms.Label lbl_rnd_maxstupiddisp;
		private System.Windows.Forms.Label lbl_rnd_minStupidDisp;
		private System.Windows.Forms.Label lbl_rnd_maxbrave;
		private System.Windows.Forms.TrackBar tbar_rnd_maxbrave;
		private System.Windows.Forms.Label lbl_rnd_minbrave;
		private System.Windows.Forms.TrackBar tbr_rnd_minbrave;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label lbl_rnd_mfRatio;
		private System.Windows.Forms.CheckBox chk_rnd_allFemale;
		private System.Windows.Forms.CheckBox chk_rnd_allMale;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DomainUpDown dmn_rnd_MaxKerbals;
		private System.Windows.Forms.CheckBox chk_rnd_locktour;
		private System.Windows.Forms.CheckBox chk_rnd_locksci;
		private System.Windows.Forms.CheckBox chk_rnd_lockengi;
		private System.Windows.Forms.CheckBox chk_rnd_lockpilots;
		private System.Windows.Forms.TrackBar tbar_rnd_maxtour;
		private System.Windows.Forms.Label lbl_rnd_maxtour;
		private System.Windows.Forms.Label lbl_rnd_maxtourdisp;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Button btn_rnd_reset;
		private System.Windows.Forms.Panel pnl_spe_gen;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.GroupBox gb_spe_gen;
		private System.Windows.Forms.GroupBox groupBox14;
		private System.Windows.Forms.Label lbl_spe_brave;
		private System.Windows.Forms.Label lbl_spe_bravedisp;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.CheckBox chk_spe_tourist;
		private System.Windows.Forms.CheckBox chk_spe_badass;
		private System.Windows.Forms.RadioButton rd_spe_sci;
		private System.Windows.Forms.RadioButton rd_spe_engi;
		private System.Windows.Forms.RadioButton rd_spe_pilot;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.RadioButton rd_spe_genderfemale;
		private System.Windows.Forms.RadioButton rd_spe_gendermale;
		private System.Windows.Forms.TextBox txt_spe_kerbname;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label lbl_spe_stupid;
		private System.Windows.Forms.Label lbl_spe_stupiddisp;
		private System.Windows.Forms.TrackBar tbar_spe_stupid;
		private System.Windows.Forms.Button btn_spe_reset;
		private System.Windows.Forms.Button btn_spe_generate;
		private System.Windows.Forms.GroupBox groupBox16;
		private System.Windows.Forms.Label lbl_si_scicountdisp;
		private System.Windows.Forms.Label lbl_si_scicount;
		private System.Windows.Forms.Label lbl_si_engicountdisp;
		private System.Windows.Forms.Label lbl_si_engicount;
		private System.Windows.Forms.Label lbl_si_pilotcountdisp;
		private System.Windows.Forms.Label lbl_si_pilotcount;
		private System.Windows.Forms.Label lbl_si_genderfcountdisp;
		private System.Windows.Forms.Label lbl_si_gendermcountdisp;
		private System.Windows.Forms.Label lbl_si_genderfcount;
		private System.Windows.Forms.Label lbl_si_kerbcountdisp;
		private System.Windows.Forms.Label lbl_si_gendermcount;
		private System.Windows.Forms.Label lbl_si_kerbcount;
		private System.Windows.Forms.GroupBox groupBox15;
		private System.Windows.Forms.GroupBox gb_ki_stats;
		private System.Windows.Forms.Label lbl_ki_flightcountdisp;
		private System.Windows.Forms.Label lbl_ki_stupid;
		private System.Windows.Forms.Label lbl_ki_statedisp;
		private System.Windows.Forms.Label lbl_ki_flightcount;
		private System.Windows.Forms.Label lbl_ki_stupiddisp;
		private System.Windows.Forms.Label lbl_ki_state;
		private System.Windows.Forms.Label lbl_ki_bravedisp;
		private System.Windows.Forms.Label lbl_ki_tourdisp;
		private System.Windows.Forms.Label lbl_ki_badsdisp;
		private System.Windows.Forms.Label lbl_ki_statusdisp;
		private System.Windows.Forms.Label lbl_ki_roledisp;
		private System.Windows.Forms.Label lbl_ki_genderdisp;
		private System.Windows.Forms.Label lbl_ki_bads;
		private System.Windows.Forms.Label lbl_ki_tour;
		private System.Windows.Forms.Label lbl_ki_brave;
		private System.Windows.Forms.Label lbl_ki_status;
		private System.Windows.Forms.Label lbl_ki_role;
		private System.Windows.Forms.Label lbl_ki_gender;
		private System.Windows.Forms.Label cmb_ki_selectKerb;
		private System.Windows.Forms.ComboBox cmb_kerb_list;
		private System.Windows.Forms.GroupBox groupBox20;
		private System.Windows.Forms.Label lbl_si_badscount;
		private System.Windows.Forms.Label lbl_si_tourcountdisp;
		private System.Windows.Forms.Label lbl_si_tourcount;
		private System.Windows.Forms.Label lbl_si_badscountdisp;
		private System.Windows.Forms.GroupBox groupBox19;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.Label lbl_si_livingcount;
		private System.Windows.Forms.Label lbl_si_deadcountdisp;
		private System.Windows.Forms.Label lbl_si_deadcount;
		private System.Windows.Forms.Label lbl_si_livingcountdisp;
		private System.Windows.Forms.GroupBox groupBox17;
		private System.Windows.Forms.Panel pnl_po_options;
		private System.Windows.Forms.Button btn_po_exit;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.GroupBox grp_save_flag;
		private System.Windows.Forms.Label lbl_CurrentSaveDir;
		private System.Windows.Forms.Label label59;
		private System.Windows.Forms.Label lbl_kspInstalDir;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.Button btn_po_OpenCfgr;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.CheckBox chk_spe_lastNameKerman;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.CheckBox chk_spe_rndName;
		private System.Windows.Forms.CheckBox chk_spe_rndStupid;
		private System.Windows.Forms.CheckBox chk_spe_rndBrave;
		private System.Windows.Forms.TrackBar tbar_spe_brave;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Button btn_po_Save;
		private System.Windows.Forms.GroupBox gb_si_statusBkdwn;
		private System.Windows.Forms.Label lbl_si_assigned;
		private System.Windows.Forms.Label lbl_si_availdisp;
		private System.Windows.Forms.Label lbl_si_assigneddisp;
		private System.Windows.Forms.Label lbl_si_avail;
		private System.Windows.Forms.GroupBox gb_si_CrewBkdwn;
		private System.Windows.Forms.Label lbl_si_hired;
		private System.Windows.Forms.Label lbl_si_applcntdisp;
		private System.Windows.Forms.Label lbl_si_hireddisp;
		private System.Windows.Forms.Label lbl_si_applicants;
	}
}

