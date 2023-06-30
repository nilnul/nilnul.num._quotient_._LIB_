using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_.floored
{
	static public class _OfX
	{



		/// <summary>
		/// 
		/// </summary>
		/// <param name="_nonNeg"></param>
		/// <returns></returns>
		/// alias:
		///		toFloorAndTail
		///		toFloorAndProper

		public static (long, double) ToFloorAndMantissa(this double _nonNeg)
		{
			long floor = ieee._FloorX.Floor(_nonNeg);
			double num2 = _nonNeg - (double)floor;
			num2 = ((num2 > 0.0) ? num2 : 0.0);
			return (floor, num2);
		}


	}
}
