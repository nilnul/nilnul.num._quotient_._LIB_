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

namespace nilnul.num.integer.str_.started_.nonhead8positive._fractile.denoms.of_.dbl_.probal_.approx_
{

	public class _ByLowerX
	{


		/// <summary>
		/// convert to SimpleProper with the err lt  (1/ give number).
		/// </summary>
		/// <param name="_tail_0to1_"></param>
		/// <param name="denominatorLowerbound_positive"></param>
		/// <returns></returns>
		static public List<P> _ToDenoms_0prob_1positive(double _tail_0to1_, BigInteger denominatorLowerbound_positive)
		{
			var denominants = new List<P>();

			if (_tail_0to1_ <= 0)
			{
				return denominants;
			}


			var tailInverse = nilnul_obj.num.NumX.FloorAndTail(1 / _tail_0to1_);
			denominants.Add(new P(tailInverse.Item1));
			if (tailInverse.Item2 <= 0)
			{
				return denominants;
			}

			BigInteger denominatorK_1 = 1;
			BigInteger denominatorK_2 = 0;
			BigInteger denominatorK = denominatorK_2 + tailInverse.Item1 * denominatorK_1;

			while (denominatorK < denominatorLowerbound_positive)
			{
				if (tailInverse.Item2 <= 0)
				{
					return denominants;
				}
				tailInverse = nilnul_obj.num.NumX.FloorAndTail(1 / tailInverse.Item2);
				denominants.Add(new P(tailInverse.Item1));
				denominatorK_2 = denominatorK_1;
				denominatorK_1 = denominatorK;

				denominatorK = tailInverse.Item1 * denominatorK_1 + denominatorK_2;


			}

			return denominants;

		}










	}
}
