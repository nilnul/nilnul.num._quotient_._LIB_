using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.slider_.cumulative_
{
	public class Product : nilnul.num.quotient.slider_._cumulative.RetA
	{
		private nilnul.num.Quotient1 product = 1;
		public Product(StreamI5 arg) : base(arg)
		{
		}

		public Product(SliderI1 slider) : base(slider)
		{
		}

		public override QuotientI current => product;

		public override void moveNext()
		{
			product*=this.arg.next();
		}
	}
}
