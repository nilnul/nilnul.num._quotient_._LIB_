using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider.op_.binary_.multi
{
	public class Cumulator
		:
		nilnul.obj.op_.binary.Accumulator_opDefault<nilnul.num.quotient.stream_.SliderI1, nilnul.num.quotient.stream_.slider.op_.binary_.Multi>
	{
		public Cumulator() : base(new nilnul.num.quotient.stream_.slider_.Repeater(1) )
		{
		}
	}
}
