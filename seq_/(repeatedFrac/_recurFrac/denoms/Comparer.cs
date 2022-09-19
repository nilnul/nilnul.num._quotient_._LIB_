using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fraction2 = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;
using Fraction = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;
using Positive = nilnul.num.natural.PositiveNatural_inheritNatural;

using Frac = nilnul.num._quotient.Fraction1;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Positive1 = nilnul._num.bigint.be.Positive1.Asserted;
using N = nilnul._num.bigint.be.Natural.Asserted;
using nilnul.num.quotient._continuedFrac.simpleProper_;

namespace nilnul.num.quotient._continuedFrac.simpleProper
{
	/// <summary>
	/// </summary>

	/// <remarks>
	/// 
	/// </remarks>
	public class Comparer
		
	{



		static public int Compare(simpleProper_.ForIrrational a, simpleProper_.ForIrrational b)
		{


			if (a.denominators.Count() < b.denominators.Count())
			{
				return _compareDenominatorsLongToShort(b.denominators, a.denominators);

			}
			return _compareDenominatorsLongToShort(a.denominators, b.denominators);



		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		/// <remarks>a must be no shortr than b</remarks>
		static private int _compareDenominatorsLongToShort(IEnumerable<Positive1> a, IEnumerable<Positive1> b)
		{
			if (a.Count() == 0)
			{
				return 0;

			}

			if (b.Count() == 0)
			{
				return 1;

			}

			if (a.First() > b.First())
			{
				return -1;

			}

			if (a.First() < b.First())
			{
				return 1;

			}
			return _compareDenominatorsLongToShort(a.Skip(1), b.Skip(1));


		}


	}
}
