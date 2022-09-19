using nilnul.obj._expr_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.expr_.closed_
{
	public class Variable :
		nilnul.obj.expr_.closed_.Variable< nilnul.num.QuotientI1>
		,
		ClosedI
	{
		public Variable(VarI val) : base(val)
		{
		}

		public Variable(obj.VarI6<QuotientI1> val) : base(val)
		{
		}
	}
}
