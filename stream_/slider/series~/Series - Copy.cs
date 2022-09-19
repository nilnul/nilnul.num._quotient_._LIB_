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
	public class Series
		:
		nilnul.num.quotient.slider.Series
	{
		

		

		public Series(StreamI3 stream)
			:base(new Slider(stream))
		{

			
		}

	
	}
}
