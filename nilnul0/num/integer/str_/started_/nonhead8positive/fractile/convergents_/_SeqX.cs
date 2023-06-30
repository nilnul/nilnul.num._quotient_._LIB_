using nilnul.num.quotient_;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile.convergents_
{
	static public class _SeqX
	{

		/// <summary>
		/// the value of the fractile, which is the end of the searies;
		/// </summary>
		/// <param name="adders"></param>
		/// <returns></returns>
		static public DenomNonnil _Last_0fractile(IEnumerable<BigInteger> adders)
		{

			//var addersCount = adders.Count();

			//if (addersCount == 1)
			//{
			//	return new DenomNonnil(adders.First());
			//}

			var uppers = new _convergent._Dividends(adders);


			var lowers = new _convergent._Divisors(adders);

			return new DenomNonnil(uppers.Last(), lowers.Last());  

		}

		public static DenomNonnil _Last_0fractile(IEnumerable<int> x)
		{
			return _Last_0fractile(
				x.Select(t => (BigInteger)t)
			);
		}
	}
}
