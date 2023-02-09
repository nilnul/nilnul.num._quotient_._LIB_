using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.border_.lower
{
	static public class _CompX
	{
		static public int _Comp_ifMarkEq(Border2 x, Border2 y)
		{
			if (x.openFalseCloseTrue == y.openFalseCloseTrue)
			{
				return 0;

			}
			return x.openFalseCloseTrue ? -1 : 1;

		}


		static public int Comp(Border2 x, Border2 y)
		{

			if (x.mark < y.mark)
			{
				return -1;

			}

			if (x.mark > y.mark)
			{
				return 1;
			}

			return _Comp_ifMarkEq(x, y);

		}


	
	}
}
