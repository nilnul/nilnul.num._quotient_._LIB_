using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider._convert
{
	public abstract class RetA
		:
		nilnul.obj._call_.ArgA<nilnul.num.quotient.SliderI>
		,
		nilnul.num.quotient.SliderI
	{
		public RetA(SliderI arg) : base(arg)
		{
		}

		public abstract Simplify.Ed1 current
		{
			get;
		}


		public abstract void moveNext();
	}
}
