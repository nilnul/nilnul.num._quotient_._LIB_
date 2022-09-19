using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.slider.duo.merge_
{
	public class Div
		: MergeI
	{
		

		public SliderI merge(SliderI a, SliderI b)
		{
			return new _div.Ret(a, b);
			//throw new NotImplementedException();
		}
	}
}
