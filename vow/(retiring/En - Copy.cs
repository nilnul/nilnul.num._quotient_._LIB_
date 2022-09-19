using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;


namespace nilnul.num.quotient.vow
{
	[Obsolete()]
	public class En1<TVow> :
		nilnul.obj.vow.En<Q1, TVow>
		where TVow : nilnul.num.quotient.VowI1, new()
	{
		public En1(Q1 val) : base(val)
		{
		}
		public En1(nilnul.num.QuotientI val) : this( new Q1(val))
		{
		}

	}
}
