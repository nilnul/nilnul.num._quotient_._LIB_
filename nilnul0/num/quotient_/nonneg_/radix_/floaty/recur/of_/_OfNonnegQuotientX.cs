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

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur.of_
{
	/// <summary>
	/// theoretically by multiplying radic with denominator till it's a <see cref="quotient_.nonneg_.ILtOne"/> to be processed <see cref="nonneg_.radix.recur_.inMantissa.of_._OfProperX"/>;
	/// </summary>
	/// 
	 
	static public class _OfNonnegQuotientX
	{

	//////////////problematic:
	/// practically, first convert the integer part into radix, and then get the radix of the proper part, then feed all the gits into the recurrence finding algorithm like that in <see cref="recur_.inMantissa.of_._OfProperX"/>;


		/// <summary>
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		static public Recur _Of_0plural(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.nonneg.vow.En proper
		)
		{
			return _Of_0plural_1nonneg(_radix_plural, proper.en);

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
		/// <returns>
		/// 
		/// .(285714
		/// </returns>
		/// <exception cref="NotImplementedException"></exception>
		public static Recur _Of_0plural_1nonneg(
			BigInteger _radix_plural, Quotient1 proper)
		{

			return _Of_0plural_1nonneg(
				_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper)
			);
		}


		public static Recur _Of_0plural_1nonneg(
			BigInteger _radix_plural,
			num.quotient_.DenomNonnilI _nonneg
		)
		{
			/// 20000000/7 = 285614 2.85614
			/// = 2856142+6/7
			/// = (285614  * 10 ^1

			var numerator = _nonneg.numerator;
			var denominator = _nonneg.denominator.eeByRef;
			var indic = 0;

			while (numerator>=denominator)
			{
				denominator *= _radix_plural;
				indic ++; // for the eg, 7 as in 10^7
			}

			var inMantissa = quotient_.nonneg_.radix_.floaty.recur.of_._OfProperX._Of_0radic_12proper(
				_radix_plural
				,
				numerator,denominator
			); // .(285614  =285614 * 10^-6, where cycle is 6

			return new Recur(
				new num.quotient_.nonneg_. Radix(
					inMantissa.radix.precision
					,
					inMantissa.radix.indic +indic
				)
				,
				inMantissa.period
			);
		}
	}
}