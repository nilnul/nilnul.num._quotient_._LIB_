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
	static public class _Sqrt
	{
		static public BigInteger _Eval_floor(Q _nonNeg) {

			return  n.op.SqrtX._Eval_ofNatural_retFloor(_nonNeg.toInt());

		}
		static public BigInteger _Eval_ceil(Q _nonNeg) {

			return  n.op.SqrtX._Eval_ofNatural_retCeil(_nonNeg.toInt());

		}


	}
}
