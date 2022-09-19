using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.border._comparer
{
	public  class Upper
		:IComparer<bool>
	{

		


		public int Compare(bool x, bool y)
		{
			if (x==y)
			{
				return 0;
				
			}
			return x ? 1 : -1;


		}

		static public readonly Upper Singleton = SingletonByDefault<Upper>.Instance;

	}
}
