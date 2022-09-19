using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.border_
{
	public class Open : nilnul.obj.Box1<nilnul.num.Quotient1>
		, nilnul.num.quotient.BorderI
	{
		public Quotient1 mark => boxed;

		public bool openFalseCloseTrue => false;

		public Open(Quotient1 val) : base(val)
		{
		}
		public Open() : this(new Quotient1())
		{

		}
		static public implicit operator nilnul.num.quotient.Border2(Open closed)
		{
			return Border2.CreateOpen(closed.mark);
		}
	}
}
