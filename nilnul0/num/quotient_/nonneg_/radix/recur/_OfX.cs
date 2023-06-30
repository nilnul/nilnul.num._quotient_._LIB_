using nilnul.num.quotient_.radix_;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.num.quotient_.nonneg_.radix.recur
{
	static public class _OfX
	{

		public static Recur _PrependNecessaryNils_1nonneg(RadixI radix, BigInteger period)
		{
			var needed = period - radix.precision.gits.Count();
			if (needed > 0)
			{
				return new Recur(
					num_.radix.of_.unary_._PrependNilsX.__PrependNils_1nonneg(radix.precision, needed)
					,
					radix.indic
					,
					period
				);
			}
			return new Recur(radix, period);
		}

		static public Recur _PrependNecessaryNils_1nonneg(Radix radix, BigInteger period)
		{
			
			return _PrependNecessaryNils_1nonneg((RadixI)radix,period);
		}
		static public Recur PrependNecessaryNils(RadixI radix, Num_ofIn period)
		{
			
			return _PrependNecessaryNils_1nonneg(radix,period.eeByRef);
		}
	}
}
