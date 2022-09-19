using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.range.vow
{
	public class En<TVow> : nilnul.obj.vow.En<nilnul.num.quotient.Range1, TVow>
		where TVow : VowI, new()
	{
		public En(Range1 val) : base(val)
		{
		}
	}
}
