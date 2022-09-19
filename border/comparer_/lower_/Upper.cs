
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.border.comparer_.lower_
{
	public partial class UpperComparer
		:

		IComparer<Border1>
	{

		static public readonly UpperComparer Singleton = SingletonByDefault<UpperComparer>.Instance;

		public int Compare(Border1 x, Border1 y)
		{
			return Lower.Singleton.Compare(-y, -x);


		}

		

	

		
	}
}
