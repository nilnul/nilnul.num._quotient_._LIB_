using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.slider_
{
	[Obsolete()]
	public class Num : nilnul.obj.Box<nilnul.num.SliderI1>, SliderI1
	{
		public Num(num.SliderI1 val) : base(val)
		{
		}

		public QuotientI current => new nilnul.num.Quotient1(  boxed.current);

		public void moveNext()
		{
			boxed.moveNext();
			//throw new NotImplementedException();
		}

	}
}
