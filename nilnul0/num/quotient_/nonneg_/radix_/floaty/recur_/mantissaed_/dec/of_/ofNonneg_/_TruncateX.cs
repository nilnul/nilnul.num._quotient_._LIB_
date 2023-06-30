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

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur_.mantissaed_.dec.of_.ofNonneg_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _TruncateX
	{



		/// <summary>
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <param name="precisionAftDot">mantissa</param>
		/// <returns></returns>
		/// 
		static public Mantissaed _Of_1precision(
			
			nilnul.num.quotient.be_.nonneg.vow.En proper
			,
			BigInteger precisionAftDot

		)
		{
			return _Of_0nonneg_1precision( proper.en, precisionAftDot);

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
		public static Mantissaed _Of_0nonneg_1precision(
			
			Quotient1 proper
			,
			BigInteger precisionAftDot

			)
		{

			return _Of_0nonneg_1precision(
				
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper)
				,
				precisionAftDot
			);
		}


		public static Mantissaed _Of_0nonneg_1precision(
			
			num.quotient_.DenomNonnilI _nonneg
			,
			BigInteger precisionAftDot
		)
		{
			return mantissaed.of_.ofNonneg_._TruncateX._Of_0plural_1nonneg_2nonneg(
				10
				,
				_nonneg
				,
				precisionAftDot
			);
		}
	}
}