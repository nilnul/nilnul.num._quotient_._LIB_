
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.ext.border.comparer_.lower
{
	public partial class UpperComparer
		:

		IComparer<ext.Border1>
	{

		static public readonly UpperComparer Singleton = SingletonByDefault<UpperComparer>.Instance;

		public int Compare(Border1 x, Border1 y)
		{
			return LowerComparer.Singleton.Compare(-y, -x);


		}

		

	

		
	}
}
