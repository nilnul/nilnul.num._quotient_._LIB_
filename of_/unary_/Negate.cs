using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using nilnul.num.rational.op;

using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient_;

namespace nilnul.num.quotient.of_.unary_
{

	public class Neg
		:
		quotient_.denomNonnil.of_.Unary_onAsImplA
		,

		quotient.op_. UnaryI
		,
		quotient_.denomNonnil.of_.UnaryI

	{
		public Q1 op(Q1 par)
		{
			return -par;
			//throw new NotImplementedException();
		}

		public override DenomNonnil opAsImpl(DenomNonnilI a)
		{
			return new DenomNonnil(
				-a.numerator
				,
				a.denominator
			);
		}

		static public Neg Singleton
		{
			get
			{
				return nilnul.Singleton1<Neg>.Instance;
			}
		}

	}


}
