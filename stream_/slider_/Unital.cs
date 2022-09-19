using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.stream_.slider_.constant_.one.subsume_;

namespace nilnul.num.quotient.stream_.slider_
{
	public class Unital : nilnul.obj.Box<nilnul.num.stream_.slider_.constant_.one.subsume_.Add>
		,
		quotient.stream_.SliderI1
	{
		public Unital() : base(new Add())
		{
		}

		public Quotient1 current => Quotient1.CreateUnit(boxed.current);// boxed.current;

		public void moveNext()
		{
			boxed.moveNext();
			//throw new NotImplementedException();
		}

		public Quotient1 next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}
	}
}
