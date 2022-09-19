using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.slider.op_.binary_
{
	public class Div
		: BinaryI
	{
		public SliderI2 op(SliderI2 a, SliderI2 b)
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
