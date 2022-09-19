using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.fro_.dbl_
{
	public class ContinuedFrac
	{
		static public Q1 Eval(double x, nilnul.num_.Positive _precision_denominator) {

			return nilnul.num.quotient.continuedFrac.to_.Quotient.Singleton.to(
				nilnul.num.quotient.continuedFrac.fro_.Ieee.Fro(x, _precision_denominator)
				
			);
		}
		static public Q1 Eval(double x, int _precision_denominator) {

			return Eval(
				x
				,
				new nilnul.num_.Positive(_precision_denominator)
			);
		}


	}
}
