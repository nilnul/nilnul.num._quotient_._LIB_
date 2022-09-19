using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider.op_.unary_
{
	/// <summary>
	/// make the term positive, negative alternatively
	/// </summary>
	public class Inv : UnaryI
	{
		public quotient.stream_.SliderI1 op(quotient.stream_.SliderI1 par)
		{
			return new _inv.Ret(par);
		}

		public nilnul.num.quotient.stream_.SliderI1 op(nilnul.num.stream_.SliderI4 num) {
			return op(new nilnul.num.quotient.stream_.slider_.OfNums(num));
		}

		static public Inv Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Inv>.Instance;
			}
		}

	}
}
