using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.slider
{
	[Obsolete()]
	public class Stream
		:nilnul.slider.Stream<Q1>
		,
		StreamI3
	{
		public Stream(SliderI s):base(s)
		{

		}
	}
}
