using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num
{
	static public  class QuotientX
	{
		static public Q1 ToQ(this BigInteger x) {
			return x;
		}

		static public Q1 ToClass(this QuotientI1 x) {
			if (x is Q1 q)
			{
				return q;
			}
			return new Q1( x );
		}

		static public Q1 QDiv(this BigInteger x, BigInteger y) {
			return new nilnul.num.Quotient1(x, y);//.duo_.dividable.op_._divide.Extensions.Divide(x,y);
		}

		static public Q1 QDiv(this int x, BigInteger y) {
			return new Q1(x, y);// nilnul.num.quotient.duo_.dividable.op_._divide.Extensions.Divide(x,y);
		}

		static public Q1 Inverse(this BigInteger x ) {
			return nilnul.num.Quotient1.CreateUnit(x);//.quotient_.nonzero.op_._inverse.Extensions._Inverse(x);
		}
		static public Q1 Inverse(this int x ) {
			return nilnul.num.Quotient1.CreateUnit(x);//.quotient_.nonzero.op_._inverse.Extensions._Inverse(x);
		}
		static public Q1 Poly(this Q1 radic,  BigInteger n) {

			return nilnul.num.quotient.op_.unary_.Poly.Eval(radic,n);
		}

		static public BigInteger Expand(this Q1 x)
		{

			return nilnul.num.integer.duo_.divisible.op_.divide_._expand.X._Expand(x.numerator, x.denominator);


		}

		static public BigInteger Expand(this nilnul.num.QuotientI x)
		{

			return nilnul.num.integer.duo_.divisible.op_.divide_._expand.X._Expand(x.numerator, x.denominator);


		}

		/// <summary>
		/// round to inf
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public BigInteger Expand(this nilnul.num.QuotientI1 x)
		{

			return nilnul.num.integer.duo_.divisible.op_.divide_._expand.X._Expand(x.numerator, x.denominator1);


		}

		static public nilnul.num.Quotient1 Abs(this nilnul.num.Quotient1 x)
		{

			return nilnul.num.quotient.op_.unary_.Abs.Singleton.op(x);


		}




	}
}
