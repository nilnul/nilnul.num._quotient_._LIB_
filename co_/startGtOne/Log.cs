using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.co_.startGtOne
{
	/// <summary>
		/// find the minimum bound that contains the log of (sub, target)
	/// get an integer bound, the diamter of which is le 1
	/// </summary>
	static public class _LogX
	{
		/// <summary>
		/// find the minimum bound that contains the log of (sub, target)
		/// </summary>
		/// <param name="sub">the base of the logarithm</param>
		/// <param name="target">the result of base^exponent</param>
		/// <returns>a singleton, or an open bound of length 1</returns>
		static public nilnul.num.integer._bound.LowerUpper Bound(nilnul.num.quotient_.GtOne sub, num.quotient_.positive_.LtOne target)
		{
			return nilnul.num.integer._bound.lowerUpper.convert_._NegX.Neg(
				startGtOne_.stopGtOne._LogX.Bound(
					sub, target.toInverse()
				)
			);
		}

		static public nilnul.num.integer._bound.LowerUpper Bound(
			nilnul.num.quotient_.GtOne sub,
			num.quotient_.Positive1 target
			)
		{
			if (target==1)
			{
				return integer._bound.LowerUpper.CreateSingle(1);
			};
			if (target > 1)
			{
				return new integer._bound.LowerUpper(
					startGtOne_.stopGtOne._LogX.Bound(
						sub, new quotient_.GtOne(target)
					)
					);
			}
			return Bound(sub, new quotient_.positive_.LtOne( target));
		}

	}
}
