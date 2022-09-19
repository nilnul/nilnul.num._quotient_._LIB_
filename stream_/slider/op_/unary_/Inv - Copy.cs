using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.slider.op_.unary_
{
	/// <summary>
	/// make the term positive, negative alternatively
	/// </summary>
	public class Inv : UnaryI
	{
		public SliderI2 op(SliderI2 par)
		{
			return new _inv.Ret(par);
		}

		public SliderI2 op(nilnul.num.SliderI2 num) {
			return op(new nilnul.num.quotient.slider_.Num1(num));
		}

		static public Inv Singleton
		{
			get
			{
				return nilnul.Singleton1<Inv>.Instance;
			}
		}

	}
}
