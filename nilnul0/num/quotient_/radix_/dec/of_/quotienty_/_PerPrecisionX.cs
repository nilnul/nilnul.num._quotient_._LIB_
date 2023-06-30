using nilnul.num.integer._integer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using R3 = nilnul.num.quotient.Radix;

namespace nilnul.num.quotient_.radix_.dec.of_.quotienty_
{

	static public class _PerPrecisionX
	{



		static public radix_.ByNeg ToDec(
			this

			nilnul.num.quotient_.DenomNonnilI q
			,
			uint x

		)
		{

			return  num.quotient_.radix.of_._OfQuotientX._Of_0radic_2precision(10,q,x);

		}

		static public radix_.ByNeg ToDec(
			this

			nilnul.num._quotient.fraction.op.Simplify.Ed1 q
			, uint x

		)
		{

			return ToDec(
				num.quotient_.denomNonnil._RegressionsX.ToDenomNonnil(q)
				,
				x
			);

		}


		static public ByNeg ToDec(
			this
			nilnul.num._quotient.fraction.op.Simplify.Ed1 q
			,
			int _precision_natural
		)
		{
			return ToDec(q, (uint)_precision_natural);
		}
	}
}