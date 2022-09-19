using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.co_.startGtOne_.stopGtOne
{
	/// <summary>
	/// get an integer bound, the diamter of which is le 1
	/// </summary>
	static public class _LogX
	{
		/// <summary>
		/// find the minimum bound that contains the log of (sub, target)
		/// </summary>
		/// <param name="sub">the base of the logarithm</param>
		/// <param name="target">the result of base^exponent</param>
		/// <returns>a singleton or an open bound of length 1</returns>
		static public nilnul.num._bound.LowerUpper Bound(nilnul.num.quotient_.GtOne sub, num.quotient_.GtOne target) {
			BigInteger lowerBound = 0;

			///find upperBound

			BigInteger vanguard = 1;    /// the bound is a guard

			var vanguardOped = sub; //num.quotient.op_.unary_.Poly.Eval(sub, vanguard);

			while (vanguardOped<target)
			{
				lowerBound = vanguard;
				vanguard<<=1;
				vanguardOped *= vanguardOped;
			}

			if (vanguardOped == target)
			{
				return nilnul.num._bound.LowerUpper.CreateSingle(vanguard);
			}

			BigInteger midFloor = nilnul.num.integer.co.band_._MidX.MidFloor(lowerBound , vanguard);

			while (lowerBound!=midFloor)
			{
				var midOped = num.quotient.op_.unary_.Poly.Eval(sub, midFloor);
				if (midOped==target)
				{
					return nilnul.num._bound.LowerUpper.CreateSingle(vanguard);
				}
				if (midOped >target)
				{
					vanguard = midFloor;
				}
				else
				{
					lowerBound = midFloor;
				}
				midFloor = nilnul.num.integer.co.band_._MidX.MidFloor(lowerBound, vanguard);

			}

			return nilnul.num._bound.LowerUpper.CreateOpen(lowerBound, vanguard);


		}
	}
}
