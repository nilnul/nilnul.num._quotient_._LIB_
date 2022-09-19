using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_
{
	[Obsolete()]
	public  class Slider : nilnul.obj.Box< nilnul.num.quotient.SliderI1>, nilnul.num.quotient.StreamI5
	{
		public Slider(quotient.SliderI1 val) : base(val)
		{
		}

		public QuotientI next()
		{

			var old = boxed.current;
			boxed.moveNext();
			return old;
		}
	}
}
