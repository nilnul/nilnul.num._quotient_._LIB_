using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.bound_.unisign_.positive.combine_
{
	static public  class _MultiX
	{
		
		public static Bound Bound(Bound a, Bound b) {

			return new Bound(a.lower*b.lower, a.upper*b.upper);
		}

	}
}
