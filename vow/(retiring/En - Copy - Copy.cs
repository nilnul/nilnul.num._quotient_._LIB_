using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;


namespace nilnul.num.quotient.vow
{
	[Obsolete()]
	public class En2<TVow> :
		nilnul.obj.vow.En<QuotientI, TVow>
		where TVow : nilnul.num.quotient.VowI1, new()
	{
		public En2(nilnul.num.QuotientI val) : base(val)
		{
		}
		public En2(nilnul.num.Quotient1 val) : this( (nilnul.num.QuotientI)(val))
		{
		}

	}
}
