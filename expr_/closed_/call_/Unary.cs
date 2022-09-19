using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.op_;
using nilnul.obj.op_;

namespace nilnul.num.quotient.expr_.closed_.call_
{


	public class Unary :
		nilnul.obj.expr_.closed_.call_.Unary<nilnul.num.QuotientI1>
		,
		expr_.CallI
	{
		public Unary(UnaryI<QuotientI1> op, obj.expr_.ClosedI<QuotientI1> arg) : base(op, arg)
		{
		}
	}
}
