using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.quotient_.nonzero.op_._inverse
{

	public static class Extensions
	{
		
			static public Q1 _Inverse(this Q1 q) {
				return new Q1(q.denominator, q.numerator);
			}

			static public Q1 _Inverse(this N q) {
				return new Q1(1,q);
			}
			static public num.quotient.be_.Positive1.En  _Inverse(this nilnul._num.bigint.be.Positive.Asserted q) {
				return  new quotient.be_.Positive1.En(  new Q1(1, q.val ));
			}



		
	}
}
