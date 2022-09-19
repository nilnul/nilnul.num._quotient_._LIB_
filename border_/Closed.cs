using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.border_
{
	public class Closed : nilnul.obj.Box<nilnul.num.Quotient1>
		, nilnul.num.quotient.BorderI
	{
		public Quotient1 mark => boxed;

		public bool openFalseCloseTrue => true;

		public Closed(Quotient1 val) : base(val)
		{
		}
		public Closed() : this(new Quotient1())
		{

		}
		static public implicit operator nilnul.num.quotient.Border2(Closed closed)
		{
			return Border2.CreateClose(closed.mark);
		}
	}
}
