using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile_.nonneg.of_.ofQuotient_
{
	static public  class _ByEuclidAlgorithmX
	{

		/// <summary>
		/// eg: 43/19 =
		///		2
		///		----------
		///		3+	1
		///			-----------
		///			1+		1
		///					-----------
		///					4
		/// </summary>
		/// <remarks>
		/// b is intially in general not nil;
		/// 
		/// if b is initally 0, this returns empty with no thrown excpetion; This is generally useless, not meaningful. here we don't assume b is positive, but when in use, we consider it's meaningful whether|if|when it's nil;
		/// </remarks>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public IEnumerable<BigInteger> _AsAdders_01nonneg(BigInteger a, BigInteger b) {
			while (b!=0)
			{
				///eg: 43/19 = 2..5
				yield return BigInteger.DivRem(a,b, out BigInteger  r); 
				a = b; // 19, 
				b = r; // 5
			}
		}
	}
}
