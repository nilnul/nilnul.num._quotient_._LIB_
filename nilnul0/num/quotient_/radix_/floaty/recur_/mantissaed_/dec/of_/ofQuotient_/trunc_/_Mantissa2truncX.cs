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
using nilnul.num.quotient_.denomNonnil;

namespace nilnul.num.quotient_.radix_.floaty.recur_.mantissaed_.dec.of_.ofQuotient_.trunc_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		mantissa2trunc
	///			abbreviatable to mantissa, which is more explicit when used in namespace
	///		aftDot
	///			not a single word;
	static public class _Mantissa2truncX
	{



		/// <summary>
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <param name="precisionAftDot">mantissa</param>
		/// <returns></returns>
		/// 
		static public Mantissaed _Of_1mantissa(
			
			nilnul.num.quotient.be_.nonneg.vow.En proper
			,
			BigInteger precisionAftDot

		)
		{
			return _Of_1mantissa(
				proper.en, precisionAftDot
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
		public static Mantissaed _Of_1mantissa(
			
			Quotient1 proper
			,
			BigInteger precisionAftDot

			)
		{

			return _Of_1mantissa(
				
				(DenomNonnilI)quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper)
				,
				precisionAftDot
			);
		}


		public static Mantissaed _Of_1mantissa(

			num.quotient_.DenomNonnilI byNeg
			,
			BigInteger precisionAftDot
		)
		{

			return _Of_1mantissa(byNeg.ToImpl(), precisionAftDot);

		}

		public static Mantissaed _Of_1mantissa(

			num.quotient_.DenomNonnil quotient
			,
			BigInteger precisionAftDot
		)
		{

			var neg = quotient < 0;

			return new Mantissaed(
				quotient_.nonneg_.radix_.floaty.recur_.mantissaed_.dec.of_.ofNonneg_.trunc_._Mantissa2truncX._Of_0nonneg_1mantissa(
					neg ? -quotient : quotient
					,
					precisionAftDot
				)
				,
				neg
			);

		}



	}
}
