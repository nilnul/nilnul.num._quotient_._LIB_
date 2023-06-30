using nilnul.num.rational.float_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_.floaty.recur_.mantissaed.of_.coerce_
{
	static public class _OfRecurX
	{
		static public floaty.recur_.Mantissaed ToMantissaed(this radix_.floaty.Recur byNeg) {
			return new Mantissaed(
				quotient_.nonneg_.radix_.floaty.recur_.mantissaed.of_.coerce_._OfRecurX.Of(byNeg.unsignedFloatyRecur)
				,
				byNeg.negated
			);
		}

		public  static floaty.recur_.Mantissaed ToMantissaed(Periodic periodic)
		{
			return ToMantissaed(
				radix_.floaty.recur.of_.coerce_._OfRecurX.AsFloatyRecur(periodic)
			);

		}

		public static floaty.recur_.Mantissaed ToMantissaed(radix.Recur periodic1111)
		{
			return ToMantissaed(
				radix_.floaty.recur.of_.coerce_._OfRecurX.AsFloatyRecur(periodic1111)
			);
		}
	}
}
