using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream.slider
{
	[Obsolete()]
	public class Series1
		:
		nilnul.num.quotient.slider.Series1
	{
		public Series1(StreamI6 stream)
			:base(new Slider1(stream))
		{
		}
	}
}
