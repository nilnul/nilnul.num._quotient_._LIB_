﻿using nilnul.num.quotient._radix;
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

namespace nilnul.num.quotient_.radix_.floaty.recur_.mantissaed_.dec.of_.ofQuotient_.trunc_.mantissaly_
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
		static public Mantissaed _Of_1mantissa(
			nilnul.num.quotient.be_.nonneg.vow.En proper
			,
			BigInteger precisionAftDot

		)
		{
			return _Of_1mantissa( proper.en, precisionAftDot);

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
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper)
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
				quotient_.nonneg_.radix_.floaty.recur_.mantissaed_.dec.of_.ofNonneg_.trunc_.mantissaly_._ThrowOverflowX._Of_0nonneg_1mantissa(
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