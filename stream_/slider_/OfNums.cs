using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider_
{
	public  class OfNums : nilnul.obj.Box<nilnul.num.stream_.SliderI4>
		,quotient.stream_.SliderI1
	{
		public OfNums(num.stream_.SliderI4 val) : base(val)
		{
		}

		public Quotient1 current => boxed.current;

		public void moveNext()
		{
			boxed.moveNext();
		}

		public Quotient1 next()
		{
			return boxed.next();
		}
	}


}
