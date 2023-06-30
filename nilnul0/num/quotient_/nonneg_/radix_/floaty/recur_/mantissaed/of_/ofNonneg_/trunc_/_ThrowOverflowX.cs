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

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur_.mantissaed.of_.ofNonneg_.trunc_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ThrowOverflowX
	{



		/// <summary>
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <param name="precisionAftDot">mantissa</param>
		/// <returns></returns>
		/// 
		static public Mantissaed _Of_0plural_2nonneg(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.nonneg.vow.En proper
			,
			BigInteger precisionAftDot

		)
		{
			return _Of_0plural_1nonneg_2nonneg(_radix_plural, proper.en, precisionAftDot);

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
		public static Mantissaed _Of_0plural_1nonneg_2nonneg(
			BigInteger _radix_plural
			,
			Quotient1 proper
			,
			BigInteger precisionAftDot

			)
		{

			return _Of_0plural_1nonneg_2nonneg(
				_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper)
				,
				precisionAftDot
			);
		}


		public static Mantissaed _Of_0plural_1nonneg_2nonneg(
			BigInteger _radix_plural
			,
			num.quotient_.DenomNonnilI _nonneg
			,
			BigInteger precision
		)
		{


			var numerator = _nonneg.numerator;
			var denominator = _nonneg.denominator.eeByRef;
			var indic = 0;

			while (numerator >= denominator)
			{
				denominator *= _radix_plural;
				indic++; // for the eg, 7 as in 10^7
			}

			var properRadix = quotient_.nonneg_.radix_.floaty.recur.of_.ofProper_.trunc_._ThrowX._Of_0radic_12proper_3nonneg(
				_radix_plural
				,
				numerator
				, denominator
				,
				precision
			);




			return new Mantissaed(
					properRadix.radix.precision
					,
					properRadix.indic + indic

				,
				properRadix.period
			);






		}


	}
}
