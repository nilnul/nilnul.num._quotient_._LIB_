using System.Numerics;

namespace nilnul.num.quotient_.nonneg_.radix
{
	static public class _ToX
	{
		static public (BigInteger amplific, BigInteger radic, BigInteger indic) ToAmplified(quotient_.nonneg_.RadixI byNeg)
		{
			return (
				byNeg.precision.toBigint()
				,
				byNeg.precision.radic
				,
				byNeg.indic
			);
		}
	}
}
