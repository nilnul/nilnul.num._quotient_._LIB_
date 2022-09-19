using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num.quotient.Q;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.stream._subtypeS.arithmeticoGeometic.be.rateAbsLtOne.asserted
{
	public class Sum
	{
		static public Q _Eval(ArithmeticoGeometric _rateAbsLtOne) {
			var a = _rateAbsLtOne.arithmetic.head;
			var r = _rateAbsLtOne.geometric.rate;
			var d = _rateAbsLtOne.arithmetic.diff;

			return _rateAbsLtOne.geometric.head*( a / (1 - r) + d * r / q.op.SquareX.Square(1-r));
		}
	}
}
