using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider.op_.binary_._div
{
	public class Ret
		: nilnul.num.quotient.slider._call.ArgArg1A

		,SliderI2
	{
		public Ret(SliderI2 a, SliderI2 b) : base(a, b)
		{
		}

		public Ret(nilnul.num.SliderI2 a, nilnul.num.SliderI2 b):this(new slider_.Num1(a), new slider_.Num1(b) )
		{

		}

		public nilnul.num.Quotient1 current
		{
			get
			{
				return nilnul.num.quotient.op_.binary_.Div1.Singleton.op( arg.current , arg1.current);

			}
		}

		public void moveNext()
		{
			arg.moveNext();
			arg1.moveNext();
		}
	}
}
