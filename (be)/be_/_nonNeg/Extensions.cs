using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.be_._nonNeg
{
	public static class Extensions
	{
		static public bool Nonneg(this Q1 q ) {
			return q.numerator >= 0;
		}
	}
}
