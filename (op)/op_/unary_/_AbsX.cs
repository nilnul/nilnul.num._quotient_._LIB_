using Q1 = nilnul.num.Quotient1;
using System.Numerics;




namespace nilnul.num.quotient.op_.unary_
{
	static public class _AbsX
	{
		static public Q1 Op(Q1 x) {
			return new Q1(BigInteger.Abs( x.numerator), x.denominator );
		}

	}


}
