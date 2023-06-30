using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.ext.border.comparer_.upper
{
	public partial class LowerComparer
		:

		IComparer<ext.Border1>
	{
		public int Compare(Border1 x, Border1 y)
		{
			return UpperComparer.Singleton.Compare(-y,-x);

		}

		

	

		
	}
}
