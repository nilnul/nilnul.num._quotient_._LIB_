using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;
using System.Numerics;
using nilnul.num.quotient_;

namespace nilnul.num.quotient.of_.unary_
{
	public class Abs
		:
		op_.UnaryI
		,
		op_.UnaryI1
		,
		quotient_.denomNonnil.of_.UnaryI

	{
		public Q1 op(Q1 par)
		{
			return op_.unary_._AbsX.Op(par);
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

		public quotient_.DenomNonnil op( in quotient_.DenomNonnil mark)
		{
			mark.fracize();

			return new quotient_.DenomNonnil(
				BigInteger.Abs(
					mark._numerator
				)
				,
				mark._denominator
			);

		}

		public quotient_.DenomNonnil op(  quotient_.DenomNonnil mark)
		{
			return op(in mark);

			

		}
		public DenomNonnil opAsImpl(DenomNonnilI x)
		{
			return new quotient_.DenomNonnil(BigInteger.Abs(x.numerator), BigInteger.Abs(x.denominator));

		}

		public DenomNonnilI op(DenomNonnilI par)
		{
			return opAsImpl(par);
		}
	}


}
