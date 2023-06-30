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
	///  per precision
	/// </summary>
	/// <remarks>recurring, cyclic, repeating, recurring...</remarks>
	static public class _TruncateX
	{
		public static ByNeg _AsByNeg_0radic_2precision(BigInteger _radix__plural, DenomNonnil x, BigInteger _precision)
		{
			var negated = x < 0;

			var unsigned = quotient_.nonneg_.radix.recur.of_.ofNonneg_._TruncateX._Of_0plural_1nonneg_2nonneg(
				_radix__plural
				,
				negated ? -x : x,
				_precision
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

		static public radix.recur_.ByNeg _AsByNeg_0radic_2precision(
			BigInteger _radix__plural
			, nilnul.num.Quotient1 x,
			BigInteger _precision)
		{
			if (x.numerator.Sign < 0)
			{
				var unsigned = quotient_.nonneg_.radix.recur.of_.ofNonneg_._TruncateX._Of_0plural_1nonneg_2nonneg(
					_radix__plural
					,
					-x,
					_precision
				);

				return new radix.recur_.ByNeg(
					unsigned
					,
					true
				);



			}


			return new radix.recur_.ByNeg(
	quotient_.nonneg_.radix.recur.of_.ofNonneg_._TruncateX._Of_0plural_1nonneg_2nonneg(
				_radix__plural
				,
				x,
				_precision
			)

			);


			//const int TO_BE_FOUND = -1;

			//var mixedFrac = nilnul.num.quotient_.FlooredX.ToFloored(x);

			//BigInteger multiplier = mixedFrac.floor;//.Item1;
			//BigInteger exponent = 0;

			//List<BigInteger> remainders = new List<BigInteger>();
			//BigInteger remainder = mixedFrac.proper.en.numerator;

			//BigInteger recurPosition = TO_BE_FOUND;

			//while (recurPosition == TO_BE_FOUND)
			//{
			//	if (_natural__digitsAfterDot-- <= 0)
			//	{
			//		break;
			//	}

			//	if (remainder == 0)
			//	{
			//		///0 is added to the remainder; 0 will repeat for ever; and the recurFound is the last position; recurSpan is the length one. This reduces to :  no 0 is added, and ---
			//		recurPosition = remainders.Count;

			//	}
			//	else
			//	{
			//		remainders.Add(remainder);

			//		multiplier = multiplier * _radix__plural
			//			+ BigInteger.DivRem(remainder * _radix__plural, x.denominator.val, out remainder);
			//		exponent--;

			//		recurPosition = remainders.IndexOf(remainder);

			//	}

			//}

			//if (recurPosition == TO_BE_FOUND)
			//{
			//	return new Recur(_radix__plural, multiplier, exponent, 0);

			//}
			//var recurSpan = remainders.Count - recurPosition;
			//if (recurSpan == 0)
			//{
			//	var radix = new Radix1(

			//		_radix__plural, multiplier, exponent
			//	);

			//	radix.appendZero();

			//	return new Recur(radix, 1);

			//}

			//return new Recur(_radix__plural, multiplier, exponent, recurSpan);
		}

	}
}
