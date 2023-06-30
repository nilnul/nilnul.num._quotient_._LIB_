using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bound = nilnul.num.quotient.ext.Bound;

namespace nilnul.num.quotient.ext.bound
{
	public class Duo
		:nilnul.order.bound.Pair_TBound<num.quotient.ext.Bound>
	{
		public Duo(Bound lower, Bound upper)
			:base(lower,upper)
		{

		}

		public bool contains(_ext.ExtI x) {

			return LowerX.Contains(lower, x) && UpperX.Contains(upper, x);

		}
	}
}
