using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;
using nilnul.num.quotient_.denomNonnil;

namespace nilnul.num.quotient_.radix.recur.of_
{
	/// <summary>
	///  get all the remainders, till a cycle formed.
	/// </summary>
	/// <remarks>recurring, cyclic, repeating, recurring...</remarks>
	static public class _OfQuotientX
	{

		static public recur_.ByNeg _AsByNeg_0radic(BigInteger _radix__plural, DenomNonnil x)
		{
			if (x < 0)
			{
				var unsigned = num.quotient_.nonneg_.radix.recur.of_._OfNonnegQuotientX._Of_0plural_1nonneg(
					_radix__plural
					,
					-x
				);

				var t = new recur_.ByNeg(
					unsigned
					,
					true
				);

				return (t);


			}




			return new recur_.ByNeg(
				num.quotient_.nonneg_.radix.recur.of_._OfNonnegQuotientX._Of_0plural_1nonneg(
					_radix__plural
					,
					x
				)
			);


		}
		static public recur_.ByNeg _AsByNeg_0radic(BigInteger _radix__plural, DenomNonnilI x)
		{
			return _AsByNeg_0radic(_radix__plural,x.ToImpl());
	}

		/// <summary>
		/// todo:
		/// </summary>
		/// <param name="_radix__plural"></param>
		/// <param name="x"></param>
		/// <returns></returns>
		static public recur_.ByNeg _AsByNeg_0radic(BigInteger _radix__plural, Quotient1 x)
		{


			if (x.numerator.Sign < 0)
			{
				var unsigned = num.quotient_.nonneg_.radix.recur.of_._OfNonnegQuotientX._Of_0plural_1nonneg(
					_radix__plural
					,
					-x
				);

				var t = new recur_.ByNeg(
					unsigned
					,
					true
				);

				return (t);


			}




			return new recur_.ByNeg(
				num.quotient_.nonneg_.radix.recur.of_._OfNonnegQuotientX._Of_0plural_1nonneg(
					_radix__plural
					,
					x
				)
			);


		}

		/// <summary>
		/// todo:
		/// </summary>
		/// <param name="_radix__plural"></param>
		/// <param name="x"></param>
		/// <returns></returns>
		static public Recur1 _AsSignificed_0radic(BigInteger _radix__plural, Quotient1 x)
		{
			return recur.to_._RegressionsX.ToRecur1AsSignificed(
				_AsByNeg_0radic(_radix__plural, x)
			);



			//const int TO_BE_FOUND = -1;

			//var mixedFrac = quotient_.FlooredX.ToFloored(x);
			///// integer and mantissa are treated differently: one is by division for remainder and gets gits one by one from right2left, the other is by mulitiplication1division for quotient, and gets gits from right2left;

			//var integerAsRadix = nilnul.num_.Radix2.Of0radic1num(_radix__plural,mixedFrac.floor)

			//BigInteger multiplier = mixedFrac.floor;//.Item1;
			//BigInteger exponent = 0;

			//List<BigInteger> remainders = new List<BigInteger>();
			//BigInteger remainder = mixedFrac.proper.en.numerator;

			//BigInteger recurPosition = TO_BE_FOUND;

			//while (recurPosition == TO_BE_FOUND)
			//{
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

			//return new Recur(_radix__plural, multiplier, exponent, remainders.Count - recurPosition);
		}


	}
}
