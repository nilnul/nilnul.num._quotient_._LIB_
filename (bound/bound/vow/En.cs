using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.bound.vow
{
	public class En<TVow> : nilnul.obj.vow.En<nilnul.num.quotient.Bound, TVow>
		where TVow : VowI, new()
	{
		public En(Bound val) : base(val)
		{
		}
	}
}
