using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num.Quotient;

namespace nilnul.num.quotient_.nonnil.op_.unary_
{
	static public  class _InverseX
	{

		

		static public Nonnil1 Op(this nilnul.num.quotient_.Nonnil1 r) {

			return new Nonnil1 (r.denominator1, r.numerator);
		
		}

		static public Nonnil Op(this nilnul.num.quotient_.Nonnil r) {

			return new Nonnil (r.denominator, r.numerator);
		
		}

		public static Quotient1 Op(Quotient1 mark)
		{
			return Op( new Nonnil(mark));

		}

		static public Quotient1 Op(BigInteger x) {
			return  Quotient1.CreateUnit(x);
		}
	}
}
