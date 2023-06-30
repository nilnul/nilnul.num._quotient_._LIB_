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
	static public class _Throw8truncX
	{





		public static radix_.ByNeg _Of_0radicPlural_2precisionNonneg(BigInteger _radix_plural, num.quotient_.DenomNonnil proper, BigInteger mantissa)
		{
			var neg = proper < 0;

			return new radix_.ByNeg(
				nonneg_.radix.of_.ofNonneg_._XpnIfTruncateX._OfNonneg_0radic_1nonneg_2precisionNonneg(
					_radix_plural
					,
					neg ? -proper : proper
					,
					mantissa
				), neg
			);



		}

		public static radix_.ByNeg _Of_0radicPlural_2precisionNonneg(BigInteger _radix_plural, num.quotient_.DenomNonnilI proper, BigInteger mantissa)
		{
			return _Of_0radicPlural_2precisionNonneg(
				_radix_plural
				,
				proper.ToImpl()
				,
				mantissa
			);


		}
		public static radix_.ByNeg _Of_0radicPlural_2precisionNonneg(
			BigInteger _radix_plural, Quotient1 proper, BigInteger mantissa)
		{

			return _Of_0radicPlural_2precisionNonneg(_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper), mantissa
			);
		}

	}
}
