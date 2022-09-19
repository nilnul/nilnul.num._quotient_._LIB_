using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.slider_
{
	[Obsolete()]
	public class Num1 : nilnul.obj.Box<nilnul.num.SliderI2>, SliderI2
	{
		public Num1(num.SliderI2 val) : base(val)
		{
		}

		public Quotient1 current => new nilnul.num.Quotient1(  boxed.current);

		public void moveNext()
		{
			boxed.moveNext();
			//throw new NotImplementedException();
		}

	}
}
