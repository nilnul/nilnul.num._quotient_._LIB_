using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed;
using F = nilnul.num._quotient.Frac;
using nilnul._num.bigint.be;

namespace nilnul.num._quotient.frac.convert_
{
	static public class _StandizeX
	{
		static public Frac _OfDenomPositive(Frac x)
		{
			var gcd = nilnul.num.integer.duo._GcdX.Num(x.numerator, x.denominator);
			return new Frac(
				nilnul.num.integer.duo_.divisible.div_._TruncateX.Truncate(x.numerator, gcd)
				,
				nilnul.num.integer.duo_.divisible.div_._TruncateX.Truncate(
					x.denominator, gcd
				)
			);
		}

		static public Frac Frac(Frac x)
		{
			return _OfDenomPositive(
				_DenomPositveX.Frac(x)
			);
		}
	}
}