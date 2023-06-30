using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;
using nilnul.num.quotient_.nonneg_.radix_.floaty.recur_;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur.of_.ofProper_
{
	static public class _TruncateX
	{



		/// <summary>
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		static public Mantissaed _Of_0radic_2nonneg(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.proper.vow.En proper
			,BigInteger lengthLimit
		)
		{
			return _Of_0radic_1proper_2nonneg(_radix_plural, proper.en,lengthLimit);

		}

		
		public static Mantissaed _Of_0radic_1proper_2nonneg(BigInteger _radix_plural, Quotient1 proper
			,BigInteger lengthLimit)
		{
			
			return _Of_0radic_1proper_2nonneg(
				_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper),lengthLimit
			);
		}
		public static Mantissaed _Of_0radic_1proper_2nonneg(
			BigInteger _radix_plural
			, DenomNonnilI proper
			,
			BigInteger lengthLimit
		)
		{
			return _Of_0radic_12proper_3nonneg(
				_radix_plural
				,
				proper.numerator
				,
				proper.denominator
				,
				lengthLimit
			);
		}
		public static Mantissaed _Of_0radic_12proper_3nonneg(
			BigInteger _radix_plural
			, BigInteger numerator
			,
			BigInteger denominator
			,
			BigInteger lengthLimit
		)
		{
			return nilnul.num.quotient_.nonneg_.radix_.floaty.recur_.mantissaed.of_.ofProper_._TruncateX._Of_0radic_12proper_3nonneg(
				_radix_plural
				,
				numerator
				,
				denominator
				,
				lengthLimit
			);

	
		}

	}
}
