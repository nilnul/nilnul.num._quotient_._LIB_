using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.ext.bound
{
	static public partial class UpperX
	{
		static public bool Contains(this Bound bound, _ext.ExtI x) {
			if (ext.Comparer.Lt(x,bound.pinpoint))
			{
				return true;

			}
			if (ext.Comparer.Eq(x,bound.pinpoint))
			{
				return bound.openFalseCloseTrue;
			}
			return false;
		}

	}
}
