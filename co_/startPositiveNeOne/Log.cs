using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.co_.startPositiveNeOne
{
	/// <summary>
	/// </summary>
	static public class _LogX
	{

		static public nilnul.num.integer._bound.LowerUpper Bound(
			nilnul.num.quotient_.positive_.NeOne sub,
			num.quotient_.Positive1 target
			)
		{

			if (sub <1)
			{
				return startPositiveLtOne._LogX.Bound(new quotient_.positive_.LtOne(sub),target);
			}
			return startGtOne._LogX.Bound(new quotient_.GtOne(sub),target);
		
		}
		static public nilnul.num.integer._bound.LowerUpper Bound(
			nilnul.num.Quotient1 sub,
			num.Quotient1 target
			)
		{
			return Bound(
				new quotient_.positive_.NeOne(sub)
				,
				new quotient_.Positive1(target)
			);
		}


	}
}
