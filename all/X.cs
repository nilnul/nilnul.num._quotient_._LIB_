using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.all
{
	static public class X
	{
		static public Q1 ToQ(this BigInteger x) {
			return x;
		}

		static public Q1 QDiv(this BigInteger x, BigInteger y) {
			return nilnul.num.quotient.duo_.dividable.op_._divide.Extensions.Divide(x,y);
		}

		static public Q1 QDiv(this int x, BigInteger y) {
			return nilnul.num.quotient.duo_.dividable.op_._divide.Extensions.Divide(x,y);
		}

		static public Q1 Inverse(this BigInteger x ) {
			return nilnul.num.quotient_.nonzero.op_._inverse.Extensions._Inverse(x);
		}
		static public Q1 Inverse(this int x ) {
			return nilnul.num.quotient_.nonzero.op_._inverse.Extensions._Inverse(x);
		}
		static public Q1 Poly(this Q1 radic,  BigInteger n) {

			return nilnul.num.quotient.op_.Poly.Eval(radic,n);
		}


	}
}
