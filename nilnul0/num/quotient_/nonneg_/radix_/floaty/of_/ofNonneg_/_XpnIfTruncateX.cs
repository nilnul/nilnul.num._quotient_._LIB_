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
	/// </summary>
	static public class _XpnIfTruncateX
	{



		/// <summary>
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		static public nonneg_.radix_.Floaty _OfNonneg_0radic_1precisionNonneg(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.nonneg.vow.En proper
			, BigInteger mantissa
		)
		{
			return _OfNonneg_0radic_1nonneg_2precisionNonneg(_radix_plural, proper.en, mantissa);

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
		public static nonneg_.radix_.Floaty _OfNonneg_0radic_1nonneg_2precisionNonneg(
			BigInteger _radix_plural, Quotient1 proper, BigInteger mantissa)
		{

			return _OfNonneg_0radic_1nonneg_2precisionNonneg(_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper), mantissa
			);
		}


		public static nonneg_.radix_.Floaty _OfNonneg_0radic_1nonneg_2precisionNonneg(BigInteger _radix_plural, num.quotient_.DenomNonnilI proper, BigInteger precision)
		{


			return _CoerceX.ToFloaty(
				nonneg_.radix.of_.ofNonneg_._XpnIfTruncateX._OfNonneg_0radic_1nonneg_2precisionNonneg(
					_radix_plural, proper, precision
					)
			);





		}


	}
}
