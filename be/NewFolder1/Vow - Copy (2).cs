using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be
{
	[Obsolete()]
	public class Vow<TBe>
		:nilnul.be.Vow<nilnul.num.Quotient1, TBe>
		,
		nilnul.num.quotient.VowI
		where TBe:nilnul.num.quotient.BeI2,new()
	{
	}
}
