using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;
using nilnul.num.quotient_.radix.recur_;

namespace nilnul.num.quotient_.radix.recur.of_.ofQuotient_.mantissaly_
{
	static public class _Throw8truncX
	{
		public static ByNeg _AsByNeg_0radic_2mantissa(BigInteger _radix__plural, DenomNonnil x, BigInteger _natural__digitsAfterDot)
		{
			var negated = x < 0;
			var unsigned = quotient_.nonneg_.radix.recur.of_.ofNonneg_.trunc_.aftDot_._ThrowX._Of_0plural_1nonneg_2nonneg(
						_radix__plural
						,
						negated ?
						-x : x,
						_natural__digitsAfterDot
					);

			return new radix.recur_.ByNeg(
				unsigned
				,
				negated
			);
		}


		/// <summary>
		/// to a recur till the precision is reached
		/// </summary>
		/// <param name="_radix__plural"></param>
		/// <param name="x"></param>
		/// <returns></returns>

		static public radix.recur_.ByNeg _AsByNeg_0radic_2mantissa(
			BigInteger _radix__plural
			, nilnul.num.Quotient1 x,
			BigInteger _natural__digitsAfterDot)
		{


			var unsigned = quotient_.nonneg_.radix.recur.of_.ofNonneg_.trunc_.aftDot_._ThrowX._Of_0plural_1nonneg_2nonneg(
				_radix__plural
				,
				x.numerator.Sign < 0 ?
				-x : x,
				_natural__digitsAfterDot
			);

			return new radix.recur_.ByNeg(
				unsigned
				,
				x.numerator.Sign < 0
			);






		}

	}
}
