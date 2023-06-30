using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num.quotient.Q;
using i = nilnul.num.integer;
using n = nilnul.num;

namespace nilnul.num.quotient.be.nonNeg.asserted
{
	static public class _Root
	{
		static public BigInteger _Eval_floor(Q _nonNeg,BigInteger _positive) {

			return  n.op.Root._Eval_natural(_nonNeg.toInt(), _positive);

		}
		static public BigInteger _Eval_ceil(Q _nonNeg,BigInteger _positive) {

			return  n.op.Root._Eval_ceil_natural(_nonNeg.toInt(), _positive);


		}


	}
}
