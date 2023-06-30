using nilnul.num.rational.float_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_.floaty.recur_.mantissaed_.dec.of_
{
	static public class _OfQuotientX
	{
		static public floaty.recur_.Mantissaed ToCyclic(this nilnul.num.quotient_.DenomNonnil byNeg)
		{

			var neg = byNeg < 0;

			return new Mantissaed(
				quotient_.nonneg_.radix_.floaty.recur_.mantissaed_.dec.of_._OfNonnegQuotientX._ToCyclic_0nonneg(
					neg ? -byNeg : byNeg
				)
				,
				neg
			);
		}

		
	}
}
