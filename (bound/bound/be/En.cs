using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border.duo.be_;
using R1 = nilnul.num.quotient.border.duo.be_.Nonempty.En
;

namespace nilnul.num.quotient.range.be
{
	public class En<TBe>
		: nilnul.be.Asserted<R1, TBe>

		where TBe : range.BeI, new()
	{
		public En(R1 val) : base(val)
		{
		}
	}
}
