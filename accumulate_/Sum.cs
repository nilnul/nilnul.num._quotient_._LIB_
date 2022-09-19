using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Q1 = nilnul.num.QuotientI;
using Q0 = nilnul.num.Quotient1;


namespace nilnul.num.quotient.accumulate_
{
	static public class _SumX
	{

		static public Q1 Sum(this IEnumerable<Q1> x)
		{
			//add is associative, with zero element of zero.

			return x.Aggregate(nilnul.num.Quotient.CreateZero() as nilnul.num.QuotientI,
				nilnul.num.quotient.combine_.Add.Instance.eval

			);

		}

		static public Q0 Sum(this IEnumerable<Q0> x)
		{
			//add is associative, with zero element of zero.

			return x.Aggregate(
				nilnul.num.Quotient1.CreateZero(),
				nilnul.num.quotient.op_.binary_._AddX.Op

			);

		}
	}
}
