using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.border.duo.be
{
	public class En1<TBe>
		: nilnul.be.En<nilnul.num.quotient.border.Duo1, TBe>
		where TBe : nilnul.num.quotient.border.duo.BeI1, new()
	{
		public En1(Duo1 val) : base(val)
		{
		}
	}
}
