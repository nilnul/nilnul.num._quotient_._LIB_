using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider.op_.binary_
{
	public class Div
		:num.quotient.stream_. slider.op_.BinaryI
	{
		public num.quotient.stream_.SliderI1 op(num.quotient.stream_.SliderI1 a, num.quotient.stream_.SliderI1 b)
		{
			return new _div.Ret(a, b);
		}


		static private Lazy<Div> _Lazy = new Lazy<Div>();
		static public Div Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
