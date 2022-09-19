using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using B = nilnul.num.quotient.Bound;


namespace nilnul.num.quotient.bound_.unisign_.positive.nulable.combine_
{
	static public  class _MultiX
	{
		public static B Bound(B a, B b) {
			if (a is null || b is null)
			{
				return null;
			}
			return positive.combine_._MultiX.Bound(a, b);
		}

	}
}
