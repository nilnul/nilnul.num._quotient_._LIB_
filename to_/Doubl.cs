using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.to_
{
	static public class _DblX
	{
		static public double ByCastNumDen(Q1 x) {
			return (double) x.numerator /(double) ( x.denominator1.en);
		}
		static public double ByIntegerDiv(Q1 x, int digitsAftDot=4) {
			var powed = nilnul.num.op_.binary_._PowX._Op(10, 4); 
			return  (double) ( BigInteger.Divide(x.numerator * powed, x.denominator1) / powed );
		}


	}
}
