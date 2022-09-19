using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;
using System.Numerics;




namespace nilnul.num.quotient.op_.unary_
{
	public class Abs
		: UnaryI
		,
		UnaryI1

	{
		public Q1 op(Q1 par)
		{
			return _AbsX.Op(par);
			//throw new NotImplementedException();
		}
		public  Quotient_unsimplified op(in Quotient_unsimplified par)
		{
			return new Quotient_unsimplified(BigInteger.Abs( par._numerator ), par._denominator);

		}

		public Quotient_unsimplified op(Quotient_unsimplified par)
		{
			return new Quotient_unsimplified(BigInteger.Abs( par._numerator ), par._denominator);
		}



		static public Abs Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Abs>.Instance;
			}
		}

		public Quotient_NonnilDenom op( in Quotient_NonnilDenom mark)
		{
			mark.standardize();

			return new Quotient_NonnilDenom(
				BigInteger.Abs(
					mark._numerator
				)
				,
				mark._denominator
			);

		}

		public Quotient_NonnilDenom op(  Quotient_NonnilDenom mark)
		{
			return op(in mark);

			

		}
	}


}
