using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.border_.upper.op_.binary_
{
	static public  class _MaxX
	{
		


		static public Border2 Max(Border2 x, Border2 y)
		{
			return _CompX.Comp(x, y) >= 0 ? x : y;
		}


	}
}
