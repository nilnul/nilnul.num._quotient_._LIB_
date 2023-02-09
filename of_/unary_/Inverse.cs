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

	public class Inverse
		:
		quotient_.denomNonnil.of_.Unary_onAsImplA
		,

		op_.UnaryI

	{
		public Q1 op(Q1 par)
		{
			return op_.unary_. _InverseX.Op(par);
			//throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="par"></param>
		/// <returns></returns>
		/// <exception cref="">if par is nil</exception>
		public DenomNonnil op(BigInteger par)
		{
			return new DenomNonnil(1,par) ;
			//throw new NotImplementedException();
		}

		public override DenomNonnil opAsImpl(DenomNonnilI a)
		{
			return new DenomNonnil(a.denominator,a.numerator);
		}

		static public Inverse Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Inverse>.Instance;
			}
		}

	}


}
