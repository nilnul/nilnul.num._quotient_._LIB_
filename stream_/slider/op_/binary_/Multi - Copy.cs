using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.slider.duo.op_
{
	public class Multi
		: OpI
	{
		public SliderI eval(SliderI a, SliderI b)
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
