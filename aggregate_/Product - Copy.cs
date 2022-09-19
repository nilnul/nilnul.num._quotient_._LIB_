using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.aggregate_
{
	static public  class _ProductX
	{
		
		static public Q1 Product(this IEnumerable<Q1> x) {

			return x.Aggregate((Q1)1, 
				nilnul.num.quotient.combine_.Multiply.Instance.eval

		);
		
		}
	}
}
