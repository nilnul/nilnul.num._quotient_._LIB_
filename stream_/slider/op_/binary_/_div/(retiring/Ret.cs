using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider.op_.bi_._div
{
	[Obsolete()]
	public class Ret
		: nilnul.num.quotient.slider.op_._bi.RetA

		,SliderI
	{
		public Ret(SliderI a, SliderI b) : base(a, b)
		{
		}

		

		public Simplify.Ed1 current
		{
			get
			{
				return arg.current / arg1.current;

			}
		}

		public void moveNext()
		{
			arg.moveNext();
			arg1.moveNext();
		}
	}
}
