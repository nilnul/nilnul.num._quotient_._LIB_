using nilnul.num.quotient_;
using nilnul.obj.str_.started;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.str_.started.scala_.fractile_
{
	/// <summary>
	/// assume the str has not been reversed;
	/// we here reverse the str, then inverse the term, add the term to the previous temr;
	/// eg:
	///		for 1+1/(2+1/3), the str before reversal is 1,2,3;
	///		after reversal, it's 3,2,1
	///		we here 1/3+2, then 1/(1/3+2) +1
	/// </summary>
	/// 
	public class ByReverse

	{

		static public DenomNonnilI _Scala_0started(
			IEnumerable<DenomNonnilI> reversed
		) {
			return _byReverse._OfReversedX._Scala_0startedReversed(
				reversed.Reverse()
			);

		}

		public static DenomNonnilI _Scala_0started(int[] ints)
		{
			return _Scala_0started(
				ints.Select(
					x=>new DenomNonnil(x)
				)
			);
		}
	}
}
