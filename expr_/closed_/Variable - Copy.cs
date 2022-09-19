using nilnul.obj._expr_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.expr_.closed_
{
	public class Variable :
		nilnul.obj.Box1<nilnul.num.quotient.VarI>,
		nilnul.num.quotient.expr_.ClosedI
		,
		ClosedI_ofType
	{
		public Variable(VarI val) : base(val)
		{
		}

		public var.SetI vars => new var.Set();

		obj.var.SetI<QuotientI1> VarsI<obj.var.SetI<QuotientI1>>.vars => vars;

		public ClosedI substitute(VarI var, ClosedI expr)
		{
			if (this.boxed==var)
			{
				return expr;
			}
			return this;
			//throw new NotImplementedException();
		}

		public obj.expr_.ClosedI<QuotientI1> substitute(obj.VarI5<QuotientI1> var, obj.expr_.ClosedI<QuotientI1> expr)
		{

			if (this.boxed==var)
			{
				return expr;
			}
			return this;

		}
	}
}
