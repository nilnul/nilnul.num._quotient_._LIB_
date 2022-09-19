using nilnul.num.quotient.op_;
using nilnul.obj;
using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.expr_.closed_.call_.binary_
{
	public class Poly
		: Binary


	{
		public Poly( ClosedI arg, nilnul.num.ExprI arg1) : base(nilnul.num.quotient.op_.binary_.Poly.Singleton, arg, arg1)
		{
		}

		public Poly(BinaryI2 op, int x, ClosedI y) : base(
nilnul.num.quotient.op_.binary_.Poly.Singleton
			, x, y)
		{
		}

		public Poly(
			obj.expr_.ClosedI<QuotientI1> arg, obj.expr_.ClosedI<QuotientI1> arg1) : base(
nilnul.num.quotient.op_.binary_.Poly.Singleton
				, arg, arg1)
		{
		}
	}
}
