using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_.floaty.of_.coerce_
{
	static public class _OfRadixX
	{
		static public Floaty ToFloaty(this radix_.ByNeg byNeg) {
			return new Floaty(
				quotient_.nonneg_.radix_.floaty.of_._CoerceX.ToFloaty(byNeg.unsigned)
				,
				byNeg.negated
			);
		}
		static public Floaty ToFloaty(this Radix8unsignedI byNeg) {
			return new Floaty(
				quotient_.nonneg_.radix_.floaty.of_._CoerceX.ToFloaty(byNeg.unsigned)
				,
				byNeg.negated
			);
		}

		static public Floaty ToFloaty(this Radix3 byNeg) {
			return new Floaty(
				quotient_.nonneg_.radix_.floaty.of_._CoerceX.ToFloaty(byNeg.unsigned)
				,
				byNeg.negated
			);
		}

	}
}
