using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ConfigNodeParser;

namespace KerbalGenerator {
	class KerbalGenerator {
		private readonly string configPath = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BadWater"),"KerbalGen");
		private Config config;
		private Roster roster;
		private Configurator cfgr;
		private KerbalParser kp;
		private KerbalMaker km;
		private frm_Krb_Gen MainForm;
		private ConfigNode persistent;

		public Roster Rstr { get { return roster; } }
		public Config Cfg { get { return config; } }

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
			
				cfgr.LoadConfig( );
				config = cfgr.Configuration;
				MainForm.SetAllControls( true );
			
		}

		public String[ ] GetSaves( ) {
			return config.SavePaths.Keys.ToArray( );
		}

		public void ParseKerbals( string saveFile ) {
			persistent = ConfigNode.Load( config.SavePaths[saveFile] );
			roster = new Roster( );
			ConfigNode rosterNode = persistent.GetNode("GAME").GetNode("ROSTER");
			foreach(ConfigNode kerbalNode in rosterNode.GetNodes("KERBAL")) {
				Kerbal k = new Kerbal();
				k.Name = kerbalNode.GetValue( "name" );
				k.Gender = kerbalNode.GetValue( "gender" );
				k.Type = kerbalNode.GetValue( "type" );
				k.Trait = kerbalNode.GetValue( "trait" );
				k.Brave = kerbalNode.GetValue( "brave" );
				k.Dumb = kerbalNode.GetValue( "dumb" );
				k.Bads = kerbalNode.GetValue( "badS" );
				k.Tour = kerbalNode.GetValue( "tour" );
				k.State = kerbalNode.GetValue( "state" );
				k.ToD = kerbalNode.GetValue( "ToD" );
				k.Flights = kerbalNode.GetNode( "CAREER_LOG" ).GetValue( "flight" );
				roster.AddKerbal( k );
			}
		}

		public bool FirstRun( ) {
			string path = Path.Combine(configPath, "config.xml");
			bool retval = !File.Exists(path);
			return retval;
		}

		public string GetKerbalCounts( string s ) {
			return roster.GetCounts( )[s].ToString( );
		}

		public Form GetCfgrForm( ) {
			return new ConfiguratorForm( ref cfgr );
		}

		public void KreateKerbal( string name, bool isKerman, string gender, string trait, float brave, float dumb, bool badass, bool tourist ) {
			km = new KerbalMaker( );
			Kerbal k = km.generateSpecific(name, isKerman, gender,trait,brave,dumb,badass,tourist);
			if ( PreviewKerbal( k ).Equals( DialogResult.Yes ) ) {
				if ( !roster.ValidateKerbal( k ) ) {
					var result = MessageBox.Show("Error! Kerbal: " + k.Name + "Already Exists!  Overwrite?", "Kerbal Exists!", MessageBoxButtons.YesNo);
					if ( result.Equals( DialogResult.Yes ) ) {
						roster.AddKerbal( k );
					}
				}
			}
		}

		public void KreateKerbal( bool genName, bool isKerman, string gender, string trait, float brave, float dumb, bool badass, bool tourist ) {
			km = new KerbalMaker( );
			bool validKerbal = false;
			Kerbal k = new Kerbal();;
			while ( !validKerbal ) {
				k = km.generateSpecific(genName, isKerman,gender,trait,brave,dumb,badass,tourist);
				validKerbal = roster.ValidateKerbal( k ); 
			}
			PreviewKerbal( k );
		}
	
		private DialogResult PreviewKerbal( Kerbal k ) {
			return new KerbalPreviewWindow( k ).ShowDialog( );
			
		}
		internal bool ValidateKerbalName( string name ) {
			return ( roster.ValidateKerbal( name ) );
		}
	}
}



