using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border_;

namespace nilnul.num.quotient._bound.lower_
{
	public class Closed :
		//nilnul.obj.Box<
			num.quotient.border_.Closed
		//>
		,
		_bound.LowerI
	{
		public Closed(border_.Closed val) : base(val)
		{
		}
		public Closed(nilnul.num.Quotient1 mark):this(new border_.Closed(mark))
		{

		}
		public Closed():this(0)
		{

		}
	}
}
