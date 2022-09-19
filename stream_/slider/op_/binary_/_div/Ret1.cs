using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.stream_.slider.op_.binary_._div
{
	public class Ret
		: nilnul.num.quotient.stream_.slider._calc.ArgArg1A

		,num.quotient.stream_.SliderI1
	{
		public Ret(num.quotient.stream_.SliderI1 a, num.quotient.stream_.SliderI1 b) : base(a, b)
		{
		}

		public Ret(nilnul.num.stream_.SliderI4 a, nilnul.num.stream_.SliderI4 b) :this(new slider_.OfNums(a), new slider_.OfNums(b) )
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

		public Quotient1 next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}
	}
}
