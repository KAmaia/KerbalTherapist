using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalTherapist.Logging {
	public class Logger {

		private static readonly string logPath = Path.Combine ( Path.Combine ( Path.Combine ( Environment.GetFolderPath ( Environment.SpecialFolder.ApplicationData ), "AmaiaSystems" ), "KerbalTherapist" ), "Logs" );
		private static readonly string logFile = Path.Combine ( logPath, ( DateTime.Now.ToString ( ).Replace ( ' ', '-' ).Replace ( '/', '-' ).Replace ( ':', '-' ) + ".txt" ) );

		private static List<string> log = new List<string> ( );

		public static void LogEvent ( string str ) {
			ValidateDirectory ( );
			ReadLog ( );
			string logMessage = FormatErrorSeperator ( "Event: " + DateTime.Now.ToString ( ) );
			logMessage += Environment.NewLine + str;
			log.Add ( logMessage );
			WriteLog ( );
		}

		internal static void LogNewLine ( string s ) {
			log.Add ( "-" + s );
			WriteLog ( );
		}

		public static void LogError ( Exception ex, object Sender ) {
			ValidateDirectory ( );
			ReadLog ( );
			string logMessage = FormatErrorSeperator ( "Error! " + DateTime.Now.ToString ( ) );
			logMessage += Environment.NewLine;
			logMessage += Sender.ToString ( );
			logMessage += Environment.NewLine;
			logMessage += ex.ToString ( );
			log.Add ( logMessage );
			WriteLog ( );
		}

		private static void ValidateDirectory ( ) {
			//since were using static Logging methods, check this EVERY time a log thing is thing'd
			if ( !Directory.Exists ( logPath ) ) {
				Directory.CreateDirectory ( logPath );
			}
			else {

			}
		}

		//ReadLog
		private static void ReadLog ( ) {
			if ( File.Exists ( logFile ) ) {
				log = File.ReadAllLines ( logFile ).ToList ( );
			}
		}

		private static void WriteLog ( ) {
			ValidateDirectory ( );
			File.WriteAllLines ( logFile, log );
		}

		private static string FormatErrorSeperator ( string str ) {
			int length = str.Length;
			string tmpErrorMsg = "";
			string seperator = "";
			for ( int i = 0; i < length * 2; i++ ) {
				seperator += "=";
			}
			int padder = ( seperator.Length ) - ( length + 1 );
			//Get the center point of tmp subtract length of str + 1 for the "+" upcoming
			str = str.PadLeft ( ( padder / 2 + length ) ).PadRight ( ( length + padder ) - 1 );
			
			tmpErrorMsg = seperator + Environment.NewLine + "+" + str + "+" + Environment.NewLine + seperator;
			return tmpErrorMsg;
		}

	}
}
