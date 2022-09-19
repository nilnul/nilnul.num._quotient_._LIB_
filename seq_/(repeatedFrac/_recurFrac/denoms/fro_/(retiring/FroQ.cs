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
using System.Numerics;

namespace nilnul.num.quotient._continuedFrac.simpleProper
{
	
	public class _FroQX
	{


		static public List<BigInteger> FroQ(
			Q1 r__0_til_1
		)
		{
			var denominants = new List<BigInteger>();
			while (r__0_til_1 != 0)
			{
				r__0_til_1 = 1 / r__0_til_1;
				var intProper = r__0_til_1.ToFloored();
				denominants.Add(intProper.floor);
				r__0_til_1 = intProper.tail.val;
			}
			return denominants;
		}












	}
}
