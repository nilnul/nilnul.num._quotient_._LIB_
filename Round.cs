using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num.Quotient1;


namespace nilnul.num.quotient
{

	static public class _RoundX
	{
		static public BigInteger Round(Q1 q) {
			var mixedFrac = (quotient_.Floored)q;
			if (mixedFrac.proper.en< Q1.CreateHalf())
			{
				return mixedFrac.floor;
			}
			return mixedFrac.floor + 1;
		}
		//static public BigInteger Round_assumeNonneg(this Q1 q) {
		//	var mixedFrac = (quotient_.Floored)q;
		//	if (mixedFrac.proper.en< Q1.CreateHalf())
		//	{
		//		return mixedFrac.floor;
		//	}
		//	return mixedFrac.floor + 1;
		//}


	}
}
