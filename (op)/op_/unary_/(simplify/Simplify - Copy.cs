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
	[Obsolete()]
	public  class _SimplifyX
	{
				


		static public F Op(F x)
		{
			var gcd =new num_.Positive( nilnul.num.integer.duo._GcdX.Num(x.numerator, x.denominator.en));
			return new F(
				nilnul.num.integer.duo_.divisible.div_._TruncateX.Truncate(x.numerator, gcd)
				,
				 nilnul.num.integer.duo_.divisible.div_._TruncateX.Truncate(x.denominator, gcd)
			);

		}
	}
}
