using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.comparer
{
	public class Re1
		:nilnul.obj.comp.Re<Q1,quotient.Comparer2>
	{



		static public Re1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Re1>.Instance;
			}
		}


	}
}
