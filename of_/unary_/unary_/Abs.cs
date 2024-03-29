﻿using System;
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
	}


}
