using nilnul.num.quotient_.radix_;
using System;
using System.Numerics;

namespace nilnul.num.quotient_.radix.recur
{
	static public class _OfX
	{
		static public recur_.ByNeg _PrependNecessaryNils_0nonneg(Radix8unsignedI radix, BigInteger period)
		{
			return new recur_.ByNeg(
				quotient_.nonneg_.radix.recur._OfX._PrependNecessaryNils_1nonneg(
					radix.unsigned,
					period
				)
				
				,
				radix.negated
			);
		}
		static public recur_.ByNeg PrependNecessaryNils(Radix8unsignedI radix, Num_ofIn period)
		{
			return _PrependNecessaryNils_0nonneg(radix,period.eeByRef);
		}

		static public recur_.ByNeg _PrependNecessaryNils_0nonneg(ByNeg radix, BigInteger period)
		{
			return new recur_.ByNeg(
				quotient_.nonneg_.radix.recur._OfX._PrependNecessaryNils_1nonneg(
					radix.unsigned,
					period
				)
				
				,
				radix.negated
			);
		}


	}
}
