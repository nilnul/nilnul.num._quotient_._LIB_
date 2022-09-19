
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.ext.border.comparer_
{
	public partial class LowerComparer
		:

		IComparer<ext.Border1>
	{

		static public readonly LowerComparer Singleton = SingletonByDefault<LowerComparer>.Instance;

		public int Compare(Border1 x, Border1 y)
		{
			if (
				ext.comparer.Decider.Singleton.subProper(x.mark, y.mark)
				)
			{

				return -1;

			}
			else if (
				ext.comparer.Decider.Singleton.eq(x.mark,y.mark)
				
			)
			{
				if (x.openFalseCloseTrue )
				{
					if (y.openFalseCloseTrue)
					{
						return 0;
					}
					else
					{
						return -1;

					}

				}
				else
				{
					if (y.openFalseCloseTrue)
					{
						return 1;

					}
					else
					{
						return 0;
					}
				}

			}
			return 1;

			throw new NotImplementedException();
		}

		

	

		
	}
}
