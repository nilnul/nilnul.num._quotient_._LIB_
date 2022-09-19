using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed;

namespace nilnul.num.quotient.duo.op
{
	[Obsolete()]
	public class Multi
	{
		static public _quotient.fraction.op.Simplify.Ed Eval(bool sign, _quotient.fraction.op.Simplify.Ed x) {
			return sign ? x : -x;
		}
	}
}
