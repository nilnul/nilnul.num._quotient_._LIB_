using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.op_
{
	public interface NaryI
		:nilnul.op_.NaryI<nilnul.num.Quotient1>
	{
	}
	public class Nary : nilnul.op_.Nary<nilnul.num.Quotient1>, NaryI
	{
		public Nary(Quotient1 ret) : base(ret)
		{
		}
	}
}
