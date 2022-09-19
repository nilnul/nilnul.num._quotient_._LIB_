using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.set.op_
{
	[Obsolete(nameof(quotient.aggregate_._ProductX))]
	static public class _ProductX
	{

		static public Q1 Product(this IEnumerable<Q1> x)
		{
			//add is associative, with zero element of zero.

			return x.Aggregate((Q1)0,
				nilnul.num.quotient.duo.op_.Add.Instance.eval

			);

		}
	}
}
