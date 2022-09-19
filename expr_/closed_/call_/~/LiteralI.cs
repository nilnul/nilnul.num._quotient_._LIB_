using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.expr_.call_
{
	public interface NaryI:nilnul.num.quotient.expr_. CallI
	{

	}

	public class Nary :
		nilnul.obj.expr_.call_.Nary<nilnul.num.Quotient1>
		,
		NaryI
	{
		public Nary(Quotient1 val) : base(val)
		{
		}

		public Nary(int val) : this(new Quotient1(val) )
		{
		}
	}
}
