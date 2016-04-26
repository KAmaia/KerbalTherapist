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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalTherapist.Accumulators {
	public class RandomAccumulator {
		//number of kerbals to create
		public int NumberToCreate { get; set; }



		public bool useRatio { get; set; }

		public bool isKerman { get; set; }

		//gendersettings;
		public float FtMRatio { get; set; }
		//ability scores
		public float MinStupid { get; set; }

		public float MaxStupid { get; set; }

		public float MinBrave { get; set; }

		public float MaxBrave { get; set; }

		public int MinNumberOfBadasses { get; set; }

		public int MaxNumberOfTourists { get; set; }

		//Profession Ratios
		public int Pilots { get; set; }

		public int Engineers { get; set; }

		public int Scientists { get; set; }

		public RandomAccumulator ( ) {
			NumberToCreate = 1;
			FtMRatio = 0;
			useRatio = true; //needs to be true by default.
			MinStupid = 0.0f;
			MaxStupid = 0.0f;
			MinBrave = 0.0f;
			MaxBrave = 0.0f;
			MinNumberOfBadasses = 0;
			MaxNumberOfTourists = 0;

			Pilots = 0;
			Engineers = 0;
			Scientists = 0;
		}

		public RandomAccumulator Reset ( ) {
			return new RandomAccumulator ( );
		}
	}
}
