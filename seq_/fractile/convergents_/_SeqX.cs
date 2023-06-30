using nilnul.num.quotient_;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.num.quotient.seq_.fractile.convergents_
{
	static public class _SeqX
	{

		/// <summary>
		/// the value of the fractile, which is the end of the searies;
		/// </summary>
		/// <param name="adders"></param>
		/// <returns></returns>
		static public IEnumerable< DenomNonnil> _Seq_0fractile(IEnumerable<BigInteger> adders)
		{

			//var addersCount = adders.Count();

			//if (addersCount == 1)
			//{
			//	return new DenomNonnil(adders.First());
			//}

			var dividends = new _convergent._Dividends(adders).GetEnumerator();

			var divisors = new _convergent._Divisors(adders).GetEnumerator();

			while (divisors.MoveNext())
			{
				dividends.MoveNext();
				yield return new DenomNonnil( dividends.Current ,divisors.Current);  
			}



		}

		public static IEnumerable<DenomNonnil> _Seq_0fractile(IEnumerable<int> x)
		{
			return _Seq_0fractile(
				x.Select(t => (BigInteger)t)
			);
		}
	}
}
