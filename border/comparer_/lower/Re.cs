using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.border.comparer_.lower
{
	public class Re
		:nilnul.obj.comp.Re<Border2, Lower1>
	{

		static public Re Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Re>.Instance;
			}
		}


		public  bool le(Border2 lower, Q1 ext)
		{
			return    le(lower, Border2.CreateClose(ext));

			//throw new NotImplementedException();
		}
		public  bool lt(Border2 lower, Q1 ext)
		{
			return    lt(lower, Border2.CreateClose(ext));

			//throw new NotImplementedException();
		}

		public  bool gt(Border2 lower, Q1 ext)
		{
			return    gt(lower, Border2.CreateClose(ext));

			//throw new NotImplementedException();
		}
		public  bool ge(Border2 lower, Q1 ext)
		{
			return    ge(lower, Border2.CreateClose(ext));

			//throw new NotImplementedException();
		}

	}
}
