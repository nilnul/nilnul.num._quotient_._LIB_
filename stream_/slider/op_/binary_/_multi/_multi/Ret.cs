using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider.duo.op_._multi
{
	public class Ret
		: Duo
		,SliderI
	{
		public Ret(SliderI a, SliderI b) : base(a, b)
		{
		}

		public Simplify.Ed1 current
		{
			get
			{
				return Item1.current * Item2.current;

			}
		}

		public void moveNext()
		{
			Item1.moveNext();
			Item2.moveNext();
		}
	}
}
