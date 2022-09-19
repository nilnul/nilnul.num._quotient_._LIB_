using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider.op_.bi_._div
{
	public class Ret1
		: nilnul.num.quotient.slider.op_._bi.RetA1

		,SliderI1
	{
		public Ret1(SliderI1 a, SliderI1 b) : base(a, b)
		{
		}

		public Ret1(nilnul.num.SliderI1 a, nilnul.num.SliderI1 b):this(new slider_.Num(a), new slider_.Num(b) )
		{

		}

		public nilnul.num.QuotientI current
		{
			get
			{
				return nilnul.num.quotient.op_.binary_.Div.Singleton.op( arg.current , arg1.current);

			}
		}

		public void moveNext()
		{
			arg.moveNext();
			arg1.moveNext();
		}
	}
}
