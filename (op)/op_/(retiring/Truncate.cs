using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.Simplified;

namespace nilnul.num.quotient.op
{
	[Obsolete()]
	public class Truncate
	{
		public BigInteger Eval(_quotient.fraction.Simplified x)
		{
			return nilnul.num.integer.Sign._Eval(
				x.fraction.sign
				,
				new op.Abs.Done(x).truncate()
			);



		}
	}
}
