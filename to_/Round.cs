using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.to_
{

	public class Round
	{
		static public BigInteger Eval(Q1 q) {
			var mixedFrac = (MixedFrac)q;
			if (mixedFrac.proper.val< Q1.CreateHalf())
			{
				return mixedFrac.floor;
			}
			return mixedFrac.floor + 1;
		}
	}
}
