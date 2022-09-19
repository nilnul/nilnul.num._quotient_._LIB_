using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.op_;

namespace nilnul.num.quotient.expr_.call_
{


	public class Unary :
		nilnul.obj.expr_.call_.Unary<nilnul.num.Quotient1, nilnul.num.quotient.ExprI, nilnul.num.quotient.op_.UnaryI>
		,
		ExprI
	{
		public Unary(UnaryI op, ExprI arg) : base(op, arg)
		{
		}
	}
}
