using nilnul.num.rational.float_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_.floaty.recur_.mantissaed.of_
{
	static public class _OfQuotientX
	{
		static public floaty.recur_.Mantissaed _ToCyclic_1radic(this nilnul.num.quotient_.DenomNonnil byNeg,BigInteger radic)
		{

			var neg = byNeg < 0;

			return new Mantissaed(
				quotient_.nonneg_.radix_.floaty.recur_.mantissaed.of_._OfNonnegQuotientX._Of_0radic_1nonneg(
					radic
					,
					neg ? -byNeg : byNeg

				)
				,
				neg
			);
		}

		
	}
}
