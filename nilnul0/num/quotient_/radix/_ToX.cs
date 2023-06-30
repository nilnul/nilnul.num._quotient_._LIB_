using System;
using System.Numerics;

namespace nilnul.num.quotient_.radix
{
	static public class _ToX
	{
		static public (BigInteger signific, BigInteger radic, BigInteger indic) ToSignified(this Radix8unsignedI byNeg) {
			var t = quotient_.nonneg_.radix._ToX.ToAmplified(byNeg.unsigned);

			return (
				byNeg.negated?
				-t.amplific:t.amplific

				,t.radic,t.indic);
		}

		static public (BigInteger signific, BigInteger radic, BigInteger indic) ToSignified(this radix_.ByNeg byNeg) {
			var t = quotient_.nonneg_.radix._ToX.ToAmplified(byNeg.unsigned);

			return (
				byNeg.negated?
				-t.amplific:t.amplific

				,t.radic,t.indic);
		}

		public static (BigInteger signific, BigInteger radic, BigInteger indic) ToSignified(Radix3 radix)
		{
			return ToSignified(
				(Radix8unsignedI)(radix)
			);
		}
	}


}
