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
	static public class _DenomPositveX
	{

		static public Frac Frac(Frac x)
		{

			if (x.denominator<0)
			{
				return x;
			}

			return new F(-x.numerator, -x.denominator);

		}
	}
}
