using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.border.comparer_.upper
{
	public class Re
		:nilnul.obj.comp.Re<Border2, Upper1>
	{


		static public Re Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Re>.Instance;
			}
		}


		public  bool le(Border2 upper, Q1 ext)
		{
			return    le(upper, Border2.CreateClose(ext));

			//throw new NotImplementedException();
		}

		public bool ge(Border2 upper, Q1 ext)
		{
			return    ge(upper, Border2.CreateClose(ext));

		}

		public bool gt(Border2 upper, Q1 ext)
		{
			return    gt(upper, Border2.CreateClose(ext));

		}


	}
}
