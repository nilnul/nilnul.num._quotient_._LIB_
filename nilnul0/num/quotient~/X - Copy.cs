using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.Simplified;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.op_._expand
{
	public static class X
	{

		

		static public BigInteger Expand(this Q1 x)
		{

			return nilnul.num.integer.duo_.divisible.op_.divide_._expand.X._Expand(x.numerator, x.denominator);


		}


	}
}
