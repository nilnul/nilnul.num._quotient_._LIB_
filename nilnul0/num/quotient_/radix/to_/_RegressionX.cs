using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.to_
{
	/// <summary>
	/// </summary>
	static public class _RegressionX

	{
		
		public static Radix3 ToRadix3(this quotient_.radix_.ByNeg radix)
		{
			return Radix3.Of((RadixI)radix);
		
		}

		public static Radix3 ToRadix3(nonneg_.RadixI radix, bool negated)
		{
			return ToRadix3(
				new radix_.ByNeg(radix,negated)
			);
		}
	}
}
