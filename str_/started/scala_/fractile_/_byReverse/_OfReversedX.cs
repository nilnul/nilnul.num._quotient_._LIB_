using nilnul.num.quotient_;
using nilnul.obj.str_.started;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.str_.started.scala_.fractile_._byReverse
{
	/// <summary>
	/// assume the str has been reversed;
	/// we here then inverse the term, add the term to the previous temr;
	/// eg:
	///		for 1+1/(2+1/3), the str before reversal is 1,2,3;
	///		after reversal, it's 3,2,1
	///		we here 1/3+2, then 1/(1/3+2) +1
	/// </summary>
	/// 
	static public class _OfReversedX
	{
		static public DenomNonnilI ScalaOfReversed(
			DenomNonnilI toe
			,
			IEnumerator<DenomNonnilI> reversed
		) {
			return quotient.of_.binary_.fractile.converse.Cascader.Unison._Cascade_0started(
				reversed
			);

		}


		static public DenomNonnilI _Scala_0startedReversed(
			IEnumerator<DenomNonnilI> reversed
		) {
			return quotient.of_.binary_.fractile.converse.Cascader.Unison._Cascade_0started(
				reversed
			);

		}

		public static DenomNonnilI _Scala_0startedReversed(IEnumerable<DenomNonnilI> enumerable)
		{
			return _Scala_0startedReversed(enumerable.GetEnumerator());
		}
	}
}
