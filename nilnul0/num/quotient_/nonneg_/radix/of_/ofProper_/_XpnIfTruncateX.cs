using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;
using nilnul.num.op_.unary_;

namespace nilnul.num.quotient_.nonneg_.radix.of_.ofProper_
{
	/// <summary>
	///  get all the gits, till a mantissa limit is reached, where we throw exception.
	/// </summary>
	static public class _XpnIfTruncateX
	{



		/// <summary>
		///
		/// keep dividing numerator by the denominator to get the gits; As integer is the quotient already, so we now only tackle the proper part in a way different from how we treat the integers;
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		static public nonneg_.Radix _OfProper_0radic(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.proper.vow.En proper
			, BigInteger mantissa
		)
		{
			return _OfProper_0radic_1proper(_radix_plural, proper.en, mantissa);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_radix_plural">
		/// eg:
		///		10
		/// </param>
		/// <param name="proper">
		///	eg:
		///		2/7
		/// </param>
		/// <param name="mantissa">
		/// how much digits allowed;
		/// eg:6
		/// </param>
		/// <returns>
		/// 
		/// .285714
		/// </returns>
		/// <exception cref="NotImplementedException"></exception>
		public static nonneg_.Radix _OfProper_0radic_1proper(
			BigInteger _radix_plural, Quotient1 proper, BigInteger mantissa)
		{

			return _OfProper_0radic_1proper_nonneg2mantissa(_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper), mantissa
			);
		}

		public static nonneg_.Radix _OfProper_0radic_12proper_nonneg3mantissa(
			BigInteger _radix_plural
			, BigInteger numerator
			, BigInteger denominator
			, BigInteger mantissa
		)
		{
			List<BigInteger> gitsAftDot = new List<BigInteger>() { };
			BigInteger indic = 0;

			var remainder = numerator;
			BigInteger quotient = 0;

			while (remainder != 0)
			{
				if (mantissa == 0)
				{
					throw new quotient_._radix.xpn_.OverlongException($"{numerator}/{denominator} cannot be converted to a pointed floaty based {_radix_plural} within {mantissa} digits after dot;");
				}
				mantissa--;

				///remove leading 0s as in 0.000354000? We shall leave it to later shrink, in order to keep this procedure simple;
				///

				quotient = BigInteger.DivRem(
						remainder * _radix_plural
						,
						denominator
						,
						out remainder
				);  ///   20%7 =2 ... 6
					/// 1/11 => 10/11 =0...1
					/// //eg: 2/5 --> 20/5 = 4...0
					/// //eg: 0/5 --> 0/5 =0 ... 0

				indic--;//this offsets the effect of multiplier*_radix
				gitsAftDot.Add(quotient);
			}
			gitsAftDot.Reverse();

			return Radix.Of_0radic_1gits_2indic(
				_radix_plural
				, gitsAftDot
				, indic
			);
		}

		public static nonneg_.Radix _OfProper_0radic_1proper_nonneg2mantissa(BigInteger _radix_plural, num.quotient_.DenomNonnilI proper, BigInteger mantissa)
		{
			return _OfProper_0radic_12proper_nonneg3mantissa(
				_radix_plural
				,
				proper.numerator
				,
				proper.denominator
				,
				mantissa
			);
		}
	}
}
