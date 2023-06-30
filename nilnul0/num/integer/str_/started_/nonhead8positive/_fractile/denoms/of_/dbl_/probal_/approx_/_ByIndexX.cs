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
using P = nilnul._num.bigint.be.Positive1.Asserted;
using N = nilnul._num.bigint.be.Natural.Asserted;
using System.Numerics;
using nilnul.num.rational.cf;
using nilnul.num.natural;

namespace nilnul.num.integer.str_.started_.nonhead8positive._fractile.denoms.of_.dbl_.probal_.approx_
{
	
	public class _ByIndexX
	{
		


		/// <summary>
		/// as each lower is ge index, when we designated index, we set the minimal lower
		/// </summary>
		/// <param name="_tail_0to1_"></param>
		/// <param name="numberOfDenominators"></param>
		/// <returns></returns>

		static public List<P> _ToDenoms_0prob(double _tail_0to1_, N numberOfDenominators)
		{
			var denominants = new List<P>();

			if (numberOfDenominators == 0)
			{
				return denominants;

			}
			if (_tail_0to1_ == 0)
			{
				return denominants;

			}

			numberOfDenominators--;

			var tailInverse = nilnul_obj.num.NumX.FloorAndTail(1 / _tail_0to1_);
			denominants.Add(new P(tailInverse.Item1));

			var fraction = _ToDenoms_0prob(tailInverse.Item2, numberOfDenominators);
			denominants.AddRange(fraction);

			return denominants;

		}

		public static List<P> _ToDenoms_0prob(double tail_0to1_, BigInteger val)
		{
			return _ToDenoms_0prob(
				tail_0to1_
				,
				new N(val)
			);
		}

	}
}
