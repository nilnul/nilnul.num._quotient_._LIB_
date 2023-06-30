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

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.of_.ofNonneg_
{
	/// <summary>
	/// no xpn is thrown;
	/// </summary>
	static public class _MantissaLeGivenX
	{



		/// <summary>
		///
		/// keep dividing numerator by the denominator to get the gits; As integer is the quotient already, so we now only tackle the proper part in a way different from how we treat the integers;
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		static public nonneg_.radix_.Floaty _Of_0radic_2mantissa(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.nonneg.vow.En nonneg
			, BigInteger mantissa
		)
		{
			return _Of_0radic_1nonneg_2mantissa(_radix_plural, nonneg.en, mantissa);

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
		public static nonneg_.radix_.Floaty _Of_0radic_1nonneg_2mantissa(
			BigInteger _radix_plural, Quotient1 proper, BigInteger mantissa)
		{

			return _Of_0radic_1nonneg_2mantissa(_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper), mantissa
			);
		}


		public static nonneg_.radix_.Floaty _Of_0radic_1nonneg_2mantissa(BigInteger _radix_plural, num.quotient_.DenomNonnilI proper, BigInteger mantissa)
		{
			return _CoerceX.ToFloaty(
				nonneg_.radix.of_.ofNonneg_._MantissaLeGivenX._Of_0radic_1nonneg_2mantissa(
					_radix_plural, proper, mantissa
					)
			);






		}


	}
}
