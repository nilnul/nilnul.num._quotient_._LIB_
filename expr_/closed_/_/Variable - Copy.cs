using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.expr_
{
	public class Variable :
		nilnul.obj.Box<nilnul.num.quotient.Var>,
		nilnul.num.quotient.ExprI
	{
		public Variable(Var val) : base(val)
		{
		}

	}
}
