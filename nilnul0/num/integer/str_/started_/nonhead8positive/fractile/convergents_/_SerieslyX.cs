using nilnul.num.quotient_;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile.convergents_
{
	static public class _SerieslyX
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


			var series = new _seriesly.terms.Series(adders);

			return series.Last(); 

		}

		public static DenomNonnil _Last_0fractile(IEnumerable<int> x)
		{
			return _Last_0fractile(
				x.Select(t => (BigInteger)t)
			);
		}
	}
}
