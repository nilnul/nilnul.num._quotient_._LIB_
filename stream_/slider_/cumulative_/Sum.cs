using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider_.cumulative_
{
	public class Sum : nilnul.num.quotient.slider_._cumulative.RetA
	{
		private nilnul.num.Quotient1 sum = 0;
		public Sum(StreamI5 arg) : base(arg)
		{
		}

		public Sum(SliderI1 slider) : base(slider)
		{
		}

		public override QuotientI current => sum;

		public override void moveNext()
		{
			sum+=this.arg.next();
		}
	}
}
