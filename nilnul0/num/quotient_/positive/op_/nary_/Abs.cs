using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;
using System.Numerics;




namespace nilnul.num.quotient_.positive.op_.nary_
{
	static public class _AbsX
	{
		static public Positive1 Op(Q1 x) {
			return new Positive1(BigInteger.Abs( x.numerator), x.denominator );
		}

	}
	public class Abs
		:
		num.quotient._calc.Arg
		,
		num.quotient_.positive.op_.NaryI

	{
		public Abs(Q1 arg) : base(arg)
		{
		}

	

		public Positive1 op()
		{
			return _AbsX.Op(this.arg);
		}


		


	}


}
