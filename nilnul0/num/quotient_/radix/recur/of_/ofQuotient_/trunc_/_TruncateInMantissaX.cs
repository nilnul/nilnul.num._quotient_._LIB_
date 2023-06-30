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

namespace nilnul.num.quotient_.radix.recur.of_.ofQuotient_
{
	/// <summary>
	///  get all the remainders, till a cycle formed.
	/// </summary>
	/// <remarks>recurring, cyclic, repeating, recurring...</remarks>
	static public class _TruncateInMantissaX
	{

		public static ByNeg _AsRecur_0radic_2mantissa(BigInteger v, DenomNonnil x, BigInteger natural__digitsAfterDo)
		{
			var negated = x<0;
	

			var unsigned = quotient_.nonneg_.radix.recur.of_.ofNonneg_.trunc_._Mantissa2truncX._Of_0plural_1nonneg_2nonneg(
				v
				,
				negated?	-x:x
				,
				natural__digitsAfterDo
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
		/// <param name="_natural__digitsAfterDot">how many gits after dot</param>
		/// <returns></returns>

		static public radix.recur_.ByNeg _AsRecur_0radic_2mantissa(
			BigInteger _radix__plural
			, nilnul.num.Quotient1 x,
			BigInteger _natural__digitsAfterDot)
		{
			var negated = false;
			if (x.numerator.Sign < 0)
			{
				negated = true;
				x = -x;
			}

			var unsigned = quotient_.nonneg_.radix.recur.of_.ofNonneg_.trunc_._Mantissa2truncX._Of_0plural_1nonneg_2nonneg(
				_radix__plural
				,
				-x,
				_natural__digitsAfterDot
			);

			return new radix.recur_.ByNeg(
				unsigned
				,
				true
			);
		}

	}
}
