using nilnul.num.quotient.ext.bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.ext
{
	public class Interval
		:bound.duo.be.Have.Be.Asserted
	{
		public Interval(num.quotient.ext.bound.Duo boundDuo)
			:base(boundDuo)
		{

		}
		public Interval(ext.Bound lower, ext.Bound upper)
			:this(new num.quotient.ext.bound.Duo(lower,upper))
		{

		}

		public bool contains(_ext.ExtI x) {
			return val.contains(x);
		}

		public bool contains(Q q) {
			return contains( (_ext.Base)q as _ext.ExtI  );
		}
		public bool no(_ext.ExtI x) {
			return !contains(x);
		}
	}
}
