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

namespace nilnul.num.quotient_.nonneg_.radix.of_.ofNonneg_
{
	/// <summary>
	/// given a precision, get the gits wide less than the given precision;
	/// eg:
	///		123e2 from 12345, given precision 3;
	/// </summary>
	static public class _ByIncreaseDenominatorX
	{



		/// <summary>
		///
		/// keep dividing numerator by the denominator to get the gits; As integer is the quotient already, so we now only tackle the proper part in a way different from how we treat the integers;
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		static public nonneg_.Radix _Of_0radic_2precision(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.nonneg.vow.En proper
			, BigInteger mantissa
		)
		{
			return _Of_0radic_1nonneg_2precision(_radix_plural, proper.en, mantissa);

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
		public static nonneg_.Radix _Of_0radic_1nonneg_2precision(
			BigInteger _radix_plural, Quotient1 proper, BigInteger mantissa)
		{

			return _Of_0radic_1nonneg_2precision(_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper), mantissa
			);
		}


		public static nonneg_.Radix _Of_0radic_1nonneg_2precision(
			BigInteger _radix_plural
			, num.quotient_.DenomNonnilI _nonneg
			, BigInteger precision
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

			var inMantissa = quotient_.nonneg_.radix.of_._OfProperX._OfProper_0radic_12proper_3mantissa(
				_radix_plural
				,
				numerator,denominator,precision
			); // .(285614  =285614 * 10^-6, where cycle is 6

			return 	new num.quotient_.nonneg_. Radix(
					inMantissa.precision
					,
					inMantissa.indic +indic
			)	;













		}


	}
}
