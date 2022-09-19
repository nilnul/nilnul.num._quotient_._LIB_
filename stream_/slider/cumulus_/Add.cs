using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.op_.binary_.multi;


namespace nilnul.num.quotient.stream_.slider.cumulus_
{
	public class Add
		:Cumulus_defaulted<
			nilnul.num.quotient.op_.binary_.add.Cumulator
		>
	{
		public Add(SliderI1 val) : base(val)
		{
		}
	}
}