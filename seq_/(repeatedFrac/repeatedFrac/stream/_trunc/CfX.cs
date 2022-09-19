using nilnul.num.natural;
using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Fraction2 = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;

namespace nilnul.num.quotient_.recurFrac.stream._trunc
{
	static public  class _CalcErrorInApproximationX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="aK"></param>
		/// <param name="termK_1"></param>
		/// <param name="termK_2"></param>
		/// <returns></returns>
		static public BigInteger CalcFromPreviousTwoTerms(BigInteger aK,BigInteger termK_1,BigInteger termK_2) {
			return aK * termK_1 + termK_2;
		}



	}
}
