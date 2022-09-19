using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.to
{
	public class Doubl
	{
		static public double ToDouble_castNumDen(Q1 x) {
			return (double) x.numerator /(double) x.denominator.val;
		}
	}
}
