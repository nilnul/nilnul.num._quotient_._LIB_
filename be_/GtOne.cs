using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.be_
{

	public partial class GtOne1
			: nilnul.be.Be_froFunc<Q1>
		,
		nilnul.num.quotient.BeI3
		,
		nilnul.num.quotient.BeI4

	{
		static public bool Be(
			Q1 x
		)
		{
			return x > 1;

		}

		public bool be(QuotientI obj)
		{
			return Be(new Q1(obj));
		}

		public GtOne1()
			: base(Be)
		{

		}














	}



}
