using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.slider.window_
{
	public class Two : nilnul.obj.Box<nilnul.num.quotient.SliderI1>
		,SliderI1
	{
		private nilnul.num.QuotientI _prev;
		public nilnul.num.QuotientI prev { get { return _prev; } }

		public QuotientI current => boxed.current;

		public Two(SliderI1 val) : base(val)
		{
			moveNext();

		}

		public void moveNext()
		{
			_prev = boxed.current;
			boxed.moveNext();
		
		}
	}
}
