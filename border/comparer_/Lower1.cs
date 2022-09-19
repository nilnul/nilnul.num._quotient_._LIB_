using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.border.comparer_
{
	[Obsolete(nameof(border_.lower._CompX))]
	public  class Lower1
		:IComparer<Border2>
	{


		static public int Eval(Border2 x, Border2 y)
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

		static public int _Eval_ifPinpointEq(Border2 x, Border2 y) {
			if (x.openFalseCloseTrue==y.openFalseCloseTrue)
			{
				return 0;
				
			}
			return x.openFalseCloseTrue ? -1 : 1;

		}



		static public Border2 Min(Border2 x, Border2 y) {
			return Eval(x, y) <= 0 ? x : y;
		}

		static public Border2 Max(Border2 x, Border2 y) {
			return Eval(x, y) >= 0 ? x : y;
		}


		static public Border2 Min(IEnumerable<Border2> bounds_nonEmpty) {
			if (bounds_nonEmpty.Count()==1)
			{
				return bounds_nonEmpty.First();
			}
			return Min(bounds_nonEmpty.First(),Min(bounds_nonEmpty.Skip(1)));



		}

		static public Border2 Min(params Border2[] bounds) {
			return Min(bounds as IEnumerable<Border2>);
		}

		public int Compare(Border2 x, Border2 y)
		{
			return Eval(x, y);
			throw new NotImplementedException();
		}


		static public Lower1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Lower1>.Instance;
			}
		}

	}
}
