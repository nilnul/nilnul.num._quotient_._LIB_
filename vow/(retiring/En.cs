using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;


namespace nilnul.num.quotient.vow
{
	[Obsolete()]
	public class En<TVow> :
		nilnul.vow.En<Q1, TVow>
		where TVow : nilnul.num.quotient.VowI, new()
	{
		public En(Q1 val) : base(val)
		{
		}
	}
}
