using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.Simplified;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.op_._truncate
{
	public static class X
	{

		static public Tuple<BigInteger, Q1> Truncate_retTuple(this Q1 x)
		{

			var t = integer.duo_.divisible.op_.divide_._TruncateX.Eval__retTuple(
				x.numerator
				,
				x.denominator
			);

			return new Tuple<BigInteger, Q1>(
				t.Item1
				,
				t.Item2 / x.denominator
			);


		}

		static public BigInteger Truncate(this Q1 x)
		{

			return nilnul.num.integer.duo_.divisible.op_.divide_._TruncateX.Truncate(x.numerator, x.denominator);


		}


	}
}
