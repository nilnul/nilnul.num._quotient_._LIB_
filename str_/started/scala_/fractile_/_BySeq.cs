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
	/// </summary>
	/// 
	static public class _BySeqX

	{

		static public DenomNonnil _Scala_0started(
			IEnumerable<DenomNonnil> terms
		) {

			var lowers = new nilnul.num.quotient.str_.started.scala_.fractile_._bySeq._Lowers(terms);
			var uppers = new nilnul.num.quotient.str_.started.scala_.fractile_._bySeq._Uppers(terms);

			return lowers.Last() / uppers.Last();

	

		}

		public static DenomNonnil _Scala_0started(int[] ints)
		{
			return _Scala_0started(
				ints.Select(
					x=>new DenomNonnil(x)
				)
			);
		}
	}
}
