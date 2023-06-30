using nilnul.num.quotient_;
using nilnul.obj.str_.started;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.str_.started.scala_.fractile_.bySeq_
{
	/// <summary>
	/// </summary>
	/// 
	static public class _BisectX

	{

		static public DenomNonnil _Scala_1started(
			IEnumerable<DenomNonnil> terms
			,
			IEnumerable<DenomNonnil> terms1

		) {

			/// pi.math.cornell.edu/~gautam/ContinuedFractions.pdf
			///where the last upper is refered to as p'[m]
			///, the lat lower is refered to as q'[m]


			return _BySeqX._Scala_0started(
				terms.Append(
					_BySeqX._Scala_0started(terms1)
				)
			);

	

		}

		public static DenomNonnil _Scala_1started(int[] ints, int[] tail)
		{
			return _Scala_1started(
				ints.Select(
					x=>new DenomNonnil(x)
				)
				,
				tail.Select(
					x=>DenomNonnil.Of(x)
				)
			);
		}
	}
}
