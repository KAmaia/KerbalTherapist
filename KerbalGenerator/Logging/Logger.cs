//Copyright (C) 2016 Amaia Industries
//
//Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
//associated documentation files (the "Software"), to deal in the Software without restriction, 
//including without limitation the rights to use, copy, modify, merge, publish, and distribute 
//copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
//	Notice:
//	The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
//	Modifications:
//	Any modified version or derivative of this software must include a link to the original source code.  Distributing the original source code with the 
//	release of the modified version shall be construed to satisfy this clause.
//
//	Attribution:
//	Any modified version or derivative of this software must include attribution to the original author.  
//
//	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
//	INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
//	PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE Amaia Industries 
//	BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//	TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE 
//	USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//	Except as contained in this notice, the name of Amaia Industries shall not be used in advertising or 
//	otherwise to promote the sale, use or other dealings in this Software without prior written authorization from Amaia Industries.

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
