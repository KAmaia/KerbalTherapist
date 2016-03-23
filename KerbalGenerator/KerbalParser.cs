using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace KerbalGenerator {
	internal class KerbalParser {


		public Dictionary<string, Kerbal> Roster { get; set; }


		public KerbalParser( ) {
		}

		public void Parse( string savepath ) {
			StreamReader rdr = new StreamReader(savepath);
			string line ="";
			//read down, throwing away everything until we hit "roster"
			bool inRoster = false;

			string name = "";
			string gender = "";
			string type ="";
			string trait = "";
			string brave = "";
			string dumb = "";
			string bads = "";
			string tour = "";
			string state = "";
			string tod = "";
			string flights = "";

			while ( ( line = rdr.ReadLine( ) ) != null ) {
				//okay roster is found, so next we need to....
				//create a new Dictionary<string, Kerbal>
				//check for the word Kerbal
				//kreate new kerbal
				//parse in important values.
				//done
				string s = line;

				if ( s.Trim( ).Equals( "ROSTER" ) ) {
					Roster = new Dictionary<string, Kerbal>( );
					inRoster = true;
				}
				//Found the better way.  No more worries!
				//Also future me: Disregard this comment it no longer applies.

				if ( inRoster ) {
					//So now that we're in the roster, 
					//We need to See if there are any kerbals here.  

					if ( s.Trim( ).Equals( "KERBAL" ) || s.Trim( ).Equals( "MESSAGESYSTEM" ) ) {
						//okay we found a kerbal, but because stupid we have to be extra stupid.
						//if our name is not blank, generate a new kerbal.
						//(Since our names our defined only after a Kerbal section is opened, we can
						//probably safely assume that when s = Kerbal again, we're clear to create a new kerbal.
						
						if ( !( name == "" ) &&
							!( gender == "" ) && 
							!( type == "" ) && 
							!( trait == "" ) && 
							!( brave == "" ) && 
							!( dumb == "" ) && 
							!( bads == "" ) && 
							!( tour == "" ) && 
							!( state == "" ) && 
							!( tod == "" ) && 
							!( flights == "" ) ) {
							Kerbal k = new Kerbal(name, gender, type, trait, brave, dumb, bads, tour, state, tod, flights);
							Roster.Add( k.Name, k );
							name = "";
							gender = "";
							type = "";
							trait = "";
							brave = "";
							dumb = "";
							bads = "";
							tour = "";
							state = "";
							tod = "";
							flights = "";
						}
					}

					//okay, now that we know what our string names are,
					//we can start to parse them out.
					if ( s.Contains( "=" ) ) {
						string[ ] stupid = ParseValues(s);
						switch ( stupid[0] ) {
							case "name":
								name = stupid[1];
								break;
							case "gender":
								gender = stupid[1];
								break;
							case "type":
								type = stupid[1];
								break;
							case "trait":
								trait = stupid[1];
								break;
							case "brave":
								brave = stupid[1];
								break;
							case "dumb":
								dumb = stupid[1];
								break;
							case "badS":
								bads = stupid[1];
								break;
							case "tour":
								tour = stupid[1];
								break;
							case "state":
								state = stupid[1];
								break;
							case "ToD":
								tod = stupid[1];
								break;
							case "flight":
								flights = stupid[1];
								break;
							default:
								break;
						}
					}
				}
			}
		}
		private string[ ] ParseValues( string toParse ) {
			string[] parsed = toParse.Split('=');
			parsed[0] = parsed[0].Trim( );
			parsed[1] = parsed[1].Trim( );
			return parsed;
		}
	}
}


