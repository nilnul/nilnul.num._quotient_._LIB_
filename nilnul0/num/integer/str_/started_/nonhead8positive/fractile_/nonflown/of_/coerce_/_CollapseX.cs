using nilnul.num.integer.str_.started_.nonhead8positive._fractile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile_.nonflown.of_.coerce_
{
	static public class _CollapseX
	{
		static public (BigInteger floor, IEnumerable<BigInteger> denoms) Collapse(
			BigInteger floor, IEnumerable<BigInteger> adders
		)
		{
			var count = adders.Count();
			switch (count)
			{
				case 0:
					return (floor, adders);
				case 1:
					if (adders.Last() == 1)
					{
						return (floor+1, new BigInteger[0]);
					}

					return (floor, adders);
				default:
					if (adders.Last() == 1)
					{
						return (floor, adders.Take(count-2).Append(adders.ElementAt(count-2) +1) );
					}
					return (floor, adders);
					break;
			}
		}

		public static (BigInteger floor, IEnumerable<BigInteger> denoms) Collapse(Fractile fractile)
		{
			return Collapse(
				fractile.ground
				,
				fractile.probal
			);
		}

		public static (BigInteger floor, IEnumerable<BigInteger> denoms) Collapse(BigInteger floor, Denoms proper)
		{
			return Collapse(
				floor
				,
				proper.denominators
			);

		}

		public static (BigInteger floor, IEnumerable<BigInteger> denoms) Collapse(BigInteger floor, IEnumerable<num_.Positive1> denominators)
		{
			return Collapse(
				floor
				,
				denominators.Select(x=>x.en)
			);


		}

		/// <summary>
		/// </summary>
		/// <param name="adders"></param>
		/// <returns></returns>
		/// inversed infinity based positioning system ?
		static public IEnumerable<BigInteger> _Collapse_0started(
			 IEnumerable<BigInteger> adders
		)
		{
			var count = adders.Count();
			switch (count)
			{
				case 1:
					return adders;
				case 2:
					if (adders.Last() == 1)
					{
						return new[] { adders.First() + 1 };
					}

					return adders;
				default:
					if (adders.Last() == 1)
					{
						return adders.Take(count-2).Append(adders.ElementAt(count-2) +1);
					}
					return adders;
					break;
			}
		}


	}
}
