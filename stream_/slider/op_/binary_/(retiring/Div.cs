using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.slider.op_.bi_
{
	public class Div
		: BiI
	{
		public SliderI eval(SliderI a, SliderI b)
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
