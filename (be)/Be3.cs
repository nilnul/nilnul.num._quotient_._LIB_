using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient
{
	[Obsolete("usiing "+nameof(nilnul.num.quotient)+"."+nameof(BeI2))]
	public interface BeI3
		:
		nilnul.obj.BeI1<Q1>
		,
		nilnul.obj.BeI1<nilnul.num.QuotientI>

	{

	}
}
