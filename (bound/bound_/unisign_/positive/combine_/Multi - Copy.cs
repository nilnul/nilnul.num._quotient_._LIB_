using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.range_.unisign_.positive.combine_
{
	static public  class _MultiX
	{
		
		public static Range1 Range(Range1 a, Range1 b) {

			return new Range1(a.lower*b.lower, a.upper*b.upper);
		}

	}
}
