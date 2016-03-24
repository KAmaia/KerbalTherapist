using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerbalGenerator {
	class KerbalGenerator {
		private readonly string configPath = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BadWater"),"KerbalGen");
		private Config config;
		private Roster roster;
		private Configurator cfgr;
		private KerbalParser kp;
		private KerbalMaker km;
		private frm_Krb_Gen MainForm;

		public Roster Rstr { get { return roster; } }
		public Config Cfg {get{ return config; } }

		public bool IsFirstRun { get; }

		public KerbalGenerator( frm_Krb_Gen mainForm ) {
			Debug.WriteLine( configPath );
			cfgr = new Configurator( configPath );
			MainForm = mainForm;
			if ( FirstRun( ) ) {
				MainForm.SetAllControls( false );
				ConfiguratorForm cfgrForm = new ConfiguratorForm(ref cfgr);
				cfgrForm.ShowDialog( );
			}
			else {
				cfgr.LoadConfig( );
				config = cfgr.Configuration;
				MainForm.SetAllControls( true );
			}
		}

		public String[] GetSaves( ) {
			return config.SavePaths.Keys.ToArray( );
		}

		public void ParseKerbals(string persistent ) {
			kp = new KerbalParser( );
			roster = kp.Parse( config.SavePaths[persistent] );
		}

		public bool FirstRun( ) {
			string path = Path.Combine(configPath, "config.xml");
			bool retval = !File.Exists(path);
			return retval;
		}

		public string GetKerbalCounts( string s) {
			return roster.GetCounts( )[s].ToString();
		}

		internal Form GetCfgrForm( ) {
			return new ConfiguratorForm( ref cfgr );
		}
	}
}



/*
Kerbal k;
			if ( chk_spe_rndName.Checked ) {
				km.generateSpecific( true, isKerman, gender, trait, brave, dumb, badass, tourist );
			}
			else {
				name = txt_spe_kerbname.Text;
				if (isKerman) {
					if(ValidateKerbal( name + " Kerman" ) ) {
						km.generateSpecific( name, isKerman, gender, trait, brave, dumb, badass, tourist );
					}
					else {
						MessageBox.Show( "Error: Kerbal: " + name +" Already Exists In The Roster!");
					}
				}
				else {
					if ( ValidateKerbal( name ) ) {
						km.generateSpecific( name, isKerman, gender, trait, brave, dumb, badass, tourist );
					}
					else {
						MessageBox.Show( "Error! Kerbal: " + name + " Already Exists In The Roster!" );
					}
				}
			}

	*/