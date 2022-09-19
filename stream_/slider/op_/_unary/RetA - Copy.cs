using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider.op_._unary
{
	public abstract class RetA
		:
		nilnul.obj._call_.ArgA<nilnul.num.quotient.SliderI1>
		,
		nilnul.num.quotient.SliderI1
	{
		public RetA(SliderI1 arg) : base(arg)
		{
		}

		public abstract nilnul.num.QuotientI current
		{
			get;
		}


		public abstract void moveNext();
	}
}
