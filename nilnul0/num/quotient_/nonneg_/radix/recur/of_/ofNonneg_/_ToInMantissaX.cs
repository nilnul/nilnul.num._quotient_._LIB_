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

namespace nilnul.num.quotient_.nonneg_.radix.recur.of_.ofNonneg_
{
	/// <summary>
	/// </summary>
	static public class _ToInMantissaX
	{



		/// <summary>
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		static public RecurI _Of_0plural(
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
		public static RecurI _Of_0plural_1nonneg(
			BigInteger _radix_plural, Quotient1 proper)
		{

			return _Of_0plural_1nonneg(
				_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper)
			);
		}


		public static RecurI _Of_0plural_1nonneg(
			BigInteger _radix_plural, num.quotient_.DenomNonnilI _nonneg)
		{

			return quotient_.nonneg_.radix_.floaty.recur_.mantissaed.of_._OfNonnegQuotientX._Of_0plural_1nonneg(_radix_plural,_nonneg);





		}


	}
}
