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

namespace nilnul.num.quotient_.radix.of_.ofQuotient_
{
	/// <summary>
	/// </summary>
	static public class _MantissalyX
	{



		public static num.quotient_.radix_.ByNeg  _Of_0radic_2mantissa(BigInteger _radix_plural, num.quotient_.DenomNonnil proper, BigInteger mantissa)
		{
			if ( proper < 0)
			{
				return  radix_.ByNeg.OfAsNeg(  nonneg_.radix.of_.ofNonneg_._MantissaLeGivenX._Of_0radic_1nonneg_2mantissa(
					_radix_plural
					,
					nilnul.num.quotient.of_.unary_.Neg.Singleton.op(proper)
					,
					mantissa
				));
			}

			return new radix_.ByNeg( nonneg_.radix.of_.ofNonneg_._MantissaLeGivenX._Of_0radic_1nonneg_2mantissa(
				_radix_plural
				,
				(proper)
				,
				mantissa
			));



		}

		public static radix_.ByNeg _Of_0radic_2mantissa(BigInteger _radix_plural, num.quotient_.DenomNonnilI proper, BigInteger mantissa)
		{
			

			return _Of_0radic_2mantissa(_radix_plural, proper.ToImpl(), mantissa);



		}


		public static num.quotient_.radix_.ByNeg _Of_0radic_2mantissa(
			BigInteger _radix_plural, Quotient1 proper, BigInteger mantissa)
		{

			return _Of_0radic_2mantissa(_radix_plural,
				(DenomNonnilI)quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper), mantissa
			);
		}


	}
}
