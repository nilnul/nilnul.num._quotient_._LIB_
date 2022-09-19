using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border_;

namespace nilnul.num.quotient._bound.upper_
{

	public class Open :
		nilnul.obj.Box1<
			num.quotient.border_.Open
		>
		,
		_bound.UpperI
	{
		public Quotient1 mark => boxed.mark;

		public bool openFalseCloseTrue => false;

		public Open(border_.Open val) : base(val)
		{
		}
		public Open(nilnul.num.Quotient1 mark):this(new border_.Open(mark))
		{

		}
		public Open():this(0)
		{

		}
	}
}
