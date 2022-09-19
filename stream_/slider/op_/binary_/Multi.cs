using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider.op_.binary_
{
	public class Multi
		: num.quotient.stream_.slider.op_.BinaryI
	{
		public num.quotient.stream_.SliderI1 op(num.quotient.stream_.SliderI1 a, num.quotient.stream_.SliderI1 b)
		{
			return new _multi.Ret(a, b);
		}


		static private Lazy<Multi> _Lazy = new Lazy<Multi>();
		static public Multi Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
