using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;
using nilnul.num.quotient_.radix.ext.errable_.ieee_._bin;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.of_
{
	/// <summary>
	/// </summary>
	static public class _OfNonnegQuotientX
	{



		
		static public nonneg_.radix_.Floaty _Of_0radic_2precision(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.nonneg.vow.En proper
			,
			BigInteger precision
		)
		{
			return _Of_0radic_1nonneg_2precision(_radix_plural, proper.en, precision);

		}

		public static nonneg_.radix_.Floaty _Of_0radic_1nonneg_2precision(
			BigInteger _radix_plural, Quotient1 proper, BigInteger precision
		)
		{

			return _Of_0radic_1nonneg_2precision(_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper), precision
			);
		}


		public static nonneg_.radix_.Floaty _Of_0radic_1nonneg_2precision(BigInteger _radix_plural, num.quotient_.DenomNonnilI proper, BigInteger precision)
		{
			return _CoerceX.ToFloaty(
				nonneg_.radix.of_._OfNonnegQuotientX._Of_0radic_1nonneg_2precision(
					_radix_plural,proper,precision
					)
			);






		}


	}
}
