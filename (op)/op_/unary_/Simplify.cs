using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed;
using F = nilnul.num.Quotient_unsimplified;
using nilnul._num.bigint.be;

namespace nilnul.num.quotient.op_.unary_
{
	public  class _SimplifyX
	{
				


		static public F Op(F x)
		{
			var gcd1 = BigInteger.GreatestCommonDivisor(
				x._numerator
				,
				x.denominator.eeByRef
			);
			return new F(
				x._numerator/gcd1
				,
				x.denominator.eeByRef/gcd1
			);
			

		}
	}
}
