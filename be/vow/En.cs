using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be
{
	[Obsolete()]
	public class En<TBe>
		: nilnul.vow.En<nilnul.num.Quotient1, be.Vow<TBe>>
		where TBe : nilnul.num.quotient.BeI2, new()
	{
		public En(Quotient1 val) : base(val)
		{
		}
	}
}
