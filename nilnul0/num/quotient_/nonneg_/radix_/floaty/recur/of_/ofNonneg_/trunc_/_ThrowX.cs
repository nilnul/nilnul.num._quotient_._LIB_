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

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur.of_.ofNonneg_.trunc_
{
	/// <summary>
	/// the precision shall not exceed given width;
	/// </summary>
	/// 
	 
	static public class _ThrowX
	{



		/// <summary>
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		static public Recur _Of_0plural_2nonneg(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.nonneg.vow.En proper
			,
			BigInteger precision
		)
		{
			return _Of_0plural_1nonneg_2nonneg(_radix_plural, proper.en
				,precision
				);

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
		public static Recur _Of_0plural_1nonneg_2nonneg(
			BigInteger _radix_plural, Quotient1 proper
			,
			BigInteger precision

			)
		{

			return _Of_0plural_1nonneg_2nonneg(
				_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper)
				,
				precision
			);
		}


		public static Recur _Of_0plural_1nonneg_2nonneg(
			BigInteger _radix_plural
			,
			num.quotient_.DenomNonnilI _nonneg
			,
			BigInteger precision

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

			var inMantissa = quotient_.nonneg_.radix_.floaty.recur.of_.ofProper_.trunc_._ThrowX._Of_0radic_12proper_3nonneg(
				_radix_plural
				,
				numerator
				,denominator
				,
				precision
			); 

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