using nilnul.obj._expr_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.expr_.closed_.call_
{
	public interface NaryI:nilnul.num.quotient.expr_.closed_.CallI
	{

	}

	public class Nary :
		nilnul.obj.expr_.closed_.call_.Nary<nilnul.num.QuotientI1>
		,
		NaryI
	{
		public Nary(obj.op_.NaryI<QuotientI1> op) : base(op)
		{
		}

		public Nary(QuotientI1 literal) : base(literal)
		{
		}

		public Nary(int val) : this(new Quotient1(val))
		{
		}
	}

}
