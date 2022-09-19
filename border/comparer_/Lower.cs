using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.border.comparer_
{
	public partial class Lower
		:IComparer<Border1>
	{

		static public readonly Lower Singleton = SingletonByDefault<Lower>.Instance;

		static public int Eval(Border1 x, Border1 y)
		{

			if (x.mark < y.mark)
			{
				return -1;

			}

			if (x.mark > y.mark)
			{
				return 1;
			}

			return _Eval_ifPinpointEq(x, y);

		}

		static public int _Eval_ifPinpointEq(Border1 x, Border1 y) {
			if (x.openFalseCloseTrue==y.openFalseCloseTrue)
			{
				return 0;
				
			}
			return x.openFalseCloseTrue ? -1 : 1;

		}



		static public Border1 Min(Border1 x, Border1 y) {
			return Eval(x, y) <= 0 ? x : y;
		}

		static public Border1 Max(Border1 x, Border1 y) {
			return Eval(x, y) >= 0 ? x : y;
		}


		static public Border1 Min(IEnumerable<Border1> bounds_nonEmpty) {
			if (bounds_nonEmpty.Count()==1)
			{
				return bounds_nonEmpty.First();
			}
			return Min(bounds_nonEmpty.First(),Min(bounds_nonEmpty.Skip(1)));



		}

		static public Border1 Min(params Border1[] bounds) {
			return Min(bounds as IEnumerable<Border1>);
		}

		public int Compare(Border1 x, Border1 y)
		{
			return Eval(x, y);
			throw new NotImplementedException();
		}
	}
}
