using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.ext
{
	public partial interface InfI
		:
		nilnul.num.quotient.ExtI
		,
		nilnul.ext_.InfI<Q>
	{

	}
}
