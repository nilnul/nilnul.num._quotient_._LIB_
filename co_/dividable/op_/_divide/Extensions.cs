using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.duo_.dividable.op_._divide
{

	static public  class Extensions
	{


		static public Q1 Divide(this Q1 a, Q1 b)
		{

			return a*( nilnul.num.quotient_.nonzero.op_._inverse.Extensions._Inverse(b));

		}

		static public Q1 Inverse(this Q1 a) {
			return Divide(1, a);
		}

		

	}

}
